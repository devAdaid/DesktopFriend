using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFriend
{
    public partial class Form1 : Form
    {
        bool isFormDragging = false;
        Point oPointClicked;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormDragging = true;
                oPointClicked = new Point(e.X, e.Y);
                //tmrDrag.Interval = 110;
                //tmrDrag.Enabled = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormDragging = false;
                //tmrDrag.Enabled = false;
                //SetBits(petWithClothes[0]);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormDragging)
            {
                var oMoveToPoint = PointToScreen(new Point(e.X, e.Y));
                oMoveToPoint.Offset(oPointClicked.X * -1, (oPointClicked.Y + SystemInformation.CaptionHeight + SystemInformation.BorderSize.Height) * -1 + 24);
                Location = oMoveToPoint;
            }
        }
    }
}
