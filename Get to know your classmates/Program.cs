using System;

namespace Get_to_know_your_classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welome to our student database!");
            string name = "";
            int student = 0;
            bool ConfirmStudet = true;
            bool runProgram = true;
            while (runProgram)
            {
                ConfirmStudet = true;
                while (ConfirmStudet)
                {
                    // Input of student
                    Console.WriteLine("Which student would you like to know about? (Enter a nuber in between 1 and 14)");
                    student = int.Parse(Console.ReadLine()) - 1;
                    if (student > 0 && student < 14)
                    {
                        name = NameOfStudent(student);
                        ConfirmStudet = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number. Please try again.");
                        ConfirmStudet = true;
                    }
                }
                bool homeAndFoodCheck = true;
                string end = "";
                bool valid = true;


                while (homeAndFoodCheck)
                {
                    // input of Hometown or food
                    Console.WriteLine($"Student {student + 1} is {name}. Would you like to know their hometown or favorite food? (hometown or favorite food)");
                    string knowledge = Console.ReadLine().ToLower();

                    string infoAboutStudent = "";
                    if (knowledge == "hometown")
                    {
                        infoAboutStudent = hometown(student);
                        Console.WriteLine($"{name} is from {infoAboutStudent}. Would you like to know more? (yes or no)");
                        end = Console.ReadLine();
                        homeAndFoodCheck = false;
                    }
                    else if (knowledge == "favorite food")
                    {
                        infoAboutStudent = FavFood(student);
                        Console.WriteLine($"{name} favorite food is {infoAboutStudent}. Would you like to know more? (yes or no)");
                        end = Console.ReadLine();
                        homeAndFoodCheck = false;
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist. Please try again. (enter 'hometown' or 'favorite food')");
                    }
                }
                while (valid)
                {

                    if (end == "yes")
                    {
                        runProgram = true;
                        valid = false;
                        Console.Clear();
                    }
                    else if (end == "no")
                    {
                        runProgram = false;
                        valid = false;
                    }
                    else
                    {
                        Console.WriteLine("Not valid option, please enter 'yes' or 'no'.");
                        Console.WriteLine("Would you like to ask again?");
                        end = Console.ReadLine();
                    }
                }
            }


        }
        public static string NameOfStudent(int x)
        {
            string[] Names = {
                "Justin",
                "Matt",
                "Logan",
                "Raston",
                "Yousif",
                "Yash",
                "Chris",
                "Radeen",
                "Josh",
                "Aron",
                "Kasean",
                "Scott",
                "Delmar",
                "Brandon"
            };
            string Student = Names[x];
            return Student;
        }

        public static string hometown(int x)
        {
            string[] town =
            {
                "Wyoming",
                "Flint",
                "Plymouth",
                "Zeeland",
                "Oak Park",
                "Detroit",
                "Novi",
                "Warren",
                "Northville",
                "Berea",
                "Detroit",
                "Lansing",
                "Detroit",
                "Novi"
            };
            string home = town[x];
            return home;
        }

        public static string FavFood(int x)
        {
            string[] Food =
            {
                "Baja Blast",
                "Hot Wings",
                "Funyuns",
                "Instant Vanilla Pudding",
                "Deep Dish Pizza",
                "Hot Cheetos",
                "Tacos",
                "Mexican",
                "Nalesniki",
                "Sushi",
                "Steak",
                "Nashville Chicken",
                "Vietnamese Food",
                "Sushi"
            };
            string favorite = Food[x];
            return favorite;
        }



    }
}
