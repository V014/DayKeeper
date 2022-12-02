namespace DayKeeper
{
    partial class Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.records_panel = new System.Windows.Forms.Panel();
            this.data_records = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.panel_inputs = new System.Windows.Forms.Panel();
            this.txt_sales = new System.Windows.Forms.TextBox();
            this.txt_fuel = new System.Windows.Forms.TextBox();
            this.txt_crew = new System.Windows.Forms.TextBox();
            this.txt_mileage = new System.Windows.Forms.TextBox();
            this.insertDatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.notes_txt = new System.Windows.Forms.RichTextBox();
            this.records_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_records)).BeginInit();
            this.panel_inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // records_panel
            // 
            this.records_panel.Controls.Add(this.data_records);
            this.records_panel.Controls.Add(this.panel_inputs);
            this.records_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records_panel.Location = new System.Drawing.Point(0, 0);
            this.records_panel.Name = "records_panel";
            this.records_panel.Padding = new System.Windows.Forms.Padding(10);
            this.records_panel.Size = new System.Drawing.Size(944, 514);
            this.records_panel.TabIndex = 0;
            // 
            // data_records
            // 
            this.data_records.AllowUserToAddRows = false;
            this.data_records.AllowUserToDeleteRows = false;
            this.data_records.AllowUserToResizeRows = false;
            this.data_records.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_records.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.data_records.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_records.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_records.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_records.ColumnHeadersHeight = 30;
            this.data_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_records.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_records.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_records.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.data_records.Location = new System.Drawing.Point(229, 10);
            this.data_records.Name = "data_records";
            this.data_records.ReadOnly = true;
            this.data_records.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_records.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_records.RowHeadersVisible = false;
            this.data_records.RowTemplate.Height = 50;
            this.data_records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_records.Size = new System.Drawing.Size(705, 494);
            this.data_records.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(100, 398);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 30);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apply.Location = new System.Drawing.Point(6, 398);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(90, 30);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // panel_inputs
            // 
            this.panel_inputs.BackColor = System.Drawing.Color.Transparent;
            this.panel_inputs.Controls.Add(this.btn_cancel);
            this.panel_inputs.Controls.Add(this.notes_txt);
            this.panel_inputs.Controls.Add(this.btn_apply);
            this.panel_inputs.Controls.Add(this.insertDatePicker);
            this.panel_inputs.Controls.Add(this.txt_sales);
            this.panel_inputs.Controls.Add(this.txt_fuel);
            this.panel_inputs.Controls.Add(this.txt_crew);
            this.panel_inputs.Controls.Add(this.txt_mileage);
            this.panel_inputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_inputs.Location = new System.Drawing.Point(10, 10);
            this.panel_inputs.Name = "panel_inputs";
            this.panel_inputs.Size = new System.Drawing.Size(219, 494);
            this.panel_inputs.TabIndex = 1;
            // 
            // txt_sales
            // 
            this.txt_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sales.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sales.ForeColor = System.Drawing.Color.Silver;
            this.txt_sales.Location = new System.Drawing.Point(3, 134);
            this.txt_sales.Multiline = true;
            this.txt_sales.Name = "txt_sales";
            this.txt_sales.Size = new System.Drawing.Size(187, 24);
            this.txt_sales.TabIndex = 3;
            this.txt_sales.Text = "Income";
            // 
            // txt_fuel
            // 
            this.txt_fuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_fuel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fuel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fuel.ForeColor = System.Drawing.Color.Silver;
            this.txt_fuel.Location = new System.Drawing.Point(3, 91);
            this.txt_fuel.Multiline = true;
            this.txt_fuel.Name = "txt_fuel";
            this.txt_fuel.Size = new System.Drawing.Size(187, 24);
            this.txt_fuel.TabIndex = 2;
            this.txt_fuel.Text = "Fuel";
            // 
            // txt_crew
            // 
            this.txt_crew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_crew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_crew.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_crew.ForeColor = System.Drawing.Color.Silver;
            this.txt_crew.Location = new System.Drawing.Point(3, 46);
            this.txt_crew.Multiline = true;
            this.txt_crew.Name = "txt_crew";
            this.txt_crew.Size = new System.Drawing.Size(187, 24);
            this.txt_crew.TabIndex = 1;
            this.txt_crew.Text = "Crew";
            // 
            // txt_mileage
            // 
            this.txt_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txt_mileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mileage.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mileage.ForeColor = System.Drawing.Color.Silver;
            this.txt_mileage.Location = new System.Drawing.Point(3, 4);
            this.txt_mileage.Multiline = true;
            this.txt_mileage.Name = "txt_mileage";
            this.txt_mileage.Size = new System.Drawing.Size(187, 24);
            this.txt_mileage.TabIndex = 0;
            this.txt_mileage.Text = "Mileage";
            // 
            // insertDatePicker
            // 
            this.insertDatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.insertDatePicker.BorderRadius = 1;
            this.insertDatePicker.Color = System.Drawing.Color.PaleGreen;
            this.insertDatePicker.CustomFormat = "";
            this.insertDatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.insertDatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.insertDatePicker.DisabledColor = System.Drawing.Color.Gray;
            this.insertDatePicker.DisplayWeekNumbers = false;
            this.insertDatePicker.DPHeight = 0;
            this.insertDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.insertDatePicker.FillDatePicker = false;
            this.insertDatePicker.Font = new System.Drawing.Font("Roboto", 9F);
            this.insertDatePicker.ForeColor = System.Drawing.Color.Gray;
            this.insertDatePicker.Icon = ((System.Drawing.Image)(resources.GetObject("insertDatePicker.Icon")));
            this.insertDatePicker.IconColor = System.Drawing.Color.Gray;
            this.insertDatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.insertDatePicker.LeftTextMargin = 5;
            this.insertDatePicker.Location = new System.Drawing.Point(3, 175);
            this.insertDatePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.insertDatePicker.Name = "insertDatePicker";
            this.insertDatePicker.Size = new System.Drawing.Size(187, 32);
            this.insertDatePicker.TabIndex = 22;
            // 
            // notes_txt
            // 
            this.notes_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.notes_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notes_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.notes_txt.ForeColor = System.Drawing.Color.White;
            this.notes_txt.Location = new System.Drawing.Point(3, 225);
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.Size = new System.Drawing.Size(187, 167);
            this.notes_txt.TabIndex = 23;
            this.notes_txt.Text = "";
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.records_panel);
            this.Name = "Records";
            this.Size = new System.Drawing.Size(944, 514);
            this.records_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_records)).EndInit();
            this.panel_inputs.ResumeLayout(false);
            this.panel_inputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel records_panel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Panel panel_inputs;
        private System.Windows.Forms.TextBox txt_sales;
        private System.Windows.Forms.TextBox txt_fuel;
        private System.Windows.Forms.TextBox txt_crew;
        private System.Windows.Forms.TextBox txt_mileage;
        private Bunifu.UI.WinForms.BunifuDatePicker insertDatePicker;
        private System.Windows.Forms.RichTextBox notes_txt;
        private System.Windows.Forms.DataGridView data_records;
    }
}
