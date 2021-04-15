<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTASPROVEEDOR
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
        Dim IdProveedorLabel As System.Windows.Forms.Label
        Dim Nombre_De_ContactoLabel As System.Windows.Forms.Label
        Dim Nombre_De_EmpresaLabel As System.Windows.Forms.Label
        Dim Numero_TelefonicoLabel As System.Windows.Forms.Label
        Dim Direccion_De_La_EmpresaLabel As System.Windows.Forms.Label
        Dim Correo_ElectronicoLabel As System.Windows.Forms.Label
        Dim IdProductoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTASPROVEEDOR))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_DatosfinalDataSet = New MISISTEMA.Base_DatosfinalDataSet()
        Me.Correo_ElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.Direccion_De_La_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_TelefonicoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_De_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_De_ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.IdProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PROVEEDORESDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVEEDORESTableAdapter = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.PROVEEDORESTableAdapter()
        Me.TableAdapterManager = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        IdProveedorLabel = New System.Windows.Forms.Label()
        Nombre_De_ContactoLabel = New System.Windows.Forms.Label()
        Nombre_De_EmpresaLabel = New System.Windows.Forms.Label()
        Numero_TelefonicoLabel = New System.Windows.Forms.Label()
        Direccion_De_La_EmpresaLabel = New System.Windows.Forms.Label()
        Correo_ElectronicoLabel = New System.Windows.Forms.Label()
        IdProductoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.ForeColor = System.Drawing.Color.White
        IdProveedorLabel.Location = New System.Drawing.Point(32, 11)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(71, 13)
        IdProveedorLabel.TabIndex = 0
        IdProveedorLabel.Text = "Id Proveedor:"
        '
        'Nombre_De_ContactoLabel
        '
        Nombre_De_ContactoLabel.AutoSize = True
        Nombre_De_ContactoLabel.ForeColor = System.Drawing.Color.White
        Nombre_De_ContactoLabel.Location = New System.Drawing.Point(32, 47)
        Nombre_De_ContactoLabel.Name = "Nombre_De_ContactoLabel"
        Nombre_De_ContactoLabel.Size = New System.Drawing.Size(110, 13)
        Nombre_De_ContactoLabel.TabIndex = 2
        Nombre_De_ContactoLabel.Text = "Nombre De Contacto:"
        '
        'Nombre_De_EmpresaLabel
        '
        Nombre_De_EmpresaLabel.AutoSize = True
        Nombre_De_EmpresaLabel.ForeColor = System.Drawing.Color.White
        Nombre_De_EmpresaLabel.Location = New System.Drawing.Point(34, 73)
        Nombre_De_EmpresaLabel.Name = "Nombre_De_EmpresaLabel"
        Nombre_De_EmpresaLabel.Size = New System.Drawing.Size(108, 13)
        Nombre_De_EmpresaLabel.TabIndex = 4
        Nombre_De_EmpresaLabel.Text = "Nombre De Empresa:"
        '
        'Numero_TelefonicoLabel
        '
        Numero_TelefonicoLabel.AutoSize = True
        Numero_TelefonicoLabel.ForeColor = System.Drawing.Color.White
        Numero_TelefonicoLabel.Location = New System.Drawing.Point(42, 99)
        Numero_TelefonicoLabel.Name = "Numero_TelefonicoLabel"
        Numero_TelefonicoLabel.Size = New System.Drawing.Size(100, 13)
        Numero_TelefonicoLabel.TabIndex = 6
        Numero_TelefonicoLabel.Text = "Numero Telefonico:"
        '
        'Direccion_De_La_EmpresaLabel
        '
        Direccion_De_La_EmpresaLabel.AutoSize = True
        Direccion_De_La_EmpresaLabel.ForeColor = System.Drawing.Color.White
        Direccion_De_La_EmpresaLabel.Location = New System.Drawing.Point(263, 47)
        Direccion_De_La_EmpresaLabel.Name = "Direccion_De_La_EmpresaLabel"
        Direccion_De_La_EmpresaLabel.Size = New System.Drawing.Size(131, 13)
        Direccion_De_La_EmpresaLabel.TabIndex = 8
        Direccion_De_La_EmpresaLabel.Text = "Direccion De La Empresa:"
        '
        'Correo_ElectronicoLabel
        '
        Correo_ElectronicoLabel.AutoSize = True
        Correo_ElectronicoLabel.ForeColor = System.Drawing.Color.White
        Correo_ElectronicoLabel.Location = New System.Drawing.Point(297, 73)
        Correo_ElectronicoLabel.Name = "Correo_ElectronicoLabel"
        Correo_ElectronicoLabel.Size = New System.Drawing.Size(97, 13)
        Correo_ElectronicoLabel.TabIndex = 10
        Correo_ElectronicoLabel.Text = "Correo Electronico:"
        '
        'IdProductoLabel
        '
        IdProductoLabel.AutoSize = True
        IdProductoLabel.ForeColor = System.Drawing.Color.White
        IdProductoLabel.Location = New System.Drawing.Point(329, 99)
        IdProductoLabel.Name = "IdProductoLabel"
        IdProductoLabel.Size = New System.Drawing.Size(65, 13)
        IdProductoLabel.TabIndex = 12
        IdProductoLabel.Text = "Id Producto:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 33)
        Me.Panel1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALTAS PROVEEDORES"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnguardar)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(IdProductoLabel)
        Me.Panel2.Controls.Add(Me.IdProductoTextBox)
        Me.Panel2.Controls.Add(Correo_ElectronicoLabel)
        Me.Panel2.Controls.Add(Me.Correo_ElectronicoTextBox)
        Me.Panel2.Controls.Add(Direccion_De_La_EmpresaLabel)
        Me.Panel2.Controls.Add(Me.Direccion_De_La_EmpresaTextBox)
        Me.Panel2.Controls.Add(Numero_TelefonicoLabel)
        Me.Panel2.Controls.Add(Me.Numero_TelefonicoTextBox)
        Me.Panel2.Controls.Add(Nombre_De_EmpresaLabel)
        Me.Panel2.Controls.Add(Me.Nombre_De_EmpresaTextBox)
        Me.Panel2.Controls.Add(Nombre_De_ContactoLabel)
        Me.Panel2.Controls.Add(Me.Nombre_De_ContactoTextBox)
        Me.Panel2.Controls.Add(IdProveedorLabel)
        Me.Panel2.Controls.Add(Me.IdProveedorTextBox)
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 157)
        Me.Panel2.TabIndex = 40
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(545, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 23)
        Me.Button5.TabIndex = 48
        Me.Button5.Text = "LIMPIAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(545, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "REORGANIZAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(182, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "IdProducto", True))
        Me.IdProductoTextBox.Location = New System.Drawing.Point(400, 96)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdProductoTextBox.TabIndex = 13
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.Base_DatosfinalDataSet
        '
        'Base_DatosfinalDataSet
        '
        Me.Base_DatosfinalDataSet.DataSetName = "Base_DatosfinalDataSet"
        Me.Base_DatosfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Correo_ElectronicoTextBox
        '
        Me.Correo_ElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Correo Electronico", True))
        Me.Correo_ElectronicoTextBox.Location = New System.Drawing.Point(400, 70)
        Me.Correo_ElectronicoTextBox.Name = "Correo_ElectronicoTextBox"
        Me.Correo_ElectronicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Correo_ElectronicoTextBox.TabIndex = 11
        '
        'Direccion_De_La_EmpresaTextBox
        '
        Me.Direccion_De_La_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Direccion De La Empresa", True))
        Me.Direccion_De_La_EmpresaTextBox.Location = New System.Drawing.Point(400, 44)
        Me.Direccion_De_La_EmpresaTextBox.Name = "Direccion_De_La_EmpresaTextBox"
        Me.Direccion_De_La_EmpresaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Direccion_De_La_EmpresaTextBox.TabIndex = 9
        '
        'Numero_TelefonicoTextBox
        '
        Me.Numero_TelefonicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Numero Telefonico", True))
        Me.Numero_TelefonicoTextBox.Location = New System.Drawing.Point(148, 96)
        Me.Numero_TelefonicoTextBox.Name = "Numero_TelefonicoTextBox"
        Me.Numero_TelefonicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_TelefonicoTextBox.TabIndex = 7
        '
        'Nombre_De_EmpresaTextBox
        '
        Me.Nombre_De_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Nombre De Empresa", True))
        Me.Nombre_De_EmpresaTextBox.Location = New System.Drawing.Point(148, 70)
        Me.Nombre_De_EmpresaTextBox.Name = "Nombre_De_EmpresaTextBox"
        Me.Nombre_De_EmpresaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_De_EmpresaTextBox.TabIndex = 5
        '
        'Nombre_De_ContactoTextBox
        '
        Me.Nombre_De_ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Nombre De Contacto", True))
        Me.Nombre_De_ContactoTextBox.Location = New System.Drawing.Point(148, 44)
        Me.Nombre_De_ContactoTextBox.Name = "Nombre_De_ContactoTextBox"
        Me.Nombre_De_ContactoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_De_ContactoTextBox.TabIndex = 3
        '
        'IdProveedorTextBox
        '
        Me.IdProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "IdProveedor", True))
        Me.IdProveedorTextBox.Location = New System.Drawing.Point(109, 8)
        Me.IdProveedorTextBox.Name = "IdProveedorTextBox"
        Me.IdProveedorTextBox.Size = New System.Drawing.Size(52, 20)
        Me.IdProveedorTextBox.TabIndex = 1
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Location = New System.Drawing.Point(96, 129)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 42
        Me.btnguardar.Text = "MODIFICAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(464, 129)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(284, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PROVEEDORESDataGridView
        '
        Me.PROVEEDORESDataGridView.AutoGenerateColumns = False
        Me.PROVEEDORESDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PROVEEDORESDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PROVEEDORESDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PROVEEDORESDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PROVEEDORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PROVEEDORESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PROVEEDORESDataGridView.DataSource = Me.PROVEEDORESBindingSource
        Me.PROVEEDORESDataGridView.EnableHeadersVisualStyles = False
        Me.PROVEEDORESDataGridView.Location = New System.Drawing.Point(30, 256)
        Me.PROVEEDORESDataGridView.Name = "PROVEEDORESDataGridView"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PROVEEDORESDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.PROVEEDORESDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.PROVEEDORESDataGridView.Size = New System.Drawing.Size(737, 220)
        Me.PROVEEDORESDataGridView.TabIndex = 46
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdProveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre De Contacto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre De Contacto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre De Empresa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre De Empresa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Numero Telefonico"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero Telefonico"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Direccion De La Empresa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Direccion De La Empresa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Correo Electronico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Correo Electronico"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdProducto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.PROVEEDORESTableAdapter = Me.PROVEEDORESTableAdapter
        Me.TableAdapterManager.UpdateOrder = MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(296, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 26)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "LISTADO PROVEEDORES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(645, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'ALTASPROVEEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 488)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PROVEEDORESDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ALTASPROVEEDOR"
        Me.Text = "ALTASPROVEEDOR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnguardar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Base_DatosfinalDataSet As Base_DatosfinalDataSet
    Friend WithEvents PROVEEDORESBindingSource As BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As Base_DatosfinalDataSetTableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents TableAdapterManager As Base_DatosfinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PROVEEDORESDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents Correo_ElectronicoTextBox As TextBox
    Friend WithEvents Direccion_De_La_EmpresaTextBox As TextBox
    Friend WithEvents Numero_TelefonicoTextBox As TextBox
    Friend WithEvents Nombre_De_EmpresaTextBox As TextBox
    Friend WithEvents Nombre_De_ContactoTextBox As TextBox
    Friend WithEvents IdProveedorTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
