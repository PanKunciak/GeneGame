using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameCross_PlatformDesktopApplication1.Content.Classes.Card;
using MonoGameCross_PlatformDesktopApplication1.Content.Classes.Shapes;


namespace MonoGameCross_PlatformDesktopApplication1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Card _card;
    private ArrayList cardArr = new ArrayList();
    private CustomRectangle _customRectangle;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        for (int i = 0; i < 5; i++)
        {
            _customRectangle = new CustomRectangle(200 + (i * 10), 150, 100, 100, (5 * i) - 10);
            _card = new Card(GraphicsDevice, _customRectangle, //new Vector2(200 + (i * 10), 150), 100, 150,
                new Color(5 * i, 10 * i, 15 * i, 255)); // XNA Color
            cardArr.Add(_card);
        }
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        _spriteBatch.Begin();
        foreach (Card card in cardArr)
        {
            card.Draw(_spriteBatch); 
        }
        //_card.Draw(_spriteBatch);
        _spriteBatch.End();

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}