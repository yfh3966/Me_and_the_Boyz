using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeAndTheBoys
{
    class Unit
    {
        private int unitSpeed;
        private Weapon unitGun;
        private string unitName;

        public Unit(int speed, Weapon gun, string name)
        {
            unitSpeed = speed;
            unitGun = gun;
            unitName = name;
        }
        public void move()
        {

        }

        public void live()
        {

        }
    }
}
