using System;

namespace studentAchievement.Models
{
    class Student
    {
        public Student() {
            Fio = "";
        }
        public Student(string f, int id, int Cs1, int Cs2, int Cs3, int Cs4, int Cs5, int Cs6)
        {
            this.Fio = f;
            this.Id = id;
            this.Cs1 = Cs1;
            this.Cs2 = Cs2;
            this.Cs3 = Cs3;
            this.Cs4 = Cs4;
            this.Cs5 = Cs5;
            this.Cs6 = Cs6;
        }
        public Student(string s)
        {
            string[] a = s.Split("~");
            this.Fio = a[0].ToString();
            this.Id = Int32.Parse(a[1]);
            this.Cs1 = Int32.Parse(a[2]);
            this.Cs2 = Int32.Parse(a[3]);
            this.Cs3 = Int32.Parse(a[4]);
            this.Cs4 = Int32.Parse(a[5]);
            this.Cs5 = Int32.Parse(a[6]);
            this.Cs6 = Int32.Parse(a[7]);
        }

        public string Fio { set; get; } = "";

        public int Id
        { set; get; }
        public int Cs1
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    Cs1 = value;
                }
            }
            get
            {
                return Cs1;
            }
        }
        public int Cs2
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    Cs2 = value;
                }
            }
            get
            {
                return Cs2;
            }
        }
        public int Cs3
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    Cs3 = value;
                }
            }
            get
            {
                return Cs3;
            }
        }
        public int Cs4
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    Cs4 = value;
                }
            }
            get
            {
                return Cs4;
            }
        }
        public int Cs5
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    Cs5 = value;
                }
            }
            get
            {
                return Cs5;
            }
        }
        public int Cs6
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    Cs6 = value;
                }
            }
            get
            {
                return Cs6;
            }
        }

        public int AverageCs()
        {
            return (Cs1 + Cs2 + Cs3 + Cs4 + Cs5 + Cs6) / 6;
        }
        public string ObjToString()
        {
            string b = Fio + "~" + Id.ToString() + "~" + Cs1.ToString() + "~" + Cs2.ToString() + "~" + Cs3.ToString() + "~" + Cs4.ToString() + "~" + Cs5.ToString() + "~" + Cs6.ToString();
            return b;
        }
    }
}
