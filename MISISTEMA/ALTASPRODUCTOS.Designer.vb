<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTASPRODUCTOS
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
        Dim NOMBRE_DEL_PRODUCTOLabel As System.Windows.Forms.Label
        Dim PRECIO_x_UNIDADLabel As System.Windows.Forms.Label
        Dim PRECIO_x_MAYOREOLabel As System.Windows.Forms.Label
        Dim PRODUCTOS_EN_EXISTENCIALabel As System.Windows.Forms.Label
        Dim IdProveedorLabel As System.Windows.Forms.Label
        Dim IdProductoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PRODUCTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_DatosfinalDataSet = New MISISTEMA.Base_DatosfinalDataSet()
        Me.NOMBRE_DEL_PRODUCTOTextBox = New System.Windows.Forms.TextBox()
        Me.PRECIO_x_UNIDADTextBox = New System.Windows.Forms.TextBox()
        Me.PRECIO_x_MAYOREOTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCTOS_EN_EXISTENCIATextBox = New System.Windows.Forms.TextBox()
        Me.IdProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PRODUCTOSTableAdapter = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.PRODUCTOSTableAdapter()
        Me.TableAdapterManager = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        NOMBRE_DEL_PRODUCTOLabel = New System.Windows.Forms.Label()
        PRECIO_x_UNIDADLabel = New System.Windows.Forms.Label()
        PRECIO_x_MAYOREOLabel = New System.Windows.Forms.Label()
        PRODUCTOS_EN_EXISTENCIALabel = New System.Windows.Forms.Label()
        IdProveedorLabel = New System.Windows.Forms.Label()
        IdProductoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'NOMBRE_DEL_PRODUCTOLabel
        '
        NOMBRE_DEL_PRODUCTOLabel.AutoSize = True
        NOMBRE_DEL_PRODUCTOLabel.ForeColor = System.Drawing.Color.White
        NOMBRE_DEL_PRODUCTOLabel.Location = New System.Drawing.Point(17, 8)
        NOMBRE_DEL_PRODUCTOLabel.Name = "NOMBRE_DEL_PRODUCTOLabel"
        NOMBRE_DEL_PRODUCTOLabel.Size = New System.Drawing.Size(145, 13)
        NOMBRE_DEL_PRODUCTOLabel.TabIndex = 44
        NOMBRE_DEL_PRODUCTOLabel.Text = "NOMBRE DEL PRODUCTO:"
        '
        'PRECIO_x_UNIDADLabel
        '
        PRECIO_x_UNIDADLabel.AutoSize = True
        PRECIO_x_UNIDADLabel.ForeColor = System.Drawing.Color.White
        PRECIO_x_UNIDADLabel.Location = New System.Drawing.Point(59, 32)
        PRECIO_x_UNIDADLabel.Name = "PRECIO_x_UNIDADLabel"
        PRECIO_x_UNIDADLabel.Size = New System.Drawing.Size(103, 13)
        PRECIO_x_UNIDADLabel.TabIndex = 45
        PRECIO_x_UNIDADLabel.Text = "PRECIO x UNIDAD:"
        '
        'PRECIO_x_MAYOREOLabel
        '
        PRECIO_x_MAYOREOLabel.AutoSize = True
        PRECIO_x_MAYOREOLabel.ForeColor = System.Drawing.Color.White
        PRECIO_x_MAYOREOLabel.Location = New System.Drawing.Point(47, 55)
        PRECIO_x_MAYOREOLabel.Name = "PRECIO_x_MAYOREOLabel"
        PRECIO_x_MAYOREOLabel.Size = New System.Drawing.Size(115, 13)
        PRECIO_x_MAYOREOLabel.TabIndex = 46
        PRECIO_x_MAYOREOLabel.Text = "PRECIO x MAYOREO:"
        '
        'PRODUCTOS_EN_EXISTENCIALabel
        '
        PRODUCTOS_EN_EXISTENCIALabel.AutoSize = True
        PRODUCTOS_EN_EXISTENCIALabel.ForeColor = System.Drawing.Color.White
        PRODUCTOS_EN_EXISTENCIALabel.Location = New System.Drawing.Point(0, 81)
        PRODUCTOS_EN_EXISTENCIALabel.Name = "PRODUCTOS_EN_EXISTENCIALabel"
        PRODUCTOS_EN_EXISTENCIALabel.Size = New System.Drawing.Size(162, 13)
        PRODUCTOS_EN_EXISTENCIALabel.TabIndex = 47
        PRODUCTOS_EN_EXISTENCIALabel.Text = "PRODUCTOS EN EXISTENCIA:"
        '
        'IdProveedorLabel
        '
        IdProveedorLabel.AutoSize = True
        IdProveedorLabel.ForeColor = System.Drawing.Color.White
        IdProveedorLabel.Location = New System.Drawing.Point(91, 142)
        IdProveedorLabel.Name = "IdProveedorLabel"
        IdProveedorLabel.Size = New System.Drawing.Size(71, 13)
        IdProveedorLabel.TabIndex = 48
        IdProveedorLabel.Text = "Id Proveedor:"
        '
        'IdProductoLabel
        '
        IdProductoLabel.AutoSize = True
        IdProductoLabel.ForeColor = System.Drawing.Color.White
        IdProductoLabel.Location = New System.Drawing.Point(97, 112)
        IdProductoLabel.Name = "IdProductoLabel"
        IdProductoLabel.Size = New System.Drawing.Size(65, 13)
        IdProductoLabel.TabIndex = 49
        IdProductoLabel.Text = "Id Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 33)
        Me.Panel1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALTAS PRODUCTOS"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(3, 42)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(237, 42)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "MODIFICAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(74, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PRODUCTOSDataGridView
        '
        Me.PRODUCTOSDataGridView.AutoGenerateColumns = False
        Me.PRODUCTOSDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PRODUCTOSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PRODUCTOSDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRODUCTOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PRODUCTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PRODUCTOSDataGridView.DataSource = Me.PRODUCTOSBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PRODUCTOSDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.PRODUCTOSDataGridView.EnableHeadersVisualStyles = False
        Me.PRODUCTOSDataGridView.Location = New System.Drawing.Point(359, 97)
        Me.PRODUCTOSDataGridView.Name = "PRODUCTOSDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRODUCTOSDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.PRODUCTOSDataGridView.Size = New System.Drawing.Size(542, 391)
        Me.PRODUCTOSDataGridView.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE DEL PRODUCTO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE DEL PRODUCTO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PRECIO x UNIDAD"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PRECIO x UNIDAD"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRECIO x MAYOREO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRECIO x MAYOREO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PRODUCTOS EN EXISTENCIA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRODUCTOS EN EXISTENCIA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdProveedor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdProveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdProducto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.Base_DatosfinalDataSet
        '
        'Base_DatosfinalDataSet
        '
        Me.Base_DatosfinalDataSet.DataSetName = "Base_DatosfinalDataSet"
        Me.Base_DatosfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NOMBRE_DEL_PRODUCTOTextBox
        '
        Me.NOMBRE_DEL_PRODUCTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "NOMBRE DEL PRODUCTO", True))
        Me.NOMBRE_DEL_PRODUCTOTextBox.Location = New System.Drawing.Point(170, 3)
        Me.NOMBRE_DEL_PRODUCTOTextBox.Name = "NOMBRE_DEL_PRODUCTOTextBox"
        Me.NOMBRE_DEL_PRODUCTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRE_DEL_PRODUCTOTextBox.TabIndex = 45
        '
        'PRECIO_x_UNIDADTextBox
        '
        Me.PRECIO_x_UNIDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "PRECIO x UNIDAD", True))
        Me.PRECIO_x_UNIDADTextBox.Location = New System.Drawing.Point(170, 29)
        Me.PRECIO_x_UNIDADTextBox.Name = "PRECIO_x_UNIDADTextBox"
        Me.PRECIO_x_UNIDADTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRECIO_x_UNIDADTextBox.TabIndex = 46
        '
        'PRECIO_x_MAYOREOTextBox
        '
        Me.PRECIO_x_MAYOREOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "PRECIO x MAYOREO", True))
        Me.PRECIO_x_MAYOREOTextBox.Location = New System.Drawing.Point(170, 55)
        Me.PRECIO_x_MAYOREOTextBox.Name = "PRECIO_x_MAYOREOTextBox"
        Me.PRECIO_x_MAYOREOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRECIO_x_MAYOREOTextBox.TabIndex = 47
        '
        'PRODUCTOS_EN_EXISTENCIATextBox
        '
        Me.PRODUCTOS_EN_EXISTENCIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "PRODUCTOS EN EXISTENCIA", True))
        Me.PRODUCTOS_EN_EXISTENCIATextBox.Location = New System.Drawing.Point(170, 78)
        Me.PRODUCTOS_EN_EXISTENCIATextBox.Name = "PRODUCTOS_EN_EXISTENCIATextBox"
        Me.PRODUCTOS_EN_EXISTENCIATextBox.Size = New System.Drawing.Size(100, 20)
        Me.PRODUCTOS_EN_EXISTENCIATextBox.TabIndex = 48
        '
        'IdProveedorTextBox
        '
        Me.IdProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "IdProveedor", True))
        Me.IdProveedorTextBox.Location = New System.Drawing.Point(170, 137)
        Me.IdProveedorTextBox.Name = "IdProveedorTextBox"
        Me.IdProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdProveedorTextBox.TabIndex = 49
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "IdProducto", True))
        Me.IdProductoTextBox.Location = New System.Drawing.Point(170, 109)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdProductoTextBox.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(276, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 20)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(122, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 23)
        Me.Button5.TabIndex = 52
        Me.Button5.Text = "REORGANIZAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(IdProveedorLabel)
        Me.Panel2.Controls.Add(IdProductoLabel)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PRODUCTOS_EN_EXISTENCIATextBox)
        Me.Panel2.Controls.Add(PRODUCTOS_EN_EXISTENCIALabel)
        Me.Panel2.Controls.Add(PRECIO_x_MAYOREOLabel)
        Me.Panel2.Controls.Add(PRECIO_x_UNIDADLabel)
        Me.Panel2.Controls.Add(Me.PRECIO_x_MAYOREOTextBox)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(NOMBRE_DEL_PRODUCTOLabel)
        Me.Panel2.Controls.Add(Me.IdProductoTextBox)
        Me.Panel2.Controls.Add(Me.IdProveedorTextBox)
        Me.Panel2.Controls.Add(Me.PRECIO_x_UNIDADTextBox)
        Me.Panel2.Controls.Add(Me.NOMBRE_DEL_PRODUCTOTextBox)
        Me.Panel2.Location = New System.Drawing.Point(0, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 409)
        Me.Panel2.TabIndex = 53
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(122, 91)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 23)
        Me.Button6.TabIndex = 54
        Me.Button6.Text = "LIMPIAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Me.PRODUCTOSTableAdapter
        Me.TableAdapterManager.PROVEEDORESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 22)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "MANTENIMIENTO PRODUCTOS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Location = New System.Drawing.Point(0, 228)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(337, 146)
        Me.Panel4.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(512, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 24)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "LISTADO PRODUCTOS"
        '
        'ALTASPRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 518)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PRODUCTOSDataGridView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ALTASPRODUCTOS"
        Me.Text = "ALTASPRODUCTOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Base_DatosfinalDataSet As Base_DatosfinalDataSet
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As Base_DatosfinalDataSetTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents TableAdapterManager As Base_DatosfinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRODUCTOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_DEL_PRODUCTOTextBox As TextBox
    Friend WithEvents PRECIO_x_UNIDADTextBox As TextBox
    Friend WithEvents PRECIO_x_MAYOREOTextBox As TextBox
    Friend WithEvents PRODUCTOS_EN_EXISTENCIATextBox As TextBox
    Friend WithEvents IdProveedorTextBox As TextBox
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
End Class
