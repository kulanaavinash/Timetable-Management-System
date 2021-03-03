
namespace Time_table_Management_System.Locations
{
    partial class View_Location
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
            this.loc_dgridv = new System.Windows.Forms.DataGridView();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loc_dgridv)).BeginInit();
            this.SuspendLayout();
            // 
            // loc_dgridv
            // 
            this.loc_dgridv.AllowUserToResizeColumns = false;
            this.loc_dgridv.AllowUserToResizeRows = false;
            this.loc_dgridv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loc_dgridv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loc_dgridv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.loc_dgridv.ColumnHeadersHeight = 29;
            this.loc_dgridv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Building,
            this.Room,
            this.Capacity,
            this.Room_type});
            this.loc_dgridv.Location = new System.Drawing.Point(63, 113);
            this.loc_dgridv.Margin = new System.Windows.Forms.Padding(5);
            this.loc_dgridv.MultiSelect = false;
            this.loc_dgridv.Name = "loc_dgridv";
            this.loc_dgridv.ReadOnly = true;
            this.loc_dgridv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loc_dgridv.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.loc_dgridv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.loc_dgridv.RowTemplate.Height = 24;
            this.loc_dgridv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loc_dgridv.Size = new System.Drawing.Size(737, 330);
            this.loc_dgridv.TabIndex = 20;
            // 
            // Building
            // 
            this.Building.HeaderText = "Building ";
            this.Building.MinimumWidth = 6;
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // Room_type
            // 
            this.Room_type.HeaderText = "Room Type ";
            this.Room_type.MinimumWidth = 6;
            this.Room_type.Name = "Room_type";
            this.Room_type.ReadOnly = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Building",
            "Room",
            "Capacity ",
            "Room Type "});
            this.metroComboBox2.Location = new System.Drawing.Point(63, 47);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(204, 30);
            this.metroComboBox2.TabIndex = 24;
            this.metroComboBox2.UseSelectable = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(628, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 25;
            // 
            // View_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.loc_dgridv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Location";
            this.Size = new System.Drawing.Size(859, 496);
            ((System.ComponentModel.ISupportInitialize)(this.loc_dgridv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loc_dgridv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_type;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
