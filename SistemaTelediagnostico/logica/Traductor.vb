Imports System.Windows.Forms

Public Class Traductor
    Public Shared Property idiomas As String = ""

    Public Enum Idioma
        ' de momento se implementa con dos idiomas
        ESPAÑOL
        INGLES
    End Enum

    Public Shared idiomaActual As String = Idioma.ESPAÑOL   ' por defecto será español

    Public Shared Function Traducir(clave As String) As String
        Dim traduccion As String = ""

        Select Case idiomas
            Case "Español"
                traduccion = My.Resources.Español.ResourceManager.GetString(clave)

            Case "English"
                traduccion = My.Resources.Ingles.ResourceManager.GetString(clave)
        End Select
        If traduccion = Nothing Then
            traduccion = clave
        End If

        Return traduccion
    End Function
    Public Shared Sub TraducirForm(formulario As Form)

        For Each control As Control In formulario.Controls
            If TypeOf control Is Label Then
                Dim label As Label = DirectCast(control, Label)
                label.Text = Traducir(label.Text)
            End If
            If TypeOf control Is Button Then
                Dim Btn As Button = DirectCast(control, Button)
                Btn.Text = Traducir(Btn.Text)
            End If
            If TypeOf control Is CheckBox Then
                Dim chk As CheckBox = DirectCast(control, CheckBox)
                chk.Text = Traducir(chk.Text)
            End If
            If TypeOf control Is TextBox Then
                Dim txt As TextBox = DirectCast(control, TextBox)
                txt.Text = Traducir(txt.Text)
            End If

        Next
    End Sub
    Public Shared Sub TraducirPanel(formulario As Panel)

        For Each control As Control In formulario.Controls
            If TypeOf control Is Label Then
                Dim label As Label = DirectCast(control, Label)
                label.Text = Traducir(label.Text)
            End If
            If TypeOf control Is Button Then
                Dim Btn As Button = DirectCast(control, Button)
                Btn.Text = Traducir(Btn.Text)
            End If
            If TypeOf control Is CheckBox Then
                Dim chk As CheckBox = DirectCast(control, CheckBox)
                chk.Text = Traducir(chk.Text)
            End If
            If TypeOf control Is TextBox Then
                Dim txt As TextBox = DirectCast(control, TextBox)
                txt.Text = Traducir(txt.Text)
            End If

        Next
    End Sub
End Class

