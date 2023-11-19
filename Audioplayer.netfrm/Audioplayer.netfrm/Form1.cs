using System;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using NAudio.Wave;


namespace Audioplayer.netfrm
{
    public partial class Form1 : Form
    {
        #region Присваевающие методы
        string[] randomMessages =
        {
            "message1",
            "message2",
            "message3",
            "message4",
            "message5"
        };

        private void SetRandomMessage()
        {
            Random random = new Random();
            string randomMessageKey = randomMessages[random.Next(randomMessages.Length)];
            HomeMessage = strings.ResourceManager.GetString(randomMessageKey);
            lbl_HomeMessage.Text = HomeMessage;
        }

        private void SetPicture()
        {
            try
            {
                if (currentPlaylist == PlaylistType.AllMusic)
                {
                    var file = TagLib.File.Create(paths[listBox_AllMusic.SelectedIndex]);
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    MemoryStream memory = new MemoryStream(bin);
                    song_picture.Image = System.Drawing.Image.FromStream(memory);
                    memory.SetLength(0);
                    bin = null;
                }
                else if (currentPlaylist == PlaylistType.Liked)
                {
                    var file = TagLib.File.Create(liked[listBox_LikedMusic.SelectedIndex]);
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    MemoryStream memory = new MemoryStream(bin);
                    song_picture.Image = System.Drawing.Image.FromStream(memory);
                    memory.SetLength(0);
                    bin = null;
                }
            }
            catch
            {
            }
        }

        private void SetText()
        {
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                if (listBox_AllMusic.SelectedIndex >= 0)
                {
                    SongName = listBox_AllMusic.SelectedItem.ToString().Split('-').Last();
                    string ArtistName = listBox_AllMusic.SelectedItem.ToString().Split('-').First();
                    if (ArtistName.IndexOf("feat.") > 0)
                    {
                        Artist = ArtistName.Substring(0, ArtistName.IndexOf("feat."));
                    }
                    else
                    {
                        Artist = ArtistName;
                    }
                    if (Artist.Length > 14)
                    {
                        Artist = Artist.Substring(0, 13) + "...";
                    }
                    lbl_NameOfSong.Refresh();
                    lbl_Artist.Refresh();
                }
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                if (listBox_LikedMusic.SelectedIndex >= 0)
                {
                    SongName = listBox_LikedMusic.SelectedItem.ToString().Split('-').Last();
                    string ArtistName = listBox_LikedMusic.SelectedItem.ToString().Split('-').First();
                    if (ArtistName.IndexOf("feat.") > 0)
                    {
                        Artist = ArtistName.Substring(0, ArtistName.IndexOf("feat."));
                    }
                    else
                    {
                        Artist = ArtistName;
                    }
                    if (Artist.Length > 14)
                    {
                        Artist = Artist.Substring(0, 13) + "...";
                    }
                    lbl_NameOfSong.Refresh();
                    lbl_Artist.Refresh();
                }
            }
        }

        private void UpdateMySongsInfo()
        {
            lbl_QuantityOfSongs.Text = $"{strings.songs} {listBox_AllMusic.Items.Count}";
            lbl_quantity_liked.Text = $"{strings.songs} {listBox_LikedMusic.Items.Count}";

            double totalSeconds = 0;

            foreach (var filePath in paths)
            {
                try
                {
                    using (var audioFile = new AudioFileReader(filePath))
                    {
                        totalSeconds += audioFile.TotalTime.TotalSeconds;
                    }
                }
                catch
                {
                }
            }

            TimeSpan totalDuration = TimeSpan.FromSeconds(totalSeconds);
            lbl_Duration.Text = $"{strings.duration} {totalDuration.Hours:D2}:{totalDuration.Minutes:D2}:{totalDuration.Seconds:D2}";
            totalSeconds = 0;
            foreach (var filePath in liked)
            {
                try
                {
                    using (var audioFile = new AudioFileReader(filePath))
                    {
                        totalSeconds += audioFile.TotalTime.TotalSeconds;
                    }
                }
                catch
                {
                }
            }

            TimeSpan likedDuration = TimeSpan.FromSeconds(totalSeconds);
            lbl_duration_liked.Text = $"{strings.duration} {likedDuration.Hours:D2}:{likedDuration.Minutes:D2}:{likedDuration.Seconds:D2}";
        }

