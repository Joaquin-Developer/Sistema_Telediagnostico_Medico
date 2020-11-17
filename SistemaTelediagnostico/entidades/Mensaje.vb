Public Class Mensaje

    Public Property idMensaje As Integer
    Public Property usuarioEmisor As Usuario   ' usuario que lo envia (en la tabla mensaje en Bd se guarda su id)
    Public Property textoMensaje As String     ' contenido del mensaje
    Public Property fecha_Hora_mensaje As Date
    'Public Property hora As New Date

    Public Sub New()
    End Sub

    Public Sub New(idMensaje As Integer, usuarioEmisor As Usuario, textoMensaje As String, fecha_Hora_mensaje As Date)
        Me.idMensaje = idMensaje
        Me.usuarioEmisor = usuarioEmisor
        Me.textoMensaje = textoMensaje
        Me.fecha_Hora_mensaje = fecha_Hora_mensaje
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
