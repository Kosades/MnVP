﻿using System.Windows;

namespace MnVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MusicPlayer player = new MusicPlayer(-1, 44100, 0);
            player.RunBass();
            
            player.Play("music.mp3", true);
            //player.StopBass();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings settings_form = new Settings();
            settings_form.Show();
        }
    }
}
