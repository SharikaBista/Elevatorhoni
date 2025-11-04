using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ElevatorAssignment.Controllers;
using ElevatorAssignment.States;

namespace ElevatorAssignment
{
    public partial class Form1 : Form
    {
        private readonly int liftSpeed = 5;
        private readonly int doorSpeed = 5;
        private readonly int doorMaxOpenWidth;
        private readonly ElevatorContext elevatorContext;
        private readonly DataTable dt = new DataTable();
        private readonly DBcontext DBcontext = new DBcontext();

        public Form1()
        {
            InitializeComponent();

            doorMaxOpenWidth = lift.Width / 2 - 10;
            elevatorContext = new ElevatorContext(this);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            UpdateLiftStatus("0"); 

            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[1].Name = "Events";

            dt.Columns.Add("Time");
            dt.Columns.Add("Events");
        }

        // Methods called by states
        public void StartMovingUp()
        {
            firstFloorButton.BackColor = Color.Green;
            liftTimer.Start();
            UpdateLiftStatus("1");
            LogEvents("Moving to Top floor");
        }

        public void StartMovingDown()
        {
            groundFloorButton.BackColor = Color.Green;
            liftTimer.Start();
            UpdateLiftStatus("0");
            LogEvents("Moving to Down floor");
        }

        public void StopMoving()
        {
            liftTimer.Stop();
            groundFloorButton.BackColor = SystemColors.Control;
            firstFloorButton.BackColor = SystemColors.Control;
        }

        public void StartOpeningDoor()
        {
            doorTimer.Start();
            groundFloorButton.Enabled = false;
            firstFloorButton.Enabled= false;
            upButton.Enabled= false;
            downButton.Enabled= false;
            autoDoorCloseTimer.Start();
            LogEvents("Opening doors");
        }

        public void StartClosingDoor()
        {
            doorTimer.Start();
            groundFloorButton.Enabled = true;
            firstFloorButton.Enabled = true;
            upButton.Enabled = true;
            downButton.Enabled = true;
            autoDoorCloseTimer.Stop();
            LogEvents("Closing doors");
        }

        public void StopDoorMovement()
        {
            doorTimer.Stop();
            doorOpenButton.Enabled = true;
            doorCloseButton.Enabled = true;
        }

        private void LogEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            dt.Rows.Add(currentTime, message);
            dataGridView1.Rows.Add(currentTime, message);
            DBcontext.InsertLogs(dt);
        }

        // Event handlers
        private void downFloorClicked(object sender, EventArgs e)
        {
            elevatorContext.MoveDown();
        }

        private void topFloorClicked(object sender, EventArgs e)
        {
            elevatorContext.MoveUp();
        }

        private void doorOpenClicked(object sender, EventArgs e)
        {
            elevatorContext.OpenDoor();
        }

        private void doorCloseClicked(object sender, EventArgs e)
        {
            elevatorContext.CloseDoor();
        }

        private void liftTimer_Tick(object sender, EventArgs e)
        {
            if (elevatorContext.CurrentState is MovingUpState)
            {
                if (lift.Top > 0)
                {
                    doorOpenButton.Enabled = false;
                    lift.Top -= liftSpeed;
                }
                else
                {
                    lift.Top = 0;
                    elevatorContext.Stop();
                    elevatorContext.OpenDoor();
                    doorOpenButton.Enabled = true;
                }
            }
            else if (elevatorContext.CurrentState is MovingDownState)
            {
                if (lift.Bottom < ClientSize.Height)
                {
                    doorOpenButton.Enabled = false;
                    lift.Top += liftSpeed;
                }
                else
                {
                    lift.Top = ClientSize.Height - lift.Height;
                    elevatorContext.Stop();
                    elevatorContext.OpenDoor();
                    doorOpenButton.Enabled = true;
                }
            }
        }

        private void doorTimer_Tick(object sender, EventArgs e)
        {
            bool isAtTopFloor = lift.Top == 0;

            if (elevatorContext.CurrentState is DoorOpeningState)
            {
                HandleDoorOpening(isAtTopFloor);
            }
            else if (elevatorContext.CurrentState is DoorClosingState)
            {
                HandleDoorClosing(isAtTopFloor);
            }
        }

        private void HandleDoorOpening(bool isAtTopFloor)
        {
            var leftDoor = isAtTopFloor ? upLeftDoor : downLeftDoor;
            var rightDoor = isAtTopFloor ? upRightDoor : downRightDoor;

            if (leftDoor.Left > lift.Width - doorMaxOpenWidth)
            {
                leftDoor.Left -= doorSpeed;
                rightDoor.Left += doorSpeed;
            }
            else
            {
                elevatorContext.Stop();
                doorCloseButton.Enabled = true;
            }
        }

        private void HandleDoorClosing(bool isAtTopFloor)
        {
            var leftDoor = isAtTopFloor ? upLeftDoor : downLeftDoor;
            var rightDoor = isAtTopFloor ? upRightDoor : downRightDoor;

            if (leftDoor.Right < lift.Width + doorMaxOpenWidth / 2+30)
            {
                leftDoor.Left += doorSpeed;
                rightDoor.Left -= doorSpeed;
            }
            else
            {
                elevatorContext.Stop();
                doorOpenButton.Enabled = true;
            }
        }


        private void clearLogsClicked(object sender, EventArgs e)
        {
            DBcontext.TruncateLogs(dt, dataGridView1);

        }
        private void UpdateLiftStatus(string status)
        {
            floorCondition.Text = status;
        }
        private void AutoCloseTimer_Tick(object sender, EventArgs e)
        {
            elevatorContext.CloseDoor();
            autoDoorCloseTimer.Stop();
        }

        private void downLeftDoor_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void upLeftDoor_Click(object sender, EventArgs e)
        {

        }

        private void upRightDoor_Click(object sender, EventArgs e)
        {

        }
    }
}
