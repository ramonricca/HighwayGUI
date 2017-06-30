namespace HighwayGUI
{
    partial class HWindow
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
            this.minuteLabel = new System.Windows.Forms.Label();
            this.minuteText = new System.Windows.Forms.TextBox();
            this.reportText = new System.Windows.Forms.TextBox();
            this.truckBtn = new System.Windows.Forms.Button();
            this.carBtn = new System.Windows.Forms.Button();
            this.motoBtn = new System.Windows.Forms.Button();
            this.bikeBtn = new System.Windows.Forms.Button();
            this.trafficBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(9, 337);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(42, 13);
            this.minuteLabel.TabIndex = 1;
            this.minuteLabel.Text = "Minute:";
            // 
            // minuteText
            // 
            this.minuteText.Location = new System.Drawing.Point(61, 333);
            this.minuteText.Name = "minuteText";
            this.minuteText.ReadOnly = true;
            this.minuteText.Size = new System.Drawing.Size(100, 20);
            this.minuteText.TabIndex = 2;
            this.minuteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reportText
            // 
            this.reportText.Location = new System.Drawing.Point(12, 257);
            this.reportText.Multiline = true;
            this.reportText.Name = "reportText";
            this.reportText.ReadOnly = true;
            this.reportText.Size = new System.Drawing.Size(560, 60);
            this.reportText.TabIndex = 3;
            // 
            // truckBtn
            // 
            this.truckBtn.Location = new System.Drawing.Point(497, 331);
            this.truckBtn.Name = "truckBtn";
            this.truckBtn.Size = new System.Drawing.Size(75, 23);
            this.truckBtn.TabIndex = 4;
            this.truckBtn.Text = "Add Truck";
            this.truckBtn.UseVisualStyleBackColor = true;
            this.truckBtn.Click += new System.EventHandler(this.truckBtn_Click);
            // 
            // carBtn
            // 
            this.carBtn.Location = new System.Drawing.Point(416, 331);
            this.carBtn.Name = "carBtn";
            this.carBtn.Size = new System.Drawing.Size(75, 23);
            this.carBtn.TabIndex = 5;
            this.carBtn.Text = "Add Car";
            this.carBtn.UseVisualStyleBackColor = true;
            this.carBtn.Click += new System.EventHandler(this.carBtn_Click);
            // 
            // motoBtn
            // 
            this.motoBtn.Location = new System.Drawing.Point(335, 331);
            this.motoBtn.Name = "motoBtn";
            this.motoBtn.Size = new System.Drawing.Size(75, 23);
            this.motoBtn.TabIndex = 6;
            this.motoBtn.Text = "Add Moto";
            this.motoBtn.UseVisualStyleBackColor = true;
            this.motoBtn.Click += new System.EventHandler(this.motoBtn_Click);
            // 
            // bikeBtn
            // 
            this.bikeBtn.Location = new System.Drawing.Point(254, 331);
            this.bikeBtn.Name = "bikeBtn";
            this.bikeBtn.Size = new System.Drawing.Size(75, 23);
            this.bikeBtn.TabIndex = 7;
            this.bikeBtn.Text = "Add Bike";
            this.bikeBtn.UseVisualStyleBackColor = true;
            this.bikeBtn.Click += new System.EventHandler(this.bikeBtn_Click);
            // 
            // trafficBtn
            // 
            this.trafficBtn.Location = new System.Drawing.Point(173, 332);
            this.trafficBtn.Name = "trafficBtn";
            this.trafficBtn.Size = new System.Drawing.Size(75, 23);
            this.trafficBtn.TabIndex = 8;
            this.trafficBtn.Text = "Start";
            this.trafficBtn.UseVisualStyleBackColor = true;
            this.trafficBtn.Click += new System.EventHandler(this.trafficBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.trafficBtn);
            this.Controls.Add(this.bikeBtn);
            this.Controls.Add(this.motoBtn);
            this.Controls.Add(this.carBtn);
            this.Controls.Add(this.truckBtn);
            this.Controls.Add(this.reportText);
            this.Controls.Add(this.minuteText);
            this.Controls.Add(this.minuteLabel);
            this.Name = "HWindow";
            this.Text = "Highway Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.TextBox minuteText;
        private System.Windows.Forms.TextBox reportText;
        private System.Windows.Forms.Button truckBtn;
        private System.Windows.Forms.Button carBtn;
        private System.Windows.Forms.Button motoBtn;
        private System.Windows.Forms.Button bikeBtn;
        private System.Windows.Forms.Button trafficBtn;
        private System.Windows.Forms.Timer timer1;
    }
}