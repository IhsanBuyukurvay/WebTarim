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
    public partial class UrunGoruntule : System.Web.UI.Page
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
             id = Request.QueryString["urun_id"];
            int urun_id = Convert.ToInt32(Session["urun_id"]);

            SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
            if (Page.IsPostBack == false)
            {
                baglanti.Open();
                string sorgu = "Select * from UrunBilgisi where urun_id=@kulID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kulID", id);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Label11.Text = dr[1].ToString();
                    Label2.Text = dr[2].ToString();
                    Image1.ImageUrl = dr[9].ToString();
                    Label7.Text = dr[3].ToString();
                    Label6.Text = dr[4].ToString();
                    Label8.Text = dr[5].ToString();
                    Label4.Text = dr[6].ToString();
                    Label9.Text = dr[7].ToString();
                    Label10.Text = dr[8].ToString();
                 
                }
            }
        }
    }
}