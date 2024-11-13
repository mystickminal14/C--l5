using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshaElevator
{
    internal class ElevatorClose1 : IElevator
    {
        public void ElevatorCloseDoor(Elevator elevator)
        {
            if (elevator.left1.Left < elevator.elevatorBase.Left)
            {
                elevator.left1.Left += elevator.elevatorSpeed;
                elevator.right1.Left -= elevator.elevatorSpeed;
            }
            else
            {
                // Stop the closing timer when fully closed
                elevator.closeTimer.Stop();
                elevator._CurrentState = new Idle();

                elevator.req1.Enabled = true;
                elevator.reqG.Enabled = true;
                elevator.up.Enabled = true;
                elevator.down.Enabled = true;



            }
        }

        public void ElevatorMoveDown(Elevator elevator)
        {
        }

        public void ElevatorMoveUp(Elevator elevator)
        {
        }

        public void ElevatorOpenDoor(Elevator elevator)
        {
        }
    }
}
