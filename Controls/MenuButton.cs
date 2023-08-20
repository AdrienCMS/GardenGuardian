using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GardenGuardian.Controls
{
    class MenuButton : System.Windows.Forms.Button
    {
        private Image logo = GardenGuardian.Properties.Resources.cross_small;
        private Color GardenGLight = Color.FromArgb(14, 84, 46);
        private static Color FBDarker = Color.FromArgb(22,168,88);

        private Brush brush;
        private Brush fontBrush = new SolidBrush(Color.White);
        private Pen linePen;
        private Brush gradientBrush;
        private bool _isHovering;
        private string buttonLabel;


        public MenuButton()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, pevent) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, pevent) =>
            {
                _isHovering = false;
                Invalidate();
            };
        }

        //Ici, on dessine le contrôle
        protected override void OnPaint(PaintEventArgs pevent)
        {

            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            Point linePoint1 = new Point(10, (int)(this.Height * 0.90));
            Point linePoint2 = new Point(this.Width - 10, (int)(this.Height * 0.90));
            Point imagePoint = new Point(1, 1);

            Rectangle R = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            Rectangle imageZone = new Rectangle(10, 10, (int)(this.Height * 0.70), (int)(this.Height * 0.70));

            if (this.Enabled)
                brush = new SolidBrush(_isHovering ? GardenGLight : Color.Transparent);
            else
                brush = new SolidBrush(Color.FromArgb(122,122,122));
            Font = new Font("Bahnschrift", 16);
            g.FillRectangle(brush, R);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.FlatAppearance.BorderSize = 0;

            //Drawing logo
            g.DrawImage(logo, imageZone);

            //Drawing underline
            gradientBrush = new LinearGradientBrush(linePoint1, linePoint2, GardenGLight, FBDarker);

            linePen = new Pen(gradientBrush);
            linePen.Width = 3;
            g.DrawLine(linePen, linePoint1, linePoint2);

            //Button Text

            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(buttonLabel, Font, fontBrush, imageZone.Width + 20, (Height - stringSize.Height) / 2);

            TextAlign = ContentAlignment.MiddleRight;


        }

        public Image Logo
        {
            get => logo;
            set
            {
                logo = value;
                Invalidate();
            }
        }

        public Color lineColor
        {
            get => GardenGLight;
            set
            {
                GardenGLight = value;
                Invalidate();
            }
        }

        public String Label
        {
            get => buttonLabel;
            set
            {
                buttonLabel = value;
                Invalidate();
            }
        }
    }
}
