using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator_sys
{
    internal class LiftOpenDoor1 : ILift
    {
        public void liftCloseDoor(ElevatorContext lift)
        {
        }

        public void liftMovingDown(ElevatorContext lift)
        {
        }

        public void liftMovingUp(ElevatorContext lift)
        {
        }

        public void liftOpenDoor(ElevatorContext lift)
        {
            if (lift.topLeftDoor.Left > lift.liftCar.Left - lift.width)
            {
                // Move both lifts away from the center
                lift.topLeftDoor.Left -= lift.doorSpeed;
                lift.topRightDoor.Left += lift.doorSpeed;
            }
            else
            {
                // Stop the opening timer when fully open
                lift.openTimer.Stop();
                lift._CurrentState = new Idle();
                lift.reqUp.Enabled = false;
                lift.reqDown.Enabled = false;
                lift.reqButton1.Enabled = false;
                lift.reqButton2.Enabled = false;

            }
        }
    }
}
