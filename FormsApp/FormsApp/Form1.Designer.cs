﻿namespace FormsApp
{
    partial class workForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pictrOutput = new System.Windows.Forms.PictureBox();
            this.buttonColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictrOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.IndianRed;
            this.btnStart.Location = new System.Drawing.Point(12, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Zmaž";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictrOutput
            // 
            this.pictrOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictrOutput.Location = new System.Drawing.Point(167, 37);
            this.pictrOutput.Name = "pictrOutput";
            this.pictrOutput.Size = new System.Drawing.Size(400, 400);
            this.pictrOutput.TabIndex = 1;
            this.pictrOutput.TabStop = false;
            this.pictrOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictrOutput_MouseDown);
            this.pictrOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictrOutput_MouseMove);
            this.pictrOutput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictrOutput_MouseUp);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonColor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonColor.Location = new System.Drawing.Point(21, 89);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(129, 348);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Farba\r\n";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // workForm
            // 
            this.ClientSize = new System.Drawing.Size(596, 465);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.pictrOutput);
            this.Controls.Add(this.btnStart);
            this.Name = "workForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictrOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictrOutput;
        private System.Windows.Forms.Button buttonColor;
    }
}

