namespace Domain
{
    public class Tarefa
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime dataVencimento { get; private set; }
        public int Prioridade { get; private set; }
        public List<string> Etiquetas { get; private set; } = new List<string>();
        
        public Tarefa(string titulo, string descricao, DateTime dataVencimento, int prioridade, List<string> etiquetas)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Descricao = descricao;
            this.dataVencimento = dataVencimento;
            Prioridade = prioridade;
            Etiquetas = etiquetas;
        }

    }
}

