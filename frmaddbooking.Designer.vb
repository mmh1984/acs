<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddbooking
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerPanel = New System.Windows.Forms.Panel()
        Me.lvCustomers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BookingPanel = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.cbxampm = New System.Windows.Forms.ComboBox()
        Me.txttime = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtdate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.rbdifferentaddress = New System.Windows.Forms.RadioButton()
        Me.rbsameaddress = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ServicePanel = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnsavebooking = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lvservicedetails = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader()
        Me.txtremarks = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxgas = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbxcompressor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxunits = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rbnormal = New System.Windows.Forms.RadioButton()
        Me.rbinverter = New System.Windows.Forms.RadioButton()
        Me.txtbrandmodel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxactype = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.CustomerPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.BookingPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ServicePanel.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 48)
        Me.Panel1.TabIndex = 51
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Gainsboro
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(915, 16)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(57, 23)
        Me.btnclose.TabIndex = 45
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking Details"
        '
        'CustomerPanel
        '
        Me.CustomerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerPanel.Controls.Add(Me.lvCustomers)
        Me.CustomerPanel.Controls.Add(Me.txtsearch)
        Me.CustomerPanel.Controls.Add(Me.Label3)
        Me.CustomerPanel.Controls.Add(Me.Panel3)
        Me.CustomerPanel.Location = New System.Drawing.Point(12, 54)
        Me.CustomerPanel.Name = "CustomerPanel"
        Me.CustomerPanel.Size = New System.Drawing.Size(475, 244)
        Me.CustomerPanel.TabIndex = 52
        '
        'lvCustomers
        '
        Me.lvCustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvCustomers.FullRowSelect = True
        Me.lvCustomers.GridLines = True
        Me.lvCustomers.HideSelection = False
        Me.lvCustomers.Location = New System.Drawing.Point(0, 61)
        Me.lvCustomers.Margin = New System.Windows.Forms.Padding(5)
        Me.lvCustomers.MultiSelect = False
        Me.lvCustomers.Name = "lvCustomers"
        Me.lvCustomers.Size = New System.Drawing.Size(473, 181)
        Me.lvCustomers.TabIndex = 5
        Me.lvCustomers.UseCompatibleStateImageBehavior = False
        Me.lvCustomers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Customer Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Company Name"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Phone Number"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "District"
        Me.ColumnHeader6.Width = 100
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Location = New System.Drawing.Point(223, 30)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(231, 23)
        Me.txtsearch.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(2, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Search: (Type the name and press enter)"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(473, 28)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Step 1: Customer Details (Select customer after search)"
        '
        'BookingPanel
        '
        Me.BookingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BookingPanel.Controls.Add(Me.Label16)
        Me.BookingPanel.Controls.Add(Me.Label15)
        Me.BookingPanel.Controls.Add(Me.btnnext)
        Me.BookingPanel.Controls.Add(Me.cbxampm)
        Me.BookingPanel.Controls.Add(Me.txttime)
        Me.BookingPanel.Controls.Add(Me.Label7)
        Me.BookingPanel.Controls.Add(Me.dtdate)
        Me.BookingPanel.Controls.Add(Me.Label6)
        Me.BookingPanel.Controls.Add(Me.txtaddress)
        Me.BookingPanel.Controls.Add(Me.rbdifferentaddress)
        Me.BookingPanel.Controls.Add(Me.rbsameaddress)
        Me.BookingPanel.Controls.Add(Me.Label4)
        Me.BookingPanel.Controls.Add(Me.Panel5)
        Me.BookingPanel.Enabled = False
        Me.BookingPanel.Location = New System.Drawing.Point(13, 305)
        Me.BookingPanel.Name = "BookingPanel"
        Me.BookingPanel.Size = New System.Drawing.Size(475, 184)
        Me.BookingPanel.TabIndex = 53
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(257, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 15)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "am/pm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(200, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 15)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "hh:mm"
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Gainsboro
        Me.btnnext.FlatAppearance.BorderSize = 0
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnnext.Location = New System.Drawing.Point(396, 141)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(57, 23)
        Me.btnnext.TabIndex = 47
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'cbxampm
        '
        Me.cbxampm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxampm.FormattingEnabled = True
        Me.cbxampm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbxampm.Location = New System.Drawing.Point(258, 141)
        Me.cbxampm.Name = "cbxampm"
        Me.cbxampm.Size = New System.Drawing.Size(45, 23)
        Me.cbxampm.TabIndex = 9
        '
        'txttime
        '
        Me.txttime.Location = New System.Drawing.Point(200, 141)
        Me.txttime.Mask = "90:00"
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(52, 23)
        Me.txttime.TabIndex = 8
        Me.txttime.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Time:"
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MM/yyyy"
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(45, 141)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(104, 23)
        Me.dtdate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date:"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(4, 54)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(465, 57)
        Me.txtaddress.TabIndex = 4
        Me.txtaddress.Text = ""
        '
        'rbdifferentaddress
        '
        Me.rbdifferentaddress.AutoSize = True
        Me.rbdifferentaddress.Location = New System.Drawing.Point(281, 33)
        Me.rbdifferentaddress.Name = "rbdifferentaddress"
        Me.rbdifferentaddress.Size = New System.Drawing.Size(116, 19)
        Me.rbdifferentaddress.TabIndex = 3
        Me.rbdifferentaddress.TabStop = True
        Me.rbdifferentaddress.Text = "Different Address"
        Me.rbdifferentaddress.UseVisualStyleBackColor = True
        '
        'rbsameaddress
        '
        Me.rbsameaddress.AutoSize = True
        Me.rbsameaddress.Location = New System.Drawing.Point(107, 33)
        Me.rbsameaddress.Name = "rbsameaddress"
        Me.rbsameaddress.Size = New System.Drawing.Size(168, 19)
        Me.rbsameaddress.TabIndex = 2
        Me.rbsameaddress.TabStop = True
        Me.rbsameaddress.Text = "Same as Customer Address"
        Me.rbsameaddress.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Booking address:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(473, 28)
        Me.Panel5.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Step 2: Booking Details (Click next once complete)"
        '
        'ServicePanel
        '
        Me.ServicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ServicePanel.Controls.Add(Me.btncancel)
        Me.ServicePanel.Controls.Add(Me.btnremove)
        Me.ServicePanel.Controls.Add(Me.btnsavebooking)
        Me.ServicePanel.Controls.Add(Me.btnadd)
        Me.ServicePanel.Controls.Add(Me.lvservicedetails)
        Me.ServicePanel.Controls.Add(Me.txtremarks)
        Me.ServicePanel.Controls.Add(Me.Label14)
        Me.ServicePanel.Controls.Add(Me.cbxgas)
        Me.ServicePanel.Controls.Add(Me.Label13)
        Me.ServicePanel.Controls.Add(Me.cbxcompressor)
        Me.ServicePanel.Controls.Add(Me.Label12)
        Me.ServicePanel.Controls.Add(Me.cbxunits)
        Me.ServicePanel.Controls.Add(Me.Label10)
        Me.ServicePanel.Controls.Add(Me.rbnormal)
        Me.ServicePanel.Controls.Add(Me.rbinverter)
        Me.ServicePanel.Controls.Add(Me.txtbrandmodel)
        Me.ServicePanel.Controls.Add(Me.Label9)
        Me.ServicePanel.Controls.Add(Me.cbxactype)
        Me.ServicePanel.Controls.Add(Me.Label8)
        Me.ServicePanel.Controls.Add(Me.Panel7)
        Me.ServicePanel.Enabled = False
        Me.ServicePanel.Location = New System.Drawing.Point(494, 55)
        Me.ServicePanel.Name = "ServicePanel"
        Me.ServicePanel.Size = New System.Drawing.Size(489, 434)
        Me.ServicePanel.TabIndex = 54
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(359, 391)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(121, 32)
        Me.btncancel.TabIndex = 56
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.Gainsboro
        Me.btnremove.FlatAppearance.BorderSize = 0
        Me.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnremove.Location = New System.Drawing.Point(351, 220)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(122, 23)
        Me.btnremove.TabIndex = 47
        Me.btnremove.Text = "Remove Selected"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btnsavebooking
        '
        Me.btnsavebooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsavebooking.FlatAppearance.BorderSize = 0
        Me.btnsavebooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsavebooking.ForeColor = System.Drawing.Color.Black
        Me.btnsavebooking.Location = New System.Drawing.Point(237, 391)
        Me.btnsavebooking.Name = "btnsavebooking"
        Me.btnsavebooking.Size = New System.Drawing.Size(116, 32)
        Me.btnsavebooking.TabIndex = 55
        Me.btnsavebooking.Text = "Save Booking"
        Me.btnsavebooking.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Gainsboro
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnadd.Location = New System.Drawing.Point(13, 219)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(57, 23)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lvservicedetails
        '
        Me.lvservicedetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvservicedetails.FullRowSelect = True
        Me.lvservicedetails.GridLines = True
        Me.lvservicedetails.HideSelection = False
        Me.lvservicedetails.Location = New System.Drawing.Point(12, 249)
        Me.lvservicedetails.Name = "lvservicedetails"
        Me.lvservicedetails.Size = New System.Drawing.Size(465, 127)
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
        Me.ColumnHeader10.Width = 120
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Gas"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Remarks"
        Me.ColumnHeader12.Width = 200
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(12, 149)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(465, 57)
        Me.txtremarks.TabIndex = 20
        Me.txtremarks.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Remarks/Details:"
        '
        'cbxgas
        '
        Me.cbxgas.FormattingEnabled = True
        Me.cbxgas.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxgas.Location = New System.Drawing.Point(359, 89)
        Me.cbxgas.Name = "cbxgas"
        Me.cbxgas.Size = New System.Drawing.Size(76, 23)
        Me.cbxgas.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(316, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 15)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Gas:"
        '
        'cbxcompressor
        '
        Me.cbxcompressor.FormattingEnabled = True
        Me.cbxcompressor.Items.AddRange(New Object() {"OUTDOOR", "ROOF", "OTHERS"})
        Me.cbxcompressor.Location = New System.Drawing.Point(104, 89)
        Me.cbxcompressor.Name = "cbxcompressor"
        Me.cbxcompressor.Size = New System.Drawing.Size(197, 23)
        Me.cbxcompressor.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 30)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Compressor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Location:"
        '
        'cbxunits
        '
        Me.cbxunits.FormattingEnabled = True
        Me.cbxunits.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"})
        Me.cbxunits.Location = New System.Drawing.Point(359, 60)
        Me.cbxunits.Name = "cbxunits"
        Me.cbxunits.Size = New System.Drawing.Size(76, 23)
        Me.cbxunits.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(316, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Units:"
        '
        'rbnormal
        '
        Me.rbnormal.AutoSize = True
        Me.rbnormal.Location = New System.Drawing.Point(387, 32)
        Me.rbnormal.Name = "rbnormal"
        Me.rbnormal.Size = New System.Drawing.Size(65, 19)
        Me.rbnormal.TabIndex = 11
        Me.rbnormal.TabStop = True
        Me.rbnormal.Text = "Normal"
        Me.rbnormal.UseVisualStyleBackColor = True
        '
        'rbinverter
        '
        Me.rbinverter.AutoSize = True
        Me.rbinverter.Location = New System.Drawing.Point(315, 32)
        Me.rbinverter.Name = "rbinverter"
        Me.rbinverter.Size = New System.Drawing.Size(65, 19)
        Me.rbinverter.TabIndex = 10
        Me.rbinverter.TabStop = True
        Me.rbinverter.Text = "Inverter"
        Me.rbinverter.UseVisualStyleBackColor = True
        '
        'txtbrandmodel
        '
        Me.txtbrandmodel.Location = New System.Drawing.Point(104, 60)
        Me.txtbrandmodel.Name = "txtbrandmodel"
        Me.txtbrandmodel.Size = New System.Drawing.Size(197, 23)
        Me.txtbrandmodel.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Brand && Model:"
        '
        'cbxactype
        '
        Me.cbxactype.FormattingEnabled = True
        Me.cbxactype.Items.AddRange(New Object() {"Split", "Window", "Ceiling(Central)", "Cassette", "Standing"})
        Me.cbxactype.Location = New System.Drawing.Point(104, 30)
        Me.cbxactype.Name = "cbxactype"
        Me.cbxactype.Size = New System.Drawing.Size(197, 23)
        Me.cbxactype.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Select AC type:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(487, 28)
        Me.Panel7.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Service Details"
        '
        'frmaddbooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.ServicePanel)
        Me.Controls.Add(Me.BookingPanel)
        Me.Controls.Add(Me.CustomerPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmaddbooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CustomerPanel.ResumeLayout(False)
        Me.CustomerPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.BookingPanel.ResumeLayout(False)
        Me.BookingPanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ServicePanel.ResumeLayout(False)
        Me.ServicePanel.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lvCustomers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents BookingPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dtdate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents rbdifferentaddress As RadioButton
    Friend WithEvents rbsameaddress As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxampm As ComboBox
    Friend WithEvents txttime As MaskedTextBox
    Friend WithEvents ServicePanel As Panel
    Friend WithEvents lvservicedetails As ListView
    Friend WithEvents txtremarks As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbxgas As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbxcompressor As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxunits As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rbnormal As RadioButton
    Friend WithEvents rbinverter As RadioButton
    Friend WithEvents txtbrandmodel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxactype As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btnsavebooking As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents btnnext As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
