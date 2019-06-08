namespace AppControle.AplicationCore.Entity
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public int PessoaId { get; set; }
        public int PessoaTipoId { get; set; }
        public virtual PessoaTipo PessoaTipo { get; set; }
    }
}
