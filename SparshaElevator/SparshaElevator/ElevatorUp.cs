using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshaElevator
{
    internal class ElevatorUp : IElevator
    {
        public void ElevatorCloseDoor(Elevator elevator)
        {
        }

        public void ElevatorMoveDown(Elevator elevator)
        {
        }

        public void ElevatorMoveUp(Elevator elevator)
        {
            int distanceToFirstFloor = elevator.elevatorBase.Top - elevator.firstY;
            if (distanceToFirstFloor >= elevator.elevatorSpeed)
            {
                elevator.elevatorBase.Top -= elevator.elevatorSpeed;
                elevator.open.Enabled = false;
                elevator.close.Enabled = false;
            }
            else
            {
                elevator.elevatorBase.Top = elevator.firstY;
                elevator.SetState(new Idle());
                elevator.initial = 1;
                elevator.upTimer.Stop();
                elevator.show.Text = $"1";
                elevator.req1.Enabled = true;
                elevator.reqG.Enabled = true;
                elevator.up.Enabled = true;
                elevator.down.Enabled = true;
                elevator.close.Enabled = true;
                elevator.open.Enabled = true;

                elevator.open.PerformClick();

            }
        }

        public void ElevatorOpenDoor(Elevator elevator)
        {
        }
    }
}
