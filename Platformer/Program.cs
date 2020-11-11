using System;
using Raylib_cs;
using Gamestates;

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

            int displayWidth = 1920;
            int displayHeight = 1080;
            int level = 0;

            Raylib.InitWindow(displayWidth, displayHeight, "Platformer game");
            Raylib.ToggleFullscreen();

            Menu mainMenu = new Menu(displayWidth, displayHeight);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (level == 0)
                {
                    mainMenu.Draw();
                }

                Raylib.EndDrawing();
            }
        }
    }
}