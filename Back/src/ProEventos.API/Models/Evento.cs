namespace ProEventos.API.Models
{

    public class Evento {
        
        public int Id { get; set; }
        public string Local { get; set; }
        public string Data { get; set; }
        public string Nome { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }


}