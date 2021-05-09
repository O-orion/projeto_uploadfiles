using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace UploadArquivos.Controllers{
    public class UploadController : Controller{
         public interface IFormFile{
            public string ContentDisposition { get;}
            public string ContentType { get; }
            public string FileName { get; }
            public Microsoft.AspNetCore.Http.IHeaderDictionary Headers {get;}
            public long Length { get; }
            public string Name { get; }
            //MÉTODOS
            public System.IO.Stream OpenReadStream ();
            public System.Threading.Tasks.Task CopyToAsync ( System.IO.Stream target,
             System.Threading.CancellationToken cancellationToken = default
            );
            public void CopyTO (System.IO.Stream target);
        } 

        //Instanciando IHostingEnvionment
        IHostingEnvironment _appEnvironment;
        public UploadController(IHostingEnvironment env)
        {
            _appEnvironment = env;
            
        }

        //retornando formulario
        public IActionResult Index(){
            return View();
        }

        public async Task<IActionResult> EnviarArquivo(List<IFormFile> arquivos){
            long tamanhoArquivo = arquivos.Sum(f => f.Length);
            var caminhoArquivo = Path.GetTempFileName();
            string nome ="";
            

            foreach(var arquivo in arquivos){
                nome = arquivo.FileName;
                if(arquivo == null  || arquivo.Length==0){
                    ViewData["Error"] = "Error: nenhum arquivo foi selecionado";
                    return View(ViewData);
                }

                string arquivosRecebidos = "Usuario_arquivo";
                string nomeArquivo = "Arquivo_Usuario_" + DateTime.Now.Millisecond.ToString();

                if(arquivo.FileName.Contains(",jpg")){
                    nomeArquivo += ".jpg";
                }else if(arquivo.FileName.Contains(".docx")){
                    nomeArquivo += ".docx";
                }else if(arquivo.FileName.Contains(".png")){
                    nomeArquivo += ".png";
                }else if(arquivo.FileName.Contains(".pdf")){
                    nomeArquivo += ".pdf";
                }else{
                    nomeArquivo += ".temp";
                }

                string caminho_wwroot = _appEnvironment.WebRootPath;
                string armazemDeArquivos = caminho_wwroot +"\\"+ arquivosRecebidos +"\\";
                string caminhoDestinoArquivoOriginal = armazemDeArquivos + "\\Recebidos\\" + nomeArquivo;
                using(var stream = new FileStream(caminhoDestinoArquivoOriginal, FileMode.Create)){
                    await arquivo.CopyToAsync(stream);
                }

            }
            ViewData["Resultado"] = "Upload realizado com sucesso!";
            return View(ViewData);

        }
        


    }
}