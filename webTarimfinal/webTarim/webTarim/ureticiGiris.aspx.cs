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
    public partial class ureticiGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (textkulgiris.Text == "" || textkulsifre.Text == "")
            {
                Label4.Text = "Üretici Ad veya Tc hatalı";
            }
            else
            {
                string baglantiYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SULTAN GENCER\Documents\webTarim.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection baglanti = new SqlConnection(baglantiYolu);
                SqlCommand sorgu = new SqlCommand("SELECT * FROM Uretici WHERE uretici_ad=@uretici_ad AND uretici_tc=@uretici_tc", baglanti);

                sorgu.Parameters.AddWithValue("@uretici_ad", textkulgiris.Text);
                sorgu.Parameters.AddWithValue("@uretici_tc", textkulsifre.Text);


                baglanti.Open();

                SqlDataReader oku = sorgu.ExecuteReader();
                // Eğer bir kayıt varsa
                if (oku.Read())
                {
                    // Okunan verileri Session(Oturum) değişkenlerinde saklayalım
                    Session["uretici_id"] = oku["uretici_id"].ToString();

                    Label4.Text = "Tamam bulundu";
                    // Giriş sayfasına yönlendir
                    Response.Redirect("ureticiAnasayfa.aspx");
                }
                else // Kayıt yoksa
                {
                    Label4.Text = "Böyle bir kullanıcı bulunamadı !!!";

                }
                oku.Close(); // Reader nesnesini kapat
                baglanti.Close(); // Bağlantı nesnesini kapat
            }
        }
    }
}