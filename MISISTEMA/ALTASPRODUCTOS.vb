Public Class ALTASPRODUCTOS
    Private Sub PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PRODUCTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_DatosfinalDataSet)

    End Sub

    Private Sub ALTASPRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_DatosfinalDataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.PRODUCTOS)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PRODUCTOSTableAdapter.AGREGARPRODUCTO(NOMBRE_DEL_PRODUCTOTextBox.Text, PRECIO_x_UNIDADTextBox.Text, PRECIO_x_MAYOREOTextBox.Text, PRODUCTOS_EN_EXISTENCIATextBox.Text, IdProveedorTextBox.Text)
        Me.PRODUCTOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.PRODUCTOS)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.PRODUCTOSTableAdapter.BORRARPRODUCTO(NOMBRE_DEL_PRODUCTOTextBox.Text)
        Me.PRODUCTOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.PRODUCTOS)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.PRODUCTOSTableAdapter.UPDATEPRODUCTOS(NOMBRE_DEL_PRODUCTOTextBox.Text, PRECIO_x_UNIDADTextBox.Text, PRECIO_x_MAYOREOTextBox.Text, PRODUCTOS_EN_EXISTENCIATextBox.Text, IdProductoTextBox.Text, NOMBRE_DEL_PRODUCTOTextBox.Text)
        Me.PRODUCTOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.PRODUCTOS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PRODUCTOSTableAdapter.FillByPRODUCTOS(Base_DatosfinalDataSet.PRODUCTOS, IdProductoTextBox.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.PRODUCTOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.PRODUCTOS)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        IdProductoTextBox.Text = ""
        NOMBRE_DEL_PRODUCTOTextBox.Text = ""
        PRECIO_x_UNIDADTextBox.Text = ""
        PRECIO_x_MAYOREOTextBox.Text = ""
        PRODUCTOS_EN_EXISTENCIATextBox.Text = ""

    End Sub
End Class