using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator_sys
{
    internal interface ILift
    {
        void liftMovingUp(ElevatorContext lift);
        void liftMovingDown(ElevatorContext lift);
        void liftOpenDoor(ElevatorContext lift);
        void liftCloseDoor(ElevatorContext lift);
    }
}
