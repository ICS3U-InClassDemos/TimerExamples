namespace TimerExamples
{
    partial class Form1
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
            this.counterLabel = new System.Windows.Forms.Label();
            this.countOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.colourOutput = new System.Windows.Forms.Label();
            this.timeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(67, 71);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(69, 25);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "Count";
            // 
            // countOutput
            // 
            this.countOutput.AutoSize = true;
            this.countOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countOutput.Location = new System.Drawing.Point(165, 71);
            this.countOutput.Name = "countOutput";
            this.countOutput.Size = new System.Drawing.Size(24, 25);
            this.countOutput.TabIndex = 1;
            this.countOutput.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countTimer
            // 
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // colourOutput
            // 
            this.colourOutput.BackColor = System.Drawing.Color.Red;
            this.colourOutput.Location = new System.Drawing.Point(167, 108);
            this.colourOutput.Name = "colourOutput";
            this.colourOutput.Size = new System.Drawing.Size(22, 23);
            this.colourOutput.TabIndex = 3;
            // 
            // timeOutput
            // 
            this.timeOutput.AutoSize = true;
            this.timeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutput.Location = new System.Drawing.Point(165, 154);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(24, 25);
            this.timeOutput.TabIndex = 4;
            this.timeOutput.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(268, 386);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.colourOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countOutput);
            this.Controls.Add(this.counterLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label countOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Label colourOutput;
        private System.Windows.Forms.Label timeOutput;
    }
}

