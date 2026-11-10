using System.ComponentModel;

namespace WinFormsApp3;

partial class AddEditStudent
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        tbId = new System.Windows.Forms.TextBox();
        lbId = new System.Windows.Forms.Label();
        lbName = new System.Windows.Forms.Label();
        tbName = new System.Windows.Forms.TextBox();
        lbSurname = new System.Windows.Forms.Label();
        tbSurname = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        tbMath = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        tbTech = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        tbPhis = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        tbLangPol = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        tbLangFor = new System.Windows.Forms.TextBox();
        rtbComments = new System.Windows.Forms.RichTextBox();
        label1 = new System.Windows.Forms.Label();
        btnCancel = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        cbExtraActivities = new System.Windows.Forms.CheckBox();
        label2 = new System.Windows.Forms.Label();
        tbGroup = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // tbId
        // 
        tbId.Location = new System.Drawing.Point(112, 9);
        tbId.Name = "tbId";
        tbId.ReadOnly = true;
        tbId.Size = new System.Drawing.Size(342, 23);
        tbId.TabIndex = 0;
        tbId.UseWaitCursor = true;
        // 
        // lbId
        // 
        lbId.Location = new System.Drawing.Point(12, 12);
        lbId.Name = "lbId";
        lbId.Size = new System.Drawing.Size(45, 20);
        lbId.TabIndex = 1;
        lbId.Text = "Id:";
        lbId.UseWaitCursor = true;
        // 
        // lbName
        // 
        lbName.Location = new System.Drawing.Point(12, 41);
        lbName.Name = "lbName";
        lbName.Size = new System.Drawing.Size(45, 20);
        lbName.TabIndex = 3;
        lbName.Text = "Imię:";
        lbName.UseWaitCursor = true;
        // 
        // tbName
        // 
        tbName.Location = new System.Drawing.Point(112, 38);
        tbName.Name = "tbName";
        tbName.Size = new System.Drawing.Size(342, 23);
        tbName.TabIndex = 2;
        tbName.UseWaitCursor = true;
        // 
        // lbSurname
        // 
        lbSurname.Location = new System.Drawing.Point(12, 70);
        lbSurname.Name = "lbSurname";
        lbSurname.Size = new System.Drawing.Size(64, 20);
        lbSurname.TabIndex = 5;
        lbSurname.Text = "Nazwisko:";
        lbSurname.UseWaitCursor = true;
        // 
        // tbSurname
        // 
        tbSurname.Location = new System.Drawing.Point(112, 67);
        tbSurname.Name = "tbSurname";
        tbSurname.Size = new System.Drawing.Size(342, 23);
        tbSurname.TabIndex = 4;
        tbSurname.UseWaitCursor = true;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(12, 99);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(94, 20);
        label3.TabIndex = 7;
        label3.Text = "Matematyka:";
        label3.UseWaitCursor = true;
        // 
        // tbMath
        // 
        tbMath.Location = new System.Drawing.Point(112, 96);
        tbMath.Name = "tbMath";
        tbMath.Size = new System.Drawing.Size(342, 23);
        tbMath.TabIndex = 6;
        tbMath.UseWaitCursor = true;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(12, 128);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(94, 20);
        label4.TabIndex = 9;
        label4.Text = "Technologia:";
        label4.UseWaitCursor = true;
        // 
        // tbTech
        // 
        tbTech.Location = new System.Drawing.Point(112, 125);
        tbTech.Name = "tbTech";
        tbTech.Size = new System.Drawing.Size(342, 23);
        tbTech.TabIndex = 8;
        tbTech.UseWaitCursor = true;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(12, 157);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(94, 20);
        label5.TabIndex = 11;
        label5.Text = "Fizyka:";
        label5.UseWaitCursor = true;
        // 
        // tbPhis
        // 
        tbPhis.Location = new System.Drawing.Point(112, 154);
        tbPhis.Name = "tbPhis";
        tbPhis.Size = new System.Drawing.Size(342, 23);
        tbPhis.TabIndex = 10;
        tbPhis.UseWaitCursor = true;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(12, 186);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(94, 20);
        label6.TabIndex = 13;
        label6.Text = "Jęz. pol.:";
        label6.UseWaitCursor = true;
        // 
        // tbLangPol
        // 
        tbLangPol.Location = new System.Drawing.Point(112, 183);
        tbLangPol.Name = "tbLangPol";
        tbLangPol.Size = new System.Drawing.Size(342, 23);
        tbLangPol.TabIndex = 12;
        tbLangPol.UseWaitCursor = true;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(12, 215);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(94, 20);
        label7.TabIndex = 15;
        label7.Text = "Jęz. obc.:";
        label7.UseWaitCursor = true;
        // 
        // tbLangFor
        // 
        tbLangFor.Location = new System.Drawing.Point(112, 212);
        tbLangFor.Name = "tbLangFor";
        tbLangFor.Size = new System.Drawing.Size(342, 23);
        tbLangFor.TabIndex = 14;
        tbLangFor.UseWaitCursor = true;
        // 
        // rtbComments
        // 
        rtbComments.Location = new System.Drawing.Point(112, 278);
        rtbComments.Name = "rtbComments";
        rtbComments.Size = new System.Drawing.Size(341, 77);
        rtbComments.TabIndex = 16;
        rtbComments.Text = "";
        rtbComments.UseWaitCursor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 281);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(94, 20);
        label1.TabIndex = 17;
        label1.Text = "Uwagi:";
        label1.UseWaitCursor = true;
        // 
        // btnCancel
        // 
        btnCancel.Location = new System.Drawing.Point(119, 409);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(158, 28);
        btnCancel.TabIndex = 18;
        btnCancel.Text = "Anuluj";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.UseWaitCursor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new System.Drawing.Point(295, 409);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(158, 28);
        btnSave.TabIndex = 19;
        btnSave.Text = "Zapisz";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.UseWaitCursor = true;
        btnSave.Click += btnSave_Click;
        // 
        // cbExtraActivities
        // 
        cbExtraActivities.Location = new System.Drawing.Point(112, 361);
        cbExtraActivities.Name = "cbExtraActivities";
        cbExtraActivities.Size = new System.Drawing.Size(133, 31);
        cbExtraActivities.TabIndex = 20;
        cbExtraActivities.Text = "Zajęcia dodatkowe";
        cbExtraActivities.UseVisualStyleBackColor = true;
        cbExtraActivities.UseWaitCursor = true;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(11, 244);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(94, 20);
        label2.TabIndex = 22;
        label2.Text = "Id Grupy:";
        label2.UseWaitCursor = true;
        // 
        // tbGroup
        // 
        tbGroup.Location = new System.Drawing.Point(111, 241);
        tbGroup.Name = "tbGroup";
        tbGroup.Size = new System.Drawing.Size(342, 23);
        tbGroup.TabIndex = 21;
        tbGroup.UseWaitCursor = true;
        // 
        // AddEditStudent
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(484, 450);
        Controls.Add(label2);
        Controls.Add(tbGroup);
        Controls.Add(cbExtraActivities);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Controls.Add(label1);
        Controls.Add(rtbComments);
        Controls.Add(label7);
        Controls.Add(tbLangFor);
        Controls.Add(label6);
        Controls.Add(tbLangPol);
        Controls.Add(label5);
        Controls.Add(tbPhis);
        Controls.Add(label4);
        Controls.Add(tbTech);
        Controls.Add(label3);
        Controls.Add(tbMath);
        Controls.Add(lbSurname);
        Controls.Add(tbSurname);
        Controls.Add(lbName);
        Controls.Add(tbName);
        Controls.Add(lbId);
        Controls.Add(tbId);
        MaximumSize = new System.Drawing.Size(500, 489);
        MinimumSize = new System.Drawing.Size(500, 489);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Dodawanie Ucznia";
        UseWaitCursor = true;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbGroup;

    private System.Windows.Forms.CheckBox cbExtraActivities;

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;

    private System.Windows.Forms.Label lbName;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.Label lbSurname;
    private System.Windows.Forms.TextBox tbSurname;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbMath;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbTech;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbPhis;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbLangPol;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox tbLangFor;
    private System.Windows.Forms.RichTextBox rtbComments;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox tbId;
    private System.Windows.Forms.Label lbId;

    #endregion
}