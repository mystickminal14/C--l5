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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PratikLift
{
    public partial class Form1 : Form
    {
        public int liftSpeed = 10, doorSpeed = 7, width, groundY, firstY;
        DataTable datatable = new DataTable();
        Storage db=new Storage();
        private lift lift;
        public Form1()
        {
            InitializeComponent();
            groundY = ldoorg.Location.Y;
            firstY = ldoor1.Location.Y;
            width = mainBase.Width / 2;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[1].Name = "Events";
            lift = new lift(this.ClientSize.Height, liftSpeed, doorSpeed, width, groundY, firstY, ldoor1, ldoorg, rdoor1, rdoorg, mainBase, mathiTimer, talaTimer, dhokaBanda, dhokaKhulla, show, mathiBolau, tala, mathi, tala, dhokaOpen, dhokaClose);
        }
        private void showMsg(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            datatable.Rows.Add(currentTime, message);
            dataGridView1.Rows.Add(currentTime, message);

            db.InsertLogsIntoDB(datatable);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db.loadLogsFromDB(datatable, dataGridView1);
        }

        private void mathiBolau_Click(object sender, EventArgs e)
        {
            lift.SetState(new LiftMoveUP());
            mathiTimer.Start();
            mathiBolau.Enabled = false;
            TalaBolau.Enabled = false;
            tala.Enabled = false;
            mathi.Enabled = false;
            dhokaClose.Enabled = false;
            dhokaOpen.Enabled = false;
            showMsg("Lift is going to reach first floor!");

        }

        private void TalaBolau_Click(object sender, EventArgs e)
        {
            lift.SetState(new LiftMoveDOWN());
            talaTimer.Start();
            mathiBolau.Enabled = false;
            TalaBolau.Enabled = false;
            tala.Enabled = false;
            mathi.Enabled = false;
            dhokaClose.Enabled = false;
            dhokaOpen.Enabled = false;
        }

        private void show_Click(object sender, EventArgs e)
        {

        }

        private void mathi_Click(object sender, EventArgs e)
        {
            lift.SetState(new LiftMoveUP());
            mathiTimer.Start();
            mathiBolau.Enabled = false;
            TalaBolau.Enabled = false;
            tala.Enabled = false;
            mathi.Enabled = false;
            dhokaClose.Enabled = false;
            dhokaOpen.Enabled = false;
            showMsg("Lift is going to reach first floor!");
        }

        private void tala_Click(object sender, EventArgs e)
        {

            lift.SetState(new LiftMoveDOWN());
            talaTimer.Start();
            mathiBolau.Enabled = false;
            TalaBolau.Enabled = false;
            tala.Enabled = false;
            mathi.Enabled = false;
            dhokaClose.Enabled = false;
            dhokaOpen.Enabled = false;
        }

        private void dhokaOpen_Click(object sender, EventArgs e)
        {
            if (lift.initial == 1)
            {
                lift.SetState(new DoorOpen1());
                dhokaKhulla.Start();
                mathiBolau.Enabled = false;
                TalaBolau.Enabled = false;
                tala.Enabled = false;
                mathi.Enabled = false;
                showMsg("Door of first floor is being opened!");

            }
            else
            {
                lift.SetState(new DoorOpenG());
                dhokaKhulla.Start();

                mathiBolau.Enabled = false;
                TalaBolau.Enabled = false;
                tala.Enabled = false;
                mathi.Enabled = false;
                showMsg("Door of ground floor is being opened!");

            }
        }

        private void dhokaClose_Click(object sender, EventArgs e)
        {
            if (lift.initial == 1)
            {
                lift.SetState(new CloseDoor1());
                dhokaBanda.Start();
                mathiBolau.Enabled = false;
                TalaBolau.Enabled = false;
                tala.Enabled = false;
                mathi.Enabled = false;

                showMsg("Door of first floor is being closed!");

            }
            else
            {
                lift.SetState(new CloseDoorG());
                dhokaBanda.Start();
                mathiBolau.Enabled = false;
                TalaBolau.Enabled = false;
                tala.Enabled = false;
                mathi.Enabled = false;
                showMsg("Door of ground floor is being closed!");

            }
        }

        private void mathiTimer_Tick(object sender, EventArgs e)
        {
            lift.LiftMoveUp();        }

        private void talaTimer_Tick(object sender, EventArgs e)
        {
            lift.LiftMoveDown();
        }

    

    private void dhokaKhulla_Tick(object sender, EventArgs e)
        {
            lift.LiftOpenDoor();
        }

        private void dhokaBanda_Tick(object sender, EventArgs e)
        {
            lift.LiftCloseDoor();

        }
    }
}
