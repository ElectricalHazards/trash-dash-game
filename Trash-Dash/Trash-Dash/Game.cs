using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Trash_Dash;
using Trash_Dash.Game.Entities;
namespace Trash_Dash
{
    public class TrashGame : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D debugSquare;
        private Texture2D playerTex;
        private Texture2D trashTex;
        private Texture2D fishTex;
        Trash trash;


        public Player player;
        public TrashGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.AllowUserResizing = true;

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
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Player(new Vector2(GameUtils.PLAYER_X_LOCK, _spriteBatch.GraphicsDevice.Viewport.Height / 2), playerTex);
            trash = new Trash(new Vector2(_spriteBatch.GraphicsDevice.Viewport.Width + 10, _spriteBatch.GraphicsDevice.Viewport.Height / 2), trashTex);

            // TODO: use this.Content to load your game content here
        }
        Vector2 lastPos = Vector2.Zero;
        int counter = 0;
        protected override void Update(GameTime gameTime)
        {
            GameUtils.DELTA_TIME = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            // TODO: Add your update logic here
            player.Update(gameTime);
            trash.Update(gameTime);
            Vector2 currentPos = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
            if (currentPos == lastPos) {
                counter++;
            }
            else {
                lastPos = currentPos;
                counter = 0;
            }
            IsMouseVisible = !(counter > 100);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            player.Draw(_spriteBatch);
            trash.Draw(_spriteBatch);

            // TODO: Add your drawing code here
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
