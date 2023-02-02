Imports System

Module Program
    Class Customer
        Private ShareHolderName As String  '<---- Properties
        Private CustomerID As String
        Private PurchaseDate As Date
        Private NumberOfShares As Integer
        Private PerShareValue As Double
        Private NetValue As Double

        Public Sub New(ByVal SHN As String, ByVal CI As String, ByVal PD As Date, ByVal NOS As Integer, ByVal PSV As Double, ByVal NV As Double) '<--- Constructor
            ShareHolderName = SHN
            CustomerID = CI
            PurchaseDate = PD
            NumberOfShares = NOS
            PerShareValue = PSV
            NetValue = NV
        End Sub

        Public Function GetterSHN() As String
            Return ShareHolderName
        End Function

        Public Function GetterCI() As String
            Return CustomerID
        End Function

        Public Function GetterPD() As Date
            Return PurchaseDate
        End Function

        Public Function GetterNOS() As Integer
            Return NumberOfShares
        End Function

        Public Function GetterPSV() As Double
            Return PerShareValue
        End Function

        Public Function GetterNV() As Double
            Return NetValue
        End Function

        Public Sub SetterSHN(ByVal SHN As String)
            ShareHolderName = SHN
        End Sub

        Public Sub SetterCI(ByVal CI As String)
            CustomerID = CI
        End Sub

        Public Sub SetterPD(ByVal PD As Date)
            PurchaseDate = PD
        End Sub

        Public Sub SetterNOS(ByVal NOS As Integer)
            NumberOfShares = NOS
        End Sub

        Public Sub SetterPSV(ByVal PSV As Double)
            PerShareValue = PSV
        End Sub

        Public Sub SetterNV(ByVal NV As Double)
            NetValue = NV
        End Sub

    End Class
    Sub Main(args As String())
        Dim Transac As New Customer("X", "0001", #02/02/2023#, 11, 10.0, 21.21)  '<---- To remove the "New" error, initialise data 
        Console.WriteLine(Transac.GetterSHN())
        Console.WriteLine(Transac.GetterCI())
        Console.WriteLine(Transac.GetterPD())
        Console.WriteLine(Transac.GetterNOS())
        Console.WriteLine(Transac.GetterPSV())
        Console.WriteLine(Transac.GetterNV())
        Console.WriteLine("")
        Transac.SetterSHN("Y")
        Transac.SetterCI("2000")
        Transac.SetterPD(#3/10/2004#)
        Transac.SetterNOS(24)
        Transac.SetterPSV(30.75)
        Transac.SetterNV(12.05)
        Console.WriteLine(Transac.GetterSHN())
        Console.WriteLine(Transac.GetterCI())
        Console.WriteLine(Transac.GetterPD())
        Console.WriteLine(Transac.GetterNOS())
        Console.WriteLine(Transac.GetterPSV())
        Console.WriteLine(Transac.GetterNV())
        Console.ReadKey()
    End Sub
End Module
