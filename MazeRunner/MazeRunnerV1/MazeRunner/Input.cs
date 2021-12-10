using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MazeRunner
{
    public class Input
    {
        public static bool ExitRequested
        {
            get { return GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape); }
        }

        public static bool PlayerDown
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S); }
        }

        public static bool PlayerUp
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Up)|| Keyboard.GetState().IsKeyDown(Keys.W); }
        }

        public static bool PlayerLeft
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Left)|| Keyboard.GetState().IsKeyDown(Keys.A); }
        }

        public static bool PlayerRight
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Right)|| Keyboard.GetState().IsKeyDown(Keys.D); }
        }

        public static bool PlayerStop
        {
            get { return Keyboard.GetState().IsKeyDown(Keys.Space); }
        }
    }
}
