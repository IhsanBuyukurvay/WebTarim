<%@ Page Title="" Language="C#" MasterPageFile="~/yonetici.Master" AutoEventWireup="true" CodeBehind="TedarikciListesi.aspx.cs" Inherits="webTarim.TedarikciListesi" %>
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
    <h1> TEDARİKÇİ LİSTESİ </h1>
<p> 
    <asp:DataList ID="DataList1" runat="server" Width="608px" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
        <ItemTemplate>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("tedarikci_ad") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("tedarikci_soyad") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("tedarikci_firma") %>'></asp:Label>
                    </td>
                    <td>
                       <a href ="TedarikciListesi.aspx?tedarikci_id=<%# Eval("tedarikci_id") %>&islem=sil">  <asp:Image ID="Image2" runat="server" Height="23px" ImageUrl="~/RESİMLER/delete.png" Width="36px" /></a>
                    </td>
                    <td>
                      <a href ="TedarikciGuncelle.aspx?tedarikci_id=<%# Eval("tedarikci_id") %>&islem=guncelle">   <asp:Image ID="Image1" runat="server" Height="24px" ImageUrl="~/RESİMLER/update.jpg" Width="37px" /></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    </p>
</asp:Content>