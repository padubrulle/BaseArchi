using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using BaseArchi.Content;

namespace BaseArchi.SceneManagement.Scenes
{
    public class MainMenuScene : IScene
    {
        //string MenuTitle { get; set; }
        public MainMenuScene()
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
            if(!(MainGame.oldKeyboardState.IsKeyDown(Keys.O)) && MainGame.newKeyboardState.IsKeyDown(Keys.O))
            {
                MainGame.sceneManager.ChangeScene(SceneManager.SceneType.Option);
            }

            if (!(MainGame.oldKeyboardState.IsKeyDown(Keys.Enter)) && MainGame.newKeyboardState.IsKeyDown(Keys.Enter))
            {
                MainGame.sceneManager.ChangeScene(SceneManager.SceneType.Game);
            }
        }

        public void Draw()
        {
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "Hello", new Vector2(0,0), Color.Red);
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "string measure : " + MainGame.SegoeUI.MeasureString("Hello"), new Vector2(0, 20), Color.Red);
            MainGame.spriteBatch.DrawString(MainGame.SegoeUI, "word at 35px ", new Vector2(35, 0), Color.Red);
            //ServiceProvider.Current.GetService(typeof(SpriteBatch))

        }
    }
}
