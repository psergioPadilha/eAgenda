using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public Contato(string nome, string telefone, string email, string empresa, string cargo)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
            this.Empresa = empresa;
            this.Cargo = cargo;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");
            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");
            if (string.IsNullOrEmpty(Email.Trim()))
                erros.Add("O campo \"e-mail\" é obrigatório");
            if (string.IsNullOrEmpty(Empresa.Trim()))
                erros.Add("O campo \"empresa\" é obrigatório");
            if (string.IsNullOrEmpty(Cargo.Trim()))
                erros.Add("O campo \"cargo\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Contato atualizado = (Contato)novoRegistro;

            Nome = atualizado.Nome;
            Telefone = atualizado.Telefone;
            Email = atualizado.Email;
            Empresa = atualizado.Empresa;
            Cargo = atualizado.Cargo;
        }

        public override string ToString()
        {
            return $"ID: 0, NOME: {Nome}, TELEFONE: {Telefone}, E-MAIL: {Email}, EMPRESA: {Empresa}, CARGO: {Cargo}";
        }
    }
}
