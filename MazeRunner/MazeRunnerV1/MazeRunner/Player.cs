using System;
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
        private const float _BOUNCE_STRENGTH = 20;
        private const float _MAX_VELOCITY = 5;

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
            _velocity.X -= posneg(_velocity.X) * 0.1f;
            _velocity.Y -= posneg(_velocity.Y) * 0.1f;

            _velocity.X = (float)Math.Round(_velocity.X, 1);
            _velocity.Y = (float)Math.Round(_velocity.Y, 1);

            //Handle input
            if (Input.PlayerUp)
            {
                _direction = Direction.Up;
                _velocity.Y -= 0.2f;
            }
            if (Input.PlayerDown)
            {
                _direction = Direction.Down;
                _velocity.Y += 0.2f;
            }
            if (Input.PlayerLeft)
            {
                _direction = Direction.Left;
                _velocity.X -= 0.2f;
            }
            if (Input.PlayerRight)
            {
                _direction = Direction.Right;
                _velocity.X += 0.2f;
            }
            if (Input.PlayerStop)
            {
                _velocity.X += _velocity.X * (-0.1f);
                _velocity.Y += _velocity.Y * (-0.1f);
            }

            //Bounce on viewport bounds
            if (_position.Y < _bounds.Y) _velocity.Y += _BOUNCE_STRENGTH;
            if (_position.Y + _size > _bounds.Height) _velocity.Y -= _BOUNCE_STRENGTH;
            if (_position.X < _bounds.X) _velocity.X += _BOUNCE_STRENGTH;
            if (_position.X + _size > _bounds.Width) _velocity.X -= _BOUNCE_STRENGTH;

            //Max x,y velocity
            _velocity.X = MathF.Min(MathF.Abs(_velocity.X), _MAX_VELOCITY) * posneg(_velocity.X);
            _velocity.Y = MathF.Min(MathF.Abs(_velocity.Y), _MAX_VELOCITY) * posneg(_velocity.Y);

            //Max 360 velocity
            if(_velocity.Length()> _MAX_VELOCITY)
            {
                float angle = MathF.Atan2(_velocity.X, _velocity.Y);
                _velocity.X = MathF.Sin(angle) * _MAX_VELOCITY;
                _velocity.Y = MathF.Cos(angle) * _MAX_VELOCITY;
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
}
