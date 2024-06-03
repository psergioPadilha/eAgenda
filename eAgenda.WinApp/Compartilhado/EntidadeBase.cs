﻿
using System.Collections.Generic;

namespace eAgenda.WinApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract List<string> Validar();

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    }
}
