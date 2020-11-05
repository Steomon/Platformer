using System;
using Raylib_cs;

namespace Platformer
{
    class Program
    {
        static void Main()
        {
            int DisplayWidth = 1920;
            int DisplayHeight = 1080;

            Raylib.InitWindow(DisplayWidth, DisplayHeight, "Platformer game");
            Raylib.ToggleFullscreen();

            bool closeMainMenu = false;
            bool displayRestart = false;
            bool pressToRestart = false;
            int level = 0;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawRectangle(10, 10, 100, 100, Color.ORANGE);

                Raylib.EndDrawing();
            }
        }
    }
}
