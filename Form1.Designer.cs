namespace Tamas02
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet3 = new Tamas02.Database1DataSet3();
            this.szamlakFejeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szamlakFejeTableAdapter = new Tamas02.Database1DataSet3TableAdapters.SzamlakFejeTableAdapter();
            this.erdetiSzamlaSzamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlaDatumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rogzitesDatumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlaKiallitojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szamlakFejeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromExcelFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importFromExcelFileToolStripMenuItem
            // 
            this.importFromExcelFileToolStripMenuItem.Image = global::Tamas02.Properties.Resources.ImportXMLHS;
            this.importFromExcelFileToolStripMenuItem.Name = "importFromExcelFileToolStripMenuItem";
            this.importFromExcelFileToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.importFromExcelFileToolStripMenuItem.Text = "Import data from Excel file";
            this.importFromExcelFileToolStripMenuItem.Click += new System.EventHandler(this.importFromExcelFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Tamas02.Properties.Resources._305_Close_16x16_72;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Tamas02.Properties.Resources.ImportXMLHS;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Import data from Excel file";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Tamas02.Properties.Resources.Gear;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Settings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.erdetiSzamlaSzamaDataGridViewTextBoxColumn,
            this.szamlaDatumaDataGridViewTextBoxColumn,
            this.rogzitesDatumaDataGridViewTextBoxColumn,
            this.szamlaKiallitojaDataGridViewTextBoxColumn,
            this.megjegyzesemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.szamlakFejeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 268);
            this.dataGridView1.TabIndex = 3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szamlakFejeBindingSource
            // 
            this.szamlakFejeBindingSource.DataMember = "SzamlakFeje";
            this.szamlakFejeBindingSource.DataSource = this.database1DataSet3;
            // 
            // szamlakFejeTableAdapter
            // 
            this.szamlakFejeTableAdapter.ClearBeforeFill = true;
            // 
            // erdetiSzamlaSzamaDataGridViewTextBoxColumn
            // 
            this.erdetiSzamlaSzamaDataGridViewTextBoxColumn.DataPropertyName = "Erdeti számla száma";
            this.erdetiSzamlaSzamaDataGridViewTextBoxColumn.HeaderText = "ErdetiSzamlaSzama";
            this.erdetiSzamlaSzamaDataGridViewTextBoxColumn.Name = "erdetiSzamlaSzamaDataGridViewTextBoxColumn";
            this.erdetiSzamlaSzamaDataGridViewTextBoxColumn.Width = 150;
            // 
            // szamlaDatumaDataGridViewTextBoxColumn
            // 
            this.szamlaDatumaDataGridViewTextBoxColumn.DataPropertyName = "SzamlaDatuma";
            this.szamlaDatumaDataGridViewTextBoxColumn.HeaderText = "SzamlaDatuma";
            this.szamlaDatumaDataGridViewTextBoxColumn.Name = "szamlaDatumaDataGridViewTextBoxColumn";
            this.szamlaDatumaDataGridViewTextBoxColumn.Width = 150;
            // 
            // rogzitesDatumaDataGridViewTextBoxColumn
            // 
            this.rogzitesDatumaDataGridViewTextBoxColumn.DataPropertyName = "RogzitesDatuma";
            this.rogzitesDatumaDataGridViewTextBoxColumn.HeaderText = "RogzitesDatuma";
            this.rogzitesDatumaDataGridViewTextBoxColumn.Name = "rogzitesDatumaDataGridViewTextBoxColumn";
            this.rogzitesDatumaDataGridViewTextBoxColumn.Width = 150;
            // 
            // szamlaKiallitojaDataGridViewTextBoxColumn
            // 
            this.szamlaKiallitojaDataGridViewTextBoxColumn.DataPropertyName = "SzamlaKiallitoja";
            this.szamlaKiallitojaDataGridViewTextBoxColumn.HeaderText = "SzamlaKiallitoja";
            this.szamlaKiallitojaDataGridViewTextBoxColumn.Name = "szamlaKiallitojaDataGridViewTextBoxColumn";
            this.szamlaKiallitojaDataGridViewTextBoxColumn.Width = 150;
            // 
            // megjegyzesemDataGridViewTextBoxColumn
            // 
            this.megjegyzesemDataGridViewTextBoxColumn.DataPropertyName = "Megjegyzesem";
            this.megjegyzesemDataGridViewTextBoxColumn.HeaderText = "Megjegyzesem";
            this.megjegyzesemDataGridViewTextBoxColumn.Name = "megjegyzesemDataGridViewTextBoxColumn";
            this.megjegyzesemDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penzugyi nyilvantarto hulyeseg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szamlakFejeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem importFromExcelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource szamlakFejeBindingSource;
        private Database1DataSet3TableAdapters.SzamlakFejeTableAdapter szamlakFejeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn erdetiSzamlaSzamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlaDatumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rogzitesDatumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlaKiallitojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesemDataGridViewTextBoxColumn;
    }
}

