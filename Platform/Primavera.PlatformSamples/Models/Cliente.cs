using System;

namespace Primavera.PlatformSamples.Models
{
    public class Cliente
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Nif { get; set; }

        public override string ToString()
        {
            return $"{Codigo} — {Nome}";
        }
    }
}
