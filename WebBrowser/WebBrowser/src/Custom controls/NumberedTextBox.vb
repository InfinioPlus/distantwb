' Copyright 2011 Jorge Alberto Gomez Lopez
' based on C# code of
' http://www.codeproject.com/KB/edit/numberedtextbox.aspx

Public Class NumberedTextBox
    ' cuando la fuente de letra cambie, cambiamos la fuente de los numeros
    ' NOTA: feature aun no activado hasta la siguiente version
    Private Sub rtb_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.FontChanged
        change_labels()
    End Sub

    ' si detectamos que el usuario presiona enter, creamos un nuevo
    ' actualizamos los numeros de linea
    Private Sub rtb_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtb.KeyUp
        If e.KeyCode = Keys.Enter Then
            change_labels()
        End If
    End Sub

    ' cuando el tamaño de letra cambie, actualizamos los numeros de linea
    ' NOTA: feature aun no activado hasta la siguiente version
    Private Sub rtb_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.SizeChanged
        change_labels()
    End Sub

    ' cuando detecte cambios en el vertical scroll...
    Private Sub rtb_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.VScroll
        ' obtenemos la posicion del primer caracter visible
        Dim pos As Integer = rtb.GetPositionFromCharIndex(0).Y Mod (rtb.Font.Height + 1)
        ' ahora cambiamos el lugar en donde apunta el label
        lblNumbers3.Location = New Point(0, pos)
        ' actualizamos
        change_labels()
    End Sub

    ' funcion que cambia los numeros de linea
    Private Sub change_labels()
        ' para ubicar lo que se encuentra en el richtextbox, nada mas
        ' hay que imaginarlo como el IV cuadrante de un plano cartesiano
        Dim pointer As New Point(0, 0)
        ' averiguamos cuantos caracteres hay hasta la posicion especificada
        ' (0,0)
        Dim firstCharIndex As Integer = rtb.GetCharIndexFromPosition(pointer)
        ' ya averiguamos cuantos caracteres hay, asi que averiguamos
        ' en que linea se encuentra el ultimo caracter
        ' (el valor obtenido en firstCharIndex, tomamos que la posicion del ultimo caracter
        ' encontrado es el valor que posee firstCharIndex
        Dim firstLine As Integer = rtb.GetLineFromCharIndex(firstCharIndex)
        ' ahora tomamos las medidas actuales del richtextbox
        pointer.X = ClientRectangle.Width
        pointer.Y = ClientRectangle.Height
        ' ya que al hacer esto obtenemos las coordenadas (x,y) del vertice de la esquina inferior
        ' derecha, encontramos el numero de posicion del ultimo caracter
        Dim lastCharIndex As Integer = rtb.GetCharIndexFromPosition(pointer)
        ' obtenemos el numero de linea tomando el valor obtenido anteriormente
        Dim lastLine As Integer = rtb.GetLineFromCharIndex(lastCharIndex)
        ' limpiamos los numeros que ya estaban
        lblNumbers3.Text = ""
        ' ahora que ya encontramos el numero de linea visible del
        ' principio hasta el fin, simplemente hacemos un loop
        For i As Integer = firstLine To lastLine
            lblNumbers3.Text += "" & i + 1 & System.Environment.NewLine
        Next
        lblNumbers3.Text += "" & lastLine + 2 & System.Environment.NewLine
    End Sub

    ' funcion externa que sirve para obtener el texto actual del richtextbox
    Public Function get_text() As String
        Return rtb.Text
    End Function

    ' funcion que hace un set al texto del richtextbox
    Public Sub set_text(ByVal text As String)
        rtb.Text = text
    End Sub
End Class
