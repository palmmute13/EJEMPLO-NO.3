Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opc As String = ""
        Dim n1, n2 As Integer
        Dim Operacion As Double


        If Sumar.Checked = True Then
            opc = "Sumar"
        End If

        If Restar.Checked = True Then
            opc = "Restar"
        End If

        If Multiplicar.Checked = True Then
            opc = "Multiplicar"
        End If

        If Dividir.Checked = True Then
            opc = "Dividir"
        End If
        n1 = TbNum1.Text
        n2 = TbNum2.Text

        Select Case opc
            Case "Sumar"
                Operacion = n1 + n2
            Case "Restar"
                Operacion = n1 - n2
            Case "Multiplicar"
                Operacion = n1 * n2
            Case "Dividir"
                Operacion = n1 / n2

            Case Else
                MsgBox("NO ha seleccionado ninguna operacion")
                Exit Sub

        End Select

        MsgBox("la operacion tiene como resultado = " + Operacion.ToString)















    End Sub
End Class




