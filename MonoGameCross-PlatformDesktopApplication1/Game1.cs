using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameCross_PlatformDesktopApplication1.Content.Classes.Card;

namespace MonoGameCross_PlatformDesktopApplication1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<Card> cardArr = new List<Card>();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            for (int i = 0; i < 5; i++)
            {
                var card = new Card(
                    GraphicsDevice,
                    new Vector2(200 + (i * 40), 250),   // pozycja
                    100,                                // szerokość
                    150,                                // wysokość
                    MathHelper.ToRadians((i - 2) * 10), // rotacja: -20, -10, 0, 10, 20
                    new Color(50 * i, 30 * i, 100, 255) // kolor
                );

                cardArr.Add(card);
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            foreach (var card in cardArr)
            {
                card.Draw(_spriteBatch);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}