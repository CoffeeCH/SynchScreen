namespace SQL_Password
{
    partial class Form4
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
            this.btnZurueck = new System.Windows.Forms.Button();
            this.btnPasswortChange = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWiderholen = new System.Windows.Forms.TextBox();
            this.txtNeuPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurueck.Location = new System.Drawing.Point(158, 165);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(129, 28);
            this.btnZurueck.TabIndex = 29;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnPasswortChange
            // 
            this.btnPasswortChange.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswortChange.Location = new System.Drawing.Point(158, 126);
            this.btnPasswortChange.Name = "btnPasswortChange";
            this.btnPasswortChange.Size = new System.Drawing.Size(129, 28);
            this.btnPasswortChange.TabIndex = 28;
            this.btnPasswortChange.Text = "Ändern";
            this.btnPasswortChange.UseVisualStyleBackColor = true;
            this.btnPasswortChange.Click += new System.EventHandler(this.btnPasswortChange_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Wiederholen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Neues Passwort";
            // 
            // txtWiderholen
            // 
            this.txtWiderholen.Location = new System.Drawing.Point(158, 87);
            this.txtWiderholen.Name = "txtWiderholen";
            this.txtWiderholen.Size = new System.Drawing.Size(129, 22);
            this.txtWiderholen.TabIndex = 25;
            this.txtWiderholen.TextChanged += new System.EventHandler(this.txtWiderholen_TextChanged);
            // 
            // txtNeuPass
            // 
            this.txtNeuPass.Location = new System.Drawing.Point(158, 52);
            this.txtNeuPass.Name = "txtNeuPass";
            this.txtNeuPass.Size = new System.Drawing.Size(129, 22);
            this.txtNeuPass.TabIndex = 24;
            this.txtNeuPass.TextChanged += new System.EventHandler(this.txtNeuPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "                         ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(342, 245);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZurueck);
            this.Controls.Add(this.btnPasswortChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWiderholen);
            this.Controls.Add(this.txtNeuPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwort ändern";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnPasswortChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWiderholen;
        private System.Windows.Forms.TextBox txtNeuPass;
        private System.Windows.Forms.Label label1;
    }
}