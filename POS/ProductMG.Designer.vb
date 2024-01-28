<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductMG
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPDList = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtLOCA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUOM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGROUP = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPTNM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPTNO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnPDList.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPDList
        '
        Me.btnPDList.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.btnPDList.Controls.Add(Me.TabPage1)
        Me.btnPDList.Controls.Add(Me.TabPage3)
        Me.btnPDList.Controls.Add(Me.TabPage2)
        Me.btnPDList.Controls.Add(Me.TabPage6)
        Me.btnPDList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPDList.ItemSize = New System.Drawing.Size(180, 40)
        Me.btnPDList.Location = New System.Drawing.Point(0, 0)
        Me.btnPDList.Name = "btnPDList"
        Me.btnPDList.SelectedIndex = 0
        Me.btnPDList.Size = New System.Drawing.Size(1371, 831)
        Me.btnPDList.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.btnPDList.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPDList.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnPDList.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.btnPDList.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPDList.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.btnPDList.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnPDList.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnPDList.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btnPDList.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnPDList.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.btnPDList.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnPDList.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnPDList.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.btnPDList.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPDList.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.btnPDList.TabIndex = 4
        Me.btnPDList.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1183, 823)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Guna2Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1183, 823)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1177, 74)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.Guna2Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1183, 823)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Product List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1177, 741)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Red
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "EDIT"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "EDIT"
        Me.Column1.Width = 125
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "DELETE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "DEOETE"
        Me.Column2.Width = 125
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1177, 76)
        Me.Guna2Panel2.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Guna2Button1)
        Me.TabPage6.Controls.Add(Me.btnSubmit)
        Me.TabPage6.Controls.Add(Me.txtLOCA)
        Me.TabPage6.Controls.Add(Me.txtUOM)
        Me.TabPage6.Controls.Add(Me.txtGROUP)
        Me.TabPage6.Controls.Add(Me.txtPTNM)
        Me.TabPage6.Controls.Add(Me.txtPTNO)
        Me.TabPage6.Controls.Add(Me.GunaLabel7)
        Me.TabPage6.Controls.Add(Me.GunaLabel8)
        Me.TabPage6.Controls.Add(Me.GunaLabel9)
        Me.TabPage6.Controls.Add(Me.GunaLabel10)
        Me.TabPage6.Controls.Add(Me.GunaLabel11)
        Me.TabPage6.Controls.Add(Me.Guna2Panel4)
        Me.TabPage6.Location = New System.Drawing.Point(184, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1183, 823)
        Me.TabPage6.TabIndex = 6
        Me.TabPage6.Text = "Product Master"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.IndianRed
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(553, 378)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(113, 45)
        Me.Guna2Button1.TabIndex = 30
        Me.Guna2Button1.Text = "CANCEL"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Animated = True
        Me.btnSubmit.AutoRoundedCorners = True
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderColor = System.Drawing.Color.IndianRed
        Me.btnSubmit.BorderRadius = 21
        Me.btnSubmit.BorderThickness = 2
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.White
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnSubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnSubmit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(434, 378)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(113, 45)
        Me.btnSubmit.TabIndex = 29
        Me.btnSubmit.Text = "SAVE"
        Me.btnSubmit.UseTransparentBackground = True
        '
        'txtLOCA
        '
        Me.txtLOCA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLOCA.DefaultText = ""
        Me.txtLOCA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLOCA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLOCA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLOCA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLOCA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLOCA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLOCA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLOCA.Location = New System.Drawing.Point(315, 327)
        Me.txtLOCA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLOCA.Name = "txtLOCA"
        Me.txtLOCA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLOCA.PlaceholderText = ""
        Me.txtLOCA.SelectedText = ""
        Me.txtLOCA.Size = New System.Drawing.Size(414, 37)
        Me.txtLOCA.TabIndex = 10
        '
        'txtUOM
        '
        Me.txtUOM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUOM.DefaultText = ""
        Me.txtUOM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUOM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUOM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUOM.Location = New System.Drawing.Point(315, 282)
        Me.txtUOM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUOM.PlaceholderText = ""
        Me.txtUOM.SelectedText = ""
        Me.txtUOM.Size = New System.Drawing.Size(414, 37)
        Me.txtUOM.TabIndex = 9
        '
        'txtGROUP
        '
        Me.txtGROUP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGROUP.DefaultText = ""
        Me.txtGROUP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGROUP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGROUP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGROUP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGROUP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGROUP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGROUP.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGROUP.Location = New System.Drawing.Point(315, 237)
        Me.txtGROUP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGROUP.Name = "txtGROUP"
        Me.txtGROUP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGROUP.PlaceholderText = ""
        Me.txtGROUP.SelectedText = ""
        Me.txtGROUP.Size = New System.Drawing.Size(414, 37)
        Me.txtGROUP.TabIndex = 8
        '
        'txtPTNM
        '
        Me.txtPTNM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPTNM.DefaultText = ""
        Me.txtPTNM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPTNM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPTNM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPTNM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPTNM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPTNM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPTNM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPTNM.Location = New System.Drawing.Point(315, 189)
        Me.txtPTNM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPTNM.Name = "txtPTNM"
        Me.txtPTNM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPTNM.PlaceholderText = ""
        Me.txtPTNM.SelectedText = ""
        Me.txtPTNM.Size = New System.Drawing.Size(414, 37)
        Me.txtPTNM.TabIndex = 7
        '
        'txtPTNO
        '
        Me.txtPTNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPTNO.DefaultText = ""
        Me.txtPTNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPTNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPTNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPTNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPTNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPTNO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPTNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPTNO.Location = New System.Drawing.Point(315, 135)
        Me.txtPTNO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPTNO.Name = "txtPTNO"
        Me.txtPTNO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPTNO.PlaceholderText = ""
        Me.txtPTNO.SelectedText = ""
        Me.txtPTNO.Size = New System.Drawing.Size(414, 37)
        Me.txtPTNO.TabIndex = 6
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(127, 345)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(89, 19)
        Me.GunaLabel7.TabIndex = 5
        Me.GunaLabel7.Text = "LOCATION"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(127, 207)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(101, 19)
        Me.GunaLabel8.TabIndex = 4
        Me.GunaLabel8.Text = "PART NAME"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(127, 255)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(66, 19)
        Me.GunaLabel9.TabIndex = 3
        Me.GunaLabel9.Text = "GROUP"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(127, 302)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(145, 19)
        Me.GunaLabel10.TabIndex = 2
        Me.GunaLabel10.Text = "UNIT OF MASURE"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(127, 153)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(83, 19)
        Me.GunaLabel11.TabIndex = 1
        Me.GunaLabel11.Text = "PART NO."
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1177, 76)
        Me.Guna2Panel4.TabIndex = 0
        '
        'ProductMG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 831)
        Me.Controls.Add(Me.btnPDList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductMG"
        Me.Text = "ProductMG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.btnPDList.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPDList As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtLOCA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUOM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGROUP As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPTNM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPTNO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
End Class
