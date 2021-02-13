using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    interface IRobotBuilder
    {
        public void setRobotHead();

        public void setRobotArm();

        public Robot getRobot();
    }
}
