Public Class Material

    Public Property Type As String
    Public Property Thickness As Double
    Public Property EL As Double
    Public Property ET As Double
    Public Property vLT As Double
    Public Property GLT As Double
    Public Property thermal_alpha1 As Double
    Public Property thermal_alpha2 As Double
    Public Property moisture_beta1 As Double
    Public Property moisture_beta2 As Double

    Private calcQMatrix(2, 2) As Double

    Public Sub New()
    End Sub

    Public Sub New(inName As String, inThickness As Double, inEL As Double, inET As Double, in_vLT As Double, inGLT As Double, Optional in_thermal_alpha1 As Double = 0, Optional in_thermal_alpha2 As Double = 0, Optional in_moisture_beta1 As Double = 0, Optional in_moisture_beta2 As Double = 0)
        Type = inName
        Thickness = inThickness
        EL = inEL
        ET = inET
        vLT = in_vLT
        GLT = inGLT
        thermal_alpha1 = in_thermal_alpha1
        thermal_alpha2 = in_thermal_alpha2
        moisture_beta1 = in_moisture_beta1
        moisture_beta2 = in_moisture_beta2

    End Sub

    Sub calculateQmatrix()
        calcQMatrix(0, 0) = EL ^ 2 / (EL - vLT * ET) 'EL / (1 - νLT * ((ET * νLT) / EL)) '''From Western calc sheet
        calcQMatrix(0, 1) = (vLT * EL * ET) / (EL - vLT ^ 2 * ET)
        calcQMatrix(0, 2) = 0
        calcQMatrix(1, 0) = calcQMatrix(0, 1)
        calcQMatrix(1, 1) = (EL * ET) / (EL - vLT ^ 2 * ET)
        calcQMatrix(1, 2) = 0
        calcQMatrix(2, 0) = 0
        calcQMatrix(2, 1) = 0
        calcQMatrix(2, 2) = GLT
    End Sub

    Public Function qMatrix() As Double(,)
        Return calcQMatrix
    End Function
End Class
