
namespace Programming_Concepts
{
    partial class CommonForm
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
            this.IterationsButton = new System.Windows.Forms.Button();
            this.SequencesButton = new System.Windows.Forms.Button();
            this.SelectionButton = new System.Windows.Forms.Button();
            this.DataButton = new System.Windows.Forms.Button();
            this.MethodsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IterationsButton
            // 
            this.IterationsButton.Location = new System.Drawing.Point(67, 41);
            this.IterationsButton.Name = "IterationsButton";
            this.IterationsButton.Size = new System.Drawing.Size(75, 23);
            this.IterationsButton.TabIndex = 0;
            this.IterationsButton.Text = "Iterations";
            this.IterationsButton.UseVisualStyleBackColor = true;
            // 
            // SequencesButton
            // 
            this.SequencesButton.Location = new System.Drawing.Point(197, 42);
            this.SequencesButton.Name = "SequencesButton";
            this.SequencesButton.Size = new System.Drawing.Size(75, 23);
            this.SequencesButton.TabIndex = 1;
            this.SequencesButton.Tag = "";
            this.SequencesButton.Text = "Sequences";
            this.SequencesButton.UseVisualStyleBackColor = true;
            // 
            // SelectionButton
            // 
            this.SelectionButton.Location = new System.Drawing.Point(354, 42);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(75, 23);
            this.SelectionButton.TabIndex = 2;
            this.SelectionButton.Text = "Selection";
            this.SelectionButton.UseVisualStyleBackColor = true;
            // 
            // DataButton
            // 
            this.DataButton.Location = new System.Drawing.Point(493, 42);
            this.DataButton.Name = "DataButton";
            this.DataButton.Size = new System.Drawing.Size(75, 23);
            this.DataButton.TabIndex = 3;
            this.DataButton.Text = "Data";
            this.DataButton.UseVisualStyleBackColor = true;
            // 
            // MethodsButton
            // 
            this.MethodsButton.Location = new System.Drawing.Point(639, 42);
            this.MethodsButton.Name = "MethodsButton";
            this.MethodsButton.Size = new System.Drawing.Size(75, 23);
            this.MethodsButton.TabIndex = 4;
            this.MethodsButton.Text = "Methods";
            this.MethodsButton.UseVisualStyleBackColor = true;
            // 
            // CommonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MethodsButton);
            this.Controls.Add(this.DataButton);
            this.Controls.Add(this.SelectionButton);
            this.Controls.Add(this.SequencesButton);
            this.Controls.Add(this.IterationsButton);
            this.Name = "CommonForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IterationsButton;
        private System.Windows.Forms.Button SequencesButton;
        private System.Windows.Forms.Button SelectionButton;
        private System.Windows.Forms.Button DataButton;
        private System.Windows.Forms.Button MethodsButton;
    }
}