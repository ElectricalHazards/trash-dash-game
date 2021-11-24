using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using Trash_Dash;
using Trash_Dash.Game;
using Trash_Dash.Game.Entities;
namespace Trash_Dash
{
    public class TrashGame : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D debugSquare;
        private Texture2D playerTex;
        static public Texture2D trashTex;
        static public Texture2D fishTex;
        private Texture2D boarderTex;

        public Player player;
        public TrashGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.AllowUserResizing = false;
            IsFixedTimeStep = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            debugSquare = new Texture2D(GraphicsDevice, 1, 1);
            debugSquare.SetData(new[] { Color.White });
            playerTex = Content.Load<Texture2D>("player");
            trashTex = Content.Load<Texture2D>("trash");
            boarderTex = Content.Load<Texture2D>("boarder");
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Player(new Vector2(GameUtils.PLAYER_X_LOCK, _spriteBatch.GraphicsDevice.Viewport.Height / 2), playerTex);
            

            // TODO: use this.Content to load your game content here
        }
        Vector2 lastPos = Vector2.Zero;
        int cursorCounter = 0;
        float boarderPos = 0;
        protected override void Update(GameTime gameTime)
        {
            GameUtils.DELTA_TIME = (float)gameTime.ElapsedGameTime.TotalSeconds;

            // TODO: Add your update logic here
            player.Update(gameTime);
            Vector2 currentPos = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
            if (currentPos == lastPos) {
                cursorCounter++;
            }
            else {
                lastPos = currentPos;
                cursorCounter = 0;
            }
            IsMouseVisible = !(cursorCounter > 100);
            boarderPos += 1;
            if (boarderPos > _spriteBatch.GraphicsDevice.Viewport.Height-60) {
                boarderPos = 0;
            }
            SpawnableController.Update(_spriteBatch, gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            player.Draw(_spriteBatch);
            SpawnableController.Draw(_spriteBatch);
            _spriteBatch.Draw(boarderTex, new Rectangle(0, 0+(int)boarderPos, GameUtils.BOARDER_X_POS, _spriteBatch.GraphicsDevice.Viewport.Height),Color.White);
            _spriteBatch.Draw(boarderTex, new Rectangle(0, (-_spriteBatch.GraphicsDevice.Viewport.Height+60) + (int)boarderPos, GameUtils.BOARDER_X_POS, _spriteBatch.GraphicsDevice.Viewport.Height), Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
