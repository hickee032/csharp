using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Robot {
    public void Move() {
        Console.WriteLine("robot move");
    }
}
class CleanRobot : Robot {
    public void Clean() {
        Console.WriteLine("robot clean start");
    }
}
class RescueCleanRobot : Robot {
        public void Clean() {
            Console.WriteLine("Rescue robot clean start");
        }
}




namespace Inheritance {
    internal class Inheritance {
        static void Main(string[] args) {
            CleanRobot cleanRobot = new CleanRobot();
            cleanRobot.Move();
            cleanRobot.Clean();

            RescueCleanRobot rerobot = new RescueCleanRobot();
            rerobot.Move();

        }
    }
}
