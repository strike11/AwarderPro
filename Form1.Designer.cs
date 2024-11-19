namespace AwarderPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            top_1 = new System.Windows.Forms.Panel();
            app_label = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            to_db_button = new System.Windows.Forms.Button();
            git_btn = new System.Windows.Forms.Button();
            gen_btn = new System.Windows.Forms.Button();
            pan_table = new System.Windows.Forms.Panel();
            saveimg_btn = new System.Windows.Forms.Button();
            addtodb_btn = new System.Windows.Forms.Button();
            input_desc = new System.Windows.Forms.TextBox();
            input_company = new System.Windows.Forms.TextBox();
            input_certtype = new System.Windows.Forms.TextBox();
            input_date = new System.Windows.Forms.TextBox();
            input_issuedby = new System.Windows.Forms.TextBox();
            input_surname = new System.Windows.Forms.TextBox();
            input_name = new System.Windows.Forms.TextBox();
            btn_export = new System.Windows.Forms.Button();
            btn_import = new System.Windows.Forms.Button();
            btn_remove = new System.Windows.Forms.Button();
            btn_add = new System.Windows.Forms.Button();
            db_table = new System.Windows.Forms.DataGridView();
            ID_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Surname_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Certificate_typle_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cert_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Issued_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comp_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Certificate_construstor_pan = new System.Windows.Forms.Panel();
            certificate_image = new System.Windows.Forms.PictureBox();
            top_1.SuspendLayout();
            panel1.SuspendLayout();
            pan_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)db_table).BeginInit();
            Certificate_construstor_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)certificate_image).BeginInit();
            SuspendLayout();
            // 
            // top_1
            // 
            top_1.BackColor = System.Drawing.Color.FromArgb(35, 98, 133);
            top_1.Controls.Add(app_label);
            top_1.Dock = System.Windows.Forms.DockStyle.Top;
            top_1.Location = new System.Drawing.Point(0, 0);
            top_1.Name = "top_1";
            top_1.Size = new System.Drawing.Size(1270, 30);
            top_1.TabIndex = 0;
            // 
            // app_label
            // 
            app_label.AutoSize = true;
            app_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            app_label.ForeColor = System.Drawing.Color.White;
            app_label.Location = new System.Drawing.Point(7, 4);
            app_label.Name = "app_label";
            app_label.Size = new System.Drawing.Size(93, 21);
            app_label.TabIndex = 0;
            app_label.Text = "AwarderPro";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(23, 66, 90);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(to_db_button);
            panel1.Controls.Add(git_btn);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1270, 50);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(92, 144, 174);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(132, 11);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(117, 30);
            button1.TabIndex = 2;
            button1.Text = "Constructor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // to_db_button
            // 
            to_db_button.BackColor = System.Drawing.Color.FromArgb(92, 144, 174);
            to_db_button.FlatAppearance.BorderSize = 0;
            to_db_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            to_db_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            to_db_button.ForeColor = System.Drawing.Color.White;
            to_db_button.Location = new System.Drawing.Point(12, 11);
            to_db_button.Name = "to_db_button";
            to_db_button.Size = new System.Drawing.Size(103, 30);
            to_db_button.TabIndex = 1;
            to_db_button.Text = "Database";
            to_db_button.UseVisualStyleBackColor = false;
            to_db_button.Click += to_db_button_Click;
            // 
            // git_btn
            // 
            git_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            git_btn.BackColor = System.Drawing.Color.FromArgb(92, 144, 174);
            git_btn.FlatAppearance.BorderSize = 0;
            git_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            git_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            git_btn.ForeColor = System.Drawing.Color.White;
            git_btn.Location = new System.Drawing.Point(1179, 11);
            git_btn.Name = "git_btn";
            git_btn.Size = new System.Drawing.Size(75, 30);
            git_btn.TabIndex = 0;
            git_btn.Text = "GitHub";
            git_btn.UseVisualStyleBackColor = false;
            git_btn.Click += git_btn_Click;
            // 
            // gen_btn
            // 
            gen_btn.BackColor = System.Drawing.Color.FromArgb(92, 164, 174);
            gen_btn.FlatAppearance.BorderSize = 0;
            gen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gen_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gen_btn.ForeColor = System.Drawing.Color.White;
            gen_btn.Location = new System.Drawing.Point(15, 275);
            gen_btn.Name = "gen_btn";
            gen_btn.Size = new System.Drawing.Size(101, 33);
            gen_btn.TabIndex = 1;
            gen_btn.Text = "Generate...";
            gen_btn.UseVisualStyleBackColor = false;
            gen_btn.Click += button2_Click;
            // 
            // pan_table
            // 
            pan_table.BackColor = System.Drawing.Color.FromArgb(23, 58, 78);
            pan_table.Controls.Add(saveimg_btn);
            pan_table.Controls.Add(addtodb_btn);
            pan_table.Controls.Add(gen_btn);
            pan_table.Controls.Add(input_desc);
            pan_table.Controls.Add(input_company);
            pan_table.Controls.Add(input_certtype);
            pan_table.Controls.Add(input_date);
            pan_table.Controls.Add(input_issuedby);
            pan_table.Controls.Add(input_surname);
            pan_table.Controls.Add(input_name);
            pan_table.Controls.Add(btn_export);
            pan_table.Controls.Add(btn_import);
            pan_table.Controls.Add(btn_remove);
            pan_table.Controls.Add(btn_add);
            pan_table.Dock = System.Windows.Forms.DockStyle.Right;
            pan_table.Location = new System.Drawing.Point(1026, 80);
            pan_table.Name = "pan_table";
            pan_table.Size = new System.Drawing.Size(244, 603);
            pan_table.TabIndex = 2;
            // 
            // saveimg_btn
            // 
            saveimg_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            saveimg_btn.BackColor = System.Drawing.Color.FromArgb(50, 168, 111);
            saveimg_btn.FlatAppearance.BorderSize = 0;
            saveimg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            saveimg_btn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            saveimg_btn.ForeColor = System.Drawing.Color.White;
            saveimg_btn.Location = new System.Drawing.Point(15, 314);
            saveimg_btn.Name = "saveimg_btn";
            saveimg_btn.Size = new System.Drawing.Size(213, 37);
            saveimg_btn.TabIndex = 15;
            saveimg_btn.Text = "Save Image";
            saveimg_btn.UseVisualStyleBackColor = false;
            saveimg_btn.Click += saveimg_btn_Click;
            // 
            // addtodb_btn
            // 
            addtodb_btn.BackColor = System.Drawing.Color.FromArgb(92, 144, 174);
            addtodb_btn.FlatAppearance.BorderSize = 0;
            addtodb_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addtodb_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addtodb_btn.ForeColor = System.Drawing.Color.White;
            addtodb_btn.Location = new System.Drawing.Point(127, 275);
            addtodb_btn.Name = "addtodb_btn";
            addtodb_btn.Size = new System.Drawing.Size(101, 33);
            addtodb_btn.TabIndex = 14;
            addtodb_btn.Text = "Add to DB";
            addtodb_btn.UseVisualStyleBackColor = false;
            addtodb_btn.Click += addtodb_btn_Click;
            // 
            // input_desc
            // 
            input_desc.BackColor = System.Drawing.Color.FromArgb(48, 64, 84);
            input_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            input_desc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            input_desc.ForeColor = System.Drawing.Color.White;
            input_desc.Location = new System.Drawing.Point(16, 236);
            input_desc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            input_desc.MaxLength = 256;
            input_desc.Name = "input_desc";
            input_desc.Size = new System.Drawing.Size(213, 25);
            input_desc.TabIndex = 13;
            input_desc.Text = "Description";
            input_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_company
            // 
            input_company.BackColor = System.Drawing.Color.FromArgb(48, 64, 84);
            input_company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            input_company.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            input_company.ForeColor = System.Drawing.Color.White;
            input_company.Location = new System.Drawing.Point(15, 182);
            input_company.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            input_company.MaxLength = 256;
            input_company.Name = "input_company";
            input_company.Size = new System.Drawing.Size(213, 25);
            input_company.TabIndex = 12;
            input_company.Text = "Company";
            input_company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_certtype
            // 
            input_certtype.BackColor = System.Drawing.Color.FromArgb(48, 64, 84);
            input_certtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            input_certtype.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            input_certtype.ForeColor = System.Drawing.Color.White;
            input_certtype.Location = new System.Drawing.Point(16, 95);
            input_certtype.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            input_certtype.MaxLength = 256;
            input_certtype.Name = "input_certtype";
            input_certtype.Size = new System.Drawing.Size(213, 25);
            input_certtype.TabIndex = 11;
            input_certtype.Text = "Certificate type";
            input_certtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_date
            // 
            input_date.BackColor = System.Drawing.Color.FromArgb(48, 64, 84);
            input_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            input_date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            input_date.ForeColor = System.Drawing.Color.White;
            input_date.Location = new System.Drawing.Point(15, 124);
            input_date.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            input_date.MaxLength = 256;
            input_date.Name = "input_date";
            input_date.Size = new System.Drawing.Size(213, 25);
            input_date.TabIndex = 10;
            input_date.Text = "Date of issue";
            input_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_issuedby
            // 
            input_issuedby.BackColor = System.Drawing.Color.FromArgb(48, 64, 84);
            input_issuedby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            input_issuedby.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            input_issuedby.ForeColor = System.Drawing.Color.White;
            input_issuedby.Location = new System.Drawing.Point(16, 153);
            input_issuedby.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            input_issuedby.MaxLength = 256;
            input_issuedby.Name = "input_issuedby";
            input_issuedby.Size = new System.Drawing.Size(213, 25);
            input_issuedby.TabIndex = 9;
            input_issuedby.Text = "Issued by";
            input_issuedby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_surname
            // 
            input_surname.BackColor = System.Drawing.Color.FromArgb(48, 64, 84);
            input_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            input_surname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            input_surname.ForeColor = System.Drawing.Color.White;
            input_surname.Location = new System.Drawing.Point(15, 66);
            input_surname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            input_surname.MaxLength = 256;
            input_surname.Name = "input_surname";
            input_surname.Size = new System.Drawing.Size(213, 25);
            input_surname.TabIndex = 8;
            input_surname.Text = "Surname";
            input_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_name
            // 
            input_name.BackColor = System.Drawing.Color.FromArgb(48, 64, 84);
            input_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            input_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            input_name.ForeColor = System.Drawing.Color.White;
            input_name.Location = new System.Drawing.Point(15, 37);
            input_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            input_name.MaxLength = 256;
            input_name.Name = "input_name";
            input_name.Size = new System.Drawing.Size(213, 25);
            input_name.TabIndex = 5;
            input_name.Text = "Name";
            input_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_export
            // 
            btn_export.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_export.BackColor = System.Drawing.Color.FromArgb(92, 164, 174);
            btn_export.FlatAppearance.BorderSize = 0;
            btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_export.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_export.ForeColor = System.Drawing.Color.White;
            btn_export.Location = new System.Drawing.Point(15, 534);
            btn_export.Name = "btn_export";
            btn_export.Size = new System.Drawing.Size(213, 45);
            btn_export.TabIndex = 4;
            btn_export.Text = "Export";
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Visible = false;
            btn_export.Click += btn_export_Click;
            // 
            // btn_import
            // 
            btn_import.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_import.BackColor = System.Drawing.Color.FromArgb(92, 144, 174);
            btn_import.FlatAppearance.BorderSize = 0;
            btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_import.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_import.ForeColor = System.Drawing.Color.White;
            btn_import.Location = new System.Drawing.Point(15, 483);
            btn_import.Name = "btn_import";
            btn_import.Size = new System.Drawing.Size(213, 45);
            btn_import.TabIndex = 3;
            btn_import.Text = "Import";
            btn_import.UseVisualStyleBackColor = false;
            btn_import.Visible = false;
            btn_import.Click += btn_import_Click;
            // 
            // btn_remove
            // 
            btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_remove.BackColor = System.Drawing.Color.FromArgb(92, 144, 174);
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_remove.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_remove.ForeColor = System.Drawing.Color.White;
            btn_remove.Location = new System.Drawing.Point(15, 432);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new System.Drawing.Size(213, 45);
            btn_remove.TabIndex = 2;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Visible = false;
            // 
            // btn_add
            // 
            btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_add.BackColor = System.Drawing.Color.FromArgb(92, 144, 174);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_add.ForeColor = System.Drawing.Color.White;
            btn_add.Location = new System.Drawing.Point(15, 381);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(213, 45);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Visible = false;
            btn_add.Click += btn_add_Click;
            // 
            // db_table
            // 
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            db_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            db_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            db_table.BackgroundColor = System.Drawing.Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(35, 98, 133);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            db_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            db_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            db_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_column, Name_column, Surname_column, Certificate_typle_column, cert_date_column, Issued_col, Comp_col });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(35, 98, 133);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            db_table.DefaultCellStyle = dataGridViewCellStyle3;
            db_table.Dock = System.Windows.Forms.DockStyle.Fill;
            db_table.GridColor = System.Drawing.Color.FromArgb(217, 217, 217);
            db_table.Location = new System.Drawing.Point(0, 80);
            db_table.Name = "db_table";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            db_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            db_table.RowTemplate.Height = 25;
            db_table.Size = new System.Drawing.Size(1026, 603);
            db_table.TabIndex = 3;
            db_table.Visible = false;
            // 
            // ID_column
            // 
            ID_column.FillWeight = 30F;
            ID_column.HeaderText = "ID";
            ID_column.Name = "ID_column";
            ID_column.ReadOnly = true;
            // 
            // Name_column
            // 
            Name_column.HeaderText = "Name";
            Name_column.Name = "Name_column";
            // 
            // Surname_column
            // 
            Surname_column.HeaderText = "Surname";
            Surname_column.Name = "Surname_column";
            // 
            // Certificate_typle_column
            // 
            Certificate_typle_column.HeaderText = "Certificate type";
            Certificate_typle_column.Name = "Certificate_typle_column";
            // 
            // cert_date_column
            // 
            cert_date_column.HeaderText = "Date of issue";
            cert_date_column.Name = "cert_date_column";
            // 
            // Issued_col
            // 
            Issued_col.HeaderText = "Issued by";
            Issued_col.Name = "Issued_col";
            // 
            // Comp_col
            // 
            Comp_col.HeaderText = "Company";
            Comp_col.Name = "Comp_col";
            // 
            // Certificate_construstor_pan
            // 
            Certificate_construstor_pan.BackColor = System.Drawing.Color.FromArgb(10, 29, 39);
            Certificate_construstor_pan.Controls.Add(certificate_image);
            Certificate_construstor_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            Certificate_construstor_pan.Location = new System.Drawing.Point(0, 80);
            Certificate_construstor_pan.Name = "Certificate_construstor_pan";
            Certificate_construstor_pan.Size = new System.Drawing.Size(1026, 603);
            Certificate_construstor_pan.TabIndex = 4;
            // 
            // certificate_image
            // 
            certificate_image.BackColor = System.Drawing.Color.Black;
            certificate_image.Dock = System.Windows.Forms.DockStyle.Fill;
            certificate_image.Location = new System.Drawing.Point(0, 0);
            certificate_image.Name = "certificate_image";
            certificate_image.Size = new System.Drawing.Size(1026, 603);
            certificate_image.TabIndex = 0;
            certificate_image.TabStop = false;
            certificate_image.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1270, 683);
            Controls.Add(Certificate_construstor_pan);
            Controls.Add(db_table);
            Controls.Add(pan_table);
            Controls.Add(panel1);
            Controls.Add(top_1);
            Name = "Form1";
            Text = "Awarder Pro";
            top_1.ResumeLayout(false);
            top_1.PerformLayout();
            panel1.ResumeLayout(false);
            pan_table.ResumeLayout(false);
            pan_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)db_table).EndInit();
            Certificate_construstor_pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)certificate_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel top_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pan_table;
        private System.Windows.Forms.DataGridView db_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certificate_typle_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn cert_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issued_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comp_col;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_company;
        private System.Windows.Forms.TextBox input_certtype;
        private System.Windows.Forms.TextBox input_date;
        private System.Windows.Forms.TextBox input_issuedby;
        private System.Windows.Forms.TextBox input_surname;
        private System.Windows.Forms.Label app_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button to_db_button;
        private System.Windows.Forms.Button git_btn;
        private System.Windows.Forms.Panel Certificate_construstor_pan;
        private System.Windows.Forms.Button gen_btn;
        public System.Windows.Forms.PictureBox certificate_image;
        private System.Windows.Forms.TextBox input_desc;
        private System.Windows.Forms.Button addtodb_btn;
        private System.Windows.Forms.Button saveimg_btn;
    }
}
