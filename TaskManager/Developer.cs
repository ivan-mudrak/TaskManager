using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{

    public class Developer : User
    {
        public Developer()
            : base()
        {

        }

        public override string Name { get; set; }
        public override Team Team { get; set; }

        public override Roles Role
        {
            get { return Roles.Developer; }
        }        
    }
}
