using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikLift
{
    internal class DoorOpen1 : ILift
    {
        public void LiftCloseDoor(lift lift)
        {
        }

        public void LiftMoveDown(lift lift)
        {
        }

        public void LiftMoveUp(lift lift)
        {
        }

        public void LiftOpenDoor(lift lift)
        {
            if (lift.left1.Left > lift.liftBase.Left - lift.width)
            {
                lift.left1.Left -= lift.doorSpeed;
                lift.right1.Left += lift.doorSpeed;
            }
            else
            {
                // Stop the opening timer when fully open
                lift.openTimer.Stop();
                lift._CurrentState = new Idle();
                lift.req1.Enabled = false;
                lift.reqG.Enabled = false;
                lift.up.Enabled = false;
                lift.down.Enabled = false;

            }
        }
    }
}
