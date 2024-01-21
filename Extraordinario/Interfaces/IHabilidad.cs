namespace Extraordinario;

public interface IHabilidad
{
    string Id { get; }
    string Nombre { get; }
    int NivelRequerido { get; }
    ClaseHabilidadEnum ClaseHabilidad { get; }
    ClasePersonajeEnum ClasePersonajeAsociada { get; }
}
