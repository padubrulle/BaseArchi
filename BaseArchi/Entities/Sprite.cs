using BaseArchi.Core;
using BaseArchi.Managers;
using BaseArchi.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseArchi.Entities
{
    class Sprite : GameObject
    {
        #region Fields
        protected AnimationManager animationManager;

        protected Dictionary<string, Animation> Animations;

        

        public Texture2D Img { get; protected set; }
        #endregion

        public enum FacingDirection
        {
            Right,
            Down,
            Left,
            Up
        }


        #region Properties

        protected FacingDirection Direction;

        public Input Input;

        public float Speed = 0f;

        public Vector2 Velocity;

        protected bool canMove = true;

        protected Vector2 m_position
        {
            get { return Position; }
            set
            {
                Position = value;
                if (animationManager != null)
                    animationManager._position = Position;
            }
        }

        #endregion

        public Sprite(Texture2D _img) : base ()
        {
            Img = _img;
        }

        public Sprite(Dictionary<string, Animation> animations) : base()
        {
            Animations = animations;
            animationManager = new AnimationManager(Animations.First().Value);

        }

        public void Update(GameTime gameTime, List<Sprite> sprites)
        {
            animationManager._position = Position;
            Move();

            SetAnimations();
            animationManager.Update(gameTime);

            this.Position += this.Velocity;
            this.Velocity = Vector2.Zero;
        }

        protected virtual void SetAnimations()
        {
            
        }

        protected virtual void Move()
        {
            
        }


        public void Draw()
        {
            if (Img != null)
                MainGame.spriteBatch.Draw(this.Img, this.Position, Color.White);
            else if (animationManager != null)
                 animationManager.Draw();
            else throw new Exception("Exception");
        }
    }
}
