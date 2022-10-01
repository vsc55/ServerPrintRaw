Namespace CerebelumLib.MySettings
    Public Class StoreSetting

        Private _Name As String
        Public Property Name As String
            Get
                Return _Name
            End Get
            Set(value As String)
                _Name = value
            End Set
        End Property

        Private _value As Object
        Public Property Value As Object
            Get
                Return _value
            End Get
            Set(value As Object)
                _value = value
            End Set
        End Property

        Private _TypeValue As Type
        Public Property TypeValue As Type
            Get
                Return _TypeValue
            End Get
            Set(value As Type)
                _TypeValue = value
            End Set
        End Property

        Private _TypeValueStr As String
        Public Property TypeValueStr As String
            Get
                Return _TypeValueStr
            End Get
            Set(value As String)
                _TypeValueStr = value
            End Set
        End Property

        Public Class Collectionss
            Public Property column As StoreSetting()
        End Class

    End Class
End Namespace