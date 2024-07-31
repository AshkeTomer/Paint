namespace Final_Proj_main
{
    partial class Paint_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint_Project));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.Save_data_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_palette = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_brush = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.Fill_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Palette_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Pencil_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Menu_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Eraser_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Delete_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Brush_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.CColor_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackColor = System.Drawing.Color.Gray;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.Location = new System.Drawing.Point(1575, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(270, 750);
            this.sidebar.MinimumSize = new System.Drawing.Size(75, 750);
            this.sidebar.Name = "sidebar";
            this.sidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sidebar.Size = new System.Drawing.Size(75, 750);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 66);
            this.panel1.TabIndex = 0;
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(10, 9);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(50, 50);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBtn.TabIndex = 0;
            this.menuBtn.TabStop = false;
            this.Menu_Tooltip.SetToolTip(this.menuBtn, "Toggle menu");
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.opacityBar);
            this.panel3.Location = new System.Drawing.Point(3, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 127);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "window opacity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(10, 23);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(50, 50);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // opacityBar
            // 
            this.opacityBar.Location = new System.Drawing.Point(64, 77);
            this.opacityBar.Minimum = 2;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(198, 45);
            this.opacityBar.TabIndex = 1;
            this.opacityBar.Value = 10;
            this.opacityBar.Scroll += new System.EventHandler(this.opacityBar_Scroll);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_square);
            this.panel5.Controls.Add(this.btn_line);
            this.panel5.Controls.Add(this.btn_circle);
            this.panel5.Controls.Add(this.btn_triangle);
            this.panel5.Controls.Add(this.Save_data_btn);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(3, 208);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 114);
            this.panel5.TabIndex = 5;
            // 
            // btn_square
            // 
            this.btn_square.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_square.Image = ((System.Drawing.Image)(resources.GetObject("btn_square.Image")));
            this.btn_square.Location = new System.Drawing.Point(172, 3);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(50, 50);
            this.btn_square.TabIndex = 1;
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_line
            // 
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_line.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.Image")));
            this.btn_line.Location = new System.Drawing.Point(106, 64);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(50, 50);
            this.btn_line.TabIndex = 3;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_circle.Image = ((System.Drawing.Image)(resources.GetObject("btn_circle.Image")));
            this.btn_circle.Location = new System.Drawing.Point(106, 3);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(50, 50);
            this.btn_circle.TabIndex = 2;
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_triangle.Image = ((System.Drawing.Image)(resources.GetObject("btn_triangle.Image")));
            this.btn_triangle.Location = new System.Drawing.Point(172, 64);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(50, 50);
            this.btn_triangle.TabIndex = 0;
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // Save_data_btn
            // 
            this.Save_data_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_data_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Save_data_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Save_data_btn.Location = new System.Drawing.Point(10, 5);
            this.Save_data_btn.Name = "Save_data_btn";
            this.Save_data_btn.Size = new System.Drawing.Size(50, 50);
            this.Save_data_btn.TabIndex = 6;
            this.Save_data_btn.Text = "Save data";
            this.Save_data_btn.UseVisualStyleBackColor = true;
            this.Save_data_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(10, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.btn_palette);
            this.panel4.Location = new System.Drawing.Point(3, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 61);
            this.panel4.TabIndex = 4;
            // 
            // btn_palette
            // 
            this.btn_palette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_palette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_palette.Image = ((System.Drawing.Image)(resources.GetObject("btn_palette.Image")));
            this.btn_palette.Location = new System.Drawing.Point(10, 3);
            this.btn_palette.Name = "btn_palette";
            this.btn_palette.Size = new System.Drawing.Size(50, 50);
            this.btn_palette.TabIndex = 1;
            this.Palette_Tooltip.SetToolTip(this.btn_palette, "Color Palette");
            this.btn_palette.UseVisualStyleBackColor = true;
            this.btn_palette.Click += new System.EventHandler(this.btn_palette_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.color_picker);
            this.panel6.Controls.Add(this.btn_fill);
            this.panel6.Controls.Add(this.btn_pencil);
            this.panel6.Controls.Add(this.btn_eraser);
            this.panel6.Controls.Add(this.btn_brush);
            this.panel6.Controls.Add(this.btn_delete);
            this.panel6.Location = new System.Drawing.Point(3, 395);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 338);
            this.panel6.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.CColor_Tooltip.SetToolTip(this.pictureBox1, "Current Color");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // color_picker
            // 
            this.color_picker.Image = ((System.Drawing.Image)(resources.GetObject("color_picker.Image")));
            this.color_picker.Location = new System.Drawing.Point(112, 34);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(110, 218);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.color_picker.TabIndex = 2;
            this.color_picker.TabStop = false;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_fill.Image = ((System.Drawing.Image)(resources.GetObject("btn_fill.Image")));
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(10, 3);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(50, 50);
            this.btn_fill.TabIndex = 4;
            this.btn_fill.Text = "fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fill_Tooltip.SetToolTip(this.btn_fill, "Fill - only works while sidebar is closed");
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_pencil.Image = ((System.Drawing.Image)(resources.GetObject("btn_pencil.Image")));
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pencil.Location = new System.Drawing.Point(10, 59);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(50, 50);
            this.btn_pencil.TabIndex = 2;
            this.btn_pencil.Text = "pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pencil_Tooltip.SetToolTip(this.btn_pencil, "Pencil");
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(10, 227);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(50, 50);
            this.btn_eraser.TabIndex = 0;
            this.btn_eraser.Text = "eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eraser_Tooltip.SetToolTip(this.btn_eraser, "A small eraser");
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_brush
            // 
            this.btn_brush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_brush.Image = ((System.Drawing.Image)(resources.GetObject("btn_brush.Image")));
            this.btn_brush.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_brush.Location = new System.Drawing.Point(10, 115);
            this.btn_brush.Name = "btn_brush";
            this.btn_brush.Size = new System.Drawing.Size(50, 50);
            this.btn_brush.TabIndex = 3;
            this.btn_brush.Text = "brush";
            this.btn_brush.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Brush_Tooltip.SetToolTip(this.btn_brush, "Brush");
            this.btn_brush.UseVisualStyleBackColor = true;
            this.btn_brush.Click += new System.EventHandler(this.btn_brush_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete.Location = new System.Drawing.Point(10, 171);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 50);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Delete_Tooltip.SetToolTip(this.btn_delete, "Wipes the entire page");
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebar_tick);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1575, 748);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Paint_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 748);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paint_Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Building #7 Simulator";
            this.Load += new System.EventHandler(this.Paint_Project_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.TrackBar opacityBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_brush;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button Save_data_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_palette;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.PictureBox pic;
        public System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolTip Fill_Tooltip;
        private System.Windows.Forms.ToolTip Palette_Tooltip;
        private System.Windows.Forms.ToolTip Pencil_Tooltip;
        private System.Windows.Forms.ToolTip Menu_Tooltip;
        private System.Windows.Forms.ToolTip Eraser_Tooltip;
        private System.Windows.Forms.ToolTip Delete_Tooltip;
        private System.Windows.Forms.ToolTip Brush_Tooltip;
        private System.Windows.Forms.ToolTip CColor_Tooltip;
    }
}

