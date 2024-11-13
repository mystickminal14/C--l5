using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparshaElevator
{
    internal class Elevator
    {
        public int size, elevatorSpeed, doorSpeed, width, groundY, firstY, initial = 0;
        public PictureBox left1, leftG, right1, rightG, elevatorBase;
        public Timer upTimer, downTimer, closeTimer, openTimer;
        public Button show, req1, reqG, up, down, open, close;
        public IElevator _CurrentState;
        public Elevator(int size, int elevatorSpeed, int doorSpeed, int width, int groundY, int firstY, PictureBox left1, PictureBox leftG, PictureBox right1, PictureBox rightg, PictureBox elevatorBase, Timer upTimer, Timer downTimer, Timer closeTimer, Timer openTimer, Button show, Button req1, Button reqG, Button up, Button down, Button open, Button close)
        {
            this.size = size;
            this.elevatorSpeed = elevatorSpeed;
            this.doorSpeed = doorSpeed;
            this.width = width;
            this.groundY = groundY;
            this.firstY = firstY;
            this.left1 = left1;
            this.leftG = leftG;
            this.right1 = right1;
            this.rightG = rightg;
            this.elevatorBase = elevatorBase;
            this.upTimer = upTimer;
            this.downTimer = downTimer;
            this.closeTimer = closeTimer;
            this.openTimer = openTimer;
            this.show = show;
            this.req1 = req1;
            this.reqG = reqG;
            this.up = up;
            this.down = down;
            this.open = open;
            this.close = close;
            _CurrentState = new Idle();

        }
        public void SetState(IElevator state)
        {
            _CurrentState = state;
        }

        public void ElevatorMoveUp()
        {
            _CurrentState.ElevatorMoveUp(this);
        }

        public void ElevatorMoveDown()
        {
            _CurrentState.ElevatorMoveDown(this);
        }
        public void ElevatorOpenDoor()
        {
            _CurrentState.ElevatorOpenDoor(this);
        }

        public void ElevatorCloseDoor()
        {
            _CurrentState.ElevatorCloseDoor(this);
        }
    }
  

}
