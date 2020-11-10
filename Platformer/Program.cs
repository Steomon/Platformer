using System;
using Raylib_cs;

namespace Platformer
{
    public class Program
    {
        public static void Main()
        {
            bool closeMainMenu = false;
            bool displayRestart = false;
            bool pressToRestart = false;
            bool startButtonPressed = false;
            bool loadHealthBar = false;

            int DisplayWidth = 1920;
            int DisplayHeight = 1080;
            int level = 0;

            Raylib.InitWindow(DisplayWidth, DisplayHeight, "Platformer game");
            Raylib.ToggleFullscreen();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (level == 0)
                {
                    Gamestates.MainMenu.DrawMainMenu();
                }

                Raylib.EndDrawing();
            }
        }
    }
}