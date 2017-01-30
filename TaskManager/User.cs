using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public enum Roles
    {
        Admin,
        Manager,
        ScrumMaster,
        ProductOwner,
        Developer,
        Tester
    }

    public abstract class User
    {
        public abstract string Name { get; set; }
        public abstract Roles Role { get; }
        public abstract Team Team { get; set; }        
 
        public virtual HeaderPanel BuildHeaderPanel(User user)
        {
            return null;
        }
        public virtual BodyPanel BuildBodyPanel(User user)
        {
            return null;
        }
    }
}
