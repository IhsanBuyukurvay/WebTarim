using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace webTarim
{
    public partial class UreticiListesi : System.Web.UI.Page
    {
        string id = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
            string sql = "select * from Uretici ";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);

            SqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            baglanti.Close();

            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["uretici_id"];
                islem = Request.QueryString["islem"];

            }
            if (islem == "sil")
            {
                string sorgu3 = "Delete from Uretici where uretici_id=@pID";
                SqlConnection baglanti2 = new SqlConnection(Sqlislemleri.baglantiYolu);
                baglanti2.Open();
                SqlCommand komut3 = new SqlCommand(sorgu3, baglanti2);
                komut3.Parameters.AddWithValue("@pID", id);
                komut3.ExecuteNonQuery();
                baglanti2.Close();

            }
        }
    }
}