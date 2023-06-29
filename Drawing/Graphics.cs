using OpenTK.Graphics.OpenGL;
using System.Numerics;

namespace SimpleGameFramework.Drawing
{
    public static class Graphics
    {
        public static void Background(float r, float g, float b, float a = 255)
        {
            GL.ClearColor(r / 255f, g / 255f, b / 255f, a / 255f);
        }

        public static void Background(Vector4 color) => Background(color.X, color.Y, color.Z, color.W);
    }
}