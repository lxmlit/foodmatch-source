<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIBS
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
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formIBS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ibsTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.resultsLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.symptomsTab = New System.Windows.Forms.TabPage()
        Me.symptomsTabLabel = New System.Windows.Forms.Label()
        Me.riskFactorsTab = New System.Windows.Forms.TabPage()
        Me.riskFactorsTabLabel = New System.Windows.Forms.Label()
        Me.ibsMatchBtn = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.symptomsTab.SuspendLayout()
        Me.riskFactorsTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food/Beverage/Medication"
        '
        'ibsTextBox
        '
        Me.ibsTextBox.Location = New System.Drawing.Point(181, 72)
        Me.ibsTextBox.Name = "ibsTextBox"
        Me.ibsTextBox.Size = New System.Drawing.Size(154, 20)
        Me.ibsTextBox.TabIndex = 1
        '
        'resultsLabel
        '
        Me.resultsLabel.AutoSize = True
        Me.resultsLabel.Location = New System.Drawing.Point(36, 170)
        Me.resultsLabel.Name = "resultsLabel"
        Me.resultsLabel.Size = New System.Drawing.Size(96, 13)
        Me.resultsLabel.TabIndex = 4
        Me.resultsLabel.Text = "Waiting for input ..."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.symptomsTab)
        Me.TabControl1.Controls.Add(Me.riskFactorsTab)
        Me.TabControl1.Location = New System.Drawing.Point(422, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(355, 356)
        Me.TabControl1.TabIndex = 6
        '
        'symptomsTab
        '
        Me.symptomsTab.Controls.Add(Me.symptomsTabLabel)
        Me.symptomsTab.Location = New System.Drawing.Point(4, 22)
        Me.symptomsTab.Name = "symptomsTab"
        Me.symptomsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.symptomsTab.Size = New System.Drawing.Size(347, 330)
        Me.symptomsTab.TabIndex = 0
        Me.symptomsTab.Text = "Symptoms"
        Me.symptomsTab.UseVisualStyleBackColor = True
        '
        'symptomsTabLabel
        '
        Me.symptomsTabLabel.AutoSize = True
        Me.symptomsTabLabel.Location = New System.Drawing.Point(6, 13)
        Me.symptomsTabLabel.Name = "symptomsTabLabel"
        Me.symptomsTabLabel.Size = New System.Drawing.Size(0, 13)
        Me.symptomsTabLabel.TabIndex = 0
        '
        'riskFactorsTab
        '
        Me.riskFactorsTab.Controls.Add(Me.riskFactorsTabLabel)
        Me.riskFactorsTab.Location = New System.Drawing.Point(4, 22)
        Me.riskFactorsTab.Name = "riskFactorsTab"
        Me.riskFactorsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.riskFactorsTab.Size = New System.Drawing.Size(347, 330)
        Me.riskFactorsTab.TabIndex = 1
        Me.riskFactorsTab.Text = "Risk Factors"
        Me.riskFactorsTab.UseVisualStyleBackColor = True
        '
        'riskFactorsTabLabel
        '
        Me.riskFactorsTabLabel.AutoSize = True
        Me.riskFactorsTabLabel.Location = New System.Drawing.Point(6, 13)
        Me.riskFactorsTabLabel.Name = "riskFactorsTabLabel"
        Me.riskFactorsTabLabel.Size = New System.Drawing.Size(0, 13)
        Me.riskFactorsTabLabel.TabIndex = 0
        '
        'ibsMatchBtn
        '
        Me.ibsMatchBtn.BackColor = System.Drawing.Color.Transparent
        Me.ibsMatchBtn.BackgroundImage = CType(resources.GetObject("ibsMatchBtn.BackgroundImage"), System.Drawing.Image)
        Me.ibsMatchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ibsMatchBtn.FlatAppearance.BorderSize = 0
        Me.ibsMatchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibsMatchBtn.Location = New System.Drawing.Point(341, 66)
        Me.ibsMatchBtn.Name = "ibsMatchBtn"
        Me.ibsMatchBtn.Size = New System.Drawing.Size(35, 31)
        Me.ibsMatchBtn.TabIndex = 9
        Me.ibsMatchBtn.UseVisualStyleBackColor = False
        '
        'formIBS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ibsMatchBtn)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.resultsLabel)
        Me.Controls.Add(Me.ibsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formIBS"
        Me.Text = "Irritable Bowel Syndrome (IBS)"
        Me.TabControl1.ResumeLayout(False)
        Me.symptomsTab.ResumeLayout(False)
        Me.symptomsTab.PerformLayout()
        Me.riskFactorsTab.ResumeLayout(False)
        Me.riskFactorsTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ibsTextBox As MaskedTextBox
    Friend WithEvents resultsLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents riskFactorsTab As TabPage
    Friend WithEvents riskFactorsTabLabel As Label
    Friend WithEvents symptomsTab As TabPage
    Friend WithEvents symptomsTabLabel As Label
    Friend WithEvents ibsMatchBtn As Button
End Class
