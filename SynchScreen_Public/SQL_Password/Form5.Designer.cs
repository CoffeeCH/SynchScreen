namespace SQL_Password
{
    partial class Form5
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
            this.laGeburtstag = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblBenuterkonto = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.laBenutzername = new System.Windows.Forms.Label();
            this.checkGeburtstag = new System.Windows.Forms.CheckBox();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laGeburtstag
            // 
            this.laGeburtstag.AutoSize = true;
            this.laGeburtstag.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laGeburtstag.Location = new System.Drawing.Point(24, 128);
            this.laGeburtstag.Name = "laGeburtstag";
            this.laGeburtstag.Size = new System.Drawing.Size(82, 20);
            this.laGeburtstag.TabIndex = 36;
            this.laGeburtstag.Text = "Geburtstag";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(24, 95);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(108, 20);
            this.lblNachname.TabIndex = 34;
            this.lblNachname.Text = "Nachname       ";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(24, 61);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(104, 20);
            this.lblVorname.TabIndex = 32;
            this.lblVorname.Text = "Vorname         ";
            // 
            // lblBenuterkonto
            // 
            this.lblBenuterkonto.AutoSize = true;
            this.lblBenuterkonto.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenuterkonto.Location = new System.Drawing.Point(24, 30);
            this.lblBenuterkonto.Name = "lblBenuterkonto";
            this.lblBenuterkonto.Size = new System.Drawing.Size(108, 20);
            this.lblBenuterkonto.TabIndex = 30;
            this.lblBenuterkonto.Text = "Benutzerkonto ";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(189, 63);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(100, 22);
            this.txtVorname.TabIndex = 37;
            this.txtVorname.TextChanged += new System.EventHandler(this.txtVorname_TextChanged);
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(189, 97);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(100, 22);
            this.txtNachname.TabIndex = 38;
            this.txtNachname.TextChanged += new System.EventHandler(this.txtNachname_TextChanged);
            // 
            // laBenutzername
            // 
            this.laBenutzername.AutoSize = true;
            this.laBenutzername.Location = new System.Drawing.Point(186, 35);
            this.laBenutzername.Name = "laBenutzername";
            this.laBenutzername.Size = new System.Drawing.Size(46, 17);
            this.laBenutzername.TabIndex = 40;
            this.laBenutzername.Text = "label1";
            this.laBenutzername.Click += new System.EventHandler(this.laBenutzername_Click);
            // 
            // checkGeburtstag
            // 
            this.checkGeburtstag.AutoSize = true;
            this.checkGeburtstag.Location = new System.Drawing.Point(189, 130);
            this.checkGeburtstag.Name = "checkGeburtstag";
            this.checkGeburtstag.Size = new System.Drawing.Size(92, 21);
            this.checkGeburtstag.TabIndex = 41;
            this.checkGeburtstag.Text = "Aktivieren";
            this.checkGeburtstag.UseVisualStyleBackColor = true;
            this.checkGeburtstag.CheckedChanged += new System.EventHandler(this.checkGeburtstag_CheckedChanged);
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurueck.Location = new System.Drawing.Point(28, 195);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(131, 29);
            this.btnZurueck.TabIndex = 42;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(189, 195);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(131, 29);
            this.btnSpeichern.TabIndex = 43;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(564, 286);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.checkGeburtstag);
            this.Controls.Add(this.laBenutzername);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.laGeburtstag);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.lblBenuterkonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzerdaten";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laGeburtstag;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblBenuterkonto;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.Label laBenutzername;
        private System.Windows.Forms.CheckBox checkGeburtstag;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label label1;
    }
}