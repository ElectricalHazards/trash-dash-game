using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trash_Dash.Game.Objects
{
    public class Entity : Object
    {
        protected Vector2 Velocity;

        public Entity(Vector2 pos, Texture2D tex) : base(pos, tex){ 
        
        }
       
    }
}
