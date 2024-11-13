using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator_sys
{
    internal class LiftMovingDown : ILift
    {
        public void liftCloseDoor(ElevatorContext lift)
        {
        }

        public void liftMovingDown(ElevatorContext lift)
        {
            int distanceToGround = lift.groundY - lift.liftCar.Top;

            if (distanceToGround > lift.liftSpeed)
            {
                lift.liftCar.Top += lift.liftSpeed;
                lift.reqOpen.Enabled = false;
                lift.reqClose.Enabled = false;
            }
            else
            {
                lift.liftCar.Top = lift.groundY;
                lift.SetState(new Idle());
                lift.floor = 0;
                lift.movingDownTimer.Stop();

                lift.display.Text = $"G";
                lift.display1.Text = $"G";
                lift.display2.Text = $"G";
                lift.reqButton1.Enabled = true;
                lift.reqButton2.Enabled = true;
                lift.reqUp.Enabled = true;
                lift.reqDown.Enabled = true;
                lift.reqClose.Enabled = true;
                lift.reqOpen.Enabled = true;
                lift.reqOpen.PerformClick();

            }
        }

        public void liftMovingUp(ElevatorContext lift)
        {
        }

        public void liftOpenDoor(ElevatorContext lift)
        {
        }
    }
}
