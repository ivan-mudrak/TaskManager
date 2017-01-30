using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public enum Seniorities
    {
        Trainee,
        Junior,
        Middle,
        Senior
    }

    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperInfo : Attribute
    {
        private string _emailAddress;
        private int _revision;
       

        public DeveloperInfo(string emailAddress, int revision)
        {
            this._emailAddress = emailAddress;
            this._revision = revision;        
        }
    }

    [Serializable]
    [DeveloperInfo("mud@simcorp.com", 1)]
    class Developer : User
    {       
        public Developer()
        {
              
        }
    }
}
