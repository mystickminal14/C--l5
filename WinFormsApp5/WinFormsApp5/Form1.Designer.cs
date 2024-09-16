namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            firstName = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            SignUp = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            fbox = new TextBox();
            dOb = new Label();
            dateTimePicker1 = new DateTimePicker();
            age = new Label();
            agebox = new TextBox();
            username = new Label();
            userBox = new TextBox();
            pw = new Label();
            pass = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName.Location = new Point(425, 107);
            firstName.Name = "firstName";
            firstName.Size = new Size(95, 28);
            firstName.TabIndex = 1;
            firstName.Text = "FullName";
            firstName.Click += label2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "a-logo-with-the-name-minal-in-a-stylish-modern-fon-BGsu3jHIRxiNjTrQssRaLA-msEs7hVLSpKpZ1VCG87kPA-removebg-preview.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.DarkGray;
            // 
            // SignUp
            // 
            SignUp.Cursor = Cursors.No;
            SignUp.Font = new Font("Showcard Gothic", 20F);
            SignUp.Location = new Point(498, 45);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(200, 60);
            SignUp.TabIndex = 2;
            SignUp.Text = "SIGN-UP";
            SignUp.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(-5, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 385);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // fbox
            // 
            fbox.BorderStyle = BorderStyle.FixedSingle;
            fbox.Location = new Point(546, 108);
            fbox.Name = "fbox";
            fbox.PlaceholderText = "fullname";
            fbox.Size = new Size(208, 27);
            fbox.TabIndex = 4;
            fbox.TextAlign = HorizontalAlignment.Center;
            // 
            // dOb
            // 
            dOb.AutoSize = true;
            dOb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dOb.Location = new Point(425, 158);
            dOb.Name = "dOb";
            dOb.Size = new Size(97, 28);
            dOb.TabIndex = 5;
            dOb.Text = "Birth date";
            dOb.Click += label1_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(546, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            age.Location = new Point(446, 206);
            age.Name = "age";
            age.Size = new Size(47, 28);
            age.TabIndex = 7;
            age.Text = "Age";
            age.Click += label1_Click_2;
            // 
            // agebox
            // 
            agebox.BorderStyle = BorderStyle.FixedSingle;
            agebox.Location = new Point(546, 211);
            agebox.Name = "agebox";
            agebox.PlaceholderText = "age";
            agebox.Size = new Size(208, 27);
            agebox.TabIndex = 8;
            agebox.TextAlign = HorizontalAlignment.Center;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(427, 259);
            username.Name = "username";
            username.Size = new Size(99, 28);
            username.TabIndex = 9;
            username.Text = "Username";
            username.Click += label1_Click_3;
            // 
            // userBox
            // 
            userBox.BorderStyle = BorderStyle.FixedSingle;
            userBox.Location = new Point(546, 260);
            userBox.Name = "userBox";
            userBox.PlaceholderText = "username";
            userBox.Size = new Size(208, 27);
            userBox.TabIndex = 10;
            userBox.TextAlign = HorizontalAlignment.Center;
            // 
            // pw
            // 
            pw.AutoSize = true;
            pw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pw.Location = new Point(427, 303);
            pw.Name = "pw";
            pw.Size = new Size(93, 28);
            pw.TabIndex = 11;
            pw.Text = "Password";
            pw.Click += label1_Click_4;
            // 
            // pass
            // 
            pass.BorderStyle = BorderStyle.FixedSingle;
            pass.Location = new Point(546, 308);
            pass.Name = "pass";
            pass.PlaceholderText = "Password";
            pass.Size = new Size(208, 27);
            pass.TabIndex = 12;
            pass.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(427, 356);
            button1.Name = "button1";
            button1.Size = new Size(327, 43);
            button1.TabIndex = 13;
            button1.Text = "R E G I S T E R";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pass);
            Controls.Add(pw);
            Controls.Add(userBox);
            Controls.Add(username);
            Controls.Add(agebox);
            Controls.Add(age);
            Controls.Add(dateTimePicker1);
            Controls.Add(dOb);
            Controls.Add(fbox);
            Controls.Add(pictureBox1);
            Controls.Add(SignUp);
            Controls.Add(firstName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstName;
        private ImageList imageList1;
        private ImageList imageList2;
        private Label SignUp;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private TextBox fbox;
        private Label dOb;
        private DateTimePicker dateTimePicker1;
        private Label age;
        private TextBox agebox;
        private Label username;
        private TextBox userBox;
        private Label pw;
        private TextBox pass;
        private Button button1;
    }
}
