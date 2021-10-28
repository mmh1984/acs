<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbookingdetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbookingdetails))
        Me.ServicePanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbACDetails = New System.Windows.Forms.GroupBox()
        Me.btncanceladd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxactype = New System.Windows.Forms.ComboBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbrandmodel = New System.Windows.Forms.TextBox()
        Me.rbinverter = New System.Windows.Forms.RadioButton()
        Me.txtremarks = New System.Windows.Forms.RichTextBox()
        Me.rbnormal = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxgas = New System.Windows.Forms.ComboBox()
        Me.cbxunits = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxcompressor = New System.Windows.Forms.ComboBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.lvservicedetails = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblbookingno = New System.Windows.Forms.Label()
        Me.ServicePanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbACDetails.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServicePanel
        '
        Me.ServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServicePanel.Controls.Add(Me.Button1)
        Me.ServicePanel.Controls.Add(Me.GroupBox2)
        Me.ServicePanel.Controls.Add(Me.gbACDetails)
        Me.ServicePanel.Controls.Add(Me.btncancel)
        Me.ServicePanel.Controls.Add(Me.btnremove)
        Me.ServicePanel.Controls.Add(Me.btnnew)
        Me.ServicePanel.Controls.Add(Me.lvservicedetails)
        Me.ServicePanel.Controls.Add(Me.Panel7)
        Me.ServicePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServicePanel.Location = New System.Drawing.Point(0, 0)
        Me.ServicePanel.Name = "ServicePanel"
        Me.ServicePanel.Size = New System.Drawing.Size(784, 470)
        Me.ServicePanel.TabIndex = 55
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 32)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Add to PO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(450, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 239)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Instructions"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 205)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'gbACDetails
        '
        Me.gbACDetails.Controls.Add(Me.btncanceladd)
        Me.gbACDetails.Controls.Add(Me.btnupdate)
        Me.gbACDetails.Controls.Add(Me.Label8)
        Me.gbACDetails.Controls.Add(Me.cbxactype)
        Me.gbACDetails.Controls.Add(Me.btnadd)
        Me.gbACDetails.Controls.Add(Me.Label9)
        Me.gbACDetails.Controls.Add(Me.txtbrandmodel)
        Me.gbACDetails.Controls.Add(Me.rbinverter)
        Me.gbACDetails.Controls.Add(Me.txtremarks)
        Me.gbACDetails.Controls.Add(Me.rbnormal)
        Me.gbACDetails.Controls.Add(Me.Label14)
        Me.gbACDetails.Controls.Add(Me.Label10)
        Me.gbACDetails.Controls.Add(Me.cbxgas)
        Me.gbACDetails.Controls.Add(Me.cbxunits)
        Me.gbACDetails.Controls.Add(Me.Label13)
        Me.gbACDetails.Controls.Add(Me.Label12)
        Me.gbACDetails.Controls.Add(Me.cbxcompressor)
        Me.gbACDetails.Enabled = False
        Me.gbACDetails.Location = New System.Drawing.Point(12, 34)
        Me.gbACDetails.Name = "gbACDetails"
        Me.gbACDetails.Size = New System.Drawing.Size(423, 203)
        Me.gbACDetails.TabIndex = 57
        Me.gbACDetails.TabStop = False
        Me.gbACDetails.Text = "Aircon Details"
        '
        'btncanceladd
        '
        Me.btncanceladd.BackColor = System.Drawing.Color.Gainsboro
        Me.btncanceladd.FlatAppearance.BorderSize = 0
        Me.btncanceladd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btncanceladd.Location = New System.Drawing.Point(162, 169)
        Me.btncanceladd.Name = "btncanceladd"
        Me.btncanceladd.Size = New System.Drawing.Size(58, 23)
        Me.btncanceladd.TabIndex = 60
        Me.btncanceladd.Text = "Cancel"
        Me.btncanceladd.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Gainsboro
        Me.btnupdate.FlatAppearance.BorderSize = 0
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnupdate.Location = New System.Drawing.Point(226, 169)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(58, 23)
        Me.btnupdate.TabIndex = 60
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Select AC type:"
        '
        'cbxactype
        '
        Me.cbxactype.FormattingEnabled = True
        Me.cbxactype.Items.AddRange(New Object() {"Split", "Window", "Ceiling(Central)", "Cassette", "Standing"})
        Me.cbxactype.Location = New System.Drawing.Point(98, 16)
        Me.cbxactype.Name = "cbxactype"
        Me.cbxactype.Size = New System.Drawing.Size(178, 23)
        Me.cbxactype.TabIndex = 10
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnadd.Location = New System.Drawing.Point(98, 169)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(58, 23)
        Me.btnadd.TabIndex = 59
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Brand && Model:"
        '
        'txtbrandmodel
        '
        Me.txtbrandmodel.Location = New System.Drawing.Point(98, 46)
        Me.txtbrandmodel.Name = "txtbrandmodel"
        Me.txtbrandmodel.Size = New System.Drawing.Size(178, 23)
        Me.txtbrandmodel.TabIndex = 12
        '
        'rbinverter
        '
        Me.rbinverter.AutoSize = True
        Me.rbinverter.Location = New System.Drawing.Point(282, 15)
        Me.rbinverter.Name = "rbinverter"
        Me.rbinverter.Size = New System.Drawing.Size(65, 19)
        Me.rbinverter.TabIndex = 10
        Me.rbinverter.TabStop = True
        Me.rbinverter.Text = "Inverter"
        Me.rbinverter.UseVisualStyleBackColor = True
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(98, 106)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(270, 57)
        Me.txtremarks.TabIndex = 20
        Me.txtremarks.Text = ""
        '
        'rbnormal
        '
        Me.rbnormal.AutoSize = True
        Me.rbnormal.Location = New System.Drawing.Point(354, 15)
        Me.rbnormal.Name = "rbnormal"
        Me.rbnormal.Size = New System.Drawing.Size(65, 19)
        Me.rbnormal.TabIndex = 11
        Me.rbnormal.TabStop = True
        Me.rbnormal.Text = "Normal"
        Me.rbnormal.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Remarks/Details:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(283, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Units:"
        '
        'cbxgas
        '
        Me.cbxgas.FormattingEnabled = True
        Me.cbxgas.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxgas.Location = New System.Drawing.Point(326, 72)
        Me.cbxgas.Name = "cbxgas"
        Me.cbxgas.Size = New System.Drawing.Size(57, 23)
        Me.cbxgas.TabIndex = 18
        '
        'cbxunits
        '
        Me.cbxunits.FormattingEnabled = True
        Me.cbxunits.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cbxunits.Location = New System.Drawing.Point(326, 43)
        Me.cbxunits.Name = "cbxunits"
        Me.cbxunits.Size = New System.Drawing.Size(57, 23)
        Me.cbxunits.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(283, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Gas:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 30)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Compressor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Location:"
        '
        'cbxcompressor
        '
        Me.cbxcompressor.FormattingEnabled = True
        Me.cbxcompressor.Items.AddRange(New Object() {"OUTDOOR", "ROOF", "OTHERS"})
        Me.cbxcompressor.Location = New System.Drawing.Point(98, 75)
        Me.cbxcompressor.Name = "cbxcompressor"
        Me.cbxcompressor.Size = New System.Drawing.Size(178, 23)
        Me.cbxcompressor.TabIndex = 16
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(650, 425)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(121, 32)
        Me.btncancel.TabIndex = 56
        Me.btncancel.Text = "Cancel and Close"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.Gainsboro
        Me.btnremove.FlatAppearance.BorderSize = 0
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnremove.Location = New System.Drawing.Point(313, 250)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(122, 23)
        Me.btnremove.TabIndex = 47
        Me.btnremove.Text = "Remove Selected"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.Gainsboro
        Me.btnnew.FlatAppearance.BorderSize = 0
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnnew.Location = New System.Drawing.Point(19, 250)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(62, 23)
        Me.btnnew.TabIndex = 46
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'lvservicedetails
        '
        Me.lvservicedetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvservicedetails.FullRowSelect = True
        Me.lvservicedetails.GridLines = True
        Me.lvservicedetails.HideSelection = False
        Me.lvservicedetails.Location = New System.Drawing.Point(18, 279)
        Me.lvservicedetails.Name = "lvservicedetails"
        Me.lvservicedetails.Size = New System.Drawing.Size(753, 127)
        Me.lvservicedetails.TabIndex = 21
        Me.lvservicedetails.UseCompatibleStateImageBehavior = False
        Me.lvservicedetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "AC Type"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Brand & Model"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Units"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Compressor Location"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Gas"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Remarks"
        Me.ColumnHeader12.Width = 230
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.lblbookingno)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(782, 28)
        Me.Panel7.TabIndex = 0
        '
        'lblbookingno
        '
        Me.lblbookingno.AutoSize = True
        Me.lblbookingno.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblbookingno.ForeColor = System.Drawing.Color.White
        Me.lblbookingno.Location = New System.Drawing.Point(3, 3)
        Me.lblbookingno.Name = "lblbookingno"
        Me.lblbookingno.Size = New System.Drawing.Size(106, 20)
        Me.lblbookingno.TabIndex = 0
        Me.lblbookingno.Text = "Service Details"
        '
        'frmbookingdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.ServicePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmbookingdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ServicePanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbACDetails.ResumeLayout(False)
        Me.gbACDetails.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ServicePanel As Panel
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbACDetails As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxactype As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbrandmodel As TextBox
    Friend WithEvents rbinverter As RadioButton
    Friend WithEvents txtremarks As RichTextBox
    Friend WithEvents rbnormal As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxgas As ComboBox
    Friend WithEvents cbxunits As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxcompressor As ComboBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents lvservicedetails As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblbookingno As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btncanceladd As Button
End Class
