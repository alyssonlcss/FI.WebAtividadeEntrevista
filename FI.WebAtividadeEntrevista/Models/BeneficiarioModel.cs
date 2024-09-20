using Forms.Attributes;
using System.ComponentModel.DataAnnotations;

public class Beneficiario
{

    /// <summary>
    /// CPF
    /// </summary>
    [Required(ErrorMessage = "O CPF � obrigat�rio.")]
    [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF dos beneficiarios devem estar no formato 000.000.000-00")]
    [CpfValidation(ErrorMessage = "Pelo menos um dos CPF's dos benefic�arios � invalido.")]
    public string CPF { get; set; }

    /// <summary>
    /// Nome
    /// </summary>
    public string Nome { get; set; }
    
}
