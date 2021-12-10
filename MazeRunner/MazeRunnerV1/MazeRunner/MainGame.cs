using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MazeRunner
{
    public class MainGame : Game
    {
        private GraphicsDeviceManager _graphics;

        public MainGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Components.Add(new Playfield(this));
            Components.Add(new Player(this));

            base.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            if (Input.ExitRequested) Exit();

            base.Update(gameTime);
        }
    }
}
