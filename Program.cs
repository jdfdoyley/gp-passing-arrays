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

        // Get an array of grades using our getGrades method - note we're
        // using the overload that doesn't need the user to enter a count of
        // grades - an advantage of using a List - we don't need to know how
        // many items in advance
        Console.WriteLine("\nProcessing grades using a List:");
        List<int> gradesList = GetGrades();

        // Calculate the average of the grades using our AverageGrades
        // method and display it
        avg = AverageGrades(gradesList);
        Console.WriteLine(
            "The average of the grades you entered is: {0}",
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

    // Overloaded function to get grades from the user and return a List of
    // grades - note that we do not need to know how many grades will be entered
    // since we're using a List, allowing the user to determine when they're
    // done
    public static List<int> GetGrades()
    {
        // Create (declare) a List to hold grades - no need to give it a size;
        // we'll let the user decide when to stop
        List<int> grades = new List<int>();

        // Loop to get values from the user, storing them in an ArrayList to
        // return once we have the values; use a do-while loop so we always get
        // a value from the user, even if it's a -1 because they changed their
        // mind...users do that sometimes
        int grade = -1;

        do
        {
            Console.Write("Please enter a grade (-1 to quit): ");
            string? val = Console.ReadLine();
            grade = Convert.ToInt32(val);

            if (grade > 0)
            {
                grades.Add(grade);
            }
        } while (grade > 0);

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

    // Overloaded function to get the average of the grades in a List; use a
    // for-each loop to get the total then divide it by the number of item in
    // the List
    public static int AverageGrades(List<int> grades)
    {
        int total = 0;

        foreach (int grade in grades)
        {
            total += grade;
        }

        return total / grades.Count;
    }
}