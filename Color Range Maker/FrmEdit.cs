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

            Owner = mainForm;
        }

        private void tbMinHue_Scroll(object sender, EventArgs e)
        {
            Global.MinHue = tbMinHue.Value;
            lbMinHue.Text = string.Format("Min Hue: OpenCV: {0} | Norm HSV: {1}", Global.MinHue, Math.Round((Global.MinHue / 180) * 360, 0));
            num_MinHue.Value = (decimal)Global.MinHue;
            mainForm.Invalidate();
        }

        private void tbMinSat_Scroll(object sender, EventArgs e)
        {
            Global.MinSat = tbMinSat.Value;
            lbMinSat.Text = string.Format("Min Sat: OpenCV: {0} | Norm HSV: {1}", Global.MinSat, Math.Round((Global.MinSat / 255) * 100, 0));
            num_MinSat.Value = (decimal)Global.MinSat;
            mainForm.Invalidate();
        }

        private void tbMinVal_Scroll(object sender, EventArgs e)
        {
            Global.MinVal = tbMinVal.Value;
            lbMinVal.Text = string.Format("Min Val: OpenCV: {0} | Norm HSV: {1}", Global.MinVal, Math.Round((Global.MinVal / 255) * 100, 0));
            num_MinVal.Value = (decimal)Global.MinVal;
            mainForm.Invalidate();
        }

        private void tbMaxHue_Scroll(object sender, EventArgs e)
        {
            Global.MaxHue = tbMaxHue.Value;
            lbMaxHue.Text = string.Format("Max Hue: OpenCV: {0} | Norm HSV: {1}", Global.MaxHue, Math.Round((Global.MaxHue / 180) * 360, 0));
            num_MaxHue.Value = (decimal)Global.MaxHue;
            mainForm.Invalidate();
        }

        private void tbMaxSat_Scroll(object sender, EventArgs e)
        {
            Global.MaxSat = tbMaxSat.Value;
            lbMaxSat.Text = string.Format("Max Sat: OpenCV: {0} | Norm HSV: {1}", Global.MaxSat, Math.Round((Global.MaxSat / 255) * 100, 0));
            num_MaxSat.Value = (decimal)Global.MaxSat;
            mainForm.Invalidate();
        }

        private void tbMaxVal_Scroll(object sender, EventArgs e)
        {
            Global.MaxVal = tbMaxVal.Value;
            lbMaxVal.Text = string.Format("Max Val: OpenCV: {0} | Norm HSV: {1}", Global.MaxVal, Math.Round((Global.MaxVal / 255) * 100, 0));
            num_MaxVal.Value = (decimal)Global.MaxVal;
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

        private void num_MinHue_ValueChanged(object sender, EventArgs e)
        {
            tbMinHue.Value = (int)num_MinHue.Value;
            tbMinHue_Scroll(sender, e);
        }

        private void num_MinSat_ValueChanged(object sender, EventArgs e)
        {
            tbMinSat.Value = (int)num_MinSat.Value;
            tbMinSat_Scroll(sender, e);
        }

        private void num_MinVal_ValueChanged(object sender, EventArgs e)
        {
            tbMinVal.Value = (int)num_MinVal.Value;
            tbMinVal_Scroll(sender, e);
        }

        private void num_MaxHue_ValueChanged(object sender, EventArgs e)
        {
            tbMaxHue.Value = (int)num_MaxHue.Value;
            tbMaxHue_Scroll(sender, e);
        }

        private void num_MaxSat_ValueChanged(object sender, EventArgs e)
        {
            tbMaxSat.Value = (int)num_MaxSat.Value;
            tbMaxSat_Scroll(sender, e);
        }

        private void num_MaxVal_ValueChanged(object sender, EventArgs e)
        {
            tbMaxVal.Value = (int)num_MaxVal.Value;
            tbMaxVal_Scroll(sender, e);
        }

        private void num_MinHue_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                num_MinHue_ValueChanged(sender, e);
        }

        private void num_MinSat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                num_MinSat_ValueChanged(sender, e);
        }

        private void num_MinVal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                num_MinVal_ValueChanged(sender, e);
        }

        private void num_MaxHue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                num_MaxHue_ValueChanged(sender, e);
        }

        private void num_MaxSat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                num_MaxSat_ValueChanged(sender, e);
        }

        private void num_MaxVal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                num_MaxVal_ValueChanged(sender, e);
        }
    }
}
