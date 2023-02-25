using studentAchievement.Models;

namespace studentAchievement.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Greeting = a();
    }

    public string Greeting { get; set; }

    public static string a()
    {
        Student stud = new("a b c", 1, 1, 1, 1, 1, 1, 1);
        return stud.ObjToString();
    }
}
