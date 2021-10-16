namespace UCLFlix.Classes
{
    public class DistEucl
    {
        public Usuario User { get; set; }
        public double Distance { get; set; }

        public DistEucl(Usuario usuario, double distancia){
            User = usuario;
            Distance = distancia;
        }
    }
}