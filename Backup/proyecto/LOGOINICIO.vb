Public Class LOGOINICIO
    Public time As Integer = 10

    Private Sub LOGOINICIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim var As Form
        var = Me
        var.Size = New Size(533, 214)
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        TIMERINICIO.Start()
    End Sub

   
    Private Sub TIMERINICIO_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIMERINICIO.Tick
        If (TIMERINICIO.Interval = 1000) Then
            Ingreso.Show()
            Me.Close()
        End If
    End Sub
End Class