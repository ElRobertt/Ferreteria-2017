Public Class ALTASEMPLEADOS
    Private Sub EMPLEADOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.EMPLEADOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Base_DatosfinalDataSet)

    End Sub

    Private Sub ALTASEMPLEADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Base_DatosfinalDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.EMPLEADOS)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.EMPLEADOSTableAdapter.AÑADIREMPLEADO(NOMBRETextBox.Text, APELLIDOSTextBox.Text, EDADTextBox.Text, NUMERO_TELEFONICOTextBox.Text, DOMICILIOTextBox.Text, HORARIOTextBox.Text, SALARIO_x_MESTextBox.Text)
        Me.EMPLEADOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.EMPLEADOS)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.EMPLEADOSTableAdapter.BORRAREMPLEADOS(NOMBRETextBox.Text)
        Me.EMPLEADOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.EMPLEADOS)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EMPLEADOSTableAdapter.UPDATEEMPLEADOS(NOMBRETextBox.Text, APELLIDOSTextBox.Text, EDADTextBox.Text, NUMERO_TELEFONICOTextBox.Text, DOMICILIOTextBox.Text, HORARIOTextBox.Text, SALARIO_x_MESTextBox.Text, NOMBRETextBox.Text)
        Me.EMPLEADOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.EMPLEADOS)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Me.EMPLEADOSTableAdapter.FillByempleados(Base_DatosfinalDataSet.EMPLEADOS, IdEmpleadoTextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EMPLEADOSTableAdapter.Fill(Me.Base_DatosfinalDataSet.EMPLEADOS)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IdEmpleadoTextBox.Text = ""
        NOMBRETextBox.Text = ""
        APELLIDOSTextBox.Text = ""
        DOMICILIOTextBox.Text = ""
        HORARIOTextBox.Text = ""
        SALARIO_x_MESTextBox.Text = ""
        EDADTextBox.Text = ""
        NUMERO_TELEFONICOTextBox.Text = ""
    End Sub
End Class