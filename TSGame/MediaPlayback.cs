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
        public void PlayAudio(string audioFilePath)
        {
            var thread = new Thread(() => { PlayAudioThreadProc(audioFilePath); });
            thread.Start();
        }
        private void PlayAudioThreadProc(string audioFilePath)
        {
            MediaPlayer mediaPlayer = CreateMediaPlayer(audioFilePath);
            mediaPlayer.Play();
            while (!_closing)
            {
                System.Threading.Thread.Sleep(10);
                Dispatcher.Run();
            }
            mediaPlayer.Stop();
            mediaPlayer.MediaEnded -= MediaPlayer_MediaEnded;
            mediaPlayer.Close();
        }
        private MediaPlayer CreateMediaPlayer(string audioFilePath)
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
    }
}
