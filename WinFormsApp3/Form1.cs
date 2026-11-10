using Microsoft.VisualBasic;
using WinFormsApp3.Properties;

namespace WinFormsApp3;

public partial class Form1 : Form
{

    private bool _isLoadingGroups;
    private bool IsMaximize
    {
        get
        {
            return Settings.Default.IsMaximize;
        }
        set
        {
            Settings.Default.IsMaximize = value;
        }
    }
    
    private string IsGroupSelected
    {
        get
        {
            return Settings.Default.IsGroupSelected;
        }
        set
        {
            Settings.Default.IsGroupSelected = value;
        }
    }

    public Form1()
    {
        InitializeComponent();
        GroupsDiarySetup();
        SetColumnsHeader();
        if (IsMaximize)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
    
    private void RefreshDiary()
    {
        var students = Program.FileHelper.DeserializeFromFile();
        var linqStudents = IsGroupSelected != "-1" ? students.Where(x => x.GroupId == IsGroupSelected).ToList() : students;
        dgvDiary.DataSource = linqStudents;
    }

    private void SetGroupsList()
    {
        _isLoadingGroups = true;
        var students = Program.FileHelper.DeserializeFromFile();
        List<ComboboxItem> groupsList = new List<ComboboxItem>();
        var groups = students
            .Select(x => x.GroupId)
            .Distinct()
            .OrderBy(x => x)
            .ToList();
        comboBox1.DataSource = null;
        comboBox1.Items.Clear();
        
        foreach (var group in groups)
        {
            groupsList.Add(new ComboboxItem { Value = group, Label = group == "-1" ? "Wszyscy" : $@"Grupa {group}"});
        }

        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.DisplayMember = "Label";
        comboBox1.ValueMember = "Value";
        comboBox1.DataSource = groupsList;
        if (!groupsList.Any(x => x.Value == IsGroupSelected))
        {
            IsGroupSelected = "-1";
        }
        comboBox1.SelectedValue = IsGroupSelected;
        _isLoadingGroups = false;
    }
    
    private void GroupsDiarySetup()
    {
        RefreshDiary();
        SetGroupsList();
    }

    private void SetColumnsHeader()
    {
        dgvDiary.Columns[0].HeaderText = "Numer";
        dgvDiary.Columns[1].HeaderText = "Imię";
        dgvDiary.Columns[2].HeaderText = "Nazwisko";
        dgvDiary.Columns[3].HeaderText = "Uwagi";
        dgvDiary.Columns[4].HeaderText = "Matematyka";
        dgvDiary.Columns[5].HeaderText = "Technologia";
        dgvDiary.Columns[6].HeaderText = "Fizyka";
        dgvDiary.Columns[7].HeaderText = "Język Polski";
        dgvDiary.Columns[8].HeaderText = "Język Obcy";
        dgvDiary.Columns[9].HeaderText = "Grupa";
        dgvDiary.Columns[10].HeaderText = "Zajęcia dodatkowe";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var addEditStudent = new AddEditStudent();
        addEditStudent.FormClosing += AddEditStudent_FormClosing;
        addEditStudent.ShowDialog();
    }

    private void AddEditStudent_FormClosing(object sender, FormClosingEventArgs e)
    {
        GroupsDiarySetup();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvDiary.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a student");
            return;
        }
        var addEditStudent = new AddEditStudent(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
        addEditStudent.FormClosing += AddEditStudent_FormClosing;
        addEditStudent.ShowDialog();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvDiary.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a student");
            return;
        }

        var selectedStudent = dgvDiary.SelectedRows[0];
        var result = MessageBox.Show($"Czy na pewno chcesz usunąć {(
            selectedStudent.Cells[1].Value + " " + 
            selectedStudent.Cells[2].Value).Trim()}?", "Usuwanie ucznia", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK)
        {
            DeleteStudent(Convert.ToInt32(selectedStudent.Cells[0].Value));
            GroupsDiarySetup();
        }
    }

    private void DeleteStudent(int id)
    {
        var students = Program.FileHelper.DeserializeFromFile();
        students.RemoveAll(x => x.Id == id);
        Program.FileHelper.SerializeToFile(students);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        GroupsDiarySetup();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        IsMaximize = WindowState == FormWindowState.Maximized ? true : false;
        Settings.Default.Save();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_isLoadingGroups) return;
       
        string? groupName = comboBox1.SelectedValue?.ToString();
        if (groupName != null)
        {
            IsGroupSelected = groupName;
            Settings.Default.Save();
            RefreshDiary();
        }
        
    }
}