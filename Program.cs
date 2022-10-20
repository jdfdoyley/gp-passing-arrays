public class PassingArrays
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "\nJason D'Oyley - Week 3 GP Passing Arrays and Lists\n"
        );

        // Ask the user for a count of grades to be entered
        Console.WriteLine("Processing grades using an array:");
        Console.Write("How many grades will you entered? ");
        string? val = Console.ReadLine();
        int gradeCount = Convert.ToInt32(val);

        // Get an array of grades using our getGrades method
        int[] gradesArr = GetGrades(gradeCount);

        // Calculate the average of the grades using our averageGrades
        // method and display it
        int avg = AverageGrades(gradesArr);
        Console.WriteLine(
            "The average of the grades your entered is: {0}",
            avg
        );
    }

    // Get grades from the user and return an array of grades - note that we
    // have to know how many grades will be entered so we can create an
    // appropriately sized array and loop the correct number of times
    public static int[] GetGrades(int count)
    {
        // Create (declare) an array to hold the number of grades the user
        // specified
        int[] grades = new int[count];

        // Loop for the specified count and get values from the user, storing
        // them in an array to return once we have all the values
        for (int i = 0; i < count; i++)
        {
            Console.Write("Please enter a grade: ");
            string? val = Console.ReadLine();
            grades[i] = Convert.ToInt32(val);
        }

        return grades;
    }

    // Function to get the average of the grades in an array; use a for-each
    // loop to get the total then divide it by the number of items in the
    // array
    public static int AverageGrades(int[] grades)
    {
        int total = 0;

        foreach (int grade in grades)
        {
            total += grade;
        }

        return total / grades.Length;
    }
}