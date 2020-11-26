using System;
using System.Numerics;
using Raylib_cs;
using Platformer;

namespace Objects
{
    public class Player
    {
        static int playerW = 40;
        static int playerH = 70;
        public static int health = 5;
        public static float playerX;
        public static float playerY;
        static float yVelocity;
        public static bool goToStart;
        public static bool playerOnGround;
        public static bool playerKill;
        public static bool switchLevel;
        public static bool loadHealthBar;
        static bool respawnPressed;
        static bool jumping = true;
        static Texture2D playerModel = Raylib.LoadTexture(@"textures\playerModel.png");
        static Texture2D healthModel = Raylib.LoadTexture(@"textures\healthModel.png");
        public static void player(float movementSpeed, float gravityStrength, int startX, int startY)
        {
            Raylib.DrawTexture(playerModel, (int)playerX, (int)playerY, Color.WHITE);
            playerY += yVelocity;

            if (goToStart)
            {
                playerX = startX;
                playerY = startY;
                goToStart = false;
            }
            //restart 
            if (Raylib.IsKeyDown(KeyboardKey.KEY_R))
            {
                goToStart = true;
            }

            //move right
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                playerX += movementSpeed;
            }

            //move left
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) || Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                playerX -= movementSpeed;
            }

            //Stops the player from falling if it's standing on ground
            if (playerOnGround)
            {
                jumping = false;
                yVelocity = 0;
            }

            //Increases yVelocity gradually to create gravity and downwards acceleration
            if (!playerOnGround)
            {
                yVelocity += gravityStrength;
            }

            //jump
            if (!jumping &&
            (Raylib.IsKeyDown(KeyboardKey.KEY_UP) ||
            Raylib.IsKeyDown(KeyboardKey.KEY_W) ||
            Raylib.IsKeyDown(KeyboardKey.KEY_SPACE)))
            {
                yVelocity = -15;
                jumping = true;
            }

            //Makes it so the yVelocity can't go over a certain limit
            if (yVelocity >= 20)
            {
                yVelocity = 20;
            }

            if (yVelocity <= -20)
            {
                yVelocity = -20;
            }

            //Makes the player lose a life and respawn when taking damage
            if (playerKill)
            {
                playerKill = false;
                goToStart = true;
                health -= 1;
            }
            //Creates the player's health bar

            if (loadHealthBar)
            {
                if (health >= 1)
                {
                    Raylib.DrawTexture(healthModel, 20, 10, Color.WHITE);
                }
                if (health >= 2)
                {
                    Raylib.DrawTexture(healthModel, 75, 10, Color.WHITE);
                }
                if (health >= 3)
                {
                    Raylib.DrawTexture(healthModel, 130, 10, Color.WHITE);
                }
                if (health >= 4)
                {
                    Raylib.DrawTexture(healthModel, 185, 10, Color.WHITE);
                }
                if (health >= 5)
                {
                    Raylib.DrawTexture(healthModel, 240, 10, Color.WHITE);
                }
            }

            if (switchLevel)
            {
                goToStart = true;
                switchLevel = false;
            }
        }
    }
    public class Walls
    {
        public static void groundAndRoof(float roofH, float groundH)
        {

        }
    }
}
