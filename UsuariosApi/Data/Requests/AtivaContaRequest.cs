using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace UsuariosAPI.Data.Requests
{
    public class AtivaContaRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string CodigoDeAtivacao { get; set; }
    }
}
