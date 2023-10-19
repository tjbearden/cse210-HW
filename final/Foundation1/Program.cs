using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("Blink-182", "YOU DON'T KNOW WHAT YOU'VE GOT", 198);
        _videos[0].AddComment("oldmanmaggie", "I am a 38 year old father. Makes me proud to see my kids enjoying blink182 as much as I do");
        _videos[0].AddComment("BLINKD In", "Best Band EVER");
        _videos[0].AddComment("philbert123", "how have I not heard this song yet?");

        _videos[1] = new Video("HeavenHelpMe", "How to have better Prayers", 603);
        _videos[1].AddComment("MandyPants", "Great Advice, thanks for making this video");
        _videos[1].AddComment("NotConvinced", "Get a life");
        _videos[1].AddComment("Please Help me", "bruh");
        
        _videos[2] = new Video("purplesite", "How to get the best STLs for free", 750);
        _videos[2].AddComment("Tim", "This is Fraud");
        _videos[2].AddComment("CarlDB", "Don't click on the links, they is a scam");
        _videos[2].AddComment("Bob'0'Head", "I got over 100 stls for free!.");

        _videos[3] = new Video("Pam", "Workout to the Oldies", 6000);
        _videos[3].AddComment("Jim Halpert", "Great Music, love the unitard on the dude.");
        _videos[3].AddComment("Dwight Shrut", "I didn't even sweat");
        _videos[3].AddComment("Kevin", "Exercise is not for me.");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}