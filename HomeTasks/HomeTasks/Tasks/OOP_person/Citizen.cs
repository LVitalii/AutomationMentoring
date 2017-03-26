using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeTasks
{
    public class Citizen : Person, IHashId
    {
        public Citizen(string name, int age, int id) : base (name, age)
        {
            this.id = id;
        }

        private int id;
        public int Id
        {
            get { return id; }
        }
    }
}
