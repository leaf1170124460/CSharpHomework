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
    public partial class MainForm : Form
    {
        public static OrderService Service { get; set; }                //订单服务
        public string Catalogue { get; set; }                           //查询类型
        public string SelectValue { get; set; }                         //查询值

        public MainForm()
        {
            InitializeComponent();
            Service = new OrderService();

            Order firstOrder = new Order() { OrderCode = "5", Customer = new Customer { Name = "Mike", Phone = "13845691234", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 2 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 30 } } };
            Order secondOrder = new Order() { OrderCode = "4", Customer = new Customer { Name = "Amy", Phone = "13845123457", Address = "Beijing" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 1 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 1 } } };
            Order thirdtOrder = new Order() { OrderCode = "3", Customer = new Customer { Name = "John", Phone = "13845123466", Address = "Shanghai" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 3 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 3 } } };
            Order fourthOrder = new Order() { OrderCode = "2", Customer = new Customer { Name = "Amy", Phone = "13845123356", Address = "Wuhan" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 4 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 6 } } };
            Order fifthOrder = new Order() { OrderCode = "1", Customer = new Customer { Name = "Bob", Phone = "13845123156", Address = "Guangzhou" }, Items = new List<OrderItem>() { new OrderItem() { Commodity = new Commodity() { Code = "123456", Name = "Phone", Price = 3999.0F }, Count = 5 }, new OrderItem() { Commodity = new Commodity() { Code = "123457", Name = "Pen", Price = 9.0F }, Count = 10 } } };

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
            bdsOrders.DataSource = Service.OrderList;
            cmbCatalogue.DataBindings.Add("SelectedItem", this, "Catalogue");
            txtSelectValue.DataBindings.Add("Text", this, "SelectValue");
        }

        //添加订单项
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //以新增模式打开窗口
            EditOrderDialog detailOrderDialog = new EditOrderDialog(1,-1);
            if (detailOrderDialog.ShowDialog() == DialogResult.OK)
            {
                bdsOrders.DataSource = Service.OrderList;
                bdsOrders.ResetBindings(false);
                bdsItems.ResetBindings(false);
            }
        }

        //修改订单项
        private void btnModify_Click(object sender, EventArgs e)
        {
            //获取索引
            string orderCode=(string)dgvOrders.CurrentRow.Cells[0].Value;
            int index = Service.OrderList.IndexOf(new Order() { OrderCode = orderCode });

            //模式代码0以修改模式打开窗口
            EditOrderDialog detailOrderDialog = new EditOrderDialog(0, index);
            if (detailOrderDialog.ShowDialog() == DialogResult.OK)
            {
                bdsOrders.DataSource = Service.OrderList;
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
            bdsOrders.DataSource = Service.OrderList;
            bdsOrders.ResetBindings(false);
            bdsItems.ResetBindings(false);
        }


        //移除订单
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrders.RowCount > 1)
            {
                int index = dgvOrders.CurrentRow.Index;
                Service.OrderList.RemoveAt(index);
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
