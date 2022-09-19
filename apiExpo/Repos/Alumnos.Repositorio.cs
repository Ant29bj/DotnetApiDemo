using System.Collections.Generic;
using System.Linq;
using apiExpo.Modelos; 

namespace apiExpo.Repos{
  public class AlumnosRepos{

    public static List<AlumnosModel> _listaAlumnos = new List<AlumnosModel>(){
      new AlumnosModel() {Id = 1, Nombre = "Jessica", Apellido = "Wardweek"},
      new AlumnosModel() {Id = 2, Nombre = "Reyna", Apellido = "Bolder"},
      new AlumnosModel() {Id = 3, Nombre = "Martin", Apellido = "Bineador"}
    };

    public IEnumerable<AlumnosModel> ObtenerAlumnos(){
      return _listaAlumnos;
    }

    public AlumnosModel ObtenerAlumno(int id){
      var alumno = _listaAlumnos.Where(cli => cli.Id == id);
      return alumno.FirstOrDefault();

    }
    

    public void Agregar(AlumnosModel alumno){
      _listaAlumnos.Add(alumno);
    }

    public void Borrar(int id){
      var alumno = _listaAlumnos.Where(cli => cli.Id == id);
      _listaAlumnos.Remove(alumno.FirstOrDefault());
    
    }

  }
}
