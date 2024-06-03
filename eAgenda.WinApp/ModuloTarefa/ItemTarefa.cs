﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Concluido { get; set; }
        public Tarefa Tarefa { get; set; }

        public ItemTarefa(string titulo)
        {
            this.Titulo = titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        public void Marcarpendente()
        {
            Concluido = false;
        }

        public override string ToString()
        {
            return $"{Titulo}";
        }
    }
}
