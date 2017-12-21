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
            this.num_MinHue = new System.Windows.Forms.NumericUpDown();
            this.num_MinSat = new System.Windows.Forms.NumericUpDown();
            this.num_MinVal = new System.Windows.Forms.NumericUpDown();
            this.num_MaxVal = new System.Windows.Forms.NumericUpDown();
            this.num_MaxSat = new System.Windows.Forms.NumericUpDown();
            this.num_MaxHue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxHue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMinHue
            // 
            this.tbMinHue.Location = new System.Drawing.Point(114, 12);
            this.tbMinHue.Maximum = 180;
            this.tbMinHue.Name = "tbMinHue";
            this.tbMinHue.Size = new System.Drawing.Size(447, 56);
            this.tbMinHue.TabIndex = 0;
            this.tbMinHue.Scroll += new System.EventHandler(this.tbMinHue_Scroll);
            // 
            // tbMinSat
            // 
            this.tbMinSat.Location = new System.Drawing.Point(114, 74);
            this.tbMinSat.Maximum = 255;
            this.tbMinSat.Name = "tbMinSat";
            this.tbMinSat.Size = new System.Drawing.Size(447, 56);
            this.tbMinSat.TabIndex = 1;
            this.tbMinSat.Scroll += new System.EventHandler(this.tbMinSat_Scroll);
            // 
            // tbMinVal
            // 
            this.tbMinVal.Location = new System.Drawing.Point(114, 136);
            this.tbMinVal.Maximum = 255;
            this.tbMinVal.Name = "tbMinVal";
            this.tbMinVal.Size = new System.Drawing.Size(447, 56);
            this.tbMinVal.TabIndex = 2;
            this.tbMinVal.Value = 80;
            this.tbMinVal.Scroll += new System.EventHandler(this.tbMinVal_Scroll);
            // 
            // tbMaxVal
            // 
            this.tbMaxVal.Location = new System.Drawing.Point(114, 322);
            this.tbMaxVal.Maximum = 255;
            this.tbMaxVal.Name = "tbMaxVal";
            this.tbMaxVal.Size = new System.Drawing.Size(447, 56);
            this.tbMaxVal.TabIndex = 5;
            this.tbMaxVal.Value = 255;
            this.tbMaxVal.Scroll += new System.EventHandler(this.tbMaxVal_Scroll);
            // 
            // tbMaxSat
            // 
            this.tbMaxSat.Location = new System.Drawing.Point(114, 260);
            this.tbMaxSat.Maximum = 255;
            this.tbMaxSat.Name = "tbMaxSat";
            this.tbMaxSat.Size = new System.Drawing.Size(447, 56);
            this.tbMaxSat.TabIndex = 4;
            this.tbMaxSat.Value = 255;
            this.tbMaxSat.Scroll += new System.EventHandler(this.tbMaxSat_Scroll);
            // 
            // tbMaxHue
            // 
            this.tbMaxHue.Location = new System.Drawing.Point(114, 198);
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
            this.lbMinHue.Location = new System.Drawing.Point(567, 31);
            this.lbMinHue.Name = "lbMinHue";
            this.lbMinHue.Size = new System.Drawing.Size(56, 17);
            this.lbMinHue.TabIndex = 6;
            this.lbMinHue.Text = "MinHue";
            // 
            // lbMinSat
            // 
            this.lbMinSat.AutoSize = true;
            this.lbMinSat.Location = new System.Drawing.Point(567, 92);
            this.lbMinSat.Name = "lbMinSat";
            this.lbMinSat.Size = new System.Drawing.Size(51, 17);
            this.lbMinSat.TabIndex = 7;
            this.lbMinSat.Text = "MinSat";
            // 
            // lbMinVal
            // 
            this.lbMinVal.AutoSize = true;
            this.lbMinVal.Location = new System.Drawing.Point(567, 155);
            this.lbMinVal.Name = "lbMinVal";
            this.lbMinVal.Size = new System.Drawing.Size(50, 17);
            this.lbMinVal.TabIndex = 8;
            this.lbMinVal.Text = "MinVal";
            // 
            // lbMaxHue
            // 
            this.lbMaxHue.AutoSize = true;
            this.lbMaxHue.Location = new System.Drawing.Point(567, 218);
            this.lbMaxHue.Name = "lbMaxHue";
            this.lbMaxHue.Size = new System.Drawing.Size(59, 17);
            this.lbMaxHue.TabIndex = 9;
            this.lbMaxHue.Text = "MaxHue";
            // 
            // lbMaxSat
            // 
            this.lbMaxSat.AutoSize = true;
            this.lbMaxSat.Location = new System.Drawing.Point(567, 279);
            this.lbMaxSat.Name = "lbMaxSat";
            this.lbMaxSat.Size = new System.Drawing.Size(54, 17);
            this.lbMaxSat.TabIndex = 10;
            this.lbMaxSat.Text = "MaxSat";
            // 
            // lbMaxVal
            // 
            this.lbMaxVal.AutoSize = true;
            this.lbMaxVal.Location = new System.Drawing.Point(567, 342);
            this.lbMaxVal.Name = "lbMaxVal";
            this.lbMaxVal.Size = new System.Drawing.Size(53, 17);
            this.lbMaxVal.TabIndex = 11;
            this.lbMaxVal.Text = "MaxVal";
            // 
            // num_MinHue
            // 
            this.num_MinHue.Location = new System.Drawing.Point(12, 12);
            this.num_MinHue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_MinHue.Name = "num_MinHue";
            this.num_MinHue.Size = new System.Drawing.Size(96, 22);
            this.num_MinHue.TabIndex = 12;
            this.num_MinHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MinHue.ValueChanged += new System.EventHandler(this.num_MinHue_ValueChanged);
            this.num_MinHue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_MinHue_KeyUp);
            // 
            // num_MinSat
            // 
            this.num_MinSat.Location = new System.Drawing.Point(12, 74);
            this.num_MinSat.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_MinSat.Name = "num_MinSat";
            this.num_MinSat.Size = new System.Drawing.Size(96, 22);
            this.num_MinSat.TabIndex = 13;
            this.num_MinSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MinSat.ValueChanged += new System.EventHandler(this.num_MinSat_ValueChanged);
            this.num_MinSat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_MinSat_KeyUp);
            // 
            // num_MinVal
            // 
            this.num_MinVal.Location = new System.Drawing.Point(12, 136);
            this.num_MinVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_MinVal.Name = "num_MinVal";
            this.num_MinVal.Size = new System.Drawing.Size(96, 22);
            this.num_MinVal.TabIndex = 14;
            this.num_MinVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MinVal.ValueChanged += new System.EventHandler(this.num_MinVal_ValueChanged);
            this.num_MinVal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_MinVal_KeyUp);
            // 
            // num_MaxVal
            // 
            this.num_MaxVal.Location = new System.Drawing.Point(12, 322);
            this.num_MaxVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_MaxVal.Name = "num_MaxVal";
            this.num_MaxVal.Size = new System.Drawing.Size(96, 22);
            this.num_MaxVal.TabIndex = 17;
            this.num_MaxVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MaxVal.ValueChanged += new System.EventHandler(this.num_MaxVal_ValueChanged);
            this.num_MaxVal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_MaxVal_KeyUp);
            // 
            // num_MaxSat
            // 
            this.num_MaxSat.Location = new System.Drawing.Point(12, 260);
            this.num_MaxSat.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_MaxSat.Name = "num_MaxSat";
            this.num_MaxSat.Size = new System.Drawing.Size(96, 22);
            this.num_MaxSat.TabIndex = 16;
            this.num_MaxSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MaxSat.ValueChanged += new System.EventHandler(this.num_MaxSat_ValueChanged);
            this.num_MaxSat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_MaxSat_KeyUp);
            // 
            // num_MaxHue
            // 
            this.num_MaxHue.Location = new System.Drawing.Point(12, 198);
            this.num_MaxHue.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_MaxHue.Name = "num_MaxHue";
            this.num_MaxHue.Size = new System.Drawing.Size(96, 22);
            this.num_MaxHue.TabIndex = 15;
            this.num_MaxHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MaxHue.ValueChanged += new System.EventHandler(this.num_MaxHue_ValueChanged);
            this.num_MaxHue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.num_MaxHue_KeyUp);
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 385);
            this.ControlBox = false;
            this.Controls.Add(this.num_MaxVal);
            this.Controls.Add(this.num_MaxSat);
            this.Controls.Add(this.num_MaxHue);
            this.Controls.Add(this.num_MinVal);
            this.Controls.Add(this.num_MinSat);
            this.Controls.Add(this.num_MinHue);
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
            this.MaximizeBox = false;
            this.Name = "FrmEdit";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Window";
            this.Activated += new System.EventHandler(this.FrmEdit_Activated);
            this.Deactivate += new System.EventHandler(this.FrmEdit_Deactivate);
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMinHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxHue)).EndInit();
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
        private System.Windows.Forms.NumericUpDown num_MinHue;
        private System.Windows.Forms.NumericUpDown num_MinSat;
        private System.Windows.Forms.NumericUpDown num_MinVal;
        private System.Windows.Forms.NumericUpDown num_MaxVal;
        private System.Windows.Forms.NumericUpDown num_MaxSat;
        private System.Windows.Forms.NumericUpDown num_MaxHue;
    }
}