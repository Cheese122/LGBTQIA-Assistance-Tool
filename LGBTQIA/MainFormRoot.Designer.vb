<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFormRoot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cbxAspec = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSexualOrientation = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxRomanticOrientation = New System.Windows.Forms.ComboBox()
        Me.chbxPoly = New System.Windows.Forms.CheckBox()
        Me.chbxQuestioning = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxSAB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblOutput.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOutput.Location = New System.Drawing.Point(507, 259)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(189, 45)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "You are: "
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxAspec
        '
        Me.cbxAspec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAspec.FormattingEnabled = True
        Me.cbxAspec.Items.AddRange(New Object() {"Allosexual (Not Aspec)", "Demisexual", "Gray Ace", "Asexual", "Other Aspec"})
        Me.cbxAspec.Location = New System.Drawing.Point(66, 215)
        Me.cbxAspec.Name = "cbxAspec"
        Me.cbxAspec.Size = New System.Drawing.Size(207, 22)
        Me.cbxAspec.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(55, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sexual Attraction Spectrum"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Alloromantic (Not Aromantic)", "Demiromantic", "Gray Romantic", "Aromantic", "Other Arospec"})
        Me.ComboBox2.Location = New System.Drawing.Point(66, 280)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(207, 22)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(55, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Romantic Attraction Spectrum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(55, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 45)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Orientation"
        '
        'cbxSexualOrientation
        '
        Me.cbxSexualOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSexualOrientation.FormattingEnabled = True
        Me.cbxSexualOrientation.Items.AddRange(New Object() {"Heterosexual", "Homosexual", "Bisexual", "Pansexual", "Aspectrum", "Other"})
        Me.cbxSexualOrientation.Location = New System.Drawing.Point(66, 358)
        Me.cbxSexualOrientation.Name = "cbxSexualOrientation"
        Me.cbxSexualOrientation.Size = New System.Drawing.Size(207, 22)
        Me.cbxSexualOrientation.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(55, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sexual Orientation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(55, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Romantic Orientation"
        '
        'cbxRomanticOrientation
        '
        Me.cbxRomanticOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRomanticOrientation.FormattingEnabled = True
        Me.cbxRomanticOrientation.Items.AddRange(New Object() {"Same as Sexual Orientation", "Heteroromantic", "Homoromantic", "Biromantic", "Panromantic", "Arospec", "Other"})
        Me.cbxRomanticOrientation.Location = New System.Drawing.Point(66, 442)
        Me.cbxRomanticOrientation.Name = "cbxRomanticOrientation"
        Me.cbxRomanticOrientation.Size = New System.Drawing.Size(207, 22)
        Me.cbxRomanticOrientation.TabIndex = 9
        '
        'chbxPoly
        '
        Me.chbxPoly.AutoSize = True
        Me.chbxPoly.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chbxPoly.Location = New System.Drawing.Point(55, 486)
        Me.chbxPoly.Name = "chbxPoly"
        Me.chbxPoly.Size = New System.Drawing.Size(152, 27)
        Me.chbxPoly.TabIndex = 10
        Me.chbxPoly.Text = "Polyamorous"
        Me.chbxPoly.UseVisualStyleBackColor = True
        '
        'chbxQuestioning
        '
        Me.chbxQuestioning.AutoSize = True
        Me.chbxQuestioning.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chbxQuestioning.Location = New System.Drawing.Point(55, 519)
        Me.chbxQuestioning.Name = "chbxQuestioning"
        Me.chbxQuestioning.Size = New System.Drawing.Size(144, 27)
        Me.chbxQuestioning.TabIndex = 11
        Me.chbxQuestioning.Text = "Questioning"
        Me.chbxQuestioning.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(913, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 45)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(863, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sex assigned at birth "
        '
        'cbxSAB
        '
        Me.cbxSAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSAB.FormattingEnabled = True
        Me.cbxSAB.Items.AddRange(New Object() {"Male", "Female", "Intersex Variation"})
        Me.cbxSAB.Location = New System.Drawing.Point(876, 215)
        Me.cbxSAB.Name = "cbxSAB"
        Me.cbxSAB.Size = New System.Drawing.Size(207, 22)
        Me.cbxSAB.TabIndex = 14
        '
        'MainFormRoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.cbxSAB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chbxQuestioning)
        Me.Controls.Add(Me.chbxPoly)
        Me.Controls.Add(Me.cbxRomanticOrientation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxSexualOrientation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxAspec)
        Me.Controls.Add(Me.lblOutput)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(1200, 700)
        Me.Name = "MainFormRoot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LGBTQIA+ Assistance Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents cbxAspec As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxSexualOrientation As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxRomanticOrientation As ComboBox
    Friend WithEvents chbxPoly As CheckBox
    Friend WithEvents chbxQuestioning As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxSAB As ComboBox
End Class
