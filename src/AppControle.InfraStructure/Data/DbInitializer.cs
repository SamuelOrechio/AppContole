using AppControle.AplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppControle.InfraStructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.PessoaTipos.Any())
            {
                return;
            }

            var pessoaTipos = new PessoaTipo[]
            {
                new PessoaTipo
                {
                    Descricao = "Pessoa Física"
                },

                new PessoaTipo
                {
                    Descricao = "Pessoa Jurídica"
                }
            };
            context.AddRange(pessoaTipos);
            context.SaveChanges();
        }
    }
}
