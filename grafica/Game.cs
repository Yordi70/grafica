using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace grafica
{
    class Game:GameWindow
    {
        private Silla silla,silla2;
        private Mesa mesa;
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
            silla = new Silla(0.8,0);
            mesa = new Mesa(-0.8,0.5);
            silla2 = new Silla(0.0,-0.8);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);



            base.OnLoad(e);
        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            silla.Dibujar();
            mesa.Dibujar();
            silla2.Dibujar();
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
    }
}
