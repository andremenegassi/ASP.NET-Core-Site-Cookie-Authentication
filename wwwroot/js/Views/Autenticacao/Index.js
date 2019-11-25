
document.getElementById("entrar").onclick = autenticar;

function autenticar() {

    if (!document.forms[0].checkValidity()) {
        alert("Verifique os campos inválidos.");
    }

    document.getElementById("entrar").classList.add("disable");
    document.getElementById("imgLoading").style.display = "inline";
    document.getElementById("divLoading").style.display = "flex";
    let dados = {
        email: document.getElementById("email").value,
        senha: document.getElementById("senha").value
    }

    let config = {
        method: "POST",
        headers: {
            "Content-Type":"application/json"
        },
        body: JSON.stringify(dados)
    }

    fetch("/autenticacao/autenticar", config)
        .then((res) => res.json())
        .then((res) => {

            if (res.operacao) {
                localStorage.setItem("token", res.token);
                window.location.href = "/home";
            }
            else {
                document.getElementById("divMsg").innerHTML = res.msg;
            }
            document.getElementById("entrar").classList.remove("disable");
            document.getElementById("imgLoading").style.display = "none";
            document.getElementById("divLoading").style.display = "none";

        })
        .catch(() => {
            document.getElementById("entrar").classList.remove("disable");
            document.getElementById("imgLoading").style.display = "none";
            document.getElementById("divLoading").style.display = "none";

            alert("Deu erro");
        });
   
        
}