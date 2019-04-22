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
        Hero hero { get; set; }
        public GameScene()
        {
            //hero = new Hero(MainGame.heroImgSide, new Vector2(50, 50));
        }

        public void LoadContent(ContentManager content)
        {
            var animations = new Dictionary<string, Animation>
            {
                { "WalkUp", new Animation(content.Load<Texture2D>("Player/hero-walk-back"), 6) },
                { "WalkRight", new Animation(content.Load<Texture2D>("Player/hero-walk-side"), 6) },
                { "WalkDown", new Animation(content.Load<Texture2D>("Player/hero-walk-front"), 6) }
            };
            m_sprites = new List<Sprite>()
            {
                new Sprite(animations, new Vector2(50, 50))
                {
                    Input = new Input()
                    {
                        Up = Keys.Z,
                        Right = Keys.D,
                        Down = Keys.S,
                        Left = Keys.Q,
                    }
                }
            };
            //hero = new Sprite(animations, new Vector2(50, 50));
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
            foreach (var sprite in m_sprites)
                sprite.Draw();
        }
    }
}
