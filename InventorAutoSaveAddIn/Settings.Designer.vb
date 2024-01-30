<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LoadDefaults = New System.Windows.Forms.Button()
        Me.RemoveAfterManualSave = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RemovalUnits = New System.Windows.Forms.ComboBox()
        Me.HowLongAgoToRemove = New System.Windows.Forms.NumericUpDown()
        Me.NumberOfVersionsToKeep = New System.Windows.Forms.NumericUpDown()
        Me.KeepAllVersions = New System.Windows.Forms.RadioButton()
        Me.RemoveOlder = New System.Windows.Forms.RadioButton()
        Me.VersionsToKeep = New System.Windows.Forms.RadioButton()
        Me.Browse = New System.Windows.Forms.Button()
        Me.UseDocumentLocation = New System.Windows.Forms.CheckBox()
        Me.SaveLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveIntervalUnits = New System.Windows.Forms.ComboBox()
        Me.SaveInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DocsToSave = New System.Windows.Forms.ComboBox()
        Me.Doc = New System.Windows.Forms.Label()
        Me.EnableAutoSave = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.HowLongAgoToRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberOfVersionsToKeep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SaveInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(206, 351)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(85, 23)
        Me.OK.TabIndex = 26
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(109, 351)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(85, 23)
        Me.Cancel.TabIndex = 25
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'LoadDefaults
        '
        Me.LoadDefaults.Location = New System.Drawing.Point(12, 351)
        Me.LoadDefaults.Name = "LoadDefaults"
        Me.LoadDefaults.Size = New System.Drawing.Size(85, 23)
        Me.LoadDefaults.TabIndex = 24
        Me.LoadDefaults.Text = "Load Defaults"
        Me.LoadDefaults.UseVisualStyleBackColor = True
        '
        'RemoveAfterManualSave
        '
        Me.RemoveAfterManualSave.AutoSize = True
        Me.RemoveAfterManualSave.Location = New System.Drawing.Point(12, 305)
        Me.RemoveAfterManualSave.Name = "RemoveAfterManualSave"
        Me.RemoveAfterManualSave.Size = New System.Drawing.Size(206, 17)
        Me.RemoveAfterManualSave.TabIndex = 23
        Me.RemoveAfterManualSave.Text = "Remove saved files after manual save"
        Me.RemoveAfterManualSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RemovalUnits)
        Me.GroupBox2.Controls.Add(Me.HowLongAgoToRemove)
        Me.GroupBox2.Controls.Add(Me.NumberOfVersionsToKeep)
        Me.GroupBox2.Controls.Add(Me.KeepAllVersions)
        Me.GroupBox2.Controls.Add(Me.RemoveOlder)
        Me.GroupBox2.Controls.Add(Me.VersionsToKeep)
        Me.GroupBox2.Controls.Add(Me.Browse)
        Me.GroupBox2.Controls.Add(Me.UseDocumentLocation)
        Me.GroupBox2.Controls.Add(Me.SaveLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 164)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Save Location"
        '
        'RemovalUnits
        '
        Me.RemovalUnits.FormattingEnabled = True
        Me.RemovalUnits.Items.AddRange(New Object() {"Days", "Weeks", "Months"})
        Me.RemovalUnits.Location = New System.Drawing.Point(195, 110)
        Me.RemovalUnits.Name = "RemovalUnits"
        Me.RemovalUnits.Size = New System.Drawing.Size(79, 21)
        Me.RemovalUnits.TabIndex = 6
        '
        'HowLongAgoToRemove
        '
        Me.HowLongAgoToRemove.Location = New System.Drawing.Point(151, 110)
        Me.HowLongAgoToRemove.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.HowLongAgoToRemove.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HowLongAgoToRemove.Name = "HowLongAgoToRemove"
        Me.HowLongAgoToRemove.Size = New System.Drawing.Size(38, 20)
        Me.HowLongAgoToRemove.TabIndex = 5
        Me.HowLongAgoToRemove.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumberOfVersionsToKeep
        '
        Me.NumberOfVersionsToKeep.Location = New System.Drawing.Point(119, 87)
        Me.NumberOfVersionsToKeep.Name = "NumberOfVersionsToKeep"
        Me.NumberOfVersionsToKeep.Size = New System.Drawing.Size(38, 20)
        Me.NumberOfVersionsToKeep.TabIndex = 4
        '
        'KeepAllVersions
        '
        Me.KeepAllVersions.AutoSize = True
        Me.KeepAllVersions.Location = New System.Drawing.Point(6, 133)
        Me.KeepAllVersions.Name = "KeepAllVersions"
        Me.KeepAllVersions.Size = New System.Drawing.Size(105, 17)
        Me.KeepAllVersions.TabIndex = 3
        Me.KeepAllVersions.TabStop = True
        Me.KeepAllVersions.Text = "Keep all versions"
        Me.KeepAllVersions.UseVisualStyleBackColor = True
        '
        'RemoveOlder
        '
        Me.RemoveOlder.AutoSize = True
        Me.RemoveOlder.Location = New System.Drawing.Point(6, 110)
        Me.RemoveOlder.Name = "RemoveOlder"
        Me.RemoveOlder.Size = New System.Drawing.Size(139, 17)
        Me.RemoveOlder.TabIndex = 3
        Me.RemoveOlder.TabStop = True
        Me.RemoveOlder.Text = "Remove files older than:"
        Me.RemoveOlder.UseVisualStyleBackColor = True
        '
        'VersionsToKeep
        '
        Me.VersionsToKeep.AutoSize = True
        Me.VersionsToKeep.Location = New System.Drawing.Point(6, 87)
        Me.VersionsToKeep.Name = "VersionsToKeep"
        Me.VersionsToKeep.Size = New System.Drawing.Size(107, 17)
        Me.VersionsToKeep.TabIndex = 3
        Me.VersionsToKeep.TabStop = True
        Me.VersionsToKeep.Text = "Versions to keep:"
        Me.VersionsToKeep.UseVisualStyleBackColor = True
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(199, 47)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 2
        Me.Browse.Text = "Browse..."
        Me.Browse.UseVisualStyleBackColor = True
        '
        'UseDocumentLocation
        '
        Me.UseDocumentLocation.AutoSize = True
        Me.UseDocumentLocation.Location = New System.Drawing.Point(6, 47)
        Me.UseDocumentLocation.Name = "UseDocumentLocation"
        Me.UseDocumentLocation.Size = New System.Drawing.Size(135, 17)
        Me.UseDocumentLocation.TabIndex = 1
        Me.UseDocumentLocation.Text = "Use document location"
        Me.UseDocumentLocation.UseVisualStyleBackColor = True
        '
        'SaveLocation
        '
        Me.SaveLocation.Location = New System.Drawing.Point(6, 20)
        Me.SaveLocation.Name = "SaveLocation"
        Me.SaveLocation.Size = New System.Drawing.Size(268, 20)
        Me.SaveLocation.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SaveIntervalUnits)
        Me.GroupBox1.Controls.Add(Me.SaveInterval)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 51)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Save Interval"
        '
        'SaveIntervalUnits
        '
        Me.SaveIntervalUnits.FormattingEnabled = True
        Me.SaveIntervalUnits.Items.AddRange(New Object() {"Seconds", "Minutes", "Hours"})
        Me.SaveIntervalUnits.Location = New System.Drawing.Point(91, 20)
        Me.SaveIntervalUnits.Name = "SaveIntervalUnits"
        Me.SaveIntervalUnits.Size = New System.Drawing.Size(78, 21)
        Me.SaveIntervalUnits.TabIndex = 2
        '
        'SaveInterval
        '
        Me.SaveInterval.Location = New System.Drawing.Point(46, 20)
        Me.SaveInterval.Name = "SaveInterval"
        Me.SaveInterval.Size = New System.Drawing.Size(39, 20)
        Me.SaveInterval.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Every"
        '
        'DocsToSave
        '
        Me.DocsToSave.FormattingEnabled = True
        Me.DocsToSave.Items.AddRange(New Object() {"Current Document", "All Visible Documents", "All Open Documents"})
        Me.DocsToSave.Location = New System.Drawing.Point(120, 33)
        Me.DocsToSave.Name = "DocsToSave"
        Me.DocsToSave.Size = New System.Drawing.Size(172, 21)
        Me.DocsToSave.TabIndex = 20
        '
        'Doc
        '
        Me.Doc.AutoSize = True
        Me.Doc.Location = New System.Drawing.Point(12, 36)
        Me.Doc.Name = "Doc"
        Me.Doc.Size = New System.Drawing.Size(102, 13)
        Me.Doc.TabIndex = 19
        Me.Doc.Text = "Documents to save:"
        '
        'EnableAutoSave
        '
        Me.EnableAutoSave.AutoSize = True
        Me.EnableAutoSave.Location = New System.Drawing.Point(12, 12)
        Me.EnableAutoSave.Name = "EnableAutoSave"
        Me.EnableAutoSave.Size = New System.Drawing.Size(109, 17)
        Me.EnableAutoSave.TabIndex = 18
        Me.EnableAutoSave.Text = "Enable AutoSave"
        Me.EnableAutoSave.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 385)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.LoadDefaults)
        Me.Controls.Add(Me.RemoveAfterManualSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DocsToSave)
        Me.Controls.Add(Me.Doc)
        Me.Controls.Add(Me.EnableAutoSave)
        Me.Name = "Settings"
        Me.Text = "AutoSave Settings"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.HowLongAgoToRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberOfVersionsToKeep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SaveInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OK As Windows.Forms.Button
    Friend WithEvents Cancel As Windows.Forms.Button
    Friend WithEvents LoadDefaults As Windows.Forms.Button
    Friend WithEvents RemoveAfterManualSave As Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents RemovalUnits As Windows.Forms.ComboBox
    Friend WithEvents HowLongAgoToRemove As Windows.Forms.NumericUpDown
    Friend WithEvents NumberOfVersionsToKeep As Windows.Forms.NumericUpDown
    Friend WithEvents KeepAllVersions As Windows.Forms.RadioButton
    Friend WithEvents RemoveOlder As Windows.Forms.RadioButton
    Friend WithEvents VersionsToKeep As Windows.Forms.RadioButton
    Friend WithEvents Browse As Windows.Forms.Button
    Friend WithEvents UseDocumentLocation As Windows.Forms.CheckBox
    Friend WithEvents SaveLocation As Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents SaveIntervalUnits As Windows.Forms.ComboBox
    Friend WithEvents SaveInterval As Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents DocsToSave As Windows.Forms.ComboBox
    Friend WithEvents Doc As Windows.Forms.Label
    Friend WithEvents EnableAutoSave As Windows.Forms.CheckBox
End Class
