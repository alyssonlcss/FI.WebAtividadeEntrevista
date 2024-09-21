using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    using System.Collections.Generic;

    namespace FI.AtividadeEntrevista.BLL
    {
        public class BoBeneficiario
        {
            /// <summary>
            /// Inclui um novo beneficiário
            /// </summary>
            /// <param name="beneficiario">Objeto de beneficiário</param>
            public void Incluir(List<DML.Beneficiario> beneficiarios, long idCliente)
            {
                DAL.DaoBeneficiario daoBeneficiario = new DAL.DaoBeneficiario();
                daoBeneficiario.IncluirBeneficiarios(beneficiarios, idCliente);
            }
        }
    }

}
