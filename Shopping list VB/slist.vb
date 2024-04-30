
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks

Namespace Shopping_list
    Friend Class slist
        Private _number As Integer
        Private _buys As String

        Public Property Number() As Integer
            Get
                Return _number
            End Get
            Set(ByVal value As Integer)
                _number = value
            End Set
        End Property

        Public Property Buys() As String
            Get
                Return _buys
            End Get
            Set(ByVal value As String)
                _buys = value
            End Set
        End Property

        Public Sub New(ByVal _number As Integer, ByVal _buys As String)
            Number = _number
            Buys = _buys
        End Sub

        Public Overrides Function ToString() As String
            Return Convert.ToString(Number) & " - " & Buys
        End Function
    End Class
End Namespace
