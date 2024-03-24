namespace Events
{
    public class StudentGrades
    {
        public required string StudentName { get; set; }
        public required int[] Grades { get; set; }

        public int MaximumGrade()
        {
            return Grades.Max();
        }

        public double AverageGrade()
        {
            return Grades.Average();
        }
    }

    public class Program
    {
        static void Main()
        {
            StudentGrades[] students = new StudentGrades[]
            {
                new StudentGrades { StudentName = "John", Grades = new int[] { 9, 9, 8, 5 } },
                new StudentGrades { StudentName = "Alice", Grades = new int[] { 12, 12, 9, 11 } },
                new StudentGrades { StudentName = "Bob", Grades = new int[] { 10, 10, 8, 12 } }
            };

            StudentGrades studentWithMaxGrade = students.OrderByDescending(s => s.MaximumGrade()).First();
            Console.WriteLine($"Student with maximum grade: {studentWithMaxGrade.StudentName}, Grade: {studentWithMaxGrade.MaximumGrade()}");

            double averageGrade = students.Average(s => s.AverageGrade());
            Console.WriteLine($"Average grade across all students: {averageGrade}");
        }
    }
}
