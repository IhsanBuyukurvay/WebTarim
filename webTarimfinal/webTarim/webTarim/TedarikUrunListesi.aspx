<%@ Page Title="" Language="C#" MasterPageFile="~/Tedarikci.Master" AutoEventWireup="true" CodeBehind="TedarikUrunListesi.aspx.cs" Inherits="webTarim.TedarikUrunListesi" %>
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
    <h1> TEDARİK ÜRÜN LİSTESİ </h1>
    <p> &nbsp;
        <asp:Label ID="Label5" runat="server" ForeColor="#0066FF" Text="Alt Ürün"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" ForeColor="#0066FF" Text="Üretim Tarihi"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" ForeColor="#0066FF" Text="Son Kullanım Tarihi"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
<p> 
    <asp:DataList ID="DataList1" runat="server" Width="608px" >
        <ItemTemplate>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("alturun_ad") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("alturun_uretimtarihi") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("alturun_skt") %>'></asp:Label>
                    </td>
                    <td>
                       <a href ="TedarikUrunListesi.aspx?alturun_id=<%# Eval("alturun_id") %>&islem=sil">  <asp:Image ID="Image2" runat="server" Height="23px" ImageUrl="~/RESİMLER/delete.png" Width="36px" /></a>
                    </td>
                    <td>
                      <a href ="TedarikUrunGuncelle.aspx?alturun_id=<%# Eval("alturun_id") %>&islem=guncelle">   <asp:Image ID="Image1" runat="server" Height="35px" ImageUrl="~/RESİMLER/update.jpg" Width="37px" /></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    </p>
</asp:Content>
