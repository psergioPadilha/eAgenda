using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();
        protected int contadorId = 1;

        #region Cadastra novo registro, recebe a entidade como parâmentro gera o id e adiciona no repositório de registro
        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId ++;
            registros.Add(novoRegistro);
        }
        #endregion

        #region Cadastra vários registros de uma única vez
        public void CadastrarVarios(List<T> novosRegistros)
        {
            foreach (T novoRegistro in novosRegistros)
                Cadastrar(novoRegistro);
        }
        #endregion

        #region Edita registro, recebe o id e a entidade como parâmentro e atualiza no repositório de registro
        public bool Editar(int id, T novaEntidade)
        {
            T registro = SelecionarPorId(id);
            if(registro == null)
                return false;

            registro.AtualizarRegistro(novaEntidade);

            return true;
        }
        #endregion

        #region Excluir registro, recebe o id da entidade que se deseja excluir,procura se existe um registro com o mesmo id, caso positivo exclui o registro e retorna verddadeiro
        public bool Excluir(int id)
        {
            return registros.Remove(SelecionarPorId(id));
        }
        #endregion

        #region Seleciona todos registro e retorna a lista
        public List<T> SelecionarTodos()
        {
            return registros;
        }
        #endregion

        #region Selecionar por id recebe o id da entidade que deseja ser consultada e se casa exista esse regitro retorna a entidade
        public T SelecionarPorId(int id)
        {
            return registros.Find(entidade => entidade.Id == id);
        }
        #endregion

        #region Existe registro recebe o id como parâmetro e verifica se existe um registro com o id de entrada
        public bool ExisteRegistro(int id)
        {
            return registros.Any(entidade => entidade.Id == id);
        }
        #endregion
    }
}
