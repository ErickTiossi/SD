namespace Front.Moldels
{
    public class UsuarioModel
    {
        public UsuarioModel(int id, string name, string cpf) {
            Id = id;
            Name = name;
            Cpf = cpf;
        }

        public UsuarioModel(string name, string cpf) {
            Name = name;
            Cpf = cpf;
        }


        public UsuarioModel() {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

    }
}
