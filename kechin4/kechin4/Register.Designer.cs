namespace kechin4
{
    partial class Register
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
            this.Register_btn = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.Transparent;
            this.Register_btn.BackgroundImage = global::kechin4.Properties.Resources.Btn;
            this.Register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Register_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Register_btn.Location = new System.Drawing.Point(223, 282);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(165, 59);
            this.Register_btn.TabIndex = 0;
            this.Register_btn.Text = "s i g n u p";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.DimGray;
            this.user.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.user.Location = new System.Drawing.Point(246, 100);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(269, 35);
            this.user.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.DimGray;
            this.pass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pass.Location = new System.Drawing.Point(246, 158);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(269, 35);
            this.pass.TabIndex = 2;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SVN-Transformer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SVN-Transformer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(102, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SVN-Transformer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "re-password";
            // 
            // repass
            // 
            this.repass.BackColor = System.Drawing.Color.DimGray;
            this.repass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repass.Location = new System.Drawing.Point(246, 209);
            this.repass.Name = "repass";
            this.repass.Size = new System.Drawing.Size(269, 35);
            this.repass.TabIndex = 5;
            this.repass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SVN-Transformer", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "register";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::kechin4.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Register_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repass;
        private System.Windows.Forms.Label label4;
    }
}

