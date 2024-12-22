using System;

namespace coolOrange_Planner
{
    public enum Priority
    {
        MIN_PRIORITY = 1,
        MED_PRIORITY = 5,
        MAX_PRIORITY = 10
    }

    public interface IPriority
    {
        void setPriority(int priority);
        int getPriority();
    }

    public interface IComplexity
    {
        void setComplexity(int complexity);
        int getComplexity();
    }
}