
namespace Paint
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sideBar = new System.Windows.Forms.Panel();
            this.brushValues = new System.Windows.Forms.GroupBox();
            this.fillCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brushColorButton = new System.Windows.Forms.Button();
            this.penValues = new System.Windows.Forms.GroupBox();
            this.penThickness = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.penColorButton = new System.Windows.Forms.Button();
            this.shape = new System.Windows.Forms.GroupBox();
            this.curve = new System.Windows.Forms.RadioButton();
            this.elypse = new System.Windows.Forms.RadioButton();
            this.square = new System.Windows.Forms.RadioButton();
            this.line = new System.Windows.Forms.RadioButton();
            this.drawingSpace = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.brushValues.SuspendLayout();
            this.penValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penThickness)).BeginInit();
            this.shape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingSpace)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sideBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.drawingSpace, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.brushValues);
            this.sideBar.Controls.Add(this.penValues);
            this.sideBar.Controls.Add(this.shape);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar.Location = new System.Drawing.Point(3, 3);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(144, 416);
            this.sideBar.TabIndex = 0;
            // 
            // brushValues
            // 
            this.brushValues.Controls.Add(this.fillCheck);
            this.brushValues.Controls.Add(this.label3);
            this.brushValues.Controls.Add(this.brushColorButton);
            this.brushValues.Location = new System.Drawing.Point(3, 257);
            this.brushValues.Name = "brushValues";
            this.brushValues.Size = new System.Drawing.Size(137, 111);
            this.brushValues.TabIndex = 2;
            this.brushValues.TabStop = false;
            this.brushValues.Text = "Wypełnienie";
            // 
            // fillCheck
            // 
            this.fillCheck.AutoSize = true;
            this.fillCheck.Location = new System.Drawing.Point(52, 59);
            this.fillCheck.Name = "fillCheck";
            this.fillCheck.Size = new System.Drawing.Size(79, 21);
            this.fillCheck.TabIndex = 6;
            this.fillCheck.Text = "Tak/Nie";
            this.fillCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "kolor";
            // 
            // brushColorButton
            // 
            this.brushColorButton.BackColor = System.Drawing.Color.Yellow;
            this.brushColorButton.Location = new System.Drawing.Point(65, 21);
            this.brushColorButton.Name = "brushColorButton";
            this.brushColorButton.Size = new System.Drawing.Size(66, 23);
            this.brushColorButton.TabIndex = 4;
            this.brushColorButton.UseVisualStyleBackColor = false;
            this.brushColorButton.Click += new System.EventHandler(this.brushColor_Click);
            // 
            // penValues
            // 
            this.penValues.Controls.Add(this.penThickness);
            this.penValues.Controls.Add(this.label2);
            this.penValues.Controls.Add(this.label1);
            this.penValues.Controls.Add(this.penColorButton);
            this.penValues.Location = new System.Drawing.Point(3, 149);
            this.penValues.Name = "penValues";
            this.penValues.Size = new System.Drawing.Size(137, 102);
            this.penValues.TabIndex = 1;
            this.penValues.TabStop = false;
            this.penValues.Text = "Pióro";
            // 
            // penThickness
            // 
            this.penThickness.Location = new System.Drawing.Point(65, 54);
            this.penThickness.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.penThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penThickness.Name = "penThickness";
            this.penThickness.Size = new System.Drawing.Size(66, 22);
            this.penThickness.TabIndex = 3;
            this.penThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "grubość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "kolor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // penColorButton
            // 
            this.penColorButton.BackColor = System.Drawing.Color.Black;
            this.penColorButton.Location = new System.Drawing.Point(65, 21);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(66, 23);
            this.penColorButton.TabIndex = 0;
            this.penColorButton.UseVisualStyleBackColor = false;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // shape
            // 
            this.shape.Controls.Add(this.curve);
            this.shape.Controls.Add(this.elypse);
            this.shape.Controls.Add(this.square);
            this.shape.Controls.Add(this.line);
            this.shape.Location = new System.Drawing.Point(3, 7);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(138, 136);
            this.shape.TabIndex = 0;
            this.shape.TabStop = false;
            this.shape.Text = "Kształt";
            this.shape.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // curve
            // 
            this.curve.AutoSize = true;
            this.curve.Location = new System.Drawing.Point(14, 105);
            this.curve.Name = "curve";
            this.curve.Size = new System.Drawing.Size(74, 21);
            this.curve.TabIndex = 3;
            this.curve.TabStop = true;
            this.curve.Text = "Krzywa";
            this.curve.UseVisualStyleBackColor = true;
            this.curve.CheckedChanged += new System.EventHandler(this.curve_CheckedChanged);
            // 
            // elypse
            // 
            this.elypse.AutoSize = true;
            this.elypse.Location = new System.Drawing.Point(14, 78);
            this.elypse.Name = "elypse";
            this.elypse.Size = new System.Drawing.Size(67, 21);
            this.elypse.TabIndex = 2;
            this.elypse.TabStop = true;
            this.elypse.Text = "Elipsa";
            this.elypse.UseVisualStyleBackColor = true;
            this.elypse.CheckedChanged += new System.EventHandler(this.elypse_CheckedChanged);
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Location = new System.Drawing.Point(14, 51);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(89, 21);
            this.square.TabIndex = 1;
            this.square.TabStop = true;
            this.square.Text = "Prostokąt";
            this.square.UseVisualStyleBackColor = true;
            this.square.CheckedChanged += new System.EventHandler(this.square_CheckedChanged);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(14, 24);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(59, 21);
            this.line.TabIndex = 0;
            this.line.TabStop = true;
            this.line.Text = "Linia";
            this.line.UseVisualStyleBackColor = true;
            this.line.CheckedChanged += new System.EventHandler(this.line_CheckedChanged);
            // 
            // drawingSpace
            // 
            this.drawingSpace.BackColor = System.Drawing.SystemColors.GrayText;
            this.drawingSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingSpace.Location = new System.Drawing.Point(153, 3);
            this.drawingSpace.Name = "drawingSpace";
            this.drawingSpace.Size = new System.Drawing.Size(644, 416);
            this.drawingSpace.TabIndex = 1;
            this.drawingSpace.TabStop = false;
            this.drawingSpace.Click += new System.EventHandler(this.drawingSpace_Click);
            this.drawingSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingSpace_MouseDown);
            this.drawingSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingSpace_MouseMove);
            this.drawingSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingSpace_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.ponówToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // ponówToolStripMenuItem
            // 
            this.ponówToolStripMenuItem.Name = "ponówToolStripMenuItem";
            this.ponówToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ponówToolStripMenuItem.Text = "Ponów";
            this.ponówToolStripMenuItem.Click += new System.EventHandler(this.ponówToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.brushValues.ResumeLayout(false);
            this.brushValues.PerformLayout();
            this.penValues.ResumeLayout(false);
            this.penValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penThickness)).EndInit();
            this.shape.ResumeLayout(false);
            this.shape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingSpace)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.PictureBox drawingSpace;
        private System.Windows.Forms.GroupBox shape;
        private System.Windows.Forms.RadioButton curve;
        private System.Windows.Forms.RadioButton elypse;
        private System.Windows.Forms.RadioButton square;
        private System.Windows.Forms.RadioButton line;
        private System.Windows.Forms.GroupBox brushValues;
        private System.Windows.Forms.GroupBox penValues;
        private System.Windows.Forms.NumericUpDown penThickness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.CheckBox fillCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brushColorButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponówToolStripMenuItem;
    }
}

