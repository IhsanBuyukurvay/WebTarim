using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace webTarim
{
    public partial class yonetici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (textkulgiris.Text == "" || textkulsifre.Text == "")
            {
                Label4.Text = "Yönetici Tc veya şifreniz hatalı";
            }
            else
            {
                string baglantiYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SULTAN GENCER\Documents\webTarim.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection baglanti = new SqlConnection(baglantiYolu);
                SqlCommand sorgu = new SqlCommand("SELECT * FROM yonetici WHERE yonetici_sifre=@yonsifre AND yonetici_tc=@yontc", baglanti);

                sorgu.Parameters.AddWithValue("@yontc", textkulgiris.Text);
                sorgu.Parameters.AddWithValue("@yonsifre", textkulsifre.Text);


                baglanti.Open();

                SqlDataReader oku = sorgu.ExecuteReader();
                // Eğer bir kayıt varsa
                if (oku.Read())
                {
                    // Okunan verileri Session(Oturum) değişkenlerinde saklayalım
                    Session["yonetici_id"] = oku["yonetici_id"].ToString();
                    
                    Label4.Text = "Tamam bulundu";
                    // Giriş sayfasına yönlendir
                    Response.Redirect("yoneticianasayfa.aspx");
                }
                else // Kayıt yoksa
                {
                    Label4.Text = "Böyle bir yönetici bulunamadı !!!";

                }
                oku.Close(); // Reader nesnesini kapat
                baglanti.Close(); // Bağlantı nesnesini kapat
            }
        }
    }
}