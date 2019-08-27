using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeAndTheBoys
{
    class User
    {
        private int userId;
        private string userName;
        private double currency;
        private BadImageFormatException icon;

        public User(int id, string name, double curren)
        {
            userId = id;
            userName = name;
            currency = curren;
        }

        public void setName()
        {

        }

        public int buyCurrency()
        {
            return 0;
        }



    }
}
