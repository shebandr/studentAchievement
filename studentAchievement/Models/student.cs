namespace studentAchievement.Models;

internal class Student
{
    private int cs1;
    private int cs2;
    private int cs3;
    private int cs4;
    private int cs5;
    private int cs6;

    public Student()
    {
        Fio = "";
    }

    public Student(string f, int id, int cs1, int cs2, int cs3, int cs4, int cs5, int cs6)
    {
        Fio = f;
        Id = id;
        Cs1 = cs1;
        Cs2 = cs2;
        Cs3 = cs3;
        Cs4 = cs4;
        Cs5 = cs5;
        Cs6 = cs6;
    }

    public Student(string s)
    {
        var a = s.Split("~");
        Fio = a[0];
        Id = int.Parse(a[1]);
        Cs1 = int.Parse(a[2]);
        Cs2 = int.Parse(a[3]);
        Cs3 = int.Parse(a[4]);
        Cs4 = int.Parse(a[5]);
        Cs5 = int.Parse(a[6]);
        Cs6 = int.Parse(a[7]);
    }

    public string Fio { set; get; } = "";

    public int Id { set; get; }

    public int Cs1
    {
        set {
            if (value is >= 0 and <= 2) cs1 = value;
        }
        get => cs1;
    }

    public int Cs2
    {
        set {
            if (value is >= 0 and <= 2) cs2 = value;
        }
        get => cs2;
    }

    public int Cs3
    {
        set {
            if (value is >= 0 and <= 2) cs3 = value;
        }
        get => cs3;
    }

    public int Cs4
    {
        set {
            if (value is >= 0 and <= 2) cs4 = value;
        }
        get => cs4;
    }

    public int Cs5
    {
        set {
            if (value is >= 0 and <= 2) cs5 = value;
        }
        get => cs5;
    }

    public int Cs6
    {
        set {
            if (value is >= 0 and <= 2) cs6 = value;
        }
        get => cs6;
    }

    public int AverageCs() =>
        (Cs1 + Cs2 + Cs3 + Cs4 + Cs5 + Cs6) / 6;

    public string ObjToString()
    {
        var b = Fio + "~" + Id + "~" + Cs1 + "~" + Cs2 + "~" + Cs3 + "~" + Cs4 + "~" + Cs5 + "~" + Cs6;
        return b;
    }
}
