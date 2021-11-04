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
    public partial class TedarikUrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
              
                SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);

                SqlCommand komut = new SqlCommand();

                try
                {
                    komut = new SqlCommand("INSERT INTO AltUrun (alturun_ad,alturun_uretimtarihi,alturun_skt) VALUES(@adi,@uth,@skt)", baglanti);


                    komut.Parameters.AddWithValue("@adi", TextBox1.Text);
                    komut.Parameters.AddWithValue("@uth", TextBox2.Text);
                    komut.Parameters.AddWithValue("@skt", TextBox3.Text);



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