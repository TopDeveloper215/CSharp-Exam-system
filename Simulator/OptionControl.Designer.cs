namespace Simulator
{
    partial class OptionControl
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
            this.rdb_option = new System.Windows.Forms.RadioButton();
            this.txt_option = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rdb_option
            // 
            this.rdb_option.AutoCheck = false;
            this.rdb_option.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdb_option.Location = new System.Drawing.Point(0, 0);
            this.rdb_option.Name = "rdb_option";
            this.rdb_option.Size = new System.Drawing.Size(32, 45);
            this.rdb_option.TabIndex = 0;
            this.rdb_option.Text = "A";
            this.rdb_option.UseVisualStyleBackColor = true;
            this.rdb_option.Click += new System.EventHandler(this.rdb_option_Click);
            // 
            // txt_option
            // 
            this.txt_option.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_option.HideSelection = false;
            this.txt_option.Location = new System.Drawing.Point(32, 0);
            this.txt_option.Name = "txt_option";
            this.txt_option.ReadOnly = true;
            this.txt_option.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txt_option.Size = new System.Drawing.Size(780, 45);
            this.txt_option.TabIndex = 1;
            this.txt_option.Text = "";
            this.txt_option.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.txt_option_ContentsResized);
            // 
            // OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.txt_option);
            this.Controls.Add(this.rdb_option);
            this.Name = "OptionControl";
            this.Size = new System.Drawing.Size(812, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_option;
        private System.Windows.Forms.RichTextBox txt_option;
    }
}
