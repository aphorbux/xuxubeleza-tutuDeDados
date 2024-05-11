namespace Modelo{

public class MenuItem
{
    public string descricao;
    public List<MenuItem> itens;
    public MenuItem(string descricao)
    {
        this.descricao = descricao;
        itens = new List<MenuItem>();
    }
}
}