﻿namespace TP_POO_R.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; // Inicializar com valor padrão
        public string Telefone { get; set; } = string.Empty; // Inicializar com valor padrão

    }
}