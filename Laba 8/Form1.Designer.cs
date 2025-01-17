namespace Laba_8;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView = new System.Windows.Forms.DataGridView();
        resultLabel = new System.Windows.Forms.Label();
        startButton = new System.Windows.Forms.Button();
        resultTextBox = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        SuspendLayout();
        // 
        // dataGridView
        // 
        dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView.ColumnHeadersHeight = 29;
        dataGridView.ColumnHeadersVisible = false;
        dataGridView.Location = new System.Drawing.Point(0, -2);
        dataGridView.Name = "dataGridView";
        dataGridView.ReadOnly = true;
        dataGridView.RowHeadersVisible = false;
        dataGridView.RowHeadersWidth = 51;
        dataGridView.Size = new System.Drawing.Size(613, 378);
        dataGridView.TabIndex = 0;
        // 
        // resultLabel
        // 
        resultLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
        resultLabel.Location = new System.Drawing.Point(164, 393);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new System.Drawing.Size(164, 44);
        resultLabel.TabIndex = 1;
        resultLabel.Text = "Результат: ";
        // 
        // startButton
        // 
        startButton.Font = new System.Drawing.Font("Segoe UI", 16F);
        startButton.Location = new System.Drawing.Point(17, 382);
        startButton.Name = "startButton";
        startButton.Size = new System.Drawing.Size(141, 54);
        startButton.TabIndex = 2;
        startButton.Text = "ПУСК";
        startButton.UseVisualStyleBackColor = true;
        startButton.Click += startButton_Click;
        // 
        // resultTextBox
        // 
        resultTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
        resultTextBox.Location = new System.Drawing.Point(334, 393);
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ReadOnly = true;
        resultTextBox.Size = new System.Drawing.Size(251, 43);
        resultTextBox.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(615, 450);
        Controls.Add(resultTextBox);
        Controls.Add(startButton);
        Controls.Add(resultLabel);
        Controls.Add(dataGridView);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.Label resultLabel;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.TextBox resultTextBox;

    #endregion
}