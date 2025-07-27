using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    internal abstract class User
    {
        private static int _nextId = 0;

        public User()
        {
            UserId = _nextId++;
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Account UserAcc { get; set; }
    }

   
}
