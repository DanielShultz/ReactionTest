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
    public partial class Menu : Form
    {
        TrafficLightsResult OneColorFirstTry = new TrafficLightsResult(0); 
        TrafficLightsResult OneColorRecord = new TrafficLightsResult(0);
        TrafficLightsResult ThreeColorFirstTry = new TrafficLightsResult(0);
        TrafficLightsResult ThreeColorRecod = new TrafficLightsResult(0);
        ReactionResult ReactionFirstTry = new ReactionResult(0);
        ReactionResult ReactionRecord = new ReactionResult(0);
        ReactionResult ReactionSoundFirstTry = new ReactionResult(0);
        ReactionResult ReactionSoundRecord = new ReactionResult(0);

        public Menu()
        {
            InitializeComponent();
            Log1FirstTry.Text = OneColorFirstTry.Log;
            Log1Record.Text = OneColorRecord.Log;
            Log2FirstTry.Text = ThreeColorFirstTry.Log;
            Log2Record.Text = ThreeColorRecod.Log;
            Log3FirstTry.Text = ReactionFirstTry.logValue;
            Log3Record.Text = ReactionRecord.logValue;
            Log4FirstTry.Text = ReactionSoundFirstTry.logValue;
            Log4Record.Text = ReactionSoundRecord.logValue;
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            TrafficLightsForm trafficLights = new TrafficLightsForm(1, OneColorFirstTry,OneColorRecord);
            DialogResult result = trafficLights.ShowDialog(this);
            OneColorFirstTry = trafficLights.FirstTry;
            OneColorRecord = trafficLights.Recod;
            Log1FirstTry.Text = OneColorFirstTry.Log;
            Log1Record.Text = OneColorRecord.Log;
        }

        private void Start2_Click(object sender, EventArgs e)
        {
            TrafficLightsForm trafficLights = new TrafficLightsForm(2, ThreeColorFirstTry, ThreeColorRecod);
            DialogResult result = trafficLights.ShowDialog(this);
            ThreeColorFirstTry = trafficLights.FirstTry;
            ThreeColorRecod = trafficLights.Recod;
            Log2FirstTry.Text = ThreeColorFirstTry.Log;
            Log2Record.Text = ThreeColorRecod.Log;
        }

        private void Start3_Click(object sender, EventArgs e)
        {
            ReactionForm reactionForm = new ReactionForm(false,ReactionFirstTry,ReactionRecord);
            DialogResult result = reactionForm.ShowDialog(this);
            ReactionFirstTry = reactionForm.firstTry;
            ReactionRecord = reactionForm.recod;
            Log3FirstTry.Text = ReactionFirstTry.logValue;
            Log3Record.Text = ReactionRecord.logValue;
        }

        private void Start4_Click(object sender, EventArgs e)
        {
            ReactionForm reactionForm = new ReactionForm(true,ReactionSoundFirstTry,ReactionSoundRecord);
            DialogResult result = reactionForm.ShowDialog(this);
            ReactionSoundFirstTry = reactionForm.firstTry;
            ReactionSoundRecord = reactionForm.recod;
            Log3FirstTry.Text = ReactionSoundFirstTry.logValue;
            Log3Record.Text = ReactionSoundRecord.logValue;
            reactionForm.Close();
        }
    }
}
