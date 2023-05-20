using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
 

namespace supershop
{ 
    public partial class Stock_List : Form
    {
        public Stock_List()
        {
            InitializeComponent();
        }

        #region Data bind
        //Show Products image
        public void ItemList_with_images(string value)
        {
            flowLayoutPanelUserList.Controls.Clear();
            string img_directory = Application.StartupPath + @"\ITEMIMAGE\";
            string[] files = Directory.GetFiles(img_directory, "*.png *.jpg");
            try
            {
                string sql = "select * from purchase where  ( product_name like '" + value + "%' ) " +
                " OR ( product_id like '" + value + "%' ) " +
                " OR (category = '" + value + "')  ";
                DataAccess.ExecuteSQL(sql);
                DataTable dt = DataAccess.GetDataTable(sql);
                lblRows.Text =  "Total Rows " + dt.Rows.Count.ToString() + " Found";

                int currentImage = 0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dataReader = dt.Rows[i];

                    Button b = new Button();
                    //Image i = Image.FromFile(img_directory + dataReader["name"]);
                    b.Tag = dataReader["product_id"];
                    b.Click += new EventHandler(b_Click);

                    string taxapply;
                    if (dataReader["taxapply"].ToString() == "1")
                    {
                        taxapply = "YES";
                    }
                    else
                    {
                        taxapply = "NO";
                    }

                    string KitchenDisplay;
                    if (dataReader["status"].ToString() == "3")
                    {
                        KitchenDisplay = "YES";
                    }
                    else
                    {
                        KitchenDisplay = "NO";
                    }

                    string details =
                        "====================================" +
                        "\n ID: " + dataReader["product_id"]  +
                        "\n Name: " + dataReader["product_name"].ToString() +
                        "\n Buy price: " + dataReader["cost_price"].ToString() + 
                        "\n Stock Qty: " + dataReader["product_quantity"].ToString() + 
                        "\n Retail price: " + dataReader["retail_price"].ToString() +
                        "\n Discount: " + dataReader["discount"].ToString() + "%" +
                        "\n Category: " + dataReader["category"].ToString() +
                        "\n Supplier: " + dataReader["supplier"].ToString() +
                        "\n Branch: " + dataReader["Shopid"].ToString() +
                        "\n Tax Apply: " + taxapply +
                        "\n Kitchen Display  : " + KitchenDisplay +
                        "\n ====================================";
                    b.Name =  details;
                    toolTip1.ToolTipTitle = "Item Details";
                    toolTip1.AutoPopDelay = 32766;
                    toolTip1.SetToolTip(b, details);

                    ImageList il = new ImageList();
                    il.ColorDepth = ColorDepth.Depth32Bit;
                    il.TransparentColor = Color.Transparent;
                    il.ImageSize = new Size(80, 80);
                    il.Images.Add(Image.FromFile(img_directory + dataReader["imagename"]));
                  
                    //if (dataReader["imagename"].ToString() == img_directory + dataReader["imagename"])
                    //{
                    //    //8940000000002.png
                        
                    //}
                    //else
                    //{
                    //    il.Images.Add(Image.FromFile(img_directory + "/8940000000002.png"));    
                    //}
         
                    
                     
                    b.Image = il.Images[0];
                    b.Margin = new Padding(3, 3, 3, 3);

                    b.Size = new Size(220, 100);
                    b.Text.PadRight(4);
                    
                    b.Text += " " + dataReader["product_id"] + "\n ";
                    b.Text += dataReader["product_name"].ToString();
                    b.Text += "\n Buy: " + dataReader["cost_price"];
                    b.Text += "\n Stock: " + dataReader["product_quantity"];
                    b.Text += "\n R.Price: " + dataReader["retail_price"];
                    b.Text += "\n Dis: " + dataReader["discount"] + "% Tax: " + taxapply;
                    
                    b.Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point);
                    b.TextAlign = ContentAlignment.TopLeft;
                    b.TextImageRelation = TextImageRelation.ImageBeforeText;
                    flowLayoutPanelUserList.Controls.Add(b);                   
                    currentImage++;
                }
            }
            catch //(Exception)
            {

                //throw;
            }
        }

        //Go to Item Details page
        protected void b_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string s;
            s = b.Tag.ToString();

            this.Hide();
            Add_Item go = new Add_Item();
            go.itemCode = s;
            go.MdiParent = this.ParentForm;
            go.Show();
     

        }

        //Product filter by Category
        private void combCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemList_with_images(combCategory.Text);
        }

        //Product filter by Product Name or Product ID
        private void txtItemSearchBar_TextChanged(object sender, EventArgs e)
        {
            ItemList_with_images(txtItemSearchBar.Text);
        } 
 
        private void detail_info_Load(object sender, EventArgs e)
        {         
            
            try
            {
                //Product Category
                string sql5 = "select   DISTINCT  category   from purchase ";
                DataAccess.ExecuteSQL(sql5);
                DataTable dt5 = DataAccess.GetDataTable(sql5);
                combCategory.DataSource = dt5;
                combCategory.DisplayMember = "category";

                ItemList_with_images("");
                
            }
            catch
            {
            }
        }
        #endregion

        #region page links
        private void btnCreateBarcode_Click(object sender, EventArgs e)
        { 

            BarCode.Barcode_machine go = new BarCode.Barcode_machine();
            go.MdiParent = this.ParentForm;
            go.Show();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart g = new Chart();
            g.MdiParent = this.ParentForm;
            g.Show();
        }

        private void picCloseEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        private void btnImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import_Items go = new Import_Items();
            go.MdiParent = this.ParentForm;
            go.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Item go = new Add_Item();
            go.MdiParent = this.ParentForm;
            go.Show();
        }

        private void bntStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items.StockDetails go = new Items.StockDetails();
            go.MdiParent = this.ParentForm;
            go.Show();
        }

        private void btnpurchasehistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items.Purchase_History go = new Items.Purchase_History();
            go.MdiParent = this.ParentForm;
            go.Show();
        }
        #endregion


        // toolbar 
        private void lblMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   //Minimized              
        }

        private void detail_info_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm.ReleaseCapture();
                MoveForm.SendMessage(Handle, MoveForm.WM_NCLBUTTONDOWN, MoveForm.HT_CAPTION, 0);
            }
        } 

    }
}
