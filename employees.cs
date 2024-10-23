using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    public abstract class employees
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public abstract void Mission();
       
        public void Info()
        {
            Console.WriteLine($"{Name} {Surname} Department is: {Department}");
        }
    }

    public class projectManager : employees 
    { 
        public override void Mission()
        {
            Console.WriteLine("I work as a project manager.\n");
        }
    } 
    
    
    public class softwareDeveloper : employees 
    { 
        public override void Mission()
        {
            Console.WriteLine("I work as a sofware developer.\n");
        }
    }

    public class salesRepresentative : employees
    {
        public override void Mission()
        {
            Console.WriteLine("I work as a sales representative.\n");
        }
    }


}
