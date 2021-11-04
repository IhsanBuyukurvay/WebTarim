<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici.Master" AutoEventWireup="true" CodeBehind="UreticiListesi.aspx.cs" Inherits="webTarim.UreticiListesi" %>
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
    <h1> ÜRETİCİ LİSTESİ </h1>
<p> 
    <asp:DataList ID="DataList1" runat="server" Width="608px" >
        <ItemTemplate>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("uretici_ad") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("uretici_soyad") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("uretici_firma") %>'></asp:Label>
                    </td>
                    <td>
                       <a href ="UreticiListesi.aspx?uretici_id=<%# Eval("uretici_id") %>&islem=sil">  <asp:Image ID="Image2" runat="server" Height="23px" ImageUrl="~/RESİMLER/delete.png" Width="36px" /></a>
                    </td>
                    <td>
                      <a href ="UreticiGuncelle.aspx?uretici_id=<%# Eval("uretici_id") %>&islem=guncelle">   <asp:Image ID="Image1" runat="server" Height="35px" ImageUrl="~/RESİMLER/update.jpg" Width="37px" /></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    </p>
</asp:Content>