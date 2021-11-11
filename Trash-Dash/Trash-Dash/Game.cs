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



        public Player player;
        public TrashGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            debugSquare = new Texture2D(GraphicsDevice, 1, 1);
            debugSquare.SetData(new[] { Color.White });
            player = new Player(new Vector2(GameUtils.PLAYER_X_LOCK, _spriteBatch.GraphicsDevice.Viewport.Height/2), debugSquare);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            GameUtils.DELTA_TIME = (float)gameTime.ElapsedGameTime.TotalSeconds;
            // TODO: Add your update logic here
            player.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            player.Draw(_spriteBatch);

            // TODO: Add your drawing code here
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
