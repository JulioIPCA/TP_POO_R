public class Recibo
{
    public int IdRecibo { get; set; }
    public int IdContrato { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    // Método para adicionar um recibo ao DataGridView
    public void AdicionarRecibo(DataGridView dataGridView)
    {
        // Cria uma instância do ReciboController, passando o DataGridView como parâmetro
        var reciboController = new ReciboController(dataGridView);

        // Chama o método AdicionarRecibo do ReciboController, passando o recibo atual (this)
        reciboController.AdicionarRecibo(this);
    }
}
