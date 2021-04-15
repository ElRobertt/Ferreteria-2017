Public Class ALTASCLIENTES
    Private Sub CLIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_DatosfinalDataSet)

    End Sub

    Private Sub ALTASCLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_DatosfinalDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me.Base_DatosfinalDataSet.CLIENTES)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.CLIENTESTableAdapter.AÑADIR(IdClienteTextBox.Text, NOMBRETextBox.Text, APELLIDOSTextBox.Text, CALLETextBox.Text, COLONIATextBox.Text, NUMERO_RESIDENCIALTextBox.Text, CODIGO_POSTALTextBox.Text, EDADTextBox.Text, NUMERO_TELEFONICOTextBox.Text)
        Me.CLIENTESTableAdapter.Fill(Me.Base_DatosfinalDataSet.CLIENTES)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.CLIENTESTableAdapter.UPDATENEW(IdClienteTextBox.Text, NOMBRETextBox.Text, APELLIDOSTextBox.Text, CALLETextBox.Text, COLONIATextBox.Text, NUMERO_RESIDENCIALTextBox.Text, CODIGO_POSTALTextBox.Text, EDADTextBox.Text, NUMERO_TELEFONICOTextBox.Text, IdClienteTextBox.Text)
        Me.CLIENTESTableAdapter.Fill(Me.Base_DatosfinalDataSet.CLIENTES)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.CLIENTESTableAdapter.BORRAR(IdClienteTextBox.Text)
        Me.CLIENTESTableAdapter.Fill(Me.Base_DatosfinalDataSet.CLIENTES)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CLIENTESTableAdapter.FillBy(Base_DatosfinalDataSet.CLIENTES, IdClienteTextBox.Text)
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.CLIENTESTableAdapter.Fill(Me.Base_DatosfinalDataSet.CLIENTES)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IdClienteTextBox.Text = ""
        NOMBRETextBox.Text = ""
        APELLIDOSTextBox.Text = ""
        CALLETextBox.Text = ""
        COLONIATextBox.Text = ""
        NUMERO_RESIDENCIALTextBox.Text = ""
        CODIGO_POSTALTextBox.Text = ""
        EDADTextBox.Text = ""
        NUMERO_TELEFONICOTextBox.Text = ""
    End Sub
End Class