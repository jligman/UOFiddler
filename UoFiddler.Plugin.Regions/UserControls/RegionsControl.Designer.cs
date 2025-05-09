/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

namespace UoFiddler.Plugin.Regions.UserControls
{
    partial class RegionsControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            regionMapControl1 = new RegionMapControl();
            SuspendLayout();
            // 
            // regionMapControl1
            // 
            regionMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            regionMapControl1.Location = new System.Drawing.Point(0, 0);
            regionMapControl1.Margin = new System.Windows.Forms.Padding(0);
            regionMapControl1.Name = "regionMapControl1";
            regionMapControl1.Size = new System.Drawing.Size(800, 600);
            regionMapControl1.TabIndex = 0;
            // 
            // RegionsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(regionMapControl1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RegionsControl";
            Size = new System.Drawing.Size(800, 600);
            ResumeLayout(false);
        }

        #endregion


        private RegionMapControl regionMapControl1;
    }
}
