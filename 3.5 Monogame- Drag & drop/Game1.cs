﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace _3._5_Monogame__Drag___drop
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        Texture2D asteroidTexture;
        Rectangle asteroidRect;

        Texture2D carTexture;
        Rectangle carRect;

        Texture2D rocketTexture;
        Rectangle rocketRect;

        bool isDraggingAsteroid;
        bool isDraggingCar;
        bool isDraggingRocket;

        MouseState currentMouseStae;
        MouseState prevMouseState;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            asteroidTexture = Content.Load<Texture2D>("asteroid");
            carTexture = Content.Load<Texture2D>("fast_car");
            rocketTexture = Content.Load<Texture2D>("rocket");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            prevMouseState = currentMouseStae;
            currentMouseStae = Mouse.GetState();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Azure);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            _spriteBatch.Draw(asteroidTexture, asteroidRect, Color.White);
            _spriteBatch.Draw(carTexture,carRect, Color.White);

            base.Draw(gameTime);
        }
    }
}
