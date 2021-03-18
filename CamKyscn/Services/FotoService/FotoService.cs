using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CamKyscn.Context;
using CamKyscn.Dtos.Foto;
using CamKyscn.Entities;
using Microsoft.AspNetCore.Hosting;

namespace CamKyscn.Services.FotoService
{
    public class FotoService : IFotoService
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment _env;

        public FotoService(ApplicationDbContext context, IWebHostEnvironment env)
        {
            this._context = context;
            this._env = env;
        }
        public async Task<ServiceResponse<GetFotoDTO>> AddFoto(AddFotoDTO foto)
        {
            // Genera el dia para la carpeta
            DateTime thisDay = DateTime.Now;
            DateTime today = DateTime.Today;
            String dateName = thisDay.ToString("yyyy-MM-dd");

            // Crea las rutas
            // string path = Path.Combine("http://localhost:5000/", "images/" + dateName).ToLower();
            string path = Path.Combine(_env.WebRootPath, "images/" + dateName).ToLower();
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            string pathFile = Path.Combine(path, foto.Foto.FileName);
            string pathFileLogo = Path.Combine(path, foto.Logo.FileName);

            

            // Guarda las imagenes en el directorio
            if (foto.Foto.Length > 0 && foto.Logo.Length > 0){
                using (Stream fileStream =  new FileStream(pathFile, FileMode.Create)){
                    await foto.Foto.CopyToAsync(fileStream);
                }
                using (Stream fileStream =  new FileStream(pathFileLogo, FileMode.Create)){
                    await foto.Logo.CopyToAsync(fileStream);
                }
            }

            // Guardar las fotos en la db
            Banda banda = _context.Bandas.FirstOrDefault(x => x.Codigo == foto.CodigoBanda);
            Paquete paquete = _context.Paquetes.FirstOrDefault(x => x.Id == banda.PaqueteId);
            
            string pathToFile = Path.Combine("http://localhost:5000/", "images/" + dateName, foto.Foto.FileName);
            string pathToFileLogo = Path.Combine("http://localhost:5000/", "images/" +dateName  , foto.Logo.FileName);

            if (today == paquete.Fecha)
            {
                paquete.Fotos.Add(new Fotos {
                    Ruta = pathToFile,
                    Ruta_Demo = pathToFileLogo,
                    PaqueteId = paquete.Id
                });
                _context.Update(paquete);
                await _context.SaveChangesAsync();
            }

            GetFotoDTO getFotoDto = new GetFotoDTO
            {
                CodigoBanda = foto.CodigoBanda,
                Foto = pathToFile,
                Logo = pathToFileLogo
            };

            ServiceResponse<GetFotoDTO> serviceResponse = new ServiceResponse<GetFotoDTO>();
            serviceResponse.Data = getFotoDto;
            serviceResponse.Message = "Foto agregada correctamente, paquete: " + paquete.Id;
            return serviceResponse;
        }

        private string RemoveWhiteSpaces(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}