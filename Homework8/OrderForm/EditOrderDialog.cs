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
        private int mode;                                       //模式代码（0为修改模式，其他值为新增模式）
        private OrderService service;                           //订单服务
        private Order currentOrder;                             //当前订单

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set;}
        public string CustomerAddress { get; set; }

        public EditOrderDialog(int mode,int index)
        {
            InitializeComponent();
            service = MainForm.Service;
            this.mode = mode;
            switch (mode)
            {
                case 0:
                    currentOrder = (Order)service.OrderList[index].Clone();         //深克隆，避免直接操作原数据
                    break;
                default:
                    currentOrder = new Order();
                    break;
            }
        }

        private void DetailOrderDialog_Load(object sender, EventArgs e)
        {
            //数据绑定
            bdsDialog.DataSource = currentOrder;
            bdsDialog.DataMember = "Items";
            txtOrderCode.DataBindings.Add("Text", currentOrder, "OrderCode");
            txtCustomerName.DataBindings.Add("Text", currentOrder.Customer, "Name");
            txtCustomerPhone.DataBindings.Add("Text", currentOrder.Customer, "Phone");
            txtCustomerAddress.DataBindings.Add("Text", currentOrder.Customer, "Address");
        }

        //确认添加/修改订单
        private void btnComfirm_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    service.UpdateOrder(currentOrder.OrderCode, currentOrder);              //模式代码为0更新订单
                    break;
                default:
                    service.AddOrder(currentOrder);                                         //其他值新增订单
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        //取消添加/修改订单
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
