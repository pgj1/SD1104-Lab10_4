using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4_MusicPlayer
{
    class MovieSoundTrack : IAudioPlayer
    {
        public string movieName { get; }
        public string trackName { get; private set; }

        public MovieSoundTrack(string movieName)
        {
            this.movieName = movieName;
        }

        public void SelectTrack(string track)
        {
            trackName = track;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now playing: ");
            sb.Append(trackName);
            sb.Append(" from ");
            sb.Append(movieName);
            Console.WriteLine(sb.ToString());
        }


    }
}
