using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTest
{
    public partial class ReactionForm : Form
    {
        public ReactionResult firstTry;
        ReactionResult lastTry;
        public ReactionResult recod;

        int tick = 0;
        int lampTick = 0;
        int[] radiants = new int[3];
        int[] result = new int[3];
        bool lampEnable = false;
        bool beeepEnable = false;
        int beepValue = 0;
        Bitmap arrow;
        Random rnd = new Random();
        SoundPlayer beeep = new SoundPlayer (Properties.Resources.Beeep);

        public ReactionForm(bool be, ReactionResult f, ReactionResult r)
        {
            InitializeComponent();
            arrow = (Bitmap)Circle.Image;
            firstTry = f;
            recod = r;
            if (be)
            {
                beeepEnable = be;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Timer.Enabled)
            {
                Timer.Enabled = false;
                Start.Text = "Старт";
                result[0] = (int)Answer0.Value;
                result[1] = (int)Answer1.Value;
                result[2] = (int)Answer2.Value;
                lastTry = new ReactionResult(radiants,result);
                Radiant0.Text = radiants[0].ToString();
                Radiant1.Text = radiants[1].ToString();
                Radiant2.Text = radiants[2].ToString();
                Result0.Text = lastTry.result[0].ToString();
                Result1.Text = lastTry.result[1].ToString();
                Result2.Text = lastTry.result[2].ToString();
                MiddleResult.Text = lastTry.middleValue.ToString();
                if (firstTry.middleValue == 0)
                {
                    firstTry = lastTry;
                }
                if (recod.middleValue == 0 || recod.middleValue > lastTry.middleValue)
                {
                    recod = lastTry;
                }
                Time.Text = lastTry.logValue;
            }
            else
            {
                Timer.Enabled = true;
                Start.Text = "Стоп";
                radiants[0] = rnd.Next(0, 100);
                radiants[1] = rnd.Next(120, 220);
                radiants[2] = rnd.Next(240, 340);
                if (beeepEnable)
                {
                    beepValue = rnd.Next(0, 3);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tick < 360)
            {
                if (lampTick > 10)
                {
                    lampTick = 0;
                    lampEnable = false;
                    Lamp.Image = Properties.Resources.Lamp_1;
                }
                if (lampEnable)
                {
                    lampTick++;
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (tick == radiants[i])
                        {
                            if (beeepEnable && i == beepValue)
                            {
                                beeep.Play();
                            }
                            lampEnable = true;
                            Lamp.Image = Properties.Resources.Lamp_2;
                        }
                    }
                }
                tick++;
            }
            else
            {
                tick = 0;
            }
            Circle.Image = rotateImage(arrow, tick);
        }

        private Bitmap rotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);

            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }

            return returnBitmap;
        }
    }
}
