<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTASCLIENTES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim CALLELabel As System.Windows.Forms.Label
        Dim COLONIALabel As System.Windows.Forms.Label
        Dim NUMERO_RESIDENCIALLabel As System.Windows.Forms.Label
        Dim CODIGO_POSTALLabel As System.Windows.Forms.Label
        Dim EDADLabel As System.Windows.Forms.Label
        Dim NUMERO_TELEFONICOLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTASCLIENTES))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUMERO_TELEFONICOTextBox = New System.Windows.Forms.TextBox()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_DatosfinalDataSet = New MISISTEMA.Base_DatosfinalDataSet()
        Me.EDADTextBox = New System.Windows.Forms.TextBox()
        Me.CODIGO_POSTALTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NUMERO_RESIDENCIALTextBox = New System.Windows.Forms.TextBox()
        Me.COLONIATextBox = New System.Windows.Forms.TextBox()
        Me.CALLETextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CLIENTESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTESTableAdapter = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.CLIENTESTableAdapter()
        Me.TableAdapterManager = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        CALLELabel = New System.Windows.Forms.Label()
        COLONIALabel = New System.Windows.Forms.Label()
        NUMERO_RESIDENCIALLabel = New System.Windows.Forms.Label()
        CODIGO_POSTALLabel = New System.Windows.Forms.Label()
        EDADLabel = New System.Windows.Forms.Label()
        NUMERO_TELEFONICOLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.ForeColor = System.Drawing.Color.White
        IdClienteLabel.Location = New System.Drawing.Point(64, 58)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(66, 13)
        IdClienteLabel.TabIndex = 21
        IdClienteLabel.Text = "ID CLIENTE"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.ForeColor = System.Drawing.Color.White
        NOMBRELabel.Location = New System.Drawing.Point(76, 81)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 23
        NOMBRELabel.Text = "NOMBRE:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.ForeColor = System.Drawing.Color.White
        APELLIDOSLabel.Location = New System.Drawing.Point(64, 107)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(69, 13)
        APELLIDOSLabel.TabIndex = 24
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'CALLELabel
        '
        CALLELabel.AutoSize = True
        CALLELabel.ForeColor = System.Drawing.Color.White
        CALLELabel.Location = New System.Drawing.Point(90, 137)
        CALLELabel.Name = "CALLELabel"
        CALLELabel.Size = New System.Drawing.Size(43, 13)
        CALLELabel.TabIndex = 25
        CALLELabel.Text = "CALLE:"
        '
        'COLONIALabel
        '
        COLONIALabel.AutoSize = True
        COLONIALabel.ForeColor = System.Drawing.Color.White
        COLONIALabel.Location = New System.Drawing.Point(324, 57)
        COLONIALabel.Name = "COLONIALabel"
        COLONIALabel.Size = New System.Drawing.Size(57, 13)
        COLONIALabel.TabIndex = 26
        COLONIALabel.Text = "COLONIA:"
        '
        'NUMERO_RESIDENCIALLabel
        '
        NUMERO_RESIDENCIALLabel.AutoSize = True
        NUMERO_RESIDENCIALLabel.ForeColor = System.Drawing.Color.White
        NUMERO_RESIDENCIALLabel.Location = New System.Drawing.Point(253, 136)
        NUMERO_RESIDENCIALLabel.Name = "NUMERO_RESIDENCIALLabel"
        NUMERO_RESIDENCIALLabel.Size = New System.Drawing.Size(132, 13)
        NUMERO_RESIDENCIALLabel.TabIndex = 27
        NUMERO_RESIDENCIALLabel.Text = "NUMERO RESIDENCIAL:"
        '
        'CODIGO_POSTALLabel
        '
        CODIGO_POSTALLabel.AutoSize = True
        CODIGO_POSTALLabel.ForeColor = System.Drawing.Color.White
        CODIGO_POSTALLabel.Location = New System.Drawing.Point(284, 110)
        CODIGO_POSTALLabel.Name = "CODIGO_POSTALLabel"
        CODIGO_POSTALLabel.Size = New System.Drawing.Size(97, 13)
        CODIGO_POSTALLabel.TabIndex = 28
        CODIGO_POSTALLabel.Text = "CODIGO POSTAL:"
        '
        'EDADLabel
        '
        EDADLabel.AutoSize = True
        EDADLabel.ForeColor = System.Drawing.Color.White
        EDADLabel.Location = New System.Drawing.Point(341, 84)
        EDADLabel.Name = "EDADLabel"
        EDADLabel.Size = New System.Drawing.Size(40, 13)
        EDADLabel.TabIndex = 29
        EDADLabel.Text = "EDAD:"
        '
        'NUMERO_TELEFONICOLabel
        '
        NUMERO_TELEFONICOLabel.AutoSize = True
        NUMERO_TELEFONICOLabel.ForeColor = System.Drawing.Color.White
        NUMERO_TELEFONICOLabel.Location = New System.Drawing.Point(5, 163)
        NUMERO_TELEFONICOLabel.Name = "NUMERO_TELEFONICOLabel"
        NUMERO_TELEFONICOLabel.Size = New System.Drawing.Size(128, 13)
        NUMERO_TELEFONICOLabel.TabIndex = 30
        NUMERO_TELEFONICOLabel.Text = "NUMERO TELEFONICO:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(395, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALTAS CLIENTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Location = New System.Drawing.Point(792, 183)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 33)
        Me.btncancelar.TabIndex = 17
        Me.btncancelar.Text = "RESTAURAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 33)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(NUMERO_TELEFONICOLabel)
        Me.Panel2.Controls.Add(Me.NUMERO_TELEFONICOTextBox)
        Me.Panel2.Controls.Add(EDADLabel)
        Me.Panel2.Controls.Add(Me.EDADTextBox)
        Me.Panel2.Controls.Add(CODIGO_POSTALLabel)
        Me.Panel2.Controls.Add(Me.CODIGO_POSTALTextBox)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(NUMERO_RESIDENCIALLabel)
        Me.Panel2.Controls.Add(Me.NUMERO_RESIDENCIALTextBox)
        Me.Panel2.Controls.Add(COLONIALabel)
        Me.Panel2.Controls.Add(Me.COLONIATextBox)
        Me.Panel2.Controls.Add(CALLELabel)
        Me.Panel2.Controls.Add(Me.CALLETextBox)
        Me.Panel2.Controls.Add(APELLIDOSLabel)
        Me.Panel2.Controls.Add(Me.APELLIDOSTextBox)
        Me.Panel2.Controls.Add(NOMBRELabel)
        Me.Panel2.Controls.Add(Me.NOMBRETextBox)
        Me.Panel2.Controls.Add(IdClienteLabel)
        Me.Panel2.Controls.Add(Me.IdClienteTextBox)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(204, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 247)
        Me.Panel2.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(133, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 33)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "MANTENIMIENTO CLIENTES"
        '
        'NUMERO_TELEFONICOTextBox
        '
        Me.NUMERO_TELEFONICOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "NUMERO TELEFONICO", True))
        Me.NUMERO_TELEFONICOTextBox.Location = New System.Drawing.Point(139, 156)
        Me.NUMERO_TELEFONICOTextBox.Name = "NUMERO_TELEFONICOTextBox"
        Me.NUMERO_TELEFONICOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUMERO_TELEFONICOTextBox.TabIndex = 31
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.Base_DatosfinalDataSet
        '
        'Base_DatosfinalDataSet
        '
        Me.Base_DatosfinalDataSet.DataSetName = "Base_DatosfinalDataSet"
        Me.Base_DatosfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EDADTextBox
        '
        Me.EDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "EDAD", True))
        Me.EDADTextBox.Location = New System.Drawing.Point(387, 77)
        Me.EDADTextBox.Name = "EDADTextBox"
        Me.EDADTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EDADTextBox.TabIndex = 30
        '
        'CODIGO_POSTALTextBox
        '
        Me.CODIGO_POSTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CODIGO POSTAL", True))
        Me.CODIGO_POSTALTextBox.Location = New System.Drawing.Point(387, 103)
        Me.CODIGO_POSTALTextBox.Name = "CODIGO_POSTALTextBox"
        Me.CODIGO_POSTALTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CODIGO_POSTALTextBox.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(206, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NUMERO_RESIDENCIALTextBox
        '
        Me.NUMERO_RESIDENCIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "NUMERO RESIDENCIAL", True))
        Me.NUMERO_RESIDENCIALTextBox.Location = New System.Drawing.Point(387, 133)
        Me.NUMERO_RESIDENCIALTextBox.Name = "NUMERO_RESIDENCIALTextBox"
        Me.NUMERO_RESIDENCIALTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUMERO_RESIDENCIALTextBox.TabIndex = 28
        '
        'COLONIATextBox
        '
        Me.COLONIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "COLONIA", True))
        Me.COLONIATextBox.Location = New System.Drawing.Point(387, 50)
        Me.COLONIATextBox.Name = "COLONIATextBox"
        Me.COLONIATextBox.Size = New System.Drawing.Size(100, 20)
        Me.COLONIATextBox.TabIndex = 27
        '
        'CALLETextBox
        '
        Me.CALLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CALLE", True))
        Me.CALLETextBox.Location = New System.Drawing.Point(139, 130)
        Me.CALLETextBox.Name = "CALLETextBox"
        Me.CALLETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CALLETextBox.TabIndex = 26
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(139, 104)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDOSTextBox.TabIndex = 25
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(139, 78)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRETextBox.TabIndex = 24
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "IdCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(139, 52)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdClienteTextBox.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(245, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 20)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(792, 87)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 33)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "LIMPIAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(792, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 33)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(792, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 33)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "MODIFICAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CLIENTESDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        Me.CLIENTESDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CLIENTESDataGridView.AutoGenerateColumns = False
        Me.CLIENTESDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CLIENTESDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CLIENTESDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.CLIENTESDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLIENTESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CLIENTESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CLIENTESDataGridView.DataSource = Me.CLIENTESBindingSource
        Me.CLIENTESDataGridView.EnableHeadersVisualStyles = False
        Me.CLIENTESDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CLIENTESDataGridView.Location = New System.Drawing.Point(0, 329)
        Me.CLIENTESDataGridView.Name = "CLIENTESDataGridView"
        Me.CLIENTESDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLIENTESDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CLIENTESDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.CLIENTESDataGridView.Size = New System.Drawing.Size(933, 168)
        Me.CLIENTESDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APELLIDOS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDOS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CALLE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CALLE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "COLONIA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "COLONIA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NUMERO RESIDENCIAL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NUMERO RESIDENCIAL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CODIGO POSTAL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CODIGO POSTAL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EDAD"
        Me.DataGridViewTextBoxColumn8.HeaderText = "EDAD"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NUMERO TELEFONICO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NUMERO TELEFONICO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.CLIENTESTableAdapter
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.PROVEEDORESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 28)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "LISTADO CLIENTES"
        '
        'ALTASCLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(945, 502)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.CLIENTESDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btncancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ALTASCLIENTES"
        Me.Text = "ALTASCLIENTES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Base_DatosfinalDataSet As Base_DatosfinalDataSet
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As Base_DatosfinalDataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents TableAdapterManager As Base_DatosfinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTESDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO_TELEFONICOTextBox As TextBox
    Friend WithEvents EDADTextBox As TextBox
    Friend WithEvents CODIGO_POSTALTextBox As TextBox
    Friend WithEvents NUMERO_RESIDENCIALTextBox As TextBox
    Friend WithEvents COLONIATextBox As TextBox
    Friend WithEvents CALLETextBox As TextBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
