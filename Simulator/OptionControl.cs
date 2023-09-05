using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator
{
    public partial class OptionControl : UserControl
    {
        public OptionControl()
        {
            InitializeComponent();
        }

        public char OptionLetter
        {
            get
            {
                return Convert.ToChar(rdb_option.Text);
            }
            set
            {
                rdb_option.Text = value.ToString();
            }
        }

        public string OptionText
        {
            get
            {
                return txt_option.Rtf;
            }
            set
            {
                try
                {
                    txt_option.Rtf = value;
                }
                catch//ExMessage = "File format is not valid." occurs if returned string is not rtf
                {
                    txt_option.Text = value;
                }
            }
        }

        public bool IsChecked
        {
            get
            {
                return rdb_option.Checked;
            }
            set
            {
                rdb_option.Checked = value;
            }
        }

        private void rdb_option_Click(object sender, EventArgs e)
        {
            rdb_option.Checked = !rdb_option.Checked;
        }

        private void txt_option_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            //increasing size of rich textbox:
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 15;

            //scroll only if caret is near the end of RTB
            //if ((((RichTextBox)sender).TextLength) - ((RichTextBox)sender).SelectionStart <= 6)
            //{
            //    tab_display_questions.VerticalScroll.Value = 0; //this is because scrollbar becomes negative if not reset and below formula doesn't work
            //    int yLocation = ((Control)sender).Location.Y;
            //    int Height = ((Control)sender).Height;

            //    tab_display_questions.AutoScrollPosition = new Point(0, yLocation + Height);
            //}
        }
    }
}
