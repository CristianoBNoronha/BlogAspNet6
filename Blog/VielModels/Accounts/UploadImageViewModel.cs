using System.ComponentModel.DataAnnotations;

namespace Blog.VielModels.Accounts;

public class UploadImageViewModel
{
    [Required(ErrorMessage = "Imagem inválida.")]
    public string Base64Image { get; set; }
}