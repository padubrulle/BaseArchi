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
        SpriteEffects se;

        public Hero(Texture2D _img, Vector2 _position) : base(_img, _position)
        {
            Speed = 3f;
        }

        public void Update()
        {
            
        }

        public new void Draw()
        {
            //MainGame.spriteBatch.Draw(this.Img, this.Position, null, Color.White, 0f, Vector2.Zero, 3f, se, 1f);
        }
    }
}
