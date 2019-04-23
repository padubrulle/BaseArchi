using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using BaseArchi.Entities;
using BaseArchi.Models;
using Microsoft.Xna.Framework.Input;

namespace BaseArchi.SceneManagement.Scenes
{
    public class GameScene : IScene
    {
        SpriteFont GameFont { get; set; }
        private List<Sprite> m_sprites;
        Hero hero;
        public GameScene()
        {
            
        }

        public void LoadContent(ContentManager content)
        {
            var animations = new Dictionary<string, Animation>
            {
                { "WalkUp", new Animation(content.Load<Texture2D>("Player/hero-walk-back"), 6) },
                { "WalkRight", new Animation(content.Load<Texture2D>("Player/hero-walk-side"), 6) },
                { "WalkDown", new Animation(content.Load<Texture2D>("Player/hero-walk-front"), 6) },
                { "WalkLeft", new Animation(content.Load<Texture2D>("Player/hero-walk-side"), 6, SpriteEffects.FlipHorizontally) }
            };
            hero = new Hero(animations);
            hero.ChangePosition(new Vector2(500, 500));
            m_sprites = new List<Sprite>();

            m_sprites.Add(hero);

            //{
            //    hero = new Sprite(animations, new Vector2(500, 500))
            //    {
            //        Input = new Input()
            //        {
            //            Up = Keys.Z,
            //            Right = Keys.D,
            //            Down = Keys.S,
            //            Left = Keys.Q,
            //        }
            //    }
            //};
        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
            foreach (var sprite in m_sprites)
                sprite.Update(gameTime, m_sprites);
        }

        public void Draw()
        {
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "je suis dans le game", new Vector2(0, 0), Color.Green);
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "hero.X : " + hero.Position.X, new Vector2(0, 40), Color.Green);
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "hero.Y : " + hero.Position.Y, new Vector2(0, 60), Color.Green);
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "hero.Velocity.X : " + hero.Velocity.X, new Vector2(0, 80), Color.Green);
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "hero.Velocity.Y : " + hero.Velocity.Y, new Vector2(0, 100), Color.Green);
            foreach (var sprite in m_sprites)
                sprite.Draw();
        }
    }
}
