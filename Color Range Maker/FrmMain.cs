using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Color_Range_Maker
{
    public partial class FrmMain : Form
    {

        private FrmEdit editForm;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                editForm = new FrmEdit(this);
                editForm.ShowDialog();
            }).Start();
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                Global.Image?.Dispose();
                GC.Collect();

                Global.Image = new Image<Hsv, byte>(files[0]);
                Invalidate();
            }
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            if (Global.Image != null)
            {
                List<ColorRange> ranges = new List<ColorRange>();

                if (Global.MinHue > Global.MaxHue)
                {
                    ColorRange lowerRange;
                    lowerRange.MinHue = 0;
                    lowerRange.MinSat = Global.MinSat;
                    lowerRange.MinVal = Global.MinVal;
                    lowerRange.MaxHue = Global.MaxHue;
                    lowerRange.MaxSat = Global.MaxSat;
                    lowerRange.MaxVal = Global.MaxVal;

                    ColorRange upperRange;
                    upperRange.MinHue = Global.MinHue;
                    upperRange.MinSat = Global.MinSat;
                    upperRange.MinVal = Global.MinVal;
                    upperRange.MaxHue = 180;
                    upperRange.MaxSat = Global.MaxSat;
                    upperRange.MaxVal = Global.MaxVal;

                    ranges.Add(lowerRange);
                    ranges.Add(upperRange);
                }
                else
                {
                    ColorRange lowerRange;
                    lowerRange.MinHue = Global.MinHue;
                    lowerRange.MinSat = Global.MinSat;
                    lowerRange.MinVal = Global.MinVal;
                    lowerRange.MaxHue = Global.MaxHue;
                    lowerRange.MaxSat = Global.MaxSat;
                    lowerRange.MaxVal = Global.MaxVal;

                    ranges.Add(lowerRange);
                }

                Image<Gray, byte> mask = new Image<Gray, byte>(Global.Image.Size);
                foreach (var range in ranges)
                {
                    mask |= Global.Image.InRange(new Hsv(range.MinHue, range.MinSat, range.MinVal), new Hsv(range.MaxHue, range.MaxSat, range.MaxVal));
                }

                
                e.Graphics.DrawImage(mask.ToBitmap(), Width / 2, 0, Width / 2, Height);
                e.Graphics.DrawImage(Global.Image.ToBitmap(), 0, 0, Width / 2, Height);
            }
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if(editForm.InvokeRequired)
            {
                editForm.BeginInvoke(new Action(delegate ()
                {
                    editForm.Close();
                }));
            }
            else
                editForm.Close();

            e.Cancel = false;
        }
    }
}