using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoluCSharp.Fund.Demo04.Models;
using SoluCSharp.Fund.Demo04.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoluCSharp.Fund.Demo04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] UsuarioDto oUsuarioDto)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (var db = new CursoWebAPIContext())
                {
                    Usuario oUsuario = new Usuario()
                    {
                        Nombre = oUsuarioDto.Nombre,
                        Pais = oUsuarioDto.Pais
                    };

                    db.Usuarios.Add(oUsuario);
                    db.SaveChanges();

                }

                respuesta.Exito = true;
                respuesta.Mensake = "Exito Insert";
                
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Mensake = "Error Insert";
            }
            return Ok(respuesta);

        }
    }
}
