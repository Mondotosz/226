using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MazeRunner
{
    public class Player : DrawableGameComponent
    {
        enum Direction
        {
            // Values matches image order in bitmap
            Left = 0,
            Up = 1,
            Right = 2,
            Down = 3,
        }

        private Texture2D _texture;
        private Rectangle[] _textureRectangles;
        private SpriteBatch _spriteBatch;

        private Vector2 _position;
        private double _speed;
        private Direction _direction;

        private Vector2 _velocity;
        private Rectangle _bounds;
        private int _size;
        private const float _MAX_VELOCITY = 10;

        public Player(Game game) : base(game)
        {
            _position = new Vector2(0, 0);
            _speed = 100.0;
            _direction = Direction.Down;
            _velocity = new Vector2(0, 0);
            _bounds = game.GraphicsDevice.Viewport.Bounds;
        }

        protected override void LoadContent()
        {
            _texture = Game.Content.Load<Texture2D>("pacman");
            _size = _texture.Height;
            _textureRectangles = new Rectangle[4];
            int size = _texture.Height;
            for (int direction = 0; direction < 4; direction++)
            {
                _textureRectangles[direction] = new Rectangle(direction * size, 0, size, size);
            }

            _spriteBatch = new SpriteBatch(Game.GraphicsDevice);
        }

        public override void Update(GameTime gameTime)
        {
            //Drag
            //_velocity.X -= posneg(_velocity.X) * 0.1f;
            //_velocity.Y -= posneg(_velocity.Y) * 0.1f;

            _velocity.X = (float)Math.Round(_velocity.X, 1);
            _velocity.Y = (float)Math.Round(_velocity.Y, 1);

            //Handle input
            if (Input.PlayerUp)
            {
                _velocity.Y -= 0.2f;
            }
            if (Input.PlayerDown)
            {
                _velocity.Y += 0.2f;
            }
            if (Input.PlayerLeft)
            {
                _velocity.X -= 0.2f;
            }
            if (Input.PlayerRight)
            {
                _velocity.X += 0.2f;
            }
            if (Input.PlayerStop)
            {
                _velocity.X += _velocity.X * (-0.1f);
                _velocity.Y += _velocity.Y * (-0.1f);
            }

            //Bounce on viewport bounds
            if (!Hitbox.IsInside(_bounds))
            {
                if (_position.Y < _bounds.Y) _velocity.Y = _velocity.Y.ToPositive();
                if (_position.Y + _size > _bounds.Height) _velocity.Y = _velocity.Y.ToNegative();
                if (_position.X < _bounds.X) _velocity.X = _velocity.X.ToPositive();
                if (_position.X + _size > _bounds.Width) _velocity.X = _velocity.X.ToNegative();
            }

            //Max x,y velocity
            _velocity.X = MathF.Min(MathF.Abs(_velocity.X), _MAX_VELOCITY) * posneg(_velocity.X);
            _velocity.Y = MathF.Min(MathF.Abs(_velocity.Y), _MAX_VELOCITY) * posneg(_velocity.Y);

            //Max 360 velocity
            if (_velocity.Length() > _MAX_VELOCITY)
            {
                float angle = MathF.Atan2(_velocity.X, _velocity.Y);
                _velocity.X = MathF.Sin(angle) * _MAX_VELOCITY;
                _velocity.Y = MathF.Cos(angle) * _MAX_VELOCITY;
            }

            //Handle visuals based on direction
            if (Math.Abs(_velocity.X) >= Math.Abs(_velocity.Y))
            {
                _direction = _velocity.X.IsPositive() ? Direction.Right : Direction.Left;
            } else
            {
                _direction = _velocity.Y.IsPositive() ? Direction.Down : Direction.Up;
            }

            _position.X += (float)(_velocity.X * _speed * gameTime.ElapsedGameTime.TotalSeconds);
            _position.Y += (float)(_velocity.Y * _speed * gameTime.ElapsedGameTime.TotalSeconds);
        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, _position, _textureRectangles[(int)_direction], Color.White);
            _spriteBatch.End();
        }

        public Rectangle Hitbox
        {
            get { return new Rectangle(_position.ToPoint(), new Point(_size, _size)); }
        }

        private int posneg(float value)
        {
            int result = 0;
            if (value < 0)
            {
                result = -1;
            }
            else if (value > 0)
            {
                result = 1;
            }
            return result;
        }

    }

    public static class PlayerHelper
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool IsInside(this Rectangle hitbox, Rectangle bounds)
        {
            return (hitbox.Y >= bounds.Y && hitbox.Y + hitbox.Height <= bounds.Height && hitbox.X >= bounds.X && hitbox.X + hitbox.Width <= bounds.Width);
        }

        public static Vector2 Reversed(this Vector2 vector)
        {
            vector.X *= -1;
            vector.Y *= -1;
            return vector;
        }

        public static Vector2 ReversedX(this Vector2 vector)
        {
            vector.X *= -1;
            return vector;
        }

        public static Vector2 ReversedY(this Vector2 vector)
        {
            vector.Y *= -1;
            return vector;
        }

        public static int ToPositive(this int i)
        {
            return Math.Abs(i);
        }

        public static int ToNegative(this int i)
        {
            return -Math.Abs(i);
        }

        public static float ToPositive(this float i)
        {
            return Math.Abs(i);
        }

        public static float ToNegative(this float i)
        {
            return -Math.Abs(i);
        }

        public static bool IsPositive(this float i)
        {
            return i >= 0;
        }
        public static bool IsNegative(this float i)
        {
            return i < 0;
        }
    }
}
