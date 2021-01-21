using System;
using System.Numerics;
using Raylib_cs;
using Platformer;
using Objects;

namespace Gamestates
{
    public class Levels
    {
        public int displayWidth;
        public int displayHeight;
        public Levels(int displayWidth, int displayHeight)   //Fick hjälp med den här, men jag modifierade den även efter det
        {                                                     
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
        }
        Color lightGray = new Color(200, 200, 200, 255);
        Color darkGray = new Color(150, 150, 150, 255);
        Texture2D mainMenuBG = Raylib.LoadTexture(@"textures\mainMenuBackground.png");
        static Image cursorHand = Raylib.LoadImage(@"textures\mouse_hand_icon.png");
        Texture2D cursorHandTexture = Raylib.LoadTextureFromImage(cursorHand);
        public void DrawMainMenu()
        {
            Raylib.DrawTexture(mainMenuBG, 0, 0, Color.WHITE);

            Raylib.DrawText("Platformer Game", (displayWidth / 2) - (Raylib.MeasureText("Platformer Game", 100) / 2), displayHeight / 2 - 300, 100, lightGray);
            Raylib.DrawText("Made by: Simon Kjellgren", 5, displayHeight - 50, 45, lightGray);
            Raylib.DrawText("Controls:", 5, 5, 45, lightGray);
            Raylib.DrawText("Move left - A/Left Arrow", 5, 53, 30, lightGray);
            Raylib.DrawText("Move right - D/Right Arrow", 5, 85, 30, lightGray);
            Raylib.DrawText("Jump - W/Spacebar/Up Arrow", 5, 117, 30, lightGray);
            Raylib.DrawText("Restart level - R", 5, 149, 30, lightGray);
            Raylib.DrawText("Exit game - ESC", 5, 181, 30, lightGray);

            Raylib.DrawRectangle(displayWidth / 2 - 210, displayHeight / 2 - 10, 410, 170, Color.WHITE);
            Raylib.DrawRectangle(displayWidth / 2 - 200, displayHeight / 2, 400, 160, darkGray);
            Raylib.DrawRectangle(displayWidth / 2 - 200, displayHeight / 2, 390, 150, lightGray);

            Raylib.DrawText("Play", (displayWidth / 2) - (Raylib.MeasureText("Play", 100) / 2), displayHeight / 2 + 22, 100, darkGray);
            Raylib.DrawText("Play", (displayWidth / 2) - (Raylib.MeasureText("Play", 100) / 2) - 5, displayHeight / 2 + 17, 100, Color.WHITE);

            if ((Raylib.GetMouseX() > displayWidth / 2 - 210)
            && (Raylib.GetMouseX() < displayWidth / 2 + 200)
            && (Raylib.GetMouseY() > displayHeight / 2 - 10)
            && (Raylib.GetMouseY() < displayHeight / 2 + 160))
            {
                Raylib.HideCursor();
                Raylib.DrawTexture(cursorHandTexture, Raylib.GetMouseX() - 7, Raylib.GetMouseY(), Color.WHITE);
                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    Raylib.DrawRectangle(displayWidth / 2 - 200, displayHeight / 2, 400, 160, Color.WHITE);
                    Raylib.DrawRectangle(displayWidth / 2 - 210, displayHeight / 2 - 10, 400, 160, darkGray);
                    Raylib.DrawRectangle(displayWidth / 2 - 200, displayHeight / 2, 390, 150, lightGray);

                    Raylib.DrawText("Play", (displayWidth / 2) - (Raylib.MeasureText("Play", 100) / 2) + 5, displayHeight / 2 + 27, 100, darkGray);
                    Raylib.DrawText("Play", (displayWidth / 2) - (Raylib.MeasureText("Play", 100) / 2), displayHeight / 2 + 22, 100, Color.WHITE);

                }
                else if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    Platformer.Program.level = 1;
                    Raylib.ShowCursor();
                    Objects.Player.goToStart = true;
                }
            }
            else
            {
                Raylib.ShowCursor();
            }
        }
    }
}