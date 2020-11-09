using System;
using Raylib_cs;
using Platformer;

namespace Platformer
{
    class Program
    {
        static void Main()
        {
            bool closeMainMenu = false;
            bool displayRestart = false;
            bool pressToRestart = false;
            bool startButtonPressed = false;

            int DisplayWidth = 1920;
            int DisplayHeight = 1080;
            int level = 0;

            Raylib.InitWindow(DisplayWidth, DisplayHeight, "Platformer game");
            Raylib.ToggleFullscreen();

            mainMenu.mainMenuStartup();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (level == 0)
                {
                    mainMenu.drawMainMenu();
                }

                Raylib.EndDrawing();
            }
        }
    }
}
