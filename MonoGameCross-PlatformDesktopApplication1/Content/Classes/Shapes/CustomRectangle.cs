using System.Collections;

namespace MonoGameCross_PlatformDesktopApplication1.Content.Classes.Shapes;

public class CustomRectangle
{
    private int XCorner { get; set; }
    private int YCorner{ get; set; }
    private int width{ get; set; }
    private int height{ get; set; }
    private double rotation{ get; set; }

    public CustomRectangle(int xCorner, int yCorner, int width, int height, double rotation)
    {
        XCorner = xCorner;
        YCorner = yCorner;
        this.width = width;
        this.height = height;
        this.rotation = rotation;
    }

    public CustomRectangle(int xCorner, int yCorner, int width, int height)
    {
        XCorner = xCorner;
        YCorner = yCorner;
        this.width = width;
        this.height = height;
    }
}