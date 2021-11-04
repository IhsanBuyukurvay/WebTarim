<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici.Master" AutoEventWireup="true" CodeBehind="KullaniciListesi.aspx.cs" Inherits="webTarim.KullaniciListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
        width: 375px;
    }
    .auto-style6 {
        font-weight: bold;
    }
    
        .auto-style4 {
            width: 583px;
        }
        .auto-style8 {
            width: 877px;
        }
        .auto-style9 {
            width: 207px;
        }
    
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> KULLANICI LİSTESİ </h1>
<p> 
    <asp:DataList ID="DataList1" runat="server" Width="608px">
        <ItemTemplate>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("kullanici_ad") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("kullanici_soyad") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("telefon") %>'></asp:Label>
                    </td>
                    <td>
                       <a href ="KullaniciListesi.aspx?kullanici_id=<%# Eval("kullanici_id") %>&islem=sil">  <asp:Image ID="Image2" runat="server" Height="23px" ImageUrl="~/RESİMLER/delete.png" Width="36px" /></a>
                    </td>
                    <td>
                      <a href ="KullaniciGuncelle.aspx?kullanici_id=<%# Eval("kullanici_id") %>&islem=guncelle">   <asp:Image ID="Image1" runat="server" Height="23px" ImageUrl="~/RESİMLER/update.jpg" Width="36px" /></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    </p>
</asp:Content>