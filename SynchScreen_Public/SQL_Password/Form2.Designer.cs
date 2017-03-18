namespace SQL_Password
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLaden = new System.Windows.Forms.Button();
            this.Auswahl = new System.Windows.Forms.GroupBox();
            this.raTermine = new System.Windows.Forms.RadioButton();
            this.raInformationen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSenden = new System.Windows.Forms.Button();
            this.btnBenutzer = new System.Windows.Forms.Button();
            this.laBenutzer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lalBefehl = new System.Windows.Forms.Label();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHilfe = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Auswahl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(238, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(791, 584);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richtextbo1_KEyDown);
            // 
            // btnLaden
            // 
            this.btnLaden.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaden.Location = new System.Drawing.Point(12, 393);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(200, 29);
            this.btnLaden.TabIndex = 3;
            this.btnLaden.Text = "SCREEN laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            this.btnLaden.Click += new System.EventHandler(this.btnLaden_Click);
            // 
            // Auswahl
            // 
            this.Auswahl.Controls.Add(this.raTermine);
            this.Auswahl.Controls.Add(this.raInformationen);
            this.Auswahl.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auswahl.Location = new System.Drawing.Point(12, 266);
            this.Auswahl.Name = "Auswahl";
            this.Auswahl.Size = new System.Drawing.Size(200, 103);
            this.Auswahl.TabIndex = 2;
            this.Auswahl.TabStop = false;
            this.Auswahl.Text = "Texte";
            this.Auswahl.Enter += new System.EventHandler(this.Auswahl_Enter);
            // 
            // raTermine
            // 
            this.raTermine.AutoSize = true;
            this.raTermine.Location = new System.Drawing.Point(24, 62);
            this.raTermine.Name = "raTermine";
            this.raTermine.Size = new System.Drawing.Size(81, 24);
            this.raTermine.TabIndex = 4;
            this.raTermine.TabStop = true;
            this.raTermine.Text = "Termine";
            this.raTermine.UseVisualStyleBackColor = true;
            this.raTermine.CheckedChanged += new System.EventHandler(this.raTermine_CheckedChanged);
            // 
            // raInformationen
            // 
            this.raInformationen.AutoSize = true;
            this.raInformationen.Location = new System.Drawing.Point(24, 35);
            this.raInformationen.Name = "raInformationen";
            this.raInformationen.Size = new System.Drawing.Size(122, 24);
            this.raInformationen.TabIndex = 3;
            this.raInformationen.TabStop = true;
            this.raInformationen.Text = "Informationen";
            this.raInformationen.UseVisualStyleBackColor = true;
            this.raInformationen.CheckedChanged += new System.EventHandler(this.raInformationen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hallo ";
            // 
            // btnSenden
            // 
            this.btnSenden.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenden.Location = new System.Drawing.Point(12, 428);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(200, 27);
            this.btnSenden.TabIndex = 4;
            this.btnSenden.Text = "SCREEN senden";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // btnBenutzer
            // 
            this.btnBenutzer.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenutzer.Location = new System.Drawing.Point(16, 217);
            this.btnBenutzer.Name = "btnBenutzer";
            this.btnBenutzer.Size = new System.Drawing.Size(197, 31);
            this.btnBenutzer.TabIndex = 1;
            this.btnBenutzer.Text = "Einstellungen";
            this.btnBenutzer.UseVisualStyleBackColor = true;
            this.btnBenutzer.Click += new System.EventHandler(this.btnBenutzer_Click);
            // 
            // laBenutzer
            // 
            this.laBenutzer.AutoSize = true;
            this.laBenutzer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laBenutzer.Location = new System.Drawing.Point(68, 173);
            this.laBenutzer.Name = "laBenutzer";
            this.laBenutzer.Size = new System.Drawing.Size(36, 25);
            this.laBenutzer.TabIndex = 6;
            this.laBenutzer.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "                                  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lalBefehl
            // 
            this.lalBefehl.AutoSize = true;
            this.lalBefehl.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalBefehl.Location = new System.Drawing.Point(12, 477);
            this.lalBefehl.Name = "lalBefehl";
            this.lalBefehl.Size = new System.Drawing.Size(48, 20);
            this.lalBefehl.TabIndex = 8;
            this.lalBefehl.Text = "Befehl";
            this.lalBefehl.Click += new System.EventHandler(this.lalBefehl_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchliessen.Location = new System.Drawing.Point(12, 619);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(200, 29);
            this.btnSchliessen.TabIndex = 5;
            this.btnSchliessen.Text = "Beenden";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(238, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(295, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "F";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(409, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "K";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHilfe
            // 
            this.btnHilfe.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHilfe.Location = new System.Drawing.Point(12, 584);
            this.btnHilfe.Name = "btnHilfe";
            this.btnHilfe.Size = new System.Drawing.Size(200, 29);
            this.btnHilfe.TabIndex = 15;
            this.btnHilfe.Text = "Hilfe";
            this.btnHilfe.UseVisualStyleBackColor = true;
            this.btnHilfe.Click += new System.EventHandler(this.btnHilfe_Click);
            this.btnHilfe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(830, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1053, 724);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHilfe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.lalBefehl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laBenutzer);
            this.Controls.Add(this.btnBenutzer);
            this.Controls.Add(this.btnSenden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Auswahl);
            this.Controls.Add(this.btnLaden);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynchScreen - v2.1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Auswahl.ResumeLayout(false);
            this.Auswahl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.GroupBox Auswahl;
        private System.Windows.Forms.RadioButton raTermine;
        private System.Windows.Forms.RadioButton raInformationen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.Button btnBenutzer;
        public System.Windows.Forms.Label laBenutzer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lalBefehl;
        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHilfe;
        private System.Windows.Forms.Button button3;
    }
}