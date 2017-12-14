using System;
using System.Windows.Forms;

namespace Color_Range_Maker
{
    public partial class FrmEdit : Form
    {

        private FrmMain mainForm;

        public FrmEdit()
        {
            InitializeComponent();
        }

        public FrmEdit(FrmMain mainForm) : this()
        {
            this.mainForm = mainForm;
        }

        private void tbMinHue_Scroll(object sender, EventArgs e)
        {
            Global.MinHue = tbMinHue.Value;
            lbMinHue.Text = string.Format("Min Hue: OpenCV: {0} | Norm HSV: {1}", Global.MinHue, Math.Round((Global.MinHue / 180) * 360, 0));
            mainForm.Invalidate();
        }

        private void tbMinSat_Scroll(object sender, EventArgs e)
        {
            Global.MinSat = tbMinSat.Value;
            lbMinSat.Text = string.Format("Min Sat: OpenCV: {0} | Norm HSV: {1}", Global.MinSat, Math.Round((Global.MinSat / 255) * 100, 0));
            mainForm.Invalidate();
        }

        private void tbMinVal_Scroll(object sender, EventArgs e)
        {
            Global.MinVal = tbMinVal.Value;
            lbMinVal.Text = string.Format("Min Val: OpenCV: {0} | Norm HSV: {1}", Global.MinVal, Math.Round((Global.MinVal / 255) * 100, 0));
            mainForm.Invalidate();
        }

        private void tbMaxHue_Scroll(object sender, EventArgs e)
        {
            Global.MaxHue = tbMaxHue.Value;
            lbMaxHue.Text = string.Format("Max Hue: OpenCV: {0} | Norm HSV: {1}", Global.MaxHue, Math.Round((Global.MaxHue / 180) * 360, 0));
            mainForm.Invalidate();
        }

        private void tbMaxSat_Scroll(object sender, EventArgs e)
        {
            Global.MaxSat = tbMaxSat.Value;
            lbMaxSat.Text = string.Format("Max Sat: OpenCV: {0} | Norm HSV: {1}", Global.MaxSat, Math.Round((Global.MaxSat / 255) * 100, 0));
            mainForm.Invalidate();
        }

        private void tbMaxVal_Scroll(object sender, EventArgs e)
        {
            Global.MaxVal = tbMaxVal.Value;
            lbMaxVal.Text = string.Format("Max Val: OpenCV: {0} | Norm HSV: {1}", Global.MaxVal, Math.Round((Global.MaxVal / 255) * 100, 0));
            mainForm.Invalidate();
        }

        private void FrmEdit_Activated(object sender, EventArgs e)
        {
            Opacity = 100;
        }

        private void FrmEdit_Deactivate(object sender, EventArgs e)
        {
            Opacity = 0.75;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            tbMinHue_Scroll(this, EventArgs.Empty);
            tbMinSat_Scroll(this, EventArgs.Empty);
            tbMinVal_Scroll(this, EventArgs.Empty);
            tbMaxHue_Scroll(this, EventArgs.Empty);
            tbMaxSat_Scroll(this, EventArgs.Empty);
            tbMaxVal_Scroll(this, EventArgs.Empty);
        }
    }
}
