using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4_MusicPlayer
{
    class AudioBook : IAudioPlayer
    {
        public string bookTitle { get; }
        public string author { get; }

        public AudioBook(string bookTitle, string author)
        {
            this.bookTitle = bookTitle;
            this.author = author;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now playing: ");
            sb.Append(bookTitle);
            sb.Append(" by: ");
            sb.Append(author + "\n");
            Console.WriteLine(sb.ToString());


        }
    
    }
}
