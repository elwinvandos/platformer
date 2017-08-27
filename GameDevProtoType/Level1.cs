﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameDevProtoType
{
    class Level1 : Level
    {
        public Level1 (ContentManager content, SpriteBatch spritebatch)
            : base (content, spritebatch)
        { }
      
        protected void CreateTileArray()
        {
            tileArray = new byte[,]
            {
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,3,5,5,5,5,5,4,0,0,0,0,0,0,0,0,8 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,5,5,5 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,3,5,7,4,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,3,5,5,5,5,7,5,7,5,4,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,2,0,0,0 },
            { 1,1,1,1,1,9,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
            };
        }

        public override void Initialize()
        {
            CreateTileArray();
            StartPosition = new Vector2(20, 400);
            enemy1Position = new Vector2(400, 400);
            enemy2Position = new Vector2(600, 400);
        }

        public override void LoadContent()
        {         
            BackgroundTexture = Content.Load<Texture2D>("Graphics\\Level1");
            ObstacleSprite = Content.Load<Texture2D>("Graphics\\Tilesheet");
        }

        public override void DrawBackground (GraphicsDevice graphicsdevice)
        {
            SpriteBatch.Draw(BackgroundTexture, graphicsdevice.Viewport.Bounds, Color.White);
        }

    }
}
