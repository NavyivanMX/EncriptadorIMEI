Imports System.Security.Cryptography
Imports System.IO
Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNGENERAR.Click
        If TXTIMEI.Text.Length <= 10 Then
            MessageBox.Show("Longitud IMEI no válido")
        End If
        LBLCODIGO.Text = Encrypt(TXTIMEI.Text, My.Settings.Semilla)
    End Sub

    Public Shared Function Encrypt(ByVal plainText As String, ByVal password As String) As String
        If plainText Is Nothing Then
            Return Nothing
        End If

        Dim bytesToBeEncrypted = System.Text.Encoding.UTF8.GetBytes(plainText)
        Dim passwordBytes = System.Text.Encoding.UTF8.GetBytes(password)
        passwordBytes = SHA512.Create().ComputeHash(passwordBytes)
        Dim bytesEncrypted = Encrypt(bytesToBeEncrypted, passwordBytes)
        Return Convert.ToBase64String(bytesEncrypted)
    End Function

    Private Shared Function Encrypt(ByVal bytesToBeEncrypted As Byte(), ByVal passwordBytes As Byte()) As Byte()
        Dim encryptedBytes As Byte() = Nothing
        Dim saltBytes = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}

        Using ms As MemoryStream = New MemoryStream()

            Using AES As RijndaelManaged = New RijndaelManaged()
                Dim key = New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
                AES.KeySize = 256
                AES.BlockSize = 128
                AES.Key = key.GetBytes(AES.KeySize / 8)
                AES.IV = key.GetBytes(AES.BlockSize / 8)
                AES.Mode = CipherMode.CBC

                Using cs = New CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length)
                    cs.Close()
                End Using

                encryptedBytes = ms.ToArray()
            End Using
        End Using

        Return encryptedBytes
    End Function

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            Dim FSEM As New frmSemilla
            FSEM.ShowDialog()
        End If
    End Sub
End Class
