using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseArchi.Entities
{
    class LivingEntity : Sprite
    {
        public int HP { get; protected set; }

        

        public LivingEntity(Texture2D _img, Vector2 _position) : base(_img, _position)
        {
            
        }

        public new void Draw()
        {
            MainGame.spriteBatch.Draw(this.Img, this.Position, Color.White);
        }
    }
}
