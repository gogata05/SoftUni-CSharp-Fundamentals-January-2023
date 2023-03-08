using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;
//3
//favourite_DownTown_3: 14
//favourite_Kiss_4: 16
//favourite_Smooth Criminal_4:01
//favourite

//DownTown
//Kiss
//Smooth Criminal
int n = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split('_');
    string typeList = input[0];
    string songName = input[1];
    string duration = input[2];
    Song song = new Song()
    {
        TypeList = typeList,
        Name = songName,
        Time = duration,
    };
    songs.Add(song);

}
string searchForTypeList = Console.ReadLine();
if (searchForTypeList == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (var song in songs)
    {
        if (song.TypeList == searchForTypeList)
        {
            Console.WriteLine(song.Name);
        }
    }
}
public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}
