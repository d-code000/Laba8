using System.Data;

namespace Laba_8;

public partial class Form1 : Form
{
    private int[,] _matrix = new int[12, 12];

    public Form1()
    {
        InitializeComponent();
        dataGridView.AllowUserToAddRows = false;
    }
    
    private void RandomMatrix()
    {
        Random random = new Random();
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
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
            table.Columns.Add("", typeof(int));
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
        RandomMatrix();
        dataGridView.DataSource = ConvertMatrixToDataTable(_matrix);
        int sum = 0;
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < _matrix.GetLength(1); j++)
            {
                sum += _matrix[i, j];
            }
        }
        resultTextBox.Text = sum.ToString();
    }
}