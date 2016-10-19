namespace assignment2
{
    partial class Assignment2
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
            this.txtMark1 = new System.Windows.Forms.TextBox();
            this.txtMark2 = new System.Windows.Forms.TextBox();
            this.txtMark3 = new System.Windows.Forms.TextBox();
            this.txtMark4 = new System.Windows.Forms.TextBox();
            this.txtMark5 = new System.Windows.Forms.TextBox();
            this.lblMark1 = new System.Windows.Forms.Label();
            this.lblMark2 = new System.Windows.Forms.Label();
            this.lblMark3 = new System.Windows.Forms.Label();
            this.lblMark4 = new System.Windows.Forms.Label();
            this.lblMark5 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMark1
            // 
            this.txtMark1.Location = new System.Drawing.Point(308, 58);
            this.txtMark1.Name = "txtMark1";
            this.txtMark1.Size = new System.Drawing.Size(100, 20);
            this.txtMark1.TabIndex = 0;
            // 
            // txtMark2
            // 
            this.txtMark2.Location = new System.Drawing.Point(308, 84);
            this.txtMark2.Name = "txtMark2";
            this.txtMark2.Size = new System.Drawing.Size(100, 20);
            this.txtMark2.TabIndex = 1;
            // 
            // txtMark3
            // 
            this.txtMark3.Location = new System.Drawing.Point(308, 110);
            this.txtMark3.Name = "txtMark3";
            this.txtMark3.Size = new System.Drawing.Size(100, 20);
            this.txtMark3.TabIndex = 2;
            // 
            // txtMark4
            // 
            this.txtMark4.Location = new System.Drawing.Point(308, 136);
            this.txtMark4.Name = "txtMark4";
            this.txtMark4.Size = new System.Drawing.Size(100, 20);
            this.txtMark4.TabIndex = 3;
            // 
            // txtMark5
            // 
            this.txtMark5.Location = new System.Drawing.Point(308, 162);
            this.txtMark5.Name = "txtMark5";
            this.txtMark5.Size = new System.Drawing.Size(100, 20);
            this.txtMark5.TabIndex = 4;
            // 
            // lblMark1
            // 
            this.lblMark1.AutoSize = true;
            this.lblMark1.Location = new System.Drawing.Point(250, 61);
            this.lblMark1.Name = "lblMark1";
            this.lblMark1.Size = new System.Drawing.Size(51, 13);
            this.lblMark1.TabIndex = 5;
            this.lblMark1.Text = "1st Mark:";
            // 
            // lblMark2
            // 
            this.lblMark2.AutoSize = true;
            this.lblMark2.Location = new System.Drawing.Point(250, 87);
            this.lblMark2.Name = "lblMark2";
            this.lblMark2.Size = new System.Drawing.Size(55, 13);
            this.lblMark2.TabIndex = 6;
            this.lblMark2.Text = "2nd Mark:";
            // 
            // lblMark3
            // 
            this.lblMark3.AutoSize = true;
            this.lblMark3.Location = new System.Drawing.Point(250, 113);
            this.lblMark3.Name = "lblMark3";
            this.lblMark3.Size = new System.Drawing.Size(52, 13);
            this.lblMark3.TabIndex = 7;
            this.lblMark3.Text = "3rd Mark:";
            // 
            // lblMark4
            // 
            this.lblMark4.AutoSize = true;
            this.lblMark4.Location = new System.Drawing.Point(250, 139);
            this.lblMark4.Name = "lblMark4";
            this.lblMark4.Size = new System.Drawing.Size(52, 13);
            this.lblMark4.TabIndex = 8;
            this.lblMark4.Text = "4th Mark:";
            // 
            // lblMark5
            // 
            this.lblMark5.AutoSize = true;
            this.lblMark5.Location = new System.Drawing.Point(250, 165);
            this.lblMark5.Name = "lblMark5";
            this.lblMark5.Size = new System.Drawing.Size(52, 13);
            this.lblMark5.TabIndex = 9;
            this.lblMark5.Text = "5th Mark:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(253, 188);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(155, 23);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "Calculate Average";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(162, 214);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(286, 161);
            this.lblDisplay.TabIndex = 11;
            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(250, 21);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(155, 23);
            this.lblInput.TabIndex = 12;
            this.lblInput.Text = "Enter your marks";
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 384);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblMark5);
            this.Controls.Add(this.lblMark4);
            this.Controls.Add(this.lblMark3);
            this.Controls.Add(this.lblMark2);
            this.Controls.Add(this.lblMark1);
            this.Controls.Add(this.txtMark5);
            this.Controls.Add(this.txtMark4);
            this.Controls.Add(this.txtMark3);
            this.Controls.Add(this.txtMark2);
            this.Controls.Add(this.txtMark1);
            this.Name = "Assignment2";
            this.Text = "Assignment 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMark1;
        private System.Windows.Forms.TextBox txtMark2;
        private System.Windows.Forms.TextBox txtMark3;
        private System.Windows.Forms.TextBox txtMark4;
        private System.Windows.Forms.TextBox txtMark5;
        private System.Windows.Forms.Label lblMark1;
        private System.Windows.Forms.Label lblMark2;
        private System.Windows.Forms.Label lblMark3;
        private System.Windows.Forms.Label lblMark4;
        private System.Windows.Forms.Label lblMark5;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblInput;
    }
}

