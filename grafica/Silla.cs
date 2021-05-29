using OpenTK.Graphics.OpenGL;


namespace grafica
{
    class Silla
    {
        public double x;
        public double y;
        public Silla(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public void setCentrodeMasa(double posx, double posy)
        {
            this.x = posx;
            this.y = posy;
        }
            
        public void Dibujar()
        {
            //asiento
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.60f, 0.60f);
            GL.Vertex2(x + 0.0, y + 0.0);
            GL.Vertex2(x + 0.2, y + 0.2);
            GL.Vertex2(x + 0.0, y + 0.4 );
            GL.Vertex2(-0.2 + x, y + 0.2);
            GL.End();
            //espaldar

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.50f);
            GL.Vertex2(-0.2 + x , 0.2 + y);
            GL.Vertex2(0.0 + x, 0.4 + y);
            GL.Vertex2(0.0 + x, 0.8 + y);
            GL.Vertex2(-0.2 + x, 0.6 + y);
            GL.End();


            ///Barrita del Asiento Adelante
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.55f);
            GL.Vertex2(0.0 + x, 0.0 + y);
            GL.Vertex2(0.2 + x, 0.2 + y);
            GL.Vertex2(0.2 + x, 0.15 + y);
            GL.Vertex2(0.0 + x, -0.05 + y);
            GL.End();


            //Barrita del Asiento Detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.55f);
            GL.Vertex2(0.0 + x, 0.0 + y);
            GL.Vertex2(-0.2 + x, 0.2 + y);
            GL.Vertex2(-0.2 + x, 0.15 + y);
            GL.Vertex2(0.0 + x, -0.05 + y);
            GL.End();


            //Pata del Medio
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.70f, 0.70f);
            GL.Vertex2(0.0 + x , -0.05 + y);
            GL.Vertex2(0.0 + x, -0.2 + y);
            GL.Vertex2(0.02 + x, -0.18 + y);
            GL.Vertex2(0.02 + x, -0.03 + y);
            GL.End();


            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(0.0 + x, -0.05 + y);
            GL.Vertex2(0.0 + x, -0.2 + y);
            GL.Vertex2(-0.02 + x, -0.18 + y);
            GL.Vertex2(-0.02 + x, -0.03 + y);
            GL.End();


            ///Pata de la Derecha
            ///

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.70f, 0.70f);
            GL.Vertex2(0.2 + x, 0.15 + y);
            GL.Vertex2(0.2 + x, -0.05 + y);
            GL.Vertex2(0.18 + x, -0.07 + y);
            GL.Vertex2(0.18 + x, 0.13 + y);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(0.18 + x, -0.07 + y);
            GL.Vertex2(0.16 + x, -0.05 + y);
            GL.Vertex2(0.16 + x, 0.11 + y);
            GL.Vertex2(0.18 + x, 0.13 + y);
            GL.End();



            ///Patas del Lado Izquierdo
            ///

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(-0.2 + x, 0.15 + y);
            GL.Vertex2(-0.2 + x, 0.0 + y);
            GL.Vertex2(-0.18 + x, -0.02 + y);
            GL.Vertex2(-0.18 + x, 0.13 + y);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.70f, 0.70f);
            GL.Vertex2(-0.18 + x, -0.02 + y);
            GL.Vertex2(-0.16 + x, 0.0 + y);
            GL.Vertex2(-0.16 + x, 0.11 + y);
            GL.Vertex2(-0.18 + x, 0.13 + y);
            GL.End();



        }
    }
}
