using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }

    public static void Main(string[] args)
    {
        string judulVideo = "Tutorial Design By Contract - Alif";
        SayaTubeVideo video = new SayaTubeVideo(judulVideo);
        video.IncreasePlayCount(20);
        video.PrintVideoDetails();
    }
}
