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



        private Spawnable test;
        bool flag = false;
        public TrashGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
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
            test = new Spawnable(new Vector2(100, 100), debugSquare);
            flag = true;

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            GameUtils.DELTA_TIME = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                test.velocity.X = 25.0f;

            // TODO: Add your update logic here
            test.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            test.Draw(_spriteBatch);

            // TODO: Add your drawing code here
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
