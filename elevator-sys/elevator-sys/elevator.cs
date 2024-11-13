using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevator_sys
{
    public partial class elevator : Form
    {
        public int groundY, topY;
        public int width;
        public int doorSpeed = 5, liftSpeed = 10;
        private ElevatorContext ElevatorContext;
        DataTable datatable = new DataTable();
        database database = new database();
        public elevator()
        {
            InitializeComponent();
            groundY = bottomLeftDoor.Location.Y;
            topY = topLeftDoor.Location.Y;
            width = (int)(liftCar.Width / 2);
            ElevatorContext = new ElevatorContext(liftCar, this.ClientSize.Height, liftSpeed, doorSpeed, width, groundY, topY, movingUpTimer, movingDownTimer, closeTimer, openTimer, reqUp, reqDown, reqButton1, reqButton2, reqOpen, reqClose, display, display1, display2, topLeftDoor, topRightDoor, bottomLeftDoor, bottomRightDoor);
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[0].Width = 80;

            dataGridView1.Columns[1].Name = "Events";
            dataGridView1.Columns[1].Width = 300;

        }
        private void displayMessage(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            datatable.Rows.Add(currentTime, message);
            dataGridView1.Rows.Add(currentTime, message);

            database.InsertLogsIntoDB(datatable);
        }
        private void openTimer_Tick(object sender, EventArgs e)
        {
            ElevatorContext.liftOpenDoor();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            ElevatorContext.liftCloseDoor();

        }

        private void movingUpTimer_Tick(object sender, EventArgs e)
        {
            ElevatorContext.liftMovingUp();

        }

        private void reqUp_Click(object sender, EventArgs e)
        {
            ElevatorContext.SetState(new LiftMovingUp());
            movingUpTimer.Start();
            reqUp.Enabled = false;
            reqDown.Enabled = false;
            reqClose.Enabled = false;
            reqButton2.Enabled = false;
            reqButton1.Enabled = false;
            reqOpen.Enabled = false;
            displayMessage("lift is moving to first floor!!");

        }

        private void reqDown_Click(object sender, EventArgs e)
        {
            ElevatorContext.SetState(new LiftMovingDown());
            movingDownTimer.Start();
            reqUp.Enabled = false;
            reqDown.Enabled = false;
            reqClose.Enabled = false;
            reqButton2.Enabled = false;
            reqButton1.Enabled = false;
            reqOpen.Enabled = false;
            displayMessage("lift is moving to ground floor!!");

        }



        private void reqClose_Click(object sender, EventArgs e)
        {
            if (ElevatorContext.floor == 1)
            {
                ElevatorContext.SetState(new LiftCloseDoor1());
                closeTimer.Start();
                reqUp.Enabled = false;
                reqDown.Enabled = false;
                reqButton1.Enabled = false;
                reqButton2.Enabled = false;
                displayMessage("1st floor door is being closed!!");


            }
            else
            {
                ElevatorContext.SetState(new LiftCloseDoor0());
                closeTimer.Start();
                reqUp.Enabled = false;
                reqDown.Enabled = false;
                reqButton1.Enabled = false;
                reqButton2.Enabled = false;
                displayMessage("Ground floor door is being closed!!");


            }
        }

        private void reqButton1_Click(object sender, EventArgs e)
        {
            ElevatorContext.SetState(new LiftMovingUp());
            movingUpTimer.Start();
            reqUp.Enabled = false;
            reqDown.Enabled = false;
            reqClose.Enabled = false;
            reqButton2.Enabled = false;
            reqButton1.Enabled = false;
            reqOpen.Enabled = false;
            displayMessage("lift is moving to first floor!!");

        }

        private void reqOpen_Click(object sender, EventArgs e)
        {
            if (ElevatorContext.floor == 1)
            {
                ElevatorContext.SetState(new LiftOpenDoor1());
                openTimer.Start();
                reqUp.Enabled = false;
                reqDown.Enabled = false;
                reqButton1.Enabled = false;
                reqButton2.Enabled = false;
                displayMessage("First floor door is being opened!!");



            }
            else
            {
                ElevatorContext.SetState(new LiftOpenDoor0());
                openTimer.Start();
                reqUp.Enabled = false;
                reqDown.Enabled = false;
                reqButton1.Enabled = false;
                reqButton2.Enabled = false;
                displayMessage("Ground floor door is being opened!!");


            }
        }

        private void movingDownTimer_Tick(object sender, EventArgs e)
        {
            ElevatorContext.liftMovingDown();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            database.clearData(datatable, dataGridView1);
        }

        private void reqButton2_Click(object sender, EventArgs e)
        {
            ElevatorContext.SetState(new LiftMovingDown());
            movingDownTimer.Start();
            reqUp.Enabled = false;
            reqDown.Enabled = false;
            reqClose.Enabled = false;
            reqButton2.Enabled = false;
            reqButton1.Enabled = false;
            reqOpen.Enabled = false;
            displayMessage("lift is moving to ground floor!!");

        }

        private void elevator_Load(object sender, EventArgs e)
        {
            database.loadLogsFromDB(datatable, dataGridView1);
        }
    }
}
