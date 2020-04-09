namespace OrderForm
{
    partial class EditOrderDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrderDialog));
            this.tlpOtherFunction = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.tlpCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.tlpOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.dgvDialog = new System.Windows.Forms.DataGridView();
            this.commodityCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsDialog = new System.Windows.Forms.BindingSource(this.components);
            this.tlpDialog = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.bdnDialog = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.tlpOtherFunction.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.tlpCustomer.SuspendLayout();
            this.gbxOrder.SuspendLayout();
            this.tlpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDialog)).BeginInit();
            this.tlpDialog.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnDialog)).BeginInit();
            this.bdnDialog.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpOtherFunction
            // 
            this.tlpOtherFunction.ColumnCount = 2;
            this.tlpOtherFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOtherFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOtherFunction.Controls.Add(this.btnCancel, 1, 0);
            this.tlpOtherFunction.Controls.Add(this.btnComfirm, 0, 0);
            this.tlpOtherFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpOtherFunction.Location = new System.Drawing.Point(0, 454);
            this.tlpOtherFunction.Name = "tlpOtherFunction";
            this.tlpOtherFunction.RowCount = 1;
            this.tlpOtherFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherFunction.Size = new System.Drawing.Size(303, 50);
            this.tlpOtherFunction.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(177, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComfirm
            // 
            this.btnComfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComfirm.Location = new System.Drawing.Point(25, 5);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Padding = new System.Windows.Forms.Padding(5);
            this.btnComfirm.Size = new System.Drawing.Size(100, 40);
            this.btnComfirm.TabIndex = 0;
            this.btnComfirm.Text = "Comfirm";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.tlpCustomer);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomer.Location = new System.Drawing.Point(0, 95);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(303, 249);
            this.gbxCustomer.TabIndex = 5;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // tlpCustomer
            // 
            this.tlpCustomer.ColumnCount = 2;
            this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpCustomer.Controls.Add(this.lblCustomerName, 0, 0);
            this.tlpCustomer.Controls.Add(this.txtCustomerAddress, 1, 2);
            this.tlpCustomer.Controls.Add(this.lblCustomerPhone, 0, 1);
            this.tlpCustomer.Controls.Add(this.txtCustomerPhone, 1, 1);
            this.tlpCustomer.Controls.Add(this.lblCustomerAddress, 0, 2);
            this.tlpCustomer.Controls.Add(this.txtCustomerName, 1, 0);
            this.tlpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCustomer.Location = new System.Drawing.Point(3, 21);
            this.tlpCustomer.Name = "tlpCustomer";
            this.tlpCustomer.RowCount = 3;
            this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCustomer.Size = new System.Drawing.Size(297, 225);
            this.tlpCustomer.TabIndex = 8;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(17, 30);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(39, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(84, 175);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(10);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(203, 25);
            this.txtCustomerAddress.TabIndex = 7;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(13, 105);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(47, 15);
            this.lblCustomerPhone.TabIndex = 2;
            this.lblCustomerPhone.Text = "Phone";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(84, 100);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(10);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(203, 25);
            this.txtCustomerPhone.TabIndex = 6;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(5, 180);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(63, 15);
            this.lblCustomerAddress.TabIndex = 3;
            this.lblCustomerAddress.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(84, 25);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(10);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(203, 25);
            this.txtCustomerName.TabIndex = 5;
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.tlpOrder);
            this.gbxOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxOrder.Location = new System.Drawing.Point(0, 0);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(303, 95);
            this.gbxOrder.TabIndex = 6;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Order";
            // 
            // tlpOrder
            // 
            this.tlpOrder.ColumnCount = 2;
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpOrder.Controls.Add(this.lblOrderCode, 0, 0);
            this.tlpOrder.Controls.Add(this.txtOrderCode, 1, 0);
            this.tlpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrder.Location = new System.Drawing.Point(3, 21);
            this.tlpOrder.Name = "tlpOrder";
            this.tlpOrder.RowCount = 1;
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrder.Size = new System.Drawing.Size(297, 71);
            this.tlpOrder.TabIndex = 5;
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Location = new System.Drawing.Point(17, 28);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(39, 15);
            this.lblOrderCode.TabIndex = 0;
            this.lblOrderCode.Text = "Code";
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderCode.Location = new System.Drawing.Point(84, 23);
            this.txtOrderCode.Margin = new System.Windows.Forms.Padding(10);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(203, 25);
            this.txtOrderCode.TabIndex = 4;
            // 
            // dgvDialog
            // 
            this.dgvDialog.AllowDrop = true;
            this.dgvDialog.AllowUserToOrderColumns = true;
            this.dgvDialog.AutoGenerateColumns = false;
            this.dgvDialog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDialog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDialog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDialog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodityCodeDataGridViewTextBoxColumn,
            this.commodityNameDataGridViewTextBoxColumn,
            this.commodityPriceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dgvDialog.DataSource = this.bdsDialog;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDialog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDialog.Location = new System.Drawing.Point(0, 0);
            this.dgvDialog.MultiSelect = false;
            this.dgvDialog.Name = "dgvDialog";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDialog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDialog.RowTemplate.Height = 27;
            this.dgvDialog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDialog.Size = new System.Drawing.Size(718, 504);
            this.dgvDialog.TabIndex = 10;
            // 
            // commodityCodeDataGridViewTextBoxColumn
            // 
            this.commodityCodeDataGridViewTextBoxColumn.DataPropertyName = "CommodityCode";
            this.commodityCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.commodityCodeDataGridViewTextBoxColumn.Name = "commodityCodeDataGridViewTextBoxColumn";
            // 
            // commodityNameDataGridViewTextBoxColumn
            // 
            this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
            this.commodityNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
            // 
            // commodityPriceDataGridViewTextBoxColumn
            // 
            this.commodityPriceDataGridViewTextBoxColumn.DataPropertyName = "CommodityPrice";
            this.commodityPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.commodityPriceDataGridViewTextBoxColumn.Name = "commodityPriceDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // bdsDialog
            // 
            this.bdsDialog.AllowNew = true;
            this.bdsDialog.DataMember = "Items";
            this.bdsDialog.DataSource = typeof(OrderManagement.Order);
            // 
            // tlpDialog
            // 
            this.tlpDialog.ColumnCount = 2;
            this.tlpDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpDialog.Controls.Add(this.pnlDetail, 1, 0);
            this.tlpDialog.Controls.Add(this.pnlFunction, 0, 0);
            this.tlpDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDialog.Location = new System.Drawing.Point(0, 0);
            this.tlpDialog.Name = "tlpDialog";
            this.tlpDialog.RowCount = 1;
            this.tlpDialog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDialog.Size = new System.Drawing.Size(1033, 510);
            this.tlpDialog.TabIndex = 11;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.bdnDialog);
            this.pnlDetail.Controls.Add(this.dgvDialog);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(312, 3);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(718, 504);
            this.pnlDetail.TabIndex = 1;
            // 
            // bdnDialog
            // 
            this.bdnDialog.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdnDialog.BindingSource = this.bdsDialog;
            this.bdnDialog.CountItem = this.bindingNavigatorCountItem;
            this.bdnDialog.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdnDialog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnDialog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnDialog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bdnDialog.Location = new System.Drawing.Point(0, 477);
            this.bdnDialog.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnDialog.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnDialog.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnDialog.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnDialog.Name = "bdnDialog";
            this.bdnDialog.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnDialog.Size = new System.Drawing.Size(718, 27);
            this.bdnDialog.TabIndex = 11;
            this.bdnDialog.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Remove";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move to First";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move to Previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move to Next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move to Last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pnlFunction
            // 
            this.pnlFunction.Controls.Add(this.gbxCustomer);
            this.pnlFunction.Controls.Add(this.gbxOrder);
            this.pnlFunction.Controls.Add(this.tlpOtherFunction);
            this.pnlFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunction.Location = new System.Drawing.Point(3, 3);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(303, 504);
            this.pnlFunction.TabIndex = 0;
            // 
            // EditOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 510);
            this.Controls.Add(this.tlpDialog);
            this.Name = "EditOrderDialog";
            this.Text = "Edit Order";
            this.Load += new System.EventHandler(this.DetailOrderDialog_Load);
            this.tlpOtherFunction.ResumeLayout(false);
            this.gbxCustomer.ResumeLayout(false);
            this.tlpCustomer.ResumeLayout(false);
            this.tlpCustomer.PerformLayout();
            this.gbxOrder.ResumeLayout(false);
            this.tlpOrder.ResumeLayout(false);
            this.tlpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDialog)).EndInit();
            this.tlpDialog.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnDialog)).EndInit();
            this.bdnDialog.ResumeLayout(false);
            this.bdnDialog.PerformLayout();
            this.pnlFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpOtherFunction;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.TableLayoutPanel tlpCustomer;
        private System.Windows.Forms.TableLayoutPanel tlpOrder;
        private System.Windows.Forms.BindingSource bdsDialog;
        private System.Windows.Forms.DataGridView dgvDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tlpDialog;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.BindingNavigator bdnDialog;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}