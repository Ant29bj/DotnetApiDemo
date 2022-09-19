using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apiExpo.Modelos;
using apiExpo.Repos; 
namespace apiExpo.Controllers;

[ApiController]
[Route("api/[controller]")]

public class alumno : ControllerBase
{

  //ObtenerAlumnos
 [HttpGet] 
 public IActionResult Get(){
    AlumnosRepos rpAl = new AlumnosRepos();
    return Ok(rpAl.ObtenerAlumnos());
    
  }


  //Obtener un solo alumno
  [HttpGet ("{id}")]
  public IActionResult Get(int id){
    AlumnosRepos rpAl = new AlumnosRepos();
    var cliret = rpAl.ObtenerAlumno(id); 
    if(cliret == null){
      var nf = NotFound("El alumno "+id.ToString()+" no existe");
      return nf;
    }
    return Ok(cliret);
  }

  //Agregar 
  [HttpPost("Agregar")]
  public IActionResult agregarAlumno(AlumnosModel alumno){
    AlumnosRepos rpAl = new AlumnosRepos();
    rpAl.Agregar(alumno);
    return CreatedAtAction(nameof(agregarAlumno),alumno);
  }

  //Eliminar
  [HttpDelete("{id}")]
  public IActionResult borrarAlumno(int id){
    AlumnosRepos rpAl = new AlumnosRepos();
    rpAl.Borrar(id);
    return CreatedAtAction(nameof(borrarAlumno),"Alumno Eliminado");
  }
    
}
