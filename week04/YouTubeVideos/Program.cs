using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Cooking Cheese Cake", "The Flavor Of life", 2100 );
        Video video2 = new Video("Dancing Salsa", "Passion", 3600 );  
        Video video3 = new Video("Geopolitics", "Globalist", 1600 );

        Comment comment1 = new Comment("Bernie", "This looks delicious!");
        Comment comment2 = new Comment("Masha", "Can't wait to cook this in home");
        Comment comment3 = new Comment("Mario","Unbelievable");
        Comment comment4 = new Comment("Marlin","Can't wait to dance this in a Party");
        Comment comment5 = new Comment("Donald", "So excited for the beautiful things are taking place");
        Comment comment6 = new Comment("Pete", "No way!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);
        video3.AddComment(comment5);
        video3.AddComment(comment6);


        List<Video> videoList = new List<Video>();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            Console.WriteLine();
            video.DisplayInfo();
        }
        
    
    }
}