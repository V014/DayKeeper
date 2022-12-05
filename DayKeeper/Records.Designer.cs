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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.records_panel = new System.Windows.Forms.Panel();
            this.data_records = new System.Windows.Forms.DataGridView();
            this.panel_inputs = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.txt_mileage = new MetroFramework.Controls.MetroTextBox();
            this.txt_crew = new MetroFramework.Controls.MetroTextBox();
            this.txt_fuel = new MetroFramework.Controls.MetroTextBox();
            this.txt_income = new MetroFramework.Controls.MetroTextBox();
            this.date_input = new MetroFramework.Controls.MetroDateTime();
            this.txt_notes = new MetroFramework.Controls.MetroTextBox();
            this.lbl_records = new System.Windows.Forms.Label();
            this.context_records = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.records_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_records)).BeginInit();
            this.panel_inputs.SuspendLayout();
            this.context_records.SuspendLayout();
            this.SuspendLayout();
            // 
            // records_panel
            // 
            this.records_panel.BackColor = System.Drawing.Color.Transparent;
            this.records_panel.Controls.Add(this.data_records);
            this.records_panel.Controls.Add(this.panel_inputs);
            this.records_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.records_panel.Location = new System.Drawing.Point(0, 0);
            this.records_panel.Name = "records_panel";
            this.records_panel.Padding = new System.Windows.Forms.Padding(5);
            this.records_panel.Size = new System.Drawing.Size(944, 514);
            this.records_panel.TabIndex = 0;
            // 
            // data_records
            // 
            this.data_records.AllowUserToAddRows = false;
            this.data_records.AllowUserToDeleteRows = false;
            this.data_records.AllowUserToResizeColumns = false;
            this.data_records.AllowUserToResizeRows = false;
            this.data_records.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data_records.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
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
            this.data_records.ContextMenuStrip = this.context_records;
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
            this.data_records.Location = new System.Drawing.Point(218, 5);
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
            this.data_records.Size = new System.Drawing.Size(721, 504);
            this.data_records.TabIndex = 0;
            // 
            // panel_inputs
            // 
            this.panel_inputs.BackColor = System.Drawing.Color.Transparent;
            this.panel_inputs.Controls.Add(this.lbl_records);
            this.panel_inputs.Controls.Add(this.date_input);
            this.panel_inputs.Controls.Add(this.txt_notes);
            this.panel_inputs.Controls.Add(this.txt_income);
            this.panel_inputs.Controls.Add(this.txt_fuel);
            this.panel_inputs.Controls.Add(this.txt_crew);
            this.panel_inputs.Controls.Add(this.txt_mileage);
            this.panel_inputs.Controls.Add(this.btn_cancel);
            this.panel_inputs.Controls.Add(this.btn_apply);
            this.panel_inputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_inputs.Location = new System.Drawing.Point(5, 5);
            this.panel_inputs.Name = "panel_inputs";
            this.panel_inputs.Size = new System.Drawing.Size(213, 504);
            this.panel_inputs.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(106, 336);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 30);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btn_apply.ForeColor = System.Drawing.Color.White;
            this.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apply.Location = new System.Drawing.Point(9, 336);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(90, 30);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // txt_mileage
            // 
            this.txt_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // 
            // 
            this.txt_mileage.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_mileage.CustomButton.FlatAppearance.BorderSize = 0;
            this.txt_mileage.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_mileage.CustomButton.Image = null;
            this.txt_mileage.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_mileage.CustomButton.Name = "";
            this.txt_mileage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_mileage.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_mileage.CustomButton.TabIndex = 1;
            this.txt_mileage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mileage.CustomButton.UseSelectable = true;
            this.txt_mileage.CustomButton.UseVisualStyleBackColor = false;
            this.txt_mileage.CustomButton.Visible = false;
            this.txt_mileage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_mileage.ForeColor = System.Drawing.Color.Gray;
            this.txt_mileage.Lines = new string[0];
            this.txt_mileage.Location = new System.Drawing.Point(9, 44);
            this.txt_mileage.MaxLength = 32767;
            this.txt_mileage.Name = "txt_mileage";
            this.txt_mileage.PasswordChar = '\0';
            this.txt_mileage.PromptText = "Mileage";
            this.txt_mileage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mileage.SelectedText = "";
            this.txt_mileage.SelectionLength = 0;
            this.txt_mileage.SelectionStart = 0;
            this.txt_mileage.ShortcutsEnabled = true;
            this.txt_mileage.ShowClearButton = true;
            this.txt_mileage.Size = new System.Drawing.Size(187, 23);
            this.txt_mileage.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_mileage.TabIndex = 24;
            this.txt_mileage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_mileage.UseSelectable = true;
            this.txt_mileage.WaterMark = "Mileage";
            this.txt_mileage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mileage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_crew
            // 
            this.txt_crew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // 
            // 
            this.txt_crew.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_crew.CustomButton.FlatAppearance.BorderSize = 0;
            this.txt_crew.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_crew.CustomButton.Image = null;
            this.txt_crew.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_crew.CustomButton.Name = "";
            this.txt_crew.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_crew.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_crew.CustomButton.TabIndex = 1;
            this.txt_crew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_crew.CustomButton.UseSelectable = true;
            this.txt_crew.CustomButton.UseVisualStyleBackColor = false;
            this.txt_crew.CustomButton.Visible = false;
            this.txt_crew.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_crew.ForeColor = System.Drawing.Color.Gray;
            this.txt_crew.Lines = new string[0];
            this.txt_crew.Location = new System.Drawing.Point(9, 73);
            this.txt_crew.MaxLength = 32767;
            this.txt_crew.Name = "txt_crew";
            this.txt_crew.PasswordChar = '\0';
            this.txt_crew.PromptText = "Crew";
            this.txt_crew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_crew.SelectedText = "";
            this.txt_crew.SelectionLength = 0;
            this.txt_crew.SelectionStart = 0;
            this.txt_crew.ShortcutsEnabled = true;
            this.txt_crew.ShowClearButton = true;
            this.txt_crew.Size = new System.Drawing.Size(187, 23);
            this.txt_crew.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_crew.TabIndex = 24;
            this.txt_crew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_crew.UseSelectable = true;
            this.txt_crew.WaterMark = "Crew";
            this.txt_crew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_crew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_fuel
            // 
            this.txt_fuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // 
            // 
            this.txt_fuel.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_fuel.CustomButton.FlatAppearance.BorderSize = 0;
            this.txt_fuel.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_fuel.CustomButton.Image = null;
            this.txt_fuel.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_fuel.CustomButton.Name = "";
            this.txt_fuel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fuel.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_fuel.CustomButton.TabIndex = 1;
            this.txt_fuel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fuel.CustomButton.UseSelectable = true;
            this.txt_fuel.CustomButton.UseVisualStyleBackColor = false;
            this.txt_fuel.CustomButton.Visible = false;
            this.txt_fuel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_fuel.ForeColor = System.Drawing.Color.Gray;
            this.txt_fuel.Lines = new string[0];
            this.txt_fuel.Location = new System.Drawing.Point(9, 102);
            this.txt_fuel.MaxLength = 32767;
            this.txt_fuel.Name = "txt_fuel";
            this.txt_fuel.PasswordChar = '\0';
            this.txt_fuel.PromptText = "Fuel";
            this.txt_fuel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fuel.SelectedText = "";
            this.txt_fuel.SelectionLength = 0;
            this.txt_fuel.SelectionStart = 0;
            this.txt_fuel.ShortcutsEnabled = true;
            this.txt_fuel.ShowClearButton = true;
            this.txt_fuel.Size = new System.Drawing.Size(187, 23);
            this.txt_fuel.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_fuel.TabIndex = 24;
            this.txt_fuel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_fuel.UseSelectable = true;
            this.txt_fuel.WaterMark = "Fuel";
            this.txt_fuel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fuel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_income
            // 
            this.txt_income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // 
            // 
            this.txt_income.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_income.CustomButton.FlatAppearance.BorderSize = 0;
            this.txt_income.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_income.CustomButton.Image = null;
            this.txt_income.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_income.CustomButton.Name = "";
            this.txt_income.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_income.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_income.CustomButton.TabIndex = 1;
            this.txt_income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_income.CustomButton.UseSelectable = true;
            this.txt_income.CustomButton.UseVisualStyleBackColor = false;
            this.txt_income.CustomButton.Visible = false;
            this.txt_income.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_income.ForeColor = System.Drawing.Color.Gray;
            this.txt_income.Lines = new string[0];
            this.txt_income.Location = new System.Drawing.Point(9, 131);
            this.txt_income.MaxLength = 32767;
            this.txt_income.Name = "txt_income";
            this.txt_income.PasswordChar = '\0';
            this.txt_income.PromptText = "Income";
            this.txt_income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_income.SelectedText = "";
            this.txt_income.SelectionLength = 0;
            this.txt_income.SelectionStart = 0;
            this.txt_income.ShortcutsEnabled = true;
            this.txt_income.ShowClearButton = true;
            this.txt_income.Size = new System.Drawing.Size(187, 23);
            this.txt_income.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_income.TabIndex = 24;
            this.txt_income.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_income.UseSelectable = true;
            this.txt_income.WaterMark = "Income";
            this.txt_income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // date_input
            // 
            this.date_input.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.date_input.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.date_input.Location = new System.Drawing.Point(9, 160);
            this.date_input.MinimumSize = new System.Drawing.Size(0, 25);
            this.date_input.Name = "date_input";
            this.date_input.Size = new System.Drawing.Size(187, 25);
            this.date_input.Style = MetroFramework.MetroColorStyle.Green;
            this.date_input.TabIndex = 25;
            this.date_input.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_notes
            // 
            this.txt_notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // 
            // 
            this.txt_notes.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txt_notes.CustomButton.FlatAppearance.BorderSize = 0;
            this.txt_notes.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_notes.CustomButton.Image = null;
            this.txt_notes.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.txt_notes.CustomButton.Name = "";
            this.txt_notes.CustomButton.Size = new System.Drawing.Size(137, 137);
            this.txt_notes.CustomButton.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_notes.CustomButton.TabIndex = 1;
            this.txt_notes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_notes.CustomButton.UseSelectable = true;
            this.txt_notes.CustomButton.UseVisualStyleBackColor = false;
            this.txt_notes.CustomButton.Visible = false;
            this.txt_notes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_notes.ForeColor = System.Drawing.Color.Gray;
            this.txt_notes.Lines = new string[0];
            this.txt_notes.Location = new System.Drawing.Point(9, 191);
            this.txt_notes.MaxLength = 32767;
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.PasswordChar = '\0';
            this.txt_notes.PromptText = "Notes";
            this.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_notes.SelectedText = "";
            this.txt_notes.SelectionLength = 0;
            this.txt_notes.SelectionStart = 0;
            this.txt_notes.ShortcutsEnabled = true;
            this.txt_notes.ShowClearButton = true;
            this.txt_notes.Size = new System.Drawing.Size(187, 139);
            this.txt_notes.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_notes.TabIndex = 24;
            this.txt_notes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_notes.UseSelectable = true;
            this.txt_notes.WaterMark = "Notes";
            this.txt_notes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_notes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_records
            // 
            this.lbl_records.AutoSize = true;
            this.lbl_records.Font = new System.Drawing.Font("Roboto", 16F);
            this.lbl_records.ForeColor = System.Drawing.Color.Gray;
            this.lbl_records.Location = new System.Drawing.Point(4, 12);
            this.lbl_records.Name = "lbl_records";
            this.lbl_records.Size = new System.Drawing.Size(129, 27);
            this.lbl_records.TabIndex = 26;
            this.lbl_records.Text = "Add records";
            // 
            // context_records
            // 
            this.context_records.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.context_records.Name = "context_records";
            this.context_records.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.records_panel);
            this.Name = "Records";
            this.Size = new System.Drawing.Size(944, 514);
            this.records_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_records)).EndInit();
            this.panel_inputs.ResumeLayout(false);
            this.panel_inputs.PerformLayout();
            this.context_records.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel records_panel;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Panel panel_inputs;
        private System.Windows.Forms.DataGridView data_records;
        private MetroFramework.Controls.MetroTextBox txt_mileage;
        private MetroFramework.Controls.MetroDateTime date_input;
        private MetroFramework.Controls.MetroTextBox txt_income;
        private MetroFramework.Controls.MetroTextBox txt_fuel;
        private MetroFramework.Controls.MetroTextBox txt_crew;
        private MetroFramework.Controls.MetroTextBox txt_notes;
        private System.Windows.Forms.Label lbl_records;
        private System.Windows.Forms.ContextMenuStrip context_records;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}
