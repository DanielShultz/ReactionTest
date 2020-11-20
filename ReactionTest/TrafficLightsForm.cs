using ReactionTest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTest
{
    public partial class TrafficLightsForm : Form
    {
        public TrafficLightsResult FirstTry;
        TrafficLightsResult LastTry;
        public TrafficLightsResult Recod;

        int Time = 0;
        int TimeTemp = 0;
        int Cycle = 10;
        int CycleTemp = 0;
        Random rnd = new Random();
        int TrafficLights = 0;
        int TrafficLightsTemp = 0;
        int[] result = new int[10];
        public int ResultTemp = 0;
        int variant = 1;

        private void CommonStartValues()
        {
            Cycle = 0;
            CycleTemp = 0;
            TimeTemp = 0;
            Time = rnd.Next(100, 500);
            Timer.Enabled = true;
        }

        public TrafficLightsForm(int _variant, TrafficLightsResult firstTry, TrafficLightsResult record)
        {
            InitializeComponent();
            if (_variant == 1)
            {
                Green.Visible = false;
                Yellow.Visible = false;
            }
            if (_variant == 2)
            {
                variant = _variant;
            }
            FirstTry = firstTry;
            Recod = record;
            LogFirstTry.Text = FirstTry.Log;
            LogRecord.Text = Recod.Log;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Cycle<9 || Time>0)
            {
                if (Time>0)
                {
                    Time -= 1;
                    TimeTemp += 1;
                }
                else
                {
                    Cycle += 1;
                    result[Cycle] = 0;
                    Time = rnd.Next(100,500);
                    TimeTemp = 0;
                    if (variant == 1)
                    {
                        TrafficLightsRed();
                    }
                    else
                    {
                        TrafficLigtsChange();
                    }
                }
            }
            else
            {
                TrafficLightsOff();
                Timer.Enabled = false;
                ResultLog();
            }
        }

        private void TrafficLigtsChange()
        {
            while (TrafficLightsTemp == TrafficLights)
            {
                TrafficLightsTemp = rnd.Next(1, 4);
            }
            TrafficLights = TrafficLightsTemp;
            if (TrafficLights == 1)
            {
                Picture.Image = Resources._2;
            }
            if (TrafficLights == 2)
            {
                Picture.Image = Resources._4;
            }
            if (TrafficLights == 3)
            {
                Picture.Image = Resources._3;
            }
        }
        private void TrafficLightsRed()
        {
            TrafficLights = 1;
            Picture.Image = Resources._2;
        }
        private void TrafficLightsOff()
        {
            TrafficLightsTemp = 0;
            TrafficLights = 0;
            Picture.Image = Resources._1;
        }
        private void Stop()
        {
            Timer.Enabled = false;
            TrafficLightsOff();
        }
        private void ResultLog()
        {
            LastTry = new TrafficLightsResult(result);
            if (LastTry.Result<Recod.Result || Recod.Result == 0)
            {
                Recod.Result = LastTry.Result;
                Recod.Log = LastTry.Log;
                LogRecord.Text = Recod.Log;
            }
            if (FirstTry.Result == 0)
            {
                FirstTry.Result = LastTry.Result;
                FirstTry.Log = LastTry.Log;
                LogFirstTry.Text = FirstTry.Log;
            }
            Log.Text = LastTry.Log;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            CommonStartValues();
            if (variant == 1)
            {
                TrafficLightsRed();
            }
            else
            {
                TrafficLigtsChange();
            }
            CommonStartValues();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            if (TrafficLights == 1 && CycleTemp == Cycle)
            {
                result[Cycle] = TimeTemp*10;
                CycleTemp = Cycle + 1;
                if (variant == 1)
                {
                    TrafficLightsOff();
                }
                Log.Text = CycleTemp.ToString() + "/10";
            }
            else
            {
                Stop();
                Log.Text = "Вы ошиблись";
            }
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            if (TrafficLights == 2 && CycleTemp == Cycle)
            {
                result[Cycle] = TimeTemp * 10;
                CycleTemp = Cycle + 1;
                Log.Text = CycleTemp.ToString() + "/10";
            }
            else
            {
                Stop();
                Log.Text = "Вы ошиблись";
            }

        }

        private void Green_Click(object sender, EventArgs e)
        {
            if (TrafficLights == 3 && CycleTemp == Cycle)
            {
                result[Cycle] = TimeTemp * 10;
                CycleTemp = Cycle + 1;
                Log.Text = CycleTemp.ToString() + "/10";
            }
            else
            {
                Stop();
                Log.Text = "Вы ошиблись";
            }

        }
    }
}
