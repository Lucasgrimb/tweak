﻿namespace pruebaa
{
    partial class Form3
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
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.pB3 = new System.Windows.Forms.PictureBox();
            this.pB4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).BeginInit();
            this.SuspendLayout();
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(512, 73);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(186, 119);
            this.pB1.TabIndex = 1;
            this.pB1.TabStop = false;
            // 
            // pB2
            // 
            this.pB2.Location = new System.Drawing.Point(257, 338);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(125, 66);
            this.pB2.TabIndex = 2;
            this.pB2.TabStop = false;
            // 
            // pB3
            // 
            this.pB3.Location = new System.Drawing.Point(543, 338);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(121, 66);
            this.pB3.TabIndex = 3;
            this.pB3.TabStop = false;
            // 
            // pB4
            // 
            this.pB4.Location = new System.Drawing.Point(859, 338);
            this.pB4.Name = "pB4";
            this.pB4.Size = new System.Drawing.Size(129, 66);
            this.pB4.TabIndex = 4;
            this.pB4.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 662);
            this.Controls.Add(this.pB4);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pB3;
        private System.Windows.Forms.PictureBox pB4;
    }
}