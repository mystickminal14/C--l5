using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikLift
{
    internal interface ILift
    {

        void LiftMoveUp(lift lift);
        void LiftMoveDown(lift lift);

        void LiftOpenDoor(lift lift);
        void LiftCloseDoor(lift lift);

    }
}
