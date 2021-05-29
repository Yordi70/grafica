using OpenTK.Graphics.OpenGL;

namespace grafica
{
    class Mesa
    {
        public double x;
        public double y;
        public Mesa(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public void SetCentrodeMasa(double posx, double posy){
            this.x = posx;
            this.y = posy;
        }

        public void Dibujar(){

            //mesa
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.60f, 0.60f);
            GL.Vertex2(x + 0.0, y + 0.0);
            GL.Vertex2(x + 0.3, y + 0.3);
            GL.Vertex2(x + 1.2, y + 0.3);
            GL.Vertex2(0.9 + x, y + 0.0);
            GL.End();

            //barritas izq
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.55f);
            GL.Vertex2(x + 0.0,  0.0 + y);
            GL.Vertex2(x + 0.0, -0.08 + y);
            GL.Vertex2(x + 0.9,  -0.08 + y);
            GL.Vertex2(0.9 + x, y + 0.0);
            GL.End();

            //barritas der
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.50f, 0.55f);
            GL.Vertex2(x + 0.9, y + 0.0);
            GL.Vertex2(x + 0.9,-0.08 + y);
            GL.Vertex2(x + 1.2, y + 0.22);
            GL.Vertex2(1.2 + x, y + 0.3);
            GL.End();



            //pata primera izq
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.48f, 0.48f);
            GL.Vertex2(x + 0.0, -0.08 + y);
            GL.Vertex2(x + 0.0, -0.58 + y);
            GL.Vertex2(x + 0.05, -0.6 + y);
            GL.Vertex2( x + 0.05, -0.08 + y);
            GL.End();

            // 

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(x + 0.05, -0.08 + y);
            GL.Vertex2(x + 0.05, -0.6 + y);
            
            GL.Vertex2(x + 0.1, -0.58 + y);
            GL.Vertex2(x + 0.1, -0.08 + y);
            GL.End();



            //pata central 
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(x + 0.9, -0.08 + y);
            GL.Vertex2(x + 0.9, -0.6 + y);
            GL.Vertex2(x + 0.85, -0.6 + y);
            GL.Vertex2(x + 0.85, -0.08 + y);
            GL.End();

            //
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.48f, 0.48f);

            GL.Vertex2(x + 0.9, -0.08 + y);
            GL.Vertex2(x + 0.9, -0.6 + y);
            GL.Vertex2(x + 0.95, -0.55 + y);
            GL.Vertex2(x + 0.95, -0.03 + y);
            GL.End();

            //pata derecha
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.40f, 0.40f);
            GL.Vertex2(x + 1.2, 0.22 + y);
            GL.Vertex2(x + 1.2, -0.3 + y);
            GL.Vertex2(x + 1.15, -0.35 + y);
            GL.Vertex2(x + 1.15, 0.17 + y);
            GL.End();
            
            //
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.48f, 0.48f);
            GL.Vertex2(x + 1.15, 0.17 + y);
            GL.Vertex2(x + 1.15, -0.35 + y);
            GL.Vertex2(x + 1.1, -0.35 + y);
            GL.Vertex2(x + 1.1, 0.12 + y);
            GL.End();


        }
       
    }
}
