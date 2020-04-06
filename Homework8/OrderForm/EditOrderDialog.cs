using OrderManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class EditOrderDialog : Form
    {
        private int mode;
        private int index;
        private OrderService service;
        private Order currentOrder;
        private OrderItem currentOrderItem;


        public EditOrderDialog(int mode,int index)
        {
            InitializeComponent();
            service = MainForm.Service;
            this.mode = mode;
            this.index = index;
            if (mode == 1)
            {
                
            }
            else
            {
                currentOrder = service.OrderList[index];
                currentOrderItem = currentOrder.Items[0];
            }
        }

        private void DetailOrderDialog_Load(object sender, EventArgs e)
        {
            bdsDialog.DataSource = currentOrder;
            bdsDialog.DataMember = "Items";
            txtOrderCode.DataBindings.Add("Text", currentOrder, "OrderCode");
            txtCustomerName.DataBindings.Add("Text", currentOrder.Customer, "Name");
            txtCustomerPhone.DataBindings.Add("Text", currentOrder.Customer, "Phone");
            txtCustomerAddress.DataBindings.Add("Text", currentOrder.Customer, "Address");
            txtCommodityCode.DataBindings.Add("Text", currentOrderItem.Commodity, "Code");
            txtCommodityName.DataBindings.Add("Text", currentOrderItem.Commodity, "Name");
            txtCommodityPrice.DataBindings.Add("Text", currentOrderItem.Commodity, "Price");
            txtCommodityCount.DataBindings.Add("Text", currentOrderItem, "Count");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentOrder.Items.Add(currentOrderItem);
            bdsDialog.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDialog.RowCount > 1)
            {
                int index = dgvDialog.CurrentRow.Index;
                currentOrder.Items.RemoveAt(index);
                bdsDialog.ResetBindings(false);
            }else
            {
                MessageBox.Show("At least 1 item!");
            }
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                service.AddOrder(currentOrder);
            }else
            {
                service.UpdateOrder(currentOrder.OrderCode, currentOrder);
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgvDialog_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int index = dgvDialog.CurrentRow.Index;
            //currentOrderItem = currentOrder.Items[index];
        }
    }
}
