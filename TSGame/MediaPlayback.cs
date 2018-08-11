using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Media;
using System.IO;

namespace TSGame
{
    class MediaPlayback
    {
        private bool _closing = false;
        private bool _pause = false;
        public double Volume = .1;
        public TimeSpan Position;
        //public TimeSpan position = MediaPlayer.Position; 

        public void PlayAudio(string audioFilePath)
        {
            var thread = new Thread(() => { PlayAudioThreadProc(audioFilePath, Volume); });
            thread.Start();
        }
        private void PlayAudioThreadProc(string audioFilePath, double volumeAmount)
        {
            MediaPlayer mediaPlayer = CreateMediaPlayer(audioFilePath, volumeAmount);
            mediaPlayer.Volume = volumeAmount;
            mediaPlayer.Play();
            Position = mediaPlayer.Position;

            while (_pause)
            {
                mediaPlayer.Pause();
            }
            while (!_closing)
            {
                System.Threading.Thread.Sleep(10);
                Dispatcher.Run();
                mediaPlayer.Stop();
                mediaPlayer.MediaEnded -= MediaPlayer_MediaEnded;
                mediaPlayer.Close();

            }

        }
        private MediaPlayer CreateMediaPlayer(string audioFilePath, double volumeAmount)
        {
            var mediaPlayer = new MediaPlayer();
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;     
            mediaPlayer.Open(new Uri(Path.GetFullPath(audioFilePath)));
            return mediaPlayer;
        }
        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            //This starts the media again after it has ended playing.
            var player = (MediaPlayer)sender;
            player.Position = TimeSpan.Zero;
            player.Play();
        }
        public void Stop()
        {
            _closing = true;
        }
        public void Resume()
        {
            _pause = false;
        }
        public void Pause()
        {
            _pause = true;
        }
    }
}
