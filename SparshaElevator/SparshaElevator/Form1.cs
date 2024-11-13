using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparshaElevator
{
    public partial class Form1 : Form
    {
        public int elevatorSpeed = 10, width, groundY, firstY;
        public int doorSpeed = 7;
        private Elevator elevator;
        DataTable datatable = new DataTable();    
        ElevatordB db=new ElevatordB();


        public Form1()
        {
            InitializeComponent();
            groundY = lG.Location.Y;
            firstY = L1.Location.Y;
            width = elevatorBase.Width / 2;
            elevator = new Elevator(this.ClientSize.Height, elevatorSpeed, doorSpeed, width, groundY, firstY, L1, lG, r1, rG, elevatorBase, up, down, close, open, show, ask1, askg, upBu, downBu, khulla, banda);
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[1].Name = "Events";
        }

        private void showMsg(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            datatable.Rows.Add(currentTime, message);
            dataGridView1.Rows.Add(currentTime, message);

            db.InsertLogsIntoDB(datatable);
        }

        private void ask1_Click(object sender, EventArgs e)
        {
            elevator.SetState(new ElevatorUp());
            up.Start();
            ask1.Enabled = false;
            askg.Enabled = false;
            banda.Enabled = false;
            upBu.Enabled = false;
            downBu.Enabled = false;
            khulla.Enabled = false;
            showMsg("elevator is going to reach first floor!");
        }

        private void askg_Click(object sender, EventArgs e)
        {
            elevator.SetState(new ElevatorDown());
            down.Start();
            ask1.Enabled = false;
            askg.Enabled = false;
            banda.Enabled = false;
            upBu.Enabled = false;
            downBu.Enabled = false;
            khulla.Enabled = false;
            showMsg("elevator is arriving at ground floor");
        }

        private void upBu_Click(object sender, EventArgs e)
        {
            elevator.SetState(new ElevatorUp());
            up.Start();
            ask1.Enabled = false;
            askg.Enabled = false;
            banda.Enabled = false;
            upBu.Enabled = false;
            downBu.Enabled = false;
            khulla.Enabled = false;
            showMsg("elevator is going to reach first floor!");
        }

        private void downBu_Click(object sender, EventArgs e)
        {
            elevator.SetState(new ElevatorDown());
            down.Start();
            ask1.Enabled = false;
            askg.Enabled = false;
            banda.Enabled = false;
            upBu.Enabled = false;
            downBu.Enabled = false;
            khulla.Enabled = false;
            showMsg("elevator is arriving at ground floor");
        }

        private void banda_Click(object sender, EventArgs e)
        {
            if (elevator.initial == 1)
            {
                elevator.SetState(new ElevatorClose1());
                close.Start();
                ask1.Enabled = false;
                askg.Enabled = false;
                upBu.Enabled = false;
                downBu.Enabled = false;
                showMsg("Door of first floor is being closed!");

            }
            else
            {
                elevator.SetState(new ElevatorCloseG());
                close.Start();
                ask1.Enabled = false;
                askg.Enabled = false;
                upBu.Enabled = false;
                downBu.Enabled = false;
                showMsg("Door of ground floor is being closed!");

            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            elevator.ElevatorCloseDoor();
        }

        private void open_Tick(object sender, EventArgs e)
        {
            elevator.ElevatorOpenDoor();
        }

        private void khulla_Click(object sender, EventArgs e)
        {
            if (elevator.initial == 1)
            {
                elevator.SetState(new ElevatorOpen1());
                open.Start();
                ask1.Enabled = false;
                askg.Enabled = false;
                upBu.Enabled = false;
                downBu.Enabled = false;
               
                showMsg("Door of first floor is being opened!");

            }
            else
            {
                elevator.SetState(new ElevatorOpenG());
                open.Start();
                ask1.Enabled = false;
                askg.Enabled = false;
                upBu.Enabled = false;
                downBu.Enabled = false;
                showMsg("Door of ground floor is being opened!");

            }
        }

        private void up_Tick(object sender, EventArgs e)
        {
            elevator.ElevatorMoveUp();

        }

        private void down_Tick(object sender, EventArgs e)
        {
            elevator.ElevatorMoveDown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.loadLogsFromDB(datatable, dataGridView1);

        }
    }
}
