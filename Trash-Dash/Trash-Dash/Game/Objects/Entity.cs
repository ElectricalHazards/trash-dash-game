using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Trash_Dash;
using System.Text;

namespace Trash_Dash.Game.Objects
{
    public class Entity : Object
    {
        public Vector2 velocity;

        public Entity() { }
        public Entity(Vector2 pos, Texture2D tex) : base(pos, tex){
         
        }
        public new void Update(GameTime gameTime){
            position.X += velocity.X * GameUtils.DELTA_TIME;
            position.Y += velocity.Y * GameUtils.DELTA_TIME;

            velocity.X /= 1.1f;
            velocity.Y /= 1.1f;
        }
    }
}
