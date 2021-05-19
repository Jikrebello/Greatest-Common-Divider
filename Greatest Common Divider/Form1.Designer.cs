
namespace Greatest_Common_Divider
{
    partial class Form1
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
            this.BtnGreatestCommonDivider = new System.Windows.Forms.Button();
            this.BtnMixedToImproper = new System.Windows.Forms.Button();
            this.BtnLowestFormFractions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGreatestCommonDivider
            // 
            this.BtnGreatestCommonDivider.Location = new System.Drawing.Point(12, 12);
            this.BtnGreatestCommonDivider.Name = "BtnGreatestCommonDivider";
            this.BtnGreatestCommonDivider.Size = new System.Drawing.Size(221, 29);
            this.BtnGreatestCommonDivider.TabIndex = 0;
            this.BtnGreatestCommonDivider.Text = "Greatest Common Divider For 2 Numbers";
            this.BtnGreatestCommonDivider.UseVisualStyleBackColor = true;
            this.BtnGreatestCommonDivider.Click += new System.EventHandler(this.BtnGreatestCommonDivider_Click);
            // 
            // BtnMixedToImproper
            // 
            this.BtnMixedToImproper.Location = new System.Drawing.Point(10, 47);
            this.BtnMixedToImproper.Name = "BtnMixedToImproper";
            this.BtnMixedToImproper.Size = new System.Drawing.Size(221, 29);
            this.BtnMixedToImproper.TabIndex = 1;
            this.BtnMixedToImproper.Text = "Mixed To Improper";
            this.BtnMixedToImproper.UseVisualStyleBackColor = true;
            this.BtnMixedToImproper.Click += new System.EventHandler(this.BtnMixedToImproper_Click);
            // 
            // BtnLowestFormFractions
            // 
            this.BtnLowestFormFractions.Location = new System.Drawing.Point(10, 80);
            this.BtnLowestFormFractions.Name = "BtnLowestFormFractions";
            this.BtnLowestFormFractions.Size = new System.Drawing.Size(221, 29);
            this.BtnLowestFormFractions.TabIndex = 2;
            this.BtnLowestFormFractions.Text = "Add 2 Fractions to Lowest Form";
            this.BtnLowestFormFractions.UseVisualStyleBackColor = true;
            this.BtnLowestFormFractions.Click += new System.EventHandler(this.BtnLowestFormFractions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 116);
            this.Controls.Add(this.BtnLowestFormFractions);
            this.Controls.Add(this.BtnMixedToImproper);
            this.Controls.Add(this.BtnGreatestCommonDivider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGreatestCommonDivider;
        private System.Windows.Forms.Button BtnMixedToImproper;
        private System.Windows.Forms.Button BtnLowestFormFractions;
    }
}

