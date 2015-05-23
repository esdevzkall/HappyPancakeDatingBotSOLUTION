namespace HappyPancakeDatingBot
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
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.ageMinTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ageMaxTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lanTb = new System.Windows.Forms.TextBox();
            this.onlineCb = new System.Windows.Forms.CheckBox();
            this.sortNewestCb = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Användarnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lösenord";
            // 
            // usernameTb
            // 
            this.usernameTb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTb.Location = new System.Drawing.Point(109, 90);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(163, 20);
            this.usernameTb.TabIndex = 3;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(109, 116);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(163, 20);
            this.passwordTb.TabIndex = 4;
            this.passwordTb.UseSystemPasswordChar = true;
            // 
            // ageMinTb
            // 
            this.ageMinTb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ageMinTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageMinTb.Location = new System.Drawing.Point(51, 155);
            this.ageMinTb.Name = "ageMinTb";
            this.ageMinTb.Size = new System.Drawing.Size(35, 20);
            this.ageMinTb.TabIndex = 5;
            this.ageMinTb.Text = "18";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ålder";
            // 
            // ageMaxTb
            // 
            this.ageMaxTb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ageMaxTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageMaxTb.Location = new System.Drawing.Point(92, 155);
            this.ageMaxTb.Name = "ageMaxTb";
            this.ageMaxTb.Size = new System.Drawing.Size(35, 20);
            this.ageMaxTb.TabIndex = 7;
            this.ageMaxTb.Text = "30";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Län";
            // 
            // lanTb
            // 
            this.lanTb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lanTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lanTb.Location = new System.Drawing.Point(166, 155);
            this.lanTb.Name = "lanTb";
            this.lanTb.Size = new System.Drawing.Size(106, 20);
            this.lanTb.TabIndex = 9;
            this.lanTb.Text = "[Alla]";
            // 
            // onlineCb
            // 
            this.onlineCb.AutoSize = true;
            this.onlineCb.Location = new System.Drawing.Point(12, 181);
            this.onlineCb.Name = "onlineCb";
            this.onlineCb.Size = new System.Drawing.Size(56, 17);
            this.onlineCb.TabIndex = 10;
            this.onlineCb.Text = "Online";
            this.onlineCb.UseVisualStyleBackColor = true;
            // 
            // sortNewestCb
            // 
            this.sortNewestCb.AutoSize = true;
            this.sortNewestCb.Location = new System.Drawing.Point(74, 181);
            this.sortNewestCb.Name = "sortNewestCb";
            this.sortNewestCb.Size = new System.Drawing.Size(118, 17);
            this.sortNewestCb.TabIndex = 11;
            this.sortNewestCb.Text = "Sortera efter nyaste";
            this.sortNewestCb.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HappyPancakeDatingBot.Properties.Resources.tecknaderik;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(198, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 56);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HappyPancakeDatingBot.Properties.Resources.happy_pancake_logo_426x120;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Flirta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "av Zkal@Esdev.se";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sortNewestCb);
            this.Controls.Add(this.onlineCb);
            this.Controls.Add(this.lanTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageMaxTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageMinTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HappyPancake Dating Bot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox ageMinTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ageMaxTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lanTb;
        private System.Windows.Forms.CheckBox onlineCb;
        private System.Windows.Forms.CheckBox sortNewestCb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

