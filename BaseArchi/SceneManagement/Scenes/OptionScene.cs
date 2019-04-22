using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BaseArchi.SceneManagement.Scenes
{
    public class OptionScene : IScene
    {
        SpriteFont GameFont { get; set; }
        public OptionScene()
        {

        }

        public void LoadContent(ContentManager content)
        {

        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw()
        {
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "je suis dans les options", new Vector2(0, 0), Color.Green);
        }
    }
}
