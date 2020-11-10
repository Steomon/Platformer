using System;
using Raylib_cs;

namespace Gamestates
{
    public class MainMenu
    {
        public static void DrawMainMenu()
        {
            Texture2D mainMenuBG = Raylib.LoadTexture(@"mainMenuBackground.png");
            Raylib.DrawTexture(mainMenuBG, 0, 0, Color.WHITE);
        }
    }
}