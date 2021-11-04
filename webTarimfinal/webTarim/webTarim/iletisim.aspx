<%@ Page Title="" Language="C#" MasterPageFile="~/anasayfa.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="webTarim.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1> İLETİŞİM </h1>
    
  İsim:<br>
  <input type="text" name="firstname" value="">
  <br>
  Soyisim:<br>
  <input type="text" name="lastname" value="">
  <br>
  Ülke:
    <select id="country" name="country">
      <option value="Türkiye">Türkiye</option>
      <option value="Azerbeycan">Azerbeycan</option>
      <option value="Suriye">Suriye</option>
    </select>
  <br>
  Konu:<br>
  <textarea id="subject" name="subject" placeholder="Bir şeyler yaz.." style="height:200px"></textarea>
  <br><br>
  <input type="submit" value="Submit">
    
</asp:Content>
