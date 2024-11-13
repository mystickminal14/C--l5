using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevator_sys
{
    internal class ElevatorContext
    {
        public int size, liftSpeed, doorSpeed, groundY, topY, floor = 0;
        public int width;
        public Timer movingUpTimer, movingDownTimer, closeTimer, openTimer;
        public Button reqUp, reqDown, reqButton1, reqButton2, reqOpen, reqClose, display, display1, display2;
        public PictureBox liftCar, topLeftDoor, topRightDoor, bottomLeftDoor, bottomRightDoor;
        public ILift _CurrentState;
        public ElevatorContext(PictureBox liftCar, int size, int liftSpeed, int doorSpeed, int width, int groundY, int topY, Timer movingUpTimer, Timer movingDownTimer, Timer closeTimer, Timer openTimer, Button reqUp, Button reqDown, Button reqButton1, Button reqButton2, Button reqOpen, Button reqClose, Button display, Button display1, Button display2, PictureBox topLeftDoor, PictureBox topRightDoor, PictureBox bottomLeftDoor, PictureBox bottomRightDoor)
        {
            this.liftCar = liftCar;
            this.size = size;
            this.liftSpeed = liftSpeed;
            this.doorSpeed = doorSpeed;
            this.width = width;
            this.groundY = groundY;
            this.topY = topY;
            this.movingUpTimer = movingUpTimer;
            this.movingDownTimer = movingDownTimer;
            this.closeTimer = closeTimer;
            this.openTimer = openTimer;
            this.reqUp = reqUp;
            this.reqDown = reqDown;
            this.reqButton1 = reqButton1;
            this.reqButton2 = reqButton2;
            this.reqOpen = reqOpen;
            this.reqClose = reqClose;
            this.display = display;
            this.display1 = display1;
            this.display2 = display2;
            this.topLeftDoor = topLeftDoor;
            this.topRightDoor = topRightDoor;
            this.bottomLeftDoor = bottomLeftDoor;
            _CurrentState = new Idle();
            this.bottomRightDoor = bottomRightDoor;
        }
        public void SetState(ILift state)
        {
            _CurrentState = state;
        }

        public void liftMovingUp()
        {
            _CurrentState.liftMovingUp(this);
        }

        public void liftMovingDown()
        {
            _CurrentState.liftMovingDown(this);
        }
        public void liftOpenDoor()
        {
            _CurrentState.liftOpenDoor(this);
        }

        public void liftCloseDoor()
        {
            _CurrentState.liftCloseDoor(this);
        }
    }
}
