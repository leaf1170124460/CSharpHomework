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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrderDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlbOtherFunction = new System.Windows.Forms.TableLayoutPanel();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.gbxCommodity = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCommodityCode = new System.Windows.Forms.Label();
            this.txtCommodityCount = new System.Windows.Forms.TextBox();
            this.txtCommodityCode = new System.Windows.Forms.TextBox();
            this.lblCommodityCount = new System.Windows.Forms.Label();
            this.lblCommodityName = new System.Windows.Forms.Label();
            this.txtCommodityPrice = new System.Windows.Forms.TextBox();
            this.txtCommodityName = new System.Windows.Forms.TextBox();
            this.lblCommodityPrice = new System.Windows.Forms.Label();
            this.tlpAdd = new System.Windows.Forms.TableLayoutPanel();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bdnDialog = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvDialog = new System.Windows.Forms.DataGridView();
            this.commodityCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsDialog = new System.Windows.Forms.BindingSource(this.components);
            this.tlbOtherFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxCustomer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbxCommodity.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlpAdd.SuspendLayout();
            this.gbxOrder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnDialog)).BeginInit();
            this.bdnDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDialog)).BeginInit();
            this.SuspendLayout();
            // 
            // tlbOtherFunction
            // 
            this.tlbOtherFunction.ColumnCount = 2;
            this.tlbOtherFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbOtherFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbOtherFunction.Controls.Add(this.btnComfirm, 0, 0);
            this.tlbOtherFunction.Controls.Add(this.btnCancel, 1, 0);
            this.tlbOtherFunction.Controls.Add(this.dataGridView1, 0, 1);
            this.tlbOtherFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlbOtherFunction.Location = new System.Drawing.Point(0, 719);
            this.tlbOtherFunction.Name = "tlbOtherFunction";
            this.tlbOtherFunction.RowCount = 2;
            this.tlbOtherFunction.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlbOtherFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbOtherFunction.Size = new System.Drawing.Size(1009, 50);
            this.tlbOtherFunction.TabIndex = 3;
            // 
            // btnComfirm
            // 
            this.btnComfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComfirm.Location = new System.Drawing.Point(202, 3);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Padding = new System.Windows.Forms.Padding(5);
            this.btnComfirm.Size = new System.Drawing.Size(100, 40);
            this.btnComfirm.TabIndex = 0;
            this.btnComfirm.Text = "Comfirm";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(706, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(240, 14);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(32, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.tableLayoutPanel2);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCustomer.Location = new System.Drawing.Point(339, 3);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(330, 205);
            this.gbxCustomer.TabIndex = 5;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomerAddress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerPhone, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomerPhone, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerAddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomerName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 181);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(21, 22);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(39, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(91, 138);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(10);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(223, 25);
            this.txtCustomerAddress.TabIndex = 7;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(17, 82);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(47, 15);
            this.lblCustomerPhone.TabIndex = 2;
            this.lblCustomerPhone.Text = "Phone";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(91, 77);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(10);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(223, 25);
            this.txtCustomerPhone.TabIndex = 6;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(9, 143);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(63, 15);
            this.lblCustomerAddress.TabIndex = 3;
            this.lblCustomerAddress.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(91, 17);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(10);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(223, 25);
            this.txtCustomerName.TabIndex = 5;
            // 
            // gbxCommodity
            // 
            this.gbxCommodity.Controls.Add(this.tableLayoutPanel3);
            this.gbxCommodity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCommodity.Location = new System.Drawing.Point(675, 3);
            this.gbxCommodity.Name = "gbxCommodity";
            this.gbxCommodity.Size = new System.Drawing.Size(331, 205);
            this.gbxCommodity.TabIndex = 7;
            this.gbxCommodity.TabStop = false;
            this.gbxCommodity.Text = "Commodity";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.lblCommodityCode, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCommodityCount, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtCommodityCode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCommodityCount, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCommodityName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtCommodityPrice, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCommodityName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCommodityPrice, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(325, 181);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // lblCommodityCode
            // 
            this.lblCommodityCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommodityCode.AutoSize = true;
            this.lblCommodityCode.Location = new System.Drawing.Point(21, 15);
            this.lblCommodityCode.Name = "lblCommodityCode";
            this.lblCommodityCode.Size = new System.Drawing.Size(39, 15);
            this.lblCommodityCode.TabIndex = 0;
            this.lblCommodityCode.Text = "Code";
            // 
            // txtCommodityCount
            // 
            this.txtCommodityCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommodityCount.Location = new System.Drawing.Point(91, 145);
            this.txtCommodityCount.Margin = new System.Windows.Forms.Padding(10);
            this.txtCommodityCount.Name = "txtCommodityCount";
            this.txtCommodityCount.Size = new System.Drawing.Size(224, 25);
            this.txtCommodityCount.TabIndex = 7;
            // 
            // txtCommodityCode
            // 
            this.txtCommodityCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommodityCode.Location = new System.Drawing.Point(91, 10);
            this.txtCommodityCode.Margin = new System.Windows.Forms.Padding(10);
            this.txtCommodityCode.Name = "txtCommodityCode";
            this.txtCommodityCode.Size = new System.Drawing.Size(224, 25);
            this.txtCommodityCode.TabIndex = 3;
            // 
            // lblCommodityCount
            // 
            this.lblCommodityCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommodityCount.AutoSize = true;
            this.lblCommodityCount.Location = new System.Drawing.Point(17, 150);
            this.lblCommodityCount.Name = "lblCommodityCount";
            this.lblCommodityCount.Size = new System.Drawing.Size(47, 15);
            this.lblCommodityCount.TabIndex = 6;
            this.lblCommodityCount.Text = "Count";
            // 
            // lblCommodityName
            // 
            this.lblCommodityName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommodityName.AutoSize = true;
            this.lblCommodityName.Location = new System.Drawing.Point(21, 60);
            this.lblCommodityName.Name = "lblCommodityName";
            this.lblCommodityName.Size = new System.Drawing.Size(39, 15);
            this.lblCommodityName.TabIndex = 1;
            this.lblCommodityName.Text = "Name";
            // 
            // txtCommodityPrice
            // 
            this.txtCommodityPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommodityPrice.Location = new System.Drawing.Point(91, 100);
            this.txtCommodityPrice.Margin = new System.Windows.Forms.Padding(10);
            this.txtCommodityPrice.Name = "txtCommodityPrice";
            this.txtCommodityPrice.Size = new System.Drawing.Size(224, 25);
            this.txtCommodityPrice.TabIndex = 5;
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommodityName.Location = new System.Drawing.Point(91, 55);
            this.txtCommodityName.Margin = new System.Windows.Forms.Padding(10);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(224, 25);
            this.txtCommodityName.TabIndex = 4;
            // 
            // lblCommodityPrice
            // 
            this.lblCommodityPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCommodityPrice.AutoSize = true;
            this.lblCommodityPrice.Location = new System.Drawing.Point(17, 105);
            this.lblCommodityPrice.Name = "lblCommodityPrice";
            this.lblCommodityPrice.Size = new System.Drawing.Size(47, 15);
            this.lblCommodityPrice.TabIndex = 2;
            this.lblCommodityPrice.Text = "Price";
            // 
            // tlpAdd
            // 
            this.tlpAdd.ColumnCount = 3;
            this.tlpAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpAdd.Controls.Add(this.gbxOrder, 0, 0);
            this.tlpAdd.Controls.Add(this.gbxCommodity, 2, 0);
            this.tlpAdd.Controls.Add(this.gbxCustomer, 1, 0);
            this.tlpAdd.Controls.Add(this.tableLayoutPanel4, 2, 1);
            this.tlpAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAdd.Location = new System.Drawing.Point(0, 0);
            this.tlpAdd.Name = "tlpAdd";
            this.tlpAdd.RowCount = 2;
            this.tlpAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAdd.Size = new System.Drawing.Size(1009, 264);
            this.tlpAdd.TabIndex = 8;
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.tableLayoutPanel1);
            this.gbxOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxOrder.Location = new System.Drawing.Point(3, 3);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(330, 205);
            this.gbxOrder.TabIndex = 6;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Order";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblOrderCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOrderCode, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 181);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderCode.AutoSize = true;
            this.lblOrderCode.Location = new System.Drawing.Point(21, 83);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(39, 15);
            this.lblOrderCode.TabIndex = 0;
            this.lblOrderCode.Text = "Code";
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderCode.Location = new System.Drawing.Point(91, 78);
            this.txtOrderCode.Margin = new System.Windows.Forms.Padding(10);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.Size = new System.Drawing.Size(223, 25);
            this.txtOrderCode.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(675, 214);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(331, 47);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(198, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bdnDialog
            // 
            this.bdnDialog.AddNewItem = null;
            this.bdnDialog.CountItem = this.bindingNavigatorCountItem;
            this.bdnDialog.DeleteItem = this.bindingNavigatorCountItem;
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
            this.bindingNavigatorSeparator2});
            this.bdnDialog.Location = new System.Drawing.Point(0, 692);
            this.bdnDialog.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnDialog.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnDialog.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnDialog.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnDialog.Name = "bdnDialog";
            this.bdnDialog.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnDialog.Size = new System.Drawing.Size(1009, 27);
            this.bdnDialog.TabIndex = 9;
            this.bdnDialog.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
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
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dgvDialog
            // 
            this.dgvDialog.AllowUserToAddRows = false;
            this.dgvDialog.AllowUserToDeleteRows = false;
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
            this.dgvDialog.Location = new System.Drawing.Point(0, 264);
            this.dgvDialog.MultiSelect = false;
            this.dgvDialog.Name = "dgvDialog";
            this.dgvDialog.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDialog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDialog.RowTemplate.Height = 27;
            this.dgvDialog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDialog.Size = new System.Drawing.Size(1009, 428);
            this.dgvDialog.TabIndex = 10;
            this.dgvDialog.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDialog_RowEnter);
            // 
            // commodityCodeDataGridViewTextBoxColumn
            // 
            this.commodityCodeDataGridViewTextBoxColumn.DataPropertyName = "CommodityCode";
            this.commodityCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.commodityCodeDataGridViewTextBoxColumn.Name = "commodityCodeDataGridViewTextBoxColumn";
            this.commodityCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commodityNameDataGridViewTextBoxColumn
            // 
            this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
            this.commodityNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
            this.commodityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commodityPriceDataGridViewTextBoxColumn
            // 
            this.commodityPriceDataGridViewTextBoxColumn.DataPropertyName = "CommodityPrice";
            this.commodityPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.commodityPriceDataGridViewTextBoxColumn.Name = "commodityPriceDataGridViewTextBoxColumn";
            this.commodityPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsDialog
            // 
            this.bdsDialog.AllowNew = false;
            this.bdsDialog.DataMember = "Items";
            this.bdsDialog.DataSource = typeof(OrderManagement.Order);
            // 
            // EditOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 769);
            this.Controls.Add(this.dgvDialog);
            this.Controls.Add(this.bdnDialog);
            this.Controls.Add(this.tlpAdd);
            this.Controls.Add(this.tlbOtherFunction);
            this.Name = "EditOrderDialog";
            this.Text = "DetailOrderDialog";
            this.Load += new System.EventHandler(this.DetailOrderDialog_Load);
            this.tlbOtherFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxCustomer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbxCommodity.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tlpAdd.ResumeLayout(false);
            this.gbxOrder.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdnDialog)).EndInit();
            this.bdnDialog.ResumeLayout(false);
            this.bdnDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlbOtherFunction;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.GroupBox gbxCommodity;
        private System.Windows.Forms.TextBox txtCommodityPrice;
        private System.Windows.Forms.TextBox txtCommodityName;
        private System.Windows.Forms.TextBox txtCommodityCode;
        private System.Windows.Forms.Label lblCommodityPrice;
        private System.Windows.Forms.Label lblCommodityName;
        private System.Windows.Forms.Label lblCommodityCode;
        private System.Windows.Forms.TableLayoutPanel tlpAdd;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.TextBox txtCommodityCount;
        private System.Windows.Forms.Label lblCommodityCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingNavigator bdnDialog;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bdsDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commodityPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}