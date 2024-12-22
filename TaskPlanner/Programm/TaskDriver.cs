using System;

namespace coolOrange_Planner
{

    public class TaskDriver
    {
        public static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            Task homework = new Task("Doing Homework");
            homework.setPriority((int)Priority.MAX_PRIORITY);
            homework.setComplexity(8);

            Task lunch = new Task("Eating Lunch");
            lunch.setPriority((int)Priority.MIN_PRIORITY);
            lunch.setComplexity(2);

            Task programming = new Task("Programming");
            programming.setPriority((int)Priority.MED_PRIORITY);
            programming.setComplexity(5);

            tasks.Add(homework);
            tasks.Add(lunch);
            tasks.Add(programming);

            //Sort using the .Sort method of the List class. This uses the implemented CompareTo method
            tasks.Sort();

            Console.WriteLine("TO-DO");
            foreach (var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }

            Console.WriteLine($"{tasks[0].ToString()} is one of the most important tasks.");
        }
    }
}