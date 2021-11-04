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
    public partial class KullaniciEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                string baglantiYolu = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SULTAN GENCER\Documents\webTarim.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection baglanti = new SqlConnection(baglantiYolu);

                SqlCommand komut = new SqlCommand();

                try
                {
                    komut = new SqlCommand("INSERT INTO Kullanici (kullanici_ad,kullanici_soyad,kullanici_tc,telefon) VALUES(@adi, @soyadi,@tc,@telefon)", baglanti);


                    komut.Parameters.AddWithValue("@adi", TextBox1.Text);
                    komut.Parameters.AddWithValue("@soyadi", TextBox2.Text);
                    komut.Parameters.AddWithValue("@tc", TextBox4.Text);
                    komut.Parameters.AddWithValue("@telefon", TextBox8.Text);



                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    Label7.Text = "Kayıt Eklendi";
                    //  GridView1.DataBind();
                }
                catch (Exception a)
                {


                    Label7.Text = a.ToString();
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }
    }
}