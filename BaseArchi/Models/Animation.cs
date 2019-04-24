using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseArchi.Models
{
    public class Animation
    {
        public int CurrentFrame { get; set; }

        public int FrameCount { get; private set; }

        public int FrameHeight { get { return Texture.Height; } }

        public float FrameSpeed { get; set; }

        public int FrameWidth { get { return Texture.Width / FrameCount; } }

        public bool bIsLooping { get; private set; }

        public Texture2D Texture { get; private set; }

        public SpriteEffects SpriteEffects { get; private set; }

        public Animation(Texture2D _texture, int _frameCount, SpriteEffects _spriteEffects = SpriteEffects.None)
        {
            Texture = _texture;

            FrameCount = _frameCount;

            bIsLooping = true;

            FrameSpeed = 0.35f;

            SpriteEffects = _spriteEffects;
        }

        public bool isFinished()
        {
            return CurrentFrame == FrameCount;
        }



    }
}
