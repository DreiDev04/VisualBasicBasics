<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Forms
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
        components = New ComponentModel.Container()
        pb_mainBG = New PictureBox()
        ColoredBard1 = New ColoredBard()
        tmr_Main = New Timer(components)
        lbl_Progress = New Label()
        CType(pb_mainBG, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pb_mainBG
        ' 
        pb_mainBG.Dock = DockStyle.Fill
        pb_mainBG.Image = My.Resources.Resources.BG_main
        pb_mainBG.Location = New Point(0, 0)
        pb_mainBG.Name = "pb_mainBG"
        pb_mainBG.Size = New Size(704, 441)
        pb_mainBG.SizeMode = PictureBoxSizeMode.StretchImage
        pb_mainBG.TabIndex = 0
        pb_mainBG.TabStop = False
        ' 
        ' ColoredBard1
        ' 
        ColoredBard1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ColoredBard1.Location = New Point(126, 354)
        ColoredBard1.Name = "ColoredBard1"
        ColoredBard1.ProgressColor = Color.FromArgb(CByte(238), CByte(62), CByte(201))
        ColoredBard1.Size = New Size(445, 23)
        ColoredBard1.TabIndex = 2
        ' 
        ' tmr_Main
        ' 
        ' 
        ' lbl_Progress
        ' 
        lbl_Progress.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_Progress.AutoSize = True
        lbl_Progress.BackColor = Color.Transparent
        lbl_Progress.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Progress.ForeColor = Color.Black
        lbl_Progress.ImageAlign = ContentAlignment.MiddleRight
        lbl_Progress.Location = New Point(126, 333)
        lbl_Progress.Name = "lbl_Progress"
        lbl_Progress.RightToLeft = RightToLeft.No
        lbl_Progress.Size = New Size(49, 18)
        lbl_Progress.TabIndex = 3
        lbl_Progress.Text = "000 %"
        lbl_Progress.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Main_Forms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.BG_main
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(704, 441)
        Controls.Add(lbl_Progress)
        Controls.Add(ColoredBard1)
        Controls.Add(pb_mainBG)
        DoubleBuffered = True
        Name = "Main_Forms"
        Text = "Splash Screen"
        CType(pb_mainBG, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pb_mainBG As PictureBox
    Friend WithEvents ColoredBard1 As ColoredBard
    Friend WithEvents tmr_Main As Timer
    Friend WithEvents lbl_Progress As Label

End Class
