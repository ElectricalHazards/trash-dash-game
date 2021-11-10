using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trash_Dash.Objects
{
    class Object
    {
        private Vector2 position;
        private Texture2D texture;

        public Object(Vector2 pos, Texture2D tex)
        {
            position = pos;
            texture = tex;
        }
    }   
}
