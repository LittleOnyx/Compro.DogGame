using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogGame
{
    public partial class Form1: Form
    {
        #region player controller
        bool moveLeft, moveRight, moveUp, moveDown;
        #endregion

        #region animation system
        public Image[] frames;
        public int currentFrame = 0;
        public int sampleRate = 5;
        private int frameCounter = 0;
        public Point position;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        public void Test()
        {
            //test test dog หมา หมา อย่าพึ่งทำไรนะ
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) moveLeft = true;
            if (e.KeyCode == Keys.D) moveRight = true;
            if (e.KeyCode == Keys.W) moveUp = true;
            if (e.KeyCode == Keys.S) moveDown = true;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) moveLeft = false;
            if (e.KeyCode == Keys.D) moveRight = false;
            if (e.KeyCode == Keys.W) moveUp = false;
            if (e.KeyCode == Keys.S) moveDown = false;
        }
    }
}

