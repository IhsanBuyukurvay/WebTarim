<%@ Page Title="" Language="C#" MasterPageFile="~/Uretici.Master" AutoEventWireup="true" CodeBehind="UrunGoruntule.aspx.cs" Inherits="webTarim.UrunGoruntule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
       <h1> ÜRÜN BİLGİSİ </h1>
    <p>
        <strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image1" runat="server" Height="247px" Width="245px" />
        </strong></p>
       <p>
           &nbsp;</p>
    <p>
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Text="Ürün Türü:"></asp:Label>
        </strong></p>
    <p>
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Yer:"></asp:Label>
        &nbsp;</strong></p>
    
        <strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label7" runat="server" Text="İlaç:"></asp:Label>
                <br />
                </strong>
    <p>
        <strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Toprak:"></asp:Label>
        &nbsp;</strong></p>
    
        <strong>
    
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Ürün Boyu:"></asp:Label>
    &nbsp;<br />
    </strong>
     
    
    
    <p>
        <strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Üretim Tarihi:"></asp:Label>
        &nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>
        <strong>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="Son Kullanma Tarihi:"></asp:Label>
        &nbsp;</strong></p>
    
        <strong>
    
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="Barkod No:"></asp:Label>
    &nbsp;<br />
    </strong>
</asp:Content>
