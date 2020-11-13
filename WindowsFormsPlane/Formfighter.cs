﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class Formfighter : Form
    {

        private IFlyingTransport warplane;

        public Formfighter()
        {
            InitializeComponent();
        }

        public void SetWarplane(IFlyingTransport warplane)
        {
            this.warplane = warplane;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxfighter.Width, pictureBoxfighter.Height);
            Graphics gr = Graphics.FromImage(bmp);
            warplane.DrawTransport(gr);
            pictureBoxfighter.Image = bmp;
        }

        private void ButtonCreateWarplane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            warplane = new WarPlane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.ForestGreen);

            warplane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxfighter.Width,
            pictureBoxfighter.Height);
            Draw();
        }

        private void ButtonCreateFighter_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            warplane = new Fighter(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.ForestGreen,
           Color.Black, true, true);
            warplane.SetPosition(rnd.Next(10, 10), rnd.Next(64, 128), pictureBoxfighter.Width,
           pictureBoxfighter.Height);
            Draw();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    warplane.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    warplane.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    warplane.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    warplane.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
