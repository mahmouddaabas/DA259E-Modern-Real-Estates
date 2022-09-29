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
            this.uploadImgBtn = new System.Windows.Forms.Button();
            this.specificproptwo_txt = new System.Windows.Forms.TextBox();
            this.specificproptwo_lbl = new System.Windows.Forms.Label();
            this.specificpropone_lbl = new System.Windows.Forms.Label();
            this.specificpropone_txt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.XML = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_From_XML = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_To_XML = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.columnHeader8});
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.Location = new System.Drawing.Point(-2, 27);
            this.list.Name = "list";
            this.list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list.Size = new System.Drawing.Size(831, 327);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "All Estates";
            this.columnHeader8.Width = 1000;
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
            "Villa",
            "Townhouse",
            "Hospital",
            "School",
            "University"});
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
            // uploadImgBtn
            // 
            this.uploadImgBtn.Location = new System.Drawing.Point(48, 566);
            this.uploadImgBtn.Name = "uploadImgBtn";
            this.uploadImgBtn.Size = new System.Drawing.Size(101, 23);
            this.uploadImgBtn.TabIndex = 19;
            this.uploadImgBtn.Text = "Upload Image";
            this.uploadImgBtn.UseVisualStyleBackColor = true;
            this.uploadImgBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // specificproptwo_txt
            // 
            this.specificproptwo_txt.Location = new System.Drawing.Point(284, 427);
            this.specificproptwo_txt.Name = "specificproptwo_txt";
            this.specificproptwo_txt.Size = new System.Drawing.Size(100, 23);
            this.specificproptwo_txt.TabIndex = 20;
            // 
            // specificproptwo_lbl
            // 
            this.specificproptwo_lbl.AutoSize = true;
            this.specificproptwo_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specificproptwo_lbl.Location = new System.Drawing.Point(211, 429);
            this.specificproptwo_lbl.Name = "specificproptwo_lbl";
            this.specificproptwo_lbl.Size = new System.Drawing.Size(45, 21);
            this.specificproptwo_lbl.TabIndex = 21;
            this.specificproptwo_lbl.Text = "Type:";
            // 
            // specificpropone_lbl
            // 
            this.specificpropone_lbl.AutoSize = true;
            this.specificpropone_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specificpropone_lbl.Location = new System.Drawing.Point(211, 396);
            this.specificpropone_lbl.Name = "specificpropone_lbl";
            this.specificpropone_lbl.Size = new System.Drawing.Size(45, 21);
            this.specificpropone_lbl.TabIndex = 22;
            this.specificpropone_lbl.Text = "Type:";
            // 
            // specificpropone_txt
            // 
            this.specificpropone_txt.Location = new System.Drawing.Point(284, 398);
            this.specificpropone_txt.Name = "specificpropone_txt";
            this.specificpropone_txt.Size = new System.Drawing.Size(100, 23);
            this.specificpropone_txt.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripMenu
            // 
            this.stripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.New,
            this.Save,
            this.SaveAs,
            this.XML,
            this.Exit});
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(37, 20);
            this.stripMenu.Text = "File";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(180, 22);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(180, 22);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(180, 22);
            this.SaveAs.Text = "Save as..";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // XML
            // 
            this.XML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import_From_XML,
            this.Export_To_XML});
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(180, 22);
            this.XML.Text = "XML";
            // 
            // Import_From_XML
            // 
            this.Import_From_XML.Name = "Import_From_XML";
            this.Import_From_XML.Size = new System.Drawing.Size(172, 22);
            this.Import_From_XML.Text = "Import_From_XML";
            // 
            // Export_To_XML
            // 
            this.Export_To_XML.Name = "Export_To_XML";
            this.Export_To_XML.Size = new System.Drawing.Size(172, 22);
            this.Export_To_XML.Text = "Export_To_XML";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 599);
            this.Controls.Add(this.specificpropone_txt);
            this.Controls.Add(this.specificpropone_lbl);
            this.Controls.Add(this.specificproptwo_lbl);
            this.Controls.Add(this.specificproptwo_txt);
            this.Controls.Add(this.uploadImgBtn);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Modern Real Estates by Mahmoud Daabas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add_btn;
        private Button delete_btn;
        private Button change_btn;
        private ListView list;
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
        private ColumnHeader columnHeader8;
        private Button uploadImgBtn;
        private TextBox specificproptwo_txt;
        private Label specificproptwo_lbl;
        private Label specificpropone_lbl;
        private TextBox specificpropone_txt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenu;
        private ToolStripMenuItem Open;
        private ToolStripMenuItem New;
        private ToolStripMenuItem Save;
        private ToolStripMenuItem SaveAs;
        private ToolStripMenuItem XML;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem Import_From_XML;
        private ToolStripMenuItem Export_To_XML;
    }
}