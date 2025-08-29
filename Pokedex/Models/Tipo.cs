using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR;

namespace Pokedex.Models;

[Table("Tipo")]
public class Tipo
{
    [Key]
    public uint Id { get; set; }

    [StringLength(30)]
    [Required(ErrorMessage = "Por favor, informe o nome")]
    public string Nome { get; set; }

    [StringLength(25)]
    [Required(ErrorMessage = "Por favor, informe a cor")]

    public string Cor { get; set;} = "#000";

    public ICollection<PokemonTipo> Pokemons { get; set; }
}
