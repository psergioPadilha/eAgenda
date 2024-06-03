using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto {  get; set; }
        public DateTime DataCompromisso { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get; set; }
        public string Local {  get; set; }
        public string Modo {  get; set; }

        public Compromisso(string assunto, DateTime dataCompromisso, TimeSpan horaInicio, TimeSpan horaTermino,
            Contato contato, string local, string modo)
        {
            this.Assunto = assunto;
            this.DataCompromisso = dataCompromisso;
            this.HoraInicio = horaInicio;
            this.HoraTermino = horaTermino;
            this.Contato = contato;
            this.Local = local;
            this.Modo = modo;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if(string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"assunto\" é obrigatório!");
            if (string.IsNullOrEmpty(Local.Trim()))
                erros.Add("O campo \"local\" é obrigatório!");
            if (string.IsNullOrEmpty(DataCompromisso.ToShortDateString().Trim()))
                erros.Add("O campo \"repositorioCompromissos\" é obrigatório!");
            if (string.IsNullOrEmpty(HoraInicio.ToString().Trim()))
                erros.Add("O campo \"hora início\" é obrigatório!");
            if (string.IsNullOrEmpty(HoraTermino.ToString().Trim()))
                erros.Add("O campo \"hora término\" é obrigatório!");
            if (Contato.Nome == null)
                erros.Add("O campo \"contato\" é obrigatório!");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Local = atualizado.Local;
            DataCompromisso = atualizado.DataCompromisso;
            HoraInicio = atualizado.HoraInicio;
            HoraTermino = atualizado.HoraTermino;
            Contato = atualizado.Contato;
            Local = atualizado.Local;
            Modo = atualizado.Modo;
        }

        public override string ToString()
        {
            return $"ID: 0, ASSUNTO: {Assunto}, LOCAL: {Local}, DATA: {DataCompromisso.ToShortDateString()}," +
                $"INÍCIO: {HoraInicio.ToString(@"hh\:mm")}, TÉRMINO: {HoraTermino.ToString(@"hh\:mm")}, CONTATO: {Contato.Nome}, LOCAL: {Local}, MODO: {Modo}";
        }
    }
}