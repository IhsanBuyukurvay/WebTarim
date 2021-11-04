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
    public partial class tedarikciGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (textkulgiris.Text == "" || textkulsifre.Text == "")
            {
                Label4.Text = "Tedarikci Ad veya Tc hatalı";
            }
            else
            {
                string baglantiYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SULTAN GENCER\Documents\webTarim.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection baglanti = new SqlConnection(baglantiYolu);
                SqlCommand sorgu = new SqlCommand("SELECT * FROM Tedarikci WHERE tedarikci_ad=@tedarikci_ad AND tedarikci_tc=@tedarikci_tc", baglanti);

                sorgu.Parameters.AddWithValue("@tedarikci_ad", textkulgiris.Text);
                sorgu.Parameters.AddWithValue("@tedarikci_tc", textkulsifre.Text);


                baglanti.Open();

                SqlDataReader oku = sorgu.ExecuteReader();
                // Eğer bir kayıt varsa
                if (oku.Read())
                {
                    // Okunan verileri Session(Oturum) değişkenlerinde saklayalım
                    Session["tedarikci_id"] = oku["tedarikci_id"].ToString();

                    Label4.Text = "Tamam bulundu";
                    // Giriş sayfasına yönlendir
                    Response.Redirect("TedarikciAnasayfa.aspx");
                }
                else // Kayıt yoksa
                {
                    Label4.Text = "Böyle bir tedarikci bulunamadı !!!";

                }
                oku.Close(); // Reader nesnesini kapat
                baglanti.Close(); // Bağlantı nesnesini kapat
            }
        }
    }
}