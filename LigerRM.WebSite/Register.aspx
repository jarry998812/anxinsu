﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Detail.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:100%; text-align:center">
    <table border="1" cellpadding="1" cellspacing="1" width="90%" style="background-color:Gray;">
        <tr><td bgcolor="White"></td>
            <td bgcolor="White" 
                style="font-size: x-large; text-align: left; width: 774px;">系统注册</td></tr>
        <tr><td bgcolor="White">用户码：</td><td align="left" bgcolor="White" 
                style="width: 774px">
            <asp:Label ID="lblUserCode" runat="server"></asp:Label>
            </td></tr>
        <tr><td bgcolor="White">注册号：</td><td align="left" bgcolor="White" 
                style="width: 774px">
            <asp:TextBox ID="txtCrackNumber" runat="server" Width="400px"></asp:TextBox>
            </td></tr>
        <tr><td bgcolor="White">&nbsp;</td><td align="left" bgcolor="White" 
                style="width: 774px">
            <asp:Button ID="btnRegister" runat="server" CssClass="buttonDefault" 
                Text="注册" onclick="btnRegister_Click" />
            </td></tr>
    </table></div>
</asp:Content>

