using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshaElevator
{
    internal class ElevatorDown : IElevator
    {
        public void ElevatorCloseDoor(Elevator elevator)
        {
        }

        public void ElevatorMoveDown(Elevator elevator)
        {
            int distanceToGround = elevator.groundY - elevator.elevatorBase.Top;

            if (distanceToGround > elevator.elevatorSpeed)
            {
                elevator.elevatorBase.Top += elevator.elevatorSpeed;
                elevator.open.Enabled = false;
                elevator.close.Enabled = false;
            }
            else
            {
                elevator.elevatorBase.Top = elevator.groundY;
                elevator.SetState(new Idle());
                elevator.downTimer.Stop();

                elevator.initial = 0;
                elevator.show.Text = $"G";
                elevator.req1.Enabled = true;
                elevator.reqG.Enabled = true;
                elevator.up.Enabled = true;
                elevator.down.Enabled = true;
                elevator.close.Enabled = true;
                elevator.open.Enabled = true;
                elevator.open.PerformClick();

            }
        }

        public void ElevatorMoveUp(Elevator elevator)
        {
        }

        public void ElevatorOpenDoor(Elevator elevator)
        {
        }
    }
}
