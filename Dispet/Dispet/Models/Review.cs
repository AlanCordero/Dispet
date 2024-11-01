namespace Dispet.Models
{
    public class Review
    {
        public int Rating { get; set; }       // Calificación (1-5 estrellas)
        public string Comment { get; set; }   // Comentario del usuario
        public string User { get; set; }      // Nombre del usuario
    }
}
