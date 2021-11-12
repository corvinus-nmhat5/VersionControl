
namespace Fejlesztesi_mintak
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.carButton = new System.Windows.Forms.Button();
            this.ballButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonColor);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.ballButton);
            this.mainPanel.Controls.Add(this.carButton);
            this.mainPanel.Location = new System.Drawing.Point(0, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(796, 453);
            this.mainPanel.TabIndex = 0;
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(13, 12);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(100, 83);
            this.carButton.TabIndex = 0;
            this.carButton.Text = "CAR";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // ballButton
            // 
            this.ballButton.Location = new System.Drawing.Point(119, 12);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(100, 83);
            this.ballButton.TabIndex = 1;
            this.ballButton.Text = "BALL";
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next:";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(119, 102);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 23);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Button buttonColor;
    }
}

