
namespace FRESHMusicPlayer.Favorites
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.favoriteArtistsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.favoriteAlbumsListBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.favoriteTracksListBox = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.historyListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // historyListBox
            // 
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 15;
            this.historyListBox.Location = new System.Drawing.Point(3, 3);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(786, 382);
            this.historyListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.favoriteArtistsListBox);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Favorite Artists";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // favoriteArtistsListBox
            // 
            this.favoriteArtistsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoriteArtistsListBox.FormattingEnabled = true;
            this.favoriteArtistsListBox.ItemHeight = 15;
            this.favoriteArtistsListBox.Location = new System.Drawing.Point(3, 3);
            this.favoriteArtistsListBox.Name = "favoriteArtistsListBox";
            this.favoriteArtistsListBox.Size = new System.Drawing.Size(786, 382);
            this.favoriteArtistsListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.favoriteAlbumsListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Favorite Albums";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // favoriteAlbumsListBox
            // 
            this.favoriteAlbumsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoriteAlbumsListBox.FormattingEnabled = true;
            this.favoriteAlbumsListBox.ItemHeight = 15;
            this.favoriteAlbumsListBox.Location = new System.Drawing.Point(0, 0);
            this.favoriteAlbumsListBox.Name = "favoriteAlbumsListBox";
            this.favoriteAlbumsListBox.Size = new System.Drawing.Size(792, 388);
            this.favoriteAlbumsListBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.favoriteTracksListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 388);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Favorite Tracks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // favoriteTracksListBox
            // 
            this.favoriteTracksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoriteTracksListBox.FormattingEnabled = true;
            this.favoriteTracksListBox.ItemHeight = 15;
            this.favoriteTracksListBox.Location = new System.Drawing.Point(0, 0);
            this.favoriteTracksListBox.Name = "favoriteTracksListBox";
            this.favoriteTracksListBox.Size = new System.Drawing.Size(792, 388);
            this.favoriteTracksListBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 388);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Options";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.infoLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 34);
            this.panel2.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(7, 10);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(38, 15);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(718, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Nuke Tracking File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "FRESHMusicPlayer Favorites";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.ListBox favoriteArtistsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox favoriteAlbumsListBox;
        private System.Windows.Forms.ListBox favoriteTracksListBox;
        private System.Windows.Forms.Button button2;
    }
}

