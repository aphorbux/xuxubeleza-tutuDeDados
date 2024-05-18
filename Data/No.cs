using Modelo;

namespace Data
{
    public class No
    {
        public Funcionario? valor;
        public List<No> filhos;
        public No()
        {
            filhos = new List<No>();
        }

        public void Add(No no){
            filhos.Add(no);
        }
    }
}
