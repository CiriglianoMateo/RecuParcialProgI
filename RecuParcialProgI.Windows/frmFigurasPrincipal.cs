using RecuParcialProgI.Entidades;

namespace RecuParcialProgI.Windows
{
    public partial class frmFigurasPrincipal : Form
    {
        public frmFigurasPrincipal()
        {
            InitializeComponent();
        }
    }
}


    private void tsbNuevo_Click(object sender, EventArgs e)
    {
        frmFiguraAE frm = new frmFiguraAE() { Text = "Agregar figura" };
        DialogResult dr = frm.ShowDialog(this);
        if (dr == DialogResult.Cancel)
        {
            return;
        }
        Pentagono pentagono = frm.GetPentagono();
        DataGridViewRow fila = ConstruirFila();
        SetearFila(fila, pentagono);
        AgregarFila(fila);

        MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private DataGridViewRow ConstruirFila()
    {
        DataGridViewRow fila = new DataGridViewRow();
        fila.CreateCells(dgvDatos);
        return fila;
    }

    private void AgregarFila(DataGridViewRow fila)
    {
        dgvDatos.Rows.Add(fila);
    }

    private void SetearFila(DataGridViewRow fila, Pentagono pentagono)
    {
        if (pentagono != null)
        {
            fila.Cells[colLado.Index].Value = pentagono.Lado;
            fila.Cells[colArea.Index].Value = pentagono.Area;
            fila.Cells[colPerimetro.Index].Value = pentagono.Perimetro;
            fila.Cells[colApotema.Index].Value = pentagono.Apotema;
            fila.Cells[colBorde.Index].Value = pentagono.Borde;

            fila.Tag = pentagono;
        }
    
        
    }


