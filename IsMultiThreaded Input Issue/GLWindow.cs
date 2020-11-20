using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;


namespace IsMultiThreaded_Input_Issue
{
    class GLWindow : GameWindow
    {
        public GLWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings) 
        {
            VSync = VSyncMode.On;
        }

        protected override void OnLoad()
        {
            base.OnLoad();
        }
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            SwapBuffers();
            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            if (MouseState.ScrollDelta.Y != 0)
            {
                Console.WriteLine("Mousewheel Y: " + MouseState.ScrollDelta.Y);
            }

            base.OnUpdateFrame(args);
        }

    }
}
