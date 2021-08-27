<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNumerosPrimos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.BtnCantidadPrimos = New System.Windows.Forms.Button()
        Me.PnlPrincipal = New System.Windows.Forms.Panel()
        Me.BtnCalcularPrimos = New System.Windows.Forms.Button()
        Me.BtnEsPrimo = New System.Windows.Forms.Button()
        Me.TxtPrimos = New System.Windows.Forms.TextBox()
        Me.LblNumero = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PnlPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(75, 3)
        Me.TxtNumero.Multiline = True
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(245, 20)
        Me.TxtNumero.TabIndex = 0
        '
        'BtnCantidadPrimos
        '
        Me.BtnCantidadPrimos.Location = New System.Drawing.Point(6, 29)
        Me.BtnCantidadPrimos.Name = "BtnCantidadPrimos"
        Me.BtnCantidadPrimos.Size = New System.Drawing.Size(119, 23)
        Me.BtnCantidadPrimos.TabIndex = 1
        Me.BtnCantidadPrimos.Text = "Calcular Cantidad"
        Me.BtnCantidadPrimos.UseVisualStyleBackColor = True
        '
        'PnlPrincipal
        '
        Me.PnlPrincipal.Controls.Add(Me.BtnCalcularPrimos)
        Me.PnlPrincipal.Controls.Add(Me.BtnEsPrimo)
        Me.PnlPrincipal.Controls.Add(Me.TxtPrimos)
        Me.PnlPrincipal.Controls.Add(Me.LblNumero)
        Me.PnlPrincipal.Controls.Add(Me.TxtNumero)
        Me.PnlPrincipal.Controls.Add(Me.BtnCantidadPrimos)
        Me.PnlPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.PnlPrincipal.Name = "PnlPrincipal"
        Me.PnlPrincipal.Size = New System.Drawing.Size(323, 377)
        Me.PnlPrincipal.TabIndex = 2
        '
        'BtnCalcularPrimos
        '
        Me.BtnCalcularPrimos.Location = New System.Drawing.Point(131, 29)
        Me.BtnCalcularPrimos.Name = "BtnCalcularPrimos"
        Me.BtnCalcularPrimos.Size = New System.Drawing.Size(104, 23)
        Me.BtnCalcularPrimos.TabIndex = 5
        Me.BtnCalcularPrimos.Text = "Calcular Primos"
        Me.BtnCalcularPrimos.UseVisualStyleBackColor = True
        '
        'BtnEsPrimo
        '
        Me.BtnEsPrimo.Location = New System.Drawing.Point(241, 29)
        Me.BtnEsPrimo.Name = "BtnEsPrimo"
        Me.BtnEsPrimo.Size = New System.Drawing.Size(79, 23)
        Me.BtnEsPrimo.TabIndex = 4
        Me.BtnEsPrimo.Text = "Es Primo"
        Me.BtnEsPrimo.UseVisualStyleBackColor = True
        '
        'TxtPrimos
        '
        Me.TxtPrimos.Location = New System.Drawing.Point(3, 58)
        Me.TxtPrimos.Multiline = True
        Me.TxtPrimos.Name = "TxtPrimos"
        Me.TxtPrimos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtPrimos.Size = New System.Drawing.Size(317, 316)
        Me.TxtPrimos.TabIndex = 3
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumero.Location = New System.Drawing.Point(3, 3)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(66, 16)
        Me.LblNumero.TabIndex = 2
        Me.LblNumero.Text = "Número:"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(257, 392)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmNumerosPrimos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 427)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PnlPrincipal)
        Me.Name = "FrmNumerosPrimos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Números Primos"
        Me.PnlPrincipal.ResumeLayout(False)
        Me.PnlPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents BtnCantidadPrimos As Button
    Friend WithEvents PnlPrincipal As Panel
    Friend WithEvents LblNumero As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtPrimos As TextBox
    Friend WithEvents BtnCalcularPrimos As Button
    Friend WithEvents BtnEsPrimo As Button
End Class
