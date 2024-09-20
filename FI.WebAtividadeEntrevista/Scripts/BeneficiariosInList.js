let beneficiarios = [];

document.getElementById('btnIncluir').addEventListener('click', function (e) {
    e.preventDefault();

    const CPF = document.getElementById('CPFBeneficiario').value;
    const Nome = document.getElementById('NomeBeneficiario').value;

    const cpfExistente = beneficiarios.some(b => b.CPF === CPF);

    if (cpfExistente) {
        alert('Esse CPF já foi adicionado. Por favor, insira um CPF único.');
        return;
    }

    if (CPF && Nome) {
        beneficiarios.push({ CPF, Nome });

        const tbody = document.getElementById('tabelaBeneficiarios').querySelector('tbody');
        const tr = document.createElement('tr');
        tr.innerHTML = `
            <td>${CPF}</td>
            <td>${Nome}</td>
            <td>
                <button class="btn btn-primary btn-sm btnEdit">Alterar</button>
                <button class="btn btn-acao btn-sm btnDelete">Excluir</button> <!-- Classe btn-acao para azul -->
            </td>
        `;
        tbody.appendChild(tr);

        document.getElementById('CPFBeneficiario').value = '';
        document.getElementById('NomeBeneficiario').value = '';

        const btnEdit = tr.querySelector('.btnEdit');
        btnEdit.addEventListener('click', function () {
            document.getElementById('CPFBeneficiario').value = CPF;
            document.getElementById('NomeBeneficiario').value = Nome;
            tr.remove();
            beneficiarios = beneficiarios.filter(b => b.CPF !== CPF);
            document.getElementById('beneficiariosList').value = JSON.stringify(beneficiarios);
        });

        const btnDelete = tr.querySelector('.btnDelete');
        btnDelete.addEventListener('click', function () {
            tr.remove();
            beneficiarios = beneficiarios.filter(b => b.CPF !== CPF);
            document.getElementById('beneficiariosList').value = JSON.stringify(beneficiarios);
        });

        document.getElementById('beneficiariosList').value = JSON.stringify(beneficiarios);
    } else {
        alert('Por favor, preencha todos os campos.');
    }
});
