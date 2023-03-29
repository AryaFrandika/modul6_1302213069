using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class SayaTubeVideo
{
    public int id;
    public string title;
    public int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(00000, 99999);
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int n)
    {
        this.playCount += n;
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: {0}", this.id);
        Console.WriteLine("JUDUL: {0}", this.title);
        Console.WriteLine("PLAY COUNT: {0}", this.playCount);
    }
}

class SayaTubeUser
{
    public int id;
    public List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string username)
    {
        Random random = new Random();
        this.uploadedVideos= new List<SayaTubeVideo>();
        this.Username= username;
        this.id = random.Next(00000, 99999);
    }

    public int GetTotalVideoPlayCount()
    {
        int jumlah = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            jumlah += uploadedVideos[i].playCount;
        }
        return jumlah;
    }

    public void AddVideo(SayaTubeVideo video) 
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount() 
    {
        Console.WriteLine("User: " + Username);
        for(int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video :" + (i + 1) + " judul " + uploadedVideos[i].title);
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Review Film Iron Man oleh Arya Frandika");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film The Incridible Hulk oleh Arya Frandika");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Iron Man 2 oleh Arya Frandika");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Thor oleh Arya Frandika");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Captain America oleh Arya Frandika");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film The Avenger oleh Arya Frandika");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Iron Man 3 oleh Arya Frandika");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Thor : The Dark World oleh Arya Frandika");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Captain America : The Winter Soldier oleh Arya Frandika");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Guardian Of The Galaxy oleh Arya Frandika");

        video.IncreasePlayCount(2);
        video.PrintVideoDetails();
        video2.IncreasePlayCount(2);
        video2.PrintVideoDetails();
        video3.IncreasePlayCount(2);
        video3.PrintVideoDetails();
        video4.IncreasePlayCount(2);
        video4.PrintVideoDetails();
        video5.IncreasePlayCount(2);
        video5.PrintVideoDetails();
        video6.IncreasePlayCount(2);
        video6.PrintVideoDetails();
        video7.IncreasePlayCount(2);
        video7.PrintVideoDetails();
        video8.IncreasePlayCount(2);
        video8.PrintVideoDetails();
        video9.IncreasePlayCount(2);
        video9.PrintVideoDetails();
        video10.IncreasePlayCount(2);
        video10.PrintVideoDetails();


    }
}






