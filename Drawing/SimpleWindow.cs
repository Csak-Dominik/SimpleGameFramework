using OpenTK.Windowing.Desktop;

namespace SimpleGameFramework.Drawing
{
    public class SimpleWindow : GameWindow
    {
        public SimpleWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            Graphics.Background(255, 0, 255);
        }
    }
}