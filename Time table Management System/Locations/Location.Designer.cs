
namespace Time_table_Management_System
{
    partial class Location
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loc_tabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.viewloc_tab = new System.Windows.Forms.TabPage();
            this.locationview_panel = new System.Windows.Forms.Panel();
            this.search_by_cmb = new MetroFramework.Controls.MetroComboBox();
            this.search_txt_box = new MetroFramework.Controls.MetroTextBox();
            this.loc_dgridv = new System.Windows.Forms.DataGridView();
            this.addloc_tab = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.clr_btn = new MetroFramework.Controls.MetroButton();
            this.addloc_btn = new MetroFramework.Controls.MetroButton();
            this.capacity_cmb = new System.Windows.Forms.NumericUpDown();
            this.roomtype_cmb = new MetroFramework.Controls.MetroComboBox();
            this.room_cmb = new MetroFramework.Controls.MetroComboBox();
            this.building_cmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.editloc_tab = new System.Windows.Forms.TabPage();
            this.editloc_panel = new MetroFramework.Controls.MetroPanel();
            this.edit_building_txt_box = new MetroFramework.Controls.MetroTextBox();
            this.delete_btn = new MetroFramework.Controls.MetroButton();
            this.editloc_btn = new MetroFramework.Controls.MetroButton();
            this.editcap_cmb = new System.Windows.Forms.NumericUpDown();
            this.room_type_txt_box = new MetroFramework.Controls.MetroComboBox();
            this.editroom_cmb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Locations = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Hwbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.loc_tabcontrol.SuspendLayout();
            this.viewloc_tab.SuspendLayout();
            this.locationview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loc_dgridv)).BeginInit();
            this.addloc_tab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity_cmb)).BeginInit();
            this.editloc_tab.SuspendLayout();
            this.editloc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editcap_cmb)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.loc_tabcontrol);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(117, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 592);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loc_tabcontrol
            // 
            this.loc_tabcontrol.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.loc_tabcontrol.Controls.Add(this.viewloc_tab);
            this.loc_tabcontrol.Controls.Add(this.addloc_tab);
            this.loc_tabcontrol.Controls.Add(this.editloc_tab);
            this.loc_tabcontrol.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.loc_tabcontrol.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.loc_tabcontrol.Location = new System.Drawing.Point(76, 66);
            this.loc_tabcontrol.Name = "loc_tabcontrol";
            this.loc_tabcontrol.SelectedIndex = 1;
            this.loc_tabcontrol.Size = new System.Drawing.Size(788, 461);
            this.loc_tabcontrol.Style = MetroFramework.MetroColorStyle.Silver;
            this.loc_tabcontrol.TabIndex = 4;
            this.loc_tabcontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loc_tabcontrol.UseCustomBackColor = true;
            this.loc_tabcontrol.UseCustomForeColor = true;
            this.loc_tabcontrol.UseSelectable = true;
            this.loc_tabcontrol.UseStyleColors = true;
            // 
            // viewloc_tab
            // 
            this.viewloc_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewloc_tab.Controls.Add(this.locationview_panel);
            this.viewloc_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewloc_tab.Location = new System.Drawing.Point(4, 37);
            this.viewloc_tab.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.viewloc_tab.Name = "viewloc_tab";
            this.viewloc_tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.viewloc_tab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewloc_tab.Size = new System.Drawing.Size(780, 420);
            this.viewloc_tab.TabIndex = 0;
            this.viewloc_tab.Text = "View Locations";
            this.viewloc_tab.UseVisualStyleBackColor = true;
            // 
            // locationview_panel
            // 
            this.locationview_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.locationview_panel.Controls.Add(this.search_by_cmb);
            this.locationview_panel.Controls.Add(this.search_txt_box);
            this.locationview_panel.Controls.Add(this.loc_dgridv);
            this.locationview_panel.Location = new System.Drawing.Point(-1, -1);
            this.locationview_panel.Name = "locationview_panel";
            this.locationview_panel.Size = new System.Drawing.Size(779, 419);
            this.locationview_panel.TabIndex = 0;
            this.locationview_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.locationview_panel_Paint);
            // 
            // search_by_cmb
            // 
            this.search_by_cmb.FormattingEnabled = true;
            this.search_by_cmb.ItemHeight = 23;
            this.search_by_cmb.Items.AddRange(new object[] {
            "Building",
            "Room",
            "Capacity",
            "Room Type"});
            this.search_by_cmb.Location = new System.Drawing.Point(250, 23);
            this.search_by_cmb.Name = "search_by_cmb";
            this.search_by_cmb.PromptText = "Search By...";
            this.search_by_cmb.Size = new System.Drawing.Size(138, 29);
            this.search_by_cmb.TabIndex = 19;
            this.search_by_cmb.UseSelectable = true;
            this.search_by_cmb.SelectedIndexChanged += new System.EventHandler(this.search_by_cmb_SelectedIndexChanged);
            // 
            // search_txt_box
            // 
            // 
            // 
            // 
            this.search_txt_box.CustomButton.Image = null;
            this.search_txt_box.CustomButton.Location = new System.Drawing.Point(114, 2);
            this.search_txt_box.CustomButton.Name = "";
            this.search_txt_box.CustomButton.Size = new System.Drawing.Size(19, 20);
            this.search_txt_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_txt_box.CustomButton.TabIndex = 1;
            this.search_txt_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_txt_box.CustomButton.UseSelectable = true;
            this.search_txt_box.CustomButton.Visible = false;
            this.search_txt_box.Lines = new string[0];
            this.search_txt_box.Location = new System.Drawing.Point(414, 22);
            this.search_txt_box.MaxLength = 32767;
            this.search_txt_box.Name = "search_txt_box";
            this.search_txt_box.PasswordChar = '\0';
            this.search_txt_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search_txt_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_txt_box.SelectedText = "";
            this.search_txt_box.SelectionLength = 0;
            this.search_txt_box.SelectionStart = 0;
            this.search_txt_box.ShortcutsEnabled = true;
            this.search_txt_box.Size = new System.Drawing.Size(180, 30);
            this.search_txt_box.TabIndex = 0;
            this.search_txt_box.UseSelectable = true;
            this.search_txt_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_txt_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.search_txt_box.TextChanged += new System.EventHandler(this.search_txt_box_TextChanged);
            this.search_txt_box.Click += new System.EventHandler(this.search_txt_box_Click);
            // 
            // loc_dgridv
            // 
            this.loc_dgridv.AllowUserToAddRows = false;
            this.loc_dgridv.AllowUserToResizeColumns = false;
            this.loc_dgridv.AllowUserToResizeRows = false;
            this.loc_dgridv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loc_dgridv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loc_dgridv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.loc_dgridv.ColumnHeadersHeight = 29;
            this.loc_dgridv.Location = new System.Drawing.Point(22, 80);
            this.loc_dgridv.MultiSelect = false;
            this.loc_dgridv.Name = "loc_dgridv";
            this.loc_dgridv.ReadOnly = true;
            this.loc_dgridv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loc_dgridv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.loc_dgridv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.loc_dgridv.RowTemplate.Height = 24;
            this.loc_dgridv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loc_dgridv.Size = new System.Drawing.Size(738, 316);
            this.loc_dgridv.TabIndex = 18;
            this.loc_dgridv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loc_dgridv_CellContentClick_1);
            // 
            // addloc_tab
            // 
            this.addloc_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addloc_tab.Controls.Add(this.metroPanel2);
            this.addloc_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addloc_tab.Location = new System.Drawing.Point(4, 37);
            this.addloc_tab.Name = "addloc_tab";
            this.addloc_tab.Size = new System.Drawing.Size(780, 420);
            this.addloc_tab.TabIndex = 1;
            this.addloc_tab.Text = "Add Locations";
            this.addloc_tab.UseVisualStyleBackColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.metroPanel2.Controls.Add(this.clr_btn);
            this.metroPanel2.Controls.Add(this.addloc_btn);
            this.metroPanel2.Controls.Add(this.capacity_cmb);
            this.metroPanel2.Controls.Add(this.roomtype_cmb);
            this.metroPanel2.Controls.Add(this.room_cmb);
            this.metroPanel2.Controls.Add(this.building_cmb);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(2, -1);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(776, 419);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.clr_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clr_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.clr_btn.Location = new System.Drawing.Point(404, 328);
            this.clr_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(150, 40);
            this.clr_btn.TabIndex = 38;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseCustomBackColor = true;
            this.clr_btn.UseCustomForeColor = true;
            this.clr_btn.UseSelectable = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // addloc_btn
            // 
            this.addloc_btn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.addloc_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addloc_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.addloc_btn.Location = new System.Drawing.Point(237, 328);
            this.addloc_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addloc_btn.Name = "addloc_btn";
            this.addloc_btn.Size = new System.Drawing.Size(150, 40);
            this.addloc_btn.TabIndex = 37;
            this.addloc_btn.Text = "Add Location";
            this.addloc_btn.UseCustomBackColor = true;
            this.addloc_btn.UseCustomForeColor = true;
            this.addloc_btn.UseSelectable = true;
            this.addloc_btn.Click += new System.EventHandler(this.addloc_btn_Click);
            // 
            // capacity_cmb
            // 
            this.capacity_cmb.AutoSize = true;
            this.capacity_cmb.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.capacity_cmb.Location = new System.Drawing.Point(389, 190);
            this.capacity_cmb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.capacity_cmb.Name = "capacity_cmb";
            this.capacity_cmb.Size = new System.Drawing.Size(100, 22);
            this.capacity_cmb.TabIndex = 36;
            this.capacity_cmb.ValueChanged += new System.EventHandler(this.capacity_cmb_ValueChanged);
            // 
            // roomtype_cmb
            // 
            this.roomtype_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomtype_cmb.FormattingEnabled = true;
            this.roomtype_cmb.ItemHeight = 23;
            this.roomtype_cmb.Items.AddRange(new object[] {
            "Lecture Hall",
            "PC Lab",
            "Engineering Lab"});
            this.roomtype_cmb.Location = new System.Drawing.Point(389, 251);
            this.roomtype_cmb.Name = "roomtype_cmb";
            this.roomtype_cmb.PromptText = "Select Room Type";
            this.roomtype_cmb.Size = new System.Drawing.Size(200, 29);
            this.roomtype_cmb.TabIndex = 35;
            this.roomtype_cmb.UseSelectable = true;
            this.roomtype_cmb.SelectedIndexChanged += new System.EventHandler(this.roomtype_cmb_SelectedIndexChanged);
            // 
            // room_cmb
            // 
            this.room_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.room_cmb.FormattingEnabled = true;
            this.room_cmb.ItemHeight = 23;
            this.room_cmb.Items.AddRange(new object[] {
            "A302",
            "A401",
            "A402",
            "A403",
            "A404",
            "A406",
            "A411",
            "A501",
            "A502",
            "A504",
            "A506",
            "D204",
            "D302",
            "D303",
            "E203",
            "E204",
            "E304",
            "E501",
            "E602",
            "N3B",
            "N3D",
            "N3E"});
            this.room_cmb.Location = new System.Drawing.Point(389, 129);
            this.room_cmb.MaxDropDownItems = 100;
            this.room_cmb.Name = "room_cmb";
            this.room_cmb.PromptText = "Select Room";
            this.room_cmb.Size = new System.Drawing.Size(200, 29);
            this.room_cmb.TabIndex = 34;
            this.room_cmb.UseSelectable = true;
            this.room_cmb.SelectedIndexChanged += new System.EventHandler(this.room_cmb_SelectedIndexChanged);
            // 
            // building_cmb
            // 
            this.building_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.building_cmb.FormattingEnabled = true;
            this.building_cmb.ItemHeight = 23;
            this.building_cmb.Items.AddRange(new object[] {
            "Faculty of Computing Building",
            "Faculty of Business Building",
            "Faculty of Engineering Building",
            "New Building"});
            this.building_cmb.Location = new System.Drawing.Point(389, 72);
            this.building_cmb.MaxDropDownItems = 10;
            this.building_cmb.Name = "building_cmb";
            this.building_cmb.PromptText = "Select Building";
            this.building_cmb.Size = new System.Drawing.Size(200, 29);
            this.building_cmb.TabIndex = 33;
            this.building_cmb.UseSelectable = true;
            this.building_cmb.SelectedIndexChanged += new System.EventHandler(this.building_cmb_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(168, 251);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(180, 30);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Room Type";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(168, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(180, 30);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Capacity";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(168, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(180, 30);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Room";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(303, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 25);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Add Locations";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(168, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 30);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Building";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // editloc_tab
            // 
            this.editloc_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editloc_tab.Controls.Add(this.editloc_panel);
            this.editloc_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editloc_tab.Location = new System.Drawing.Point(4, 37);
            this.editloc_tab.Name = "editloc_tab";
            this.editloc_tab.Size = new System.Drawing.Size(780, 420);
            this.editloc_tab.TabIndex = 2;
            this.editloc_tab.Text = "Edit/Delete Locations";
            this.editloc_tab.UseVisualStyleBackColor = true;
            // 
            // editloc_panel
            // 
            this.editloc_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.editloc_panel.Controls.Add(this.edit_building_txt_box);
            this.editloc_panel.Controls.Add(this.delete_btn);
            this.editloc_panel.Controls.Add(this.editloc_btn);
            this.editloc_panel.Controls.Add(this.editcap_cmb);
            this.editloc_panel.Controls.Add(this.room_type_txt_box);
            this.editloc_panel.Controls.Add(this.editroom_cmb);
            this.editloc_panel.Controls.Add(this.metroLabel6);
            this.editloc_panel.Controls.Add(this.metroLabel7);
            this.editloc_panel.Controls.Add(this.metroLabel8);
            this.editloc_panel.Controls.Add(this.metroLabel9);
            this.editloc_panel.Controls.Add(this.metroLabel10);
            this.editloc_panel.HorizontalScrollbarBarColor = true;
            this.editloc_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.editloc_panel.HorizontalScrollbarSize = 10;
            this.editloc_panel.Location = new System.Drawing.Point(1, 0);
            this.editloc_panel.Name = "editloc_panel";
            this.editloc_panel.Size = new System.Drawing.Size(776, 419);
            this.editloc_panel.TabIndex = 1;
            this.editloc_panel.UseCustomBackColor = true;
            this.editloc_panel.VerticalScrollbarBarColor = true;
            this.editloc_panel.VerticalScrollbarHighlightOnWheel = false;
            this.editloc_panel.VerticalScrollbarSize = 10;
            // 
            // edit_building_txt_box
            // 
            // 
            // 
            // 
            this.edit_building_txt_box.CustomButton.Image = null;
            this.edit_building_txt_box.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.edit_building_txt_box.CustomButton.Name = "";
            this.edit_building_txt_box.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.edit_building_txt_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.edit_building_txt_box.CustomButton.TabIndex = 1;
            this.edit_building_txt_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.edit_building_txt_box.CustomButton.UseSelectable = true;
            this.edit_building_txt_box.CustomButton.Visible = false;
            this.edit_building_txt_box.Lines = new string[0];
            this.edit_building_txt_box.Location = new System.Drawing.Point(389, 129);
            this.edit_building_txt_box.MaxLength = 32767;
            this.edit_building_txt_box.Name = "edit_building_txt_box";
            this.edit_building_txt_box.PasswordChar = '\0';
            this.edit_building_txt_box.ReadOnly = true;
            this.edit_building_txt_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edit_building_txt_box.SelectedText = "";
            this.edit_building_txt_box.SelectionLength = 0;
            this.edit_building_txt_box.SelectionStart = 0;
            this.edit_building_txt_box.ShortcutsEnabled = true;
            this.edit_building_txt_box.Size = new System.Drawing.Size(234, 25);
            this.edit_building_txt_box.TabIndex = 40;
            this.edit_building_txt_box.UseSelectable = true;
            this.edit_building_txt_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.edit_building_txt_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.edit_building_txt_box.Click += new System.EventHandler(this.edit_building_txt_box_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.delete_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.delete_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_btn.Location = new System.Drawing.Point(404, 328);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(150, 40);
            this.delete_btn.TabIndex = 38;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseCustomBackColor = true;
            this.delete_btn.UseCustomForeColor = true;
            this.delete_btn.UseSelectable = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // editloc_btn
            // 
            this.editloc_btn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.editloc_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.editloc_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.editloc_btn.Location = new System.Drawing.Point(237, 328);
            this.editloc_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editloc_btn.Name = "editloc_btn";
            this.editloc_btn.Size = new System.Drawing.Size(150, 40);
            this.editloc_btn.TabIndex = 37;
            this.editloc_btn.Text = "Update Location";
            this.editloc_btn.UseCustomBackColor = true;
            this.editloc_btn.UseCustomForeColor = true;
            this.editloc_btn.UseSelectable = true;
            this.editloc_btn.Click += new System.EventHandler(this.editloc_btn_Click);
            // 
            // editcap_cmb
            // 
            this.editcap_cmb.AutoSize = true;
            this.editcap_cmb.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.editcap_cmb.Location = new System.Drawing.Point(389, 190);
            this.editcap_cmb.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editcap_cmb.Name = "editcap_cmb";
            this.editcap_cmb.Size = new System.Drawing.Size(100, 22);
            this.editcap_cmb.TabIndex = 36;
            this.editcap_cmb.ValueChanged += new System.EventHandler(this.editcap_cmb_ValueChanged);
            // 
            // room_type_txt_box
            // 
            this.room_type_txt_box.AllowDrop = true;
            this.room_type_txt_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.room_type_txt_box.FormattingEnabled = true;
            this.room_type_txt_box.ItemHeight = 23;
            this.room_type_txt_box.Items.AddRange(new object[] {
            "Lecture Hall",
            "PC Lab",
            "Engineering Lab"});
            this.room_type_txt_box.Location = new System.Drawing.Point(389, 251);
            this.room_type_txt_box.Name = "room_type_txt_box";
            this.room_type_txt_box.Size = new System.Drawing.Size(234, 29);
            this.room_type_txt_box.TabIndex = 35;
            this.room_type_txt_box.UseSelectable = true;
            this.room_type_txt_box.SelectedIndexChanged += new System.EventHandler(this.room_type_txt_box_SelectedIndexChanged);
            // 
            // editroom_cmb
            // 
            this.editroom_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editroom_cmb.FormattingEnabled = true;
            this.editroom_cmb.ItemHeight = 23;
            this.editroom_cmb.Items.AddRange(new object[] {
            "A302",
            "A401",
            "A402",
            "A403",
            "A404",
            "A406",
            "A411",
            "A501",
            "A502",
            "A504",
            "A506",
            "D204",
            "D302",
            "D303",
            "E203",
            "E204",
            "E304",
            "E501",
            "E602",
            "N3B",
            "N3D",
            "N3E"});
            this.editroom_cmb.Location = new System.Drawing.Point(389, 73);
            this.editroom_cmb.Name = "editroom_cmb";
            this.editroom_cmb.PromptText = "Select Room";
            this.editroom_cmb.Size = new System.Drawing.Size(234, 29);
            this.editroom_cmb.TabIndex = 34;
            this.editroom_cmb.UseSelectable = true;
            this.editroom_cmb.SelectedIndexChanged += new System.EventHandler(this.editroom_cmb_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(168, 251);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(180, 30);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Room Type";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(168, 190);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(180, 30);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Capacity";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(168, 72);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(180, 30);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Room";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(303, 19);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(123, 25);
            this.metroLabel9.TabIndex = 29;
            this.metroLabel9.Text = "Edit Location";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(168, 129);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(180, 30);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Building";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Locations);
            this.panel4.Location = new System.Drawing.Point(221, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 67);
            this.panel4.TabIndex = 1;
            // 
            // Locations
            // 
            this.Locations.AutoSize = true;
            this.Locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Locations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locations.Location = new System.Drawing.Point(150, 11);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(140, 31);
            this.Locations.TabIndex = 2;
            this.Locations.Text = "Locations";
            this.Locations.Click += new System.EventHandler(this.label2_Click_3);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 96);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HomePage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_2341531;
            this.pictureBox1.Location = new System.Drawing.Point(34, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button8.Location = new System.Drawing.Point(170, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 51);
            this.button8.TabIndex = 3;
            this.button8.Text = "Home";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_home_header);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(484, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rooms";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_rooms_header);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(649, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Types";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_advanced_header);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Location = new System.Drawing.Point(820, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Genarate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_genarate_header);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(318, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sessions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_sessions_header);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Image = global::Time_table_Management_System.Properties.Resources.oo;
            this.button14.Location = new System.Drawing.Point(980, 9);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(15, 17);
            this.button14.TabIndex = 0;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Image = global::Time_table_Management_System.Properties.Resources.uu__1_;
            this.button13.Location = new System.Drawing.Point(1001, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(20, 20);
            this.button13.TabIndex = 0;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::Time_table_Management_System.Properties.Resources.ne__2___1_;
            this.button12.Location = new System.Drawing.Point(1027, 7);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(20, 20);
            this.button12.TabIndex = 0;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button11.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_1203275__2_;
            this.button11.Location = new System.Drawing.Point(11, 492);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 83);
            this.button11.TabIndex = 13;
            this.button11.Text = "Location";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_locations_nav);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button10.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_511570__1_;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(8, 581);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 78);
            this.button10.TabIndex = 0;
            this.button10.Text = "Statistics";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_statics_nav);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button9.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_1110775__1_;
            this.button9.Location = new System.Drawing.Point(8, 403);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 67);
            this.button9.TabIndex = 12;
            this.button9.Text = "Tags";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_tags_nav);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button7.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_1083954__1_;
            this.button7.Location = new System.Drawing.Point(8, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 78);
            this.button7.TabIndex = 11;
            this.button7.Text = "Students";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_students_nav);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button6.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_58351__1_;
            this.button6.Location = new System.Drawing.Point(8, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 71);
            this.button6.TabIndex = 9;
            this.button6.Text = "Subjects";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_subjects_nav);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button5.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_266447__1_;
            this.button5.Location = new System.Drawing.Point(2, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 73);
            this.button5.TabIndex = 8;
            this.button5.Text = "Lectures";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_lectures_nav);
            // 
            // Hwbtn
            // 
            this.Hwbtn.FlatAppearance.BorderSize = 0;
            this.Hwbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hwbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hwbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Hwbtn.Image = global::Time_table_Management_System.Properties.Resources.pngaaa_com_176187__1___1_;
            this.Hwbtn.Location = new System.Drawing.Point(2, 103);
            this.Hwbtn.Name = "Hwbtn";
            this.Hwbtn.Size = new System.Drawing.Size(113, 86);
            this.Hwbtn.TabIndex = 2;
            this.Hwbtn.Text = "Working Days\r\n Hours";
            this.Hwbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Hwbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Hwbtn.UseVisualStyleBackColor = true;
            this.Hwbtn.Click += new System.EventHandler(this.btn_days_nav);
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1061, 695);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Hwbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Location_MouseDown);
            this.panel1.ResumeLayout(false);
            this.loc_tabcontrol.ResumeLayout(false);
            this.viewloc_tab.ResumeLayout(false);
            this.locationview_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loc_dgridv)).EndInit();
            this.addloc_tab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity_cmb)).EndInit();
            this.editloc_tab.ResumeLayout(false);
            this.editloc_panel.ResumeLayout(false);
            this.editloc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editcap_cmb)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Hwbtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private MetroFramework.Controls.MetroTabControl loc_tabcontrol;
        private System.Windows.Forms.TabPage viewloc_tab;
        private System.Windows.Forms.Panel locationview_panel;
        private MetroFramework.Controls.MetroComboBox search_by_cmb;
        private MetroFramework.Controls.MetroTextBox search_txt_box;
        private System.Windows.Forms.DataGridView loc_dgridv;
        private System.Windows.Forms.TabPage addloc_tab;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton clr_btn;
        private MetroFramework.Controls.MetroButton addloc_btn;
        public System.Windows.Forms.NumericUpDown capacity_cmb;
        public MetroFramework.Controls.MetroComboBox roomtype_cmb;
        public MetroFramework.Controls.MetroComboBox room_cmb;
        public MetroFramework.Controls.MetroComboBox building_cmb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage editloc_tab;
        private MetroFramework.Controls.MetroPanel editloc_panel;
        private MetroFramework.Controls.MetroTextBox edit_building_txt_box;
        private MetroFramework.Controls.MetroButton delete_btn;
        private MetroFramework.Controls.MetroButton editloc_btn;
        private System.Windows.Forms.NumericUpDown editcap_cmb;
        private MetroFramework.Controls.MetroComboBox room_type_txt_box;
        private MetroFramework.Controls.MetroComboBox editroom_cmb;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Locations;
    }
}

