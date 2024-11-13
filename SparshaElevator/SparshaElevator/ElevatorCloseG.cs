using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshaElevator
{
    internal class ElevatorCloseG : IElevator
    {
        public void ElevatorCloseDoor(Elevator elevator)
        {
            if (elevator.leftG.Left < elevator.elevatorBase.Left)
            {
                // Move both elevators toward the center
                elevator.leftG.Left += elevator.elevatorSpeed;
                elevator.rightG.Left -= elevator.elevatorSpeed;
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
