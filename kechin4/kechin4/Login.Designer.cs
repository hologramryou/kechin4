namespace kechin4
{
    partial class OpenTimer
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
            this.Signin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userlogin = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signin
            // 
            this.Signin.BackColor = System.Drawing.Color.Transparent;
            this.Signin.BackgroundImage = global::kechin4.Properties.Resources.Btn;
            this.Signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signin.Font = new System.Drawing.Font("SVN-Transformer", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Signin.ForeColor = System.Drawing.Color.White;
            this.Signin.Location = new System.Drawing.Point(169, 246);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(280, 70);
            this.Signin.TabIndex = 0;
            this.Signin.Text = "s i g n i n";
            this.Signin.UseVisualStyleBackColor = false;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SVN-Transformer", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(116, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SVN-Transformer", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(116, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // userlogin
            // 
            this.userlogin.BackColor = System.Drawing.Color.DimGray;
            this.userlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userlogin.Font = new System.Drawing.Font("SVN-Transformer", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.userlogin.Location = new System.Drawing.Point(267, 106);
            this.userlogin.Name = "userlogin";
            this.userlogin.Size = new System.Drawing.Size(230, 34);
            this.userlogin.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.DimGray;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("SVN-Transformer", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pass.Location = new System.Drawing.Point(267, 169);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(230, 34);
            this.pass.TabIndex = 4;
            this.pass.UseSystemPasswordChar = true;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(89, 212);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(0, 13);
            this.check.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SVN-Transformer", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OpenTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kechin4.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.userlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Signin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenTimer";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userlogin;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Label label3;
    }
}