        private void ResetSongInfo()
        {
            song_picture.Image = null;
        }

        private enum PlaylistType
        {
            AllMusic,
            Liked
        }

        private void SwitchFunc(int page)
        {
            switch (page)
            {
                case 1:
                    panelChildForm.Hide();
                    panelSettings.Hide();
                    panelLiked.Hide();
                    break;
                case 2:
                    panelChildForm.Show();
                    panelSettings.Show();
                    panelLiked.Hide();
                    break;
                case 3:
                    panelChildForm.Hide();
                    panelSettings.Show();
                    panelLiked.Hide();
                    break;
                case 4:
                    panelLiked.Show();
                    panelChildForm.Hide();
                    panelSettings.Show();
                    break;
            }
        }
        #endregion

        #region Обьявления и старт
        private bool isShuffleAll = false;
        private bool isShuffleLiked = false;
        private PlaylistType currentPlaylist = PlaylistType.AllMusic;
        private bool isRepeatEnabled = false;
        private bool isShuffle = false;
        private Random random = new Random();
        private const string SongsFileName = "songs.txt";
        private string SongsFilePath => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SongsFileName);
        private string LikeFileName = "liked.txt";
        private string LikeFilePath => System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LikeFileName);
        public double song_state = 0.0;
        public string SongName = "";
        public string Artist = "";
        public string HomeMessage = "";
        float Default_value = 0.0f, Min = 0.0f, Max = 1.0f;
        string[] paths, liked;
        private System.Drawing.Color inactiveForeColor;
        public Form1()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            SetRandomMessage();
            LoadMusicFromFile();
            player.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(player_PositionChange);
            this.DoubleBuffered = true;
            btn_Homepage.ForeColor = System.Drawing.Color.White;
            inactiveForeColor = System.Drawing.Color.FromArgb(65, 65, 65);
            SwitchFunc(1);
            player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
            listBox_AllMusic.MouseDoubleClick += listBox_AllMusic_MouseDoubleClick;
            slider.Height = 30;
            volume_bar.Value = 20;
            LoadSettings();
        }
        #endregion

        #region Кнопки
        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (listBox_AllMusic.SelectedItem != null)
            {
                if (song_state > 0.0)
                {
                    player.Ctlcontrols.currentPosition = song_state;
                    song_state = 0.0;
                }
                player.Ctlcontrols.play();
                btn_Play.Hide();
                btn_Pause.Show();

                // Обновление видимости кнопок в зависимости от плейлиста
                if (currentPlaylist == PlaylistType.AllMusic)
                {
                    btn_PlayAllMusic.Hide();
                    btn_PauseAllMusic.Show();
                    btn_PlayLiked.Show();
                    btn_PauseLiked.Hide();
                }
                else if (currentPlaylist == PlaylistType.Liked)
                {
                    btn_PlayLiked.Hide();
                    btn_PauseLiked.Show();
                    btn_PlayAllMusic.Show();
                    btn_PauseAllMusic.Hide();
                }
            }
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            song_state = player.Ctlcontrols.currentPosition;
            btn_Pause.Hide();
            btn_Play.Show();

            // Обновление видимости кнопок в зависимости от плейлиста
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                btn_PlayAllMusic.Show();
                btn_PauseAllMusic.Hide();
                btn_PlayLiked.Show();
                btn_PauseLiked.Hide();
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                btn_PlayLiked.Show();
                btn_PauseLiked.Hide();
                btn_PlayAllMusic.Show();
                btn_PauseAllMusic.Hide();
            }
        }

        private void btn_MyMusic_Click(object sender, EventArgs e)
        {
            SwitchFunc(2);
            SwitchToAllMusicPlaylist();
            btn_MyMusic.ForeColor = System.Drawing.Color.White;
            btn_Settings.ForeColor = inactiveForeColor;
            btn_LikedMusic.ForeColor = inactiveForeColor;
            btn_Homepage.ForeColor = inactiveForeColor;
        }

        private void btn_Homepage_Click(object sender, EventArgs e)
        {
            SwitchFunc(1);
            btn_Homepage.ForeColor = System.Drawing.Color.White;
            btn_MyMusic.ForeColor = inactiveForeColor;
            btn_Settings.ForeColor = inactiveForeColor;
            btn_LikedMusic.ForeColor = inactiveForeColor;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            SwitchFunc(3);
            btn_Settings.ForeColor = System.Drawing.Color.White;
            btn_LikedMusic.ForeColor = inactiveForeColor;
            btn_MyMusic.ForeColor = inactiveForeColor;
            btn_Homepage.ForeColor = inactiveForeColor;
        }

        private void btn_LikedMusic_Click(object sender, EventArgs e)
        {
            btn_LikedMusic.ForeColor = System.Drawing.Color.White;
            SwitchFunc(4);
            SwitchToLikedPlaylist();
            btn_Settings.ForeColor = inactiveForeColor;
            btn_Homepage.ForeColor = inactiveForeColor;
            btn_MyMusic.ForeColor = inactiveForeColor;
        }

        private void btn_PlayAllMusic_Click(object sender, EventArgs e)
        {
            if (paths != null && paths.Length > 0)
            {
                btn_PlayAllMusic.Hide();
                btn_PauseAllMusic.Show();
                SwitchToAllMusicPlaylist();
                PlayNextSong();
                btn_PauseLiked.Hide();
                btn_PlayLiked.Show();
            }
        }

        private void btn_PauseAllMusic_Click_1(object sender, EventArgs e)
        {
            btn_PauseAllMusic.Hide();
            btn_PlayAllMusic.Show();
            player.Ctlcontrols.pause();
            btn_Pause.Hide();
            btn_Play.Show();

            // Обновление видимости кнопок в зависимости от плейлиста
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                btn_PlayAllMusic.Show();
                btn_PauseAllMusic.Hide();
                btn_PlayLiked.Show();
                btn_PauseLiked.Hide();
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                btn_PlayLiked.Show();
                btn_PauseLiked.Hide();
                btn_PlayAllMusic.Show();
                btn_PauseAllMusic.Hide();
            }
        }

        private void btn_PlayLiked_Click(object sender, EventArgs e)
        {
            if (liked != null && liked.Length > 0)
            {
                btn_PlayLiked.Hide();
                btn_PauseLiked.Show();
                SwitchToLikedPlaylist();
                PlayNextSongLiked();
                btn_PauseAllMusic.Hide();
                btn_PlayAllMusic.Show();
            }
        }

        private void btn_PauseLiked_Click(object sender, EventArgs e)
        {
            btn_PlayLiked.Show();
            btn_PauseLiked.Hide();
            player.Ctlcontrols.pause();
            btn_Pause.Hide();
            btn_Play.Show();

            // Обновление видимости кнопок в зависимости от плейлиста
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                btn_PlayAllMusic.Show();
                btn_PauseAllMusic.Hide();
                btn_PlayLiked.Show();
                btn_PauseLiked.Hide();
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                btn_PlayLiked.Show();
                btn_PauseLiked.Hide();
                btn_PlayAllMusic.Show();
                btn_PauseAllMusic.Hide();
            }
        }

        private void btn_addMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Audio Files|*.mp3;*.wav;*.flac|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var newFilePath in ofd.FileNames)
                {
                    if (!paths.Contains(newFilePath))
                    {
                        paths = paths.Concat(new[] { newFilePath }).ToArray();
                    }
                    else
                    {
                        MessageBox.Show($"{strings.Song} {Path.GetFileNameWithoutExtension(newFilePath)} {strings.added}", $"{strings.Attention}");
                    }
                }

                File.WriteAllLines(SongsFilePath, paths);
                LoadMusicFromFile();
            }
        }

        private void btn_NextSong_Click(object sender, EventArgs e)
        {
            try
            {
                PlayNextSong();

                string selectedSongPath = GetSelectedSongPath();
                bool isLiked = liked.Contains(selectedSongPath);

                if (isLiked)
                {
                    btn_Like.Hide();
                    btn_Liked.Show();
                }
                else
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }
            }
            catch(Exception) { }
        }

        private void btn_PreviousSong_Click(object sender, EventArgs e)
        {
            try
            {
                PlayPreviousSong();

                string selectedSongPath = GetSelectedSongPath();
                bool isLiked = liked.Contains(selectedSongPath);

                if (isLiked)
                {
                    btn_Like.Hide();
                    btn_Liked.Show();
                }
                else
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }
            }
            catch(Exception) { }
        }

        private void btn_RepeatSong_Click(object sender, EventArgs e)
        {
            if (!isRepeatEnabled)
            {
                isRepeatEnabled = true;
                btn_RepeatSong.BackColor = Color.FromArgb(29, 29, 29);
                player.settings.setMode("loop", true);
            }
            else
            {
                isRepeatEnabled = false;
                btn_RepeatSong.BackColor = Color.Transparent;
                player.settings.setMode("loop", false);
            }
        }

        private void btn_Shuffle_Click(object sender, EventArgs e)
        {
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                if (!isShuffleAll)
                {
                    isShuffleAll = true;
                    btn_Shuffle.BackColor = Color.FromArgb(29, 29, 29);
                    ShufflePlaylist(listBox_AllMusic, paths);
                }
                else
                {
                    isShuffleAll = false;
                    btn_Shuffle.BackColor = Color.Transparent;
                }
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                if (!isShuffleLiked)
                {
                    isShuffleLiked = true;
                    btn_Shuffle.BackColor = Color.FromArgb(29, 29, 29);
                    ShufflePlaylist(listBox_LikedMusic, liked);
                }
                else
                {
                    isShuffleLiked = false;
                    btn_Shuffle.BackColor = Color.Transparent;
                }
            }
        }

        private void btn_deletesong_Click(object sender, EventArgs e)
        {
            if (listBox_AllMusic.SelectedIndex != -1)
            {
                string deletedSongPath = paths[listBox_AllMusic.SelectedIndex];
                paths = paths.Where(p => p != deletedSongPath).ToArray();
                listBox_AllMusic.Items.RemoveAt(listBox_AllMusic.SelectedIndex);
                File.WriteAllLines(SongsFilePath, paths);

                if(listBox_AllMusic.Items.Count == 0)
                {
                    player.Ctlcontrols.stop();
                    btn_Pause.Hide();
                    btn_Play.Show();
                    btn_PlayAllMusic.Show();
                    btn_PauseAllMusic.Hide();
                    ResetSongInfo();
                    UpdateMySongsInfo();
                }
                else
                {
                    UpdateMySongsInfo();
                    PlayNextSong();
                }
            }
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохраняем выбранный индекс
                int selectedSongIndex = listBox_AllMusic.SelectedIndex;

                // Добавляем песню в список liked
                string selectedSongPath = paths[selectedSongIndex];
                liked = liked.Append(selectedSongPath).ToArray();

                // Обновляем файл liked.txt
                File.WriteAllLines(LikeFilePath, liked);

                // Перезагружаем музыку
                LoadMusicFromFile();

                // Показываем кнопку "Liked" и скрываем "Like"
                btn_Like.Hide();
                btn_Liked.Show();

                // Восстанавливаем выбранный индекс
                listBox_AllMusic.SelectedIndex = selectedSongIndex;

                // Обновляем информацию о песнях
                UpdateMySongsInfo();
            }
            catch (Exception) { }
        }

        private void btn_Liked_Click(object sender, EventArgs e)
        {
            if (currentPlaylist == PlaylistType.AllMusic && listBox_AllMusic.SelectedIndex >= 0)
            {
                int selectedSongIndex = listBox_AllMusic.SelectedIndex;
                string selectedSongPath = paths[selectedSongIndex];

                if (liked.Contains(selectedSongPath))
                {
                    liked = liked.Where(song => song != selectedSongPath).ToArray();
                }
                else
                {
                    liked = liked.Append(selectedSongPath).ToArray();
                }

                // Обновляем файл liked.txt
                File.WriteAllLines(LikeFilePath, liked);

                // Проверяем, нужно ли скрывать кнопку "Liked" в плейлисте всех песен
                if (!liked.Contains(selectedSongPath))
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }
            }
            else if (currentPlaylist == PlaylistType.Liked && listBox_LikedMusic.SelectedIndex >= 0)
            {
                int selectedSongIndex = listBox_LikedMusic.SelectedIndex;
                string selectedSongPath = liked[selectedSongIndex];

                // Удаляем песню из списка liked
                liked = liked.Where(song => song != selectedSongPath).ToArray();

                // Удаляем соответствующую строку из файла liked.txt
                File.WriteAllLines(LikeFilePath, liked);

                // Обновляем ListBox_LikedMusic после удаления
                listBox_LikedMusic.Items.Clear();
                foreach (var likedSong in liked)
                {
                    listBox_LikedMusic.Items.Add(Path.GetFileNameWithoutExtension(likedSong));
                }

                // Восстанавливаем выбранную песню (если она была)
                if (selectedSongIndex < listBox_LikedMusic.Items.Count)
                {
                    listBox_LikedMusic.SelectedIndex = selectedSongIndex;
                }
                else if (listBox_LikedMusic.Items.Count > 0)
                {
                    // Если удалена была последняя песня, выбираем предыдущую (если она есть)
                    listBox_LikedMusic.SelectedIndex = listBox_LikedMusic.Items.Count - 1;
                }

                // Обновляем информацию о песнях
                UpdateMySongsInfo();

                // Проверяем, нужно ли скрывать кнопку "Liked" в плейлисте liked
                if (listBox_LikedMusic.Items.Count == 0)
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }
            }
        }
        #endregion

        #region Методы для работы плеера

        private void SaveLikedToFile()
        {
            File.AppendAllLines(LikeFilePath, liked);
        }

        private void PlayNextSongLiked()
        {
            int currentIndex = listBox_LikedMusic.SelectedIndex;

            // Ищем следующую доступную песню
            int newSelectedIndex = currentIndex;
            do
            {
                newSelectedIndex = (newSelectedIndex + 1) % liked.Length;
            } while (newSelectedIndex != currentIndex && !File.Exists(liked[newSelectedIndex]));

            // Если удаленная песня была последней в списке, выбираем предыдущую
            if (newSelectedIndex == currentIndex)
            {
                do
                {
                    newSelectedIndex = (newSelectedIndex - 1 + liked.Length) % liked.Length;
                } while (newSelectedIndex != currentIndex && !File.Exists(liked[newSelectedIndex]));
            }

            // Если найдена доступная песня, воспроизводим её
            if (File.Exists(liked[newSelectedIndex]))
            {
                string nextSongPath = liked[newSelectedIndex];

                // Останавливаем воспроизведение текущей песни
                player.Ctlcontrols.stop();

                // Устанавливаем новый путь к следующей песне
                player.URL = nextSongPath;

                // Воспроизводим следующую песню
                player.Ctlcontrols.play();

                // Устанавливаем новый индекс в списке
                listBox_LikedMusic.SelectedIndex = newSelectedIndex;

                // Обновляем интерфейс
                SetText();
                SetPicture();

                if (liked.Contains(nextSongPath))
                {
                    // Если следующая песня в списке любимых
                    // cкрыть кнопку "Like" и показать "Liked"
                    btn_Like.Hide();
                    btn_Liked.Show();
                }
                else
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }
            }
        }

        private void LoadMusicFromFile()
        {
            if (File.Exists(SongsFilePath) && File.Exists(LikeFilePath))
            {
                liked = File.ReadAllLines(LikeFilePath);
                paths = File.ReadAllLines(SongsFilePath);
                listBox_AllMusic.Items.Clear();
                for (int x = 0; x < paths.Length; x++)
                {
                    string filename = System.IO.Path.GetFileNameWithoutExtension(paths[x]);
                    int index = listBox_AllMusic.Items.Count;
                    listBox_AllMusic.Items.Insert(index, filename);
                }
                listBox_LikedMusic.Items.Clear();
                for (int i= 0; i < liked.Length; i++)
                {
                    string filename = System.IO.Path.GetFileNameWithoutExtension(liked[i]);
                    int index = listBox_LikedMusic.Items.Count;
                    listBox_LikedMusic.Items.Insert(index, filename);
                }
                UpdateMySongsInfo();
            }
            else {
                File.WriteAllText(SongsFilePath, string.Empty);
                File.WriteAllText(LikeFilePath, string.Empty);
            }
        }

        private void listBox_LikedMusic_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listBox_LikedMusic.SelectedIndex >= 0 && listBox_LikedMusic.SelectedIndex < liked.Length)
                {
                    string selectedSongPath = liked[listBox_LikedMusic.SelectedIndex];
                    bool isLiked = liked.Contains(selectedSongPath);

                    if (isLiked)
                    {
                        btn_Like.Hide();
                        btn_Liked.Show();
                    }
                    else
                    {
                        btn_Liked.Hide();
                        btn_Like.Show();
                    }
                    player.URL = selectedSongPath;
                    player.Ctlcontrols.play();

                    // Обновление видимости кнопок в зависимости от плейлиста
                    btn_PlayAllMusic.Show();
                    btn_PauseAllMusic.Hide();
                    btn_PlayLiked.Hide();
                    btn_PauseLiked.Show();

                    SetText();
                    SetPicture();
                    btn_Play.Hide();
                    btn_Pause.Show();
                }
            }
            catch (Exception) { }
        }

        private void listBox_AllMusic_MouseDoubleClick(object sender, EventArgs e)
        {
            if (listBox_AllMusic.SelectedIndex >= 0)
            {
                string selectedSongPath = paths[listBox_AllMusic.SelectedIndex];
                bool isLiked = liked.Contains(selectedSongPath);

                if (isLiked)
                {
                    btn_Like.Hide();
                    btn_Liked.Show();
                }
                else
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }

                player.URL = selectedSongPath;
                player.Ctlcontrols.play();
                btn_PlayAllMusic.Hide();
                btn_PauseAllMusic.Show();
                btn_PlayLiked.Show();
                btn_PauseLiked.Hide();
                SetText();
                SetPicture();
                btn_Play.Hide();
                btn_Pause.Show();
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded && !isRepeatEnabled)
            {
                PlayNextSong();
            }
        }

        private void Player_PlayStateChangeForNextSong(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsReady)
            {
                player.Ctlcontrols.play();
                player.PlayStateChange -= Player_PlayStateChangeForNextSong;
            }
        }

        private void player_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            if (isRepeatEnabled && e.newPosition == player.Ctlcontrols.currentItem.duration)
            {
                PlayNextSong();
            }
        }

        private void SwitchPlaylist(PlaylistType newPlaylist)
        {
            currentPlaylist = newPlaylist;

            if (currentPlaylist == PlaylistType.AllMusic)
            {
                listBox_AllMusic.Items.Clear();
                foreach (var path in paths)
                {
                    string filename = System.IO.Path.GetFileNameWithoutExtension(path);
                    listBox_AllMusic.Items.Add(filename);
                }
                slider.Enabled = true;
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                listBox_LikedMusic.Items.Clear();
                foreach (var path in liked)
                {
                    string filename = System.IO.Path.GetFileNameWithoutExtension(path);
                    listBox_LikedMusic.Items.Add(filename);
                }
                slider.Enabled = true;
            }
            slider.Enabled = true;
            UpdateMySongsInfo();
        }

        private void SwitchToAllMusicPlaylist()
        {
            SwitchPlaylist(PlaylistType.AllMusic);
        }

        private void SwitchToLikedPlaylist()
        {
            SwitchPlaylist(PlaylistType.Liked);
        }

        private void ShufflePlaylist(System.Windows.Forms.ListBox listBox, string[] playlist)
        {
            int currentIndex = listBox.SelectedIndex;

            while (listBox.SelectedIndex == currentIndex)
            {
                listBox.SelectedIndex = random.Next(0, listBox.Items.Count);
            }

            if (currentPlaylist == PlaylistType.AllMusic)
            {
                player.URL = paths[listBox.SelectedIndex];
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                player.URL = liked[listBox.SelectedIndex];
            }
        }

        private void ShuffleLikedPlaylist()
        {
            int currentIndex = listBox_LikedMusic.SelectedIndex;

            while (listBox_LikedMusic.SelectedIndex == currentIndex)
            {
                listBox_LikedMusic.SelectedIndex = random.Next(0, listBox_LikedMusic.Items.Count);
            }

            player.URL = liked[listBox_LikedMusic.SelectedIndex];
        }

        private void PlayNextSong()
        {
            try
            {
                if (currentPlaylist == PlaylistType.AllMusic)
                {
                    if (isShuffleAll)
                    {
                        ShufflePlaylist(listBox_AllMusic, paths);
                    }
                    else
                    {
                        if (listBox_AllMusic.SelectedIndex < listBox_AllMusic.Items.Count - 1)
                        {
                            listBox_AllMusic.SelectedIndex = listBox_AllMusic.SelectedIndex + 1;
                        }
                        else
                        {
                            listBox_AllMusic.SelectedIndex = 0;
                        }

                        player.URL = paths[listBox_AllMusic.SelectedIndex];
                    }
                }
                else if (currentPlaylist == PlaylistType.Liked)
                {
                    if (isShuffleLiked)
                    {
                        ShufflePlaylist(listBox_LikedMusic, liked);
                    }
                    else
                    {
                        if (listBox_LikedMusic.SelectedIndex < listBox_LikedMusic.Items.Count - 1)
                        {
                            listBox_LikedMusic.SelectedIndex = listBox_LikedMusic.SelectedIndex + 1;
                        }
                        else
                        {
                            listBox_LikedMusic.SelectedIndex = 0;
                        }

                        player.URL = liked[listBox_LikedMusic.SelectedIndex];
                    }
                }
                SetText();
                SetPicture();
                btn_Play.Hide();
                btn_Pause.Show();

                player.PlayStateChange -= Player_PlayStateChangeForNextSong;
                player.PlayStateChange += Player_PlayStateChangeForNextSong;

                string nextSongPath = GetCurrentSongPath();
                if (liked.Contains(nextSongPath))
                {
                    btn_Like.Hide();
                    btn_Liked.Show();
                }
                else
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }
            }
            catch (Exception) { }
        }

        private void PlayPreviousSong()
        {
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                PlayPreviousSongAllMusic();
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                PlayPreviousSongLiked();
            }
        }

        private void PlayNextSongAllMusic()
        {
            if (listBox_AllMusic.SelectedIndex < listBox_AllMusic.Items.Count - 1)
            {
                string nextSongPath = paths[listBox_AllMusic.SelectedIndex];
                listBox_AllMusic.SelectedIndex++;        
                SetText();
                SetPicture();
                btn_Play.Hide();
                btn_Pause.Show();
                player.URL = nextSongPath;

                if (liked.Contains(nextSongPath))
                {
                    btn_Like.Hide();
                    btn_Liked.Show();
                }
                else
                {
                    btn_Liked.Hide();
                    btn_Like.Show();
                }
            }
        }

        private void PlayPreviousSongAllMusic()
        {
            if (listBox_AllMusic.SelectedIndex > 0)
            {
                listBox_AllMusic.SelectedIndex--;
                player.URL = paths[listBox_AllMusic.SelectedIndex];
                SetText();
                SetPicture();
                btn_Play.Hide();
                btn_Pause.Show();
            }
        }

        private void PlayPreviousSongLiked()
        {
            if (listBox_LikedMusic.SelectedIndex > 0)
            {
                listBox_LikedMusic.SelectedIndex--;
                player.URL = liked[listBox_LikedMusic.SelectedIndex];
                SetText();
                SetPicture();
                btn_Play.Hide();
                btn_Pause.Show();
            }
        }

        private string GetCurrentSongPath()
        {
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                return paths[listBox_AllMusic.SelectedIndex];
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                return liked[listBox_LikedMusic.SelectedIndex];
            }

            return string.Empty;
        }

        private string GetSelectedSongPath()
        {
            if (currentPlaylist == PlaylistType.AllMusic)
            {
                return paths[listBox_AllMusic.SelectedIndex];
            }
            else if (currentPlaylist == PlaylistType.Liked)
            {
                return liked[listBox_LikedMusic.SelectedIndex];
            }

            return string.Empty;
        }
        #endregion

        #region Слайдер

        public float Bar(float value)
        {
            return (slider.Width - 24) * (value - Min) / (float)(Max - Min);
        }

        public void thumb(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            Default_value = value;
            slider.Refresh();

        }

        bool mouse = false;
        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox_AllMusic.SelectedItem != null)
            {
                    mouse = true;
                    thumb(slider_width(e.X));
                    player.Ctlcontrols.pause();
                    player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / slider.Width;
            }
        }

        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                thumb(slider_width(e.X));
                player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / slider.Width;
                song_state = player.Ctlcontrols.currentPosition;
            }
        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
            if (!btn_Play.Visible)
            {
                player.Ctlcontrols.play();
            }
        }

        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volume_bar.Value;
        }

        public float slider_width(int x)
        {
            return Min + (Max - Min) * x / (float)(slider.Width);
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = Bar(Default_value);
            int y = (int)(slider.Height * bar_size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(System.Drawing.Brushes.Gray, 0, y, slider.Width, y / 2);
            e.Graphics.FillRectangle(System.Drawing.Brushes.White, 0, y, x, slider.Height - 2 * y);

            using (System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.White, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
                e.Graphics.FillEllipse(System.Drawing.Brushes.White, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
            }
        }

        #endregion

        #region Отрисовка лейблов
        private void lbl_Artist_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("MontereyFLF", 19);
            System.Drawing.Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkGray);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(Artist, myfont, mybrush, 0, 0);
        }

        private void lbl_NameOfSong_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("MontereyFLF", 19);
            System.Drawing.Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString(SongName, myfont, mybrush, 0, 0);
        }

        #endregion

        #region Настройки

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                System.Globalization.CultureInfo.GetCultureInfo("uk-UA")
            };
            comboBox1.DisplayMember = "NativeName";
            comboBox1.ValueMember = "Name";

            if(!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                comboBox1.SelectedValue = Properties.Settings.Default.Language;
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Volume = volume_bar.Value;
            Properties.Settings.Default.IsShuffleEnabled = isShuffle;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            player.settings.volume = Properties.Settings.Default.Volume;
            volume_bar.Value = Properties.Settings.Default.Volume;
            isShuffle = Properties.Settings.Default.IsShuffleEnabled;
            btn_Shuffle.BackColor = isShuffle ? Color.FromArgb(29, 29, 29) : Color.Transparent;
            btn_RepeatSong.BackColor = isRepeatEnabled ? Color.FromArgb(29, 29, 29) : Color.Transparent;
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Max = (int)player.Ctlcontrols.currentItem.duration;
                Default_value = (int)player.Ctlcontrols.currentPosition;
                slider.Invalidate();
                try
                {
                    lbl_songStart.Text = player.Ctlcontrols.currentPositionString;
                    lbl_songEnd.Text = player.Ctlcontrols.currentItem.durationString;
                }
                catch
                {

                }
            }
        }
    }
}