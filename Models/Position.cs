using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Position
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public ICollection<Worker> Workers { get; set; } = new List<Worker>();

        public Position() {
        }

        public Position(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
