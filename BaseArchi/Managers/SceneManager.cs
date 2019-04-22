using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseArchi.Managers;
using BaseArchi.SceneManagement.Scenes;
using Microsoft.Xna.Framework.Content;


namespace BaseArchi.SceneManagement
{
    public class SceneManager
    {
        public enum SceneType
        {
            Menu,
            Game,
            Option,
            GameOver
        }

        public IScene CurrentScene { get; private set; }

        public SceneManager()
        {
            CurrentScene = new MainMenuScene();
        }

        public void ChangeScene(SceneType _scene)
        {
            switch(_scene)
            {
                case SceneType.Menu:
                default:
                    CurrentScene = new MainMenuScene();
                    break;
                case SceneType.Game:
                    CurrentScene = new GameScene();
                    break;
                case SceneType.GameOver:
                    CurrentScene = new GameOverScene();
                    break;
                case SceneType.Option:
                    CurrentScene = new OptionScene();
                    break;
            }
            CurrentScene.LoadContent(AssetManager.Content);
        }

    }
}
