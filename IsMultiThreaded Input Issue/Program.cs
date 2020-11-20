using OpenTK.Windowing.Desktop;

namespace IsMultiThreaded_Input_Issue
{
    class Program
    {
        private static GameWindowSettings gameWindowSettings = new GameWindowSettings() { IsMultiThreaded = false, UpdateFrequency = 60 };
        private static NativeWindowSettings nativeWindowSettings = new NativeWindowSettings() { };
        private static GLWindow GLW;

        static void Main(string[] args)
        {
            GLW = new GLWindow(gameWindowSettings, nativeWindowSettings);
            GLW.Run();
        }
    }
}
