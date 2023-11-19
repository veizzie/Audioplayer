using System.Drawing;
namespace Audioplayer.netfrm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LikedMusic = new System.Windows.Forms.Button();
            this.btn_MyMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Homepage = new System.Windows.Forms.Button();
            this.panelRightSide = new System.Windows.Forms.Panel();
            this.btn_Like = new System.Windows.Forms.Button();
            this.btn_Liked = new System.Windows.Forms.Button();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_NameOfSong = new System.Windows.Forms.Label();
            this.song_picture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_deletesong = new System.Windows.Forms.Button();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.btn_RepeatSong = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.lbl_songEnd = new System.Windows.Forms.Label();
            this.lbl_songStart = new System.Windows.Forms.Label();
            this.btn_PreviousSong = new System.Windows.Forms.Button();
            this.btn_NextSong = new System.Windows.Forms.Button();
            this.slider = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelLiked = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_duration_liked = new System.Windows.Forms.Label();
            this.lbl_quantity_liked = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox_LikedMusic = new System.Windows.Forms.ListBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_QuantityOfSongs = new System.Windows.Forms.Label();
            this.lbl_AllMusic = new System.Windows.Forms.Label();
            this.picture_PlaySong = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox_AllMusic = new System.Windows.Forms.ListBox();
            this.btn_addMusic = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_HomeMessage = new System.Windows.Forms.Label();
            this.btn_PlayLiked = new System.Windows.Forms.Button();
            this.btn_PlayAllMusic = new System.Windows.Forms.Button();
            this.btn_PauseLiked = new System.Windows.Forms.Button();
            this.btn_PauseAllMusic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.song_picture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelLiked.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_PlaySong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            resources.ApplyResources(this.panelLeftSide, "panelLeftSide");
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelLeftSide.Controls.Add(this.btn_Settings);
            this.panelLeftSide.Controls.Add(this.pictureBox2);
            this.panelLeftSide.Controls.Add(this.panel1);
            this.panelLeftSide.Controls.Add(this.label1);
            this.panelLeftSide.Controls.Add(this.pictureBox1);
            this.panelLeftSide.Controls.Add(this.btn_Homepage);
            this.panelLeftSide.Name = "panelLeftSide";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.btn_Settings, "btn_Settings");
            this.btn_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_Settings.Image = global::Audioplayer.netfrm.Properties.Resources.settings_icon;
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Audioplayer.netfrm.Properties.Resources.devider;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LikedMusic);
            this.panel1.Controls.Add(this.btn_MyMusic);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btn_LikedMusic
            // 
            this.btn_LikedMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LikedMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_LikedMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_LikedMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.btn_LikedMusic, "btn_LikedMusic");
            this.btn_LikedMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_LikedMusic.Image = global::Audioplayer.netfrm.Properties.Resources.Без_названия;
            this.btn_LikedMusic.Name = "btn_LikedMusic";
            this.btn_LikedMusic.UseVisualStyleBackColor = true;
            this.btn_LikedMusic.Click += new System.EventHandler(this.btn_LikedMusic_Click);
            // 
            // btn_MyMusic
            // 
            this.btn_MyMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MyMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_MyMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_MyMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.btn_MyMusic, "btn_MyMusic");
            this.btn_MyMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_MyMusic.Image = global::Audioplayer.netfrm.Properties.Resources.channels4_profile;
            this.btn_MyMusic.Name = "btn_MyMusic";
            this.btn_MyMusic.UseVisualStyleBackColor = true;
            this.btn_MyMusic.Click += new System.EventHandler(this.btn_MyMusic_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Image = global::Audioplayer.netfrm.Properties.Resources.playlists_icon;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Audioplayer.netfrm.Properties.Resources.devider;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_Homepage
            // 
            this.btn_Homepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Homepage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_Homepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Homepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.btn_Homepage, "btn_Homepage");
            this.btn_Homepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_Homepage.Image = global::Audioplayer.netfrm.Properties.Resources.home_icon;
            this.btn_Homepage.Name = "btn_Homepage";
            this.btn_Homepage.UseVisualStyleBackColor = true;
            this.btn_Homepage.Click += new System.EventHandler(this.btn_Homepage_Click);
            // 
            // panelRightSide
            // 
            this.panelRightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelRightSide.Controls.Add(this.btn_Like);
            this.panelRightSide.Controls.Add(this.btn_Liked);
            this.panelRightSide.Controls.Add(this.lbl_Artist);
            this.panelRightSide.Controls.Add(this.lbl_NameOfSong);
            this.panelRightSide.Controls.Add(this.song_picture);
            resources.ApplyResources(this.panelRightSide, "panelRightSide");
            this.panelRightSide.Name = "panelRightSide";
            // 
            // btn_Like
            // 
            this.btn_Like.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Like.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_Like.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Like.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Like, "btn_Like");
            this.btn_Like.Image = global::Audioplayer.netfrm.Properties.Resources.Like;
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.UseVisualStyleBackColor = true;
            this.btn_Like.Click += new System.EventHandler(this.btn_Like_Click);
            // 
            // btn_Liked
            // 
            this.btn_Liked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Liked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_Liked.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Liked.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Liked, "btn_Liked");
            this.btn_Liked.Image = global::Audioplayer.netfrm.Properties.Resources.Liked;
            this.btn_Liked.Name = "btn_Liked";
            this.btn_Liked.UseVisualStyleBackColor = true;
            this.btn_Liked.Click += new System.EventHandler(this.btn_Liked_Click);
            // 
            // lbl_Artist
            // 
            resources.ApplyResources(this.lbl_Artist, "lbl_Artist");
            this.lbl_Artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_Artist_Paint);
            // 
            // lbl_NameOfSong
            // 
            resources.ApplyResources(this.lbl_NameOfSong, "lbl_NameOfSong");
            this.lbl_NameOfSong.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_NameOfSong.Name = "lbl_NameOfSong";
            this.lbl_NameOfSong.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_NameOfSong_Paint);
            // 
            // song_picture
            // 
            resources.ApplyResources(this.song_picture, "song_picture");
            this.song_picture.Name = "song_picture";
            this.song_picture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel2.Controls.Add(this.btn_deletesong);
            this.panel2.Controls.Add(this.btn_Shuffle);
            this.panel2.Controls.Add(this.btn_RepeatSong);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.volume_bar);
            this.panel2.Controls.Add(this.lbl_songEnd);
            this.panel2.Controls.Add(this.lbl_songStart);
            this.panel2.Controls.Add(this.btn_PreviousSong);
            this.panel2.Controls.Add(this.btn_NextSong);
            this.panel2.Controls.Add(this.slider);
            this.panel2.Controls.Add(this.btn_Play);
            this.panel2.Controls.Add(this.btn_Pause);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btn_deletesong
            // 
            this.btn_deletesong.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletesong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletesong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_deletesong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_deletesong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            resources.ApplyResources(this.btn_deletesong, "btn_deletesong");
            this.btn_deletesong.Image = global::Audioplayer.netfrm.Properties.Resources.delete_32_gray1;
            this.btn_deletesong.Name = "btn_deletesong";
            this.btn_deletesong.UseVisualStyleBackColor = false;
            this.btn_deletesong.Click += new System.EventHandler(this.btn_deletesong_Click);
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shuffle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_Shuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_Shuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            resources.ApplyResources(this.btn_Shuffle, "btn_Shuffle");
            this.btn_Shuffle.Image = global::Audioplayer.netfrm.Properties.Resources.Shuffle;
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.UseVisualStyleBackColor = false;
            this.btn_Shuffle.Click += new System.EventHandler(this.btn_Shuffle_Click);
            // 
            // btn_RepeatSong
            // 
            this.btn_RepeatSong.BackColor = System.Drawing.Color.Transparent;
            this.btn_RepeatSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RepeatSong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_RepeatSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_RepeatSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            resources.ApplyResources(this.btn_RepeatSong, "btn_RepeatSong");
            this.btn_RepeatSong.Image = global::Audioplayer.netfrm.Properties.Resources.repeat;
            this.btn_RepeatSong.Name = "btn_RepeatSong";
            this.btn_RepeatSong.UseVisualStyleBackColor = false;
            this.btn_RepeatSong.Click += new System.EventHandler(this.btn_RepeatSong_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Audioplayer.netfrm.Properties.Resources.Volume_ico;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // volume_bar
            // 
            resources.ApplyResources(this.volume_bar, "volume_bar");
            this.volume_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_bar.Maximum = 100;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // lbl_songEnd
            // 
            resources.ApplyResources(this.lbl_songEnd, "lbl_songEnd");
            this.lbl_songEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lbl_songEnd.Name = "lbl_songEnd";
            // 
            // lbl_songStart
            // 
            resources.ApplyResources(this.lbl_songStart, "lbl_songStart");
            this.lbl_songStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lbl_songStart.Name = "lbl_songStart";
            // 
            // btn_PreviousSong
            // 
            this.btn_PreviousSong.BackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PreviousSong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_PreviousSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_PreviousSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            resources.ApplyResources(this.btn_PreviousSong, "btn_PreviousSong");
            this.btn_PreviousSong.Image = global::Audioplayer.netfrm.Properties.Resources.previousSong1;
            this.btn_PreviousSong.Name = "btn_PreviousSong";
            this.btn_PreviousSong.UseVisualStyleBackColor = false;
            this.btn_PreviousSong.Click += new System.EventHandler(this.btn_PreviousSong_Click);
            // 
            // btn_NextSong
            // 
            this.btn_NextSong.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NextSong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_NextSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btn_NextSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            resources.ApplyResources(this.btn_NextSong, "btn_NextSong");
            this.btn_NextSong.Image = global::Audioplayer.netfrm.Properties.Resources.nextSong;
            this.btn_NextSong.Name = "btn_NextSong";
            this.btn_NextSong.UseVisualStyleBackColor = false;
            this.btn_NextSong.Click += new System.EventHandler(this.btn_NextSong_Click);
            // 
            // slider
            // 
            this.slider.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.slider, "slider");
            this.slider.Name = "slider";
            this.slider.TabStop = false;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Play, "btn_Play");
            this.btn_Play.Image = global::Audioplayer.netfrm.Properties.Resources.Group_6_1_;
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Pause, "btn_Pause");
            this.btn_Pause.Image = global::Audioplayer.netfrm.Properties.Resources.Frame_5_1_;
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Black;
            this.panelHome.BackgroundImage = global::Audioplayer.netfrm.Properties.Resources.bg;
            this.panelHome.Controls.Add(this.panelSettings);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.lbl_HomeMessage);
            this.panelHome.Controls.Add(this.btn_PlayLiked);
            this.panelHome.Controls.Add(this.btn_PlayAllMusic);
            this.panelHome.Controls.Add(this.btn_PauseLiked);
            this.panelHome.Controls.Add(this.btn_PauseAllMusic);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label5);
            resources.ApplyResources(this.panelHome, "panelHome");
            this.panelHome.Name = "panelHome";
            // 
            // panelSettings
            // 
            this.panelSettings.BackgroundImage = global::Audioplayer.netfrm.Properties.Resources.bg14__2_;
            this.panelSettings.Controls.Add(this.panelLiked);
            this.panelSettings.Controls.Add(this.panelChildForm);
            this.panelSettings.Controls.Add(this.btn_addMusic);
            this.panelSettings.Controls.Add(this.comboBox1);
            this.panelSettings.Controls.Add(this.label6);
            this.panelSettings.Controls.Add(this.label7);
            resources.ApplyResources(this.panelSettings, "panelSettings");
            this.panelSettings.Name = "panelSettings";
            // 
            // panelLiked
            // 
            this.panelLiked.BackColor = System.Drawing.Color.Black;
            this.panelLiked.BackgroundImage = global::Audioplayer.netfrm.Properties.Resources.bg14__1_;
            this.panelLiked.Controls.Add(this.panel5);
            this.panelLiked.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelLiked.Controls.Add(this.listBox_LikedMusic);
            resources.ApplyResources(this.panelLiked, "panelLiked");
            this.panelLiked.Name = "panelLiked";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Audioplayer.netfrm.Properties.Resources.header__1_;
            this.panel5.Controls.Add(this.lbl_duration_liked);
            this.panel5.Controls.Add(this.lbl_quantity_liked);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pictureBox4);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // lbl_duration_liked
            // 
            this.lbl_duration_liked.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_duration_liked, "lbl_duration_liked");
            this.lbl_duration_liked.ForeColor = System.Drawing.Color.White;
            this.lbl_duration_liked.Name = "lbl_duration_liked";
            // 
            // lbl_quantity_liked
            // 
            this.lbl_quantity_liked.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_quantity_liked, "lbl_quantity_liked");
            this.lbl_quantity_liked.ForeColor = System.Drawing.Color.White;
            this.lbl_quantity_liked.Name = "lbl_quantity_liked";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Audioplayer.netfrm.Properties.Resources.liked_216x216_;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            // 
            // listBox_LikedMusic
            // 
            this.listBox_LikedMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listBox_LikedMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBox_LikedMusic, "listBox_LikedMusic");
            this.listBox_LikedMusic.ForeColor = System.Drawing.Color.White;
            this.listBox_LikedMusic.FormattingEnabled = true;
            this.listBox_LikedMusic.Name = "listBox_LikedMusic";
            this.listBox_LikedMusic.DoubleClick += new System.EventHandler(this.listBox_LikedMusic_DoubleClick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Black;
            this.panelChildForm.BackgroundImage = global::Audioplayer.netfrm.Properties.Resources.bg14__1_;
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Controls.Add(this.player);
            this.panelChildForm.Controls.Add(this.listBox_AllMusic);
            resources.ApplyResources(this.panelChildForm, "panelChildForm");
            this.panelChildForm.Name = "panelChildForm";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Audioplayer.netfrm.Properties.Resources.header__1_;
            this.panel3.Controls.Add(this.lbl_Duration);
            this.panel3.Controls.Add(this.lbl_QuantityOfSongs);
            this.panel3.Controls.Add(this.lbl_AllMusic);
            this.panel3.Controls.Add(this.picture_PlaySong);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_Duration, "lbl_Duration");
            this.lbl_Duration.ForeColor = System.Drawing.Color.White;
            this.lbl_Duration.Name = "lbl_Duration";
            // 
            // lbl_QuantityOfSongs
            // 
            this.lbl_QuantityOfSongs.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_QuantityOfSongs, "lbl_QuantityOfSongs");
            this.lbl_QuantityOfSongs.ForeColor = System.Drawing.Color.White;
            this.lbl_QuantityOfSongs.Name = "lbl_QuantityOfSongs";
            // 
            // lbl_AllMusic
            // 
            this.lbl_AllMusic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_AllMusic, "lbl_AllMusic");
            this.lbl_AllMusic.ForeColor = System.Drawing.Color.White;
            this.lbl_AllMusic.Name = "lbl_AllMusic";
            // 
            // picture_PlaySong
            // 
            this.picture_PlaySong.Image = global::Audioplayer.netfrm.Properties.Resources.channels4_profile__216х216_;
            resources.ApplyResources(this.picture_PlaySong, "picture_PlaySong");
            this.picture_PlaySong.Name = "picture_PlaySong";
            this.picture_PlaySong.TabStop = false;
            // 
            // player
            // 
            resources.ApplyResources(this.player, "player");
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            // 
            // listBox_AllMusic
            // 
            this.listBox_AllMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listBox_AllMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBox_AllMusic, "listBox_AllMusic");
            this.listBox_AllMusic.ForeColor = System.Drawing.Color.White;
            this.listBox_AllMusic.FormattingEnabled = true;
            this.listBox_AllMusic.Name = "listBox_AllMusic";
            // 
            // btn_addMusic
            // 
            this.btn_addMusic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_addMusic, "btn_addMusic");
            this.btn_addMusic.ForeColor = System.Drawing.Color.White;
            this.btn_addMusic.Name = "btn_addMusic";
            this.btn_addMusic.UseVisualStyleBackColor = false;
            this.btn_addMusic.Click += new System.EventHandler(this.btn_addMusic_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Name = "label7";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // lbl_HomeMessage
            // 
            this.lbl_HomeMessage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_HomeMessage, "lbl_HomeMessage");
            this.lbl_HomeMessage.ForeColor = System.Drawing.Color.White;
            this.lbl_HomeMessage.Name = "lbl_HomeMessage";
            // 
            // btn_PlayLiked
            // 
            this.btn_PlayLiked.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PlayLiked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlayLiked.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PlayLiked.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PlayLiked.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btn_PlayLiked, "btn_PlayLiked");
            this.btn_PlayLiked.Image = global::Audioplayer.netfrm.Properties.Resources.play_gray_button;
            this.btn_PlayLiked.Name = "btn_PlayLiked";
            this.btn_PlayLiked.UseVisualStyleBackColor = false;
            this.btn_PlayLiked.Click += new System.EventHandler(this.btn_PlayLiked_Click);
            // 
            // btn_PlayAllMusic
            // 
            this.btn_PlayAllMusic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PlayAllMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlayAllMusic.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PlayAllMusic.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PlayAllMusic.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btn_PlayAllMusic, "btn_PlayAllMusic");
            this.btn_PlayAllMusic.Image = global::Audioplayer.netfrm.Properties.Resources.play_gray_button;
            this.btn_PlayAllMusic.Name = "btn_PlayAllMusic";
            this.btn_PlayAllMusic.UseVisualStyleBackColor = false;
            this.btn_PlayAllMusic.Click += new System.EventHandler(this.btn_PlayAllMusic_Click);
            // 
            // btn_PauseLiked
            // 
            this.btn_PauseLiked.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PauseLiked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PauseLiked.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PauseLiked.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PauseLiked.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btn_PauseLiked, "btn_PauseLiked");
            this.btn_PauseLiked.Image = global::Audioplayer.netfrm.Properties.Resources.pause_button_colored;
            this.btn_PauseLiked.Name = "btn_PauseLiked";
            this.btn_PauseLiked.UseVisualStyleBackColor = false;
            this.btn_PauseLiked.Click += new System.EventHandler(this.btn_PauseLiked_Click);
            // 
            // btn_PauseAllMusic
            // 
            this.btn_PauseAllMusic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PauseAllMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PauseAllMusic.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PauseAllMusic.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PauseAllMusic.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btn_PauseAllMusic, "btn_PauseAllMusic");
            this.btn_PauseAllMusic.Image = global::Audioplayer.netfrm.Properties.Resources.pause_button_colored;
            this.btn_PauseAllMusic.Name = "btn_PauseAllMusic";
            this.btn_PauseAllMusic.UseVisualStyleBackColor = false;
            this.btn_PauseAllMusic.Click += new System.EventHandler(this.btn_PauseAllMusic_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Audioplayer.netfrm.Properties.Resources.channels4_profile;
            this.label3.Name = "label3";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::Audioplayer.netfrm.Properties.Resources.Без_названия;
            this.label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRightSide);
            this.Controls.Add(this.panelLeftSide);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRightSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.song_picture)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelLiked.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_PlaySong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Button btn_Homepage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_MyMusic;
        private System.Windows.Forms.Button btn_LikedMusic;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel panelRightSide;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.PictureBox song_picture;
        private System.Windows.Forms.Button btn_Like;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_NextSong;
        private System.Windows.Forms.Button btn_PreviousSong;
        private System.Windows.Forms.Label lbl_songStart;
        private System.Windows.Forms.Label lbl_songEnd;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.Label lbl_NameOfSong;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_RepeatSong;
        private System.Windows.Forms.Button btn_Shuffle;
        private System.Windows.Forms.Button btn_deletesong;
        private System.Windows.Forms.Button btn_Liked;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PauseAllMusic;
        private System.Windows.Forms.Button btn_PauseLiked;
        private System.Windows.Forms.Button btn_PlayAllMusic;
        private System.Windows.Forms.Button btn_PlayLiked;
        private System.Windows.Forms.Label lbl_HomeMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelLiked;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_duration_liked;
        private System.Windows.Forms.Label lbl_quantity_liked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listBox_LikedMusic;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.ListBox listBox_AllMusic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_QuantityOfSongs;
        private System.Windows.Forms.Label lbl_AllMusic;
        private System.Windows.Forms.PictureBox picture_PlaySong;
        private System.Windows.Forms.Button btn_addMusic;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

