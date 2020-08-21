Lab 10.4 Music Player

Scenario: You work for a company that allows users to play audio clips from the website. The website plays a 
variety of different kinds of audio, including songs from music Artists, AudioBooks, and Movie Soundtracks.

We will write some mock classes that use Interfaces and Random to create a mockup of how we could implement a 
music player. The classes won’t play any music, but in our lab, they will output the various kinds of media they 
would be playing to the screen.

Solving the Problem:
To start the lab, let’s think about the kinds of classes we’ll need here.
● We’ll need an interface that Plays Audio Media
● We’ll need a MediaPlayer that plays the Media
● We’ll need different classes for our Media, such as Music Artist, Movie Sounds Tracks, and Audio books

Walkthrough:
Step 1. Create an interface for playing audio media. We’ll create a new interface that has one method called Play()

Step 2: Create a class for playing any kind of media. The media player will have a method called PlayMedia, 
that accepts anything that uses the interface.

Step 3: Create a Music Artist class, and implement the interface.

* We’ve created an Artist class that uses our interface. We have two properties, an artist name and a playlist. 
  We are using a new data type here called Dictionary, which holds an integer and a string value together.
* We’ve created a constructor for giving the artist a name and building a new, empty playlist.
* We’ve created a method called AddToPlaylist, which takes in the title of a song, and adds it to our playlist 
  dictionary. The song ID is automatically added.
* Finally, we implement Play(), which generates a random number between 0 and the number of items in our playlist. 
  It then writes out the console the artist’s name and the random song picked from the playlist.

Step 5: Creating an AudioBook
The beauty of interfaces is that these classes can be very different, so long as the use the interface. 
Our Audiobook has a bookTitle and Author. Its version of Play() simply prints out the book title and author info.

Step 6: Create a Movie Soundtrack
In our movie soundtrack class, we have a movie name and a track name, along with a method for choosing a 
track name. Finally, our Play() here lists the movie name and the track name selected.

Step 7. Test the other kinds of media
Back in our Main() method, let’s create the other kinds of media and try to play them.

End Results:
Our media player is able to use the Play() from all kinds of different classes. The artist plays a
random song, the audiobook just plays from the beginning, and the movie soundtrack lets us pick a 
track to play.

From this point, it would not be very difficult to build an HTML UI for selecting the media and a 
database for holding the real media to play.

To view our solution, see the 10_4Lab Project:
https://github.com/ACTWebDev/SD104/tree/master/10_4Lab/10_4Lab 

If you complete this lab early, spent time on https://edabit.com/challenges C# coding challenges to practice your C# skills.