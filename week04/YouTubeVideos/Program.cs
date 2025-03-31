using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>{};

        string videoTitle1 = "How to Erase Mistakes When Writing on Gold Plates";
        string videoAuthor1 = "How24Prophets";
        int videoLength1 = 312;
        string video1Comment1Text = "No idea how many times I used this when trying to write something other than 'And it came to pass'.";
            string video1comment1Name = "Nephi";
        string video1Comment2Text = "Had to fix so many of my brother's spelling errors #LuvUNephi";
            string video1comment2Name = "Jacob";
        string video1Comment3Text = "Not really a big deal. Barely used this info but thanks all the same.";
            string video1comment3Name = "Enos";
        
        string videoTitle2 = "Correct Procedure for Passing Records to Children";
        string videoAuthor2 = "How24Prophets";
        int videoLength2 = 1034;
        string video2Comment1Text = "Don't know if I'll need this but good to know I guess.";
            string video2comment1Name = "Jarom";
        string video2Comment2Text = "Do I have to include anything or can I just sign and pass off? Asking for a friend.";
            string video2comment2Name = "Omni";
        string video2Comment3Text = "Wow, this video is outdated.";
            string video2comment3Name = "Mormon";

        string videoTitle3 = "How to Recover Public Records and Speeches";
        string videoAuthor3 = "How24Historians";
        int videoLength3 = 905;
        string video3Comment1Text = "Thanks! Needed a couple copies for distribution and this really helped.";
            string video3comment1Name = "Mosiah";
        string video3Comment2Text = "Is there a way to get more recent records that may have not been submitted to public information yet?";
            string video3comment2Name = "Alma";
        string video3Comment3Text = "What if I don't know the exact date of the record I need? Is there an organized filing system I can look through?";
            string video3comment3Name = "Helaman";

        Video video1 = new Video();
        video1.SetVideo(videoTitle1, videoAuthor1, videoLength1);
        video1.AddComment(video1Comment1Text, video1comment1Name);
        video1.AddComment(video1Comment2Text, video1comment2Name);
        video1.AddComment(video1Comment3Text, video1comment3Name);
        videos.Add(video1);

        Video video2 = new Video();
        video2.SetVideo(videoTitle2, videoAuthor2, videoLength2);
        video2.AddComment(video2Comment1Text, video2comment1Name);
        video2.AddComment(video2Comment2Text, video2comment2Name);
        video2.AddComment(video2Comment3Text, video2comment3Name);
        videos.Add(video2);

        Video video3 = new Video();
        video3.SetVideo(videoTitle3, videoAuthor3, videoLength3);
        video3.AddComment(video3Comment1Text, video3comment1Name);
        video3.AddComment(video3Comment2Text, video3comment2Name);
        video3.AddComment(video3Comment3Text, video3comment3Name);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}