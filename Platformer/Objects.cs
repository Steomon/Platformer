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
        static bool respawnPressed;
        static bool jumping = true;
        static Texture2D playerModel = Raylib.LoadTexture(@"textures\playerModel.png");
        public static void player(float movementSpeed, float gravityStrength, int startX, int startY)
        {
            Raylib.DrawTexture(playerModel, (int)playerX, (int)playerY, Color.WHITE);
            playerY += yVelocity;

            if(goToStart){
                playerX = startX;
                playerY = startY;
                goToStart = false;
            }
            //restart 
            if(Raylib.IsKeyDown(KeyboardKey.KEY_R)){
                goToStart = true;
            }

            //move right
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)){
                playerX += movementSpeed;
            }

            //move left
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A) || Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)){
                playerX -= movementSpeed;
            }

            //Stops the player from falling if it's standing on ground
            if(playerOnGround){
                jumping = false;
                yVelocity = 0;
            }

            //Increases yVelocity gradually to create gravity and downwards acceleration
            if(!playerOnGround){
                yVelocity += gravityStrength;
            }

            //jump
            if(!jumping && (Raylib.IsKeyDown(KeyboardKey.KEY_UP) || Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))){
                yVelocity = -15;
                jumping = true;
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