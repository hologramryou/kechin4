namespace kechin4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.direct = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Site2check = new System.Windows.Forms.RichTextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Check_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.direct);
            this.groupBox1.Controls.Add(this.Open);
            this.groupBox1.Font = new System.Drawing.Font("SVN-Transformer", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asset";
            // 
            // direct
            // 
            this.direct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.direct.Font = new System.Drawing.Font("SVN-Transformer", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.direct.ForeColor = System.Drawing.Color.Silver;
            this.direct.Location = new System.Drawing.Point(17, 28);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(240, 47);
            this.direct.TabIndex = 4;
            this.direct.Click += new System.EventHandler(this.OpenImport);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.Transparent;
            this.Open.BackgroundImage = global::kechin4.Properties.Resources.Btn;
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open.Font = new System.Drawing.Font("SVN-Transformer", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(17, 115);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(240, 60);
            this.Open.TabIndex = 3;
            this.Open.Text = "T i m e r";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.Site2check);
            this.groupBox2.Controls.Add(this.Save_btn);
            this.groupBox2.Font = new System.Drawing.Font("SVN-Transformer", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(308, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // Site2check
            // 
            this.Site2check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Site2check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Site2check.ForeColor = System.Drawing.Color.Silver;
            this.Site2check.Location = new System.Drawing.Point(22, 28);
            this.Site2check.Name = "Site2check";
            this.Site2check.Size = new System.Drawing.Size(240, 153);
            this.Site2check.TabIndex = 6;
            this.Site2check.Text = "";
            this.Site2check.Click += new System.EventHandler(this.Check_the_box);
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Transparent;
            this.Save_btn.BackgroundImage = global::kechin4.Properties.Resources.Btn;
            this.Save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_btn.Font = new System.Drawing.Font("SVN-Transformer", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(22, 196);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(240, 59);
            this.Save_btn.TabIndex = 5;
            this.Save_btn.Text = "S a v e";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save);
            // 
            // Check_Btn
            // 
            this.Check_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Check_Btn.BackgroundImage = global::kechin4.Properties.Resources.Btn;
            this.Check_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Check_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check_Btn.Font = new System.Drawing.Font("SVN-Transformer", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Check_Btn.ForeColor = System.Drawing.Color.White;
            this.Check_Btn.Location = new System.Drawing.Point(12, 273);
            this.Check_Btn.Name = "Check_Btn";
            this.Check_Btn.Size = new System.Drawing.Size(280, 65);
            this.Check_Btn.TabIndex = 2;
            this.Check_Btn.Text = "C h e c k";
            this.Check_Btn.UseVisualStyleBackColor = false;
            this.Check_Btn.Click += new System.EventHandler(this.Check);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::kechin4.Properties.Resources.icone;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SVN-Transformer", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "kechin4";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kechin4.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Check_Btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "s";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox direct;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox Site2check;
        private System.Windows.Forms.Button Check_Btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}