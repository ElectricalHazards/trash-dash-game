using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
//using System.Numerics;
using System.Text;
using Trash_Dash.Game.Entities;

namespace Trash_Dash.Game
{
    class SpawnableController {
        private static int elapsed = 0;
        private static List<Trash> listTrash = new List<Trash>();
        private static List<Trash> listRemoveTrash = new List<Trash>();
        private static List<Fish> listFish = new List<Fish>();
        private static readonly Random random = new Random();
        static public void Update(SpriteBatch _spriteBatch, GameTime gameTime) {
            int rand = random.Next(1000 - elapsed);
            if (rand == 0) {
                elapsed = 0;
                newBatch(_spriteBatch);
            }
            else {
                elapsed++;
            }
            foreach(Trash trash in listTrash) {
                trash.Update(gameTime);
                if (trash.isDead) {
                    listRemoveTrash.Add(trash);
                }
            }
            foreach(Trash trash in listRemoveTrash) {
                listTrash.Remove(trash);
            }
            listRemoveTrash.Clear();
        }

        static private void newBatch(SpriteBatch _spriteBatch) {
            int gridSize = 150;
            int gridCount = _spriteBatch.GraphicsDevice.Viewport.Height / gridSize;
            int rand = random.Next(gridCount)+1;
            listTrash.Add(new Trash(new Vector2(_spriteBatch.GraphicsDevice.Viewport.Width + 10, rand * 150), TrashGame.trashTex));
            
        }
        static public void Draw(SpriteBatch _spriteBatch) {
            foreach(Trash trash in listTrash) {
                trash.Draw(_spriteBatch);
            }
            foreach(Fish fish in listFish) {
                fish.Draw(_spriteBatch);

            }
        }
    }
}
