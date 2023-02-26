using Avalonia.Media;
using studentAchievement.Models;
using ReactiveUI;
using System;
using System.Reactive;


namespace studentAchievement.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Student[] students;
        private Student Stud = new Student();
        private SolidColorBrush checkColor(float num)
        {
            if (num < 1) return new SolidColorBrush(Colors.Red);
            if (num < 1.5) return new SolidColorBrush(Colors.Yellow);
            else return new SolidColorBrush(Colors.Green);
        }

        private void CheckAverage(Student[] students)
        {
            for (int i = 0; i < 8; i++)
            {
                sc_scores[i] = 0;
            }
            for (int i = 0; i < students.Length; i++)
            {
                ScoreVisualSr += students[i].sc1;
                ScoreArchitectureSr += students[i].sc2;
                ScoreNetworksSr += students[i].sc3;
                ScoreCalculate_MathSr += students[i].sc4;
                ScorePISr += students[i].sc5;
                ScoreMathSr += students[i].sc6;
                ScoreAverageSr += students[i].Average_Score;
            }
            ScoreVisualSr /= students.Length;
            ColorVisualSr = checkColor(ScoreVisualSr);
            ScoreArchitectureSr /= students.Length;
            ColorArchitectureSr = checkColor(ScoreArchitectureSr);
            ScoreNetworksSr /= students.Length;
            ColorNetworksSr = checkColor(ScoreNetworksSr);
            ScoreCalculate_MathSr /= students.Length;
            ColorCalculate_MathSr = checkColor(ScoreCalculate_MathSr);
            ScorePISr /= students.Length;
            ColorPISr = checkColor(ScorePISr);
            ScoreMathSr /= students.Length;
            ColorMathSr = checkColor(ScoreMathSr);

            ScoreAverageSr /= students.Length;
            ColorAverageSr = checkColor(ScoreAverageSr);
        }

        public MainWindowViewModel()
        {
            AddStudent = ReactiveCommand.Create(() =>
            {
                if (newName != "")
                {
                    Student[] temp = students;
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = new Student(newName, scores[0], scores[1], scores[2], scores[3], scores[4], scores[5]);
                    Students = temp;
                    NewName = "";
                    ScoreVisual = 0;
                    ScoreArchitecture = 0;
                    ScoreNetworks = 0;
                    ScoreCalculate_Math = 0;
                    ScorePI = 0;
                    ScoreMath = 0;
                    CheckAverage(students);
                }
            });
            DeleteStudent = ReactiveCommand.Create(() =>
            {
                if (index < students.Length)
                {
                    Student[] temp = students;
                    for (int i = index; i < temp.Length - 1; i++)
                    {
                        temp[i] = temp[i + 1];
                    }
                    Array.Resize(ref temp, temp.Length - 1);
                    Students = temp;
                    Index = 5000;
                    CheckAverage(students);
                }
            });
            Save = ReactiveCommand.Create(() =>
            {
                students[0].WriteToFile(students);
            });
            Load = ReactiveCommand.Create(() =>
            {
                students = students[0].ReadFromFile();
                CheckAverage(students);
            });
            Students = new Student[]
            {
                new Student("Еремей Икашев Иванович", 2, 1, 1, 2, 2, 2),
                new Student("Иван Икашев Иванович", 1, 2, 0, 2, 0, 2),
                new Student("Аркадий Икашев Иванович", 0, 2, 0, 2, 2, 2)
            };
            CheckAverage(students);

        }

        public Student[] Students
        {
            get => students;
            set => this.RaiseAndSetIfChanged(ref students, value);
        }

        public ReactiveCommand<Unit, Unit> AddStudent { get; }
        public ReactiveCommand<Unit, Unit> DeleteStudent { get; }
        public ReactiveCommand<Unit, Unit> Save { get; }
        public ReactiveCommand<Unit, Unit> Load { get; }

        private ushort[] scores = { 0, 0, 0, 0, 0, 0, 0 };
        private string newName = "";
        private ushort index = 5000;
        private float[] sc_scores = { 0, 0, 0, 0, 0, 0, 0, 0 };
        private SolidColorBrush[] colorBrush = new SolidColorBrush[8];
        public ushort Index { get => index; set => this.RaiseAndSetIfChanged(ref index, value); }
        public string NewName { get => newName; set => this.RaiseAndSetIfChanged(ref newName, value); }
        public ushort ScoreVisual { get => scores[0]; set => this.RaiseAndSetIfChanged(ref scores[0], value); }
        public ushort ScoreArchitecture { get => scores[1]; set => this.RaiseAndSetIfChanged(ref scores[1], value); }
        public ushort ScoreNetworks { get => scores[2]; set => this.RaiseAndSetIfChanged(ref scores[2], value); }
        public ushort ScoreCalculate_Math { get => scores[3]; set => this.RaiseAndSetIfChanged(ref scores[3], value); }
        public ushort ScorePI { get => scores[4]; set => this.RaiseAndSetIfChanged(ref scores[4], value); }
        public ushort ScoreMath { get => scores[5]; set => this.RaiseAndSetIfChanged(ref scores[5], value); }

        public float ScoreVisualSr { get => sc_scores[0]; set => this.RaiseAndSetIfChanged(ref sc_scores[0], value); }
        public float ScoreArchitectureSr { get => sc_scores[1]; set => this.RaiseAndSetIfChanged(ref sc_scores[1], value); }
        public float ScoreNetworksSr { get => sc_scores[2]; set => this.RaiseAndSetIfChanged(ref sc_scores[2], value); }
        public float ScoreCalculate_MathSr { get => sc_scores[3]; set => this.RaiseAndSetIfChanged(ref sc_scores[3], value); }
        public float ScorePISr { get => sc_scores[4]; set => this.RaiseAndSetIfChanged(ref sc_scores[4], value); }
        public float ScoreMathSr { get => sc_scores[5]; set => this.RaiseAndSetIfChanged(ref sc_scores[5], value); }

        public float ScoreAverageSr { get => sc_scores[7]; set => this.RaiseAndSetIfChanged(ref sc_scores[7], value); }

        public SolidColorBrush ColorVisualSr { get => colorBrush[0]; set => this.RaiseAndSetIfChanged(ref colorBrush[0], value); }
        public SolidColorBrush ColorArchitectureSr { get => colorBrush[1]; set => this.RaiseAndSetIfChanged(ref colorBrush[1], value); }
        public SolidColorBrush ColorNetworksSr { get => colorBrush[2]; set => this.RaiseAndSetIfChanged(ref colorBrush[2], value); }
        public SolidColorBrush ColorCalculate_MathSr { get => colorBrush[3]; set => this.RaiseAndSetIfChanged(ref colorBrush[3], value); }
        public SolidColorBrush ColorPISr { get => colorBrush[4]; set => this.RaiseAndSetIfChanged(ref colorBrush[4], value); }
        public SolidColorBrush ColorMathSr { get => colorBrush[5]; set => this.RaiseAndSetIfChanged(ref colorBrush[5], value); }

        public SolidColorBrush ColorAverageSr { get => colorBrush[7]; set => this.RaiseAndSetIfChanged(ref colorBrush[7], value); }
    }
}
