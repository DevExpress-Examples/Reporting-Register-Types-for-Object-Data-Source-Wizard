﻿<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Default.aspx.vb" Inherits="WebForms.Default" %>
<%@ Register Assembly="DevExpress.XtraReports.v23.2.Web.WebForms, Version=23.2.1.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
	<dx:ASPxReportDesigner EnableRichTextEditor="False" ID="ASPxReportDesigner1" runat="server">
	</dx:ASPxReportDesigner>
</asp:Content>