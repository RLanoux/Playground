<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cities
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
        Me.grpAddCities = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCityName = New System.Windows.Forms.TextBox()
        Me.btnAddCity = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemoveCity = New System.Windows.Forms.Button()
        Me.grpAddCities.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAddCities
        '
        Me.grpAddCities.Controls.Add(Me.btnClose)
        Me.grpAddCities.Controls.Add(Me.btnRemoveCity)
        Me.grpAddCities.Controls.Add(Me.btnAddCity)
        Me.grpAddCities.Controls.Add(Me.txtCityName)
        Me.grpAddCities.Controls.Add(Me.Label1)
        Me.grpAddCities.Location = New System.Drawing.Point(12, 12)
        Me.grpAddCities.Name = "grpAddCities"
        Me.grpAddCities.Size = New System.Drawing.Size(568, 331)
        Me.grpAddCities.TabIndex = 0
        Me.grpAddCities.TabStop = False
        Me.grpAddCities.Text = "Add/Delete Cities"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City Name"
        '
        'txtCityName
        '
        Me.txtCityName.Location = New System.Drawing.Point(76, 52)
        Me.txtCityName.Name = "txtCityName"
        Me.txtCityName.Size = New System.Drawing.Size(284, 20)
        Me.txtCityName.TabIndex = 1
        '
        'btnAddCity
        '
        Me.btnAddCity.Location = New System.Drawing.Point(366, 52)
        Me.btnAddCity.Name = "btnAddCity"
        Me.btnAddCity.Size = New System.Drawing.Size(95, 20)
        Me.btnAddCity.TabIndex = 2
        Me.btnAddCity.Text = "Add City"
        Me.btnAddCity.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(76, 78)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(284, 21)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close City Maintenance Form"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRemoveCity
        '
        Me.btnRemoveCity.Location = New System.Drawing.Point(467, 52)
        Me.btnRemoveCity.Name = "btnRemoveCity"
        Me.btnRemoveCity.Size = New System.Drawing.Size(95, 20)
        Me.btnRemoveCity.TabIndex = 3
        Me.btnRemoveCity.Text = "Delete City"
        Me.btnRemoveCity.UseVisualStyleBackColor = True
        '
        'Cities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 355)
        Me.Controls.Add(Me.grpAddCities)
        Me.Name = "Cities"
        Me.Text = "Cities Maintenance"
        Me.grpAddCities.ResumeLayout(False)
        Me.grpAddCities.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAddCities As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddCity As System.Windows.Forms.Button
    Friend WithEvents txtCityName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCity As System.Windows.Forms.Button
End Class
