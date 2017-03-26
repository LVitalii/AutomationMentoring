using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public class LegalPerson : IHashId
    {
        public LegalPerson(int id)
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
