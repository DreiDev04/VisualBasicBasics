<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arnoms_Forms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Arnoms_Forms))
        Lbl_ArnomsMain = New Label()
        Tlp_Arnoms = New TableLayoutPanel()
        TplPnl_1 = New Panel()
        Panel1 = New Panel()
        Btn_ChickenDecrement = New Button()
        Btn_ChickenIncrement = New Button()
        Txtb_Chicken = New TextBox()
        PictureBox1 = New PictureBox()
        Lbl_Chicken = New Label()
        TplPnl_2 = New Panel()
        Panel2 = New Panel()
        Btn_DuckDecrement = New Button()
        TxtB_Duck = New TextBox()
        Btn_DuckIncrement = New Button()
        PictureBox2 = New PictureBox()
        Lbl_Duck = New Label()
        TplPnl_3 = New Panel()
        PictureBox3 = New PictureBox()
        Lbl_Turkey = New Label()
        Panel3 = New Panel()
        Btn_TurkeyDecrement = New Button()
        TxtB_Turkey = New TextBox()
        Btn_TurkeyIncrement = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TxtB_Total = New TextBox()
        Btn_Calculate = New Button()
        Btn_Clear = New Button()
        Tlp_Arnoms.SuspendLayout()
        TplPnl_1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TplPnl_2.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TplPnl_3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_ArnomsMain
        ' 
        Lbl_ArnomsMain.Dock = DockStyle.Top
        Lbl_ArnomsMain.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_ArnomsMain.Location = New Point(0, 0)
        Lbl_ArnomsMain.Name = "Lbl_ArnomsMain"
        Lbl_ArnomsMain.Size = New Size(704, 80)
        Lbl_ArnomsMain.TabIndex = 0
        Lbl_ArnomsMain.Text = "Arnom's Fried Chicken"
        Lbl_ArnomsMain.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Tlp_Arnoms
        ' 
        Tlp_Arnoms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Tlp_Arnoms.BackColor = Color.Transparent
        Tlp_Arnoms.ColumnCount = 3
        Tlp_Arnoms.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        Tlp_Arnoms.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        Tlp_Arnoms.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        Tlp_Arnoms.Controls.Add(TplPnl_1, 0, 0)
        Tlp_Arnoms.Controls.Add(TplPnl_2, 1, 0)
        Tlp_Arnoms.Controls.Add(TplPnl_3, 2, 0)
        Tlp_Arnoms.Location = New Point(68, 72)
        Tlp_Arnoms.Name = "Tlp_Arnoms"
        Tlp_Arnoms.RowCount = 1
        Tlp_Arnoms.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        Tlp_Arnoms.Size = New Size(557, 256)
        Tlp_Arnoms.TabIndex = 1
        ' 
        ' TplPnl_1
        ' 
        TplPnl_1.BackColor = Color.Transparent
        TplPnl_1.Controls.Add(Panel1)
        TplPnl_1.Controls.Add(PictureBox1)
        TplPnl_1.Controls.Add(Lbl_Chicken)
        TplPnl_1.Dock = DockStyle.Fill
        TplPnl_1.Location = New Point(3, 3)
        TplPnl_1.Name = "TplPnl_1"
        TplPnl_1.Size = New Size(179, 250)
        TplPnl_1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Btn_ChickenDecrement)
        Panel1.Controls.Add(Btn_ChickenIncrement)
        Panel1.Controls.Add(Txtb_Chicken)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 206)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(179, 44)
        Panel1.TabIndex = 2
        ' 
        ' Btn_ChickenDecrement
        ' 
        Btn_ChickenDecrement.Anchor = AnchorStyles.Right
        Btn_ChickenDecrement.BackColor = Color.LightSkyBlue
        Btn_ChickenDecrement.FlatStyle = FlatStyle.Popup
        Btn_ChickenDecrement.Font = New Font("Arial", 11.25F)
        Btn_ChickenDecrement.Location = New Point(151, 11)
        Btn_ChickenDecrement.Name = "Btn_ChickenDecrement"
        Btn_ChickenDecrement.Size = New Size(25, 23)
        Btn_ChickenDecrement.TabIndex = 2
        Btn_ChickenDecrement.Text = "-"
        Btn_ChickenDecrement.UseVisualStyleBackColor = False
        ' 
        ' Btn_ChickenIncrement
        ' 
        Btn_ChickenIncrement.Anchor = AnchorStyles.Right
        Btn_ChickenIncrement.BackColor = Color.LightSkyBlue
        Btn_ChickenIncrement.FlatStyle = FlatStyle.Popup
        Btn_ChickenIncrement.Font = New Font("Arial", 11.25F)
        Btn_ChickenIncrement.Location = New Point(120, 11)
        Btn_ChickenIncrement.Name = "Btn_ChickenIncrement"
        Btn_ChickenIncrement.Size = New Size(25, 23)
        Btn_ChickenIncrement.TabIndex = 1
        Btn_ChickenIncrement.Text = "+"
        Btn_ChickenIncrement.UseVisualStyleBackColor = False
        ' 
        ' Txtb_Chicken
        ' 
        Txtb_Chicken.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Txtb_Chicken.Location = New Point(3, 11)
        Txtb_Chicken.Name = "Txtb_Chicken"
        Txtb_Chicken.PlaceholderText = "0"
        Txtb_Chicken.Size = New Size(111, 23)
        Txtb_Chicken.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        PictureBox1.BackgroundImage = My.Resources.Resources.FriedChicken
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(0, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(179, 168)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Lbl_Chicken
        ' 
        Lbl_Chicken.BackColor = Color.Transparent
        Lbl_Chicken.Dock = DockStyle.Top
        Lbl_Chicken.FlatStyle = FlatStyle.Popup
        Lbl_Chicken.Font = New Font("Maiandra GD", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_Chicken.Location = New Point(0, 0)
        Lbl_Chicken.Name = "Lbl_Chicken"
        Lbl_Chicken.Size = New Size(179, 32)
        Lbl_Chicken.TabIndex = 0
        Lbl_Chicken.Text = "Chicken"
        Lbl_Chicken.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TplPnl_2
        ' 
        TplPnl_2.BackColor = Color.Transparent
        TplPnl_2.Controls.Add(Panel2)
        TplPnl_2.Controls.Add(PictureBox2)
        TplPnl_2.Controls.Add(Lbl_Duck)
        TplPnl_2.Dock = DockStyle.Fill
        TplPnl_2.Location = New Point(188, 3)
        TplPnl_2.Name = "TplPnl_2"
        TplPnl_2.Size = New Size(179, 250)
        TplPnl_2.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Btn_DuckDecrement)
        Panel2.Controls.Add(TxtB_Duck)
        Panel2.Controls.Add(Btn_DuckIncrement)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 206)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(179, 44)
        Panel2.TabIndex = 2
        ' 
        ' Btn_DuckDecrement
        ' 
        Btn_DuckDecrement.Anchor = AnchorStyles.Right
        Btn_DuckDecrement.BackColor = Color.LightSkyBlue
        Btn_DuckDecrement.FlatStyle = FlatStyle.Popup
        Btn_DuckDecrement.Font = New Font("Arial", 11.25F)
        Btn_DuckDecrement.Location = New Point(151, 11)
        Btn_DuckDecrement.Name = "Btn_DuckDecrement"
        Btn_DuckDecrement.Size = New Size(25, 23)
        Btn_DuckDecrement.TabIndex = 5
        Btn_DuckDecrement.Text = "-"
        Btn_DuckDecrement.UseVisualStyleBackColor = False
        ' 
        ' TxtB_Duck
        ' 
        TxtB_Duck.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TxtB_Duck.Location = New Point(3, 11)
        TxtB_Duck.Name = "TxtB_Duck"
        TxtB_Duck.PlaceholderText = "0"
        TxtB_Duck.Size = New Size(111, 23)
        TxtB_Duck.TabIndex = 3
        ' 
        ' Btn_DuckIncrement
        ' 
        Btn_DuckIncrement.Anchor = AnchorStyles.Right
        Btn_DuckIncrement.BackColor = Color.LightSkyBlue
        Btn_DuckIncrement.FlatStyle = FlatStyle.Popup
        Btn_DuckIncrement.Font = New Font("Arial", 11.25F)
        Btn_DuckIncrement.Location = New Point(120, 11)
        Btn_DuckIncrement.Name = "Btn_DuckIncrement"
        Btn_DuckIncrement.Size = New Size(25, 23)
        Btn_DuckIncrement.TabIndex = 4
        Btn_DuckIncrement.Text = "+"
        Btn_DuckIncrement.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Location = New Point(0, 32)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(179, 168)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Lbl_Duck
        ' 
        Lbl_Duck.Dock = DockStyle.Top
        Lbl_Duck.FlatStyle = FlatStyle.Popup
        Lbl_Duck.Font = New Font("Maiandra GD", 14.25F)
        Lbl_Duck.Location = New Point(0, 0)
        Lbl_Duck.Name = "Lbl_Duck"
        Lbl_Duck.Size = New Size(179, 32)
        Lbl_Duck.TabIndex = 0
        Lbl_Duck.Text = "Duck"
        Lbl_Duck.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TplPnl_3
        ' 
        TplPnl_3.BackColor = Color.Transparent
        TplPnl_3.Controls.Add(PictureBox3)
        TplPnl_3.Controls.Add(Lbl_Turkey)
        TplPnl_3.Controls.Add(Panel3)
        TplPnl_3.Dock = DockStyle.Fill
        TplPnl_3.Location = New Point(373, 3)
        TplPnl_3.Name = "TplPnl_3"
        TplPnl_3.Size = New Size(181, 250)
        TplPnl_3.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox3.BackColor = Color.LightSeaGreen
        PictureBox3.BackgroundImage = My.Resources.Resources.FriedTurkey
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
        PictureBox3.Location = New Point(0, 32)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(181, 168)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Lbl_Turkey
        ' 
        Lbl_Turkey.Dock = DockStyle.Top
        Lbl_Turkey.FlatStyle = FlatStyle.Popup
        Lbl_Turkey.Font = New Font("Maiandra GD", 14.25F)
        Lbl_Turkey.Location = New Point(0, 0)
        Lbl_Turkey.Name = "Lbl_Turkey"
        Lbl_Turkey.Size = New Size(181, 32)
        Lbl_Turkey.TabIndex = 1
        Lbl_Turkey.Text = "Turkey"
        Lbl_Turkey.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Controls.Add(Btn_TurkeyDecrement)
        Panel3.Controls.Add(TxtB_Turkey)
        Panel3.Controls.Add(Btn_TurkeyIncrement)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 206)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(181, 44)
        Panel3.TabIndex = 0
        ' 
        ' Btn_TurkeyDecrement
        ' 
        Btn_TurkeyDecrement.Anchor = AnchorStyles.Right
        Btn_TurkeyDecrement.BackColor = Color.LightSkyBlue
        Btn_TurkeyDecrement.FlatStyle = FlatStyle.Popup
        Btn_TurkeyDecrement.Font = New Font("Arial", 11.25F)
        Btn_TurkeyDecrement.Location = New Point(151, 11)
        Btn_TurkeyDecrement.Name = "Btn_TurkeyDecrement"
        Btn_TurkeyDecrement.Size = New Size(25, 23)
        Btn_TurkeyDecrement.TabIndex = 8
        Btn_TurkeyDecrement.Text = "-"
        Btn_TurkeyDecrement.UseVisualStyleBackColor = False
        ' 
        ' TxtB_Turkey
        ' 
        TxtB_Turkey.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TxtB_Turkey.Location = New Point(3, 11)
        TxtB_Turkey.Name = "TxtB_Turkey"
        TxtB_Turkey.PlaceholderText = "0"
        TxtB_Turkey.Size = New Size(111, 23)
        TxtB_Turkey.TabIndex = 6
        ' 
        ' Btn_TurkeyIncrement
        ' 
        Btn_TurkeyIncrement.Anchor = AnchorStyles.Right
        Btn_TurkeyIncrement.BackColor = Color.LightSkyBlue
        Btn_TurkeyIncrement.FlatStyle = FlatStyle.Popup
        Btn_TurkeyIncrement.Font = New Font("Arial", 11.25F)
        Btn_TurkeyIncrement.Location = New Point(120, 11)
        Btn_TurkeyIncrement.Name = "Btn_TurkeyIncrement"
        Btn_TurkeyIncrement.Size = New Size(25, 23)
        Btn_TurkeyIncrement.TabIndex = 7
        Btn_TurkeyIncrement.Text = "+"
        Btn_TurkeyIncrement.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(TxtB_Total)
        FlowLayoutPanel1.Controls.Add(Btn_Calculate)
        FlowLayoutPanel1.Controls.Add(Btn_Clear)
        FlowLayoutPanel1.Location = New Point(70, 347)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(555, 46)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' TxtB_Total
        ' 
        TxtB_Total.Dock = DockStyle.Right
        TxtB_Total.Font = New Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtB_Total.Location = New Point(3, 3)
        TxtB_Total.Multiline = True
        TxtB_Total.Name = "TxtB_Total"
        TxtB_Total.RightToLeft = RightToLeft.Yes
        TxtB_Total.Size = New Size(188, 36)
        TxtB_Total.TabIndex = 0
        ' 
        ' Btn_Calculate
        ' 
        Btn_Calculate.BackColor = Color.LightSkyBlue
        Btn_Calculate.FlatStyle = FlatStyle.Popup
        Btn_Calculate.Font = New Font("Lucida Fax", 9.75F)
        Btn_Calculate.Location = New Point(197, 3)
        Btn_Calculate.Name = "Btn_Calculate"
        Btn_Calculate.Size = New Size(75, 36)
        Btn_Calculate.TabIndex = 0
        Btn_Calculate.Text = "Calculate"
        Btn_Calculate.UseVisualStyleBackColor = False
        ' 
        ' Btn_Clear
        ' 
        Btn_Clear.BackColor = Color.LightSkyBlue
        Btn_Clear.FlatStyle = FlatStyle.Popup
        Btn_Clear.Font = New Font("Lucida Fax", 9.75F)
        Btn_Clear.Location = New Point(278, 3)
        Btn_Clear.Name = "Btn_Clear"
        Btn_Clear.Size = New Size(75, 36)
        Btn_Clear.TabIndex = 1
        Btn_Clear.Text = "Clear"
        Btn_Clear.UseVisualStyleBackColor = False
        ' 
        ' Arnoms_Forms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(704, 441)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Tlp_Arnoms)
        Controls.Add(Lbl_ArnomsMain)
        Name = "Arnoms_Forms"
        Text = "Arnom's Fried Food"
        Tlp_Arnoms.ResumeLayout(False)
        TplPnl_1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TplPnl_2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TplPnl_3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lbl_ArnomsMain As Label
    Friend WithEvents Tlp_Arnoms As TableLayoutPanel
    Friend WithEvents TplPnl_2 As Panel
    Friend WithEvents TplPnl_3 As Panel
    Friend WithEvents TplPnl_1 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_Chicken As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Lbl_Duck As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Lbl_Turkey As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txtb_Chicken As TextBox
    Friend WithEvents Btn_ChickenDecrement As Button
    Friend WithEvents Btn_ChickenIncrement As Button
    Friend WithEvents Btn_DuckDecrement As Button
    Friend WithEvents TxtB_Duck As TextBox
    Friend WithEvents Btn_DuckIncrement As Button
    Friend WithEvents Btn_TurkeyDecrement As Button
    Friend WithEvents TxtB_Turkey As TextBox
    Friend WithEvents Btn_TurkeyIncrement As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Btn_Calculate As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents TxtB_Total As TextBox

End Class
