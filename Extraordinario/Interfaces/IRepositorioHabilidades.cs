namespace Extraordinario;

public interface IRepositorioHabilidades
{
    IHabilidad BuscarHabilidad(string idHabilidad);
    IHabilidad BuscarHabilidad(ClasePersonajeEnum clasePersonaje, int nivelRequerido);
    List<IHabilidad> BuscarHabilidades();
    List<IHabilidad> BuscarHabilidades(ClasePersonajeEnum clasePersonaje);
    List<IHabilidad> BuscarHabilidades(ClasePersonajeEnum clasePersonaje, int nivelLimite);
    void AgregarHabilidad(IHabilidad habilidad);
}
