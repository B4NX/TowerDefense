﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TowerDefense.src {
    static class Player {
        public static int Money = 500;
        public static int Score = 0;
        public static int Health = 100;
        private static SpriteFont font;
        private static SpriteBatch spriteBatch;
        public static SpriteBatch sprite { set { spriteBatch = value; } }


        public static bool BuyTower(Tower t) {
            if (t.cost > Money) {
                return false;
            } else {
                Money -= t.cost;
                return true;
            }
        }

        public static void LoadContent(ContentManager content){
            font = content.Load<SpriteFont>("font");
        }

        public static void Update() {
            if (Health <= 0) {
                GV.PLAY = 2;
            }

            if (Input.isKeyPressed(Keys.D1)) {
                //buy a first tower
                Tower1 t = new Tower1(Input.getPos(), GV.grid, 0.1f);
                if (!BuyTower(t)) {//If you can't buy the tower
                    t = null;
                }
                else {
                    GV.TowerList.Add(t);
                }
            }
            if (Input.isKeyPressed(Keys.D2)) {
                //buy a first tower
                Tower2 t = new Tower2(Input.getPos(), GV.grid, 0.9f);
                if (!BuyTower(t)) {//If you can't buy the tower
                    t = null;
                }
                else {
                    GV.TowerList.Add(t);
                }
            }
            if (Input.isKeyPressed(Keys.D3)) {
                //buy a first tower
                Tower3 t = new Tower3(Input.getPos(), GV.grid, 0.9f);
                if (!BuyTower(t)) {//If you can't buy the tower
                    t = null;
                }
                else {
                    GV.TowerList.Add(t);
                }
            }
            if (Input.isKeyPressed(Keys.D4)) {
                //buy a first tower
                Tower4 t = new Tower4(Input.getPos(), GV.grid, 0.9f);
                if (!BuyTower(t)) {//If you can't buy the tower
                    t = null;
                }
                else {
                    GV.TowerList.Add(t);
                }
            }
        }

        public static void Draw(SpriteBatch spritebatch) {
            spritebatch.DrawString(font, "Score: "+Score.ToString(), new Vector2(165, 25), Color.Black,0.0f,new Vector2(),1.0f,SpriteEffects.None,0.1f);
            spritebatch.DrawString(font, "Health: "+Health.ToString(), new Vector2(396, 25), Color.Black,0.0f,new Vector2(),1.0f,SpriteEffects.None,0.1f);
            spritebatch.DrawString(font, "Money: "+Money.ToString(), new Vector2(200, 450), Color.Black,0.0f,new Vector2(),1.0f,SpriteEffects.None,0.1f);
        }
    }
}
