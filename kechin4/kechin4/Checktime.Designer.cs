namespace kechin4
{
    partial class timeform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timein = new System.Windows.Forms.MaskedTextBox();
            this.timeout = new System.Windows.Forms.MaskedTextBox();
            this.Timer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SVN-Transformer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(132, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "time in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SVN-Transformer", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(132, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "time out";
            // 
            // timein
            // 
            this.timein.BackColor = System.Drawing.Color.DimGray;
            this.timein.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.timein.Location = new System.Drawing.Point(137, 119);
            this.timein.Mask = "00:00";
            this.timein.Name = "timein";
            this.timein.Size = new System.Drawing.Size(335, 31);
            this.timein.TabIndex = 3;
            this.timein.ValidatingType = typeof(System.DateTime);
            // 
            // timeout
            // 
            this.timeout.BackColor = System.Drawing.Color.DimGray;
            this.timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.timeout.Location = new System.Drawing.Point(137, 205);
            this.timeout.Mask = "90:00";
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(335, 31);
            this.timeout.TabIndex = 4;
            this.timeout.ValidatingType = typeof(System.DateTime);
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.Color.Transparent;
            this.Timer.BackgroundImage = global::kechin4.Properties.Resources.Btn;
            this.Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Timer.Font = new System.Drawing.Font("SVN-Transformer", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Timer.ForeColor = System.Drawing.Color.White;
            this.Timer.Location = new System.Drawing.Point(137, 259);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(335, 68);
            this.Timer.TabIndex = 6;
            this.Timer.Text = "U S E";
            this.Timer.UseVisualStyleBackColor = false;
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SVN-Transformer", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "kechin4";
            this.label3.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::kechin4.Properties.Resources.icone;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(212, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kechin4.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.timein);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "timeform";
            this.Text = "Checktime";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox timein;
        private System.Windows.Forms.MaskedTextBox timeout;
        private System.Windows.Forms.Button Timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}