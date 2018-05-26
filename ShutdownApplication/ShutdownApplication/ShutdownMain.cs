using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Management;
using System.Diagnostics;


namespace ShutdownApplication
{
    public partial class ShutdownMain : Form
    {
        //Delegate used for safe threading
        private delegate void SetTextDelegate(string text);

        private System.Timers.Timer Countdown;
        private int IntervalsElapsed = 0;
        

        public ShutdownMain()
        {
            InitializeComponent();
            //Creates a new timer that ticks each minute
            Countdown = new System.Timers.Timer(60000);
            Countdown.Elapsed += Countdown_Elapsed;
        }

        private void Countdown_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            IntervalsElapsed++;

            int TimeLeft = int.Parse(TextBox_MinuteInput.Text) - IntervalsElapsed;

            SetText(TimeLeft.ToString());
            
            //If the intervals reach the number set, shut down
            if (IntervalsElapsed >= int.Parse(TextBox_MinuteInput.Text))
            {
                //Starts the Windows process of shutting down the computer right away
                Process.Start("shutdown", "/s /t 0");
              
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_30Min_Click(object sender, EventArgs e)
        {
            TextBox_MinuteInput.Text = "30";
        }

        private void Button_60Min_Click(object sender, EventArgs e)
        {
            TextBox_MinuteInput.Text = "60";
        }

        private void Button_120Min_Click(object sender, EventArgs e)
        {
            TextBox_MinuteInput.Text = "120";
        }

        private void TextBox_MinuteInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Checks the key pressed and only allows a result if it is a digit or the backspace
            char KeyPress = e.KeyChar;

            if (!char.IsDigit(KeyPress) 
                && KeyPress != 8)
                e.Handled = true;

            
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            //Start the countdown timer and set the time left to the minutes input
            Countdown.Start();
            Label_Timer.Text = TextBox_MinuteInput.Text;

            TextBox_MinuteInput.ReadOnly = true;
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            //Stops the countdown timer and resets UI elements
            Countdown.Stop();
            IntervalsElapsed = 0;
            Label_Timer.Text = "";
            TextBox_MinuteInput.ReadOnly = false;
        }

        //Function to set text safely
        private void SetText(string text)
        {
            if (this.Label_Timer.InvokeRequired)
            {
                SetTextDelegate Delegate = new SetTextDelegate(SetText);
                this.Invoke(Delegate, new object[] { text });
            }
            else
            {
                this.Label_Timer.Text = text;
            }

        }
        
    }
}
