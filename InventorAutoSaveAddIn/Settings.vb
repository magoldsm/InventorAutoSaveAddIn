Imports Microsoft.Win32
Imports System.Windows.Forms

Public Class Settings

    Private inventorBaseKeyName As String = "Software\\Autodesk\\Inventor"
    Private autoSaveKeyname As String = "AutoSave"

    Private inventorBasekey As RegistryKey
    Private autoSaveKey As RegistryKey

    Public enableAutoSaveSetting As Boolean
    Public docsToSaveSetting As String
    Public saveIntervalSetting As Integer
    Public saveIntervalUnitsSetting As String
    Public saveLocationSetting As String
    Public useDocumentLocationSetting As Boolean
    Public versionsToKeepSetting As Boolean
    Public numberOfVersionsToKeepSetting As Integer
    Public removeOlderSettings As Boolean
    Public howLongAgoToRemoveSettings As Integer
    Public removalUnitsSettings As String
    Public keepAllVersionsSettings As Boolean
    Public removeAfterManualSaveSettings As Boolean

    ' Private settings As Inventor.NameValueMap

    Sub New()
        ' This call is required by the designer.
        'settings = Context
        InitializeComponent()

        inventorBasekey = Registry.CurrentUser.CreateSubKey(inventorBaseKeyName)
        autoSaveKey = inventorBasekey.CreateSubKey(autoSaveKeyname)

        LoadDefaultSettings()
        Serialize(False)
        UpdateUI()

    End Sub

    Protected Overrides Sub Finalize()
        autoSaveKey.Close()
        inventorBasekey.Close()
    End Sub


    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        enableAutoSaveSetting = EnableAutoSave.Checked
        docsToSaveSetting = DocsToSave.Text
        saveIntervalSetting = SaveInterval.Value
        saveIntervalUnitsSetting = SaveIntervalUnits.Text
        saveLocationSetting = SaveLocation.Text
        useDocumentLocationSetting = UseDocumentLocation.Checked
        versionsToKeepSetting = VersionsToKeep.Checked
        numberOfVersionsToKeepSetting = NumberOfVersionsToKeep.Value
        removeOlderSettings = RemoveOlder.Checked
        howLongAgoToRemoveSettings = HowLongAgoToRemove.Value
        removalUnitsSettings = RemovalUnits.Text
        keepAllVersionsSettings = KeepAllVersions.Checked
        removeAfterManualSaveSettings = RemoveAfterManualSave.Checked

        Serialize(True)

        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoadDefaultSettings()
        EnableAutoSave.Checked = True
        DocsToSave.Text = "All Open Documents"
        SaveInterval.Value = 10
        SaveIntervalUnits.Text = "Minutes"
        SaveLocation.Text = ""
        UseDocumentLocation.Checked = True
        SaveLocation.Enabled = False
        VersionsToKeep.Checked = True
        NumberOfVersionsToKeep.Value = 10
        RemoveOlder.Checked = False
        HowLongAgoToRemove.Value = 365
        RemovalUnits.Text = "Days"
        HowLongAgoToRemove.Enabled = False
        RemovalUnits.Enabled = False
        KeepAllVersions.Checked = False
        RemoveAfterManualSave.Checked = True
        Browse.Enabled = False

    End Sub

    Private Sub UpdateUI()
        If UseDocumentLocation.Checked Then
            SaveLocation.Enabled = False
            Browse.Enabled = False
        Else
            SaveLocation.Enabled = True
            Browse.Enabled = True
        End If

        NumberOfVersionsToKeep.Enabled = VersionsToKeep.Checked

        HowLongAgoToRemove.Enabled = RemoveOlder.Checked
        RemovalUnits.Enabled = RemoveOlder.Checked

    End Sub


    Function ItemExists(name As String) As Boolean
        'Function ItemExists(ByRef settings As Inventor.NameValueMap, name As String) As Boolean
        '    For I As Integer = 0 To settings.Count - 1
        '        If name = settings.Name(I) Then
        '            Return True
        '        End If
        '    Next
        '    Return False
        Return autoSaveKey.GetValue(name, Nothing) <> Nothing
    End Function

    Private Sub Serialize(save As Boolean)

        If save Then
            autoSaveKey.SetValue("EnableAutoSave", EnableAutoSave.Checked, RegistryValueKind.DWord)
            autoSaveKey.SetValue("DocsToSave", DocsToSave.Text)
            autoSaveKey.SetValue("SaveInterval", SaveInterval.Value, RegistryValueKind.DWord)
            autoSaveKey.SetValue("SaveIntervalUnits", SaveIntervalUnits.Text)
            autoSaveKey.SetValue("SaveLocation", SaveLocation.Text)
            autoSaveKey.SetValue("UseDocumentLocation", UseDocumentLocation.Checked, RegistryValueKind.DWord)
            autoSaveKey.SetValue("VersionsToKeep", VersionsToKeep.Checked, RegistryValueKind.DWord)
            autoSaveKey.SetValue("NumberOfVersionsToKeep", NumberOfVersionsToKeep.Value, RegistryValueKind.DWord)
            autoSaveKey.SetValue("RemoveOlder", RemoveOlder.Checked, RegistryValueKind.DWord)
            autoSaveKey.SetValue("HowLongAgoToRemove", HowLongAgoToRemove.Value, RegistryValueKind.DWord)
            autoSaveKey.SetValue("RemovalUnits", RemovalUnits.Text)
            autoSaveKey.SetValue("KeepAllVersions", KeepAllVersions.Checked, RegistryValueKind.DWord)
            autoSaveKey.SetValue("RemoveAfterManualSave", RemoveAfterManualSave.Checked, RegistryValueKind.DWord)

            '    Settings.Value("EnableAutoSave") = EnableAutoSave.Checked
            '    Settings.Value("DocsToSave") = DocsToSave.Text
            '    Settings.Value("SaveInterval") = SaveInterval.Value
            '    Settings.Value("SaveIntervalUnits") = SaveIntervalUnits.Text
            '    Settings.Value("SaveLocation") = SaveLocation.Text
            '    Settings.Value("UseDocumentLocation") = UseDocumentLocation.Checked
            '    Settings.Value("VersionsToKeep") = VersionsToKeep.Checked
            '    Settings.Value("NumberOfVersionsToKeep") = NumberOfVersionsToKeep.Value
            '    Settings.Value("RemoveOlder") = RemoveOlder.Checked
            '    Settings.Value("HowLongAgoToRemove") = HowLongAgoToRemove.Value
            '    Settings.Value("RemovalUnits") = RemovalUnits.Text
            '    Settings.Value("KeepAllVersions") = KeepAllVersions.Checked
            '    Settings.Value("RemoveAfterManualSave") = RemoveAfterManualSave.Checked
        Else
            If autoSaveKey.GetValue("EnableAutoSave", Nothing) IsNot Nothing Then EnableAutoSave.Checked = autoSaveKey.GetValue("EnableAutoSave")
            If autoSaveKey.GetValue("DocsToSave", Nothing) IsNot Nothing Then DocsToSave.Text = autoSaveKey.GetValue("DocsToSave")
            If autoSaveKey.GetValue("SaveInterval", Nothing) IsNot Nothing Then SaveInterval.Value = autoSaveKey.GetValue("SaveInterval")
            If autoSaveKey.GetValue("SaveIntervalUnits", Nothing) IsNot Nothing Then SaveIntervalUnits.Text = autoSaveKey.GetValue("SaveIntervalUnits")
            If autoSaveKey.GetValue("SaveLocation", Nothing) IsNot Nothing Then SaveLocation.Text = autoSaveKey.GetValue("SaveLocation")
            If autoSaveKey.GetValue("UseDocumentLocation", Nothing) IsNot Nothing Then UseDocumentLocation.Checked = autoSaveKey.GetValue("UseDocumentLocation")
            If autoSaveKey.GetValue("VersionsToKeep", Nothing) IsNot Nothing Then VersionsToKeep.Checked = autoSaveKey.GetValue("VersionsToKeep")
            If autoSaveKey.GetValue("NumberOfVersionsToKeep", Nothing) IsNot Nothing Then NumberOfVersionsToKeep.Value = autoSaveKey.GetValue("NumberOfVersionsToKeep")
            If autoSaveKey.GetValue("RemoveOlder", Nothing) IsNot Nothing Then RemoveOlder.Checked = autoSaveKey.GetValue("RemoveOlder")
            If autoSaveKey.GetValue("HowLongAgoToRemove", Nothing) IsNot Nothing Then HowLongAgoToRemove.Value = autoSaveKey.GetValue("HowLongAgoToRemove")
            If autoSaveKey.GetValue("RemovalUnits", Nothing) IsNot Nothing Then RemovalUnits.Text = autoSaveKey.GetValue("RemovalUnits")
            If autoSaveKey.GetValue("KeepAllVersions", Nothing) IsNot Nothing Then KeepAllVersions.Checked = autoSaveKey.GetValue("KeepAllVersions")
            If autoSaveKey.GetValue("RemoveAfterManualSave", Nothing) IsNot Nothing Then RemoveAfterManualSave.Checked = autoSaveKey.GetValue("RemoveAfterManualSave")

            '    If ItemExists(Settings, "EnableAutoSave") Then EnableAutoSave.Checked = Settings.Value("EnableAutoSave")
            '    If ItemExists(Settings, "DocsToSave") Then DocsToSave.Text = Settings.Value("DocsToSave")
            '    If ItemExists(Settings, "SaveInterval") Then SaveInterval.Value = Settings.Value("SaveInterval")
            '    If ItemExists(Settings, "SaveIntervalUnits") Then SaveIntervalUnits.Text = Settings.Value("SaveIntervalUnits")
            '    If ItemExists(Settings, "SaveLocation") Then SaveLocation.Text = Settings.Value("SaveLocation")
            '    If ItemExists(Settings, "UseDocumentLocation") Then UseDocumentLocation.Checked = Settings.Value("UseDocumentLocation")
            '    If ItemExists(Settings, "VersionsToKeep") Then VersionsToKeep.Checked = Settings.Value("VersionsToKeep")
            '    If ItemExists(Settings, "NumberOfVersionsToKeep") Then NumberOfVersionsToKeep.Value = Settings.Value("NumberOfVersionsToKeep")
            '    If ItemExists(Settings, "RemoveOlder") Then RemoveOlder.Checked = Settings.Value("RemoveOlder")
            '    If ItemExists(Settings, "HowLongAgoToRemove") Then HowLongAgoToRemove.Value = Settings.Value("HowLongAgoToRemove")
            '    If ItemExists(Settings, "RemovalUnits") Then RemovalUnits.Text = Settings.Value("RemovalUnits")
            '    If ItemExists(Settings, "KeepAllVersions") Then KeepAllVersions.Checked = Settings.Value("KeepAllVersions")
            '    If ItemExists(Settings, "RemoveAfterManualSave") Then RemoveAfterManualSave.Checked = Settings.Value("RemoveAfterManualSave")
        End If

    End Sub

    Private Sub LoadDefaults_Click(sender As Object, e As EventArgs) Handles LoadDefaults.Click
        LoadDefaultSettings()
    End Sub

    Private Sub UseDocumentLocation_CheckedChanged(sender As Object, e As EventArgs) Handles UseDocumentLocation.CheckedChanged
        UpdateUI()
    End Sub

    Private Sub VersionsToKeep_CheckedChanged(sender As Object, e As EventArgs) Handles VersionsToKeep.CheckedChanged
        UpdateUI()
    End Sub

    Private Sub RemoveOlder_CheckedChanged(sender As Object, e As EventArgs) Handles RemoveOlder.CheckedChanged
        UpdateUI()
    End Sub

    Private Sub KeepAllVersions_CheckedChanged(sender As Object, e As EventArgs) Handles KeepAllVersions.CheckedChanged
        UpdateUI()
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        ' Create a new instance of FolderBrowserDialog
        Dim folderBrowserDialog1 As New FolderBrowserDialog()

        ' Show the dialog and get result
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            SaveLocation.Text = folderBrowserDialog1.SelectedPath
            UpdateUI()
        End If

    End Sub
End Class