using System;
using Raylib_cs;
using Platformer;

namespace Gamestates
{
    public class MainMenu
    {
        public static void DrawMainMenu()
        {
            int displayWidth = Program.Main.displayWidth;

            Texture2D mainMenuBG = Raylib.LoadTexture(@"textures\mainMenuBackground.png");
            Raylib.DrawTexture(mainMenuBG, 0, 0, Color.WHITE);

            Raylib.DrawText("Platformer Game", displayWidth/2, displayHeight/2-200, 100, Color.GRAY);
        }
    }
}