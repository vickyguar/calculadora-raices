
namespace CalculadoraRaices
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TituloLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Amtbox = new System.Windows.Forms.MaskedTextBox();
            this.Bmtbox = new System.Windows.Forms.MaskedTextBox();
            this.Cmtbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Raiz1tbox = new System.Windows.Forms.TextBox();
            this.Raiz2tbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TituloLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 83);
            this.panel1.TabIndex = 0;
            // 
            // TituloLbl
            // 
            this.TituloLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TituloLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.TituloLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TituloLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.TituloLbl.Location = new System.Drawing.Point(260, 11);
            this.TituloLbl.Margin = new System.Windows.Forms.Padding(0);
            this.TituloLbl.Name = "TituloLbl";
            this.TituloLbl.Size = new System.Drawing.Size(225, 71);
            this.TituloLbl.TabIndex = 1;
            this.TituloLbl.Text = "Calculadora de raices";
            this.TituloLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadoraRaices.Properties.Resources.Imagen;
            this.pictureBox1.Location = new System.Drawing.Point(270, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Amtbox
            // 
            this.Amtbox.Location = new System.Drawing.Point(218, 184);
            this.Amtbox.Name = "Amtbox";
            this.Amtbox.Size = new System.Drawing.Size(51, 26);
            this.Amtbox.TabIndex = 2;
            this.Amtbox.ValidatingType = typeof(int);
            // 
            // Bmtbox
            // 
            this.Bmtbox.Location = new System.Drawing.Point(218, 213);
            this.Bmtbox.Name = "Bmtbox";
            this.Bmtbox.Size = new System.Drawing.Size(51, 26);
            this.Bmtbox.TabIndex = 3;
            this.Bmtbox.ValidatingType = typeof(int);
            // 
            // Cmtbox
            // 
            this.Cmtbox.Location = new System.Drawing.Point(218, 242);
            this.Cmtbox.Name = "Cmtbox";
            this.Cmtbox.Size = new System.Drawing.Size(51, 26);
            this.Cmtbox.TabIndex = 4;
            this.Cmtbox.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(184, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(184, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(184, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "c =";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(184, 285);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 8;
            this.Calcular.Text = "Calcular!";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Raiz 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Raiz 2:";
            // 
            // Raiz1tbox
            // 
            this.Raiz1tbox.Location = new System.Drawing.Point(453, 188);
            this.Raiz1tbox.Name = "Raiz1tbox";
            this.Raiz1tbox.Size = new System.Drawing.Size(112, 26);
            this.Raiz1tbox.TabIndex = 11;
            // 
            // Raiz2tbox
            // 
            this.Raiz2tbox.Location = new System.Drawing.Point(453, 220);
            this.Raiz2tbox.Name = "Raiz2tbox";
            this.Raiz2tbox.Size = new System.Drawing.Size(112, 26);
            this.Raiz2tbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.Raiz2tbox);
            this.Controls.Add(this.Raiz1tbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmtbox);
            this.Controls.Add(this.Bmtbox);
            this.Controls.Add(this.Amtbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.Name = "Form1";
            this.Text = "Calculadora de raices";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TituloLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox Amtbox;
        private System.Windows.Forms.MaskedTextBox Bmtbox;
        private System.Windows.Forms.MaskedTextBox Cmtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Raiz1tbox;
        private System.Windows.Forms.TextBox Raiz2tbox;
    }
}

