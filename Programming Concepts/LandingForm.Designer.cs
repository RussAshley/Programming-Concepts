
namespace Programming_Concepts
{
    partial class LandingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.TextBox();
            this.CommonButton = new System.Windows.Forms.Button();
            this.OOPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Header.Location = new System.Drawing.Point(156, 21);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(488, 29);
            this.Header.TabIndex = 0;
            this.Header.Text = "Common and Object Orientated Coding Concepts";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CommonButton
            // 
            this.CommonButton.BackColor = System.Drawing.Color.GreenYellow;
            this.CommonButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommonButton.Location = new System.Drawing.Point(91, 141);
            this.CommonButton.Name = "CommonButton";
            this.CommonButton.Size = new System.Drawing.Size(242, 202);
            this.CommonButton.TabIndex = 1;
            this.CommonButton.Text = "Common Concepts";
            this.CommonButton.UseVisualStyleBackColor = false;
            this.CommonButton.Click += new System.EventHandler(this.CommonButton_Click);
            // 
            // OOPButton
            // 
            this.OOPButton.BackColor = System.Drawing.Color.IndianRed;
            this.OOPButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OOPButton.Location = new System.Drawing.Point(454, 141);
            this.OOPButton.Name = "OOPButton";
            this.OOPButton.Size = new System.Drawing.Size(238, 202);
            this.OOPButton.TabIndex = 2;
            this.OOPButton.Text = "Object Oriented Programming Concepts";
            this.OOPButton.UseVisualStyleBackColor = false;
            this.OOPButton.Click += new System.EventHandler(this.OOPButton_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OOPButton);
            this.Controls.Add(this.CommonButton);
            this.Controls.Add(this.Header);
            this.Name = "LandingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Button CommonButton;
        private System.Windows.Forms.Button OOPButton;
    }
}

