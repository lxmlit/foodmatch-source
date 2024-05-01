Imports System.Runtime.InteropServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnCeliac = New System.Windows.Forms.Button()
        Me.btnGERD = New System.Windows.Forms.Button()
        Me.btnCrohn = New System.Windows.Forms.Button()
        Me.btnUC = New System.Windows.Forms.Button()
        Me.btnIBS = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.foodMatchLabel = New System.Windows.Forms.Label()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.bntMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCloseChildForm = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelDesktopPane = New System.Windows.Forms.Panel()
        Me.researchNameLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.membersLbl = New System.Windows.Forms.Label()
        Me.members2Lbl = New System.Windows.Forms.Label()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        Me.panelTitleBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelDesktopPane.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.panelMenu.Controls.Add(Me.btnCeliac)
        Me.panelMenu.Controls.Add(Me.btnGERD)
        Me.panelMenu.Controls.Add(Me.btnCrohn)
        Me.panelMenu.Controls.Add(Me.btnUC)
        Me.panelMenu.Controls.Add(Me.btnIBS)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(2, 2)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 577)
        Me.panelMenu.TabIndex = 0
        '
        'btnCeliac
        '
        Me.btnCeliac.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCeliac.FlatAppearance.BorderSize = 0
        Me.btnCeliac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCeliac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCeliac.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCeliac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCeliac.Location = New System.Drawing.Point(0, 320)
        Me.btnCeliac.Name = "btnCeliac"
        Me.btnCeliac.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnCeliac.Size = New System.Drawing.Size(220, 60)
        Me.btnCeliac.TabIndex = 5
        Me.btnCeliac.Text = "Celiac Disease"
        Me.btnCeliac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCeliac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCeliac.UseVisualStyleBackColor = True
        '
        'btnGERD
        '
        Me.btnGERD.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGERD.FlatAppearance.BorderSize = 0
        Me.btnGERD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGERD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnGERD.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGERD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGERD.Location = New System.Drawing.Point(0, 260)
        Me.btnGERD.Name = "btnGERD"
        Me.btnGERD.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnGERD.Size = New System.Drawing.Size(220, 60)
        Me.btnGERD.TabIndex = 4
        Me.btnGERD.Text = "Gastroesophageal Reflux Disease (GERD)"
        Me.btnGERD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGERD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGERD.UseVisualStyleBackColor = True
        '
        'btnCrohn
        '
        Me.btnCrohn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCrohn.FlatAppearance.BorderSize = 0
        Me.btnCrohn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrohn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCrohn.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCrohn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrohn.Location = New System.Drawing.Point(0, 200)
        Me.btnCrohn.Name = "btnCrohn"
        Me.btnCrohn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnCrohn.Size = New System.Drawing.Size(220, 60)
        Me.btnCrohn.TabIndex = 3
        Me.btnCrohn.Text = "Crohn's Disease"
        Me.btnCrohn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrohn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCrohn.UseVisualStyleBackColor = True
        '
        'btnUC
        '
        Me.btnUC.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUC.FlatAppearance.BorderSize = 0
        Me.btnUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnUC.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUC.Location = New System.Drawing.Point(0, 140)
        Me.btnUC.Name = "btnUC"
        Me.btnUC.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnUC.Size = New System.Drawing.Size(220, 60)
        Me.btnUC.TabIndex = 2
        Me.btnUC.Text = "Ulcerative Colitis"
        Me.btnUC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUC.UseVisualStyleBackColor = True
        '
        'btnIBS
        '
        Me.btnIBS.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIBS.FlatAppearance.BorderSize = 0
        Me.btnIBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIBS.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnIBS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIBS.Location = New System.Drawing.Point(0, 80)
        Me.btnIBS.Name = "btnIBS"
        Me.btnIBS.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnIBS.Size = New System.Drawing.Size(220, 60)
        Me.btnIBS.TabIndex = 3
        Me.btnIBS.Text = "Irritable Bowel Syndrome (IBS)"
        Me.btnIBS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIBS.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panelLogo.Controls.Add(Me.foodMatchLabel)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(220, 80)
        Me.panelLogo.TabIndex = 0
        '
        'foodMatchLabel
        '
        Me.foodMatchLabel.AutoSize = True
        Me.foodMatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.foodMatchLabel.ForeColor = System.Drawing.Color.White
        Me.foodMatchLabel.Location = New System.Drawing.Point(56, 27)
        Me.foodMatchLabel.Name = "foodMatchLabel"
        Me.foodMatchLabel.Size = New System.Drawing.Size(111, 25)
        Me.foodMatchLabel.TabIndex = 0
        Me.foodMatchLabel.Text = "FoodMatch"
        Me.foodMatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.Panel1)
        Me.panelTitleBar.Controls.Add(Me.btnCloseChildForm)
        Me.panelTitleBar.Controls.Add(Me.lblTitle)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(222, 2)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(860, 80)
        Me.panelTitleBar.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.bntMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(716, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 80)
        Me.Panel1.TabIndex = 7
        '
        'btnMaximize
        '
        Me.btnMaximize.BackgroundImage = CType(resources.GetObject("btnMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.Location = New System.Drawing.Point(96, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(28, 16)
        Me.btnMaximize.TabIndex = 5
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'bntMinimize
        '
        Me.bntMinimize.BackgroundImage = CType(resources.GetObject("bntMinimize.BackgroundImage"), System.Drawing.Image)
        Me.bntMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bntMinimize.FlatAppearance.BorderSize = 0
        Me.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntMinimize.Location = New System.Drawing.Point(75, 0)
        Me.bntMinimize.Name = "bntMinimize"
        Me.bntMinimize.Size = New System.Drawing.Size(28, 16)
        Me.bntMinimize.TabIndex = 6
        Me.bntMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(119, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 16)
        Me.btnClose.TabIndex = 4
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCloseChildForm
        '
        Me.btnCloseChildForm.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseChildForm.BackgroundImage = CType(resources.GetObject("btnCloseChildForm.BackgroundImage"), System.Drawing.Image)
        Me.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCloseChildForm.FlatAppearance.BorderSize = 0
        Me.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseChildForm.Location = New System.Drawing.Point(21, 27)
        Me.btnCloseChildForm.Name = "btnCloseChildForm"
        Me.btnCloseChildForm.Size = New System.Drawing.Size(43, 23)
        Me.btnCloseChildForm.TabIndex = 3
        Me.btnCloseChildForm.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(87, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(75, 25)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "HOME"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelDesktopPane
        '
        Me.panelDesktopPane.Controls.Add(Me.members2Lbl)
        Me.panelDesktopPane.Controls.Add(Me.membersLbl)
        Me.panelDesktopPane.Controls.Add(Me.researchNameLbl)
        Me.panelDesktopPane.Controls.Add(Me.PictureBox1)
        Me.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktopPane.Location = New System.Drawing.Point(222, 82)
        Me.panelDesktopPane.Name = "panelDesktopPane"
        Me.panelDesktopPane.Size = New System.Drawing.Size(860, 497)
        Me.panelDesktopPane.TabIndex = 1
        '
        'researchNameLbl
        '
        Me.researchNameLbl.AutoSize = True
        Me.researchNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.researchNameLbl.Location = New System.Drawing.Point(22, 180)
        Me.researchNameLbl.Name = "researchNameLbl"
        Me.researchNameLbl.Size = New System.Drawing.Size(140, 25)
        Me.researchNameLbl.TabIndex = 1
        Me.researchNameLbl.Text = "researchName"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(321, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 175)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'membersLbl
        '
        Me.membersLbl.AutoSize = True
        Me.membersLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.membersLbl.Location = New System.Drawing.Point(196, 251)
        Me.membersLbl.Name = "membersLbl"
        Me.membersLbl.Size = New System.Drawing.Size(114, 20)
        Me.membersLbl.TabIndex = 2
        Me.membersLbl.Text = "membersLabel"
        '
        'members2Lbl
        '
        Me.members2Lbl.AutoSize = True
        Me.members2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.members2Lbl.Location = New System.Drawing.Point(468, 251)
        Me.members2Lbl.Name = "members2Lbl"
        Me.members2Lbl.Size = New System.Drawing.Size(123, 20)
        Me.members2Lbl.TabIndex = 3
        Me.members2Lbl.Text = "members2Label"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 581)
        Me.Controls.Add(Me.panelDesktopPane)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        Me.panelLogo.PerformLayout()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panelDesktopPane.ResumeLayout(False)
        Me.panelDesktopPane.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub




    Private WithEvents panelMenu As Panel
    Friend WithEvents btnIBS As Button
    Private WithEvents panelLogo As Panel
    Friend WithEvents btnCrohn As Button
    Friend WithEvents btnUC As Button
    Friend WithEvents btnCeliac As Button
    Friend WithEvents btnGERD As Button
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelDesktopPane As Panel
    Friend WithEvents foodMatchLabel As Label
    Friend WithEvents btnCloseChildForm As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents bntMinimize As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents researchNameLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents membersLbl As Label
    Friend WithEvents members2Lbl As Label
End Class
