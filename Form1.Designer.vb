<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.lblDepDate = New System.Windows.Forms.Label()
        Me.lblRetDate = New System.Windows.Forms.Label()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.cboDepartCity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBookIt = New System.Windows.Forms.Button()
        Me.picDep = New System.Windows.Forms.PictureBox()
        Me.picDest = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCities = New System.Windows.Forms.Button()
        CType(Me.picDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(90, 12)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(153, 26)
        Me.txtFName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(264, 300)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 26)
        Me.btnProcess.TabIndex = 7
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(507, 300)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 26)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dtpDeparture
        '
        Me.dtpDeparture.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText
        Me.dtpDeparture.Location = New System.Drawing.Point(27, 73)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(216, 20)
        Me.dtpDeparture.TabIndex = 3
        '
        'lblDepDate
        '
        Me.lblDepDate.AutoSize = True
        Me.lblDepDate.Location = New System.Drawing.Point(24, 57)
        Me.lblDepDate.Name = "lblDepDate"
        Me.lblDepDate.Size = New System.Drawing.Size(57, 13)
        Me.lblDepDate.TabIndex = 5
        Me.lblDepDate.Text = "Departure:"
        Me.lblDepDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRetDate
        '
        Me.lblRetDate.AutoSize = True
        Me.lblRetDate.Location = New System.Drawing.Point(24, 102)
        Me.lblRetDate.Name = "lblRetDate"
        Me.lblRetDate.Size = New System.Drawing.Size(63, 13)
        Me.lblRetDate.TabIndex = 7
        Me.lblRetDate.Text = "Return Trip:"
        Me.lblRetDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpReturn
        '
        Me.dtpReturn.Location = New System.Drawing.Point(27, 118)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(216, 20)
        Me.dtpReturn.TabIndex = 4
        '
        'cboDepartCity
        '
        Me.cboDepartCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartCity.FormattingEnabled = True
        Me.cboDepartCity.Location = New System.Drawing.Point(264, 73)
        Me.cboDepartCity.Name = "cboDepartCity"
        Me.cboDepartCity.Size = New System.Drawing.Size(156, 21)
        Me.cboDepartCity.Sorted = True
        Me.cboDepartCity.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Departure City:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(423, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Destination:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboDestination
        '
        Me.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(426, 73)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(156, 21)
        Me.cboDestination.Sorted = True
        Me.cboDestination.TabIndex = 6
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(27, 159)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(216, 167)
        Me.lblOutput.TabIndex = 99
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(426, 300)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 26)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBookIt
        '
        Me.btnBookIt.Location = New System.Drawing.Point(345, 300)
        Me.btnBookIt.Name = "btnBookIt"
        Me.btnBookIt.Size = New System.Drawing.Size(75, 26)
        Me.btnBookIt.TabIndex = 8
        Me.btnBookIt.Text = "&Commit"
        Me.btnBookIt.UseVisualStyleBackColor = True
        '
        'picDep
        '
        Me.picDep.Location = New System.Drawing.Point(264, 100)
        Me.picDep.Name = "picDep"
        Me.picDep.Size = New System.Drawing.Size(156, 194)
        Me.picDep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDep.TabIndex = 15
        Me.picDep.TabStop = False
        '
        'picDest
        '
        Me.picDest.Location = New System.Drawing.Point(426, 100)
        Me.picDest.Name = "picDest"
        Me.picDest.Size = New System.Drawing.Size(156, 194)
        Me.picDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDest.TabIndex = 16
        Me.picDest.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 339)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(598, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(42, 17)
        Me.tslStatus.Text = "Ready!"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(328, 12)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(153, 26)
        Me.txtLName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Last Name:"
        '
        'btnCities
        '
        Me.btnCities.Location = New System.Drawing.Point(487, 12)
        Me.btnCities.Name = "btnCities"
        Me.btnCities.Size = New System.Drawing.Size(95, 26)
        Me.btnCities.TabIndex = 99
        Me.btnCities.TabStop = False
        Me.btnCities.Text = "Cities &Mtc"
        Me.btnCities.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 361)
        Me.Controls.Add(Me.btnCities)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.picDest)
        Me.Controls.Add(Me.picDep)
        Me.Controls.Add(Me.btnBookIt)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboDestination)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboDepartCity)
        Me.Controls.Add(Me.lblRetDate)
        Me.Controls.Add(Me.dtpReturn)
        Me.Controls.Add(Me.lblDepDate)
        Me.Controls.Add(Me.dtpDeparture)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Playground"
        CType(Me.picDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDepDate As System.Windows.Forms.Label
    Friend WithEvents lblRetDate As System.Windows.Forms.Label
    Friend WithEvents dtpReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboDepartCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboDestination As System.Windows.Forms.ComboBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnBookIt As System.Windows.Forms.Button
    Friend WithEvents picDep As System.Windows.Forms.PictureBox
    Friend WithEvents picDest As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCities As System.Windows.Forms.Button

End Class
