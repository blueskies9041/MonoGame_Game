using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    // Shell for a basic MonoGame game.

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics; // Came with the code, don't mess with it.
        SpriteBatch spriteBatch; // We use these to draw textures, every texture will "belong" to one of these.

        Texture2D testTexture; // texture for testing
        Sprite testSprite; //sprite for testing, see Sprite.cs

        //Constructor for the game
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content"; // This is a folder inside our project directory where all the images and shit go.
        }

        //Don't mess with this yet.
        protected override void Initialize()
        {
            base.Initialize();
        }

        //This is where we load in all our textures and stuff.
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            testTexture = Content.Load<Texture2D>("CRATE_5"); // <--- Most important thing right now. String is the name of the image WITHOUT the file extension.
            testSprite = new Sprite(testTexture, new Vector2(50, 50), spriteBatch); //Again, see Sprite.cs

        }

        protected override void UnloadContent()
        {
          
        }

        //This is where game logic will  be updated.
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        
        //This is where drawing shit happens. 
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); //Blue background
            spriteBatch.Begin(); //Everything that belongs to "spriteBatch" will be drawn between the .begin() & .end()
            base.Draw(gameTime);
            testSprite.Draw(); //This actually draws the test image.
            spriteBatch.End();
        }
    }
}
