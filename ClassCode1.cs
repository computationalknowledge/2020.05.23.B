using System;
using System.Collections;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            // remember this is version 1
            // next week we will web enable this to take input from the HTML Page
            // and store data in a MS SQL database
            public Task task1 = new Task('2018,7,1', "Toronto", new Activity());
        }
    }

    public class Task
    {
        public Task(DateTime aDateTime, String aLocaion, Activity activ1)
    {
        this.dtStamp = aDateTime;
        this.Location = aLocaion;
        this.anActivity = activ1;
    }
    public DateTime dtStamp;
        public String Location;
        public Activity anActivity;

    }

    public class Activity
    {
        public Activity(String descrip, Double aCost)
    {
        this.Description = descrip;
        this.cost = aCost;
    }
        public String Description;
        public Double cost;
    }

    public class Records
    {
        Queue DataStructure1;
    }
}
