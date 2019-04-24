using BaseArchi.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            if(canMove)
                Move();

            SetAnimations();

            animationManager.Update(gameTime);
            isMoving = false;
            isAttacking = false;
            //isShooting = false;
            Position += Velocity;
            Velocity = Vector2.Zero;
            MainGame.oldKeyboardState = MainGame.newKeyboardState;
        }

        public new void SetAnimations()
        {

            switch (Direction)
            {
                case FacingDirection.Right:
                default:
                    if (isMoving)
                        animationManager.Play(Animations["WalkRight"]);
                    else if (isAttacking)
                        animationManager.Play(Animations["AttackRight"]);
                    else if (isShooting)
                        animationManager.Play(Animations["AttackWeaponRight"]);
                    else
                        animationManager.Play(Animations["IdleRight"]);
                    break;
                case FacingDirection.Down:
                    if (isMoving)
                        animationManager.Play(Animations["WalkDown"]);
                    else if (isAttacking)
                        animationManager.Play(Animations["AttackDown"]);
                    else if (isShooting)
                        animationManager.Play(Animations["AttackWeaponDown"]);
                    else
                        animationManager.Play(Animations["IdleDown"]);
                    break;
                case FacingDirection.Left:
                    if (isMoving)
                        animationManager.Play(Animations["WalkLeft"]);
                    else if (isAttacking)
                        animationManager.Play(Animations["AttackLeft"]);
                    else if (isShooting)
                    {
                        animationManager.Play(Animations["AttackWeaponLeft"]);
                    }
                    else
                        animationManager.Play(Animations["IdleLeft"]);
                    break;
                case FacingDirection.Up:
                    if (isMoving)
                        animationManager.Play(Animations["WalkUp"]);
                    else if (isAttacking)
                        animationManager.Play(Animations["AttackUp"]);
                    else if (isShooting)
                        animationManager.Play(Animations["AttackWeaponUp"]);
                    else
                        animationManager.Play(Animations["IdleUp"]);
                    break;
            }
        }

        public new void Move()
        {
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Right))
            {
                isMoving = true;
                Direction = FacingDirection.Right;
                Velocity = new Vector2(Speed, 0);
                //Velocity.X = Speed;
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Down))
            {
                isMoving = true;
                Direction = FacingDirection.Down;
                Velocity = new Vector2(0, Speed);
                //Velocity.Y = Speed;
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Left))
            {
                isMoving = true;
                Direction = FacingDirection.Left;
                Velocity = new Vector2(-Speed, 0);
                //Velocity.X = -Speed;
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Up))
            {
                isMoving = true;
                Direction = FacingDirection.Up;
                Velocity = new Vector2(0, -Speed);
                //Velocity.Y = -Speed;
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.Space) && !MainGame.oldKeyboardState.IsKeyDown(Keys.Space))
            {
                ShootProjectile();
            }
            if (MainGame.newKeyboardState.IsKeyDown(Keys.A) && !MainGame.oldKeyboardState.IsKeyDown(Keys.A))
            {
                MeleeAttack();
                Console.WriteLine("Attack");
            }
        }

        private void ShootProjectile()
        {
            isShooting = true;
        }

        private void MeleeAttack()
        {
            isAttacking = true;
        }

        public new void Draw()
        {
            //MainGame.spriteBatch.Draw(this.Img, this.Position, null, Color.White, 0f, Vector2.Zero, 3f, se, 1f);
            if(isAttacking)
            {
                MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "ATTACK", new Vector2(0, 140), Color.Red);
            }
            if(isShooting)
            {
                MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "SHOOT", new Vector2(0, 160), Color.Red);
            }
        }
    }
}
