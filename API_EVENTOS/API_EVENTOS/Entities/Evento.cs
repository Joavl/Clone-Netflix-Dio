namespace API_EVENTOS.Entities
{
    public class Eventos
    {
        public Eventos(string titulo, string descricao, string organizador, DateTime dataInicio, DateTime dataFim)
        {
            Titulo = titulo;
            Descricao = descricao;
            Organizador = organizador;
            DataInicio = dataInicio;
            DataFim = dataFim;

            DataCriacao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Organizador { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataCriacao { get; set; }

        public void Update(string titulo, string descricao, DateTime dataInicio, DateTime dataFim)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
