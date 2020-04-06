private void BTExibeFilas_Click(object sender, EventArgs e)
{
    //int remove;
    while (filaNMe.Count != 0)
    {
        LBNumMenores.Items.Add(filaNMe.Dequeue());
    }
    while (filaNMa.Count != 0)
    {
        LBNumMaiores.Items.Add(filaNMa.Dequeue());
    }
}

private void BTInsereFila_Click(object sender, EventArgs e)
{
    int valor;
    //Inicializa(ref fila);
    valor = Convert.ToInt32(TBValor.Text);
    fila.Enqueue(valor);
    TBValor.Clear();
    TBValor.Focus();
    //Evento voltar o foco para o input

}
private void TBValor_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
    {
        BTInsereFila_Click(this, new EventArgs());
    }
}
private void BTDivide2Filas_Click(object sender, EventArgs e)
{
    int vPrioridade, remove;
    vPrioridade = Convert.ToInt32(TBValorP.Text);
    while (fila.Count != 0)
    {
        remove = Convert.ToInt32(fila.Dequeue());
        if (remove < vPrioridade)
            filaNMe.Enqueue(remove);
        else if (remove > vPrioridade)
            filaNMa.Enqueue(remove);
    }
    BTExibeFilas.Focus();
    //for (i = 0; i < LBNumMenores; i++)
}
private void TBValorP_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
    {
        BTDivide2Filas_Click(this, new EventArgs());
    }
}