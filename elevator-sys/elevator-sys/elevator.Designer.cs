namespace elevator_sys
{
    partial class elevator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elevator));
            this.liftCar = new System.Windows.Forms.PictureBox();
            this.bottomLeftDoor = new System.Windows.Forms.PictureBox();
            this.bottomRightDoor = new System.Windows.Forms.PictureBox();
            this.topLeftDoor = new System.Windows.Forms.PictureBox();
            this.topRightDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reqUp = new System.Windows.Forms.Button();
            this.reqDown = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.display1 = new System.Windows.Forms.Button();
            this.display2 = new System.Windows.Forms.Button();
            this.reqButton2 = new System.Windows.Forms.Button();
            this.reqButton1 = new System.Windows.Forms.Button();
            this.reqOpen = new System.Windows.Forms.Button();
            this.reqClose = new System.Windows.Forms.Button();
            this.openTimer = new System.Windows.Forms.Timer(this.components);
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.movingUpTimer = new System.Windows.Forms.Timer(this.components);
            this.movingDownTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liftCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // liftCar
            // 
            this.liftCar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.liftCar.Location = new System.Drawing.Point(228, 425);
            this.liftCar.Name = "liftCar";
            this.liftCar.Size = new System.Drawing.Size(187, 236);
            this.liftCar.TabIndex = 0;
            this.liftCar.TabStop = false;
            // 
            // bottomLeftDoor
            // 
            this.bottomLeftDoor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottomLeftDoor.Location = new System.Drawing.Point(228, 425);
            this.bottomLeftDoor.Name = "bottomLeftDoor";
            this.bottomLeftDoor.Size = new System.Drawing.Size(97, 236);
            this.bottomLeftDoor.TabIndex = 1;
            this.bottomLeftDoor.TabStop = false;
            // 
            // bottomRightDoor
            // 
            this.bottomRightDoor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottomRightDoor.Location = new System.Drawing.Point(323, 425);
            this.bottomRightDoor.Name = "bottomRightDoor";
            this.bottomRightDoor.Size = new System.Drawing.Size(92, 236);
            this.bottomRightDoor.TabIndex = 2;
            this.bottomRightDoor.TabStop = false;
            // 
            // topLeftDoor
            // 
            this.topLeftDoor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topLeftDoor.Location = new System.Drawing.Point(228, 57);
            this.topLeftDoor.Name = "topLeftDoor";
            this.topLeftDoor.Size = new System.Drawing.Size(97, 236);
            this.topLeftDoor.TabIndex = 3;
            this.topLeftDoor.TabStop = false;
            // 
            // topRightDoor
            // 
            this.topRightDoor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topRightDoor.Location = new System.Drawing.Point(323, 57);
            this.topRightDoor.Name = "topRightDoor";
            this.topRightDoor.Size = new System.Drawing.Size(92, 236);
            this.topRightDoor.TabIndex = 4;
            this.topRightDoor.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(105, 325);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(422, 51);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(438, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 211);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // reqUp
            // 
            this.reqUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reqUp.BackgroundImage")));
            this.reqUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reqUp.Location = new System.Drawing.Point(438, 163);
            this.reqUp.Name = "reqUp";
            this.reqUp.Size = new System.Drawing.Size(42, 37);
            this.reqUp.TabIndex = 7;
            this.reqUp.UseVisualStyleBackColor = true;
            this.reqUp.Click += new System.EventHandler(this.reqUp_Click);
            // 
            // reqDown
            // 
            this.reqDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reqDown.BackgroundImage")));
            this.reqDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reqDown.Location = new System.Drawing.Point(438, 483);
            this.reqDown.Name = "reqDown";
            this.reqDown.Size = new System.Drawing.Size(42, 37);
            this.reqDown.TabIndex = 8;
            this.reqDown.UseVisualStyleBackColor = true;
            this.reqDown.Click += new System.EventHandler(this.reqDown_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.display.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.display.Location = new System.Drawing.Point(489, 250);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(80, 37);
            this.display.TabIndex = 9;
            this.display.Text = "G";
            this.display.UseVisualStyleBackColor = false;
            // 
            // display1
            // 
            this.display1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.display1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.display1.Location = new System.Drawing.Point(281, 14);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(80, 37);
            this.display1.TabIndex = 10;
            this.display1.Text = "G";
            this.display1.UseVisualStyleBackColor = false;
            // 
            // display2
            // 
            this.display2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.display2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.display2.Location = new System.Drawing.Point(281, 382);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(80, 37);
            this.display2.TabIndex = 11;
            this.display2.Text = "G";
            this.display2.UseVisualStyleBackColor = false;
            // 
            // reqButton2
            // 
            this.reqButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reqButton2.BackgroundImage")));
            this.reqButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reqButton2.Location = new System.Drawing.Point(541, 382);
            this.reqButton2.Name = "reqButton2";
            this.reqButton2.Size = new System.Drawing.Size(42, 37);
            this.reqButton2.TabIndex = 12;
            this.reqButton2.UseVisualStyleBackColor = true;
            this.reqButton2.Click += new System.EventHandler(this.reqButton2_Click);
            // 
            // reqButton1
            // 
            this.reqButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reqButton1.BackgroundImage")));
            this.reqButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reqButton1.Location = new System.Drawing.Point(476, 382);
            this.reqButton1.Name = "reqButton1";
            this.reqButton1.Size = new System.Drawing.Size(42, 37);
            this.reqButton1.TabIndex = 13;
            this.reqButton1.UseVisualStyleBackColor = true;
            this.reqButton1.Click += new System.EventHandler(this.reqButton1_Click);
            // 
            // reqOpen
            // 
            this.reqOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reqOpen.BackgroundImage")));
            this.reqOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reqOpen.Location = new System.Drawing.Point(507, 293);
            this.reqOpen.Name = "reqOpen";
            this.reqOpen.Size = new System.Drawing.Size(42, 37);
            this.reqOpen.TabIndex = 14;
            this.reqOpen.UseVisualStyleBackColor = true;
            this.reqOpen.Click += new System.EventHandler(this.reqOpen_Click);
            // 
            // reqClose
            // 
            this.reqClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reqClose.BackgroundImage")));
            this.reqClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reqClose.Location = new System.Drawing.Point(507, 336);
            this.reqClose.Name = "reqClose";
            this.reqClose.Size = new System.Drawing.Size(42, 37);
            this.reqClose.TabIndex = 15;
            this.reqClose.UseVisualStyleBackColor = true;
            this.reqClose.Click += new System.EventHandler(this.reqClose_Click);
            // 
            // openTimer
            // 
            this.openTimer.Tick += new System.EventHandler(this.openTimer_Tick);
            // 
            // closeTimer
            // 
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // movingUpTimer
            // 
            this.movingUpTimer.Tick += new System.EventHandler(this.movingUpTimer_Tick);
            // 
            // movingDownTimer
            // 
            this.movingDownTimer.Tick += new System.EventHandler(this.movingDownTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 685);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(424, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(229, 685);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(671, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 621);
            this.dataGridView1.TabIndex = 18;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(967, 639);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(97, 32);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 683);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reqClose);
            this.Controls.Add(this.reqOpen);
            this.Controls.Add(this.reqButton1);
            this.Controls.Add(this.reqButton2);
            this.Controls.Add(this.display);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.reqDown);
            this.Controls.Add(this.reqUp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.topRightDoor);
            this.Controls.Add(this.topLeftDoor);
            this.Controls.Add(this.bottomRightDoor);
            this.Controls.Add(this.bottomLeftDoor);
            this.Controls.Add(this.liftCar);
            this.Name = "elevator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.elevator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liftCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox liftCar;
        private System.Windows.Forms.PictureBox bottomLeftDoor;
        private System.Windows.Forms.PictureBox bottomRightDoor;
        private System.Windows.Forms.PictureBox topLeftDoor;
        private System.Windows.Forms.PictureBox topRightDoor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button reqUp;
        private System.Windows.Forms.Button reqDown;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button display1;
        private System.Windows.Forms.Button display2;
        private System.Windows.Forms.Button reqButton2;
        private System.Windows.Forms.Button reqButton1;
        private System.Windows.Forms.Button reqOpen;
        private System.Windows.Forms.Button reqClose;
        private System.Windows.Forms.Timer openTimer;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Timer movingUpTimer;
        private System.Windows.Forms.Timer movingDownTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Clear;
    }
}

