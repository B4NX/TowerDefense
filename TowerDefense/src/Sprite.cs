﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TowerDefense.src {
    class Sprite {
        /// <summary>
        /// Base class from which all sprites where supposed to be derived, apparently not
        /// </summary>
        Texture2D texture;
        Vector2 pos,speed;
        int Xmultiplier, Ymultiplier;

        public Sprite(Vector2 speed, Vector2 pos) {
            this.speed=speed;
            this.pos = pos;
            this.Xmultiplier = 1;
            this.Ymultiplier = 1;
        }
        public Sprite(Vector2 pos) {
            this.pos = pos;
        }

        public virtual void LoadContent(ContentManager content,String asset){
            this.texture = content.Load<Texture2D>(asset);
        }

        public virtual void Update(GraphicsDevice graphics) {
            this.pos.X += this.speed.X * this.Xmultiplier;
            this.pos.Y += this.speed.Y * this.Ymultiplier;
            this.Bounding(graphics);
        }

        protected virtual void Bounding(GraphicsDevice graphics) {
            if ((this.pos.X <= 0) || (this.pos.X >= graphics.Viewport.Width-this.texture.Width)) {
                this.Xmultiplier *= -1;
            }
            if ((this.pos.Y <= 0) || (this.pos.Y >= graphics.Viewport.Height-this.texture.Height)) {
                this.Ymultiplier *= -1;
            }
        }
        //Flursmynerf
        public virtual void Draw(SpriteBatch spritebatch) {
            spritebatch.Draw(this.texture, this.pos, Color.White);
        }
    }
}
