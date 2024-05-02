Imports System.Runtime.InteropServices
Imports System.Xml
Imports Foodmatch.Celiac
Imports Foodmatch.Crohn
Imports Foodmatch.GERD
Imports Foodmatch.IBS
Imports Foodmatch.UC

Public Class MainForm

    'FIELDS'
    Private currentButton As Button
    Private random As Random
    Private tempIndex As Integer
    Private activeForm As Form

    'CONSTRUCTOR'
    Public Sub New()
        InitializeComponent()
        random = New Random()
        currentButton = New Button()
        Me.btnCloseChildForm.Visible = False
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
    End Sub

    'METHODS'
    'Color Selector from ColorTheme.vb'
    Private Function SelectColorTheme() As Color
        Dim index As Integer = random.[Next](ColorTheme.ColorList.Count)
        While tempIndex = index
            index = random.[Next](ColorTheme.ColorList.Count)
        End While
        tempIndex = index
        Dim color As String = ColorTheme.ColorList(index)
        Return ColorTranslator.FromHtml(color)
    End Function

    'Color Changer'
    Private Sub ActivateButton(btnSender As Object)
        If btnSender IsNot Nothing Then
            If currentButton.Name <> CType(btnSender, Button).Name Then
                DisableButton()
                Dim color As Color = SelectColorTheme()
                currentButton = CType(btnSender, Button)
                currentButton.BackColor = color
                currentButton.ForeColor = Color.White
                currentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
                panelTitleBar.BackColor = color
                panelLogo.BackColor = ColorTheme.ChangeColorBrightness(color, -0.3)
                ColorTheme.PrimaryColor = color
                ColorTheme.SecondaryColor = ColorTheme.ChangeColorBrightness(color, -0.3)
                btnCloseChildForm.Visible = True

            End If
        End If
    End Sub

    Private Sub DisableButton()
        For Each previousBtn As Control In panelMenu.Controls

            If previousBtn.[GetType]() = GetType(Button) Then
                previousBtn.BackColor = Color.SeaGreen
                previousBtn.ForeColor = Color.Gainsboro
                previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            End If
        Next
    End Sub

    'Responsible for opening ChildForm'
    'childforms are FormCD, FormCrohn, FormGERD, FormIBS, and FormUC'
    Private Sub OpenChildForm(childForm As Form, btnSender As Object)
        If activeForm IsNot Nothing Then activeForm.Close()
        ActivateButton(btnSender)
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.panelDesktopPane.Controls.Add(childForm)
        Me.panelDesktopPane.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblTitle.Text = childForm.Text
    End Sub

    'event handler for close button beside Home text'
    Private Sub btnCloseChildForm_Click(sender As Object, e As EventArgs) Handles btnCloseChildForm.Click
        If (Not (activeForm) Is Nothing) Then
            activeForm.Close()
        End If
        Reset()
    End Sub

    'resets the state if a childform is closed'
    Private Sub Reset()
        DisableButton()
        lblTitle.Text = "HOME"
        panelTitleBar.BackColor = Color.FromArgb(0, 158, 96)
        panelLogo.BackColor = Color.FromArgb(6, 44, 22)
        currentButton = New Button()
        btnCloseChildForm.Visible = False
    End Sub

    'DRAG FORM'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    'moving window'
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'EVENTS

    'clicking btnIBS will open IBSController childform'
    Private Sub btnIBS_Click(sender As Object, e As EventArgs) Handles btnIBS.Click
        OpenChildForm(New IBSController(), sender)
    End Sub

    'clicking btnUC will open UCController childform'
    Private Sub btnUC_Click(sender As Object, e As EventArgs) Handles btnUC.Click
        OpenChildForm(New UCController(), sender)
    End Sub

    'clicking btnCrohn will open CrohnController childform'
    Private Sub btnCrohn_Click(sender As Object, e As EventArgs) Handles btnCrohn.Click
        OpenChildForm(New CrohnController(), sender)
    End Sub

    'clicking btnGERD will open GERDController childform'
    Private Sub btnGERD_Click(sender As Object, e As EventArgs) Handles btnGERD.Click
        OpenChildForm(New GERDController(), sender)
    End Sub

    'clicking btnCeliac will open CeliacController childform'
    Private Sub btnCeliac_Click(sender As Object, e As EventArgs) Handles btnCeliac.Click
        OpenChildForm(New CeliacController(), sender)
    End Sub

    'close, maximize, minimize form main'
    Private Sub bntminimize_click(sender As Object, e As EventArgs) Handles bntMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnmaximize_click(sender As Object, e As EventArgs) Handles btnMaximize.Click

        If (WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    'loading texts for Home'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        researchNameLbl.Text = "                      Prevention of Gastrointestinal Diseases through Preliminary Creation
                                                      of Foodmatch Software Application"

        membersLbl.Text = "Rafaela Grace S. Mayate

Jewel S. Rivera                   

Fhercival Louie Mental

Alejandro II V. Tantamco

Roger Jr. A. David

Mary Joy S. Lacson
"

        members2Lbl.Text = "Lance Joshua L. Arcellana

Earl Elexi S. Manalo

Khirro M. Sarmiento

Henlin M. Ocampo

Rein Gerald R. Malit
"
    End Sub

End Class