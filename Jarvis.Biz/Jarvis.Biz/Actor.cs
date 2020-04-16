using System;
namespace Jarvis.Biz
{
    /// <summary>
    /// 
    /// </summary>
    public class Actor
    {
        public static readonly int ReadOnlyVariable;
                
        public String JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public String ActorName { get; set; }

        private String jobTitle; // camelCase

        static Actor()
        {
            ReadOnlyVariable = 5;
        }

        public Actor()
        {
            Console.WriteLine("An Actor is born on Day: " + ReadOnlyVariable);
        }

        public Actor(String actorName): this()            
        {
            ActorName = actorName;
        }

        /// <summary>
        /// Will return Title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation() // PascalCase
        {
            JobTitle = "Actor";
            return JobTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public string GetOccupation(bool current)
        {
            if (current)
                return "Actor";
            return "Janitorial Staff";
        }
    }
}
