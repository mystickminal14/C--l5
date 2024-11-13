using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator_sys
{
    internal class LiftMovingUp : ILift
    {
        public void liftCloseDoor(ElevatorContext lift)
        {
          
        }

        public void liftMovingDown(ElevatorContext lift)
        {
        }

        public void liftMovingUp(ElevatorContext lift)
        {
            int distance = lift.liftCar.Top - lift.topY;
            if (distance >= lift.liftSpeed)
            {
                lift.liftCar.Top -= lift.liftSpeed;
                lift.reqOpen.Enabled = false;
                lift.reqClose.Enabled = false;
            }
            else
            {
                lift.liftCar.Top = lift.topY;
                lift.SetState(new Idle());
                lift.floor = 1;
                lift.movingUpTimer.Stop();
                lift.display.Text = $"1";
                lift.display1.Text = $"1";
                lift.display2.Text = $"1";
                lift.reqButton1.Enabled = true;
                lift.reqButton2.Enabled = true;
                lift.reqUp.Enabled = true;
                lift.reqDown.Enabled = true;
                lift.reqClose.Enabled = true;
                lift.reqOpen.Enabled = true;

                lift.reqOpen.PerformClick();
            }
        }

        public void liftOpenDoor(ElevatorContext lift)
        {
        }
    }
}
