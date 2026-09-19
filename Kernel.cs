using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using System.Security.Cryptography;
using System.Threading;
using Cosmos.Core.IOGroup;

namespace Cosmosvirtual
{


    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void drawWindows(int x, int y)
        {


            Pen pb = new Pen(Color.FromArgb(0, 0, 0));
            Pen pw = new Pen(Color.FromArgb(255, 255, 255));
            Rectangle r = new Rectangle(x, y, 200, 200);
            Rectangle r1 = new Rectangle(x, y, 200, 20);
            canvas.DrawFilledRectangle(pw, x, y, 400, 400);
            canvas.DrawRectangle(pb, x, y, 400, 400);
            canvas.DrawFilledRectangle(pb, x, y, 400, 20);
            canvas.DrawRectangle(pw, x, y, 400, 20);
        }
        public static void movetop(int x, int y)
        {

            drawWindows(x, y);


        }
        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1020;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();
                graf.cls(Color.White);
                tests.mainLoop();
                while (true)
                {
                    Thread.Sleep(200);





                    ;

                }
            }


        }
    }





    class tests



    {


        public static void mainLoop()
        {
            //


            double[] dcos = { 1.00, 0.707, 0.00, -0.707, -1.00, -0.707, 0.00, 0.707, 1.00 };
            double[] dsin = { 0.00, 0.707, 1.00, 0.707, 0.00, -0.707, -1.00, -0.707, 0.0 };
            
            Pen ppp = new Pen(Color.FromArgb(0, 0, 0));

            for (int a = 0; a < 8; a++) graf.canvas.DrawLine(ppp,(int)(dsin[a] * 150.00) + 250, (int)(dcos[a] * 150.00) + 250,(int)(dsin[a + 1] * 150.00) + 250, (int)(dcos[a + 1] * 150.00) + 250);

            graf.displays();
        }

    }





}
