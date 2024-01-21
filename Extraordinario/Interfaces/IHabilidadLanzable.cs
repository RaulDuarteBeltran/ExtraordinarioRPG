namespace Extraordinario;

public interface IHabilidadLanzable
{
    int CostoDeMana { get; }
    bool Autoaplicable { get; }
    TipoHabilidadEnum Tipo { get; }
    int Potencia { get; }
    void Lanzar(IPersonaje lanzador, IPersonaje objetivo);
}
