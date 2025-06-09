using CV.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ProyectosModel : PageModel
{
    public List<ProyectoDestacado> Proyectos { get; set; }

    public void OnGet()
    {
        Proyectos = new List<ProyectoDestacado>
        {
            new ProyectoDestacado { Nombre = "Trabajo de Fin de Grado", LogoUrl = "/images/riunet.png", Enlace = "https://riunet.upv.es/entities/publication/b110e89a-b36d-4d10-a61c-d9146488bd19" },
            new ProyectoDestacado { Nombre = "Moody.AI", LogoUrl = "/images/Moody.png", Enlace = "https://www.linkedin.com/feed/update/urn:li:activity:7222195782358040576/" }
        };
    }
}
