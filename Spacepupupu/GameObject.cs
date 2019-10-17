﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spacepupupu
{
    class GameObject
    {
        protected Texture2D gfx;
        protected Vector2 pos;

        public GameObject(Texture2D gfx, float X, float Y)
        {
            this.gfx = gfx;
            this.pos.Y = Y;
            this.pos.X = X;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(gfx, pos, Color.White);
        }
        public float X { get { return pos.X; } }
        public float Y { get { return pos.Y; } }
        public float Width { get { return gfx.Width; } }
        public float Height { get { return gfx.Height; } }
    }
    class MovingObject : GameObject
    {
        protected Vector2 speed;
        public MovingObject(Texture2D gfx, float X, float Y, float speedX, float speedY):base(gfx, X, Y)
        {
            this.speed.X = speedX;
            this.speed.Y = speedY;
        }
    }
}
