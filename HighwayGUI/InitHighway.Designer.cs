namespace HighwayGUI
{
    partial class InitHighway
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
            this.hLengthLabel = new System.Windows.Forms.Label();
            this.hLengthText = new System.Windows.Forms.TextBox();
            this.maxVehiclesLabel = new System.Windows.Forms.Label();
            this.maxVehiclesText = new System.Windows.Forms.TextBox();
            this.totalMinLabel = new System.Windows.Forms.Label();
            this.totalMinText = new System.Windows.Forms.TextBox();
            this.createHighway = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hLengthLabel
            // 
            this.hLengthLabel.AutoSize = true;
            this.hLengthLabel.Location = new System.Drawing.Point(13, 16);
            this.hLengthLabel.Name = "hLengthLabel";
            this.hLengthLabel.Size = new System.Drawing.Size(119, 13);
            this.hLengthLabel.TabIndex = 4;
            this.hLengthLabel.Text = "Highway Length (miles):";
            // 
            // hLengthText
            // 
            this.hLengthText.Location = new System.Drawing.Point(147, 13);
            this.hLengthText.Name = "hLengthText";
            this.hLengthText.Size = new System.Drawing.Size(125, 20);
            this.hLengthText.TabIndex = 0;
            // 
            // maxVehiclesLabel
            // 
            this.maxVehiclesLabel.AutoSize = true;
            this.maxVehiclesLabel.Location = new System.Drawing.Point(13, 43);
            this.maxVehiclesLabel.Name = "maxVehiclesLabel";
            this.maxVehiclesLabel.Size = new System.Drawing.Size(125, 13);
            this.maxVehiclesLabel.TabIndex = 5;
            this.maxVehiclesLabel.Text = "Maximum Num. Vehicles:";
            // 
            // maxVehiclesText
            // 
            this.maxVehiclesText.Location = new System.Drawing.Point(147, 40);
            this.maxVehiclesText.Name = "maxVehiclesText";
            this.maxVehiclesText.Size = new System.Drawing.Size(125, 20);
            this.maxVehiclesText.TabIndex = 1;
            // 
            // totalMinLabel
            // 
            this.totalMinLabel.AutoSize = true;
            this.totalMinLabel.Location = new System.Drawing.Point(13, 70);
            this.totalMinLabel.Name = "totalMinLabel";
            this.totalMinLabel.Size = new System.Drawing.Size(102, 13);
            this.totalMinLabel.TabIndex = 6;
            this.totalMinLabel.Text = "Total Num. Minutes:";
            // 
            // totalMinText
            // 
            this.totalMinText.Location = new System.Drawing.Point(147, 67);
            this.totalMinText.Name = "totalMinText";
            this.totalMinText.Size = new System.Drawing.Size(125, 20);
            this.totalMinText.TabIndex = 2;
            // 
            // createHighway
            // 
            this.createHighway.Location = new System.Drawing.Point(58, 104);
            this.createHighway.Name = "createHighway";
            this.createHighway.Size = new System.Drawing.Size(163, 23);
            this.createHighway.TabIndex = 3;
            this.createHighway.Text = "Create Highway Sim";
            this.createHighway.UseVisualStyleBackColor = true;
            this.createHighway.Click += new System.EventHandler(this.createHighway_Click);
            // 
            // InitHighway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.createHighway);
            this.Controls.Add(this.totalMinText);
            this.Controls.Add(this.totalMinLabel);
            this.Controls.Add(this.maxVehiclesText);
            this.Controls.Add(this.maxVehiclesLabel);
            this.Controls.Add(this.hLengthText);
            this.Controls.Add(this.hLengthLabel);
            this.Name = "InitHighway";
            this.Text = "InitHighway";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hLengthLabel;
        private System.Windows.Forms.TextBox hLengthText;
        private System.Windows.Forms.Label maxVehiclesLabel;
        private System.Windows.Forms.TextBox maxVehiclesText;
        private System.Windows.Forms.Label totalMinLabel;
        private System.Windows.Forms.TextBox totalMinText;
        private System.Windows.Forms.Button createHighway;
    }
}