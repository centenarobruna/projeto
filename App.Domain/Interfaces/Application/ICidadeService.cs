using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface ICidadeService
    {
        Cidade BuscaPorCep(string Cep);
        List<Cidade> listaCidades();
        void Salvar(Cidade obj);

    }
}
