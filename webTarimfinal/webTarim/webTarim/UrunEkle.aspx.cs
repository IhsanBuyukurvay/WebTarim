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
    public partial class UrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);

                SqlCommand komut = new SqlCommand();

                try
                {
                    komut = new SqlCommand("INSERT INTO UrunBilgisi (urun_tur,urun_yer,urun_ilac,urun_toprak, urun_boy, urun_tarih, urun_skt, urun_barkod,resim) " +
                        "VALUES(@tur, @yer,@ilac,@toprak,@boy,@tarih,@skt,@barkod,@rsm)", baglanti);


                    komut.Parameters.AddWithValue("@tur", TextBox1.Text);
                    komut.Parameters.AddWithValue("@yer", TextBox2.Text);
                    komut.Parameters.AddWithValue("@ilac", TextBox4.Text);
                    komut.Parameters.AddWithValue("@toprak", TextBox3.Text);
                    komut.Parameters.AddWithValue("@boy", TextBox5.Text);
                    komut.Parameters.AddWithValue("@tarih", TextBox8.Text);
                    komut.Parameters.AddWithValue("@skt", TextBox6.Text);
                    komut.Parameters.AddWithValue("@barkod", TextBox7.Text);
                    komut.Parameters.AddWithValue("@rsm", "~/RESİMLER/" + FileUpload1.FileName);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    Label10.Text = "Kayıt Eklendi";
                    //  GridView1.DataBind();
                }
                catch (Exception a)
                {


                    Label10.Text = a.ToString();
                }
                finally
                {
                    baglanti.Close();
                }
            }
        
    }
    }
}