using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseArchi.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BaseArchi.Managers
{
    class AnimationManager
    {
        private Animation m_animation;

        private float m_timer;

        public Vector2 Position { get; set; }

        public AnimationManager(Animation _animation)
        {
            m_animation = _animation;
        }

        public void Play(Animation _animation)
        {
            if (m_animation == _animation)
                return;

            m_animation = _animation;

            m_animation.CurrentFrame = 0;

            m_timer = 0;
        }

        public void Stop()
        {
            m_timer = 0f;

            m_animation.CurrentFrame = 0;
        }

        public void Update(GameTime gameTime)
        {
            m_timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (m_timer > m_animation.FrameSpeed)
            {
                m_timer = 0f;
                m_animation.CurrentFrame++;

                if (m_animation.CurrentFrame >= m_animation.FrameCount)
                    m_animation.CurrentFrame = 0;
            }
        }

        public void Draw()
        {
            MainGame.spriteBatch.Draw(m_animation.Texture,
                                      Position,
                                      new Rectangle(m_animation.CurrentFrame * m_animation.FrameWidth,
                                                    0,
                                                    m_animation.FrameWidth,
                                                    m_animation.FrameHeight),
                                      Color.White);

        }

        public void Draw(SpriteEffects se)
        {
            MainGame.spriteBatch.Draw(m_animation.Texture, 
                                        Position,
                                        new Rectangle(m_animation.CurrentFrame * m_animation.FrameWidth,
                                                    0,
                                                    m_animation.FrameWidth,
                                                    m_animation.FrameHeight), 
                                        Color.White, 
                                        0f, 
                                        Vector2.Zero, 
                                        1f, 
                                        se, 
                                        1f);

        }
    }
}
