﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmFornecedor.aspx.cs" Inherits="WebApplication1.FrmFornecedor" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Fornecedor</title>
    <style>
        body {
            background-color: white;
            width: 100vw;
            height: 100vh;
        }

        h1 {
            text-align: center;
        }
        .center{
            display: flex;
            justify-content: center;
            flex-direction: column;
            align-items: center;
        }
        .pricipal {
            display: flex;
            flex-direction: row;
            height: 23vh;
        }

        .label {
            display: flex;
            justify-content: space-between;
            flex-direction: column;
        }

        .input {
            display: flex;
            justify-content: space-between;
            flex-direction: column;
        }

        .btn {
            padding: 0.3rem 0.5rem;
            margin-left: 108px;
        }
        .grid{
           display: flex;
           margin-left: 107px;
           flex-direction: column;
        }
    </style>
</head>
<body>
    <header>
        <h1>Fornecedor</h1>
    </header>
    <form id="form1" runat="server">
        <div class="center">
            <div class="pricipal">

                <div class="label">
                    <asp:Label ID="lblFornecedor" runat="server" Text="ID Fornecedor:"></asp:Label>
                    <asp:Label ID="lblazaoSocial" runat="server" Text="Razão Social:"></asp:Label>
                    <asp:Label ID="lblCNPJ" runat="server" Text="CNPJ:"></asp:Label>
                    <asp:Label ID="lblUF" runat="server" Text="UF:"></asp:Label>
                    <asp:Label ID="lblEmail" runat="server" Text="Email Contato:"></asp:Label>           
                    <asp:Label ID="lblNomeContato" runat="server" Text="Nome Contato:"></asp:Label>
                </div>
                <div class="input">
                    <asp:TextBox ID="txtIdFornecedor" runat="server" Width="40px" type="number"></asp:TextBox>
                    <asp:TextBox ID="txtRazaoSocial" runat="server" Width="350px"></asp:TextBox>
                    <asp:TextBox ID="txtCNPJ" runat="server" Width="150px"></asp:TextBox>
                    <asp:TextBox ID="txtUF" runat="server" Width="40px"></asp:TextBox>
                    <asp:TextBox ID="txtEmail" runat="server" Width="350px"></asp:TextBox>
                    <asp:TextBox ID="txtNomeContato" runat="server" Width="350px"></asp:TextBox>

                </div>
            </div>
            <div class="btn">
                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
                <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
                <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="Inserir_Click" />
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="Limpar_Click" />
            </div>                    
        </div>
        <br /><br />
        <div class="grid">
            <asp:GridView ID="gdvGridview" runat="server" AutoGenerateColumns="true">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
