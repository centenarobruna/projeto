using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class CidadeService : ICidadeService
    {
        private IRepositoryBase<Cidade> _repository { get; set; }
        public CidadeService(IRepositoryBase<Cidade> repository)
        {
            _repository = repository;
        }
        public Cidade BuscaPorCep(string id)
        {
            var obj = _repository.Query(x => x.Cep == id).FirstOrDefault();
            return obj;
        }

        public List<Cidade> listaCidades()
        {
            return _repository.Query(x => 1 == 1).ToList();
        }

        public void Salvar(Cidade obj)
        {
            if (String.IsNullOrEmpty(obj.Nome))
            {
                throw new Exception("Informe o cep");
            }
            _repository.Save(obj);
            _repository.SaveChanges();
        }
    }
}
