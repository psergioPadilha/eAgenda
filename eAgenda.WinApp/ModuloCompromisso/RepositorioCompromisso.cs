using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return registros.FindAll(compromisso =>
                (compromisso.DataCompromisso >= dataInicio) &&
                (compromisso.DataCompromisso <= dataTermino));
        }

        public List<Compromisso> SelecionarCompromissoHoje()
        {
            return registros.FindAll(compromisso =>
                (compromisso.DataCompromisso > DateTime.Today.AddDays(-1)) &&
                (compromisso.DataCompromisso < DateTime.Today.AddDays(+1)));

        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            return registros.FindAll(compromisso => compromisso.DataCompromisso >= DateTime.Today);
        }

        public List<Compromisso> SlecionarCompromissosPassados()
        {
            return registros.FindAll(compromisso => compromisso.DataCompromisso < DateTime.Today);
        }
    }
}
