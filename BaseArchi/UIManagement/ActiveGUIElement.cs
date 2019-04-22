using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseArchi.UIManagement
{
    class ActiveGUIElement : GUIElement
    {
        public Rectangle BoundingBox { get; private set; }
        public Texture2D Img { get; private set; }
        SpriteFont font { get; set; }
        public ActiveGUIElement(Vector2 _position, Texture2D _img = null) : base(_position)
        {
            
        }

        public ActiveGUIElement(Vector2 _position, string _text) : base(_position)
        {
            this.BoundingBox = new Rectangle((int)Math.Round(this.Position.X),              //X
                                            (int)Math.Round(this.Position.Y),               //Y
                                            (int)Math.Round(font.MeasureString(_text).X),   //Width
                                            (int)Math.Round(font.MeasureString(_text).X));  //Height
        }

        public void LoadContent()
        {

        }

        public void Hover()
        {

        }

        public void Click()
        {

        }

        public void Update()
        {

        }

        public void Draw()
        {

        }
    }
}
