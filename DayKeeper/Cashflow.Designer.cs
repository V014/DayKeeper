namespace DayKeeper
{
    partial class Cashflow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashflow));
            this.month_cmb = new System.Windows.Forms.ComboBox();
            this.year_cmb = new System.Windows.Forms.ComboBox();
            this.chart_calendar_txt = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.hint_lbl = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.chartPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sales_lbl = new System.Windows.Forms.Label();
            this.expenditureIcon = new System.Windows.Forms.PictureBox();
            this.sumIcon = new System.Windows.Forms.PictureBox();
            this.expenditure_txt = new System.Windows.Forms.Label();
            this.sum_lbl = new System.Windows.Forms.Label();
            this.sales_txt = new System.Windows.Forms.Label();
            this.expenditure_lbl = new System.Windows.Forms.Label();
            this.loss_txt = new System.Windows.Forms.Label();
            this.salesIcon = new System.Windows.Forms.PictureBox();
            this.panel_losses = new System.Windows.Forms.Panel();
            this.daysworked_lbl = new System.Windows.Forms.Label();
            this.daysoff_lbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.breakdowns_txt = new System.Windows.Forms.Label();
            this.daysoff_txt = new System.Windows.Forms.Label();
            this.daysworked_txt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.breakdown_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesIcon)).BeginInit();
            this.panel_losses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // month_cmb
            // 
            this.month_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.month_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.month_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.month_cmb.ForeColor = System.Drawing.Color.White;
            this.month_cmb.FormattingEnabled = true;
            this.month_cmb.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May ",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_cmb.Location = new System.Drawing.Point(12, 13);
            this.month_cmb.Name = "month_cmb";
            this.month_cmb.Size = new System.Drawing.Size(130, 28);
            this.month_cmb.TabIndex = 6;
            this.month_cmb.Text = "Month";
            this.month_cmb.SelectedIndexChanged += new System.EventHandler(this.month_cmb_SelectedIndexChanged);
            // 
            // year_cmb
            // 
            this.year_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.year_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.year_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.year_cmb.ForeColor = System.Drawing.Color.White;
            this.year_cmb.FormattingEnabled = true;
            this.year_cmb.Items.AddRange(new object[] {
            "2022"});
            this.year_cmb.Location = new System.Drawing.Point(160, 13);
            this.year_cmb.Name = "year_cmb";
            this.year_cmb.Size = new System.Drawing.Size(130, 28);
            this.year_cmb.TabIndex = 6;
            this.year_cmb.Text = "Year";
            this.year_cmb.SelectedIndexChanged += new System.EventHandler(this.month_cmb_SelectedIndexChanged);
            // 
            // chart_calendar_txt
            // 
            this.chart_calendar_txt.AutoSize = true;
            this.chart_calendar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chart_calendar_txt.ForeColor = System.Drawing.Color.White;
            this.chart_calendar_txt.Location = new System.Drawing.Point(310, 18);
            this.chart_calendar_txt.Name = "chart_calendar_txt";
            this.chart_calendar_txt.Size = new System.Drawing.Size(172, 18);
            this.chart_calendar_txt.TabIndex = 7;
            this.chart_calendar_txt.Text = "Select using the calendar";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.hint_lbl);
            this.controlPanel.Controls.Add(this.year_cmb);
            this.controlPanel.Controls.Add(this.month_cmb);
            this.controlPanel.Controls.Add(this.chart_calendar_txt);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 463);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(944, 51);
            this.controlPanel.TabIndex = 11;
            // 
            // hint_lbl
            // 
            this.hint_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hint_lbl.AutoSize = true;
            this.hint_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.hint_lbl.ForeColor = System.Drawing.Color.PaleGreen;
            this.hint_lbl.Location = new System.Drawing.Point(560, 18);
            this.hint_lbl.Name = "hint_lbl";
            this.hint_lbl.Size = new System.Drawing.Size(284, 18);
            this.hint_lbl.TabIndex = 8;
            this.hint_lbl.Text = "Now showing current month\'s collections.";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.chartPanel);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(944, 463);
            this.panel_main.TabIndex = 13;
            // 
            // chartPanel
            // 
            this.chartPanel.ColumnCount = 2;
            this.chartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.chartPanel.Controls.Add(this.panel1, 0, 1);
            this.chartPanel.Controls.Add(this.panel_losses, 1, 1);
            this.chartPanel.Controls.Add(this.chart2, 1, 0);
            this.chartPanel.Controls.Add(this.chart1, 0, 0);
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(0, 0);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.RowCount = 2;
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.chartPanel.Size = new System.Drawing.Size(944, 463);
            this.chartPanel.TabIndex = 12;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart2.BorderlineColor = System.Drawing.Color.Empty;
            this.chart2.BorderlineWidth = 0;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowOffset = 20;
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(475, 3);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(42)))), ((int)(((byte)(38)))))};
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BackSecondaryColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Expenditures";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ShadowOffset = 6;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(466, 364);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.Empty;
            this.chart1.BorderlineWidth = 0;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Empty;
            this.chart1.BorderSkin.BorderWidth = 0;
            chartArea2.Area3DStyle.Inclination = 2;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 20;
            chartArea2.Area3DStyle.Rotation = 5;
            chartArea2.Area3DStyle.WallWidth = 20;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 94F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 3F;
            chartArea2.ShadowOffset = 20;
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series2.BackSecondaryColor = System.Drawing.Color.DarkGreen;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.LabelForeColor = System.Drawing.Color.Empty;
            series2.Legend = "Legend1";
            series2.Name = "Sales";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ShadowOffset = 6;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(466, 364);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // sales_lbl
            // 
            this.sales_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sales_lbl.AutoSize = true;
            this.sales_lbl.BackColor = System.Drawing.Color.Transparent;
            this.sales_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sales_lbl.ForeColor = System.Drawing.Color.Gray;
            this.sales_lbl.Location = new System.Drawing.Point(307, 11);
            this.sales_lbl.Name = "sales_lbl";
            this.sales_lbl.Size = new System.Drawing.Size(41, 15);
            this.sales_lbl.TabIndex = 30;
            this.sales_lbl.Text = "Sales:";
            // 
            // expenditureIcon
            // 
            this.expenditureIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expenditureIcon.BackColor = System.Drawing.Color.Transparent;
            this.expenditureIcon.Image = ((System.Drawing.Image)(resources.GetObject("expenditureIcon.Image")));
            this.expenditureIcon.Location = new System.Drawing.Point(291, 37);
            this.expenditureIcon.Name = "expenditureIcon";
            this.expenditureIcon.Size = new System.Drawing.Size(13, 15);
            this.expenditureIcon.TabIndex = 36;
            this.expenditureIcon.TabStop = false;
            // 
            // sumIcon
            // 
            this.sumIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sumIcon.BackColor = System.Drawing.Color.Transparent;
            this.sumIcon.Image = ((System.Drawing.Image)(resources.GetObject("sumIcon.Image")));
            this.sumIcon.Location = new System.Drawing.Point(291, 61);
            this.sumIcon.Name = "sumIcon";
            this.sumIcon.Size = new System.Drawing.Size(13, 15);
            this.sumIcon.TabIndex = 37;
            this.sumIcon.TabStop = false;
            // 
            // expenditure_txt
            // 
            this.expenditure_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expenditure_txt.AutoSize = true;
            this.expenditure_txt.BackColor = System.Drawing.Color.Transparent;
            this.expenditure_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.expenditure_txt.ForeColor = System.Drawing.Color.Gray;
            this.expenditure_txt.Location = new System.Drawing.Point(393, 37);
            this.expenditure_txt.Name = "expenditure_txt";
            this.expenditure_txt.Size = new System.Drawing.Size(14, 15);
            this.expenditure_txt.TabIndex = 31;
            this.expenditure_txt.Text = "0";
            // 
            // sum_lbl
            // 
            this.sum_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sum_lbl.AutoSize = true;
            this.sum_lbl.BackColor = System.Drawing.Color.Transparent;
            this.sum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sum_lbl.ForeColor = System.Drawing.Color.Gray;
            this.sum_lbl.Location = new System.Drawing.Point(307, 61);
            this.sum_lbl.Name = "sum_lbl";
            this.sum_lbl.Size = new System.Drawing.Size(36, 15);
            this.sum_lbl.TabIndex = 32;
            this.sum_lbl.Text = "Sum:";
            // 
            // sales_txt
            // 
            this.sales_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sales_txt.AutoSize = true;
            this.sales_txt.BackColor = System.Drawing.Color.Transparent;
            this.sales_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sales_txt.ForeColor = System.Drawing.Color.SeaGreen;
            this.sales_txt.Location = new System.Drawing.Point(393, 12);
            this.sales_txt.Name = "sales_txt";
            this.sales_txt.Size = new System.Drawing.Size(14, 15);
            this.sales_txt.TabIndex = 33;
            this.sales_txt.Text = "0";
            // 
            // expenditure_lbl
            // 
            this.expenditure_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expenditure_lbl.AutoSize = true;
            this.expenditure_lbl.BackColor = System.Drawing.Color.Transparent;
            this.expenditure_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.expenditure_lbl.ForeColor = System.Drawing.Color.Gray;
            this.expenditure_lbl.Location = new System.Drawing.Point(310, 37);
            this.expenditure_lbl.Name = "expenditure_lbl";
            this.expenditure_lbl.Size = new System.Drawing.Size(80, 15);
            this.expenditure_lbl.TabIndex = 34;
            this.expenditure_lbl.Text = "Expendeture:";
            // 
            // loss_txt
            // 
            this.loss_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loss_txt.AutoSize = true;
            this.loss_txt.BackColor = System.Drawing.Color.Transparent;
            this.loss_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.loss_txt.ForeColor = System.Drawing.Color.Gray;
            this.loss_txt.Location = new System.Drawing.Point(393, 62);
            this.loss_txt.Name = "loss_txt";
            this.loss_txt.Size = new System.Drawing.Size(14, 15);
            this.loss_txt.TabIndex = 35;
            this.loss_txt.Text = "0";
            // 
            // salesIcon
            // 
            this.salesIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.salesIcon.BackColor = System.Drawing.Color.Transparent;
            this.salesIcon.Image = ((System.Drawing.Image)(resources.GetObject("salesIcon.Image")));
            this.salesIcon.Location = new System.Drawing.Point(291, 11);
            this.salesIcon.Name = "salesIcon";
            this.salesIcon.Size = new System.Drawing.Size(13, 15);
            this.salesIcon.TabIndex = 38;
            this.salesIcon.TabStop = false;
            // 
            // panel_losses
            // 
            this.panel_losses.AutoSize = true;
            this.panel_losses.Controls.Add(this.daysworked_lbl);
            this.panel_losses.Controls.Add(this.daysoff_lbl);
            this.panel_losses.Controls.Add(this.pictureBox3);
            this.panel_losses.Controls.Add(this.breakdowns_txt);
            this.panel_losses.Controls.Add(this.daysoff_txt);
            this.panel_losses.Controls.Add(this.daysworked_txt);
            this.panel_losses.Controls.Add(this.pictureBox2);
            this.panel_losses.Controls.Add(this.breakdown_lbl);
            this.panel_losses.Controls.Add(this.pictureBox1);
            this.panel_losses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_losses.Location = new System.Drawing.Point(475, 373);
            this.panel_losses.Name = "panel_losses";
            this.panel_losses.Size = new System.Drawing.Size(466, 87);
            this.panel_losses.TabIndex = 4;
            // 
            // daysworked_lbl
            // 
            this.daysworked_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.daysworked_lbl.AutoSize = true;
            this.daysworked_lbl.BackColor = System.Drawing.Color.Transparent;
            this.daysworked_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.daysworked_lbl.ForeColor = System.Drawing.Color.Gray;
            this.daysworked_lbl.Location = new System.Drawing.Point(284, 10);
            this.daysworked_lbl.Name = "daysworked_lbl";
            this.daysworked_lbl.Size = new System.Drawing.Size(80, 15);
            this.daysworked_lbl.TabIndex = 39;
            this.daysworked_lbl.Text = "Days worked:";
            // 
            // daysoff_lbl
            // 
            this.daysoff_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.daysoff_lbl.AutoSize = true;
            this.daysoff_lbl.BackColor = System.Drawing.Color.Transparent;
            this.daysoff_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.daysoff_lbl.ForeColor = System.Drawing.Color.Gray;
            this.daysoff_lbl.Location = new System.Drawing.Point(284, 60);
            this.daysoff_lbl.Name = "daysoff_lbl";
            this.daysoff_lbl.Size = new System.Drawing.Size(53, 15);
            this.daysoff_lbl.TabIndex = 40;
            this.daysoff_lbl.Text = "Days off:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(268, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 15);
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // breakdowns_txt
            // 
            this.breakdowns_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.breakdowns_txt.AutoSize = true;
            this.breakdowns_txt.BackColor = System.Drawing.Color.Transparent;
            this.breakdowns_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.breakdowns_txt.ForeColor = System.Drawing.Color.Gray;
            this.breakdowns_txt.Location = new System.Drawing.Point(370, 36);
            this.breakdowns_txt.Name = "breakdowns_txt";
            this.breakdowns_txt.Size = new System.Drawing.Size(14, 15);
            this.breakdowns_txt.TabIndex = 41;
            this.breakdowns_txt.Text = "0";
            // 
            // daysoff_txt
            // 
            this.daysoff_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.daysoff_txt.AutoSize = true;
            this.daysoff_txt.BackColor = System.Drawing.Color.Transparent;
            this.daysoff_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.daysoff_txt.ForeColor = System.Drawing.Color.Gray;
            this.daysoff_txt.Location = new System.Drawing.Point(370, 61);
            this.daysoff_txt.Name = "daysoff_txt";
            this.daysoff_txt.Size = new System.Drawing.Size(14, 15);
            this.daysoff_txt.TabIndex = 44;
            this.daysoff_txt.Text = "0";
            // 
            // daysworked_txt
            // 
            this.daysworked_txt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.daysworked_txt.AutoSize = true;
            this.daysworked_txt.BackColor = System.Drawing.Color.Transparent;
            this.daysworked_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.daysworked_txt.ForeColor = System.Drawing.Color.SeaGreen;
            this.daysworked_txt.Location = new System.Drawing.Point(370, 11);
            this.daysworked_txt.Name = "daysworked_txt";
            this.daysworked_txt.Size = new System.Drawing.Size(14, 15);
            this.daysworked_txt.TabIndex = 42;
            this.daysworked_txt.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 15);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // breakdown_lbl
            // 
            this.breakdown_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.breakdown_lbl.AutoSize = true;
            this.breakdown_lbl.BackColor = System.Drawing.Color.Transparent;
            this.breakdown_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.breakdown_lbl.ForeColor = System.Drawing.Color.Gray;
            this.breakdown_lbl.Location = new System.Drawing.Point(287, 36);
            this.breakdown_lbl.Name = "breakdown_lbl";
            this.breakdown_lbl.Size = new System.Drawing.Size(78, 15);
            this.breakdown_lbl.TabIndex = 43;
            this.breakdown_lbl.Text = "Breakdowns:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 15);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sales_lbl);
            this.panel1.Controls.Add(this.expenditureIcon);
            this.panel1.Controls.Add(this.salesIcon);
            this.panel1.Controls.Add(this.loss_txt);
            this.panel1.Controls.Add(this.sumIcon);
            this.panel1.Controls.Add(this.expenditure_lbl);
            this.panel1.Controls.Add(this.sales_txt);
            this.panel1.Controls.Add(this.expenditure_txt);
            this.panel1.Controls.Add(this.sum_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 87);
            this.panel1.TabIndex = 3;
            // 
            // Cashflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.controlPanel);
            this.Name = "Cashflow";
            this.Size = new System.Drawing.Size(944, 514);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.chartPanel.ResumeLayout(false);
            this.chartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesIcon)).EndInit();
            this.panel_losses.ResumeLayout(false);
            this.panel_losses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox month_cmb;
        private System.Windows.Forms.ComboBox year_cmb;
        private System.Windows.Forms.Label chart_calendar_txt;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel chartPanel;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label hint_lbl;
        private System.Windows.Forms.Label sales_lbl;
        private System.Windows.Forms.PictureBox expenditureIcon;
        private System.Windows.Forms.PictureBox sumIcon;
        private System.Windows.Forms.Label expenditure_txt;
        private System.Windows.Forms.Label sum_lbl;
        private System.Windows.Forms.Label sales_txt;
        private System.Windows.Forms.Label expenditure_lbl;
        private System.Windows.Forms.Label loss_txt;
        private System.Windows.Forms.PictureBox salesIcon;
        private System.Windows.Forms.Panel panel_losses;
        private System.Windows.Forms.Label daysworked_lbl;
        private System.Windows.Forms.Label daysoff_lbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label breakdowns_txt;
        private System.Windows.Forms.Label daysoff_txt;
        private System.Windows.Forms.Label daysworked_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label breakdown_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
