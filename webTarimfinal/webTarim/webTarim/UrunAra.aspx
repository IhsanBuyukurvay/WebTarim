<%@ Page Title="" Language="C#" MasterPageFile="~/Uretici.Master" AutoEventWireup="true" CodeBehind="UrunAra.aspx.cs" Inherits="webTarim.UrunAra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    
        .auto-style4 {
            width: 583px;
        }
        .auto-style9 {
            width: 207px;
        }
    
        .auto-style8 {
            width: 877px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1> ÜRÜN ARA </h1>


     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Barkod No:"></asp:Label>
&nbsp;
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="Ara" Width="79px" />
     <br />
     <br />
     <br />
    <asp:DataList ID="DataList1" runat="server" Width="608px" >
        <ItemTemplate>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style9">
                      <a href ="UrunGoruntule.aspx?urun_id=<%# Eval("urun_id") %>">  <asp:Label ID="Label5" runat="server" Text='<%# Eval("urun_tur") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("urun_tarih") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("urun_barkod") %>'></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
     <br />
     <br />
     <br />
     <br />
     <br />


</asp:Content>
