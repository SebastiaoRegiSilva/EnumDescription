using System.ComponentModel;

/// <summary>Enum para testar o uso de enuns annotations.</summary>
public enum tipoDeGarrafa
{
    [Description("Quebra fácil.")]
    Vidro = 1,
    [Description("Fogo derrete!")]
    Plastico = 2,
    [Description("Não vendo! Me devolve!")]
    Tupperware = 3,
    [Description("Não beba na minha garrafa!")]
    Dagua = 4,
    [Description("Amassa fácil!")]
    Aluminio = 5
}