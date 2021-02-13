using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class OldRobotBuilder : IRobotBuilder
    {
        private Robot _robot;

        public OldRobotBuilder()
        {
            _robot = new Robot();
        }

        public void setRobotArm()
        {
            _robot.arm = "pistol hand";
        }

        public void setRobotHead()
        {
            _robot.head = "sturdy hand";
        }

        public Robot getRobot()
        {
            return _robot; 
        }
    }
}
