using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trash_Dash.Game.Entities
{
    public class Trash : Spawnable
    {

        public bool isDead = false;

        public Trash(Vector2 pos, Texture2D tex) : base(pos, tex)
        {
            scalingFactor = 25;
        }

        public new void Update(GameTime _gameTime) {
            if (position.X < GameUtils.BOARDER_X_POS - texture.Width/scalingFactor) {
                //position.X = -500;
                isDead = true;
            }
            base.Update(_gameTime);
        }
    }
}
