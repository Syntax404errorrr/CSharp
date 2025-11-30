using System;

class ReportCard
{
    static void Main(string[] args)
    {
        Console.Write("Enter Total Students : ");
        int totalStudents = Convert.ToInt32(Console.ReadLine());

        string[,] data = new string[totalStudents, 5];

        for (int i = 0; i < totalStudents; i++)
        {
            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();

            int eng = GetValidMarks("Enter English Marks (Out Of 100) : ");
            int math = GetValidMarks("Enter Math Marks (Out Of 100) : ");
            int comp = GetValidMarks("Enter Computer Marks (Out Of 100) : ");

            int total = eng + math + comp;

            // Store in array
            data[i, 0] = name;
            data[i, 1] = eng.ToString();
            data[i, 2] = math.ToString();
            data[i, 3] = comp.ToString();
            data[i, 4] = total.ToString();

            Console.WriteLine("*********************************************");
        }

        for (int i = 0; i < totalStudents - 1; i++)
        {
            for (int j = i + 1; j < totalStudents; j++)
            {
                int total1 = Convert.ToInt32(data[i, 4]);
                int total2 = Convert.ToInt32(data[j, 4]);

                if (total2 > total1) // swap for descending order
                {
                    for (int k = 0; k < 5; k++)
                    {
                        string temp = data[i, k];
                        data[i, k] = data[j, k];
                        data[j, k] = temp;
                    }
                }
            }
        }

       // Output

        Console.WriteLine("****************Report Card*******************");

        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"Student Name: {data[i, 0]}, Position: {i + 1}, Total: {data[i, 4]}/300");
            Console.WriteLine("****************************************");
        }
    }

    // Validation
  
    static int GetValidMarks(string message)
    {
        int marks;

        while (true)
        {
            Console.Write(message);
            bool valid = int.TryParse(Console.ReadLine(), out marks);

            if (!valid || marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
            else
            {
                break;
            }
        }

        return marks;
    }
}
