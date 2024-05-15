namespace WindowsFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Feltoltes = new System.Windows.Forms.Button();
            this.textBox_DolgozoID = new System.Windows.Forms.TextBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_Neme = new System.Windows.Forms.TextBox();
            this.textBox_Reszleg = new System.Windows.Forms.TextBox();
            this.textBox_Belepesev = new System.Windows.Forms.TextBox();
            this.textBox_Ber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DolgozóId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Neme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Részleg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Belépésév:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bér:";
            // 
            // button_Feltoltes
            // 
            this.button_Feltoltes.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Feltoltes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Feltoltes.Location = new System.Drawing.Point(53, 125);
            this.button_Feltoltes.Name = "button_Feltoltes";
            this.button_Feltoltes.Size = new System.Drawing.Size(338, 23);
            this.button_Feltoltes.TabIndex = 6;
            this.button_Feltoltes.Text = "Feltöltés";
            this.button_Feltoltes.UseVisualStyleBackColor = false;
            this.button_Feltoltes.Click += new System.EventHandler(this.button_Feltoltes_Click);
            // 
            // textBox_DolgozoID
            // 
            this.textBox_DolgozoID.Location = new System.Drawing.Point(53, 49);
            this.textBox_DolgozoID.Name = "textBox_DolgozoID";
            this.textBox_DolgozoID.Size = new System.Drawing.Size(100, 20);
            this.textBox_DolgozoID.TabIndex = 7;
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(171, 49);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nev.TabIndex = 8;
            // 
            // textBox_Neme
            // 
            this.textBox_Neme.Location = new System.Drawing.Point(291, 49);
            this.textBox_Neme.Name = "textBox_Neme";
            this.textBox_Neme.Size = new System.Drawing.Size(100, 20);
            this.textBox_Neme.TabIndex = 9;
            // 
            // textBox_Reszleg
            // 
            this.textBox_Reszleg.Location = new System.Drawing.Point(53, 99);
            this.textBox_Reszleg.Name = "textBox_Reszleg";
            this.textBox_Reszleg.Size = new System.Drawing.Size(100, 20);
            this.textBox_Reszleg.TabIndex = 10;
            // 
            // textBox_Belepesev
            // 
            this.textBox_Belepesev.Location = new System.Drawing.Point(171, 99);
            this.textBox_Belepesev.Name = "textBox_Belepesev";
            this.textBox_Belepesev.Size = new System.Drawing.Size(100, 20);
            this.textBox_Belepesev.TabIndex = 11;
            // 
            // textBox_Ber
            // 
            this.textBox_Ber.Location = new System.Drawing.Point(291, 99);
            this.textBox_Ber.Name = "textBox_Ber";
            this.textBox_Ber.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ber.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(444, 202);
            this.Controls.Add(this.textBox_Ber);
            this.Controls.Add(this.textBox_Belepesev);
            this.Controls.Add(this.textBox_Reszleg);
            this.Controls.Add(this.textBox_Neme);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.textBox_DolgozoID);
            this.Controls.Add(this.button_Feltoltes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dolgozók Felvétele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Feltoltes;
        private System.Windows.Forms.TextBox textBox_DolgozoID;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_Neme;
        private System.Windows.Forms.TextBox textBox_Reszleg;
        private System.Windows.Forms.TextBox textBox_Belepesev;
        private System.Windows.Forms.TextBox textBox_Ber;
    }
}

