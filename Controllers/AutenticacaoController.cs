using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    //[Authorize("Bearer")]
    [Authorize("CookieAuth")]
    public class AutenticacaoController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public JsonResult Autenticar(
            [FromBody] Newtonsoft.Json.Linq.JObject dados)
        {

            bool ok;
            string msg = "";

            BL.AutenticacaoBL ubl = new BL.AutenticacaoBL();
            //(ok, msg) = ubl.ValidarAutenticacao(dados["email"].ToString(), dados["senha"].ToString());
            ok = true;
            if (ok)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                   new GenericIdentity(dados["email"].ToString(), "Login"),
                   new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, dados["email"].ToString())
                   }
               );

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                Microsoft.AspNetCore.Authentication.AuthenticationHttpContextExtensions.SignInAsync(HttpContext, principal);
            }


            return Json(new
            {
                operacao = ok,
                msg
            });

        }

        [HttpPost]
        public JsonResult ExemploNewtonSoft([FromBody] Newtonsoft.Json.Linq.JObject dados)
        {

            //Usa classes e deserializa para objeto
            Models.FamiliaDonald familia = dados.ToObject<Models.FamiliaDonald>();

            //Item-item
            string tio = dados["tio"].ToString();
            int idade = dados.Value<int>("idade");

            var sobrinhos = dados["sobrinhos"].ToArray();

            foreach (var item in sobrinhos)
            {
                string nome = item["nome"].ToString();
            }

            //Deserializando para objetos anônimos.
            dynamic objDyn =
            Newtonsoft.Json.JsonConvert.DeserializeObject(dados.ToString());

            tio = objDyn.tio;
            idade = objDyn.idade;

            Newtonsoft.Json.Linq.JArray sobrinhos2 =
                objDyn.sobrinhos;

            //Exemplo de objeto anônimo

            var obj = new
            {
                nome = "Andre",
                idade = 38,
                sobrinhos = new object[] {

                    new {
                        nome = "111"
                    },
                    new {
                        nome = "222"
                    }
                }

            };



            return Json(new
            {

            });
        }
    }
}