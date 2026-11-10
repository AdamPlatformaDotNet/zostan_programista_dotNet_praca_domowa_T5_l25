namespace WinFormsApp3;

public partial class AddEditStudent : Form
{
    private int _studentId;
    public delegate void SimpleDelegate();
    public event SimpleDelegate SimpleEvent;
    
    public AddEditStudent()
    {
        InitializeComponent();
    }
    public AddEditStudent(int studentId)
    {
        InitializeComponent();
        GetStudentData(studentId);
    }

    private void GetStudentData(int studentId)
    {
        var students = Program.FileHelper.DeserializeFromFile();
        _studentId =  studentId;
        var student = students.FirstOrDefault(x => x.Id == _studentId);
        Text = "Edytowanie danych ucznia";
        if (student == null)
        {
            throw new Exception("Brak studenta o tym ID");
        }
        FillStudentData(student);
    }

    private void FillStudentData(Student student)
    {
        tbName.Select();
        
        tbId.Text =  student.Id.ToString();
        tbName.Text =  student.FirstName;
        tbSurname.Text =  student.LastName;
        tbMath.Text =  student.Math;
        tbPhis.Text =  student.Physic;
        tbTech.Text =  student.Tech;
        rtbComments.Text =  student.Comments;
        tbLangPol.Text =  student.PolishLanguage;
        tbLangFor.Text =  student.ForeignLanguage;
        tbGroup.Text = student.GroupId;
        cbExtraActivities.Checked = student.ExtraActivities;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var students = Program.FileHelper.DeserializeFromFile();

        if (_studentId != 0)
        {
            students.RemoveAll(x => x.Id == _studentId);
        }
        else
        {
            var studentWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();
            _studentId = studentWithHighestId == null ?  1 : studentWithHighestId.Id  + 1;
        }
        
        var student = new Student
        {
            Id = _studentId,
            FirstName = tbName.Text,
            LastName = tbSurname.Text,
            Comments = rtbComments.Text,
            ForeignLanguage = tbLangFor.Text,
            PolishLanguage = tbLangPol.Text,
            Math = tbMath.Text,
            Tech = tbTech.Text,
            Physic = tbPhis.Text,
            GroupId = string.IsNullOrWhiteSpace(tbGroup.Text) ? "-1" : tbGroup.Text,
            ExtraActivities = cbExtraActivities.Checked,
        };
        
        students.Add(student);
        Program.FileHelper.SerializeToFile(students);
        Close();
    }
}