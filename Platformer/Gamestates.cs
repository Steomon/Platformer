using System;
using Raylib_cs;
using Platformer;


namespace Gamestates
{
    public class Menu
    {
        public int displayWidth;
        public int displayHeight;
        public Menu(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
        }

        public void Draw()
        {
            Texture2D mainMenuBG = Raylib.LoadTexture(@"textures\mainMenuBackground.png");
            Raylib.DrawTexture(mainMenuBG, 0, 0, Color.WHITE);

            Raylib.DrawText("Platformer Game", displayWidth / 2, displayHeight / 2 - 200, 100, Color.GRAY);
        }
    }
}