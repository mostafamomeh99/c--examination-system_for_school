namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // search in how we find that int x , is not a number
            // how to generte random number
            //List<string> list =new List<string>() { "ahmed","alaa","mohamed"};
            //Random random = new Random();
            //int randomIndex = random.Next(list.Count);
            //Console.WriteLine(list[randomIndex]);

            Exaninationsystem mysystem = new Exaninationsystem();

            Student ahmed = new Student(1, "ahmed");
            Student alaa = new Student(2, "alaa");
            Student mostafa = new Student(3, "mostafa");
            Student omar = new Student(4, "omar");

            mysystem.enrollstudent(ahmed);
            mysystem.enrollstudent(alaa);
            mysystem.enrollstudent(mostafa);
            mysystem.enrollstudent(omar);
            // mysystem.displayallstudents();

            string input = "any";
            do
            {
                Console.WriteLine("student or teacher?");
                // note that !!! we can't write this line of code
                //string input = Console.ReadLine();
                input = Console.ReadLine();

                //teacher
                if (input.ToLower().Contains("teacher"))
                {
                    mysystem.MakeExam();
                    //note that
                    // we declare here variable cause we cannot declear inside (do) block and check for it
                    string inputrepeat = "any";
                    do
                    {
                        Console.WriteLine("do you want to make another exam? (y) yes / press any thing to escape");
                        inputrepeat = Console.ReadLine();
                        if (inputrepeat == "y" || inputrepeat == "Y")
                        {
                            mysystem.MakeExam();


                        }
                        else { Console.WriteLine("---thank you, teacher "); }

                    }
                    while (inputrepeat == "y" || inputrepeat == "Y");

                    // if u want to show exams
                    //mysystem.GetExams();
                }
                // end of teacher and exam

                //student
                else if (input.ToLower().Contains("student"))
                {
                    Console.WriteLine("a- are you ready to start exam?\nb- show my information\n/////choose a or b");
                    string inputstudent = Console.ReadLine();
                    if (inputstudent.ToLower()=="a")
                    {
                        if (mysystem.Exams.Count == 0)
                        { Console.WriteLine("---there is no exams yet"); }
                        else
                        {
                            mysystem.TakeExam();
                            //Console.WriteLine("lets start");
                        }

                    }
                    else if (inputstudent.ToLower() == "b")
                    {
                        try
                        {
                            Console.WriteLine("enter your id");
                            int inputid = int.Parse(Console.ReadLine());
                            Student founded = mysystem.Students.Find(el => el.Id == inputid);
                            if (founded != null)
                            { Console.WriteLine(founded); }
                            else { Console.WriteLine("---you are not in system"); }
                        }
                        catch (FormatException e)
                        { Console.WriteLine("---not valid answer"); }

                    }

                }
                // unknown input
                else { Console.WriteLine("---not valid answer"); }

            } while (input.ToLower().Contains("student") || input.ToLower().Contains("teacher"));


        }
    }

    }