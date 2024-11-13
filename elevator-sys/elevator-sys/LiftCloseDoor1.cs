using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator_sys
{
    internal class LiftCloseDoor1 : ILift
    {
        public void liftCloseDoor(ElevatorContext lift)
        {
            if (lift.topLeftDoor.Left < lift.liftCar.Left)
            {
                // Move both lifts toward the center
                lift.topLeftDoor.Left += lift.liftSpeed;
                lift.topRightDoor.Left -= lift.liftSpeed;
            }
            else
            {
                // Stop the closing timer when fully closed
                lift.closeTimer.Stop();
                lift._CurrentState = new Idle();

                lift.reqButton1.Enabled = true;
                lift.reqButton2.Enabled = true;
                lift.reqUp.Enabled = true;
                lift.reqDown.Enabled = true;


            }
        }

        public void liftMovingDown(ElevatorContext lift)
        {
        }

        public void liftMovingUp(ElevatorContext lift)
        {
        }

        public void liftOpenDoor(ElevatorContext lift)
        {
        }
    }
}
