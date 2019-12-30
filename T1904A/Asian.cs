using System;

namespace T1904A
{
    public class Asian : Human,IHuman,IAsian
    {
        public string[] telephone = new string[5];

        public string this[int index]
        {
            get { return telephone[index]; }
            set { telephone[index] = value; }
        }
        public override void Running()
        {
            base.Running();
            Console.WriteLine("Asian running..");
        }
        
        public new void Jumping()
        {
            Console.WriteLine("Asian jumping..");
        }

        public void Shopping()
        {
            
        }
        public void Drive()
        {
            
        }
        public void Parking()
        {
            
        }
        
    }
}