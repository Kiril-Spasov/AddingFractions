namespace AddingFractions
{
    partial class FormAddingFractions
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
            this.BtnProblem1 = new System.Windows.Forms.Button();
            this.BtnProblem2 = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnProblem1
            // 
            this.BtnProblem1.Location = new System.Drawing.Point(50, 61);
            this.BtnProblem1.Name = "BtnProblem1";
            this.BtnProblem1.Size = new System.Drawing.Size(178, 69);
            this.BtnProblem1.TabIndex = 0;
            this.BtnProblem1.Text = "Problem 1";
            this.BtnProblem1.UseVisualStyleBackColor = true;
            this.BtnProblem1.Click += new System.EventHandler(this.BtnProblem1_Click);
            // 
            // BtnProblem2
            // 
            this.BtnProblem2.Location = new System.Drawing.Point(48, 161);
            this.BtnProblem2.Name = "BtnProblem2";
            this.BtnProblem2.Size = new System.Drawing.Size(180, 69);
            this.BtnProblem2.TabIndex = 1;
            this.BtnProblem2.Text = "Problem 2";
            this.BtnProblem2.UseVisualStyleBackColor = true;
            this.BtnProblem2.Click += new System.EventHandler(this.BtnProblem2_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(295, 61);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(434, 352);
            this.TxtResult.TabIndex = 2;
            // 
            // FormAddingFractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnProblem2);
            this.Controls.Add(this.BtnProblem1);
            this.Name = "FormAddingFractions";
            this.Text = "Adding Fractions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProblem1;
        private System.Windows.Forms.Button BtnProblem2;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

