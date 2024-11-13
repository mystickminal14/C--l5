namespace SparshaElevator
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
            this.elevatorBase = new System.Windows.Forms.PictureBox();
            this.ask1 = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Timer(this.components);
            this.lG = new System.Windows.Forms.PictureBox();
            this.rG = new System.Windows.Forms.PictureBox();
            this.r1 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.PictureBox();
            this.askg = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.upBu = new System.Windows.Forms.Button();
            this.downBu = new System.Windows.Forms.Button();
            this.banda = new System.Windows.Forms.Button();
            this.khulla = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Timer(this.components);
            this.up = new System.Windows.Forms.Timer(this.components);
            this.down = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // elevatorBase
            // 
            this.elevatorBase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elevatorBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elevatorBase.Location = new System.Drawing.Point(126, 369);
            this.elevatorBase.Name = "elevatorBase";
            this.elevatorBase.Size = new System.Drawing.Size(184, 259);
            this.elevatorBase.TabIndex = 0;
            this.elevatorBase.TabStop = false;
            // 
            // ask1
            // 
            this.ask1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ask1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ask1.Location = new System.Drawing.Point(334, 139);
            this.ask1.Name = "ask1";
            this.ask1.Size = new System.Drawing.Size(40, 40);
            this.ask1.TabIndex = 1;
            this.ask1.UseVisualStyleBackColor = false;
            this.ask1.Click += new System.EventHandler(this.ask1_Click);
            // 
            // open
            // 
            this.open.Tick += new System.EventHandler(this.open_Tick);
            // 
            // lG
            // 
            this.lG.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lG.Location = new System.Drawing.Point(126, 369);
            this.lG.Name = "lG";
            this.lG.Size = new System.Drawing.Size(92, 259);
            this.lG.TabIndex = 2;
            this.lG.TabStop = false;
            // 
            // rG
            // 
            this.rG.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rG.Location = new System.Drawing.Point(218, 369);
            this.rG.Name = "rG";
            this.rG.Size = new System.Drawing.Size(92, 259);
            this.rG.TabIndex = 3;
            this.rG.TabStop = false;
            // 
            // r1
            // 
            this.r1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.r1.Location = new System.Drawing.Point(218, 30);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(92, 259);
            this.r1.TabIndex = 4;
            this.r1.TabStop = false;
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.L1.Location = new System.Drawing.Point(126, 30);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(92, 259);
            this.L1.TabIndex = 5;
            this.L1.TabStop = false;
            // 
            // askg
            // 
            this.askg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.askg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.askg.Location = new System.Drawing.Point(334, 489);
            this.askg.Name = "askg";
            this.askg.Size = new System.Drawing.Size(40, 40);
            this.askg.TabIndex = 6;
            this.askg.UseVisualStyleBackColor = false;
            this.askg.Click += new System.EventHandler(this.askg_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show.Location = new System.Drawing.Point(438, 212);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(184, 59);
            this.show.TabIndex = 7;
            this.show.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(427, 195);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(207, 241);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // upBu
            // 
            this.upBu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upBu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upBu.Location = new System.Drawing.Point(470, 292);
            this.upBu.Name = "upBu";
            this.upBu.Size = new System.Drawing.Size(56, 55);
            this.upBu.TabIndex = 9;
            this.upBu.UseVisualStyleBackColor = false;
            this.upBu.Click += new System.EventHandler(this.upBu_Click);
            // 
            // downBu
            // 
            this.downBu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.downBu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downBu.Location = new System.Drawing.Point(532, 292);
            this.downBu.Name = "downBu";
            this.downBu.Size = new System.Drawing.Size(56, 55);
            this.downBu.TabIndex = 10;
            this.downBu.UseVisualStyleBackColor = false;
            this.downBu.Click += new System.EventHandler(this.downBu_Click);
            // 
            // banda
            // 
            this.banda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.banda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.banda.Location = new System.Drawing.Point(532, 369);
            this.banda.Name = "banda";
            this.banda.Size = new System.Drawing.Size(56, 55);
            this.banda.TabIndex = 11;
            this.banda.Text = "banda";
            this.banda.UseVisualStyleBackColor = false;
            this.banda.Click += new System.EventHandler(this.banda_Click);
            // 
            // khulla
            // 
            this.khulla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.khulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.khulla.Location = new System.Drawing.Point(470, 369);
            this.khulla.Name = "khulla";
            this.khulla.Size = new System.Drawing.Size(56, 55);
            this.khulla.TabIndex = 12;
            this.khulla.Text = "khulla";
            this.khulla.UseVisualStyleBackColor = false;
            this.khulla.Click += new System.EventHandler(this.khulla_Click);
            // 
            // close
            // 
            this.close.Tick += new System.EventHandler(this.close_Tick);
            // 
            // up
            // 
            this.up.Tick += new System.EventHandler(this.up_Tick);
            // 
            // down
            // 
            this.down.Tick += new System.EventHandler(this.down_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(691, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 567);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rG);
            this.Controls.Add(this.khulla);
            this.Controls.Add(this.banda);
            this.Controls.Add(this.downBu);
            this.Controls.Add(this.upBu);
            this.Controls.Add(this.show);
            this.Controls.Add(this.askg);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.lG);
            this.Controls.Add(this.ask1);
            this.Controls.Add(this.elevatorBase);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elevatorBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox elevatorBase;
        private System.Windows.Forms.Button ask1;
        private System.Windows.Forms.Timer open;
        private System.Windows.Forms.PictureBox lG;
        private System.Windows.Forms.PictureBox rG;
        private System.Windows.Forms.PictureBox r1;
        private System.Windows.Forms.PictureBox L1;
        private System.Windows.Forms.Button askg;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button upBu;
        private System.Windows.Forms.Button downBu;
        private System.Windows.Forms.Button banda;
        private System.Windows.Forms.Button khulla;
        private System.Windows.Forms.Timer close;
        private System.Windows.Forms.Timer up;
        private System.Windows.Forms.Timer down;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

