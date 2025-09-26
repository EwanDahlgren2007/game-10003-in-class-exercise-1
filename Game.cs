// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{

    public class Game
    {
        
        public void Setup()
        {
            Window.SetTitle("Loop Test");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }

        public void Update()
        {
            Window.ClearBackground(Color.DarkGray);
            for (int i = 0; i < 10; i++)
            {
                int r = 165 + i * 10;
                int g = 255;
                int b = 255 - i * 10;
                Color color = new(r, g, b);
                Draw.FillColor = color;

                Draw.LineSize = 0;

                float offsetX = Input.GetMouseX();
                offsetX -= 180;
                float offsetY = Input.GetMouseY();

                float x = i * 40.0f;

                Draw.Circle(x+offsetX, offsetY, 10);

                Text.Color = Color.White;
                Text.Draw($"{i}", x - 10, offsetY - 60);
            }
        }
    }

}
