namespace GGEasy
{
    partial class Chapt9Prob3
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
            this.YPositionBox = new System.Windows.Forms.TextBox();
            this.XPositionBox = new System.Windows.Forms.TextBox();
            this.XPositionLabel = new System.Windows.Forms.Label();
            this.YPositionLabel = new System.Windows.Forms.Label();
            this.CoordinateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LBLOUT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YPositionBox
            // 
            this.YPositionBox.Location = new System.Drawing.Point(339, 230);
            this.YPositionBox.Name = "YPositionBox";
            this.YPositionBox.Size = new System.Drawing.Size(100, 20);
            this.YPositionBox.TabIndex = 0;
            this.YPositionBox.TextChanged += new System.EventHandler(this.YPositionBox_TextChanged);
            this.YPositionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YPositionBox_KeyPress);
            // 
            // XPositionBox
            // 
            this.XPositionBox.Location = new System.Drawing.Point(339, 144);
            this.XPositionBox.Name = "XPositionBox";
            this.XPositionBox.Size = new System.Drawing.Size(100, 20);
            this.XPositionBox.TabIndex = 1;
            this.XPositionBox.TextChanged += new System.EventHandler(this.XPositionBox_TextChanged);
            this.XPositionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XPositionBox_KeyPress);
            // 
            // XPositionLabel
            // 
            this.XPositionLabel.AutoSize = true;
            this.XPositionLabel.Location = new System.Drawing.Point(266, 144);
            this.XPositionLabel.Name = "XPositionLabel";
            this.XPositionLabel.Size = new System.Drawing.Size(54, 13);
            this.XPositionLabel.TabIndex = 2;
            this.XPositionLabel.Text = "X-Position";
            this.XPositionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // YPositionLabel
            // 
            this.YPositionLabel.AutoSize = true;
            this.YPositionLabel.Location = new System.Drawing.Point(263, 233);
            this.YPositionLabel.Name = "YPositionLabel";
            this.YPositionLabel.Size = new System.Drawing.Size(57, 13);
            this.YPositionLabel.TabIndex = 3;
            this.YPositionLabel.Text = "Y-Position ";
            this.YPositionLabel.Click += new System.EventHandler(this.YPositionLabel_Click);
            // 
            // CoordinateButton
            // 
            this.CoordinateButton.BackColor = System.Drawing.SystemColors.Info;
            this.CoordinateButton.Location = new System.Drawing.Point(339, 366);
            this.CoordinateButton.Name = "CoordinateButton";
            this.CoordinateButton.Size = new System.Drawing.Size(93, 23);
            this.CoordinateButton.TabIndex = 4;
            this.CoordinateButton.Text = "Coordinate";
            this.CoordinateButton.UseVisualStyleBackColor = false;
            this.CoordinateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Window;
            this.CloseButton.Location = new System.Drawing.Point(700, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 32);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // LBLOUT
            // 
            this.LBLOUT.AutoSize = true;
            this.LBLOUT.Location = new System.Drawing.Point(336, 392);
            this.LBLOUT.Name = "LBLOUT";
            this.LBLOUT.Size = new System.Drawing.Size(0, 13);
            this.LBLOUT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "X and Y Coordinate Postioner ";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Output.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(208, 308);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(368, 20);
            this.Output.TabIndex = 9;
            this.Output.Text = "Press \'Coordinate\' To See The Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please Enter \'X\' Coordinates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(313, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Please Enter \'Y\' Coordinates";
            // 
            // Chapt9Prob3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CoordinateButton);
            this.Controls.Add(this.YPositionLabel);
            this.Controls.Add(this.XPositionLabel);
            this.Controls.Add(this.XPositionBox);
            this.Controls.Add(this.YPositionBox);
            this.Controls.Add(this.LBLOUT);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Chapt9Prob3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Placement (Chapt.9 Prob3)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YPositionBox;
        private System.Windows.Forms.TextBox XPositionBox;
        private System.Windows.Forms.Label XPositionLabel;
        private System.Windows.Forms.Label YPositionLabel;
        private System.Windows.Forms.Button CoordinateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label LBLOUT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

