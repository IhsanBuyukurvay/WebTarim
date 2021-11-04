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
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        string id = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["urun_id"];
            Session["urun_id"] = id;

            SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
            if (Page.IsPostBack == false)
            {
                baglanti.Open();
                string sorgu = "Select * from UrunBilgisi where urun_id=@kID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kID", id);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox4.Text = dr[3].ToString();
                    TextBox3.Text = dr[4].ToString();
                    TextBox5.Text = dr[5].ToString();
                    TextBox8.Text = dr[6].ToString();
                    TextBox6.Text = dr[7].ToString();
                    TextBox7.Text = dr[8].ToString();

                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox8.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox6.Text = Calendar2.SelectedDate.ToString();
            Calendar2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Request.QueryString["urun_id"];
                SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE UrunBilgisi set urun_tur=@tur ,urun_yer=@yer,urun_ilac=@ilac,urun_toprak=@toprak,urun_boy=@boy,urun_tarih=@tarih,urun_skt=@skt,urun_barkod=@barkod,resim=@rsm where urun_id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@tur", TextBox1.Text);
                komut.Parameters.AddWithValue("@yer", TextBox2.Text);
                komut.Parameters.AddWithValue("@ilac", TextBox4.Text);
                komut.Parameters.AddWithValue("@toprak", TextBox3.Text);
                komut.Parameters.AddWithValue("@boy", TextBox5.Text);
                komut.Parameters.AddWithValue("@tarih", TextBox8.Text);
                komut.Parameters.AddWithValue("@skt", TextBox6.Text);
                komut.Parameters.AddWithValue("@barkod", TextBox7.Text);
                komut.Parameters.AddWithValue("@rsm", FileUpload1.FileName);
                

                komut.ExecuteNonQuery();
                baglanti.Close();
                Label10.Text = "guncellendi";
            }
            catch (Exception a)
            {
                Label10.Text = a.ToString();
            }
        }
    }
}