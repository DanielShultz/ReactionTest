namespace ReactionTest
{
    partial class ReactionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReactionForm));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.NumericUpDown();
            this.Answer1 = new System.Windows.Forms.NumericUpDown();
            this.Answer0 = new System.Windows.Forms.NumericUpDown();
            this.Radiant0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Radiant2 = new System.Windows.Forms.TextBox();
            this.Radiant1 = new System.Windows.Forms.TextBox();
            this.Result1 = new System.Windows.Forms.TextBox();
            this.Result2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Result0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiddleResult = new System.Windows.Forms.TextBox();
            this.Lamp = new System.Windows.Forms.PictureBox();
            this.Circle = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Answer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Answer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Answer0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(536, 444);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(155, 82);
            this.Start.TabIndex = 2;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(530, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ответы";
            // 
            // Answer2
            // 
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(536, 134);
            this.Answer2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(155, 38);
            this.Answer2.TabIndex = 9;
            // 
            // Answer1
            // 
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.Location = new System.Drawing.Point(537, 90);
            this.Answer1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(155, 38);
            this.Answer1.TabIndex = 10;
            // 
            // Answer0
            // 
            this.Answer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer0.Location = new System.Drawing.Point(536, 46);
            this.Answer0.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Answer0.Name = "Answer0";
            this.Answer0.Size = new System.Drawing.Size(155, 38);
            this.Answer0.TabIndex = 11;
            // 
            // Radiant0
            // 
            this.Radiant0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radiant0.Location = new System.Drawing.Point(697, 46);
            this.Radiant0.Name = "Radiant0";
            this.Radiant0.ReadOnly = true;
            this.Radiant0.Size = new System.Drawing.Size(154, 38);
            this.Radiant0.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(691, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Значения";
            // 
            // Radiant2
            // 
            this.Radiant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radiant2.Location = new System.Drawing.Point(697, 134);
            this.Radiant2.Name = "Radiant2";
            this.Radiant2.ReadOnly = true;
            this.Radiant2.Size = new System.Drawing.Size(154, 38);
            this.Radiant2.TabIndex = 14;
            // 
            // Radiant1
            // 
            this.Radiant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Radiant1.Location = new System.Drawing.Point(697, 90);
            this.Radiant1.Name = "Radiant1";
            this.Radiant1.ReadOnly = true;
            this.Radiant1.Size = new System.Drawing.Size(154, 38);
            this.Radiant1.TabIndex = 14;
            // 
            // Result1
            // 
            this.Result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result1.Location = new System.Drawing.Point(697, 253);
            this.Result1.Name = "Result1";
            this.Result1.ReadOnly = true;
            this.Result1.Size = new System.Drawing.Size(154, 38);
            this.Result1.TabIndex = 17;
            // 
            // Result2
            // 
            this.Result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result2.Location = new System.Drawing.Point(697, 297);
            this.Result2.Name = "Result2";
            this.Result2.ReadOnly = true;
            this.Result2.Size = new System.Drawing.Size(154, 38);
            this.Result2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(691, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Разница";
            // 
            // Result0
            // 
            this.Result0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result0.Location = new System.Drawing.Point(697, 209);
            this.Result0.Name = "Result0";
            this.Result0.ReadOnly = true;
            this.Result0.Size = new System.Drawing.Size(154, 38);
            this.Result0.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(691, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Среднее";
            // 
            // MiddleResult
            // 
            this.MiddleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleResult.Location = new System.Drawing.Point(697, 372);
            this.MiddleResult.Name = "MiddleResult";
            this.MiddleResult.ReadOnly = true;
            this.MiddleResult.Size = new System.Drawing.Size(154, 38);
            this.MiddleResult.TabIndex = 19;
            // 
            // Lamp
            // 
            this.Lamp.Image = global::ReactionTest.Properties.Resources.Lamp_1;
            this.Lamp.Location = new System.Drawing.Point(536, 178);
            this.Lamp.Name = "Lamp";
            this.Lamp.Size = new System.Drawing.Size(155, 260);
            this.Lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lamp.TabIndex = 4;
            this.Lamp.TabStop = false;
            // 
            // Circle
            // 
            this.Circle.BackgroundImage = global::ReactionTest.Properties.Resources.Circle;
            this.Circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.Location = new System.Drawing.Point(12, 12);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(512, 514);
            this.Circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Circle.TabIndex = 3;
            this.Circle.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(691, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Время";
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(697, 447);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(154, 38);
            this.Time.TabIndex = 21;
            // 
            // ReactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 533);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MiddleResult);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.Result2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result0);
            this.Controls.Add(this.Radiant1);
            this.Controls.Add(this.Radiant2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Radiant0);
            this.Controls.Add(this.Answer0);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lamp);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReactionForm";
            this.Text = "Тест реакции";
            ((System.ComponentModel.ISupportInitialize)(this.Answer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Answer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Answer0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox Circle;
        private System.Windows.Forms.PictureBox Lamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Answer2;
        private System.Windows.Forms.NumericUpDown Answer1;
        private System.Windows.Forms.NumericUpDown Answer0;
        private System.Windows.Forms.TextBox Radiant0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Radiant2;
        private System.Windows.Forms.TextBox Radiant1;
        private System.Windows.Forms.TextBox Result1;
        private System.Windows.Forms.TextBox Result2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Result0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MiddleResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Time;
    }
}