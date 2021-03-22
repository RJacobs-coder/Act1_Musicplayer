
namespace Programming3_Port1_MusicPlayer
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
            this.addSong = new System.Windows.Forms.Button();
            this.playFirst = new System.Windows.Forms.Button();
            this.playLast = new System.Windows.Forms.Button();
            this.playNext = new System.Windows.Forms.Button();
            this.playPrev = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.currentSongTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // addSong
            // 
            this.addSong.Location = new System.Drawing.Point(24, 40);
            this.addSong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSong.Name = "addSong";
            this.addSong.Size = new System.Drawing.Size(136, 69);
            this.addSong.TabIndex = 0;
            this.addSong.Text = "Add Song ";
            this.addSong.UseVisualStyleBackColor = true;
            this.addSong.Click += new System.EventHandler(this.addSong_Click);
            // 
            // playFirst
            // 
            this.playFirst.Location = new System.Drawing.Point(24, 138);
            this.playFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playFirst.Name = "playFirst";
            this.playFirst.Size = new System.Drawing.Size(136, 67);
            this.playFirst.TabIndex = 1;
            this.playFirst.Text = "Play First Song";
            this.playFirst.UseVisualStyleBackColor = true;
            this.playFirst.Click += new System.EventHandler(this.playFirst_Click);
            // 
            // playLast
            // 
            this.playLast.Location = new System.Drawing.Point(24, 235);
            this.playLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playLast.Name = "playLast";
            this.playLast.Size = new System.Drawing.Size(136, 71);
            this.playLast.TabIndex = 2;
            this.playLast.Text = "Play Last Song";
            this.playLast.UseVisualStyleBackColor = true;
            this.playLast.Click += new System.EventHandler(this.playLast_Click);
            // 
            // playNext
            // 
            this.playNext.Location = new System.Drawing.Point(24, 327);
            this.playNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playNext.Name = "playNext";
            this.playNext.Size = new System.Drawing.Size(136, 65);
            this.playNext.TabIndex = 3;
            this.playNext.Text = "Play Next Song";
            this.playNext.UseVisualStyleBackColor = true;
            this.playNext.Click += new System.EventHandler(this.playNext_Click);
            // 
            // playPrev
            // 
            this.playPrev.Location = new System.Drawing.Point(24, 415);
            this.playPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playPrev.Name = "playPrev";
            this.playPrev.Size = new System.Drawing.Size(136, 71);
            this.playPrev.TabIndex = 4;
            this.playPrev.Text = "Play Prev Song";
            this.playPrev.UseVisualStyleBackColor = true;
            this.playPrev.Click += new System.EventHandler(this.playPrev_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(31, 514);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(450, 44);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // currentSongTB
            // 
            this.currentSongTB.Location = new System.Drawing.Point(31, 512);
            this.currentSongTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentSongTB.Multiline = true;
            this.currentSongTB.Name = "currentSongTB";
            this.currentSongTB.ReadOnly = true;
            this.currentSongTB.Size = new System.Drawing.Size(435, 46);
            this.currentSongTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 479);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Song";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(228, 40);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 429);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 571);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentSongTB);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.playPrev);
            this.Controls.Add(this.playNext);
            this.Controls.Add(this.playLast);
            this.Controls.Add(this.playFirst);
            this.Controls.Add(this.addSong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Robert_Jacobs 30018755 Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.Button playFirst;
        private System.Windows.Forms.Button playLast;
        private System.Windows.Forms.Button playNext;
        private System.Windows.Forms.Button playPrev;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox currentSongTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

