using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public class LegalPerson : IHashId
    {
        private int id;
        public int Id
        {
            get { return id; }
        }
    }
}
