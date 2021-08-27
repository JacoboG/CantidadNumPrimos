Public Class FrmNumerosPrimos
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Dim x As Double
    Dim t As Double
    Dim cc As Double
    Dim c As Double
    Dim m As Double
    Dim n As Double
    Dim aa As Double
    Dim a As Double
    Dim k As Double
    Dim pp As Double
    Dim p As Double
    Dim r As Double
    Dim suma As Double

    Dim numero As Double
    Dim b As Double
    Function Eit(x As Double) As Double
        If x <= 0 Or x - Int(x) > 0 Then
            Eit = 0
        Else
            Eit = 1
        End If
    End Function
    Function EsPrimo(numero As Double) As Boolean
        'número par
        a = (numero - 1) / 3
        'número impar
        b = (numero - 2) / 3
        '=========================
        If a = Int(a) And a = Int(a / 2) * 2 Then
            n = a '==== PRIMERA ELECCION CUANDO t ES PAR
            cc = (-1 + Math.Sqrt(1 + 3 * n)) / 3
            m = -Int(cc * (-1))
            '==== 
            suma = 0
            k = 0
            t = 0
            For j = n To n
                For i = 1 To m
                    r = Eit((4 * j - ((-1) ^ j) + ((2 * i + 1) * (-1) ^ (i + j)) + ((2 * i - 1) * (-1) ^ i) - (12 * i * i) + 5) / (12 * i + 6 - (2 * (-1) ^ i)))
                    k = r + k
                Next i
                suma = Eit(k) + suma
                k = 0
            Next j
            If suma = 0 Then
                Return True
            Else
                Return False
            End If
            '========================== 
        ElseIf b = Int(b) And b <> 2 * Int(b / 2) Then
            n = b
            '==== SEGUNDA ELECCION CUANDO t ES IMPAR 
            cc = (-1 + Math.Sqrt(1 + 3 * n)) / 3
            m = -Int(cc * (-1))
            '====
            suma = 0
            k = 0
            t = 0
            For j = n To n
                For i = 1 To m
                    r = Eit((4 * j - ((-1) ^ j) + ((2 * i + 1) * (-1) ^ (i + j)) + ((2 * i - 1) * (-1) ^ i) - (12 * i * i) + 5) / (12 * i + 6 - (2 * (-1) ^ i)))
                    k = r + k
                Next i
                suma = Eit(k) + suma
                k = 0
            Next j
            '====
            If suma = 0 Then
                Return True
            Else
                Return False
            End If
            '========================== 
            '==== EN CASO DE QUE NO CUMPLA NINGUNO
        Else
            Return False
        End If
    End Function
    Private Sub BtnCantidadPrimos_Click(sender As Object, e As EventArgs) Handles BtnCantidadPrimos.Click
        x = Val(TxtNumero.Text)
        If x > 3 Then
            aa = (2 * x + (-1) ^ x - 1) / 6
            a = Math.Round(aa, 0)
            cc = ((-1 + (Math.Sqrt(-2 + 3 * aa))) / 3)
            c = -Int(cc * (-1))
            m = c
            n = a - 1
            suma = 0
            k = 0
            t = 0
            For j = 8 To n
                For i = 1 To m
                    r = Eit((4 * j - ((-1) ^ j) + ((2 * i + 1) * (-1) ^ (i + j)) + ((2 * i - 1) * (-1) ^ i) - (12 * i * i) + 5) / (12 * i + 6 - (2 * (-1) ^ i)))
                    k = r + k
                Next i
                suma = Eit(k) + suma
                k = 0
            Next j
            pp = (2 * x + ((-1) ^ x) - 6 * suma + 5) / 6
            p = Math.Round(pp, 0)
            MsgBox("Valor de PI(x) = " & p)
        Else
            MsgBox("Debe ser un Número Mayor a 3")
        End If
    End Sub
    Private Sub BtnCalcularPrimos_Click(sender As Object, e As EventArgs) Handles BtnCalcularPrimos.Click
        x = Val(TxtNumero.Text)
        TxtPrimos.Text = ""
        If x = 2 Then
            TxtPrimos.Text = TxtPrimos.Text + "P1: 2" + vbCrLf
        ElseIf x = 3 Then
            TxtPrimos.Text = TxtPrimos.Text + "P1: 2" + vbCrLf
            TxtPrimos.Text = TxtPrimos.Text + "P2: 3" + vbCrLf
        ElseIf x > 3 Then
            aa = (2 * x + (-1) ^ x - 1) / 6
            a = Math.Round(aa, 0)
            cc = ((-1 + (Math.Sqrt(-2 + 3 * aa))) / 3)
            c = -Int(cc * (-1))
            m = c
            n = a - 1
            suma = 0
            k = 0
            t = 0
            TxtPrimos.Text = TxtPrimos.Text + "P1:" + vbTab + "2" + vbCrLf
            TxtPrimos.Text = TxtPrimos.Text + "P2:" + vbTab + "3" + vbCrLf

            Dim contador As Double
            contador = 3

            For j = 1 To n
                For i = 1 To m
                    r = Eit((4 * j - ((-1) ^ j) + ((2 * i + 1) * (-1) ^ (i + j)) + ((2 * i - 1) * (-1) ^ i) - (12 * i * i) + 5) / (12 * i + 6 - (2 * (-1) ^ i)))
                    k = r + k
                Next i
                suma = Eit(k) + suma
                If Eit(k) = 0 Then
                    t = (-(-1) ^ j + 3 + 6 * j) / 2
                    Dim result As String
                    Dim multiplicador As Double

                    If (t - 1) Mod 6 = 0 Then
                        multiplicador = (t - 1) / 6
                        result = "SI" + vbTab + " K=" + multiplicador.ToString() + " (-1)"
                    ElseIf (t + 1) Mod 6 = 0 Then
                        multiplicador = (t + 1) / 6
                        result = "SI" + vbTab + " K=" + multiplicador.ToString() + " (+1)"
                    Else
                        result = "NO"
                    End If
                    TxtPrimos.Text = TxtPrimos.Text + "P" + contador.ToString() + ":" + vbTab + t.ToString() + "" + vbTab + result + vbCrLf
                    contador = contador + 1
                End If
                k = 0
            Next j
            pp = (2 * x + ((-1) ^ x) - 6 * suma + 5) / 6
            p = Math.Round(pp, 0)
        Else
            MsgBox("Debe ser un Número Mayor a 3")
        End If
    End Sub
    Private Sub BtnEsPrimo_Click(sender As Object, e As EventArgs) Handles BtnEsPrimo.Click
        numero = Val(TxtNumero.Text)
        If numero > 1 Then
            If (numero = 2) Or (numero = 3) Or EsPrimo(numero) Then
                MsgBox("EL NÚMERO ES PRIMO")
            Else
                MsgBox("EL NÚMERO NO ES PRIMO")
            End If
        Else
            MsgBox("Debe ser un Número Mayor a 1")
        End If
    End Sub
End Class
