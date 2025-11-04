namespace ElevatorAssignment
{  
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doorTimer = new System.Windows.Forms.Timer(this.components);
            this.liftTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.floorStatus = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.floorCondition = new System.Windows.Forms.Label();
            this.autoDoorCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.downRightDoor = new System.Windows.Forms.PictureBox();
            this.upRightDoor = new System.Windows.Forms.PictureBox();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.firstFloorButton = new System.Windows.Forms.Button();
            this.groundFloorButton = new System.Windows.Forms.Button();
            this.doorOpenButton = new System.Windows.Forms.Button();
            this.doorCloseButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.upLeftDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.downLeftDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lift = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).BeginInit();
            this.SuspendLayout();
            // 
            // doorTimer
            // 
            this.doorTimer.Tick += new System.EventHandler(this.doorTimer_Tick);
            // 
            // liftTimer
            // 
            this.liftTimer.Tick += new System.EventHandler(this.liftTimer_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(557, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(287, 562);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clearLogsClicked);
            // 
            // floorStatus
            // 
            this.floorStatus.AutoSize = true;
            this.floorStatus.Location = new System.Drawing.Point(473, 136);
            this.floorStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.floorStatus.Name = "floorStatus";
            this.floorStatus.Size = new System.Drawing.Size(0, 13);
            this.floorStatus.TabIndex = 17;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(410, 90);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 18;
            // 
            // floorCondition
            // 
            this.floorCondition.AutoSize = true;
            this.floorCondition.BackColor = System.Drawing.Color.DarkGreen;
            this.floorCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorCondition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.floorCondition.Location = new System.Drawing.Point(430, 124);
            this.floorCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.floorCondition.Name = "floorCondition";
            this.floorCondition.Padding = new System.Windows.Forms.Padding(52, 16, 52, 16);
            this.floorCondition.Size = new System.Drawing.Size(124, 56);
            this.floorCondition.TabIndex = 19;
            this.floorCondition.Text = "0";
            // 
            // autoDoorCloseTimer
            // 
            this.autoDoorCloseTimer.Interval = 5000;
            this.autoDoorCloseTimer.Tick += new System.EventHandler(this.AutoCloseTimer_Tick);
            // 
            // downRightDoor
            // 
            this.downRightDoor.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_22_072737;
            this.downRightDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downRightDoor.Location = new System.Drawing.Point(183, 396);
            this.downRightDoor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.downRightDoor.Name = "downRightDoor";
            this.downRightDoor.Size = new System.Drawing.Size(66, 207);
            this.downRightDoor.TabIndex = 2;
            this.downRightDoor.TabStop = false;
            // 
            // upRightDoor
            // 
            this.upRightDoor.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_22_072737;
            this.upRightDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upRightDoor.Location = new System.Drawing.Point(183, 46);
            this.upRightDoor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.upRightDoor.Name = "upRightDoor";
            this.upRightDoor.Size = new System.Drawing.Size(70, 186);
            this.upRightDoor.TabIndex = 5;
            this.upRightDoor.TabStop = false;
            this.upRightDoor.Click += new System.EventHandler(this.upRightDoor_Click);
            // 
            // downButton
            // 
            this.downButton.BackgroundImage = global::ElevatorAssignment.Properties.Resources.downButton;
            this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downButton.Location = new System.Drawing.Point(274, 470);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(20, 23);
            this.downButton.TabIndex = 15;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downFloorClicked);
            // 
            // upButton
            // 
            this.upButton.BackgroundImage = global::ElevatorAssignment.Properties.Resources.upButton;
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upButton.Location = new System.Drawing.Point(294, 124);
            this.upButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(20, 23);
            this.upButton.TabIndex = 14;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.topFloorClicked);
            // 
            // firstFloorButton
            // 
            this.firstFloorButton.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_31_175645;
            this.firstFloorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstFloorButton.Location = new System.Drawing.Point(467, 188);
            this.firstFloorButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstFloorButton.Name = "firstFloorButton";
            this.firstFloorButton.Size = new System.Drawing.Size(49, 53);
            this.firstFloorButton.TabIndex = 12;
            this.firstFloorButton.UseVisualStyleBackColor = true;
            this.firstFloorButton.Click += new System.EventHandler(this.topFloorClicked);
            // 
            // groundFloorButton
            // 
            this.groundFloorButton.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_31_175626;
            this.groundFloorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundFloorButton.Location = new System.Drawing.Point(467, 254);
            this.groundFloorButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groundFloorButton.Name = "groundFloorButton";
            this.groundFloorButton.Size = new System.Drawing.Size(49, 51);
            this.groundFloorButton.TabIndex = 11;
            this.groundFloorButton.UseVisualStyleBackColor = true;
            this.groundFloorButton.Click += new System.EventHandler(this.downFloorClicked);
            // 
            // doorOpenButton
            // 
            this.doorOpenButton.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_31_175657;
            this.doorOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorOpenButton.Location = new System.Drawing.Point(497, 322);
            this.doorOpenButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.doorOpenButton.Name = "doorOpenButton";
            this.doorOpenButton.Size = new System.Drawing.Size(49, 51);
            this.doorOpenButton.TabIndex = 10;
            this.doorOpenButton.UseVisualStyleBackColor = true;
            this.doorOpenButton.Click += new System.EventHandler(this.doorOpenClicked);
            // 
            // doorCloseButton
            // 
            this.doorCloseButton.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_31_175718;
            this.doorCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorCloseButton.Location = new System.Drawing.Point(439, 322);
            this.doorCloseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.doorCloseButton.Name = "doorCloseButton";
            this.doorCloseButton.Size = new System.Drawing.Size(49, 51);
            this.doorCloseButton.TabIndex = 9;
            this.doorCloseButton.UseVisualStyleBackColor = true;
            this.doorCloseButton.Click += new System.EventHandler(this.doorCloseClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_31_175341;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(431, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 253);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // upLeftDoor
            // 
            this.upLeftDoor.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_22_072737;
            this.upLeftDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upLeftDoor.Location = new System.Drawing.Point(116, 46);
            this.upLeftDoor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.upLeftDoor.Name = "upLeftDoor";
            this.upLeftDoor.Size = new System.Drawing.Size(70, 186);
            this.upLeftDoor.TabIndex = 6;
            this.upLeftDoor.TabStop = false;
            this.upLeftDoor.Click += new System.EventHandler(this.upLeftDoor_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(54, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(271, 261);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // downLeftDoor
            // 
            this.downLeftDoor.BackgroundImage = global::ElevatorAssignment.Properties.Resources.Screenshot_2024_10_22_072737;
            this.downLeftDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downLeftDoor.Location = new System.Drawing.Point(111, 396);
            this.downLeftDoor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.downLeftDoor.Name = "downLeftDoor";
            this.downLeftDoor.Size = new System.Drawing.Size(75, 207);
            this.downLeftDoor.TabIndex = 3;
            this.downLeftDoor.TabStop = false;
            this.downLeftDoor.Click += new System.EventHandler(this.downLeftDoor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(54, 334);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 293);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lift
            // 
            this.lift.BackgroundImage = global::ElevatorAssignment.Properties.Resources.lift_inside;
            this.lift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lift.Location = new System.Drawing.Point(116, 400);
            this.lift.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(128, 203);
            this.lift.TabIndex = 1;
            this.lift.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 615);
            this.Controls.Add(this.floorCondition);
            this.Controls.Add(this.status);
            this.Controls.Add(this.floorStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downRightDoor);
            this.Controls.Add(this.upRightDoor);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.firstFloorButton);
            this.Controls.Add(this.groundFloorButton);
            this.Controls.Add(this.doorOpenButton);
            this.Controls.Add(this.doorCloseButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.upLeftDoor);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.downLeftDoor);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lift;
        private System.Windows.Forms.PictureBox downRightDoor;
        private System.Windows.Forms.PictureBox downLeftDoor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox upRightDoor;
        private System.Windows.Forms.PictureBox upLeftDoor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer doorTimer;
        private System.Windows.Forms.Timer liftTimer;
        private System.Windows.Forms.Button doorCloseButton;
        private System.Windows.Forms.Button doorOpenButton;
        private System.Windows.Forms.Button groundFloorButton;
        private System.Windows.Forms.Button firstFloorButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label floorStatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label floorCondition;
        private System.Windows.Forms.Timer autoDoorCloseTimer;
    }
}

