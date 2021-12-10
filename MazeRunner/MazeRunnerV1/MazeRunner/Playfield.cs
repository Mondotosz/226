using System;
using Microsoft.Xna.Framework;

namespace MazeRunner
{
    public class Playfield : DrawableGameComponent
    {
        public Playfield(Game game) : base(game)
        {
        }

        public override void Draw(GameTime gameTime)
        {
            Game.GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
