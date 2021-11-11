using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trash_Dash.Game.Objects
{
    public class Object : IObject
    {
        protected Vector2 position;
        protected Texture2D texture;

        public Object(){ }
        public Object(Vector2 pos, Texture2D tex){
            position = pos;
            texture = tex;
        }

        public new void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 3, 3), Color.White);
        }
    }   
}
