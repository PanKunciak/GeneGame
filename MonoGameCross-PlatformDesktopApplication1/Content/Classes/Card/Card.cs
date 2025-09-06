using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameCross_PlatformDesktopApplication1.Content.Classes.Card
{
    public class Card
    {
        private readonly Texture2D _texture;

        public Vector2 Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public float Rotation { get; set; }

        public Card(GraphicsDevice graphicsDevice, Vector2 position, int width, int height, float rotation, Color color)
        {
            _texture = new Texture2D(graphicsDevice, 1, 1);
            _texture.SetData(new[] { Color.White });

            Position = position;
            Width = width;
            Height = height;
            Rotation = rotation;
            Color = color;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rec = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);

            spriteBatch.Draw(
                _texture,
                destinationRectangle: rec,
                sourceRectangle: null,
                color: Color,
                rotation: Rotation,
                origin: new Vector2(0.5f, 0.5f), // środek 1x1 tekstury
                effects: SpriteEffects.None,
                layerDepth: 0f
            );
        }
    }
}