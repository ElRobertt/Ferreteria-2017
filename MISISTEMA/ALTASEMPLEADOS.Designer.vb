<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ALTASEMPLEADOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOSLabel As System.Windows.Forms.Label
        Dim EDADLabel As System.Windows.Forms.Label
        Dim NUMERO_TELEFONICOLabel As System.Windows.Forms.Label
        Dim DOMICILIOLabel As System.Windows.Forms.Label
        Dim HORARIOLabel As System.Windows.Forms.Label
        Dim SALARIO_x_MESLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTASEMPLEADOS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SALARIO_x_MESTextBox = New System.Windows.Forms.TextBox()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_DatosfinalDataSet = New MISISTEMA.Base_DatosfinalDataSet()
        Me.HORARIOTextBox = New System.Windows.Forms.TextBox()
        Me.DOMICILIOTextBox = New System.Windows.Forms.TextBox()
        Me.NUMERO_TELEFONICOTextBox = New System.Windows.Forms.TextBox()
        Me.EDADTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOSTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.EMPLEADOSTableAdapter = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.EMPLEADOSTableAdapter()
        Me.EMPLEADOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOSLabel = New System.Windows.Forms.Label()
        EDADLabel = New System.Windows.Forms.Label()
        NUMERO_TELEFONICOLabel = New System.Windows.Forms.Label()
        DOMICILIOLabel = New System.Windows.Forms.Label()
        HORARIOLabel = New System.Windows.Forms.Label()
        SALARIO_x_MESLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.ForeColor = System.Drawing.Color.White
        IdEmpleadoLabel.Location = New System.Drawing.Point(2, 6)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(69, 13)
        IdEmpleadoLabel.TabIndex = 0
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.ForeColor = System.Drawing.Color.White
        NOMBRELabel.Location = New System.Drawing.Point(14, 31)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 2
        NOMBRELabel.Text = "NOMBRE:"
        '
        'APELLIDOSLabel
        '
        APELLIDOSLabel.AutoSize = True
        APELLIDOSLabel.ForeColor = System.Drawing.Color.White
        APELLIDOSLabel.Location = New System.Drawing.Point(2, 57)
        APELLIDOSLabel.Name = "APELLIDOSLabel"
        APELLIDOSLabel.Size = New System.Drawing.Size(69, 13)
        APELLIDOSLabel.TabIndex = 4
        APELLIDOSLabel.Text = "APELLIDOS:"
        '
        'EDADLabel
        '
        EDADLabel.AutoSize = True
        EDADLabel.ForeColor = System.Drawing.Color.White
        EDADLabel.Location = New System.Drawing.Point(335, 61)
        EDADLabel.Name = "EDADLabel"
        EDADLabel.Size = New System.Drawing.Size(40, 13)
        EDADLabel.TabIndex = 6
        EDADLabel.Text = "EDAD:"
        '
        'NUMERO_TELEFONICOLabel
        '
        NUMERO_TELEFONICOLabel.AutoSize = True
        NUMERO_TELEFONICOLabel.ForeColor = System.Drawing.Color.White
        NUMERO_TELEFONICOLabel.Location = New System.Drawing.Point(247, 92)
        NUMERO_TELEFONICOLabel.Name = "NUMERO_TELEFONICOLabel"
        NUMERO_TELEFONICOLabel.Size = New System.Drawing.Size(128, 13)
        NUMERO_TELEFONICOLabel.TabIndex = 8
        NUMERO_TELEFONICOLabel.Text = "NUMERO TELEFONICO:"
        '
        'DOMICILIOLabel
        '
        DOMICILIOLabel.AutoSize = True
        DOMICILIOLabel.ForeColor = System.Drawing.Color.White
        DOMICILIOLabel.Location = New System.Drawing.Point(6, 83)
        DOMICILIOLabel.Name = "DOMICILIOLabel"
        DOMICILIOLabel.Size = New System.Drawing.Size(65, 13)
        DOMICILIOLabel.TabIndex = 10
        DOMICILIOLabel.Text = "DOMICILIO:"
        '
        'HORARIOLabel
        '
        HORARIOLabel.AutoSize = True
        HORARIOLabel.ForeColor = System.Drawing.Color.White
        HORARIOLabel.Location = New System.Drawing.Point(315, 9)
        HORARIOLabel.Name = "HORARIOLabel"
        HORARIOLabel.Size = New System.Drawing.Size(60, 13)
        HORARIOLabel.TabIndex = 12
        HORARIOLabel.Text = "HORARIO:"
        '
        'SALARIO_x_MESLabel
        '
        SALARIO_x_MESLabel.AutoSize = True
        SALARIO_x_MESLabel.ForeColor = System.Drawing.Color.White
        SALARIO_x_MESLabel.Location = New System.Drawing.Point(285, 35)
        SALARIO_x_MESLabel.Name = "SALARIO_x_MESLabel"
        SALARIO_x_MESLabel.Size = New System.Drawing.Size(90, 13)
        SALARIO_x_MESLabel.TabIndex = 14
        SALARIO_x_MESLabel.Text = "SALARIO x MES:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 33)
        Me.Panel1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALTAS EMPLEADOS"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatAppearance.BorderSize = 0
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(128, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(86, 23)
        Me.btnguardar.TabIndex = 60
        Me.btnguardar.Text = "BUSCAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(517, 95)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 63
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(517, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "MODIFICAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(223, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 38)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(SALARIO_x_MESLabel)
        Me.Panel2.Controls.Add(Me.btnguardar)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.SALARIO_x_MESTextBox)
        Me.Panel2.Controls.Add(HORARIOLabel)
        Me.Panel2.Controls.Add(Me.HORARIOTextBox)
        Me.Panel2.Controls.Add(DOMICILIOLabel)
        Me.Panel2.Controls.Add(Me.DOMICILIOTextBox)
        Me.Panel2.Controls.Add(NUMERO_TELEFONICOLabel)
        Me.Panel2.Controls.Add(Me.NUMERO_TELEFONICOTextBox)
        Me.Panel2.Controls.Add(EDADLabel)
        Me.Panel2.Controls.Add(Me.EDADTextBox)
        Me.Panel2.Controls.Add(APELLIDOSLabel)
        Me.Panel2.Controls.Add(Me.APELLIDOSTextBox)
        Me.Panel2.Controls.Add(NOMBRELabel)
        Me.Panel2.Controls.Add(Me.NOMBRETextBox)
        Me.Panel2.Controls.Add(IdEmpleadoLabel)
        Me.Panel2.Controls.Add(Me.IdEmpleadoTextBox)
        Me.Panel2.Location = New System.Drawing.Point(2, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(909, 180)
        Me.Panel2.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(688, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(517, 66)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 66
        Me.Button5.Text = "LIMPIAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(517, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "RESTAURAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SALARIO_x_MESTextBox
        '
        Me.SALARIO_x_MESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "SALARIO x MES", True))
        Me.SALARIO_x_MESTextBox.Location = New System.Drawing.Point(381, 32)
        Me.SALARIO_x_MESTextBox.Name = "SALARIO_x_MESTextBox"
        Me.SALARIO_x_MESTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SALARIO_x_MESTextBox.TabIndex = 15
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.Base_DatosfinalDataSet
        '
        'Base_DatosfinalDataSet
        '
        Me.Base_DatosfinalDataSet.DataSetName = "Base_DatosfinalDataSet"
        Me.Base_DatosfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HORARIOTextBox
        '
        Me.HORARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "HORARIO", True))
        Me.HORARIOTextBox.Location = New System.Drawing.Point(381, 6)
        Me.HORARIOTextBox.Name = "HORARIOTextBox"
        Me.HORARIOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HORARIOTextBox.TabIndex = 13
        '
        'DOMICILIOTextBox
        '
        Me.DOMICILIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "DOMICILIO", True))
        Me.DOMICILIOTextBox.Location = New System.Drawing.Point(77, 80)
        Me.DOMICILIOTextBox.Name = "DOMICILIOTextBox"
        Me.DOMICILIOTextBox.Size = New System.Drawing.Size(137, 20)
        Me.DOMICILIOTextBox.TabIndex = 11
        '
        'NUMERO_TELEFONICOTextBox
        '
        Me.NUMERO_TELEFONICOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "NUMERO TELEFONICO", True))
        Me.NUMERO_TELEFONICOTextBox.Location = New System.Drawing.Point(381, 84)
        Me.NUMERO_TELEFONICOTextBox.Name = "NUMERO_TELEFONICOTextBox"
        Me.NUMERO_TELEFONICOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUMERO_TELEFONICOTextBox.TabIndex = 9
        '
        'EDADTextBox
        '
        Me.EDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "EDAD", True))
        Me.EDADTextBox.Location = New System.Drawing.Point(381, 58)
        Me.EDADTextBox.Name = "EDADTextBox"
        Me.EDADTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EDADTextBox.TabIndex = 7
        '
        'APELLIDOSTextBox
        '
        Me.APELLIDOSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "APELLIDOS", True))
        Me.APELLIDOSTextBox.Location = New System.Drawing.Point(77, 54)
        Me.APELLIDOSTextBox.Name = "APELLIDOSTextBox"
        Me.APELLIDOSTextBox.Size = New System.Drawing.Size(137, 20)
        Me.APELLIDOSTextBox.TabIndex = 5
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox.Location = New System.Drawing.Point(77, 28)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(137, 20)
        Me.NOMBRETextBox.TabIndex = 3
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(77, 3)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(45, 20)
        Me.IdEmpleadoTextBox.TabIndex = 1
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'EMPLEADOSDataGridView
        '
        Me.EMPLEADOSDataGridView.AutoGenerateColumns = False
        Me.EMPLEADOSDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.EMPLEADOSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EMPLEADOSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EMPLEADOSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.EMPLEADOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMPLEADOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EMPLEADOSDataGridView.DataSource = Me.EMPLEADOSBindingSource
        Me.EMPLEADOSDataGridView.EnableHeadersVisualStyles = False
        Me.EMPLEADOSDataGridView.Location = New System.Drawing.Point(7, 274)
        Me.EMPLEADOSDataGridView.Name = "EMPLEADOSDataGridView"
        Me.EMPLEADOSDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(140, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EMPLEADOSDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.EMPLEADOSDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.EMPLEADOSDataGridView.Size = New System.Drawing.Size(844, 182)
        Me.EMPLEADOSDataGridView.TabIndex = 65
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEmpleado"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EDAD"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EDAD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NUMERO TELEFONICO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NUMERO TELEFONICO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOMICILIO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOMICILIO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "HORARIO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "HORARIO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SALARIO x MES"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SALARIO x MES"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EMPLEADOSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.PROVEEDORESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MISISTEMA.Base_DatosfinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 33)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "MANTENIMIENTO EMPLEADOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(285, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 25)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "LISTADO EMPLEADOS"
        '
        'ALTASEMPLEADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 458)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EMPLEADOSDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ALTASEMPLEADOS"
        Me.Text = "ALTASEMPLEADOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_DatosfinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Base_DatosfinalDataSet As Base_DatosfinalDataSet
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As Base_DatosfinalDataSetTableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents TableAdapterManager As Base_DatosfinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMPLEADOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents SALARIO_x_MESTextBox As TextBox
    Friend WithEvents HORARIOTextBox As TextBox
    Friend WithEvents DOMICILIOTextBox As TextBox
    Friend WithEvents NUMERO_TELEFONICOTextBox As TextBox
    Friend WithEvents EDADTextBox As TextBox
    Friend WithEvents APELLIDOSTextBox As TextBox
    Friend WithEvents NOMBRETextBox As TextBox
    Friend WithEvents IdEmpleadoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
