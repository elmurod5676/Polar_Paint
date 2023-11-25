
namespace MusorPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canvas = new System.Windows.Forms.Panel();
            this.mColorsPanel = new System.Windows.Forms.Panel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.cyanBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.pinkBox = new System.Windows.Forms.PictureBox();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.moreColors = new System.Windows.Forms.Button();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.morePen = new System.Windows.Forms.Button();
            this.PensPanel = new System.Windows.Forms.Panel();
            this.morePenoff = new System.Windows.Forms.Button();
            this.Pen14 = new System.Windows.Forms.Button();
            this.Pen12 = new System.Windows.Forms.Button();
            this.Pen10 = new System.Windows.Forms.Button();
            this.Pen8 = new System.Windows.Forms.Button();
            this.Pen6 = new System.Windows.Forms.Button();
            this.Pen4 = new System.Windows.Forms.Button();
            this.Pen2 = new System.Windows.Forms.Button();
            this.canvas.SuspendLayout();
            this.mColorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.PensPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.Controls.Add(this.mColorsPanel);
            this.canvas.Location = new System.Drawing.Point(51, 54);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1423, 637);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // mColorsPanel
            // 
            this.mColorsPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mColorsPanel.Controls.Add(this.pictureBox15);
            this.mColorsPanel.Controls.Add(this.pictureBox14);
            this.mColorsPanel.Controls.Add(this.pictureBox13);
            this.mColorsPanel.Controls.Add(this.button1);
            this.mColorsPanel.Controls.Add(this.pictureBox12);
            this.mColorsPanel.Controls.Add(this.pictureBox11);
            this.mColorsPanel.Controls.Add(this.pictureBox10);
            this.mColorsPanel.Controls.Add(this.pictureBox9);
            this.mColorsPanel.Controls.Add(this.pictureBox8);
            this.mColorsPanel.Controls.Add(this.pictureBox7);
            this.mColorsPanel.Controls.Add(this.pictureBox6);
            this.mColorsPanel.Controls.Add(this.pictureBox5);
            this.mColorsPanel.Controls.Add(this.pictureBox4);
            this.mColorsPanel.Controls.Add(this.pictureBox3);
            this.mColorsPanel.Controls.Add(this.pictureBox2);
            this.mColorsPanel.Controls.Add(this.pictureBox1);
            this.mColorsPanel.Location = new System.Drawing.Point(21, 134);
            this.mColorsPanel.Name = "mColorsPanel";
            this.mColorsPanel.Size = new System.Drawing.Size(143, 290);
            this.mColorsPanel.TabIndex = 0;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox15.Location = new System.Drawing.Point(97, 144);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(41, 42);
            this.pictureBox15.TabIndex = 17;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Purple;
            this.pictureBox14.Location = new System.Drawing.Point(97, 99);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(41, 42);
            this.pictureBox14.TabIndex = 16;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Navy;
            this.pictureBox13.Location = new System.Drawing.Point(97, 51);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(41, 42);
            this.pictureBox13.TabIndex = 15;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(97, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox12.Location = new System.Drawing.Point(50, 240);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(41, 42);
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox11.Location = new System.Drawing.Point(50, 192);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(41, 42);
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox10.Location = new System.Drawing.Point(50, 144);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 42);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox9.Location = new System.Drawing.Point(50, 99);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 42);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox8.Location = new System.Drawing.Point(50, 51);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 42);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox7.Location = new System.Drawing.Point(50, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 42);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox6.Location = new System.Drawing.Point(3, 238);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 42);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox5.Location = new System.Drawing.Point(3, 192);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 42);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox4.Location = new System.Drawing.Point(3, 144);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 42);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox3.Location = new System.Drawing.Point(3, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 42);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox2.Location = new System.Drawing.Point(3, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 42);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(1365, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 45);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cyanBox
            // 
            this.cyanBox.BackColor = System.Drawing.Color.Aqua;
            this.cyanBox.Location = new System.Drawing.Point(4, 246);
            this.cyanBox.Name = "cyanBox";
            this.cyanBox.Size = new System.Drawing.Size(41, 42);
            this.cyanBox.TabIndex = 8;
            this.cyanBox.TabStop = false;
            this.cyanBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Location = new System.Drawing.Point(4, 294);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(41, 42);
            this.blueBox.TabIndex = 7;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pinkBox
            // 
            this.pinkBox.BackColor = System.Drawing.Color.Fuchsia;
            this.pinkBox.Location = new System.Drawing.Point(4, 342);
            this.pinkBox.Name = "pinkBox";
            this.pinkBox.Size = new System.Drawing.Size(41, 42);
            this.pinkBox.TabIndex = 6;
            this.pinkBox.TabStop = false;
            this.pinkBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blackBox
            // 
            this.blackBox.BackColor = System.Drawing.Color.Black;
            this.blackBox.Location = new System.Drawing.Point(4, 390);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(41, 42);
            this.blackBox.TabIndex = 5;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Lime;
            this.greenBox.Location = new System.Drawing.Point(4, 198);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(41, 42);
            this.greenBox.TabIndex = 4;
            this.greenBox.TabStop = false;
            this.greenBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // yellowBox
            // 
            this.yellowBox.BackColor = System.Drawing.Color.Yellow;
            this.yellowBox.Location = new System.Drawing.Point(4, 150);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(41, 42);
            this.yellowBox.TabIndex = 3;
            this.yellowBox.TabStop = false;
            this.yellowBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeBox.Location = new System.Drawing.Point(4, 102);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(41, 42);
            this.orangeBox.TabIndex = 2;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(4, 54);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(41, 42);
            this.redBox.TabIndex = 1;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // moreColors
            // 
            this.moreColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreColors.Location = new System.Drawing.Point(3, 438);
            this.moreColors.Name = "moreColors";
            this.moreColors.Size = new System.Drawing.Size(42, 40);
            this.moreColors.TabIndex = 0;
            this.moreColors.Text = ">";
            this.moreColors.UseVisualStyleBackColor = true;
            this.moreColors.Click += new System.EventHandler(this.moreColors_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.White;
            this.pictureBox16.Location = new System.Drawing.Point(1254, 5);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(47, 46);
            this.pictureBox16.TabIndex = 9;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(1315, 2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(40, 49);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 10;
            this.pictureBox17.TabStop = false;
            // 
            // morePen
            // 
            this.morePen.Location = new System.Drawing.Point(4, 7);
            this.morePen.Name = "morePen";
            this.morePen.Size = new System.Drawing.Size(59, 38);
            this.morePen.TabIndex = 11;
            this.morePen.Text = "PEN";
            this.morePen.UseVisualStyleBackColor = true;
            this.morePen.Click += new System.EventHandler(this.morePen_Click);
            // 
            // PensPanel
            // 
            this.PensPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PensPanel.Controls.Add(this.morePenoff);
            this.PensPanel.Controls.Add(this.Pen14);
            this.PensPanel.Controls.Add(this.Pen12);
            this.PensPanel.Controls.Add(this.Pen10);
            this.PensPanel.Controls.Add(this.Pen8);
            this.PensPanel.Controls.Add(this.Pen6);
            this.PensPanel.Controls.Add(this.Pen4);
            this.PensPanel.Controls.Add(this.Pen2);
            this.PensPanel.Location = new System.Drawing.Point(69, 7);
            this.PensPanel.Name = "PensPanel";
            this.PensPanel.Size = new System.Drawing.Size(339, 38);
            this.PensPanel.TabIndex = 12;
            // 
            // morePenoff
            // 
            this.morePenoff.BackColor = System.Drawing.Color.Gray;
            this.morePenoff.Location = new System.Drawing.Point(294, 2);
            this.morePenoff.Name = "morePenoff";
            this.morePenoff.Size = new System.Drawing.Size(41, 35);
            this.morePenoff.TabIndex = 19;
            this.morePenoff.Text = "<";
            this.morePenoff.UseVisualStyleBackColor = false;
            this.morePenoff.Click += new System.EventHandler(this.morePenoff_Click);
            // 
            // Pen14
            // 
            this.Pen14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pen14.Location = new System.Drawing.Point(253, 2);
            this.Pen14.Name = "Pen14";
            this.Pen14.Size = new System.Drawing.Size(41, 35);
            this.Pen14.TabIndex = 18;
            this.Pen14.Text = "14";
            this.Pen14.UseVisualStyleBackColor = false;
            this.Pen14.Click += new System.EventHandler(this.Pen14_Click);
            // 
            // Pen12
            // 
            this.Pen12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pen12.Location = new System.Drawing.Point(212, 2);
            this.Pen12.Name = "Pen12";
            this.Pen12.Size = new System.Drawing.Size(41, 35);
            this.Pen12.TabIndex = 17;
            this.Pen12.Text = "12";
            this.Pen12.UseVisualStyleBackColor = false;
            this.Pen12.Click += new System.EventHandler(this.Pen12_Click);
            // 
            // Pen10
            // 
            this.Pen10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pen10.Location = new System.Drawing.Point(172, 2);
            this.Pen10.Name = "Pen10";
            this.Pen10.Size = new System.Drawing.Size(41, 35);
            this.Pen10.TabIndex = 16;
            this.Pen10.Text = "10";
            this.Pen10.UseVisualStyleBackColor = false;
            this.Pen10.Click += new System.EventHandler(this.Pen10_Click);
            // 
            // Pen8
            // 
            this.Pen8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pen8.Location = new System.Drawing.Point(130, 2);
            this.Pen8.Name = "Pen8";
            this.Pen8.Size = new System.Drawing.Size(41, 35);
            this.Pen8.TabIndex = 15;
            this.Pen8.Text = "8";
            this.Pen8.UseVisualStyleBackColor = false;
            this.Pen8.Click += new System.EventHandler(this.Pen8_Click);
            // 
            // Pen6
            // 
            this.Pen6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pen6.Location = new System.Drawing.Point(88, 2);
            this.Pen6.Name = "Pen6";
            this.Pen6.Size = new System.Drawing.Size(41, 35);
            this.Pen6.TabIndex = 14;
            this.Pen6.Text = "6";
            this.Pen6.UseVisualStyleBackColor = false;
            this.Pen6.Click += new System.EventHandler(this.Pen6_Click);
            // 
            // Pen4
            // 
            this.Pen4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pen4.Location = new System.Drawing.Point(46, 2);
            this.Pen4.Name = "Pen4";
            this.Pen4.Size = new System.Drawing.Size(41, 35);
            this.Pen4.TabIndex = 13;
            this.Pen4.Text = "4";
            this.Pen4.UseVisualStyleBackColor = false;
            this.Pen4.Click += new System.EventHandler(this.Pen4_Click);
            // 
            // Pen2
            // 
            this.Pen2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pen2.Location = new System.Drawing.Point(3, 2);
            this.Pen2.Name = "Pen2";
            this.Pen2.Size = new System.Drawing.Size(41, 35);
            this.Pen2.TabIndex = 12;
            this.Pen2.Text = "2";
            this.Pen2.UseVisualStyleBackColor = false;
            this.Pen2.Click += new System.EventHandler(this.Pen2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1474, 691);
            this.Controls.Add(this.PensPanel);
            this.Controls.Add(this.morePen);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.moreColors);
            this.Controls.Add(this.blackBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.pinkBox);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.cyanBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.yellowBox);
            this.Controls.Add(this.orangeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MusorPaint";
            this.canvas.ResumeLayout(false);
            this.mColorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.PensPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.PictureBox cyanBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.PictureBox pinkBox;
        private System.Windows.Forms.PictureBox blackBox;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.PictureBox yellowBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel mColorsPanel;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button moreColors;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Button morePen;
        private System.Windows.Forms.Panel PensPanel;
        private System.Windows.Forms.Button Pen2;
        private System.Windows.Forms.Button Pen14;
        private System.Windows.Forms.Button Pen12;
        private System.Windows.Forms.Button Pen10;
        private System.Windows.Forms.Button Pen8;
        private System.Windows.Forms.Button Pen6;
        private System.Windows.Forms.Button Pen4;
        private System.Windows.Forms.Button morePenoff;
    }
}

