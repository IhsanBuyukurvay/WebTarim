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
    public partial class TedarikciGuncelle : System.Web.UI.Page
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["tedarikci_id"];
            Session["tedarikci_id"] = id;

            SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
            if (Page.IsPostBack == false)
            {
                baglanti.Open();
                string sorgu = "Select * from Tedarikci where tedarikci_id=@kID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kID", id);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox4.Text = dr[3].ToString();
                    TextBox8.Text = dr[4].ToString();

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Request.QueryString["tedarikci_id"];
                SqlConnection baglanti = new SqlConnection(Sqlislemleri.baglantiYolu);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Tedarikci set tedarikci_ad=@ad ,tedarikci_soyad=@soyad,tedarikci_tc=@tc,tedarikci_firma=@firma where tedarikci_id = @id", baglanti);

                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@ad", TextBox1.Text);
                komut.Parameters.AddWithValue("@soyad", TextBox2.Text);
                komut.Parameters.AddWithValue("@tc", TextBox4.Text);
                komut.Parameters.AddWithValue("@firma", TextBox8.Text);

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