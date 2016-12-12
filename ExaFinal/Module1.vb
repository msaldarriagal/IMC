Module Module1

    Sub Main()
        Dim peso As Double
        Dim altura As Double
        Console.WriteLine("Ingrese su peso en Kilos : ")
        peso = Console.ReadLine()
        Console.WriteLine("Ingrese su altura en metros : ")
        altura = Console.ReadLine()
        If (peso > 0) Then
            If (altura > 0) Then
                Dim IMC As Double
                IMC = peso / (altura * altura)
                Console.WriteLine("Sub Imc es : " & IMC)
            Else
                Console.WriteLine("Valor no valido")

            End If
        Else
        Console.WriteLine(" Peso invalido")
        End If
        Console.ReadKey()
    End Sub


End Module