using System;

namespace studentAchievement.Models
{
    internal class student
    {   
        public student(string name, int id, int cs1, int cs2, int cs3, int cs4, int cs5, int cs6)
        {
            this.name = name;
            this.id = id;
            this.cs1 = cs1;
            this.cs2 = cs2;
            this.cs3 = cs3;
            this.cs4 = cs4;
            this.cs5 = cs5;
            this.cs6 = cs6;
        }
        public student(string s)
        {
            string[] a = s.Split("~");
            this.name = a[0];
            this.id = Int32.Parse(a[1]);
            this.cs1 = Int32.Parse(a[2]);
            this.cs2 = Int32.Parse(a[3]);
            this.cs3 = Int32.Parse(a[4]);
            this.cs4 = Int32.Parse(a[5]);
            this.cs5 = Int32.Parse(a[6]);
            this.cs6 = Int32.Parse(a[7]);
        }

        public string name
        {
            set
            {
                string[] s = value.Split(' ');
                if(s.Length == 3)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
        public int id
        { set; get; }
        public int cs1
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    cs1 = value;
                }
            }
            get
            {
                return cs1;
            }
        }
        public int cs2
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    cs2 = value;
                }
            }
            get
            {
                return cs2;
            }
        }
        public int cs3
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    cs3 = value;
                }
            }
            get
            {
                return cs3;
            }
        }
        public int cs4
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    cs4 = value;
                }
            }
            get
            {
                return cs4;
            }
        }
        public int cs5
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    cs5 = value;
                }
            }
            get
            {
                return cs5;
            }
        }
        public int cs6
        {
            set
            {
                if (value >= 0 && value <= 2)
                {
                    cs6 = value;
                }
            }
            get
            {
                return cs6;
            }
        }

        public int averageCS()
        {
            return (cs1 + cs2 + cs3 + cs4 + cs5 + cs6) / 6;
        }
        public string toString(string s)
        {
            string b = name.ToString() + "~" + id.ToString() + "~" + cs1.ToString() + "~" + cs2.ToString() + "~" + cs3.ToString() + "~" + cs4.ToString() + "~" + cs5.ToString() + "~" + cs6;
            return b;
        }
    }
}
