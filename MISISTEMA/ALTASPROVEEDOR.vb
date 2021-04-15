Public Class ALTASPROVEEDOR
    Private Sub PROVEEDORESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PROVEEDORESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_DatosfinalDataSet)

    End Sub

    Private Sub ALTASPROVEEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_DatosfinalDataSet.PROVEEDORES' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORESTableAdapter.Fill(Me.Base_DatosfinalDataSet.PROVEEDORES)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PROVEEDORESTableAdapter.INSERTARPROVEEDOR(IdProveedorTextBox.Text, Nombre_De_ContactoTextBox.Text, Nombre_De_EmpresaTextBox.Text, Numero_TelefonicoTextBox.Text, Direccion_De_La_EmpresaTextBox.Text, Correo_ElectronicoTextBox.Text)
        Me.PROVEEDORESTableAdapter.Fill(Me.Base_DatosfinalDataSet.PROVEEDORES)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Me.PROVEEDORESTableAdapter.UPDATEPROVEEDOR(Nombre_De_ContactoTextBox.Text, Nombre_De_EmpresaTextBox.Text, Numero_TelefonicoTextBox.Text, Direccion_De_La_EmpresaTextBox.Text, Correo_ElectronicoTextBox.Text, IdProductoTextBox.Text, Nombre_De_ContactoTextBox.Text)
        Me.PROVEEDORESTableAdapter.Fill(Me.Base_DatosfinalDataSet.PROVEEDORES)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.PROVEEDORESTableAdapter.BORRARPROVEEDOR(IdProveedorTextBox.Text)
        Me.PROVEEDORESTableAdapter.Fill(Me.Base_DatosfinalDataSet.PROVEEDORES)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PROVEEDORESTableAdapter.FillByPROVEEDOR(Base_DatosfinalDataSet.PROVEEDORES, IdProveedorTextBox.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.PROVEEDORESTableAdapter.Fill(Me.Base_DatosfinalDataSet.PROVEEDORES)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IdProveedorTextBox.Text = ""
        Nombre_De_ContactoTextBox.Text = ""
        Nombre_De_EmpresaTextBox.Text = ""
        Numero_TelefonicoTextBox.Text = ""
        Direccion_De_La_EmpresaTextBox.Text = ""
        Correo_ElectronicoTextBox.Text = ""
        IdProductoTextBox.Text = ""
    End Sub
End Class