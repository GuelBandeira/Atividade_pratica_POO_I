using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Tarefas.src
{
    public class Tarefa
    {
        private int _numeroTarefa;
        private string _titulo;
        private string _descricao;
        private bool _status;

        public static int _concluidas;

        //Polimorfismo de sobrecarga
        public Tarefa(int numeroTarefa, Usuario titular)
        {
            _numeroTarefa = numeroTarefa;
            Titular = titular;
        }

        public Tarefa(int numeroTarefa, string titulo, string descricao,bool status, Usuario titular) 
        {
            _numeroTarefa = numeroTarefa;
            _titulo = titulo;
            _descricao = descricao;
            _status = status;
            Titular = titular;

            if (_status)
            {
                _concluidas++;
            }
        }

        public int NumeroTarefa {
            get => _numeroTarefa; 
            private set => _numeroTarefa = value; 
        }
        public string Titulo { 
            get => _titulo; 
            private set => _titulo = value; 
        }
        public string Descricao { 
            get => _descricao; 
            private set => _descricao = value; 
        }
        public bool Status
        {
            get => _status;
            private set => _status = value;
        }

        public int Concluidas
        {
            get => _concluidas;
        }


        public Usuario Titular { get; set; }

    }
}
