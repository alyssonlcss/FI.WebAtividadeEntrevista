using FI.AtividadeEntrevista.DML;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FI.AtividadeEntrevista.DAL
{
    /// <summary>
    /// Classe de acesso a dados de Beneficiário
    /// </summary>
    internal class DaoBeneficiario : AcessoDados
    {
        /// <summary>
        /// Inclui uma lista de beneficiários
        /// </summary>
        /// <param name="beneficiarios">Lista de objetos de beneficiário</param>
        /// <param name="idCliente">Id do cliente associado</param>
        internal void IncluirBeneficiarios(List<DML.Beneficiario> beneficiarios, long IdCliente)
        {
            foreach (var beneficiario in beneficiarios)
            {
                List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>
                {
                    new System.Data.SqlClient.SqlParameter("CPF", beneficiario.CPF),
                    new System.Data.SqlClient.SqlParameter("Nome", beneficiario.Nome),
                    new System.Data.SqlClient.SqlParameter("IdCliente", IdCliente)
                };

                base.Executar("FI_SP_IncBeneficiario", parametros);
            }
        }
    }
}
