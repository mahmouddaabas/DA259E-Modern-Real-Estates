namespace Modern_Real_Estates
{
    partial class MainView
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
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.type_lbl = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.ComboBox();
            this.legalform_lbl = new System.Windows.Forms.Label();
            this.legalform_txt = new System.Windows.Forms.ComboBox();
            this.street_lbl = new System.Windows.Forms.Label();
            this.country_lbl = new System.Windows.Forms.Label();
            this.city_lbl = new System.Windows.Forms.Label();
            this.zip_lbl = new System.Windows.Forms.Label();
            this.street_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.zip_txt = new System.Windows.Forms.TextBox();
            this.country_txt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.specificprop_txt = new System.Windows.Forms.TextBox();
            this.specificprop_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(294, 549);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(512, 549);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(406, 549);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 2;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.list.Location = new System.Drawing.Point(-2, 1);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(831, 353);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Legal Form";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Street";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "City";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Country";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zip Code";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Specifics";
            this.columnHeader7.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add new entry";
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type_lbl.Location = new System.Drawing.Point(12, 396);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(45, 21);
            this.type_lbl.TabIndex = 6;
            this.type_lbl.Text = "Type:";
            // 
            // type_txt
            // 
            this.type_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_txt.FormattingEnabled = true;
            this.type_txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.type_txt.Items.AddRange(new object[] {
            "Warehouse",
            "Apartment",
            "Shop",
            "Villa"});
            this.type_txt.Location = new System.Drawing.Point(108, 398);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(97, 23);
            this.type_txt.TabIndex = 7;
            this.type_txt.SelectedIndexChanged += new System.EventHandler(this.type_txt_SelectedIndexChanged);
            // 
            // legalform_lbl
            // 
            this.legalform_lbl.AutoSize = true;
            this.legalform_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.legalform_lbl.Location = new System.Drawing.Point(12, 425);
            this.legalform_lbl.Name = "legalform_lbl";
            this.legalform_lbl.Size = new System.Drawing.Size(91, 21);
            this.legalform_lbl.TabIndex = 8;
            this.legalform_lbl.Text = "Legal Form:";
            // 
            // legalform_txt
            // 
            this.legalform_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.legalform_txt.FormattingEnabled = true;
            this.legalform_txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.legalform_txt.Items.AddRange(new object[] {
            "Rental",
            "Ownership",
            "Tenement"});
            this.legalform_txt.Location = new System.Drawing.Point(108, 425);
            this.legalform_txt.Name = "legalform_txt";
            this.legalform_txt.Size = new System.Drawing.Size(97, 23);
            this.legalform_txt.TabIndex = 9;
            // 
            // street_lbl
            // 
            this.street_lbl.AutoSize = true;
            this.street_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.street_lbl.Location = new System.Drawing.Point(12, 452);
            this.street_lbl.Name = "street_lbl";
            this.street_lbl.Size = new System.Drawing.Size(53, 21);
            this.street_lbl.TabIndex = 10;
            this.street_lbl.Text = "Street:";
            // 
            // country_lbl
            // 
            this.country_lbl.AutoSize = true;
            this.country_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.country_lbl.Location = new System.Drawing.Point(12, 479);
            this.country_lbl.Name = "country_lbl";
            this.country_lbl.Size = new System.Drawing.Size(69, 21);
            this.country_lbl.TabIndex = 11;
            this.country_lbl.Text = "Country:";
            // 
            // city_lbl
            // 
            this.city_lbl.AutoSize = true;
            this.city_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.city_lbl.Location = new System.Drawing.Point(12, 506);
            this.city_lbl.Name = "city_lbl";
            this.city_lbl.Size = new System.Drawing.Size(40, 21);
            this.city_lbl.TabIndex = 12;
            this.city_lbl.Text = "City:";
            // 
            // zip_lbl
            // 
            this.zip_lbl.AutoSize = true;
            this.zip_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zip_lbl.Location = new System.Drawing.Point(12, 539);
            this.zip_lbl.Name = "zip_lbl";
            this.zip_lbl.Size = new System.Drawing.Size(75, 21);
            this.zip_lbl.TabIndex = 13;
            this.zip_lbl.Text = "Zip Code:";
            // 
            // street_txt
            // 
            this.street_txt.Location = new System.Drawing.Point(108, 450);
            this.street_txt.Name = "street_txt";
            this.street_txt.Size = new System.Drawing.Size(100, 23);
            this.street_txt.TabIndex = 14;
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(108, 508);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(100, 23);
            this.city_txt.TabIndex = 16;
            // 
            // zip_txt
            // 
            this.zip_txt.Location = new System.Drawing.Point(108, 537);
            this.zip_txt.Name = "zip_txt";
            this.zip_txt.Size = new System.Drawing.Size(100, 23);
            this.zip_txt.TabIndex = 17;
            // 
            // country_txt
            // 
            this.country_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_txt.FormattingEnabled = true;
            this.country_txt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.country_txt.Location = new System.Drawing.Point(108, 477);
            this.country_txt.Name = "country_txt";
            this.country_txt.Size = new System.Drawing.Size(97, 23);
            this.country_txt.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // specificprop_txt
            // 
            this.specificprop_txt.Location = new System.Drawing.Point(285, 396);
            this.specificprop_txt.Name = "specificprop_txt";
            this.specificprop_txt.Size = new System.Drawing.Size(100, 23);
            this.specificprop_txt.TabIndex = 20;
            // 
            // specificprop_lbl
            // 
            this.specificprop_lbl.AutoSize = true;
            this.specificprop_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specificprop_lbl.Location = new System.Drawing.Point(211, 396);
            this.specificprop_lbl.Name = "specificprop_lbl";
            this.specificprop_lbl.Size = new System.Drawing.Size(45, 21);
            this.specificprop_lbl.TabIndex = 21;
            this.specificprop_lbl.Text = "Type:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 599);
            this.Controls.Add(this.specificprop_lbl);
            this.Controls.Add(this.specificprop_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.country_txt);
            this.Controls.Add(this.zip_txt);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.street_txt);
            this.Controls.Add(this.zip_lbl);
            this.Controls.Add(this.city_lbl);
            this.Controls.Add(this.country_lbl);
            this.Controls.Add(this.street_lbl);
            this.Controls.Add(this.legalform_txt);
            this.Controls.Add(this.legalform_lbl);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.type_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "MainView";
            this.Text = "Modern Real Estates by Mahmoud Daabas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add_btn;
        private Button delete_btn;
        private Button change_btn;
        private ListView list;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Label type_lbl;
        private ComboBox type_txt;
        private Label legalform_lbl;
        private ComboBox legalform_txt;
        private Label street_lbl;
        private Label country_lbl;
        private Label city_lbl;
        private Label zip_lbl;
        private TextBox street_txt;
        private TextBox city_txt;
        private TextBox zip_txt;
        private ComboBox country_txt;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private Button button1;
        private ColumnHeader columnHeader7;
        private TextBox specificprop_txt;
        private Label specificprop_lbl;
    }
}