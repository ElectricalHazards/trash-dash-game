using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Trash_Dash.Game.Objects;

namespace Trash_Dash.Game.Entities
{
    public class Spawnable : Entity
    {

        public Spawnable() { }
        public Spawnable(Vector2 pos, Texture2D tex) : base(pos, tex){
            
        }
        public void Update(GameTime gameTime){

            velocity.X = 25;
            base.Update(gameTime);
        }
    }
}
