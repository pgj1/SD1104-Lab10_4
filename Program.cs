using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab10_4_MusicPlayer
{
     

    class Program
    {
        static void Main(string[] args)
        {
            //Music player
            Console.WriteLine("Lab 10.4 Music Player \n");
            Artist prince = new Artist("Prince");
            prince.AddToPlaylist("Purple Rain");
            prince.AddToPlaylist("Little Red Corvette");
            prince.AddToPlaylist("Kiss");
            prince.AddToPlaylist("When Doves Cry");
            prince.AddToPlaylist("Pearl Necklace");


            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(prince);

            //Audio Book
            AudioBook howTo = new AudioBook("How to Win Friends and Influence People","Dale Carnegie");
            player.PlayMedia(howTo);

            //Movie Soundtrack
            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);
        }
    }
}
