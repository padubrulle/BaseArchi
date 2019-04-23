using BaseArchi.Models;
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

        

        public LivingEntity(Texture2D _img) : base(_img)
        {
            
        }

        public LivingEntity(Dictionary<string, Animation> animations) : base(animations)
        {

        }

        public new void Draw()
        {
            //MainGame.spriteBatch.Draw(this.Img, this.Position, Color.White);
        }
    }
}
