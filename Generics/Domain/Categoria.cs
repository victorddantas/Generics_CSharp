namespace Generics.Domain
{
    public class Categoria : Entity
    {
        public Categoria(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Nome}";
        }

        public override bool Equals(object? obj)
        {
            var categoria = obj as Categoria;
            if (categoria == null)
                return false;
            return categoria.Id == Id;
        }
    }
}
