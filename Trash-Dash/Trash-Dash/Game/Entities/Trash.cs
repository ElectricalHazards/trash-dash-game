using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trash_Dash.Game.Entities
{
    public class Trash : Spawnable
    {

        public Trash(Vector2 pos, Texture2D tex) : base(pos, tex)
        {
            scalingFactor = 25;
        }
    }
}
