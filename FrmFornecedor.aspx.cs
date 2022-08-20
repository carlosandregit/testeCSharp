﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Repository;

namespace WebApplication1
{
    public partial class FrmFornecedor : System.Web.UI.Page
    {
        private FornecedorRepository fornecedorRepository;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }

        public void Consulta(int id)
        {
            fornecedorRepository = new FornecedorRepository();
            var result = fornecedorRepository.ConsultarPorID(id);

            if (result != null)
            {
                txtIdFornecedor.Text = result.IdFornecedor.ToString();
                txtRazaoSocial.Text = result.RazaoSocial;
                txtCNPJ.Text = result.CNPJ.ToString();
                txtUF.Text = result.UF.ToString();
                txtEmail.Text = result.EmailContato.ToString();
                txtNomeContato.Text = result.NomeContato.ToString();

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Sem Registro') ", true);
                LimparTela();
            }               

        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text != "")
                Consulta(int.Parse(txtIdFornecedor.Text));
            else
                ConsultarSemId();
        }
        protected void ConsultarSemId()
        {
            fornecedorRepository = new FornecedorRepository();
            var result = fornecedorRepository.Consult();

            gdvGridview.DataSource = result;
            gdvGridview.DataBind();
        }
        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtIdFornecedor.Text != "")
            {
                fornecedorRepository = new FornecedorRepository();
                var result = fornecedorRepository.AlterarPorId(int.Parse(txtIdFornecedor.Text), txtRazaoSocial.Text, txtCNPJ.Text, txtUF.Text, txtEmail.Text, txtNomeContato.Text);
                if (result != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Alterado com sucesso') ", true);
                    Consulta(result.IdFornecedor);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Erro ao alterar') ", true);
                    LimparTela();
                }
            }
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('É preciso informar o ID Fornecedor') ", true);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            fornecedorRepository = new FornecedorRepository();  
            
            if(txtIdFornecedor.Text != "")
            {
                var result = fornecedorRepository.DeletarRegistro(int.Parse(txtIdFornecedor.Text));

                if (result != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Erro ao excluir') ", true);
                    LimparTela();
                }
                else
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Excluido com sucesso') ", true);
            }
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Preciso Informa o ID fornecedor') ", true);


        }

        protected void Inserir_Click(object sender, EventArgs e)
        {
            fornecedorRepository = new FornecedorRepository();
            var result = fornecedorRepository.InserRegistro(txtRazaoSocial.Text, txtCNPJ.Text, txtUF.Text, txtEmail.Text, txtNomeContato.Text);
            if (result != null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Inserido com sucesso') ", true);
                Consulta(result.IdFornecedor);
            }
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Erro ao inserir') ", true);
        }

        protected void Limpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        public void LimparTela()
        {
            txtIdFornecedor.Text = " ";
            txtRazaoSocial.Text = " ";
            txtCNPJ.Text = " ";
            txtUF.Text = " ";
            txtEmail.Text = " ";
            txtNomeContato.Text = " ";
        }
    }
}