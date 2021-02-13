using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Engineer : IEngineer
    {
        private IRobotBuilder _robot;

        public Engineer(IRobotBuilder robot)
        {
            _robot = robot;
        }

        public Robot buildRobot()
        {
            _robot.setRobotArm();
            _robot.setRobotHead();

            return _robot.getRobot();
        }

    }
}
