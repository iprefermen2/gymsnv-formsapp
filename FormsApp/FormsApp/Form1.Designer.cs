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
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.btnSucet = new System.Windows.Forms.Button();
            this.btnRozdiel = new System.Windows.Forms.Button();
            this.btnSucin = new System.Windows.Forms.Button();
            this.btnPodiel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInput.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonInput.Location = new System.Drawing.Point(12, 12);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(152, 93);
            this.buttonInput.TabIndex = 0;
            this.buttonInput.Text = "Press Me!";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.Fuchsia;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInput.ForeColor = System.Drawing.Color.Blue;
            this.textBoxInput.Location = new System.Drawing.Point(190, 241);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(281, 26);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.Text = "Nothin";
            this.textBoxInput.MouseHover += new System.EventHandler(this.textBoxInput_MouseHover);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOutput.Location = new System.Drawing.Point(190, 311);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(281, 26);
            this.textBoxOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input2";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutput.Location = new System.Drawing.Point(217, 372);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(186, 55);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.Text = "Result: ";
            // 
            // btnSucet
            // 
            this.btnSucet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSucet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSucet.ForeColor = System.Drawing.Color.Red;
            this.btnSucet.Location = new System.Drawing.Point(259, 35);
            this.btnSucet.Name = "btnSucet";
            this.btnSucet.Size = new System.Drawing.Size(132, 70);
            this.btnSucet.TabIndex = 6;
            this.btnSucet.Text = "Sucet";
            this.btnSucet.UseVisualStyleBackColor = false;
            this.btnSucet.Click += new System.EventHandler(this.btnSucet_Click);
            // 
            // btnRozdiel
            // 
            this.btnRozdiel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRozdiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozdiel.ForeColor = System.Drawing.Color.Red;
            this.btnRozdiel.Location = new System.Drawing.Point(418, 35);
            this.btnRozdiel.Name = "btnRozdiel";
            this.btnRozdiel.Size = new System.Drawing.Size(132, 70);
            this.btnRozdiel.TabIndex = 7;
            this.btnRozdiel.Text = "Rozdiel";
            this.btnRozdiel.UseVisualStyleBackColor = false;
            this.btnRozdiel.Click += new System.EventHandler(this.btnRozdiel_Click);
            // 
            // btnSucin
            // 
            this.btnSucin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSucin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSucin.ForeColor = System.Drawing.Color.Red;
            this.btnSucin.Location = new System.Drawing.Point(259, 112);
            this.btnSucin.Name = "btnSucin";
            this.btnSucin.Size = new System.Drawing.Size(132, 70);
            this.btnSucin.TabIndex = 8;
            this.btnSucin.Text = "Sucin";
            this.btnSucin.UseVisualStyleBackColor = false;
            this.btnSucin.Click += new System.EventHandler(this.btnSucin_Click);
            // 
            // btnPodiel
            // 
            this.btnPodiel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPodiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodiel.ForeColor = System.Drawing.Color.Red;
            this.btnPodiel.Location = new System.Drawing.Point(418, 113);
            this.btnPodiel.Name = "btnPodiel";
            this.btnPodiel.Size = new System.Drawing.Size(132, 70);
            this.btnPodiel.TabIndex = 9;
            this.btnPodiel.Text = "Podiel";
            this.btnPodiel.UseVisualStyleBackColor = false;
            this.btnPodiel.Click += new System.EventHandler(this.btnPodiel_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 465);
            this.Controls.Add(this.btnPodiel);
            this.Controls.Add(this.btnSucin);
            this.Controls.Add(this.btnRozdiel);
            this.Controls.Add(this.btnSucet);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonInput);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button btnSucet;
        private System.Windows.Forms.Button btnRozdiel;
        private System.Windows.Forms.Button btnSucin;
        private System.Windows.Forms.Button btnPodiel;
    }
}

