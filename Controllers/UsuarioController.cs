using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace HelloWorld.Controllers
{
    //[Authorize("Bearer")]
    [Authorize("CookieAuth")]
    public class UsuarioController : Controller
    {
        private IHostingEnvironment _env;

        public UsuarioController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Autenticar([FromBody] Newtonsoft.Json.Linq.JObject dados)
        {
            bool ok;
            string msg;

            BL.AutenticacaoBL uBl = new BL.AutenticacaoBL();

            (ok, msg) = uBl.ValidarAutenticacao(dados["email"].ToString(), dados["senha"].ToString());

            return Json(new
            {
                operacao = ok,
                msg = msg
            });
        }


        [HttpPost]
        [AllowAnonymous]
        public JsonResult Cadastrar([FromBody]Dictionary<string, string> dados)
        {
            Models.Usuario u = new Models.Usuario();

            bool ok;
            string msg;
            BL.UsuarioBL uBl = new BL.UsuarioBL();


            u.Nome = dados["nome"].Trim();
            u.Email = dados["email"].Trim();
            u.Senha = dados["senha"].Trim();
            (ok, msg) = uBl.Gravar(u);

            return Json(new
            {
                usuarioId = u.Id,
                operacao = ok,
                msg = msg
            }); ;
        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult CadastrarFoto()
        {
            string usuarioId = Request.Form["usuarioId"];
            bool operacao = false;
            if (Request.Form.Files.Count > 0)
            {
                var foto = Request.Form.Files[0];

                string nome = usuarioId + System.IO.Path.GetExtension(foto.FileName);

                string path = _env.ContentRootPath +
                              @"\Upload\Usuario\" +
                              nome;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    foto.CopyTo(stream);
                    BL.UsuarioBL uBl = new BL.UsuarioBL();
                    uBl.CadastrarFoto(int.Parse(usuarioId), nome);
                    operacao = true;
                }
            }

            return Json(new
            {
                operacao
            });
        }

        [HttpGet]
        public ActionResult ObterTodos()
        {
            BL.UsuarioBL uBl = new BL.UsuarioBL();
            ViewBag.Usuarios = uBl.ObterTodos();
            return View();
        }

        [HttpGet]
        public ActionResult ObterFoto(int id)
        {
            BL.UsuarioBL uBl = new BL.UsuarioBL();
            Models.Usuario u = uBl.ObterUsuario(id);

            if (!string.IsNullOrEmpty(u.Foto))
            {
                string path = _env.ContentRootPath + @"\Upload\usuario\" + u.Foto;
                byte[] foto = System.IO.File.ReadAllBytes(path);

                return File(foto, Utils.MimeTypeMap.GetMimeType(u.Foto));
            }
            return Content("");
        }




    }




}