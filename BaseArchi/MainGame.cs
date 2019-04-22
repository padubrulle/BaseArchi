using BaseArchi.SceneManagement;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using BaseArchi.Content;
using BaseArchi.Managers;

namespace BaseArchi
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class MainGame : Game
    {
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static KeyboardState oldKeyboardState, newKeyboardState;
        public static SpriteFont SegoeUI;

        public static SceneManager sceneManager;

        const int SCREEN_WIDTH = 800;
        const int SCREEN_HEIGHT = 600;



        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
            graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;
            Window.Position = new Point(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2 - SCREEN_WIDTH / 2,
                                        GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2 - SCREEN_HEIGHT / 2);
            sceneManager = new SceneManager();
            ServiceProvider.Current = this.Services;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            oldKeyboardState = Keyboard.GetState();
            sceneManager.ChangeScene(SceneManager.SceneType.Menu);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            AssetManager.LoadContentManager(this.Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SegoeUI = Content.Load<SpriteFont>("segoeUI");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            newKeyboardState = Keyboard.GetState();
            // TODO: Add your update logic here
            if(sceneManager != null)
                sceneManager.CurrentScene.Update(gameTime);
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            // TODO: Add your drawing code here
            if (sceneManager != null)
                sceneManager.CurrentScene.Draw();

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
