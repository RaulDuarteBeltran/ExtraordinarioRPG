namespace Extraordinario;

public interface IPersonaje
{
    string Nombre { get; }
    int Nivel { get; }
    int Ataque { get; }
    int Defensa { get; }
    int VidaMaxima { get; }
    int VidaActual { get; set; }
    int ManaMaximo { get; }
    int ManaActual { get; set; }
    ClasePersonajeEnum Clase { get; }
    void SubirDeNivel();
    List<IHabilidad> ObtenerHabilidadesAprendidas();
    List<IHabilidad> ObtenerHabilidadesEquipadas();
    void EquiparHabilidad(IHabilidad habilidad);
    void DesequiparHabilidad(IHabilidad habilidad);
    void LanzarHabilidad(int indiceHabilidad, IPersonaje objetivo);
    void ExaminarPersonaje();
    void Morir();
}
