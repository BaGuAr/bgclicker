Imports System
Imports System.Net

Public Class Form1

    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtaInfo As Integer)
            ' codes hidded.
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
                While True
                    'blahblah

            If (GetAsyncKeyState(key)) Then 
'blah

           'blah
            If (status) Then
                If CheckBox1.Checked Then
                                'blah( jutter spoof )
                End If
                If CheckBox2.Checked Then
                                mouse_event(&H8, 0, 0, 0, 0) 'left click down
'blah
                                mouse_event(&H10, 0, 0, 0, 0) ' left click up
                Else
                                mouse_event(&H2, 0, 0, 0, 0) ' right click down
'blah
                                mouse_event(&H4, 0, 0, 0, 0) ' right click up
                End If
                        System.Threading.Thread.Sleep(20) ' wait :3
            End If
            Application.DoEvents()
        End While
    End Sub

End Class
