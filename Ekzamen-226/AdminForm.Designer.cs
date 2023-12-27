namespace Ekzamen_226
{
    partial class AdminForm
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
            this.loginAdm = new System.Windows.Forms.Label();
            this.passw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.adminOpen = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginAdm
            // 
            this.loginAdm.AutoSize = true;
            this.loginAdm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginAdm.Location = new System.Drawing.Point(111, 165);
            this.loginAdm.Name = "loginAdm";
            this.loginAdm.Size = new System.Drawing.Size(53, 20);
            this.loginAdm.TabIndex = 0;
            this.loginAdm.Text = "Логин";
            // 
            // passw
            // 
            this.passw.AutoSize = true;
            this.passw.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passw.Location = new System.Drawing.Point(111, 214);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(64, 20);
            this.passw.TabIndex = 1;
            this.passw.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(155, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Администрация";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLogin.Location = new System.Drawing.Point(248, 162);
            this.textLogin.Multiline = true;
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(152, 31);
            this.textLogin.TabIndex = 3;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPassword.Location = new System.Drawing.Point(248, 216);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(152, 24);
            this.textPassword.TabIndex = 4;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // adminOpen
            // 
            this.adminOpen.FlatAppearance.BorderSize = 0;
            this.adminOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adminOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminOpen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminOpen.Location = new System.Drawing.Point(229, 320);
            this.adminOpen.Name = "adminOpen";
            this.adminOpen.Size = new System.Drawing.Size(87, 30);
            this.adminOpen.TabIndex = 5;
            this.adminOpen.Text = "Войти";
            this.adminOpen.UseVisualStyleBackColor = true;
            this.adminOpen.Click += new System.EventHandler(this.adminOpen_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(12, 9);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(21, 24);
            this.back.TabIndex = 6;
            this.back.Text = "<";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(566, 470);
            this.Controls.Add(this.back);
            this.Controls.Add(this.adminOpen);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.loginAdm);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginAdm;
        private System.Windows.Forms.Label passw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button adminOpen;
        private System.Windows.Forms.Label back;
    }
}