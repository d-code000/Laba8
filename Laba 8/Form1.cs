using System.Data;

namespace Laba_8;

public partial class Form1 : Form
{
    private int[,] _matrix = new int[15, 15];

    public Form1()
    {
        InitializeComponent();
        RandomMatrix();
        dataGridView.DataSource = ConvertMatrixToDataTable(_matrix);
    }
    
    private void RandomMatrix()
    {
        Random random = new Random();
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                _matrix[i, j] = random.Next(-100, 100);
            }
        }
    }
    
    private DataTable ConvertMatrixToDataTable(int[,] matrix)
    {
        DataTable table = new DataTable();
        
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            table.Columns.Add($"Column {i + 1}", typeof(int));
        }
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            DataRow row = table.NewRow();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                row[j] = matrix[i, j];
            }
            table.Rows.Add(row);
        }

        return table;
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}