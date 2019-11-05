using System;
//Added to repository lab12assignGrades in github

namespace L12_AssignGrades_MNJ
{
    class GradesDriver
    {
        static void Main(string[] args)
        {
            int numStudents;
            Console.WriteLine("Please enter the class size (number of students): ");
            numStudents = Convert.ToInt32(Console.ReadLine());
            int[] classArray = new int[numStudents];
            Grades g = new Grades();
            g.getGradeArray(classArray);
            g.printGradeArray(classArray);
            g.printGrades(classArray);
        }
    }


    class Grades
    {
        //class variable
        int inputGrades;

        public void getGradeArray(int [] classArray)
        {
            for (int i = 0; i < classArray.Length; i++)
            {
                Console.WriteLine("\nEnter a grade value between 0-100: ");
                inputGrades = Convert.ToInt32(Console.ReadLine());
                if (inputGrades >= 0 && inputGrades <= 100)
                {
                    classArray[i] = inputGrades;            
                }
                else
                {
                    do
                    {
                        Console.WriteLine("\nInvalid entry. Try again.\nEnter a grade value between 0-100: ");
                        inputGrades = Convert.ToInt32(Console.ReadLine());
                        classArray[i] = inputGrades;
                    } while (inputGrades < 0 || inputGrades > 100);
                }
            }
        }

        public void printGradeArray(int [] classArray)
        {
            Console.Write("\nEntered grades: ");
            for (int i = 0; i < classArray.Length; i++)
            {
                Console.Write(classArray[i] + " ");
            }
            Console.Write("\n");
        }

        public void printGrades(int [] classArray)
        {
            Console.Write("\n");
            char letterGrade;
            for (int i = 0; i < classArray.Length; i++)
            {
                if (classArray[i] >= 90 && classArray[i] <= 100)
                {
                    letterGrade = 'A';
                }
                else if (classArray[i] >= 80 && classArray[i] <= 89)
                {
                    letterGrade = 'B';
                }
                else if (classArray[i] >= 70 && classArray[i] <= 79)
                {
                    letterGrade = 'C';
                }
                else if (classArray[i] >= 60 && classArray[i] <= 69)
                {
                    letterGrade = 'D';
                }
                else
                {
                    letterGrade = 'F';
                }
                
                Console.WriteLine("Student " + i + " score is " + classArray[i] + " and grade is " + letterGrade);
            }
        }

    }




}
