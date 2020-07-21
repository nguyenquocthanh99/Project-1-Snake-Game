namespace Group3_GameSnack
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Group3_GameSnack.Properties.Resources.sound;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(806, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 45);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            this.btnPlay.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnPlay_ChangeUICues);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Group3_GameSnack.Properties.Resources.Tutorial;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(854, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.BackgroundImage = global::Group3_GameSnack.Properties.Resources.Cl;
            this.button3.Location = new System.Drawing.Point(229, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 80);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Group3_GameSnack.Properties.Resources.Ad;
            this.button4.Location = new System.Drawing.Point(626, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 80);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(173, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Classic Mode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(547, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Advanced Mode";
            // 
            // btnMute
            // 
            this.btnMute.BackgroundImage = global::Group3_GameSnack.Properties.Resources.Mute1;
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMute.Location = new System.Drawing.Point(806, 4);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(51, 45);
            this.btnMute.TabIndex = 6;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group3_GameSnack.Properties.Resources.MainForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 504);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMute;
    }
}