using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameCross_PlatformDesktopApplication1.Content.Classes.Shapes;
using MonoColor = Microsoft.Xna.Framework.Color;
namespace MonoGameCross_PlatformDesktopApplication1.Content.Classes.Card;

public class Card
{
    private Texture2D _texture;



    //public Vector2 Position { get; set; }
    private CustomRectangle CustomRectangle { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Color Color { get; set; }
    public Card(GraphicsDevice graphicsDevice, CustomRectangle CustomRectangle, Color color)
    {
        _texture = new Texture2D(graphicsDevice, 1, 1);
        _texture.SetData(new[] { Microsoft.Xna.Framework.Color.White });
        CustomRectangle = CustomRectangle;
        Color = color;
        throw new System.NotImplementedException();
    }

    
    // public Card(GraphicsDevice graphicsDevice, CustomRectangle customRectangle, int width, int height, Color color)
    // {
    //     _texture = new Texture2D(graphicsDevice, 1, 1);
    //     _texture.SetData(new[] { Microsoft.Xna.Framework.Color.White });
    //     Position = position;
    //     Width = width;
    //     Height = height;
    //     Color = color;
    // }


    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, new Rectangle((int)Position.X,(int)Position.Y,Width,Height),Color);
    }
}