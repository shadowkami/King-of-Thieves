﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using King_of_Thieves.Input;
using Gears.Cloud;
using Microsoft.Xna.Framework;

namespace King_of_Thieves.Actors.Items.Swords
{
    class CSword : CActor
    {

        public CSword(string swordName, Vector2 position) :
            base()
        {
            _position = position;
            _name = swordName;
        }

        protected override void _registerUserEvents()
        {
            base._registerUserEvents();

            _userEvents.Add(0, userEventSwing);


        }

        protected override void _initializeResources()
        {
            base._initializeResources();
            //use the gerudo sword for now
            _imageIndex.Add("swingDown", new Graphics.CSprite(Graphics.CTextures.texture("GerudoSword:SwingDown")));
            _imageIndex.Add("swingRight", new Graphics.CSprite(Graphics.CTextures.texture("GerudoSword:SwingRight")));
            _imageIndex.Add("swingLeft", new Graphics.CSprite(Graphics.CTextures.texture("GerudoSword:SwingRight"), null, true));
            _imageIndex.Add("swingUp", new Graphics.CSprite(Graphics.CTextures.texture("GerudoSword:SwingUp")));
        }

        public void userEventSwing(object sender)
        {
            _position = new Vector2(Convert.ToInt32(userParams[1]), Convert.ToInt32(userParams[2]));
            switch (userParams[0])
            {
                case "UP":
                    image = _imageIndex["swingUp"];
                    break;

                case "DOWN":
                    image = _imageIndex["swingDown"];
                    break;

                case "LEFT":
                    image = _imageIndex["swingLeft"];
                    break;

                case "RIGHT":
                    image = _imageIndex["swingRight"];
                    break;

                default:
                    break;
            }
            
        }

        public override void collide(object sender, object collider)
        {
            throw new NotImplementedException();
        }

        public override void create(object sender)
        {
            throw new NotImplementedException();
        }

        public override void destroy(object sender)
        {
            throw new NotImplementedException();
        }

        public override void draw(object sender)
        {
            throw new NotImplementedException();
        }

        public override void animationEnd(object sender)
        {
            image = null;
        }

        public override void frame(object sender)
        {
            //throw new NotImplementedException();
        }

        public override void keyDown(object sender)
        {

        }

        public override void keyRelease(object sender)
        {
            
        }

        public override void update(GameTime gameTime)
        {
            base.update(gameTime);

            
        }

        public override void drawMe()
        {
            base.drawMe();
        }

        protected override void _addCollidables()
        {
            throw new NotImplementedException();
        }
    }

}



