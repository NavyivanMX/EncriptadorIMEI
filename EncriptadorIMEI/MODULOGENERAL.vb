Imports System.IO
Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Net
Imports System.Windows
Imports System.Net.Mime
Imports System.Drawing.Printing

Imports System.Runtime.InteropServices
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Security.Principal
Imports System.Threading

Imports Microsoft.Office.Interop
Imports System.Net.NetworkInformation
Imports System.Threading.Tasks
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Management
Imports WhatsAppApi



Module MODULOGENERAL
    Private Declare Function GetShortPathName Lib "kernel32" Alias "GetShortPathNameA" (ByVal lpszLongPath As String, ByVal lpszShortPath As String, ByVal lBuffer As Long) As Long

    Public RESPUESTAMG As String

    Public Sub EnviarMsgWA(ByVal telefono As String, ByVal mensaje As String)
        Dim ID As String = "C9ngxIR8i0+ZK77ksQKYnG5hcmNpc29faXZhbl9hdF9ob3RtYWlsX2RvdF9jb20="
        Try
            Dim url As String = "https://niceapi.net/"
            Dim solicitud As System.Net.HttpWebRequest = (CType(System.Net.WebRequest.Create(url), System.Net.HttpWebRequest))
            solicitud.Method = "POST"
            solicitud.ContentType = "application/x-www-form-urlencoded"
            solicitud.Headers.Add("X-APIId", ID)
            solicitud.Headers.Add("X-APIMobile", telefono)

            Using streamOut As New StreamWriter(solicitud.GetRequestStream())
                streamOut.Write(mensaje)
            End Using

            Using streamIn As New StreamReader(solicitud.GetResponse().GetResponseStream())
                OPMsgOK(streamIn.ReadToEnd())
            End Using
            OPMsgOK("Mensaje Enviado")
        Catch ex As Exception
            OPMsgError(ex.Message)
        End Try

    End Sub
    Public Sub OPVisualizacionForm(ByRef FRM As Windows.Forms.Form)
        Try
            FRM.BackgroundImage = frmPrincipal.BackgroundImage
            FRM.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

        Dim COLORDEFAULT As System.Drawing.Color
        'COLORDEFAULT = Color.DarkGoldenrod
        COLORDEFAULT = Color.Black
        Dim ALGO As String
        Dim TAMABOTON As Size
        TAMABOTON.Width = 80
        TAMABOTON.Height = 80
        Try
            'For Each Btn As Button In FRM.Controls
            '    If Btn.Tag = "" Then
            '        Btn.Size = TAMABOTON
            '    End If

            'Next
            For Each c As Control In FRM.Controls
                ALGO = c.Name
                Try
                    If TypeOf c Is TextBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Button Then
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.Size = TAMABOTON
                        End If
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is GroupBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                        For Each ctr As Control In c.Controls
                            Try
                                If TypeOf ctr Is Label Then
                                    ctr.BackColor = Color.Transparent
                                    If (ctr.Tag Is Nothing Or ctr.Tag <> "") Then
                                    Else
                                        ctr.ForeColor = COLORDEFAULT
                                    End If

                                End If
                                If TypeOf ctr Is CheckBox Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is RadioButton Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Label Then
                        c.BackColor = Color.Transparent
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.ForeColor = COLORDEFAULT
                        End If

                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is CheckBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is PictureBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is TabControl Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is TabPage Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub OPVisualizacionForm(ByRef FRM As Windows.Forms.Form, ByVal ColorFuente As System.Drawing.Color)
        Try
            FRM.BackgroundImage = frmPrincipal.BackgroundImage
            FRM.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception

        End Try

        Dim COLORDEFAULT As System.Drawing.Color
        'COLORDEFAULT = Color.DarkGoldenrod
        COLORDEFAULT = ColorFuente
        Dim ALGO As String
        Dim TAMABOTON As Size
        TAMABOTON.Width = 80
        TAMABOTON.Height = 80
        Try
            'For Each Btn As Button In FRM.Controls
            '    If Btn.Tag = "" Then
            '        Btn.Size = TAMABOTON
            '    End If

            'Next
            For Each c As Control In FRM.Controls
                ALGO = c.Name
                Try
                    If TypeOf c Is TextBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Button Then
                        If (c.Tag Is Nothing Or c.Tag <> "") Then
                        Else
                            c.Size = TAMABOTON
                        End If
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is GroupBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                        For Each ctr As Control In c.Controls
                            Try
                                If TypeOf ctr Is Label Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                                If TypeOf ctr Is CheckBox Then
                                    ctr.BackColor = Color.Transparent
                                    ctr.ForeColor = COLORDEFAULT
                                End If
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is RadioButton Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is Label Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is CheckBox Then
                        c.BackColor = Color.Transparent
                        c.ForeColor = COLORDEFAULT
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is PictureBox Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

                Try
                    If TypeOf c Is TabControl Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try
                Try
                    If TypeOf c Is TabPage Then
                        c.BackColor = Color.Transparent
                    End If
                Catch ex As Exception

                End Try

            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Enum MsgsOk

        Corte
        Reporte
        Informacion
        Exportacion
        Importacion
        Finalizado
        Impresion
        Guardado

    End Enum
    Public Function OPCrearArchivo(ByVal Ruta As String, ByVal Archivo As String, ByVal Texto As String) As Boolean
        Dim fs As FileStream
        Try
            If File.Exists(Ruta) Then
                fs = File.Create(Ruta & Archivo)
                fs.Close()
            Else
                Directory.CreateDirectory(Ruta)
                fs = File.Create(Ruta & Archivo)
                fs.Close()
            End If
            Dim escribir As New StreamWriter(Ruta & Archivo)
            escribir.WriteLine(Texto)
            escribir.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function OPCrearArchivo(ByVal Ruta As String, ByVal Archivo As String, ByVal ListaTexto As List(Of String)) As Boolean
        Dim fs As FileStream
        Try
            If File.Exists(Ruta) Then
                fs = File.Create(Ruta & Archivo)
                fs.Close()
            Else
                Directory.CreateDirectory(Ruta)
                fs = File.Create(Ruta & Archivo)
                fs.Close()
            End If
            Dim escribir As New StreamWriter(Ruta & Archivo)
            For Each linea As String In ListaTexto
                escribir.WriteLine(linea)
            Next
            escribir.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function OPLeerArchivo(ByVal Ruta As String, ByVal Archivo As String) As String
        Dim leer As New StreamReader(Ruta & Archivo)
        Dim reg As String
        reg = ""
        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                reg += linea
            End While
            leer.Close()
            Return reg
        Catch ex As Exception
            Return reg
        End Try
    End Function
    Public Function OPLeerArchivoLista(ByVal Ruta As String, ByVal Archivo As String) As List(Of String)
        Dim leer As New StreamReader(Ruta & Archivo)
        Dim reg As New List(Of String)
        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                reg.Add(linea)
            End While
            leer.Close()
            Return reg
        Catch ex As Exception
            Return reg
        End Try
    End Function
    Public Function OPMsgOK(ByVal Msg As MsgsOk) As Boolean

        Dim MM As String
        MM = ""
        Select Case Msg
            Case MsgsOk.Corte
                MM = "El corte se ha realizado correctamente"
            Case MsgsOk.Reporte
                MM = "El reporte se ha creado exitosamente"
            Case MsgsOk.Informacion
                MM = "La información ha sido procesada con éxito"
            Case MsgsOk.Exportacion
                MM = "La exportación ha concluido con éxito"
            Case MsgsOk.Importacion
                MM = "La importacion se ha realizado exitosamente"
            Case MsgsOk.Finalizado
                MM = "La tarea ha finalizado con éxito"
            Case MsgsOk.Impresion
                MM = "La impresión se ha realizado con éxito"
            Case MsgsOk.Guardado
                MM = "La información ha sido guardada correctamente"
        End Select
        MessageBox.Show(MM, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True

    End Function

    Public Function OPMsgOK(ByVal Msg As String) As Boolean
        MessageBox.Show(Msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True
    End Function
    Public Function OPMsgError(ByVal Msg As String) As Boolean
        MessageBox.Show(Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return True
    End Function
    Public Function OPMsgGuardadoOK() As Boolean
        MessageBox.Show("La información ha sido guardada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return True
    End Function
    Public Function OPMsgPreguntarSiNo(ByVal Pregunta As String) As Boolean
        Dim ABC As Short
        ABC = MessageBox.Show(Pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If ABC = 6 Then
            Return True
        End If
    End Function
    Public Function OPMsgPreguntarSiNo(ByVal Pregunta As String, ByVal BtnNoDefault As Boolean) As Boolean
        Dim ABC As Short
        ABC = MessageBox.Show(Pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ABC = 6 Then
            Return True
        End If
        Return False
    End Function
    Public Function BDEjecutarSql(ByVal QUERY As String, ByVal CADENA As String) As String

        RESPUESTAMG = "OK"
        Try
            Dim CONX As New SqlClient.SqlConnection(CADENA)
            CONX.Open()
            Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
            SQL.ExecuteNonQuery()
            SQL.Dispose()
            CONX.Close()
        Catch ex As Exception
            RESPUESTAMG = ex.Message.ToString
        End Try

        Return RESPUESTAMG
    End Function
    Public Function BDEjecutarSql(ByVal QUERY As String, ByVal CADENA As String, ByVal INI As DateTime, ByVal FIN As DateTime) As String
        Dim REG As String
        REG = "OK"
        Try
            Dim CONX As New SqlClient.SqlConnection(CADENA)
            CONX.Open()
            Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
            SQL.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
            SQL.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
            SQL.ExecuteNonQuery()
            SQL.Dispose()
            CONX.Close()
        Catch ex As Exception
            REG = ex.Message.ToString
        End Try

        Return REG
    End Function
    Public Function BDExtraeUnDato(ByVal QUERY As String, ByVal CADENA As String, Optional ByVal DEFAULTNULL As String = "") As String
        Dim REG As String
        REG = ""
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        If LEC.Read Then
            If LEC(0) Is DBNull.Value Then
                REG = DEFAULTNULL
            Else
                REG = LEC(0)
            End If
        End If
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Return REG
    End Function

    Public Sub LimpiarForm(ByVal Controls As System.Windows.Forms.Control.ControlCollection)
        For Each c As Control In Controls
            If Not c.Controls Is Nothing AndAlso c.Controls.Count > 0 Then
                LimpiarForm(c.Controls)
                LimpiarControles(c)
            ElseIf c.GetType().Equals(GetType(TextBox)) Or c.GetType().Equals(GetType(RichTextBox)) Or c.GetType().Equals(GetType(MaskedTextBox)) Then
                If (c.Tag > 0 And c.Tag < 4) Then
                    c.Text = ""
                Else
                    If c.TabIndex = 0 Then
                        c.Text = ""
                        c.Focus()
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub BORRATEMP()
        Try
            For Each subDirectory As String In Directory.GetDirectories("D:\Temp")
                System.IO.Directory.Delete("D:\Temp\" + subDirectory)
            Next
        Catch ex As Exception

        End Try
        Try
            For Each subDirectory As String In Directory.GetDirectories("C:\Temp")
                System.IO.Directory.Delete("C:\Temp\" + subDirectory)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Function InfoEsAdministrador() As Boolean
        Thread.GetDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        Dim currentPrincipal As WindowsPrincipal = TryCast(Thread.CurrentPrincipal, WindowsPrincipal)
        Return currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    'Converts the DataGridView to DataTable
    Public Function OPChecarListBox(ByRef CLB As CheckedListBox, ByVal V As Boolean)
        For X As Integer = 0 To CLB.Items.Count - 1
            CLB.SetItemChecked(X, V)
        Next
        Return True
    End Function

    Public Function DataGridView2DataTable(ByVal dgv As DataGridView) As DataTable

        Dim dt As New DataTable()

        ' Header columns
        For Each column As DataGridViewColumn In dgv.Columns
            Dim dc As New DataColumn(column.Name.ToString(), column.CellType)
            dt.Columns.Add(dc)
        Next

        ' Data cells
        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim row As DataGridViewRow = dgv.Rows(i)
            Dim dr As DataRow = dt.NewRow()
            For j As Integer = 0 To dgv.Columns.Count - 1
                dr(j) = If((row.Cells(j).Value Is Nothing), "", row.Cells(j).Value.ToString())
            Next
            dt.Rows.Add(dr)
        Next

        ' Related to the bug arround min size when using ExcelLibrary for export
        'For i As Integer = 0 To dgv.Rows.Count - 1
        '    Dim dr As DataRow = dt.NewRow()
        '    For j As Integer = 0 To dt.Columns.Count - 1
        '        dr(j) = "  "
        '    Next
        '    dt.Rows.Add(dr)
        'Next
        Return dt
    End Function
    Public Function FECHA2TEXT(ByVal DT As DateTime) As String
        Dim DIA, MES, AÑO, REG As String

        DIA = DT.Day
        MES = DT.Month
        AÑO = DT.Year
        If DIA < 10 Then
            REG = "0" + DIA
        Else
            REG = DIA
        End If
        If MES = "1" Then
            REG = REG + " DE ENERO"
        End If
        If MES = "2" Then
            REG = REG + " DE FEBRERO"
        End If
        If MES = "3" Then
            REG = REG + " DE MARZO"
        End If
        If MES = "4" Then
            REG = REG + " DE ABRIL"
        End If
        If MES = "5" Then
            REG = REG + " DE MAYO"
        End If
        If MES = "6" Then
            REG = REG + " DE JUNIO"
        End If
        If MES = "7" Then
            REG = REG + " DE JULIO"
        End If
        If MES = "8" Then
            REG = REG + " DE AGOSTO"
        End If
        If MES = "9" Then
            REG = REG + " DE SEPTIEMBRE"
        End If
        If MES = "10" Then
            REG = REG + " DE OCTUBRE"
        End If
        If MES = "11" Then
            REG = REG + " DE NOVIEMBRE"
        End If
        If MES = "12" Then
            REG = REG + " DE DICIEMBRE"
        End If
        REG = REG + " " + AÑO
        Return REG
    End Function
    Public Function GenerateGUID() As String
        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()
        Return sGUID
    End Function
    Public Function FORMATOCADENA(ByVal TEXTO As String, ByVal LONGITUD As Integer) As String
        Dim REG As String
        REG = TEXTO
        If TEXTO.Length > LONGITUD Then
            REG = TEXTO.Remove(LONGITUD, TEXTO.Length - LONGITUD)
        End If
        If TEXTO.Length < LONGITUD Then
            Dim X As Integer
            For X = TEXTO.Length To LONGITUD
                REG = REG.Insert(X, " ")
            Next
        End If
        Return REG
    End Function
    Public Function DgvCellFormatoNumerico() As DataGridViewCellStyle
        Dim CS As New DataGridViewCellStyle
        CS.Alignment = DataGridViewContentAlignment.MiddleRight
        CS.Format = "###,###,###,##0.00"
        Return CS
    End Function
    Public Function DgvCellFormatoNumerico(ByVal NumeroDecimales As Integer) As DataGridViewCellStyle
        Dim CS As New DataGridViewCellStyle
        CS.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim TEXTO As String
        TEXTO = "###,###,###,##0."
        Dim X As Integer
        For X = 0 To NumeroDecimales - 1
            TEXTO = TEXTO.Insert(16 + X, "0")
        Next
        CS.Format = TEXTO
        Return CS
    End Function
    Public Function DgvCellFormatoHora() As DataGridViewCellStyle
        Dim CS As New DataGridViewCellStyle
        CS.Alignment = DataGridViewContentAlignment.MiddleRight
        CS.Format = "hh:mm:ss tt"
        Return CS
    End Function
    Public Function DgvCellFormatoFecha() As DataGridViewCellStyle
        Dim CS As New DataGridViewCellStyle
        CS.Alignment = DataGridViewContentAlignment.MiddleRight
        CS.Format = "dd/MM/yyyy"
        Return CS
    End Function
    Public Function DgvCellFormatoPct() As DataGridViewCellStyle
        Dim CS As New DataGridViewCellStyle
        CS.Alignment = DataGridViewContentAlignment.MiddleRight
        CS.Format = "###,###,###,##0.00%"
        Return CS
    End Function
    Public Function DgvCellEstilo(ByVal FONDO As Color, ByVal FUENTE As Color) As DataGridViewCellStyle
        Dim RDgvCellEstilo As New DataGridViewCellStyle
        RDgvCellEstilo.BackColor = FONDO
        RDgvCellEstilo.ForeColor = FUENTE
        Return RDgvCellEstilo
    End Function
    Public Sub LimpiarControles(ByVal c1 As Control)
        'Limpia todos los controles dentro del control principal (c1)
        'aunque esten dentro de otros controles
        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                c.Text = "" ' eliminar el texto 
            Else
                LimpiarControles(c)
            End If
            If TypeOf c Is ComboBox Then
                c.Text = "" ' eliminar el texto 
            Else
                LimpiarControles(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today ' Pone la fecha actual 
            Else
                LimpiarControles(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False 'Quita el check
            Else
                LimpiarControles(c)
            End If
            If (TypeOf (c) Is ComboBox) Then
                Try
                    CType(c, ComboBox).SelectedIndex = 0 'Pongo el primero
                Catch ex As Exception

                End Try
            Else
                LimpiarControles(c)
            End If
            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Checked = False 'Quita el check
            Else
                LimpiarControles(c)
            End If
            If (TypeOf (c) Is DataGridView) Then
                CType(c, DataGridView).DataSource = Nothing 'Quita los datos
            Else
                LimpiarControles(c)
            End If
        Next
    End Sub
    Public Function PruebaPing(ByVal DIRECCIONoIP As String, ByVal NombreComun As String, ByVal Mostrar As Boolean) As Boolean
        Try


            Dim ECO As New System.Net.NetworkInformation.Ping
            Dim RES As System.Net.NetworkInformation.PingReply
            Dim I As Integer
            Dim RESS As String
            RESS = ""
            Dim REG As Boolean
            For I = 0 To 3
                RES = ECO.Send(DIRECCIONoIP)
                If RES.Status = NetworkInformation.IPStatus.Success Then
                    RESS += "Tiempo de Respuesta desde " + NombreComun + " aproximado en milisegundos : " & RES.RoundtripTime.ToString + "." + ControlChars.NewLine
                    REG = True
                Else
                    RESS += "No se puede acceder al sitio: " + NombreComun + ". Verifique su conexión a Internet" + ControlChars.NewLine
                    REG = False
                End If
            Next
            If Mostrar Then
                MessageBox.Show(RESS + " Tiempos mayores a 250 se consideran lentos", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            Return REG
        Catch ex As Exception
            If Mostrar Then
                MessageBox.Show(ex.ToString, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            Return False
        End Try

    End Function
    Public Function OPCargaX(ByRef LISTA As List(Of String), ByRef CB As ComboBox, ByVal VALOR As String) As Boolean
        Dim X As Integer
        For X = 0 To LISTA.Count - 1
            If LISTA(X) = VALOR Then
                CB.SelectedIndex = X
                Return True
            End If
        Next
        Try
            CB.SelectedIndex = 0
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Sub OPCargaXCLB(ByRef LISTA As List(Of String), ByRef CLB As CheckedListBox, ByVal VALOR As String)
        Dim X As Integer
        For X = 0 To LISTA.Count - 1
            If LISTA(X) = VALOR Then
                CLB.SetItemChecked(X, True)
                CLB.SelectedIndex = X
                Exit Sub
            End If
        Next
    End Sub
    Public Sub EjecutarCmd(ByVal COMANDO As String, Optional TimeOut As Integer = 10000)
        Dim objEscritor As StreamWriter
        If System.IO.File.Exists("C:\ARCHIVO.BAT") = True Then
            System.IO.File.Delete("C:\ARCHIVO.BAT")
        End If
        objEscritor = File.AppendText("C:\ARCHIVO.BAT")
        objEscritor.WriteLine(COMANDO)
        objEscritor.Close()
        Shell("C:\ARCHIVO.BAT", AppWinStyle.NormalFocus, True, TimeOut)

        If System.IO.File.Exists("C:\ARCHIVO.BAT") = True Then
            System.IO.File.Delete("C:\ARCHIVO.BAT")
        End If
    End Sub
    Public Sub Ejecutar2(ByVal COMANDO As String)
        Shell(COMANDO, AppWinStyle.NormalFocus)
    End Sub
    Public Function InfoDNSLookup(ByVal domain As String) As String
        Try
            'performs the DNS lookup
            Dim he As IPHostEntry = Dns.GetHostEntry(domain)
            Dim ip_addrs As IPAddress() = he.AddressList
            For Each ip As IPAddress In ip_addrs
                Return ip.ToString()
            Next ip
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
        Return ""
    End Function
    Public Function InfoMACaddress() As String
        Dim nets As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Dim mac As String = ""
        For Each adapter As NetworkInterface In nets
            Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
            Dim address As PhysicalAddress = adapter.GetPhysicalAddress()
            Dim bytes As Byte() = address.GetAddressBytes()
            For i As Integer = 0 To bytes.Length - 1
                mac += bytes(i).ToString("X2")
                If i <> bytes.Length - 1 Then
                    mac += "-"
                End If
            Next
        Next
        'MessageBox.Show(mac, "MAC Adresses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return mac
    End Function
    Public Function InfoNombreEquipo() As String
        'MessageBox.Show(SystemInformation.ComputerName, "Nombre del Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return SystemInformation.ComputerName.ToString
    End Function
    'Public Function InfoSerieDiscoDuro() As String
    '    ':::Obtenemos la informacion del Sistema operativo
    '    LblNombreSO.Text = "Nombre del SO: " + My.Computer.Info.OSFullName
    '    LblVersionSO.Text = "Versión del SO: " + My.Computer.Info.OSVersion

    '    Dim consultaSQLArquitectura As String = "SELECT * FROM Win32_Processor"
    '    Dim objArquitectura As New ManagementObjectSearcher(consultaSQLArquitectura)
    '    Dim ArquitecturaSO As String = ""
    '    For Each info As ManagementObject In objArquitectura.Get()
    '        ArquitecturaSO = info.Properties("AddressWidth").Value.ToString()
    '    Next info
    '    LblArquitecturaSO.Text = "Arquitectura del SO: " + ArquitecturaSO + " Bits"

    '    ':::Obtenemos la informacion del Equipo
    '    LblNombreEquipo.Text = "Nombrel del Equipo: " + My.Computer.Name
    '    LblNombreUsuario.Text = "Nombre del Usuario: " + Security.Principal.WindowsIdentity.GetCurrent().Name

    '    ':::Obtenemos el serial del Disco Duro
    '    Dim serialDD As New ManagementObject("Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'")
    '    LblSerialDD.Text = "Serial Disco Duro: " + serialDD.Properties("SerialNumber").Value.ToString

    '    ':::Obtenemos el serial de la Board
    '    Dim serial As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")
    '    Dim serialBoard As String = ""
    '    For Each serialB As ManagementObject In serial.Get()
    '        serialBoard = (serialB.GetPropertyValue("SerialNumber").ToString)
    '    Next
    '    LblSerialBoard.Text = "Serial Board: " + serialBoard
    'End Function

    Public Function InfoIPEquipo() As String
        Dim REG As String
        REG = "No Asignado"
        Dim DIRECCIONES() As IPAddress = Dns.GetHostAddresses(Dns.GetHostName())
        For Each IP As IPAddress In DIRECCIONES
            'Console.WriteLine(IP.ToString())
            REG = IP.ToString
        Next
        'MessageBox.Show(REG, "Direccion Ip", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return REG
    End Function
    Public Function InfoHoraEquipo() As String
        Return Format(Now, "hh:mm:ss tt")
    End Function
    Public Function InfoFechayHoraEquipo() As String
        Return Format(Now, "DD/MM/YYYY hh:mm:ss tt")
    End Function
    Public Function InfoFechayHoraEquipo(ByVal Formato As String) As String
        Return Format(Now, Formato)
    End Function
    Public Function InfoFechaEquipo() As String
        Return Format(Now, "DD/MM/YYYY hh:mm:ss tt")
    End Function
    Public Function InfoFechaEquipo(ByVal Formato As String) As String
        Return Format(Now, Formato)
    End Function
    Public Function VerificarUbicacionArchivo(ByVal RutaArchivo As String) As Boolean
        If System.IO.File.Exists(RutaArchivo) = True Then
            Return True
        End If
        Return False
    End Function
    Public Sub ActualizarVersion(ByVal LigaArchivo As String, ByVal RutaDescargar As String, ByVal NombreArchivo As String, ByVal RutaDescomprimir As String)
        If Not InfoEsAdministrador() Then
            MessageBox.Show("Se recomienda correr el sistema modo Administrador (Click en el botón derecho, ejecutar como administrador) en caso de no funcionar correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        Try
            OPMsgOK("En este momento no cuentas con la última versión, se descargará automáticamente")

            EjecutarCmd("DEL C:\*.RAR")
            EjecutarCmd("DEL C:\*.ZIP")
            EjecutarCmd("DEL C:\NUEVAVERSION\*.exe")
            EjecutarCmd("DEL C:\NUEVAVERSION\*.dll")


            DescargaArchivo(LigaArchivo, RutaDescargar, NombreArchivo, False)
            DescomprimirArchivo(RutaDescargar, RutaDescomprimir)
            OPMsgOK("Descarga de nueva versión exitosa")
        Catch ex As Exception
            OPMsgError("Error al actualizar la nueva versión. " + ex.Message)
        End Try
    End Sub
    Private Sub OnDownloadComplete(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            OPMsgOK("Descarga exitosa")
        Else
            OPMsgError("Descarga fallida")
        End If
    End Sub
    Private Sub ShowDownloadProgress(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ' ProgressBar.Value = e.ProgressPercentage
    End Sub
    Private Function DescargaArchivoTask(ByVal Liga As String, ByVal Ubicacion As String, ByVal Nombre As String, Optional MostrarMsg As Boolean = True) As Boolean
        Dim client As New WebClient()
        AddHandler client.DownloadProgressChanged, AddressOf ShowDownloadProgress
        AddHandler client.DownloadFileCompleted, AddressOf OnDownloadComplete
        client.DownloadFileAsync(New Uri(Liga), Ubicacion)
        Return True
    End Function
    Public Function DescargaArchivo(ByVal Liga As String, ByVal Ubicacion As String, ByVal Nombre As String, Optional MostrarMsg As Boolean = True) As Boolean
        Try
            If VerificarUbicacionArchivo(Ubicacion) Then
                Try
                    System.IO.File.Delete(Ubicacion)
                Catch ex As Exception

                End Try
            End If
            My.Computer.Network.DownloadFile(Liga, Ubicacion)
            If MostrarMsg Then
                MessageBox.Show("Actualizacion " + Nombre + " Descargada Exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Archivo (" + Nombre + ") NO Encontrado para Descarga: " + Liga + ":" + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
        Return False
    End Function
    Public Function DescomprimirArchivo(ByVal RutaArchivo As String, ByVal RutaDescomprimir As String) As Boolean
        Dim WinRar As String, WinZip As String
        WinRar = ""
        WinZip = ""
        Dim MiObjeto As Object, Ret As String
        MiObjeto = CreateObject("Wscript.Shell")
        Try
            Ret = MiObjeto.RegRead("HKEY_CLASSES_ROOT\WinRAR\shell\open\command\")
            WinRar = Left(Ret, InStrRev(Ret, " "))
        Catch ex As Exception

        End Try
        Try
            Ret = MiObjeto.RegRead("HKEY_CLASSES_ROOT\WinZip\shell\open\command\")
            WinZip = Left(Ret, InStrRev(Ret, " "))
        Catch ex As Exception

        End Try

        MiObjeto = Nothing

        If WinRar = "" And WinZip = "" Then
            OPMsgError("No se encuentra instalado ni WinZip ni WinRar :(")
            Return False
        End If
        If Not VerificarUbicacionArchivo(RutaArchivo) Then
            OPMsgError("No se encontró el archivo: " + RutaArchivo)
            Return False
        Else

        End If
        If WinRar <> "" Then
            EjecutarCmd(WinRar + " e " + RutaArchivo + " " + RutaDescomprimir)
        Else
            If WinZip <> "" Then
                EjecutarCmd(WinZip + " e " + RutaArchivo + " " + RutaDescomprimir)
            End If
        End If
        Return True
    End Function
    Public Function OPLlenaListBox(ByRef LB As ListBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        LB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        LB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            LB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            LB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function OPLlena2Listas(ByRef LISTA As List(Of String), ByRef LISTA2 As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        LISTA.Clear()
        LISTA2.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            LISTA2.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public RESULTADORFC As String
    Public Function EsRFCValido(ByVal RFC As String) As Boolean
        RESULTADORFC = ""
        If PersonaFisica_RFC(RFC) AndAlso ValidarUltimaLetraRFC(RFC) AndAlso ValidarFechaRFC(RFC) Then
            Return True
        End If

        If General_RFC(RFC) AndAlso ValidarUltimaLetraRFC(RFC) AndAlso ValidarFechaRFC(RFC) Then
            Return True
        End If

        Return False
    End Function
    Private Function ValidarUltimaLetraRFC(ByVal RFC As String) As Boolean
        Try
            If RFC.EndsWith("A") OrElse RFC.EndsWith("0") OrElse RFC.EndsWith("1") OrElse RFC.EndsWith("2") OrElse RFC.EndsWith("3") OrElse RFC.EndsWith("4") OrElse RFC.EndsWith("5") OrElse RFC.EndsWith("6") OrElse RFC.EndsWith("7") OrElse RFC.EndsWith("8") OrElse RFC.EndsWith("9") Then
                Return True
            Else
                RESULTADORFC = "Formato de RFC Incorrecto, debe terminar en: A,0,1,2,3,4,5,6,7,8,9"
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine(String.Format("ExpRegulares.ValidarUltimaLetraRFC: {0}", ex.Message))
            RESULTADORFC = String.Format("ExpRegulares.PersonaFisica_RFC: {0}", ex.Message)
            Return False
        End Try
    End Function
    Private Function ValidarFechaRFC(ByVal RFC As String) As Boolean
        Dim fecha As String = String.Empty
        Dim esFecha As Boolean = False
        Dim resultado As DateTime

        fecha = RFC.Substring(RFC.Length - 9, 6)
        esFecha = DateTime.TryParseExact(fecha, "yyMMdd", Nothing, DateTimeStyles.None, resultado)
        RESULTADORFC = String.Format("FECHA INCORRECTA: " + RFC.Substring(RFC.Length - 9, 6))
        Return esFecha
    End Function
    Private Function PersonaFisica_RFC(ByVal RFC As String) As Boolean
        Try
            If RFC.Trim().Length = 13 OrElse RFC.Trim().Length = 12 Then
                Dim pattern As String = "^[A-Z&]{3,4}(\d{6})(([A-Z0-9]){3})?$"

                Dim RFCMatch As Match = Regex.Match(RFC, pattern)
                If RFC <> String.Empty Then
                    If Not RFCMatch.Success Then
                        RESULTADORFC = "Formato de RFC Incorrecto AAAA######NNN"
                        Return False
                    End If
                End If
            Else
                RESULTADORFC = "Longitud de RFC Incorrecta: (12) o (13)"
                Return False
            End If

            Return True
        Catch ex As Exception
            Console.WriteLine(String.Format("ExpRegulares.PersonaFisica_RFC: {0}", ex.Message))
            RESULTADORFC = String.Format("ExpRegulares.PersonaFisica_RFC: {0}", ex.Message)
            Return False
        End Try
    End Function
    Private Function General_RFC(ByVal RFC As String) As Boolean
        Try
            Dim pattern As String = "^([A-Z\s]{3,4})\d{6}(([A-Z\w]|[0-9]){3})$"
            Dim RFCMatch As Match = Regex.Match(RFC.Trim(), pattern)
            If RFC.Trim() <> String.Empty Then
                If Not RFCMatch.Success Then
                    RESULTADORFC = "Formato de RFC Incorrecto AAA######NNN"
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Console.WriteLine(String.Format("ExpRegulares.General_RFC: {0}", ex.Message))
            RESULTADORFC = String.Format("ExpRegulares.PersonaFisica_RFC: {0}", ex.Message)
            Return False
        End Try
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByRef LISTA2 As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        LISTA2.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            LISTA2.Add(LEC(1))
            CB.Items.Add(LEC(2))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function Encrypt(ByVal strText As String, Optional ByVal strEncrKey As String = "&%#@?,:*") As String
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Try
            Dim bykey() As Byte = System.Text.Encoding.UTF8.GetBytes(Microsoft.VisualBasic.Strings.Left(strEncrKey, 8))
            Dim InputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
            Dim des As New DESCryptoServiceProvider
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(bykey, IV), CryptoStreamMode.Write)
            cs.Write(InputByteArray, 0, InputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function Decrypt(ByVal strText As String, Optional ByVal sDecrKey As String = "&%#@?,:*") As String
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte
        Try
            Dim byKey() As Byte = System.Text.Encoding.UTF8.GetBytes(Microsoft.VisualBasic.Strings.Left(sDecrKey, 8))
            Dim des As New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
            Return encoding.GetString(ms.ToArray())
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByRef LISTA2 As List(Of String), ByRef LISTA3 As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        LISTA2.Clear()
        LISTA3.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            LISTA2.Add(LEC(1))
            LISTA3.Add(LEC(2))
            CB.Items.Add(LEC(3))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function ValidaEmail(ByVal strEmail As String) As Boolean
        If String.IsNullOrEmpty(strEmail) Then
            Return True
        End If
        ' Retorna verdadero si strEmail es un formato de E-mail valido.
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function
    Public Function CadenaVacia(ByVal texto As String) As Boolean
        If String.IsNullOrEmpty(Trim(texto)) Then
            Return True
        End If
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String, ByVal TODOSLOS As String, ByVal CLAPRIM As String) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        CB.Items.Add(TODOSLOS)
        LISTA.Add(CLAPRIM)
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function OPLlenaComboBox(ByRef CB As ComboBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String, ByVal TODOSLOS As String, ByVal CLAPRIM As String, ByVal INI As DateTime, ByVal FIN As DateTime) As Boolean
        CB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        SQL.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
        SQL.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CB.Items.Clear()
        LISTA.Clear()
        CB.Items.Add(TODOSLOS)
        LISTA.Add(CLAPRIM)
        While LEC.Read
            LISTA.Add(LEC(0))
            CB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        Try
            CB.SelectedIndex = 0
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function BDLlenatabla(ByVal QUERY As String, ByVal CADENA As String, ByVal INI As DateTime, ByVal FIN As DateTime, ByVal INI2 As DateTime, ByVal FIN2 As DateTime) As DataTable
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, CONX)
        DA.SelectCommand.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
        DA.SelectCommand.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
        DA.SelectCommand.Parameters.Add("@INI2", SqlDbType.DateTime).Value = INI2
        DA.SelectCommand.Parameters.Add("@FIN2", SqlDbType.DateTime).Value = FIN2
        DA.SelectCommand.CommandTimeout = 300
        Dim DT As New DataTable
        DA.Fill(DT)
        Return DT
    End Function
    Public Function BDLlenatabla(ByVal QUERY As String, ByVal CADENA As String) As DataTable
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, CONX)

        DA.SelectCommand.CommandTimeout = 300
        Dim DT As New DataTable
        DA.Fill(DT)
        CONX.Close()
        Return DT
    End Function
    Public Function BDLlenatabla(ByVal QUERY As String, ByVal CADENA As String, ByVal INI As DateTime, ByVal FIN As DateTime) As DataTable
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim DA As New SqlClient.SqlDataAdapter(QUERY, CONX)
        DA.SelectCommand.Parameters.Add("@INI", SqlDbType.DateTime).Value = INI
        DA.SelectCommand.Parameters.Add("@FIN", SqlDbType.DateTime).Value = FIN
        DA.SelectCommand.CommandTimeout = 600
        Dim DT As New DataTable
        DA.Fill(DT)
        Return DT
    End Function
    Public Function SetDefPrinter(ByVal sNombreImpresora As String) As Boolean
        'Parámetro especifica nombre de impresora para poner por defecto.
        'La pongo por defecto y la quito.

        Dim WshNetwork As Object
        Dim pd As New PrintDocument
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
        Try
            WshNetwork.SetDefaultPrinter(sNombreImpresora)
            pd.PrinterSettings.PrinterName = sNombreImpresora
            If pd.PrinterSettings.IsValid Then
                Return True
            Else
                WshNetwork.SetDefaultPrinter(sNombreImpresora)
                Return False
            End If
            'Catch exptd As Exception
            'WshNetwork.SetDefaultPrinter(sNombreImpresora)
            Return False
        Finally
            WshNetwork = Nothing
            pd = Nothing
        End Try
    End Function
    Private Function ImpresoraDefault() As String
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            Dim a As New PrinterSettings()
            a.PrinterName = PrinterSettings.InstalledPrinters(i).ToString()
            If a.IsDefaultPrinter Then
                Return a.PrinterName
            End If
        Next
        Return ""
    End Function
    Dim RESPUESTA As String
    Private Function ImpresoraParaSettings(ByVal NOMBREIMPRESORA As String) As String
        If NOMBREIMPRESORA = "" Then
            Return ""
        Else
            For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1 '' ciclo de todas las impresoras k tengo instalada en la pc
                Dim a As New PrinterSettings() ''' variable de propiedades de impresora
                a.PrinterName = PrinterSettings.InstalledPrinters(i).ToString() '' la propiedad de impresora PrinterName= a la impresoras instalada en la posicion i
                If a.PrinterName.ToUpper = NOMBREIMPRESORA.ToUpper Then '' si el nombre de la impresora instalada en la posicion i = a la impresora k le mando como parametro
                    Return PrinterSettings.InstalledPrinters(i).ToString() '' nombre de impresora=a la impresora instalada
                End If
            Next
            Dim TEMPNI
            Dim QUITA As Integer
            QUITA = NOMBREIMPRESORA.LastIndexOfAny("\")
            TEMPNI = NOMBREIMPRESORA.Substring(QUITA + 1)
            QUITA = NOMBREIMPRESORA.LastIndexOfAny("/")
            TEMPNI = TEMPNI.Substring(QUITA + 1)
            For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
                Dim a As New PrinterSettings()
                a.PrinterName = PrinterSettings.InstalledPrinters(i).ToString()
                If a.PrinterName.ToUpper = TEMPNI.ToUpper Then
                    Return PrinterSettings.InstalledPrinters(i).ToString()
                End If
            Next
            Return ""
        End If
    End Function
    Public Sub ENVIARMAIL(ByVal LDESTINATARIOS As List(Of String), ByVal ArchivoAdjunto As String, ByVal SUBJECT As String, ByVal BODY As String)
        Dim MSG As New MailMessage
        Dim SMTP As New SmtpClient("smtp.gmail.com", 587)
        'Dim disposition As ContentDisposition
        'disposition = ATT.ContentDisposition
        MSG.From = New MailAddress("correosadjuntos@gmail.com", "correosadjuntos@gmail.com", System.Text.Encoding.UTF8)
        Dim X As Integer
        For X = 0 To LDESTINATARIOS.Count - 1
            MSG.To.Add(LDESTINATARIOS(X))
        Next

        SMTP.Credentials = New System.Net.NetworkCredential("correosadjuntos@gmail.com", "abretesesamo")
        SMTP.Host = "smtp.gmail.com"
        SMTP.EnableSsl = True
        SMTP.Timeout = 300

        If ArchivoAdjunto = "" Then
        Else
            If System.IO.File.Exists(ArchivoAdjunto) = True Then
                Dim ATT As New Attachment(ArchivoAdjunto)
                Try
                    MSG.Attachments.Add(ATT)
                Catch ex As SmtpException
                    Exit Sub
                End Try
            End If
        End If
        MSG.Subject = SUBJECT
        MSG.SubjectEncoding = System.Text.Encoding.UTF8
        MSG.Body = BODY
        Try
            SMTP.Send(MSG)
            MessageBox.Show("Mail Enviado Con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As SmtpException
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function SUMARTIEMPOAFECHA(ByVal FECHA As DateTime, ByVal HORA As DateTime) As DateTime
        Dim DT As DateTime
        DT = FECHA.Date
        DT = DT.AddHours(HORA.Hour)
        DT = DT.AddMinutes(HORA.Minute)
        DT = DT.AddSeconds(HORA.Second)
        Return DT
    End Function
    Public Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0
        '
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Try
            System.IO.File.Delete(sTemp)
        Catch ex As Exception
            ''MessageBox.Show(ex.Message)
        End Try
        Return bytes
    End Function
    Public Function ImportarExcel(ByVal Ruta As String, ByVal NombreHoja As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Ruta + ";" + "Extended Properties=\Excel 12.0 Xml;HDR=YES;IMEX=1;TypeGuessRows=0;ImportMixedTypes=Text"
            Dim connExcel As New OleDbConnection(constr)
            Dim cmdExcel As New OleDbCommand()
            Dim oda As New OleDbDataAdapter()
            cmdExcel.Connection = connExcel
            connExcel.Open()
            cmdExcel.CommandText = "Select * from [" + NombreHoja + "]"
            oda.SelectCommand = cmdExcel
            oda.Fill(dt)
            connExcel.Close()
        Catch ex As Exception
            MessageBox.Show("Error al extraer información de Excel. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function
    Public Function ImportarExcel(ByVal Ruta As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Ruta + ";" + "Extended Properties=\Excel 12.0 Xml;HDR=YES;IMEX=1;TypeGuessRows=0;ImportMixedTypes=Text"
            Dim connExcel As OleDbConnection = New OleDbConnection(constr)
            Dim cmdExcel As OleDbCommand = New OleDbCommand()
            Dim oda As OleDbDataAdapter = New OleDbDataAdapter()
            cmdExcel.Connection = connExcel
            connExcel.Open()
            Dim dtExcelSchema As DataTable
            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim SheetName As String = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()
            connExcel.Close()
            connExcel.Open()
            cmdExcel.CommandText = "SELECT * From [" & SheetName & "]"
            oda.SelectCommand = cmdExcel
            oda.Fill(dt)
            connExcel.Close()
        Catch ex As Exception
            MessageBox.Show("Error al extraer información de Excel. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function
    Public Function ObtenerCodigoFuenteDeURL(ByVal url As String) As String
        Dim sourceCode As String = ""

        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim sr As StreamReader = New StreamReader(response.GetResponseStream())
            sourceCode = sr.ReadToEnd()
            sr.Close()
            response.Close()
            Return sourceCode
        Catch
            sourceCode = "ERROR"
        End Try

        Return sourceCode
    End Function
    Public Sub DesChecarCheckbox(ByRef FRM As Form, ByVal V As Boolean, Optional Menos As String = "")
        For Each CHK As CheckBox In FRM.Controls

            If CHK.Name.IndexOf(Menos) = -1 Then
            Else
                CHK.Checked = V
            End If
        Next
        For Each GB As GroupBox In FRM.Controls
            For Each CHK As CheckBox In GB.Controls
                If CHK.Name.IndexOf(Menos) = -1 Then
                Else
                    CHK.Checked = V
                End If
            Next
        Next
    End Sub
    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function
    Public Sub ABRIRCAJON()
        'Try
        '    Shell("c:\caja.exe", AppWinStyle.Hide)
        '    Shell("c:\caja.exe", AppWinStyle.Hide)
        'Catch ex As Exception
        '    'MessageBox.Show("Le Falta el componente Caja.EXE, favor de Comunicarse con DeIP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End Try
        'Try
        '    Shell("c:\caja.exe", AppWinStyle.Hide)
        '    Shell("c:\caja.exe", AppWinStyle.Hide)
        'Catch ex As Exception
        '    'MessageBox.Show("Le Falta el componente Caja.EXE, favor de Comunicarse con DeIP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End Try
    End Sub
    Public Function OPLlenaCLB(ByRef CLB As CheckedListBox, ByRef LISTA As List(Of String), ByVal QUERY As String, ByVal CADENA As String) As Boolean
        CLB.Items.Clear()
        LISTA.Clear()
        Dim CONX As New SqlClient.SqlConnection(CADENA)
        CONX.Open()
        Dim SQL As New SqlClient.SqlCommand(QUERY, CONX)
        SQL.CommandTimeout = 600
        Dim LEC As SqlClient.SqlDataReader
        LEC = SQL.ExecuteReader
        CLB.Items.Clear()
        LISTA.Clear()
        While LEC.Read
            LISTA.Add(LEC(0))
            CLB.Items.Add(LEC(1))
        End While
        LEC.Close()
        SQL.Dispose()
        CONX.Close()
        CONX.Dispose()
        Try
            CLB.SelectedIndex = 0
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function

    Private Function RangoExcel(ByVal COLUMNAS As Integer, ByVal RENGLON As Integer, ByVal INICIO As Boolean) As String
        If COLUMNAS > 25 Then
            COLUMNAS = 25
        End If
        If INICIO Then
            Return "A" + RENGLON.ToString
        Else
            Return NumeroAbcedario(COLUMNAS - 1) + RENGLON.ToString
        End If

        Return ""
    End Function
    Private Function NumeroAbcedario(ByVal Num As Integer) As String
        Select Case Num
            Case 1
                Return "A"
            Case 2
                Return "B"
            Case 3
                Return "C"
            Case 4
                Return "D"
            Case 5
                Return "E"
            Case 6
                Return "F"
            Case 7
                Return "G"
            Case 8
                Return "H"
            Case 9
                Return "I"
            Case 10
                Return "J"
            Case 11
                Return "K"
            Case 12
                Return "L"
            Case 13
                Return "M"
            Case 14
                Return "N"
            Case 15
                Return "O"
            Case 16
                Return "P"
            Case 17
                Return "Q"
            Case 18
                Return "R"
            Case 19
                Return "S"
            Case 20
                Return "T"
            Case 21
                Return "U"
            Case 22
                Return "V"
            Case 23
                Return "W"
            Case 24
                Return "X"
            Case 25
                Return "Y"
            Case 26
                Return "Z"
        End Select

    End Function
    Public Sub DgvAjusteEncabezado(ByRef DGV As DataGridView, Optional NombreColumna As String = "")
        For Each DC As DataGridViewColumn In DGV.Columns
            If DC.Name <> NombreColumna Then
                DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Else
                DC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    Public Sub DgvAjusteEncabezado(ByRef DGV As DataGridView, Optional NumeroColumna As Integer = -1)
        Dim NC As Integer
        NC = DGV.ColumnCount
        For X = 0 To NC - 1
            If X = NumeroColumna Then
                DGV.Columns(X).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                DGV.Columns(X).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If
        Next
    End Sub
    Public Sub DgvPosicionaUltimoRegistro(ByRef DGV As DataGridView)
        Try
            If Not DGV.RowCount <= 0 And Not DGV.ColumnCount <= 0 Then
                DGV.CurrentCell = DGV.Rows(DGV.RowCount - 1).Cells(0)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Module
