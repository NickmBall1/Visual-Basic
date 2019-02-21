Public Class Betobj
    Public amount As Integer
    Public placedbet As String
    Public Overrides Function tostring() As String
        Return "$" & amount & " on " & placedbet
    End Function
End Class
