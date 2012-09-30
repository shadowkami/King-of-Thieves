﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace King_of_Thieves.Graphics
{
    static class CTextures
    {
        private static Dictionary<string, CTextureAtlas> _textures;
        private static ContentManager _content;

        public static void init(ContentManager content)
        {
            _content = content;
            _textures = new Dictionary<string, CTextureAtlas>();

            //Core textures should go here.  Things that are ALWAYS used (or small enough to not hog up memory)
            //other textures should only be loaded when they're needed and should be removed from memory asap.

            _textures.Add("test", new CTextureAtlas(_content.Load<Texture2D>("test"), 19, 23, 0));
            _textures.Add("mcDungeon2", new CTextureAtlas(_content.Load<Texture2D>("mcDungeon2"), 16, 16, 0, 1));
            _textures.Add("menu", new CTextureAtlas(_content.Load<Texture2D>("menu"), 288, 192, 0,0));
            _textures.Add("PlayerWalkDown", new CTextureAtlas(_content.Load<Texture2D>("Player"), 32, 32, 1, "0:1", "9:1", 15));
            _textures.Add("PlayerWalkLeft", new CTextureAtlas(_content.Load<Texture2D>("Player"), 32, 32, 1, "11:0", "15:1", 15));
        }

        public static CTextureAtlas texture(string name)
        {
            return _textures[name];
        }


    }
}
