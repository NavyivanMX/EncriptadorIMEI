<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTIMEI = New System.Windows.Forms.TextBox()
        Me.BTNGENERAR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLCODIGO = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero IMEI"
        '
        'TXTIMEI
        '
        Me.TXTIMEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIMEI.Location = New System.Drawing.Point(106, 99)
        Me.TXTIMEI.MaxLength = 100
        Me.TXTIMEI.Name = "TXTIMEI"
        Me.TXTIMEI.Size = New System.Drawing.Size(490, 38)
        Me.TXTIMEI.TabIndex = 1
        '
        'BTNGENERAR
        '
        Me.BTNGENERAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGENERAR.Location = New System.Drawing.Point(157, 189)
        Me.BTNGENERAR.Name = "BTNGENERAR"
        Me.BTNGENERAR.Size = New System.Drawing.Size(389, 107)
        Me.BTNGENERAR.TabIndex = 3
        Me.BTNGENERAR.Text = "Generar"
        Me.BTNGENERAR.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "* Respetar mayúsculas y minúsculas"
        '
        'LBLCODIGO
        '
        Me.LBLCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCODIGO.Location = New System.Drawing.Point(40, 324)
        Me.LBLCODIGO.MaxLength = 100
        Me.LBLCODIGO.Multiline = True
        Me.LBLCODIGO.Name = "LBLCODIGO"
        Me.LBLCODIGO.ReadOnly = True
        Me.LBLCODIGO.Size = New System.Drawing.Size(641, 154)
        Me.LBLCODIGO.TabIndex = 5
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EncriptadorIMEI.My.Resources.Resources.Fondo6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(709, 519)
        Me.Controls.Add(Me.LBLCODIGO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNGENERAR)
        Me.Controls.Add(Me.TXTIMEI)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Keys para App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTIMEI As TextBox
    Friend WithEvents BTNGENERAR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLCODIGO As TextBox
End Class
