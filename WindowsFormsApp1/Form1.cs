///Astoria Buzek
///February 26th 2018
///First Summative


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //title2.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //graphics tools
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 3);
            SolidBrush drawBrush = new SolidBrush(Color.SaddleBrown);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush textBrush = new SolidBrush(Color.Black);

            //Play first audio
            SoundPlayer player = new SoundPlayer(Properties.Resources.PartyHorn);
            player.Play();

            label2.Visible = false;

            Thread.Sleep(250);
            formGraphics.Clear(Color.Aquamarine);

            title2.Visible = true;
            Refresh();
            Thread.Sleep(500);

            title2.Visible = false;
            Refresh();
            Thread.Sleep(500);

            title2.Visible = true;
            Refresh();
            Thread.Sleep(500);

            //Play Happy Birthday
            player = new SoundPlayer(Properties.Resources.HappyBirthday);
            player.Play();

            formGraphics.Clear(Color.Aquamarine);

            //draw cat
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);
            Thread.Sleep(500);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);
            Thread.Sleep(500);

            //draw ears
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);
            Thread.Sleep(500);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on left
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 185, 130, 270);
            formGraphics.DrawLine(drawPen, 85, 180, 130, 270);
            formGraphics.DrawLine(drawPen, 130, 195, 130, 270);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);

            
                //ballons on left fly away
                drawBrush = new SolidBrush(Color.Pink);
                formGraphics.FillEllipse(drawBrush, 150, 120, 50, 65);
                formGraphics.FillEllipse(drawBrush, 60, 115, 50, 65);
                drawBrush = new SolidBrush(Color.DarkViolet);
                formGraphics.FillEllipse(drawBrush, 105, 130, 50, 65);
                formGraphics.DrawLine(drawPen, 174, 185, 150, 270);
                formGraphics.DrawLine(drawPen, 85, 180, 100, 270);
                formGraphics.DrawLine(drawPen, 130, 195, 130, 270);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);


            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);


            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);


            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
                formGraphics.FillEllipse(drawBrush, 150, 120, 50, 65);
                formGraphics.FillEllipse(drawBrush, 60, 115, 50, 65);
                drawBrush = new SolidBrush(Color.DarkViolet);
                formGraphics.FillEllipse(drawBrush, 105, 130, 50, 65);
                formGraphics.DrawLine(drawPen, 174, 185, 174, 270);
                formGraphics.DrawLine(drawPen, 85, 180, 85, 270);
                formGraphics.DrawLine(drawPen, 130, 195, 130, 270);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
                formGraphics.FillEllipse(drawBrush, 150, 130, 50, 65);
                formGraphics.FillEllipse(drawBrush, 60, 125, 50, 65);
                drawBrush = new SolidBrush(Color.DarkViolet);
                formGraphics.FillEllipse(drawBrush, 105, 130, 50, 65);
                formGraphics.DrawLine(drawPen, 174, 185, 174, 270);
                formGraphics.DrawLine(drawPen, 85, 180, 85, 270);
                formGraphics.DrawLine(drawPen, 130, 195, 130, 270);


            drawBrush = new SolidBrush(Color.Pink);
                formGraphics.FillEllipse(drawBrush, 150, 120, 50, 65);
                formGraphics.FillEllipse(drawBrush, 60, 115, 50, 65);
                drawBrush = new SolidBrush(Color.DarkViolet);
                formGraphics.FillEllipse(drawBrush, 120, 115, 50, 65);
                formGraphics.DrawLine(drawPen, 174, 175, 174, 260);
                formGraphics.DrawLine(drawPen, 85, 170, 85, 260);
                formGraphics.DrawLine(drawPen, 130, 180, 130, 255);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
                formGraphics.FillEllipse(drawBrush, 150, 110, 50, 65);
                formGraphics.FillEllipse(drawBrush, 60, 105, 50, 65);
                drawBrush = new SolidBrush(Color.DarkViolet);
                formGraphics.FillEllipse(drawBrush, 105, 100, 50, 65);
                formGraphics.DrawLine(drawPen, 174, 165, 174, 250);
                formGraphics.DrawLine(drawPen, 85, 160, 85, 250);
                formGraphics.DrawLine(drawPen, 130, 165, 130, 240);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

                drawBrush = new SolidBrush(Color.Pink);
                formGraphics.FillEllipse(drawBrush, 150, 100, 50, 65);
                formGraphics.FillEllipse(drawBrush, 60, 95, 50, 65);
                drawBrush = new SolidBrush(Color.DarkViolet);
                formGraphics.FillEllipse(drawBrush, 105, 85, 50, 65);
                formGraphics.DrawLine(drawPen, 174, 155, 174, 240);
                formGraphics.DrawLine(drawPen, 85, 150, 85, 240);
                formGraphics.DrawLine(drawPen, 130, 155, 130, 225);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);


            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 90, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 85, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, 70, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 145, 174, 230);
            formGraphics.DrawLine(drawPen, 85, 140, 85, 230);
            formGraphics.DrawLine(drawPen, 130, 140, 130, 210);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 80, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 75, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, 55, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 135, 174, 220);
            formGraphics.DrawLine(drawPen, 85, 140, 85, 220);
            formGraphics.DrawLine(drawPen, 130, 125, 130, 195);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 70, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 65, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, 40, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 125, 174, 210);
            formGraphics.DrawLine(drawPen, 85, 130, 85, 210);
            formGraphics.DrawLine(drawPen, 130, 110, 130, 180);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 60, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 55, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, 25, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 115, 174, 200);
            formGraphics.DrawLine(drawPen, 85, 120, 85, 200);
            formGraphics.DrawLine(drawPen, 130, 95, 130, 165);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 50, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 45, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, 10, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 105, 174, 190);
            formGraphics.DrawLine(drawPen, 85, 110, 85, 190);
            formGraphics.DrawLine(drawPen, 130, 70, 130, 150);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 40, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 35, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, -5, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 95, 174, 180);
            formGraphics.DrawLine(drawPen, 85, 100, 85, 180);
            formGraphics.DrawLine(drawPen, 130, 55, 130, 135);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 30, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 25, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, -20, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 85, 174, 170);
            formGraphics.DrawLine(drawPen, 85, 90, 85, 170);
            formGraphics.DrawLine(drawPen, 130, 40, 130, 120);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 20, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 15, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, -35, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 75, 174, 160);
            formGraphics.DrawLine(drawPen, 85, 80, 85, 160);
            formGraphics.DrawLine(drawPen, 130, 25, 130, 105);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 10, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, 5, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, -50, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 65, 174, 150);
            formGraphics.DrawLine(drawPen, 85, 70, 85, 150);
            formGraphics.DrawLine(drawPen, 130, 10, 130, 90);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, 0, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, -5, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, -65, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 55, 174, 140);
            formGraphics.DrawLine(drawPen, 85, 60, 85, 140);
            formGraphics.DrawLine(drawPen, 130, -5, 130, 75);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, -10, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, -15, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, -80, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 45, 174, 130);
            formGraphics.DrawLine(drawPen, 85, 50, 85, 130);
            formGraphics.DrawLine(drawPen, 130, -20, 130, 60);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);
            Thread.Sleep(200);
            formGraphics.Clear(Color.Aquamarine);

            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 150, -20, 50, 65);
            formGraphics.FillEllipse(drawBrush, 60, -25, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 105, -95, 50, 65);
            formGraphics.DrawLine(drawPen, 174, 35, 174, 120);
            formGraphics.DrawLine(drawPen, 85, 40, 85, 120);
            formGraphics.DrawLine(drawPen, 130, -35, 130, 45);

            //draw cat
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillEllipse(drawBrush, 240, 210, 100, 150);
            formGraphics.FillEllipse(drawBrush, 255, 160, 70, 70);

            //draw whiskers 
            formGraphics.DrawLine(drawPen, 255, 195, 225, 195);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 185);
            formGraphics.DrawLine(drawPen, 255, 195, 225, 205);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 195);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 185);
            formGraphics.DrawLine(drawPen, 325, 195, 355, 205);

            //draw ears
            drawBrush = new SolidBrush(Color.SaddleBrown);
            formGraphics.FillPie(drawBrush, 260, 122, 30, 50, 50, 80);
            formGraphics.FillPie(drawBrush, 290, 122, 30, 50, 50, 80);

            //draw eyes with different colour
            drawBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(drawBrush, 270, 180, 5, 5);
            formGraphics.FillEllipse(drawBrush, 305, 180, 5, 5);

            //draw balloons on right
            drawBrush = new SolidBrush(Color.Pink);
            formGraphics.FillEllipse(drawBrush, 500, 120, 50, 65);
            formGraphics.FillEllipse(drawBrush, 410, 115, 50, 65);
            drawBrush = new SolidBrush(Color.DarkViolet);
            formGraphics.FillEllipse(drawBrush, 455, 130, 50, 65);
            formGraphics.DrawLine(drawPen, 525, 185, 480, 270);
            formGraphics.DrawLine(drawPen, 435, 180, 480, 270);
            formGraphics.DrawLine(drawPen, 480, 195, 480, 270);

            label1.Visible = true;

        }
    }
}
