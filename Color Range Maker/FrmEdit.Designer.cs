using System;

namespace Color_Range_Maker
{
    partial class FrmEdit
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
            this.tbMinHue = new System.Windows.Forms.TrackBar();
            this.tbMinSat = new System.Windows.Forms.TrackBar();
            this.tbMinVal = new System.Windows.Forms.TrackBar();
            this.tbMaxVal = new System.Windows.Forms.TrackBar();
            this.tbMaxSat = new System.Windows.Forms.TrackBar();
            this.tbMaxHue = new System.Windows.Forms.TrackBar();
            this.lbMinHue = new System.Windows.Forms.Label();
            this.lbMinSat = new System.Windows.Forms.Label();
            this.lbMinVal = new System.Windows.Forms.Label();
            this.lbMaxHue = new System.Windows.Forms.Label();
            this.lbMaxSat = new System.Windows.Forms.Label();
            this.lbMaxVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxHue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMinHue
            // 
            this.tbMinHue.Location = new System.Drawing.Point(12, 12);
            this.tbMinHue.Maximum = 180;
            this.tbMinHue.Name = "tbMinHue";
            this.tbMinHue.Size = new System.Drawing.Size(447, 56);
            this.tbMinHue.TabIndex = 0;
            this.tbMinHue.Scroll += new System.EventHandler(this.tbMinHue_Scroll);
            // 
            // tbMinSat
            // 
            this.tbMinSat.Location = new System.Drawing.Point(12, 74);
            this.tbMinSat.Maximum = 255;
            this.tbMinSat.Name = "tbMinSat";
            this.tbMinSat.Size = new System.Drawing.Size(447, 56);
            this.tbMinSat.TabIndex = 1;
            this.tbMinSat.Scroll += new System.EventHandler(this.tbMinSat_Scroll);
            // 
            // tbMinVal
            // 
            this.tbMinVal.Location = new System.Drawing.Point(12, 136);
            this.tbMinVal.Maximum = 255;
            this.tbMinVal.Name = "tbMinVal";
            this.tbMinVal.Size = new System.Drawing.Size(447, 56);
            this.tbMinVal.TabIndex = 2;
            this.tbMinVal.Value = 80;
            this.tbMinVal.Scroll += new System.EventHandler(this.tbMinVal_Scroll);
            // 
            // tbMaxVal
            // 
            this.tbMaxVal.Location = new System.Drawing.Point(12, 322);
            this.tbMaxVal.Maximum = 255;
            this.tbMaxVal.Name = "tbMaxVal";
            this.tbMaxVal.Size = new System.Drawing.Size(447, 56);
            this.tbMaxVal.TabIndex = 5;
            this.tbMaxVal.Value = 255;
            this.tbMaxVal.Scroll += new System.EventHandler(this.tbMaxVal_Scroll);
            // 
            // tbMaxSat
            // 
            this.tbMaxSat.Location = new System.Drawing.Point(12, 260);
            this.tbMaxSat.Maximum = 255;
            this.tbMaxSat.Name = "tbMaxSat";
            this.tbMaxSat.Size = new System.Drawing.Size(447, 56);
            this.tbMaxSat.TabIndex = 4;
            this.tbMaxSat.Value = 255;
            this.tbMaxSat.Scroll += new System.EventHandler(this.tbMaxSat_Scroll);
            // 
            // tbMaxHue
            // 
            this.tbMaxHue.Location = new System.Drawing.Point(12, 198);
            this.tbMaxHue.Maximum = 180;
            this.tbMaxHue.Name = "tbMaxHue";
            this.tbMaxHue.Size = new System.Drawing.Size(447, 56);
            this.tbMaxHue.TabIndex = 3;
            this.tbMaxHue.Value = 180;
            this.tbMaxHue.Scroll += new System.EventHandler(this.tbMaxHue_Scroll);
            // 
            // lbMinHue
            // 
            this.lbMinHue.AutoSize = true;
            this.lbMinHue.Location = new System.Drawing.Point(465, 31);
            this.lbMinHue.Name = "lbMinHue";
            this.lbMinHue.Size = new System.Drawing.Size(56, 17);
            this.lbMinHue.TabIndex = 6;
            this.lbMinHue.Text = "MinHue";
            // 
            // lbMinSat
            // 
            this.lbMinSat.AutoSize = true;
            this.lbMinSat.Location = new System.Drawing.Point(465, 92);
            this.lbMinSat.Name = "lbMinSat";
            this.lbMinSat.Size = new System.Drawing.Size(51, 17);
            this.lbMinSat.TabIndex = 7;
            this.lbMinSat.Text = "MinSat";
            // 
            // lbMinVal
            // 
            this.lbMinVal.AutoSize = true;
            this.lbMinVal.Location = new System.Drawing.Point(465, 155);
            this.lbMinVal.Name = "lbMinVal";
            this.lbMinVal.Size = new System.Drawing.Size(50, 17);
            this.lbMinVal.TabIndex = 8;
            this.lbMinVal.Text = "MinVal";
            // 
            // lbMaxHue
            // 
            this.lbMaxHue.AutoSize = true;
            this.lbMaxHue.Location = new System.Drawing.Point(465, 218);
            this.lbMaxHue.Name = "lbMaxHue";
            this.lbMaxHue.Size = new System.Drawing.Size(59, 17);
            this.lbMaxHue.TabIndex = 9;
            this.lbMaxHue.Text = "MaxHue";
            // 
            // lbMaxSat
            // 
            this.lbMaxSat.AutoSize = true;
            this.lbMaxSat.Location = new System.Drawing.Point(465, 279);
            this.lbMaxSat.Name = "lbMaxSat";
            this.lbMaxSat.Size = new System.Drawing.Size(54, 17);
            this.lbMaxSat.TabIndex = 10;
            this.lbMaxSat.Text = "MaxSat";
            // 
            // lbMaxVal
            // 
            this.lbMaxVal.AutoSize = true;
            this.lbMaxVal.Location = new System.Drawing.Point(465, 342);
            this.lbMaxVal.Name = "lbMaxVal";
            this.lbMaxVal.Size = new System.Drawing.Size(53, 17);
            this.lbMaxVal.TabIndex = 11;
            this.lbMaxVal.Text = "MaxVal";
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 385);
            this.ControlBox = false;
            this.Controls.Add(this.lbMaxVal);
            this.Controls.Add(this.lbMaxSat);
            this.Controls.Add(this.lbMaxHue);
            this.Controls.Add(this.lbMinVal);
            this.Controls.Add(this.lbMinSat);
            this.Controls.Add(this.lbMinHue);
            this.Controls.Add(this.tbMaxVal);
            this.Controls.Add(this.tbMaxSat);
            this.Controls.Add(this.tbMaxHue);
            this.Controls.Add(this.tbMinVal);
            this.Controls.Add(this.tbMinSat);
            this.Controls.Add(this.tbMinHue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmEdit";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Window";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmEdit_Activated);
            this.Deactivate += new System.EventHandler(this.FrmEdit_Deactivate);
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMinHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxHue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbMinHue;
        private System.Windows.Forms.TrackBar tbMinSat;
        private System.Windows.Forms.TrackBar tbMinVal;
        private System.Windows.Forms.TrackBar tbMaxVal;
        private System.Windows.Forms.TrackBar tbMaxSat;
        private System.Windows.Forms.TrackBar tbMaxHue;
        private System.Windows.Forms.Label lbMinHue;
        private System.Windows.Forms.Label lbMinSat;
        private System.Windows.Forms.Label lbMinVal;
        private System.Windows.Forms.Label lbMaxHue;
        private System.Windows.Forms.Label lbMaxSat;
        private System.Windows.Forms.Label lbMaxVal;
    }
}