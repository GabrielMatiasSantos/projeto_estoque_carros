namespace estoque_carros.Dominio.Resultados
{
    public class Resultado1<T>: Resultado where T : class
    {
        private T? dados;

        private Resultado1(bool sucesso, bool falhaCatch, T? dados, string mensagem): base(sucesso, falhaCatch, mensagem)
        {         
            this.dados = dados;          
        }

        private Resultado1(bool sucesso, T? dados) : base(sucesso)
        {
            this.dados = dados;
        }

        public T Dados
        {
            get { return this.dados!; }
        }

        public static Resultado1<T> Sucesso1(T dados)
        {
            return new Resultado1<T>(true, dados);
        }

        public static Resultado1<T> Falha(string mensagem)
        {
            return new Resultado1<T>(false, false, null, mensagem);
        }

        public static Resultado1<T> Falha(Exception erro)
        {
            return new Resultado1<T>(false, true, null, "Ocorreu um problema na execução da solicitação. Verifique o log de erro para mais detalhes");
        }        
    }
}
