Imports System.Management
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Imports System.Management
        'haz la referencia a System.Management en la lengueta NET.

    End Sub

    'generate serialkey encrypted
    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        Dim letterDisk As String = Trim(cmbLetterDisk.Text)
        Try
            Dim Disco As New System.Management.ManagementObject("Win32_LogicalDisk.DeviceId='" + letterDisk + ":'")
            txtSerialDisk.Text = Disco("VolumeSerialNumber")
            If (txtSecretKey.Text <> Nothing) Then
                txtSerialKey.Text = Encrypt(Trim(txtSerialDisk.Text), Trim(txtSecretKey.Text)).ToString().ToUpper()
            End If

        Catch ex As Exception
            'MsgBox("Volumen = " & Disco("VolumeSerialNumber"))
            txtSerialKey.Clear()
            txtSerialDisk.Clear()
            MsgBox("No hay información de disco que mostrar.")
        End Try

    End Sub

    'function for encrypt plain text with secretkey
    Public Function Encrypt(ByVal plainText As String, ByVal secretKey As String) As String
        Dim encryptedPassword As String = Nothing
        Using outputStream As MemoryStream = New MemoryStream()
            Dim algorithm As RijndaelManaged = getAlgorithm(secretKey)
            Using cryptoStream As CryptoStream = New CryptoStream(outputStream, algorithm.CreateEncryptor(), CryptoStreamMode.Write)
                Dim inputBuffer() As Byte = Encoding.Unicode.GetBytes(plainText)
                cryptoStream.Write(inputBuffer, 0, inputBuffer.Length)
                cryptoStream.FlushFinalBlock()
                encryptedPassword = Convert.ToBase64String(outputStream.ToArray())
            End Using
        End Using
        Return encryptedPassword
    End Function

    'function for decrypt the encrypt text to plain text
    Public Function Decrypt(ByVal encryptedBytes As String, ByVal secretKey As String) As String
        Dim plainText As String = Nothing
        Using inputStream As MemoryStream = New MemoryStream(Convert.FromBase64String(encryptedBytes))
            Dim algorithm As RijndaelManaged = getAlgorithm(secretKey)
            Using cryptoStream As CryptoStream = New CryptoStream(inputStream, algorithm.CreateDecryptor(), CryptoStreamMode.Read)
                Dim outputBuffer(0 To CType(inputStream.Length - 1, Integer)) As Byte
                Dim readBytes As Integer = cryptoStream.Read(outputBuffer, 0, CType(inputStream.Length, Integer))
                plainText = Encoding.Unicode.GetString(outputBuffer, 0, readBytes)
            End Using
        End Using
        Return plainText
    End Function

    'algorithm of encrypt or decrypt
    Private Function getAlgorithm(ByVal secretKey As String) As RijndaelManaged
        'Const salt As String = "put your salt here"
        Const salt As String = "test"
        Const keySize As Integer = 256

        Dim keyBuilder As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(secretKey, Encoding.Unicode.GetBytes(salt))
        Dim algorithm As RijndaelManaged = New RijndaelManaged()
        algorithm.KeySize = keySize
        algorithm.IV = keyBuilder.GetBytes(CType(algorithm.BlockSize / 8, Integer))
        algorithm.Key = keyBuilder.GetBytes(CType(algorithm.KeySize / 8, Integer))
        algorithm.Padding = PaddingMode.PKCS7
        Return algorithm
    End Function

    Private Sub btnShowSecretKey_Click(sender As System.Object, e As System.EventArgs) Handles btnShowSecretKey.Click
        txtSecretKey.UseSystemPasswordChar = Not (txtSecretKey.UseSystemPasswordChar)
    End Sub
End Class
