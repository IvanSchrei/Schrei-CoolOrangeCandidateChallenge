using System;

namespace coolOrange_Planner
{

    public class Task : IPriority, IComplexity, IComparable<Task>
    {
        public String name;
        private int priority;
        private int complexity;

        public Task(string name){
            this.name = name;
            priority = (int)Priority.MED_PRIORITY;
            complexity = 0;
        }

        public void setName(string name){
            this.name = name;
        }

        public string getName(){
            return name;
        }

        public void setPriority(int priority){
            this.priority = priority;
        }

        public int getPriority(){
            return priority;
        }

        public void setComplexity(int complexity){
            this.complexity = complexity;
        }

        public int getComplexity(){
            return complexity;
        }

        public int CompareTo(Task? a){
            if(a != null){
                //CompareTo method used here is from the Int class.
                return a.priority.CompareTo(this.priority);
            }
            return -1;
        }

        public override string ToString()
        {
            return name + " priority: " + priority + " complexity: " + complexity;
        }
    }
}
