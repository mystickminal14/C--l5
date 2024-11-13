using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshaElevator
{
    internal interface IElevator
    {
        void ElevatorMoveUp(Elevator elevator);
        void ElevatorMoveDown(Elevator elevator);
        void ElevatorOpenDoor(Elevator elevator);
        void ElevatorCloseDoor(Elevator elevator);



    }
}
