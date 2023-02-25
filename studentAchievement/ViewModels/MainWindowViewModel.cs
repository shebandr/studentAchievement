using Avalonia.X11;
using studentAchievement.Models;

namespace studentAchievement.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string a() { 
         Student stud = new("a b c", 1, 1, 1, 1, 1, 1, 1);
            return stud.ObjToString();
        }
        public string Greeting => a();
    }
}
