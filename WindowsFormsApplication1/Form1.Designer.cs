﻿namespace WindowsFormsApplication1
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
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.Ite = new System.Windows.Forms.Button();
            this.Rec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 42);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(150, 36);
            this.txt.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(12, 177);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(150, 23);
            this.lbl.TabIndex = 1;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ite
            // 
            this.Ite.Location = new System.Drawing.Point(12, 84);
            this.Ite.Name = "Ite";
            this.Ite.Size = new System.Drawing.Size(62, 76);
            this.Ite.TabIndex = 3;
            this.Ite.Text = "Iterativo";
            this.Ite.UseVisualStyleBackColor = true;
            this.Ite.Click += new System.EventHandler(this.Iterativo);
            // 
            // Rec
            // 
            this.Rec.Location = new System.Drawing.Point(97, 84);
            this.Rec.Name = "Rec";
            this.Rec.Size = new System.Drawing.Size(65, 76);
            this.Rec.TabIndex = 4;
            this.Rec.Text = "Recursivo";
            this.Rec.UseVisualStyleBackColor = true;
            this.Rec.Click += new System.EventHandler(this.Recursivo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite um número inteiro\r\npositivo.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rec);
            this.Controls.Add(this.Ite);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button Ite;
        private System.Windows.Forms.Button Rec;
        private System.Windows.Forms.Label label1;
    }
}

