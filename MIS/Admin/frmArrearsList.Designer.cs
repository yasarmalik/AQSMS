﻿namespace MIS
{
    partial class frmArrearsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationBar1 = new DevComponents.DotNetBar.NavigationBar();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.grdList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrearsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSearch = new DevComponents.DotNetBar.PanelEx();
            this.cbxClass = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtAdmNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rbClass = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnPanelExit = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnGo = new DevComponents.DotNetBar.ButtonX();
            this.rbAdmNo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).BeginInit();
            this.navigationBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationBar1
            // 
            this.navigationBar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.navigationBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationBar1.BackgroundStyle.BackColor1.Alpha = ((byte)(0));
            this.navigationBar1.BackgroundStyle.BackColor1.Color = System.Drawing.Color.White;
            this.navigationBar1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationBar1.BackgroundStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationBar1.BackgroundStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.navigationBar1.BackgroundStyle.BorderWidth = 0;
            this.navigationBar1.ConfigureShowHideVisible = false;
            this.navigationBar1.Controls.Add(this.labelX1);
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.ItemPaddingBottom = 2;
            this.navigationBar1.ItemPaddingTop = 2;
            this.navigationBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnRefresh,
            this.btnEdit,
            this.btnSearch,
            this.btnDelete,
            this.btnPrint,
            this.btnClose});
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1090, 26);
            this.navigationBar1.TabIndex = 15;
            this.navigationBar1.Text = "navigationBar1";
            this.navigationBar1.Click += new System.EventHandler(this.navigationBar1_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(3, -1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(230, 26);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "List of Arrears";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::MIS.Properties.Resources.Add;
            this.btnAdd.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OptionGroup = "navBar";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnAdd.Text = "Add New";
            this.btnAdd.Tooltip = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MIS.Properties.Resources.arrow_refresh;
            this.btnRefresh.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OptionGroup = "navBar";
            this.btnRefresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Tooltip = "Select";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::MIS.Properties.Resources.edit;
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OptionGroup = "navBar";
            this.btnEdit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.Tooltip = "Edit Selected";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Checked = true;
            this.btnSearch.Image = global::MIS.Properties.Resources.Preview;
            this.btnSearch.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OptionGroup = "navBar";
            this.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSearch.Text = "Search";
            this.btnSearch.Tooltip = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::MIS.Properties.Resources.RecycleBin;
            this.btnDelete.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OptionGroup = "navBar";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Tooltip = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::MIS.Properties.Resources.Print;
            this.btnPrint.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OptionGroup = "navBar";
            this.btnPrint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.btnPrint.Text = "Print";
            this.btnPrint.Tooltip = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::MIS.Properties.Resources.Exit__2_;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.OptionGroup = "navBar";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.btnClose.Text = "Close Form";
            this.btnClose.Tooltip = "Close Form";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdList.BackgroundColor = System.Drawing.Color.White;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AID,
            this.SID,
            this.AdmNo,
            this.SName,
            this.CName,
            this.Section,
            this.Arrs,
            this.ClassID,
            this.ArrearsDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdList.Location = new System.Drawing.Point(0, 26);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowHeadersWidth = 70;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(1090, 616);
            this.grdList.TabIndex = 14;
            this.grdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellContentClick);
            this.grdList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellDoubleClick);
            this.grdList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdList_DataBindingComplete);
            // 
            // AID
            // 
            this.AID.DataPropertyName = "AID";
            this.AID.HeaderText = "AID";
            this.AID.Name = "AID";
            this.AID.ReadOnly = true;
            this.AID.Visible = false;
            // 
            // SID
            // 
            this.SID.DataPropertyName = "SID";
            this.SID.HeaderText = "SID";
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Visible = false;
            // 
            // AdmNo
            // 
            this.AdmNo.DataPropertyName = "AdmNo";
            this.AdmNo.HeaderText = "Adm No";
            this.AdmNo.Name = "AdmNo";
            this.AdmNo.ReadOnly = true;
            // 
            // SName
            // 
            this.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "Name";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "Class";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Arrs
            // 
            this.Arrs.DataPropertyName = "Arrs";
            this.Arrs.HeaderText = "Arrears";
            this.Arrs.Name = "Arrs";
            this.Arrs.ReadOnly = true;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Visible = false;
            // 
            // ArrearsDate
            // 
            this.ArrearsDate.DataPropertyName = "ArrearsDate";
            this.ArrearsDate.HeaderText = "Arrears Date";
            this.ArrearsDate.Name = "ArrearsDate";
            this.ArrearsDate.ReadOnly = true;
            // 
            // ttp
            // 
            this.ttp.IsBalloon = true;
            this.ttp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ttp.ToolTipTitle = "Error";
            // 
            // pnlSearch
            // 
            this.pnlSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlSearch.Controls.Add(this.cbxClass);
            this.pnlSearch.Controls.Add(this.txtAdmNo);
            this.pnlSearch.Controls.Add(this.rbClass);
            this.pnlSearch.Controls.Add(this.btnPanelExit);
            this.pnlSearch.Controls.Add(this.labelX3);
            this.pnlSearch.Controls.Add(this.btnGo);
            this.pnlSearch.Controls.Add(this.rbAdmNo);
            this.pnlSearch.Location = new System.Drawing.Point(348, 221);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(394, 201);
            this.pnlSearch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlSearch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlSearch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlSearch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlSearch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlSearch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSearch.Style.GradientAngle = 90;
            this.pnlSearch.TabIndex = 17;
            this.pnlSearch.Visible = false;
            // 
            // cbxClass
            // 
            this.cbxClass.DisplayMember = "Text";
            this.cbxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.ItemHeight = 14;
            this.cbxClass.Location = new System.Drawing.Point(120, 94);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(157, 20);
            this.cbxClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxClass.TabIndex = 3;
            // 
            // txtAdmNo
            // 
            // 
            // 
            // 
            this.txtAdmNo.Border.Class = "TextBoxBorder";
            this.txtAdmNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdmNo.Location = new System.Drawing.Point(120, 55);
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.Size = new System.Drawing.Size(157, 20);
            this.txtAdmNo.TabIndex = 1;
            // 
            // rbClass
            // 
            // 
            // 
            // 
            this.rbClass.BackgroundStyle.Class = "";
            this.rbClass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbClass.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbClass.Location = new System.Drawing.Point(17, 91);
            this.rbClass.Name = "rbClass";
            this.rbClass.Size = new System.Drawing.Size(86, 23);
            this.rbClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbClass.TabIndex = 2;
            this.rbClass.Text = "Class";
            // 
            // btnPanelExit
            // 
            this.btnPanelExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPanelExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPanelExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPanelExit.Image = global::MIS.Properties.Resources.Exit__2_1;
            this.btnPanelExit.Location = new System.Drawing.Point(367, 0);
            this.btnPanelExit.Name = "btnPanelExit";
            this.btnPanelExit.Size = new System.Drawing.Size(27, 27);
            this.btnPanelExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPanelExit.TabIndex = 5;
            this.btnPanelExit.Click += new System.EventHandler(this.btnPanelExit_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(2, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(392, 26);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "  Search . . .";
            // 
            // btnGo
            // 
            this.btnGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGo.Location = new System.Drawing.Point(292, 155);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(82, 23);
            this.btnGo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "GO";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rbAdmNo
            // 
            // 
            // 
            // 
            this.rbAdmNo.BackgroundStyle.Class = "";
            this.rbAdmNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbAdmNo.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbAdmNo.Location = new System.Drawing.Point(17, 52);
            this.rbAdmNo.Name = "rbAdmNo";
            this.rbAdmNo.Size = new System.Drawing.Size(97, 23);
            this.rbAdmNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbAdmNo.TabIndex = 0;
            this.rbAdmNo.Text = "Admission No.";
            // 
            // frmArrearsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 642);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.grdList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArrearsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmExaminers";
            this.Load += new System.EventHandler(this.frmExaminers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar1)).EndInit();
            this.navigationBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationBar navigationBar1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        public  DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdList;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrearsDate;
        private DevComponents.DotNetBar.PanelEx pnlSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxClass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAdmNo;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbClass;
        private DevComponents.DotNetBar.ButtonX btnPanelExit;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnGo;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbAdmNo;
    }
}