using OrderManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class MainForm : Form
    {
        public static OrderService Service { get; set; }                //订单服务
        public string Catalogue { get; set; }                           //查询类型
        public string SelectValue { get; set; }                         //查询值

        public MainForm()
        {
            InitializeComponent();
            Service = new OrderService();
            
            //初始化订单
            Customer mike = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" };
            Customer amy = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" };
            Customer john = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" };
            Customer bob = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" };

            Commodity phone = new Commodity() { Id = 123456L, Name = "Phone", Price = 3999.9F };
            Commodity pen = new Commodity() { Id = 123457L, Name = "Pen", Price = 9.5F };
            Commodity earphone = new Commodity() { Id = 123458L, Name = "Earphone", Price = 399.9F };

            Order firstOrder = new Order() { Customer = mike, Items = new List<OrderItem>() { new OrderItem() { Commodity = phone, Count = 2 }, new OrderItem() { Commodity = pen, Count = 30 } } };
            Order secondOrder = new Order() { Customer = amy, Items = new List<OrderItem>() { new OrderItem() { Commodity = phone, Count = 1 }, new OrderItem() { Commodity = pen, Count = 1 } } };
            Order thirdtOrder = new Order() { Customer =  john, Items = new List<OrderItem>() { new OrderItem() { Commodity = earphone, Count = 3 }, new OrderItem() { Commodity = pen, Count = 3 } } };
            Order fourthOrder = new Order() { Customer = bob,Items = new List<OrderItem>() { new OrderItem() { Commodity = phone, Count = 4 }, new OrderItem() { Commodity = pen, Count = 6 } } };
            Order fifthOrder = new Order() { Customer = amy, Items = new List<OrderItem>() { new OrderItem() { Commodity = phone, Count = 5 }, new OrderItem() { Commodity = pen, Count = 10 } } };
            

            try
            {
                //添加订单
                Service.AddOrder(firstOrder);
                Service.AddOrder(secondOrder);
                Service.AddOrder(thirdtOrder);
                Service.AddOrder(fourthOrder);
                Service.AddOrder(fifthOrder);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //数据绑定
            bdsOrders.DataSource = Service.SelectOrder("All", null);
            bdsItems.DataSource = bdsOrders;
            bdsItems.DataMember = "Items";
            cmbCatalogue.DataBindings.Add("SelectedItem", this, "Catalogue");
            txtSelectValue.DataBindings.Add("Text", this, "SelectValue");
        }

        //添加订单项
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //以新增模式打开窗口
            EditOrderDialog detailOrderDialog = new EditOrderDialog(1,new Order());
            if (detailOrderDialog.ShowDialog() == DialogResult.OK)
            {
                bdsOrders.DataSource = Service.SelectOrder("All", null);
                bdsOrders.ResetBindings(false);
                bdsItems.ResetBindings(false);
            }
        }

        //修改订单项
        private void btnModify_Click(object sender, EventArgs e)
        {
            //获取订单号
            long orderCode = (long)dgvOrders.CurrentRow.Cells[0].Value;

            //获取订单
            Order order = (Order)Service.SelectOrder("Order Code",orderCode.ToString())[0];

            //模式代码0以修改模式打开窗口
            EditOrderDialog detailOrderDialog = new EditOrderDialog(0, order);
            if (detailOrderDialog.ShowDialog() == DialogResult.OK)
            {
                bdsOrders.DataSource = Service.SelectOrder("All", null);
                bdsOrders.ResetBindings(false);
                bdsItems.ResetBindings(false);
            }
        }

        //查询订单
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //提示查询条件空
            if(Catalogue==null || SelectValue == null)
            {
                MessageBox.Show("Empty!");
                return;
            }

            //获取查询列表
            List<Order> selectedList = Service.SelectOrder(Catalogue, SelectValue).ToList();
            if (selectedList.Count>0)
            {
                bdsOrders.DataSource = selectedList;
                bdsOrders.ResetBindings(false);
                bdsItems.ResetBindings(false);
            }else
            {
                MessageBox.Show("There is no such order!");
            }
            
        }


        //恢复订单列表
        private void btnRestore_Click(object sender, EventArgs e)
        {
            bdsOrders.DataSource = Service.SelectOrder("All", null);
            bdsOrders.ResetBindings(false);
            bdsItems.ResetBindings(false);
        }


        //移除订单
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrders.RowCount > 1)
            {
                long orderCode = (dgvOrders.CurrentRow.DataBoundItem as Order).OrderCode;
                Service.DeleteOrder(orderCode);
                bdsOrders.DataSource = Service.SelectOrder("All", null);
                bdsOrders.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("At least 1 item!");
            }
        }

        //导入XML文件
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open";
            openFileDialog.Filter = "XML File|*.xml";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                Service.Import(path);
                bdsOrders.DataSource = Service.SelectOrder("All", null);
                bdsOrders.ResetBindings(false);
            }

        }

        //导出为XML文件
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export";
            saveFileDialog.Filter = "XML File|*.xml";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                Service.Export(path);
                MessageBox.Show("Successfully Exported!");
            }
        }
    }
}
