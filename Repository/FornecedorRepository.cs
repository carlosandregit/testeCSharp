﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entity;

namespace WebApplication1.Repository
{
    public class FornecedorRepository
    {
        public Fornecedor ConsultarPorID(int id)
        {
            using (BDCADASTROEntities context = new BDCADASTROEntities())
            {
                return context.Fornecedor.Find(id);
            }
        }

        public Fornecedor AlterarPorId(int id, string razao, string cnpj, string uf, string email, string nome)
        {
            using (BDCADASTROEntities context = new BDCADASTROEntities())
            {
                Fornecedor f = context.Fornecedor.FirstOrDefault(x => x.IdFornecedor == id);
                f.RazaoSocial = razao;
                f.CNPJ = cnpj;
                f.UF = uf;
                f.EmailContato = email;
                f.NomeContato = nome;
                context.SaveChanges();

                return f;
            }
        }

        public Fornecedor DeletarRegistro(int id)
        {
            using (BDCADASTROEntities context = new BDCADASTROEntities())
            {
                Fornecedor f = context.Fornecedor.FirstOrDefault(x => x.IdFornecedor == id);
                context.Fornecedor.Remove(f);
                context.SaveChanges();

                return f;
            }
        }

        public Fornecedor InserRegistro(string razao, string cnpj, string uf, string email, string nome)
        {
            using (BDCADASTROEntities context = new BDCADASTROEntities())
            {
                Fornecedor f = new Fornecedor
                {                    
                    RazaoSocial = razao,
                    CNPJ = cnpj,
                    UF = uf,
                    EmailContato = email,
                    NomeContato = nome

                };
                context.Fornecedor.Add(f);
                context.SaveChanges();

                return f;
            }
        }

        public List<Fornecedor> Consult()
        {
            using (BDCADASTROEntities context = new BDCADASTROEntities())
            {
                return context.Fornecedor.ToList();
            }
        }
    }
}