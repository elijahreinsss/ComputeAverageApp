namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        private static double gradess, ave, gradesss;

        static void Main(string[] args)
        {

            Console.WriteLine(" Enter 5 grades seperated by new line: ");
            for (int i = 0; i < 5; i++) {

                
                    double grades = Convert.ToDouble(Console.ReadLine());

                    gradess += grades;

                    ave = gradess / 5;
                    gradesss = Math.Round(ave);

                }
                Console.Write(" the average is " + ave + " and round off to " + gradesss);

            }
        }
    }
        
    


    


