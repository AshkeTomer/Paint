using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

//classes
using Final_Proj_main.ShapesList;
using Final_Proj_main.shapes;

//serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Final_Proj_main
{
    public partial class Paint_Project : Form
    {
        static int currentImage = 0;
        bool sidebarExpand = false;

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.White, 1);
        Pen erase = new Pen(Color.White, 40);
        int index = 1;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        ShapeList s;

        public Paint_Project()
        {
            InitializeComponent();
            this.Width = 1565;
            this.Height = 790;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            s = new ShapeList();
            s.Clear();
        }

        // sidebar opening and closing sequence
        private void sidebar_tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                    Invalidate();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                    Invalidate();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // opens and closes the menu button
        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            Invalidate();
        }

        // opacity bar inside 
        private void opacityBar_Scroll(object sender, EventArgs e)
        {
            ActiveForm.Opacity = ((double)(opacityBar.Value) / 10.0);
        }

        // sets mode to draw a circle
        private void btn_circle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        // sets mode to draw a rectangle
        private void btn_square_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        // sets mode to draw a line
        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
                if (paint)
                {
                    if (index == 3) // draws a circle
                    {
                        Shape sha = new Circle(new Point(cX, cY));
                        s[s.NextIndex] = sha;
                        sha.draw(g, p, sX, sY);
                    }

                    if (index == 4) // draws a rectangle
                    {
                        Shape sha = new MyRectangle(new Point(cX, cY));
                        s[s.NextIndex] = sha;
                        sha.draw(g, p, sX, sY);
                    }

                    if (index == 5) // draws a line
                    {
                        g.DrawLine(p, cX, cY, x, y);
                    }

                    if (index == 9) // draws a triangle
                    {
                        Shape sha = new Triangle(new Point(cX, cY));
                        s[s.NextIndex] = sha;
                        sha.draw(g, p, x, y);
                    }
                }
        }

        // opens pallet to chose a new color
        private void btn_palette_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pictureBox1.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        // sets central point
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        // sets new color via clicking insde the color pallet on side
        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pictureBox1.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pictureBox1.BackColor;
            p.Color = pictureBox1.BackColor;
        }

        // sets to use FILL func
        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
                if (index == 8)
                {
                    p.Width = 10;
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX; // side x
            sY = y - cY; // side y

            if (index == 3) // draws adjustable ellipse
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4) // draws adjustable rectangle
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5) // draws adjustable line
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if (index == 9) // draws adjustable triangle
            {
                new Triangle(new Point(cX, cY)).draw(g, p, x, y);
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            // checks if sidebar is closed to use FILL func
            if (index == 7 && sidebar.Width != sidebar.MaximumSize.Width)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
        }

        // sets the pens width to a brush size
        private void btn_brush_Click(object sender, EventArgs e)
        {
            index = 8;
            p.Width = 10;
        }

        // clears the work env
        private void Paint_Project_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            index = 1;
        }

        // save function
        private void btn_save_Click(object sender, EventArgs e)
        {
                var sdf = new SaveFileDialog();
                sdf.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                    btm.Save(sdf.FileName, ImageFormat.Jpeg);
                }
        }

        // sets mode to draw triangle
        private void btn_triangle_Click(object sender, EventArgs e) 
        {
            index = 9;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        // saves the mdl files
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "model files (*.mdl)|*.mdl";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(sfd.FileName, FileMode.Create,FileAccess.Write,FileShare.None))
                {
                    formatter.Serialize(stream, s);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        // loads the mdl files
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "model files (*.mdl)|*.mdl";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(ofd.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                s = (ShapeList)binaryFormatter.Deserialize(stream);
                pic.Invalidate();

                for (int i = 0; i < s.Count - 1; i++)
                {
                    Shape sha = (Shape)s[i];
                    sha.draw(g, p, this.x, this.y);
                }
            }
        }

        private void color_picker_Click(object sender, EventArgs e)
        {
        }

        // sets mode of draw as you want
        private void btn_pencil_Click(object sender, EventArgs e) 
        {
            index = 1;
            p.Width = 1;
        }

        // sets mode to erase drawings
        private void btn_eraser_Click(object sender, EventArgs e) 
        {
            index = 2;
        }

        // clears the work env
        private void btn_delete_Click(object sender, EventArgs e) 
        {
            g.Clear(Color.White);
            pic.Image = bm;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        // checks used in FILL func
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == old_color) 
            { 
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        // FILL func to fill shapes a certain color
        public void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_color);

            if (old_color == new_color)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_color);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_color);
                }
            }
        }
    }
}
