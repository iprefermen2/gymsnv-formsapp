namespace FormsApp
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictrOutput = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictrOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(12, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 46);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Zmaž";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictrOutput
            // 
            this.pictrOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictrOutput.Location = new System.Drawing.Point(167, 37);
            this.pictrOutput.Name = "pictrOutput";
            this.pictrOutput.Size = new System.Drawing.Size(400, 400);
            this.pictrOutput.TabIndex = 1;
            this.pictrOutput.TabStop = false;
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(16, 120);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(134, 50);
            this.btnPaint.TabIndex = 2;
            this.btnPaint.Text = "Kresli";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 465);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.pictrOutput);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictrOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictrOutput;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnPaint;
    }
}

