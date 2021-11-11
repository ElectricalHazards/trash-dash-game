using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using Trash_Dash.Game.Objects;

namespace Trash_Dash.Game.Entities
{
    public class Player : Entity {
        public Player() { }
        public Player(Vector2 pos, Texture2D tex) : base(pos, tex){

        }
        public new void Update(GameTime _gameTime) {
            if (Keyboard.GetState().IsKeyDown(Keys.Up)) {
                velocity.Y = -100.0f * GameUtils.GAME_SPEED;
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.Down)) {
                velocity.Y = 100.0f * GameUtils.GAME_SPEED;
            }
            base.Update(_gameTime);
        }
    }
}
