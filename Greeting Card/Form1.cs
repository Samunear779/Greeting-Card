﻿//Sam Near
//Greeting card with Leo constilation
//Sounds used from the song "Panda" by Designer 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;
namespace Greeting_Card
{
    public partial class greetingCard : Form
    {
        public greetingCard()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();                //Set up graphics pens,brushes,and font for use in the card 
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen WhitePen = new Pen(Color.White, 10);
            Pen YellowPen = new Pen(Color.Yellow, 2);
            Font smallFont = new Font("Times New Roman", 10);
            Font drawFont = new Font("Times New Roman", 30);
            SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
            SoundPlayer Gaa = new SoundPlayer(Properties.Resources.Glaaa);
            SoundPlayer Geet = new SoundPlayer(Properties.Resources.Geet);

            //Gets rid of the initial titles and image 
            cardTitle.Visible = false; 
            funnyTitle.Visible = false;
            happyImage.Visible = false;
            fg.Clear(Color.Black);

            //Writes text about the constilation, with a delay so they pop up one after another 
            Thread.Sleep(1000);
            fg.DrawString("Leo contains many bright stars, many of which were individually", smallFont, whiteBrush, 10, 400);
            Thread.Sleep(1000);
            fg.DrawString("identified by the ancients. There are four stars of first or ", smallFont, whiteBrush, 10, 410);
            Thread.Sleep(500);
            fg.DrawString("second magnitude, which render this constellation especially ", smallFont, whiteBrush, 10, 420);
            Thread.Sleep(500);
            fg.DrawString("prominent", smallFont, whiteBrush, 10, 430);
           
            //Draws the starts and adds delays and sound to each star
            Geet.Play();
            fg.FillRectangle(YellowBrush, 247, 91, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 247, 91, 227, 81);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 227, 81, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 227, 81, 200, 120);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 200, 120, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 200, 120, 206, 147);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 206, 147, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 206, 147, 118, 182);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 118, 182, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 118, 182, 77, 247);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 77, 247, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 77, 247, 133, 218);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 133, 218, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 133, 218, 250, 191);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 250, 191, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 250, 191, 236, 158);

            Geet.Play();
            fg.FillRectangle(YellowBrush, 236, 158, 5, 5);
            Thread.Sleep(500);
            fg.DrawLine(YellowPen, 236, 158, 247, 91);
            Gaa.Play();
            Thread.Sleep(5000);
            
            //Clears the graphics and draws goodbye screen 
            fg.Clear(Color.Black);
            fg.DrawString("Bye Have Good Time", drawFont, whiteBrush, 5, 200);
        }
    }
}
