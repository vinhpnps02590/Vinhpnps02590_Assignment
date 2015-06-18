<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlythanhvien
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btntim = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.txtsodt = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvkhachhang = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vinhpnps02590_Assignment.My.Resources.Resources.bboy_thesis_fan_art_lil_green_man_designs_by_swapnilextkumar_d5qq54j
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 390)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btntim)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.txtsodt)
        Me.GroupBox1.Controls.Add(Me.txttenkh)
        Me.GroupBox1.Controls.Add(Me.txtmakh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 344)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhâp thông tin Khách Hàng"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(117, 150)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(127, 21)
        Me.txtdiachi.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "DiaChi :"
        '
        'btntim
        '
        Me.btntim.Image = Global.Vinhpnps02590_Assignment.My.Resources.Resources.tải_xuống2
        Me.btntim.Location = New System.Drawing.Point(160, 273)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(84, 52)
        Me.btntim.TabIndex = 12
        Me.btntim.Text = " Tìm"
        Me.btntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Image = Global.Vinhpnps02590_Assignment.My.Resources.Resources.document_delete
        Me.btnxoa.Location = New System.Drawing.Point(160, 202)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(84, 52)
        Me.btnxoa.TabIndex = 11
        Me.btnxoa.Text = "  Xoá"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Image = Global.Vinhpnps02590_Assignment.My.Resources.Resources.edit_document_actions_notes_add_cabinet_delete_musician
        Me.btnsua.Location = New System.Drawing.Point(37, 273)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(84, 52)
        Me.btnsua.TabIndex = 10
        Me.btnsua.Text = "  Sữa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Image = Global.Vinhpnps02590_Assignment.My.Resources.Resources._222
        Me.btnthem.Location = New System.Drawing.Point(37, 202)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(84, 52)
        Me.btnthem.TabIndex = 6
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'txtsodt
        '
        Me.txtsodt.Location = New System.Drawing.Point(117, 111)
        Me.txtsodt.Name = "txtsodt"
        Me.txtsodt.Size = New System.Drawing.Size(127, 21)
        Me.txtsodt.TabIndex = 5
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(117, 74)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(127, 21)
        Me.txttenkh.TabIndex = 4
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(117, 37)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(127, 21)
        Me.txtmakh.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SoDT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TenKH :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MaKH :"
        '
        'dgvkhachhang
        '
        Me.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhachhang.Location = New System.Drawing.Point(299, 22)
        Me.dgvkhachhang.Name = "dgvkhachhang"
        Me.dgvkhachhang.Size = New System.Drawing.Size(425, 344)
        Me.dgvkhachhang.TabIndex = 4
        '
        'frmquanlythanhvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 389)
        Me.Controls.Add(Me.dgvkhachhang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmquanlythanhvien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Khách Hàng"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents txtsodt As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvkhachhang As System.Windows.Forms.DataGridView
End Class
