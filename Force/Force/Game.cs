﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Force.Classes;

namespace Force
{
    class Game : Engine
    {
        #region Shapes & Game Objects

        /* Put your game objects and shapes here.
         * Then load them in the OnLoad method. */

        Shape2D player;

        #endregion

        #region Initialise Engine

        /* Starts up the game engine */

        public Game() : base(new Vector2D(615, 515), "New Force.NET Game") { }

        #endregion

        #region Game Logic

        /* OnLoad is called before the graphics renderer starts. 
         * Use this for loading sprites, game objects, UI etc. */

        public override void OnLoad()
        {
            BackgroundColour = Color.Black;

            player = new Shape2D(new Vector2D(10, 10), new Vector2D(10, 10), "Test");
        }

        /* OnDraw is called before every frame update.
         * Use this for graphics, changing colours etc. */

        public override void OnDraw()
        {
            
        }

        /* Update is called after every frame update. 
         * Use this for movement, physics, and such */

        public override void Update()
        {
            
        }

        #endregion
    }
}
