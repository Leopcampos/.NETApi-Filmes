﻿using System.ComponentModel.DataAnnotations;

namespace Filmes.Models;

public class Sessao
{
    public int Id { get; set; }

    [Required]
    public int FilmeId { get; set; }
    public virtual Filme Filme { get; set; }

    public int? CinemaId { get; set; }
    public virtual Cinema Cinema { get; set; }
}