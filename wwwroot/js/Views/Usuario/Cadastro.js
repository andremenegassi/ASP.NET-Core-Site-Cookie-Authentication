
document.getElementById('btnCadastrar').onclick = cadastrar

let usuarioId = 0;

async function cadastrar() {

    if (!ecValidation.formIsValid()) {
        return;
    }

    if (!document.forms[0].checkValidity()) {
        document.getElementById("divMsg").classList.remove('invisible')
        document.getElementById("msgTexto").innerHTML = "Verifique os dados!"
    }
    else {
        let dados = {
            nome: document.getElementById("iNome").value,
            email: document.getElementById("iEmail").value,
            senha: document.getElementById("iSenha").value
        }

        let config = {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(dados)
        }

        await fetch("/Usuario/Cadastrar", config)
            .then(resposta => resposta.json())
            .then(resposta => {
                document.getElementById("divMsg").classList.remove('invisible')
                document.getElementById("msgTexto").innerHTML = resposta.msg;
                usuarioId = resposta.usuarioId;
            })
            .catch(() => {
                alert("Ops, algo deu errado!")
            });

        if (usuarioId > 0)
            await enviarFoto();

    }
    
}


async function enviarFoto() {

    let dados = new FormData(document.forms[0]);
    dados.append("usuarioId", usuarioId);
    dados.append("foto", document.getElementById("iFoto").files[0]);

    let config = {
        method: "POST",
        headers: {
            "Accept": "application/json"
        },
        body:dados
    }

    await fetch("/Usuario/CadastrarFoto", config)
        .then(resposta => resposta.json())
        .then(resposta => {
            console.log(resposta);
        })
        .catch(() => {
            alert("Ops, algo deu errado na foto!")
        });
}
 