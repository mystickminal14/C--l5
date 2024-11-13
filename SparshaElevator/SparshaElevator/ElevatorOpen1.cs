using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshaElevator
{
    internal class ElevatorOpen1 : IElevator
    {
        public void ElevatorCloseDoor(Elevator elevator)
        {
        }

        public void ElevatorMoveDown(Elevator elevator)
        {
        }

        public void ElevatorMoveUp(Elevator elevator)
        {
        }

        public void ElevatorOpenDoor(Elevator elevator)
        {
            if (elevator.left1.Left > elevator.elevatorBase.Left - elevator.width)
            {
                // Move both elevators away from the center
                elevator.left1.Left -= elevator.doorSpeed;
                elevator.right1.Left += elevator.doorSpeed;
            }
            else
            {
                // Stop the opening timer when fully open
                elevator.openTimer.Stop();
                elevator._CurrentState = new Idle();
                elevator.req1.Enabled = false;
                elevator.reqG.Enabled = false;
                elevator.up.Enabled = false;
                elevator.down.Enabled = false;

            }
        }
    }
}
