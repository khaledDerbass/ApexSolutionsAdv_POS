using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supershop.Customer
{
    public partial class GenerateGiftCard : Form
    {
        public GenerateGiftCard()
        {
            InitializeComponent();
         }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtserialno.Text == "")
                {
                    MessageBox.Show("Please fill Gift card Serial Number");
                    txtserialno.Focus();
                }
                else if (txtgiftamount.Text == "")
                {
                    MessageBox.Show("Please fill Gift card amount");
                    txtgiftamount.Focus();
                }
                else
                {
                    string sqlCmd = " insert into tbl_giftcardgenerate (serialno,availbalance) "  +
                                    " values ('" + txtserialno.Text + "', '" + txtgiftamount.Text + "')";
                    DataAccess.ExecuteSQL(sqlCmd);
                    MessageBox.Show("Successfully Added Serial no: " + txtserialno.Text);
                    txtserialno.Text = string.Empty;

                    GiftCard();
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Sorry\r\n this id already added \n\n " + exp.Message);
            }
        }


        public void GiftCard()
        {
            string sqlCmd = " select serialno,availbalance as Amount from  tbl_giftcardgenerate where status = 1";
            DataAccess.ExecuteSQL(sqlCmd);
            DataTable dt1 = DataAccess.GetDataTable(sqlCmd);
            dtgviewgiftcard.DataSource = dt1;
          }

        private void GenerateGiftCard_Load(object sender, EventArgs e)
        {
            GiftCard();

            //Delete Button
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dtgviewgiftcard.Columns.Add(btn);
            btn.HeaderText = " Delete ";
            btn.Text = " X ";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            txtserialno.Focus();

        }

        private void dtgviewgiftcard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgviewgiftcard.Rows[e.RowIndex];
                string serialno = row.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Do you want to Delete this record?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string sql = " delete  from  tbl_giftcardgenerate  where  serialno = '" + serialno  + "' ";
                        DataAccess.ExecuteSQL(sql);

                        MessageBox.Show("Has been deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        GiftCard();

                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Sorry\r\n You have to Check the Data" + exp.Message);
                    }
                }
            }
            catch  
            {

            }
        }
    }
}
