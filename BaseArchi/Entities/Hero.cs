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
    class Hero : LivingEntity
    {

        public Hero(Texture2D _img) : base(_img)
        {
            Speed = 3f;
        }

        public Hero(Dictionary<string, Animation> animations) : base(animations)
        {
            Speed = 3f;
        }

        public void Update(GameTime gameTime)
        {
            Move();

            SetAnimations();

            animationManager.Update(gameTime);

            Position += Velocity;
            Velocity = Vector2.Zero;
        }

        public new void Move()
        {
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Right))
            {
                Direction = FacingDirection.Right;
                Velocity.X = Speed;
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Down))
            {
                Velocity.Y = Speed;
                Direction = FacingDirection.Down;
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Left))
            {
                Velocity.X = -Speed;
                Direction = FacingDirection.Left;
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Up))
            {
                Velocity.Y = -Speed;
                Direction = FacingDirection.Up;
            }

        }

        public new void Draw()
        {
            //MainGame.spriteBatch.Draw(this.Img, this.Position, null, Color.White, 0f, Vector2.Zero, 3f, se, 1f);
        }
    }
}
