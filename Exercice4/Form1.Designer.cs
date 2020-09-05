namespace Exercice4
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
            this.lblNb1 = new System.Windows.Forms.Label();
            this.lblNb2 = new System.Windows.Forms.Label();
            this.txtNb1 = new System.Windows.Forms.TextBox();
            this.txtNb2 = new System.Windows.Forms.TextBox();
            this.btnValid1 = new System.Windows.Forms.Button();
            this.btnValid2 = new System.Windows.Forms.Button();
            this.btnGetSuite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNb1
            // 
            this.lblNb1.AutoSize = true;
            this.lblNb1.Location = new System.Drawing.Point(41, 43);
            this.lblNb1.Name = "lblNb1";
            this.lblNb1.Size = new System.Drawing.Size(86, 25);
            this.lblNb1.TabIndex = 0;
            this.lblNb1.Text = "Entier 1";
            // 
            // lblNb2
            // 
            this.lblNb2.AutoSize = true;
            this.lblNb2.Location = new System.Drawing.Point(215, 43);
            this.lblNb2.Name = "lblNb2";
            this.lblNb2.Size = new System.Drawing.Size(86, 25);
            this.lblNb2.TabIndex = 1;
            this.lblNb2.Text = "Entier 2";
            // 
            // txtNb1
            // 
            this.txtNb1.Location = new System.Drawing.Point(46, 101);
            this.txtNb1.Name = "txtNb1";
            this.txtNb1.Size = new System.Drawing.Size(100, 31);
            this.txtNb1.TabIndex = 2;
            // 
            // txtNb2
            // 
            this.txtNb2.Location = new System.Drawing.Point(220, 101);
            this.txtNb2.Name = "txtNb2";
            this.txtNb2.Size = new System.Drawing.Size(100, 31);
            this.txtNb2.TabIndex = 3;
            // 
            // btnValid1
            // 
            this.btnValid1.Location = new System.Drawing.Point(46, 181);
            this.btnValid1.Name = "btnValid1";
            this.btnValid1.Size = new System.Drawing.Size(100, 38);
            this.btnValid1.TabIndex = 4;
            this.btnValid1.Text = "Valider";
            this.btnValid1.UseVisualStyleBackColor = true;
            this.btnValid1.Click += new System.EventHandler(this.btnValid1_Click);
            // 
            // btnValid2
            // 
            this.btnValid2.Location = new System.Drawing.Point(220, 181);
            this.btnValid2.Name = "btnValid2";
            this.btnValid2.Size = new System.Drawing.Size(100, 38);
            this.btnValid2.TabIndex = 5;
            this.btnValid2.Text = "Valider";
            this.btnValid2.UseVisualStyleBackColor = true;
            this.btnValid2.Click += new System.EventHandler(this.btnValid2_Click);
            // 
            // btnGetSuite
            // 
            this.btnGetSuite.Location = new System.Drawing.Point(46, 265);
            this.btnGetSuite.Name = "btnGetSuite";
            this.btnGetSuite.Size = new System.Drawing.Size(274, 47);
            this.btnGetSuite.TabIndex = 6;
            this.btnGetSuite.Text = "Get Suite";
            this.btnGetSuite.UseVisualStyleBackColor = true;
            this.btnGetSuite.Click += new System.EventHandler(this.btnGetSuite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 379);
            this.Controls.Add(this.btnGetSuite);
            this.Controls.Add(this.btnValid2);
            this.Controls.Add(this.btnValid1);
            this.Controls.Add(this.txtNb2);
            this.Controls.Add(this.txtNb1);
            this.Controls.Add(this.lblNb2);
            this.Controls.Add(this.lblNb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNb1;
        private System.Windows.Forms.Label lblNb2;
        private System.Windows.Forms.TextBox txtNb1;
        private System.Windows.Forms.TextBox txtNb2;
        private System.Windows.Forms.Button btnValid1;
        private System.Windows.Forms.Button btnValid2;
        private System.Windows.Forms.Button btnGetSuite;
    }
}

