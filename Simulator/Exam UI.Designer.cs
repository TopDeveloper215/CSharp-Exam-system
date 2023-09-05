namespace Simulator
{
    partial class Exam_UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_elapsed_time = new System.Windows.Forms.Label();
            this.btn_begin = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.lbl_question_number = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_section_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_exam_code = new System.Windows.Forms.Label();
            this.lbl_exam_instructions = new System.Windows.Forms.Label();
            this.lbl_exam_title = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_show_answer = new System.Windows.Forms.Button();
            this.pan_display = new System.Windows.Forms.TableLayoutPanel();
            this.txt_question = new System.Windows.Forms.RichTextBox();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_middle = new System.Windows.Forms.Panel();
            this.pan_display.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_middle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1100, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left:";
            this.label1.Visible = false;
            // 
            // lbl_elapsed_time
            // 
            this.lbl_elapsed_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_elapsed_time.Location = new System.Drawing.Point(1160, 3);
            this.lbl_elapsed_time.Name = "lbl_elapsed_time";
            this.lbl_elapsed_time.Size = new System.Drawing.Size(70, 19);
            this.lbl_elapsed_time.TabIndex = 1;
            this.lbl_elapsed_time.Text = "00:00:00";
            this.lbl_elapsed_time.Visible = false;
            // 
            // btn_begin
            // 
            this.btn_begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_begin.Location = new System.Drawing.Point(6, 20);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(75, 23);
            this.btn_begin.TabIndex = 2;
            this.btn_begin.Text = "Begin";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_previous.Enabled = false;
            this.btn_previous.Location = new System.Drawing.Point(6, 20);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 23);
            this.btn_previous.TabIndex = 3;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Visible = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(98, 20);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pause.Enabled = false;
            this.btn_pause.Location = new System.Drawing.Point(1064, 20);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Visible = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_end
            // 
            this.btn_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_end.Enabled = false;
            this.btn_end.Location = new System.Drawing.Point(1154, 20);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 6;
            this.btn_end.Text = "End";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Visible = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // lbl_question_number
            // 
            this.lbl_question_number.AutoSize = true;
            this.lbl_question_number.Location = new System.Drawing.Point(70, 40);
            this.lbl_question_number.Name = "lbl_question_number";
            this.lbl_question_number.Size = new System.Drawing.Size(35, 13);
            this.lbl_question_number.TabIndex = 10;
            this.lbl_question_number.Text = "label4";
            this.lbl_question_number.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Question:";
            this.label3.Visible = false;
            // 
            // lbl_section_title
            // 
            this.lbl_section_title.AutoSize = true;
            this.lbl_section_title.Location = new System.Drawing.Point(64, 13);
            this.lbl_section_title.Name = "lbl_section_title";
            this.lbl_section_title.Size = new System.Drawing.Size(35, 13);
            this.lbl_section_title.TabIndex = 8;
            this.lbl_section_title.Text = "label2";
            this.lbl_section_title.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Section:";
            this.label2.Visible = false;
            // 
            // lbl_exam_code
            // 
            this.lbl_exam_code.AutoSize = true;
            this.lbl_exam_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_code.Location = new System.Drawing.Point(7, 47);
            this.lbl_exam_code.Name = "lbl_exam_code";
            this.lbl_exam_code.Size = new System.Drawing.Size(47, 15);
            this.lbl_exam_code.TabIndex = 2;
            this.lbl_exam_code.Text = "label4";
            // 
            // lbl_exam_instructions
            // 
            this.lbl_exam_instructions.AutoSize = true;
            this.lbl_exam_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_instructions.Location = new System.Drawing.Point(12, 74);
            this.lbl_exam_instructions.Name = "lbl_exam_instructions";
            this.lbl_exam_instructions.Size = new System.Drawing.Size(41, 15);
            this.lbl_exam_instructions.TabIndex = 1;
            this.lbl_exam_instructions.Text = "label4";
            // 
            // lbl_exam_title
            // 
            this.lbl_exam_title.AutoSize = true;
            this.lbl_exam_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_title.Location = new System.Drawing.Point(7, 13);
            this.lbl_exam_title.Name = "lbl_exam_title";
            this.lbl_exam_title.Size = new System.Drawing.Size(51, 16);
            this.lbl_exam_title.TabIndex = 0;
            this.lbl_exam_title.Text = "label3";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_show_answer
            // 
            this.btn_show_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_answer.Location = new System.Drawing.Point(992, 3);
            this.btn_show_answer.Name = "btn_show_answer";
            this.btn_show_answer.Size = new System.Drawing.Size(84, 23);
            this.btn_show_answer.TabIndex = 9;
            this.btn_show_answer.Text = "Show Answer";
            this.btn_show_answer.UseVisualStyleBackColor = true;
            this.btn_show_answer.Visible = false;
            this.btn_show_answer.Click += new System.EventHandler(this.btn_show_answer_Click);
            // 
            // pan_display
            // 
            this.pan_display.AutoSize = true;
            this.pan_display.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pan_display.ColumnCount = 1;
            this.pan_display.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pan_display.Controls.Add(this.txt_question, 0, 0);
            this.pan_display.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_display.Location = new System.Drawing.Point(0, 0);
            this.pan_display.Name = "pan_display";
            this.pan_display.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pan_display.RowCount = 2;
            this.pan_display.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pan_display.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pan_display.Size = new System.Drawing.Size(1234, 179);
            this.pan_display.TabIndex = 11;
            // 
            // txt_question
            // 
            this.txt_question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_question.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_question.Location = new System.Drawing.Point(3, 3);
            this.txt_question.Name = "txt_question";
            this.txt_question.ReadOnly = true;
            this.txt_question.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_question.Size = new System.Drawing.Size(1218, 173);
            this.txt_question.TabIndex = 12;
            this.txt_question.Text = "";
            this.txt_question.Visible = false;
            this.txt_question.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox_ContentsResized);
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.btn_next);
            this.pnl_bottom.Controls.Add(this.btn_begin);
            this.pnl_bottom.Controls.Add(this.btn_end);
            this.pnl_bottom.Controls.Add(this.btn_pause);
            this.pnl_bottom.Controls.Add(this.btn_previous);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 646);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1234, 55);
            this.pnl_bottom.TabIndex = 12;
            // 
            // pnl_top
            // 
            this.pnl_top.AutoSize = true;
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.lbl_exam_instructions);
            this.pnl_top.Controls.Add(this.btn_show_answer);
            this.pnl_top.Controls.Add(this.lbl_question_number);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.lbl_exam_title);
            this.pnl_top.Controls.Add(this.lbl_elapsed_time);
            this.pnl_top.Controls.Add(this.label3);
            this.pnl_top.Controls.Add(this.lbl_section_title);
            this.pnl_top.Controls.Add(this.lbl_exam_code);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1234, 89);
            this.pnl_top.TabIndex = 13;
            // 
            // pnl_middle
            // 
            this.pnl_middle.AutoScroll = true;
            this.pnl_middle.Controls.Add(this.pan_display);
            this.pnl_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_middle.Location = new System.Drawing.Point(0, 89);
            this.pnl_middle.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_middle.Name = "pnl_middle";
            this.pnl_middle.Size = new System.Drawing.Size(1234, 612);
            this.pnl_middle.TabIndex = 7;
            // 
            // Exam_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 701);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_middle);
            this.Controls.Add(this.pnl_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exam_UI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Exam Simulator";
            this.Load += new System.EventHandler(this.Exam_UI_Load);
            this.pan_display.ResumeLayout(false);
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_middle.ResumeLayout(false);
            this.pnl_middle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btn_show_answer;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_elapsed_time;
        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label lbl_exam_instructions;
        private System.Windows.Forms.Label lbl_exam_title;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_exam_code;
        private System.Windows.Forms.Label lbl_question_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_section_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel pan_display;
        private System.Windows.Forms.RichTextBox txt_question;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_middle;
    }
}