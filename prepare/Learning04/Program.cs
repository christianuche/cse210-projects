using System;

class Program
{
    static void Main(string[] args)
    {
        // Base "Assignment" object
        Assignment A1 = new Assignment("Ogbuagu Obinna", "Multiplication");
        Console.WriteLine(A1.GetSummary());

        // Derived class assignments
        MathAssignment A2 = new MathAssignment("Diana Ifegwu", "Fractions", "7.3", "8-19");
        Console.WriteLine(A2.GetSummary());
        Console.WriteLine(A2.GetHomeworkList());

        WritingAssignment A3 = new WritingAssignment("Christian Uche", "Biafra History", "Nigeria Civil War");
        Console.WriteLine(A3.GetSummary());
        Console.WriteLine(A3.GetWritingInformation());
    }
}
