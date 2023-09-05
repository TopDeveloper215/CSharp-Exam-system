namespace Simulator
{
    partial class Score_Sheet
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score_Sheet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_retake = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.chr_display_score = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_show_breakdown = new System.Windows.Forms.DataGridView();
            this.lbl_candidate_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_exam_number = new System.Windows.Forms.Label();
            this.lbl_elapsed_time = new System.Windows.Forms.Label();
            this.lbl_time_allowed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_print_score = new System.Windows.Forms.Button();
            this.pnt_prv_dlg = new System.Windows.Forms.PrintPreviewDialog();
            this.pnt_doc = new System.Drawing.Printing.PrintDocument();
            this.lbl_ExamTitle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_passingScore = new System.Windows.Forms.Label();
            this.lbl_yourScore = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chr_display_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_breakdown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examination Score Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CANDIDATE:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATE:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EXAM CODE:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIME ALLOWED:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ELAPSED TIME:";
            // 
            // btn_retake
            // 
            this.btn_retake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_retake.Location = new System.Drawing.Point(23, 645);
            this.btn_retake.Name = "btn_retake";
            this.btn_retake.Size = new System.Drawing.Size(75, 23);
            this.btn_retake.TabIndex = 7;
            this.btn_retake.Text = "Retake";
            this.btn_retake.UseVisualStyleBackColor = true;
            this.btn_retake.Click += new System.EventHandler(this.btn_retake_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(829, 645);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // chr_display_score
            // 
            this.chr_display_score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chr_display_score.BackColor = System.Drawing.SystemColors.Control;
            customLabel1.FromPosition = 0.5D;
            customLabel1.Text = "Required Score";
            customLabel1.ToPosition = 1.5D;
            customLabel2.FromPosition = -0.5D;
            customLabel2.Text = "Your Score";
            customLabel2.ToPosition = 0.5D;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Maximum = 2D;
            chartArea1.AxisY.Maximum = 1000D;
            chartArea1.Name = "ChartArea1";
            this.chr_display_score.ChartAreas.Add(chartArea1);
            this.chr_display_score.Location = new System.Drawing.Point(183, 211);
            this.chr_display_score.Name = "chr_display_score";
            this.chr_display_score.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chr_display_score.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.Green};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Name = "Required Score";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Name = "Score";
            this.chr_display_score.Series.Add(series1);
            this.chr_display_score.Series.Add(series2);
            this.chr_display_score.Size = new System.Drawing.Size(542, 171);
            this.chr_display_score.TabIndex = 10;
            this.chr_display_score.Text = "chart1";
            // 
            // dgv_show_breakdown
            // 
            this.dgv_show_breakdown.AllowUserToAddRows = false;
            this.dgv_show_breakdown.AllowUserToDeleteRows = false;
            this.dgv_show_breakdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_show_breakdown.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_show_breakdown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show_breakdown.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_show_breakdown.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_show_breakdown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_show_breakdown.ColumnHeadersHeight = 25;
            this.dgv_show_breakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_show_breakdown.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.section,
            this.number,
            this.accuracy,
            this.PercCorrect});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_show_breakdown.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_show_breakdown.Location = new System.Drawing.Point(163, 424);
            this.dgv_show_breakdown.Name = "dgv_show_breakdown";
            this.dgv_show_breakdown.ReadOnly = true;
            this.dgv_show_breakdown.RowHeadersVisible = false;
            this.dgv_show_breakdown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_show_breakdown.Size = new System.Drawing.Size(595, 173);
            this.dgv_show_breakdown.TabIndex = 11;
            // 
            // lbl_candidate_name
            // 
            this.lbl_candidate_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_candidate_name.AutoSize = true;
            this.lbl_candidate_name.Location = new System.Drawing.Point(301, 111);
            this.lbl_candidate_name.Name = "lbl_candidate_name";
            this.lbl_candidate_name.Size = new System.Drawing.Size(71, 13);
            this.lbl_candidate_name.TabIndex = 12;
            this.lbl_candidate_name.Text = "NameOfCand";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(266, 144);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(61, 13);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "2020-20-20";
            // 
            // lbl_exam_number
            // 
            this.lbl_exam_number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_exam_number.AutoSize = true;
            this.lbl_exam_number.Location = new System.Drawing.Point(305, 176);
            this.lbl_exam_number.Name = "lbl_exam_number";
            this.lbl_exam_number.Size = new System.Drawing.Size(25, 13);
            this.lbl_exam_number.TabIndex = 14;
            this.lbl_exam_number.Text = "123";
            // 
            // lbl_elapsed_time
            // 
            this.lbl_elapsed_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_elapsed_time.AutoSize = true;
            this.lbl_elapsed_time.Location = new System.Drawing.Point(606, 144);
            this.lbl_elapsed_time.Name = "lbl_elapsed_time";
            this.lbl_elapsed_time.Size = new System.Drawing.Size(19, 13);
            this.lbl_elapsed_time.TabIndex = 16;
            this.lbl_elapsed_time.Text = "00";
            this.lbl_elapsed_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_time_allowed
            // 
            this.lbl_time_allowed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_time_allowed.AutoSize = true;
            this.lbl_time_allowed.Location = new System.Drawing.Point(606, 111);
            this.lbl_time_allowed.Name = "lbl_time_allowed";
            this.lbl_time_allowed.Size = new System.Drawing.Size(19, 13);
            this.lbl_time_allowed.TabIndex = 15;
            this.lbl_time_allowed.Text = "00";
            this.lbl_time_allowed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(632, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "GRADE :";
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(696, 385);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(71, 13);
            this.lbl_status.TabIndex = 18;
            this.lbl_status.Text = "passed/failed";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "min(s)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "min(s)";
            // 
            // btn_print_score
            // 
            this.btn_print_score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_print_score.Location = new System.Drawing.Point(127, 645);
            this.btn_print_score.Name = "btn_print_score";
            this.btn_print_score.Size = new System.Drawing.Size(75, 23);
            this.btn_print_score.TabIndex = 21;
            this.btn_print_score.Text = "Print";
            this.btn_print_score.UseVisualStyleBackColor = true;
            this.btn_print_score.Click += new System.EventHandler(this.btn_print_score_Click);
            // 
            // pnt_prv_dlg
            // 
            this.pnt_prv_dlg.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pnt_prv_dlg.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pnt_prv_dlg.ClientSize = new System.Drawing.Size(400, 300);
            this.pnt_prv_dlg.Document = this.pnt_doc;
            this.pnt_prv_dlg.Enabled = true;
            this.pnt_prv_dlg.Icon = ((System.Drawing.Icon)(resources.GetObject("pnt_prv_dlg.Icon")));
            this.pnt_prv_dlg.Name = "pnt_prv_dlg";
            this.pnt_prv_dlg.ShowIcon = false;
            this.pnt_prv_dlg.Visible = false;
            // 
            // pnt_doc
            // 
            this.pnt_doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pnt_doc_PrintPage);
            // 
            // lbl_ExamTitle
            // 
            this.lbl_ExamTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExamTitle.Location = new System.Drawing.Point(12, 31);
            this.lbl_ExamTitle.Name = "lbl_ExamTitle";
            this.lbl_ExamTitle.Size = new System.Drawing.Size(892, 22);
            this.lbl_ExamTitle.TabIndex = 22;
            this.lbl_ExamTitle.Text = "Exam Title";
            this.lbl_ExamTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(222, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "PASSING SCORE :";
            // 
            // lbl_passingScore
            // 
            this.lbl_passingScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_passingScore.AutoSize = true;
            this.lbl_passingScore.Location = new System.Drawing.Point(336, 385);
            this.lbl_passingScore.Name = "lbl_passingScore";
            this.lbl_passingScore.Size = new System.Drawing.Size(24, 13);
            this.lbl_passingScore.TabIndex = 24;
            this.lbl_passingScore.Text = "0/0";
            // 
            // lbl_yourScore
            // 
            this.lbl_yourScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_yourScore.AutoSize = true;
            this.lbl_yourScore.Location = new System.Drawing.Point(518, 385);
            this.lbl_yourScore.Name = "lbl_yourScore";
            this.lbl_yourScore.Size = new System.Drawing.Size(24, 13);
            this.lbl_yourScore.TabIndex = 26;
            this.lbl_yourScore.Text = "0/0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(424, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "YOUR SCORE :";
            // 
            // section
            // 
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            this.section.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.section.Width = 345;
            // 
            // number
            // 
            this.number.HeaderText = "Questions";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 75;
            // 
            // accuracy
            // 
            this.accuracy.HeaderText = "Accuracy";
            this.accuracy.Name = "accuracy";
            this.accuracy.ReadOnly = true;
            this.accuracy.Width = 75;
            // 
            // PercCorrect
            // 
            this.PercCorrect.HeaderText = "Percent Correct";
            this.PercCorrect.Name = "PercCorrect";
            this.PercCorrect.ReadOnly = true;
            // 
            // Score_Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 680);
            this.Controls.Add(this.lbl_yourScore);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_passingScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_ExamTitle);
            this.Controls.Add(this.btn_print_score);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_elapsed_time);
            this.Controls.Add(this.lbl_time_allowed);
            this.Controls.Add(this.lbl_exam_number);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_candidate_name);
            this.Controls.Add(this.dgv_show_breakdown);
            this.Controls.Add(this.chr_display_score);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_retake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Score_Sheet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.chr_display_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_breakdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_retake;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_display_score;
        private System.Windows.Forms.DataGridView dgv_show_breakdown;
        private System.Windows.Forms.Label lbl_candidate_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_exam_number;
        private System.Windows.Forms.Label lbl_elapsed_time;
        private System.Windows.Forms.Label lbl_time_allowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_print_score;
        private System.Windows.Forms.PrintPreviewDialog pnt_prv_dlg;
        private System.Drawing.Printing.PrintDocument pnt_doc;
        private System.Windows.Forms.Label lbl_ExamTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_passingScore;
        private System.Windows.Forms.Label lbl_yourScore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercCorrect;
    }
}