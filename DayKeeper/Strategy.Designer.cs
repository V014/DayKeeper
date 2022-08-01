namespace DayKeeper
{
    partial class Strategy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Strategy));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.update_lbl = new System.Windows.Forms.Label();
            this.lbl_update = new System.Windows.Forms.Label();
            this.panel_strategy = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.profit_txt = new System.Windows.Forms.TextBox();
            this.offset_txt = new System.Windows.Forms.TextBox();
            this.investment_txt = new System.Windows.Forms.TextBox();
            this.annual_txt = new System.Windows.Forms.TextBox();
            this.monthly_txt = new System.Windows.Forms.TextBox();
            this.daily_txt = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_offset = new System.Windows.Forms.Label();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbl_expenses = new System.Windows.Forms.Label();
            this.lbl_daily = new System.Windows.Forms.Label();
            this.lbl_investment = new System.Windows.Forms.Label();
            this.lbl_monthly = new System.Windows.Forms.Label();
            this.lbl_annual = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.chart_progress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.panel_strategy.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_progress)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(154, 9);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(142, 33);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(6, 9);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(142, 33);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.controlPanel.Controls.Add(this.update_lbl);
            this.controlPanel.Controls.Add(this.lbl_update);
            this.controlPanel.Controls.Add(this.refresh_btn);
            this.controlPanel.Controls.Add(this.save_btn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 468);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(997, 53);
            this.controlPanel.TabIndex = 2;
            // 
            // update_lbl
            // 
            this.update_lbl.AutoSize = true;
            this.update_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.update_lbl.ForeColor = System.Drawing.Color.White;
            this.update_lbl.Location = new System.Drawing.Point(439, 17);
            this.update_lbl.Name = "update_lbl";
            this.update_lbl.Size = new System.Drawing.Size(97, 18);
            this.update_lbl.TabIndex = 4;
            this.update_lbl.Text = "Date Missing!";
            // 
            // lbl_update
            // 
            this.lbl_update.AutoSize = true;
            this.lbl_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_update.ForeColor = System.Drawing.Color.White;
            this.lbl_update.Location = new System.Drawing.Point(333, 17);
            this.lbl_update.Name = "lbl_update";
            this.lbl_update.Size = new System.Drawing.Size(99, 18);
            this.lbl_update.TabIndex = 4;
            this.lbl_update.Text = "Last Updated:";
            // 
            // panel_strategy
            // 
            this.panel_strategy.AutoScroll = true;
            this.panel_strategy.Controls.Add(this.panel_left);
            this.panel_strategy.Controls.Add(this.panel_right);
            this.panel_strategy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_strategy.Location = new System.Drawing.Point(0, 0);
            this.panel_strategy.Name = "panel_strategy";
            this.panel_strategy.Size = new System.Drawing.Size(997, 468);
            this.panel_strategy.TabIndex = 5;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.Transparent;
            this.panel_left.Controls.Add(this.profit_txt);
            this.panel_left.Controls.Add(this.offset_txt);
            this.panel_left.Controls.Add(this.investment_txt);
            this.panel_left.Controls.Add(this.annual_txt);
            this.panel_left.Controls.Add(this.monthly_txt);
            this.panel_left.Controls.Add(this.daily_txt);
            this.panel_left.Controls.Add(this.lbl_title);
            this.panel_left.Controls.Add(this.lbl_offset);
            this.panel_left.Controls.Add(this.lbl_sub);
            this.panel_left.Controls.Add(this.lbl_expenses);
            this.panel_left.Controls.Add(this.lbl_daily);
            this.panel_left.Controls.Add(this.lbl_investment);
            this.panel_left.Controls.Add(this.lbl_monthly);
            this.panel_left.Controls.Add(this.lbl_annual);
            this.panel_left.Location = new System.Drawing.Point(3, 3);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(429, 455);
            this.panel_left.TabIndex = 7;
            // 
            // profit_txt
            // 
            this.profit_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.profit_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profit_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.profit_txt.ForeColor = System.Drawing.Color.Silver;
            this.profit_txt.Location = new System.Drawing.Point(167, 398);
            this.profit_txt.Name = "profit_txt";
            this.profit_txt.Size = new System.Drawing.Size(178, 17);
            this.profit_txt.TabIndex = 18;
            // 
            // offset_txt
            // 
            this.offset_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.offset_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offset_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.offset_txt.ForeColor = System.Drawing.Color.Silver;
            this.offset_txt.Location = new System.Drawing.Point(167, 350);
            this.offset_txt.Name = "offset_txt";
            this.offset_txt.Size = new System.Drawing.Size(178, 17);
            this.offset_txt.TabIndex = 18;
            // 
            // investment_txt
            // 
            this.investment_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.investment_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.investment_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.investment_txt.ForeColor = System.Drawing.Color.Silver;
            this.investment_txt.Location = new System.Drawing.Point(167, 296);
            this.investment_txt.Name = "investment_txt";
            this.investment_txt.Size = new System.Drawing.Size(178, 17);
            this.investment_txt.TabIndex = 18;
            // 
            // annual_txt
            // 
            this.annual_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.annual_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.annual_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.annual_txt.ForeColor = System.Drawing.Color.Silver;
            this.annual_txt.Location = new System.Drawing.Point(167, 241);
            this.annual_txt.Name = "annual_txt";
            this.annual_txt.Size = new System.Drawing.Size(178, 17);
            this.annual_txt.TabIndex = 18;
            // 
            // monthly_txt
            // 
            this.monthly_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.monthly_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthly_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.monthly_txt.ForeColor = System.Drawing.Color.Silver;
            this.monthly_txt.Location = new System.Drawing.Point(167, 190);
            this.monthly_txt.Name = "monthly_txt";
            this.monthly_txt.Size = new System.Drawing.Size(178, 17);
            this.monthly_txt.TabIndex = 18;
            // 
            // daily_txt
            // 
            this.daily_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.daily_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daily_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.daily_txt.ForeColor = System.Drawing.Color.Silver;
            this.daily_txt.Location = new System.Drawing.Point(167, 134);
            this.daily_txt.Name = "daily_txt";
            this.daily_txt.Size = new System.Drawing.Size(178, 17);
            this.daily_txt.TabIndex = 18;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbl_title.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_title.Location = new System.Drawing.Point(19, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(133, 36);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Strategy ";
            // 
            // lbl_offset
            // 
            this.lbl_offset.AutoSize = true;
            this.lbl_offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_offset.ForeColor = System.Drawing.Color.White;
            this.lbl_offset.Location = new System.Drawing.Point(23, 398);
            this.lbl_offset.Name = "lbl_offset";
            this.lbl_offset.Size = new System.Drawing.Size(47, 18);
            this.lbl_offset.TabIndex = 3;
            this.lbl_offset.Text = "Profit:";
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_sub.ForeColor = System.Drawing.Color.White;
            this.lbl_sub.Location = new System.Drawing.Point(22, 85);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(376, 18);
            this.lbl_sub.TabIndex = 3;
            this.lbl_sub.Text = "Plan the course of the company here well ahead of time.";
            // 
            // lbl_expenses
            // 
            this.lbl_expenses.AutoSize = true;
            this.lbl_expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_expenses.ForeColor = System.Drawing.Color.White;
            this.lbl_expenses.Location = new System.Drawing.Point(23, 350);
            this.lbl_expenses.Name = "lbl_expenses";
            this.lbl_expenses.Size = new System.Drawing.Size(52, 18);
            this.lbl_expenses.TabIndex = 3;
            this.lbl_expenses.Text = "Offset:";
            // 
            // lbl_daily
            // 
            this.lbl_daily.AutoSize = true;
            this.lbl_daily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_daily.ForeColor = System.Drawing.Color.White;
            this.lbl_daily.Location = new System.Drawing.Point(22, 134);
            this.lbl_daily.Name = "lbl_daily";
            this.lbl_daily.Size = new System.Drawing.Size(90, 18);
            this.lbl_daily.TabIndex = 3;
            this.lbl_daily.Text = "Daily Target:";
            // 
            // lbl_investment
            // 
            this.lbl_investment.AutoSize = true;
            this.lbl_investment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_investment.ForeColor = System.Drawing.Color.White;
            this.lbl_investment.Location = new System.Drawing.Point(23, 296);
            this.lbl_investment.Name = "lbl_investment";
            this.lbl_investment.Size = new System.Drawing.Size(83, 18);
            this.lbl_investment.TabIndex = 3;
            this.lbl_investment.Text = "Investment:";
            // 
            // lbl_monthly
            // 
            this.lbl_monthly.AutoSize = true;
            this.lbl_monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_monthly.ForeColor = System.Drawing.Color.White;
            this.lbl_monthly.Location = new System.Drawing.Point(22, 190);
            this.lbl_monthly.Name = "lbl_monthly";
            this.lbl_monthly.Size = new System.Drawing.Size(110, 18);
            this.lbl_monthly.TabIndex = 3;
            this.lbl_monthly.Text = "Monthly Target:";
            // 
            // lbl_annual
            // 
            this.lbl_annual.AutoSize = true;
            this.lbl_annual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_annual.ForeColor = System.Drawing.Color.White;
            this.lbl_annual.Location = new System.Drawing.Point(22, 241);
            this.lbl_annual.Name = "lbl_annual";
            this.lbl_annual.Size = new System.Drawing.Size(102, 18);
            this.lbl_annual.TabIndex = 3;
            this.lbl_annual.Text = "Annual Target:";
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.Transparent;
            this.panel_right.Controls.Add(this.chart_progress);
            this.panel_right.Controls.Add(this.label1);
            this.panel_right.Controls.Add(this.label3);
            this.panel_right.Location = new System.Drawing.Point(438, 3);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(452, 455);
            this.panel_right.TabIndex = 19;
            // 
            // chart_progress
            // 
            this.chart_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.chart_progress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_progress.BorderlineWidth = 0;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Empty;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowOffset = 6;
            this.chart_progress.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            legend2.BorderWidth = 0;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart_progress.Legends.Add(legend2);
            this.chart_progress.Location = new System.Drawing.Point(26, 106);
            this.chart_progress.Name = "chart_progress";
            this.chart_progress.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series3.BackSecondaryColor = System.Drawing.Color.DarkGreen;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend1";
            series3.Name = "Total";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ShadowOffset = 12;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series4.BackSecondaryColor = System.Drawing.Color.Red;
            series4.BorderWidth = 0;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Target";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ShadowOffset = 12;
            this.chart_progress.Series.Add(series3);
            this.chart_progress.Series.Add(series4);
            this.chart_progress.Size = new System.Drawing.Size(420, 346);
            this.chart_progress.TabIndex = 4;
            this.chart_progress.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plan the course of the company here well ahead of time.";
            // 
            // Strategy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel_strategy);
            this.Controls.Add(this.controlPanel);
            this.Name = "Strategy";
            this.Size = new System.Drawing.Size(997, 521);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.panel_strategy.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_progress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label update_lbl;
        private System.Windows.Forms.Label lbl_update;
        private System.Windows.Forms.FlowLayoutPanel panel_strategy;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.TextBox profit_txt;
        private System.Windows.Forms.TextBox offset_txt;
        private System.Windows.Forms.TextBox investment_txt;
        private System.Windows.Forms.TextBox annual_txt;
        private System.Windows.Forms.TextBox monthly_txt;
        private System.Windows.Forms.TextBox daily_txt;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_offset;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Label lbl_expenses;
        private System.Windows.Forms.Label lbl_daily;
        private System.Windows.Forms.Label lbl_investment;
        private System.Windows.Forms.Label lbl_monthly;
        private System.Windows.Forms.Label lbl_annual;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
