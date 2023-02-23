using studentAchievement.Models;

namespace studentAchievement.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        student a = new student("A D A", 1, 1, 1, 1, 1, 1, 1);
        public string Greeting => "Welcome to Avalonia!";
    }
}
