namespace ShutdownApplication
{
    partial class ShutdownMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_60Min = new System.Windows.Forms.Button();
            this.Button_120Min = new System.Windows.Forms.Button();
            this.Button_30Min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.TextBox_MinuteInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_60Min
            // 
            this.Button_60Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_60Min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_60Min.Location = new System.Drawing.Point(159, 47);
            this.Button_60Min.Name = "Button_60Min";
            this.Button_60Min.Size = new System.Drawing.Size(100, 67);
            this.Button_60Min.TabIndex = 0;
            this.Button_60Min.Text = "60 Minutes";
            this.Button_60Min.UseVisualStyleBackColor = false;
            this.Button_60Min.Click += new System.EventHandler(this.Button_60Min_Click);
            // 
            // Button_120Min
            // 
            this.Button_120Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_120Min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_120Min.Location = new System.Drawing.Point(289, 47);
            this.Button_120Min.Name = "Button_120Min";
            this.Button_120Min.Size = new System.Drawing.Size(100, 67);
            this.Button_120Min.TabIndex = 1;
            this.Button_120Min.Text = "120 Minutes";
            this.Button_120Min.UseVisualStyleBackColor = false;
            this.Button_120Min.Click += new System.EventHandler(this.Button_120Min_Click);
            // 
            // Button_30Min
            // 
            this.Button_30Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_30Min.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_30Min.Location = new System.Drawing.Point(27, 47);
            this.Button_30Min.Name = "Button_30Min";
            this.Button_30Min.Size = new System.Drawing.Size(100, 67);
            this.Button_30Min.TabIndex = 2;
            this.Button_30Min.Text = "30 Minutes";
            this.Button_30Min.UseVisualStyleBackColor = false;
            this.Button_30Min.Click += new System.EventHandler(this.Button_30Min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quick Shutdown Tool";
            // 
            // Button_Stop
            // 
            this.Button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_Stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Stop.Location = new System.Drawing.Point(289, 211);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(75, 23);
            this.Button_Stop.TabIndex = 4;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = false;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // TextBox_MinuteInput
            // 
            this.TextBox_MinuteInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextBox_MinuteInput.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox_MinuteInput.Location = new System.Drawing.Point(234, 137);
            this.TextBox_MinuteInput.MaxLength = 3;
            this.TextBox_MinuteInput.Name = "TextBox_MinuteInput";
            this.TextBox_MinuteInput.Size = new System.Drawing.Size(77, 20);
            this.TextBox_MinuteInput.TabIndex = 5;
            this.TextBox_MinuteInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_MinuteInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "I would like to shut down my computer in ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(318, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "minutes";
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Button_Start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Start.Location = new System.Drawing.Point(46, 211);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 23);
            this.Button_Start.TabIndex = 8;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(161, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time left in Minutes";
            // 
            // Label_Timer
            // 
            this.Label_Timer.AutoSize = true;
            this.Label_Timer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Timer.Location = new System.Drawing.Point(203, 216);
            this.Label_Timer.Name = "Label_Timer";
            this.Label_Timer.Size = new System.Drawing.Size(0, 13);
            this.Label_Timer.TabIndex = 10;
            // 
            // ShutdownMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(413, 253);
            this.Controls.Add(this.Label_Timer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_MinuteInput);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_30Min);
            this.Controls.Add(this.Button_120Min);
            this.Controls.Add(this.Button_60Min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShutdownMain";
            this.Text = "Shutdown App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_60Min;
        private System.Windows.Forms.Button Button_120Min;
        private System.Windows.Forms.Button Button_30Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.TextBox TextBox_MinuteInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Timer;
    }
}

