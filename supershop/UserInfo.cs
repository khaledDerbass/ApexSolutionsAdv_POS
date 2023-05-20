using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace supershop
{
 
    /// <summary>
    /// ///////////
    /// Author : Tuaha
    /// Country: Canada
    /// </summary>
    public static class UserInfo
    {
            public static string Userid { get; set; }
            public static string UserName { get; set; }
            public static string UserPassword { get; set; }
            public static string usertype { get; set; }
            public static string invoiceNo { get; set; }
            public static string Shopid { get; set; }
            public static string usernamWK { get; set; }
    }

    public static class ReportValue  // use in report
    {
        public static string StartDate { get; set; }
        public static string EndDate { get; set; }
        public static string emp { get; set; }
       // public static string Reportid { get; set; }
        public static string Terminal { get; set; }
        //public static string StartDateGroupby { get; set; }
        //public static string EndDateGroupby { get; set; }
    }

        public static class parameter
        {
            public static string helpid { get; set; }
            public static string peopleid { get; set; }
            public static string autoprintid { get; set; }
        
        }

        public static class  vatdisvalue
        {
            public static string vat
            {
                set
                {
                     //   //Load Vat and Discount rate
                     //   string sqlVat= "select * from storeconfig";
                     //   DataAccess.ExecuteSQL(sqlVat);
                     //   DataTable dtVat = DataAccess.GetDataTable(sqlVat);
                     ////   txtVATRate.Text = dtVatdis.Rows[0].ItemArray[6].ToString();
                     //  // txtDiscountRate.Text = dtVatdis.Rows[0].ItemArray[7].ToString();
                     //   string vl =  dtVat.Rows[0].ItemArray[6].ToString();
                     //   vl = value;              
                }
                get
                {
                    string sqlVat = " select VAT from tbl_terminallocation where Shopid = '" + UserInfo.Shopid + "' "; // 
                    DataAccess.ExecuteSQL(sqlVat);
                    DataTable dtVat = DataAccess.GetDataTable(sqlVat);                  
                    string vl = dtVat.Rows[0].ItemArray[0].ToString();                                      
                    return vl;                    
                }
            }

            public static string dis
            {
                set
                {
                    //string sqldis = "select * from storeconfig";
                    //DataAccess.ExecuteSQL(sqldis);
                    //DataTable dtdis = DataAccess.GetDataTable(sqldis);
                    //string vl = dtdis.Rows[0].ItemArray[7].ToString();
                    //vl = value;
                }
                get
                {
                    string sqldis = "select Dis from tbl_terminallocation   where Shopid = '" + UserInfo.Shopid + "' ";
                    DataAccess.ExecuteSQL(sqldis);
                    DataTable dtdis = DataAccess.GetDataTable(sqldis);
                    string vl = dtdis.Rows[0].ItemArray[0].ToString();
                    return vl;
                }
            }
        }

        public static class databindsvalues
        {
            public static DataTable multiplediscountsvl(string product_id)
            {
                string sqlmuldis =  " select  id,   product_id, disrate2, disrate3, disrate4   " + 
                                    " from tbl_multidiscount where product_id = '" + product_id + "' ";
                DataAccess.ExecuteSQL(sqlmuldis);
                DataTable dtmuldis = DataAccess.GetDataTable(sqlmuldis);
                if (dtmuldis.Rows.Count > 0)
                {
                    dtmuldis = DataAccess.GetDataTable(sqlmuldis);
                }
                else
                {
                    dtmuldis.Rows.Add("1", product_id, "0", "0", "0"); 
                }
                return dtmuldis;
            }

            public static double qty1discountrate(string product_id)
            {
                string sqlqty1dis = " select      discount   from purchase where product_id = '" + product_id + "' ";
                DataAccess.ExecuteSQL(sqlqty1dis);
                DataTable dtqty1dis = DataAccess.GetDataTable(sqlqty1dis);
                double disvl =  Convert.ToDouble( dtqty1dis.Rows[0].ItemArray[0].ToString());
                if (dtqty1dis.Rows.Count > 0)
                {
                    disvl = Convert.ToDouble(dtqty1dis.Rows[0].ItemArray[0].ToString());
                }
                else
                {
                    disvl = 0.00;
                }
                return disvl;
            }

            //// Multiple discount calculation
            public static double multiplediscountratecelledit(System.Windows.Forms.DataGridViewRow row, double qty, double disrate, double Taxrate, double Rprice, double disrate2, double disrate3, double disrate4, double qty2, double qty3, double qty4)
            {
                double DisamtInc = (((Rprice * qty) * disrate) / 100.00);      // Total Discount amount of this item
                double TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate) / 100.00)) * Taxrate) / 100.00);
                if (qty == 1)
                {
                    DisamtInc = (((Rprice * qty) * disrate) / 100.00);      // Total Discount amount of this item
                    row.Cells[5].Value = DisamtInc;
                    row.Cells[7].Value = disrate;

                    TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate) / 100.00)) * Taxrate) / 100.00);
                    row.Cells[6].Value = TaxamtInc;
                }
                else if (qty == qty2)
                {
                    if(disrate2 == 0)
                    {
                        DisamtInc = (((Rprice * qty) * disrate) / 100.00);      // Total Discount amount of this item
                        row.Cells[5].Value = DisamtInc;
                        row.Cells[7].Value = disrate;

                        TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate) / 100.00)) * Taxrate) / 100.00);
                        row.Cells[6].Value = TaxamtInc;
                    }
                    else
                    {
                        DisamtInc = (((Rprice * qty) * disrate2) / 100.00);
                        row.Cells[5].Value = DisamtInc;
                        row.Cells[7].Value = disrate2;

                        TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate2) / 100.00)) * Taxrate) / 100.00);
                        row.Cells[6].Value = TaxamtInc;
                    }
             
                }
                else if (qty == qty3)
                {
                    if (disrate3 == 0 || disrate2 == 0)
                    {
                        DisamtInc = (((Rprice * qty) * disrate) / 100.00);      // Total Discount amount of this item
                        row.Cells[5].Value = DisamtInc;
                        row.Cells[7].Value = disrate;

                        TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate) / 100.00)) * Taxrate) / 100.00);
                        row.Cells[6].Value = TaxamtInc;
                    }
                    else
                    {
                        DisamtInc = (((Rprice * qty) * disrate3) / 100.00);
                        row.Cells[5].Value = DisamtInc;
                        row.Cells[7].Value = disrate3;

                        TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate3) / 100.00)) * Taxrate) / 100.00);
                        row.Cells[6].Value = TaxamtInc;
                    }

                }
                else if (qty >= qty4)
                {
                    if (disrate4 == 0 || disrate3 == 0 || disrate2 == 0)
                    {
                        DisamtInc = (((Rprice * qty) * disrate) / 100.00);      // Total Discount amount of this item
                        row.Cells[5].Value = DisamtInc;
                        row.Cells[7].Value = disrate;

                        TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate) / 100.00)) * Taxrate) / 100.00);
                        row.Cells[6].Value = TaxamtInc;
                    }
                    else
                    {
                        DisamtInc = (((Rprice * qty) * disrate4) / 100.00);
                        row.Cells[5].Value = DisamtInc;
                        row.Cells[7].Value = disrate4;

                        TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate4) / 100.00)) * Taxrate) / 100.00);
                        row.Cells[6].Value = TaxamtInc;
                    }
 
                }
                else
                {
                    DisamtInc = (((Rprice * qty) * disrate) / 100.00);      // Total Discount amount of this item
                    row.Cells[5].Value = DisamtInc;
                    row.Cells[7].Value = disrate;

                    TaxamtInc = ((((Rprice * qty) - (((Rprice * qty) * disrate) / 100.00)) * Taxrate) / 100.00);
                    row.Cells[6].Value = TaxamtInc;
                }

                return TaxamtInc;
            }
             
        }
    
  
}
