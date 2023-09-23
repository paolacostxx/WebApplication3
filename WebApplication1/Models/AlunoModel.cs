using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlunoModel
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public DateTime Matricula { get; set; }
        public  int Faltas { get; set; }

        public static List<AlunoModel> CriarLista()

        {
            var lista = new List<AlunoModel>();
            lista.Add(new AlunoModel() { Nome = "Nicolas", Curso = "DS", Matricula = DateTime.Now, Faltas = 5 });
            lista.Add(new AlunoModel() { Nome = "Emerson", Curso = "DS", Matricula = DateTime.Now, Faltas = 5 });
            lista.Add(new AlunoModel() { Nome = "Ana", Curso = "DS", Matricula = DateTime.Now, Faltas = 5 });
            lista.Add(new AlunoModel() { Nome = "Vinicius", Curso = "DS", Matricula = DateTime.Now, Faltas = 5 });

            return lista;
        }
    }

}
