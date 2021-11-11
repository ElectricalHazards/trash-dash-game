using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Trash_Dash.Game.Objects;

namespace Trash_Dash.Game.Entities
{
    class Player : Entity {
        public Player() { }
        public Player(Vector2 pos, Texture2D tex) : base(pos, tex){

        }
    }
}
