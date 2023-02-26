using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace studentAchievement.Models
{
    public class Student
    {

        public Student(string f, int cs1, int cs2, int cs3, int cs4, int cs5, int cs6)
        {
            Fio = f;
            sc1 = cs1;
            sc2 = cs2;
            sc3 = cs3;
            sc4 = cs4;
            sc5 = cs5;
            sc6 = cs6;

        }
        public Student()
        {

        }

        public Student(string s)
        {
            var a = s.Split("~");
            Fio = a[0];
            sc1 = int.Parse(a[1]);
            sc2 = int.Parse(a[2]);
            sc3 = int.Parse(a[3]);
            sc4 = int.Parse(a[4]);
            sc5 = int.Parse(a[5]);
            sc6 = int.Parse(a[6]);
        }

        private float sr_scores = 0;
        private int[] scores = { 0, 0, 0, 0, 0, 0 };
        private string fio = "";

        public string Fio
        {
            get => fio;
            set => fio = value;
        }

        public int sc1
        {
            get => scores[0];
            set => scores[0] = value;
        }


        public int sc2
        {
            get => scores[1];
            set => scores[1] = value;
        }

        public int sc3
        {
            get => scores[2];
            set => scores[2] = value;
        }

        public int sc4
        {
            get => scores[3];
            set => scores[3] = value;
        }

        public int sc5
        {
            get => scores[4];
            set => scores[4] = value;
        }
        public int sc6
        {
            get => scores[5];
            set => scores[5] = value;
        }

        public float Average_Score
        {
            get
            {
                sr_scores = 0;
                foreach (int num in scores)
                {
                    sr_scores += num;
                }
                return sr_scores /= 6;
            }
        }
        public Student[] ReadFromFile()
        {
            string path = "stud.txt";
            List<Student> people = new();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine("");
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    people.Add(new Student(line));
                }
            }
            people.RemoveAt(1);

            return people.ToArray();
        }

        public void WriteToFile(Student[] peopl)
        {
            List<Student> people = peopl.ToList();
            string path = "stud.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (Student student in people)
                {
                    if (student.Fio != "")
                    {
                        writer.WriteLine(student.ObjToString());
                    }
                }
            }
        }
        public string ObjToString()
        {
            var b = Fio + "~" + scores[0] + "~" + scores[1] + "~" + scores[2] + "~" + scores[3] + "~" + scores[4] + "~" + scores[5];
            return b;
        }
    }

}
