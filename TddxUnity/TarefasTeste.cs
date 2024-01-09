using Domain;

namespace TddxUnity
{
    public class TarefasTeste
    {
        [Fact]
        public void CriarTarefasComSucesso()
        {
            var titulo = "Teste";
            var descricao = "Descrição";
            var dataVencimento = DateTime.Now;
            var prioridade = 1;
            var etiquetas = new List<string>() { "teste1", "teste2"};
            
            //Act
            var tarefa = new Tarefa(titulo, descricao, dataVencimento, prioridade, etiquetas);
            
            //Aserts
            Assert.Equal(tarefa.Titulo, titulo);
            Assert.Equal(tarefa.Descricao, descricao);
            Assert.Equal(tarefa.dataVencimento, dataVencimento);
        }
    }
}