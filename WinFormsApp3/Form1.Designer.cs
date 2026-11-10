namespace WinFormsApp3;

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
        btnAdd = new System.Windows.Forms.Button();
        btnEdit = new System.Windows.Forms.Button();
        btnDelete = new System.Windows.Forms.Button();
        btnRefresh = new System.Windows.Forms.Button();
        dgvDiary = new System.Windows.Forms.DataGridView();
        comboBox1 = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dgvDiary).BeginInit();
        SuspendLayout();
        // 
        // btnAdd
        // 
        btnAdd.BackColor = System.Drawing.Color.OliveDrab;
        btnAdd.Location = new System.Drawing.Point(21, 12);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(105, 29);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Dodaj";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.BackColor = System.Drawing.Color.Orange;
        btnEdit.Location = new System.Drawing.Point(132, 12);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new System.Drawing.Size(105, 29);
        btnEdit.TabIndex = 1;
        btnEdit.Text = "Edytuj";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = System.Drawing.Color.IndianRed;
        btnDelete.Location = new System.Drawing.Point(243, 12);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new System.Drawing.Size(105, 29);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Usuń";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
        btnRefresh.Location = new System.Drawing.Point(354, 12);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new System.Drawing.Size(105, 29);
        btnRefresh.TabIndex = 3;
        btnRefresh.Text = "Odśwież";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // dgvDiary
        // 
        dgvDiary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvDiary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvDiary.BackgroundColor = System.Drawing.Color.White;
        dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDiary.Location = new System.Drawing.Point(15, 57);
        dgvDiary.Name = "dgvDiary";
        dgvDiary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvDiary.Size = new System.Drawing.Size(773, 381);
        dgvDiary.TabIndex = 4;
        dgvDiary.Text = "dataGridView1";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(534, 16);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(105, 23);
        comboBox1.TabIndex = 5;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(483, 16);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(45, 21);
        label1.TabIndex = 6;
        label1.Text = "Grupa:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Controls.Add(dgvDiary);
        Controls.Add(btnRefresh);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnAdd);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Dziennik Ucznia";
        FormClosed += Form1_FormClosed;
        ((System.ComponentModel.ISupportInitialize)dgvDiary).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.DataGridView dgvDiary;

    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnRefresh;

    private System.Windows.Forms.Button btnAdd;

    #endregion
}