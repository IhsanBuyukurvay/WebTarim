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
    public partial class TedarikUrunGuncelle : System.Web.UI.Page
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["alturun_id"];
            Session["alturun_id"] = id;

            SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
            if (Page.IsPostBack == false)
            {
                baglanti.Open();
                string sorgu = "Select * from AltUrun where alturun_id=@alturunID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@alturunID", id);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[3].ToString();
                    

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Request.QueryString["alturun_id"];
                SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE AltUrun set alturun_ad=@ad ,alturun_uretimtarihi=@uretimt,alturun_skt=@skt  where alturun_id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@ad", TextBox1.Text);
                komut.Parameters.AddWithValue("@uretimt", TextBox2.Text);
                komut.Parameters.AddWithValue("@skt", TextBox3.Text);
                

                komut.ExecuteNonQuery();
                baglanti.Close();
                Label10.Text = "guncellendi";
            }
            catch (Exception a)
            {
                Label10.Text = a.ToString();
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = false;
        }
    }
}