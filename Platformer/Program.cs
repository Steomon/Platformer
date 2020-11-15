using System;
using System.Numerics;
using Raylib_cs;
using Gamestates;

namespace Platformer
{
    public class Program
    {
        public static int level = 0;
        public static void Main()
        {
            bool closeMainMenu = false;
            bool displayRestart = false;
            bool pressToRestart = false;
            bool startButtonPressed = false;
            bool loadHealthBar = false;


            int displayWidth = 1920;
            int displayHeight = 1080;


            Raylib.InitWindow(displayWidth, displayHeight, "Platformer game");
            Raylib.SetTargetFPS(60);
            Raylib.ToggleFullscreen();

            MainMenu MainMenu = new MainMenu(displayWidth, displayHeight);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (level == 0)
                {
                    MainMenu.Draw();
                }
                else if (level == 1)
                {
                    
                }

                Raylib.EndDrawing();
            }
        }
    }
}