using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Tester : User
    {
        public override string Name { get; set; }
        public override Team Team { get; set; }

        public override Roles Role
        {
            get { return Roles.Tester; }
        }


        public Tester()
        {

        }

        public override HeaderPanel BuildHeaderPanel(User user)
        {
            return null;
        }

        public override BodyPanel BuildBodyPanel(User user)
        {
            return null;
        }
    }
}
