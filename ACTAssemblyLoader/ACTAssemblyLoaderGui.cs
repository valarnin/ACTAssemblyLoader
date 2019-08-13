using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTAssemblyLoader
{
    public partial class ACTAssemblyLoader : UserControl
    {
        private TextBox textAssemblies;
        private Label labelAssemblies;
        #region Designer Created Code (Avoid editing)
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
            this.textAssemblies = new System.Windows.Forms.TextBox();
            this.labelAssemblies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textAssemblies
            // 
            this.textAssemblies.Location = new System.Drawing.Point(7, 20);
            this.textAssemblies.Multiline = true;
            this.textAssemblies.Name = "textAssemblies";
            this.textAssemblies.Size = new System.Drawing.Size(676, 361);
            this.textAssemblies.TabIndex = 0;
            this.textAssemblies.WordWrap = false;
            // 
            // labelAssemblies
            // 
            this.labelAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAssemblies.AutoSize = true;
            this.labelAssemblies.Location = new System.Drawing.Point(4, 4);
            this.labelAssemblies.Name = "labelAssemblies";
            this.labelAssemblies.Size = new System.Drawing.Size(569, 13);
            this.labelAssemblies.TabIndex = 1;
            this.labelAssemblies.Text = "Place assemblies to load in text box below, one per line. Ensure this plugin load" +
    "s first, and restart ACT to apply changes.";
            this.labelAssemblies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ACTAssemblyLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelAssemblies);
            this.Controls.Add(this.textAssemblies);
            this.Name = "ACTAssemblyLoader";
            this.Size = new System.Drawing.Size(686, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #endregion

    }
}
