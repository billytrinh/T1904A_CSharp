using System;

namespace T1904A
{
    public class Human
    {
        private string name;
        private int age;

        public Human()
        {
            Console.WriteLine("Constructor ...");
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            get
            {
                if (age <= 1) return 1;
                return age;
            }
            set
            {
                if (value <= 1){
                    this.age = 1;
                }else{
                    this.age = value;
                }
            }
        }
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine("Hello "+msg);
        }

        public virtual void Running()
        {
            Console.WriteLine("Running..");
        }

        public void Jumping()
        {
            Console.WriteLine("Jumping..");
        }
    }
}