using System;
//Create Videos
Video vid1 = new Video("First Video", "Steven Spielberg", 250);
Video vid2 = new Video("Second Video", "J.J. Abrams", 190);
Video vid3 = new Video("Third Video", "Wes Anderson", 402);
Video vid4 = new Video("Fourth Video", "Sam Raimi", 999);

//Comments for Video1
vid1.AddComment("Yo Mama", "This the first video");
vid1.AddComment("Yo Daddy", "This is a comment");
vid1.AddComment("Yo friend", "Friendly Comment");
//Comments for Video2
vid2.AddComment("Huey", "Sick vid bro");
vid2.AddComment("Dewey", "^^Agreed^^");
vid2.AddComment("Louie", "All of our names rhyme... but none are spelled the same...");
//Comments for Video3
vid3.AddComment("F4n4t1c", "Wes stays on top of the game.");
vid3.AddComment("Tom N00k", "You have my money?");
vid3.AddComment("???", "????????????");
//Comments for Video4
vid4.AddComment("John Wayne", "Pew Pew");
vid4.AddComment("Clint Eastwood", "PEW PEW");
vid4.AddComment("Western Movie Lover", "Whoa, so thrilling.");
Console.Clear();
vid1.DisplayComments();
vid2.DisplayComments();
vid3.DisplayComments();
vid4.DisplayComments();