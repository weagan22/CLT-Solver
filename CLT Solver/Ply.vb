﻿Public Class Ply

    Private qBarMatrixCalulated(2, 2) As Double
    Private ABDMatrixCalculated(5, 5) As Double
    Private stressStrainCalculated(5) As Double
    Private thermalResultants(5) As Double
    Private moistureResultants(5) As Double

    Property degAngle As Integer
    Property radAngle As Double
    Property materialID As Integer
    Property HK0 As Double
    Property HK1 As Double
    Property alphaXX As Double
    Property alphaYY As Double
    Property alphaXY As Double
    Property betaXX As Double
    Property betaYY As Double
    Property betaXY As Double

    Public Sub New(InitAngle As Double, InitMaterialID As Integer, Optional angleToRad As Boolean = True)

        If angleToRad = True Then
            degAngle = Int(InitAngle)
            radAngle = MatrixOps.radians(Int(InitAngle))
        Else
            radAngle = InitAngle
            degAngle = MatrixOps.degrees(InitAngle)
        End If

        materialID = InitMaterialID
    End Sub

    Sub qBarCalculate(material As Material)
        Dim qMatrix(,) As Double = material.qMatrix

        qBarMatrixCalulated(0, 0) = qMatrix(0, 0) * Math.Cos(radAngle) ^ 4 + 2 * (qMatrix(0, 1) + 2 * qMatrix(2, 2)) * Math.Cos(radAngle) ^ 2 * Math.Sin(radAngle) ^ 2 + qMatrix(1, 1) * Math.Sin(radAngle) ^ 4
        qBarMatrixCalulated(0, 1) = qMatrix(0, 1) * (Math.Cos(radAngle) ^ 4 + Math.Sin(radAngle) ^ 4) + (qMatrix(0, 0) + qMatrix(1, 1) - 4 * qMatrix(2, 2)) * Math.Cos(radAngle) ^ 2 * Math.Sin(radAngle) ^ 2
        qBarMatrixCalulated(0, 2) = (qMatrix(0, 0) - qMatrix(0, 1) - 2 * qMatrix(2, 2)) * Math.Cos(radAngle) ^ 3 * Math.Sin(radAngle) - (qMatrix(1, 1) - qMatrix(0, 1) - 2 * qMatrix(2, 2)) * Math.Cos(radAngle) * Math.Sin(radAngle) ^ 3
        qBarMatrixCalulated(1, 0) = qBarMatrixCalulated(0, 1)
        qBarMatrixCalulated(1, 1) = qMatrix(0, 0) * Math.Sin(radAngle) ^ 4 + 2 * (qMatrix(0, 1) + 2 * qMatrix(2, 2)) * Math.Cos(radAngle) ^ 2 * Math.Sin(radAngle) ^ 2 + qMatrix(1, 1) * Math.Cos(radAngle) ^ 4
        qBarMatrixCalulated(1, 2) = (qMatrix(0, 0) - qMatrix(0, 1) - 2 * qMatrix(2, 2)) * Math.Cos(radAngle) * Math.Sin(radAngle) ^ 3 - (qMatrix(1, 1) - qMatrix(0, 1) - 2 * qMatrix(2, 2)) * Math.Cos(radAngle) ^ 3 * Math.Sin(radAngle)
        qBarMatrixCalulated(2, 0) = qBarMatrixCalulated(0, 2)
        qBarMatrixCalulated(2, 1) = qBarMatrixCalulated(1, 2)
        qBarMatrixCalulated(2, 2) = (qMatrix(0, 0) + qMatrix(1, 1) - 2 * qMatrix(0, 1) - 2 * qMatrix(2, 2)) * Math.Cos(radAngle) ^ 2 * Math.Sin(radAngle) ^ 2 + qMatrix(2, 2) * (Math.Cos(radAngle) ^ 4 + Math.Sin(radAngle) ^ 4)

    End Sub

    Sub ABDCalculate()
        Dim AMult As Double = HK0 - HK1
        Dim BMult As Double = 0.5 * (HK0 ^ 2 - HK1 ^ 2)
        Dim DMult As Double = (1 / 3) * (HK0 ^ 3 - HK1 ^ 3)

        Dim AMatrix(,) As Double = MatrixOps.matrixMultByConst(qBarMatrixCalulated, AMult)
        Dim BMatrix(,) As Double = MatrixOps.matrixMultByConst(qBarMatrixCalulated, BMult)
        Dim DMatrix(,) As Double = MatrixOps.matrixMultByConst(qBarMatrixCalulated, DMult)

        'Load A portion od ABD
        For r1 = 0 To 2
            For c1 = 0 To 2
                ABDMatrixCalculated(r1, c1) = AMatrix(r1, c1)
            Next
        Next

        'Load B protion of ABD
        For r1 = 3 To 5
            For c1 = 0 To 2
                ABDMatrixCalculated(r1, c1) = BMatrix(r1 - 3, c1)
            Next
        Next

        For r1 = 0 To 2
            For c1 = 3 To 5
                ABDMatrixCalculated(r1, c1) = BMatrix(r1, c1 - 3)
            Next
        Next

        'Load D portion of ABD
        For r1 = 3 To 5
            For c1 = 3 To 5
                ABDMatrixCalculated(r1, c1) = DMatrix(r1 - 3, c1 - 3)
            Next
        Next

    End Sub


    Function calculateThermal(deltaT As Double, material As Material, Optional returnMatrix As Boolean = False) As Double()
        alphaXX = material.thermal_alpha1 * Math.Cos(radAngle) ^ 2 + material.thermal_alpha2 * Math.Sin(radAngle) ^ 2
        alphaYY = material.thermal_alpha1 * Math.Sin(radAngle) ^ 2 + material.thermal_alpha2 * Math.Cos(radAngle) ^ 2
        alphaXY = 2 * Math.Cos(radAngle) * Math.Sin(radAngle) * (material.thermal_alpha1 - material.thermal_alpha2)

        thermalResultants(0) = deltaT * (qBarMatrix(0, 0) * alphaXX + qBarMatrix(0, 1) * alphaYY + qBarMatrix(0, 2) * alphaXY) * (HK0 - HK1)
        thermalResultants(1) = deltaT * (qBarMatrix(0, 1) * alphaXX + qBarMatrix(1, 1) * alphaYY + qBarMatrix(2, 1) * alphaXY) * (HK0 - HK1)
        thermalResultants(2) = deltaT * (qBarMatrix(0, 2) * alphaXX + qBarMatrix(2, 1) * alphaYY + qBarMatrix(2, 2) * alphaXY) * (HK0 - HK1)
        thermalResultants(3) = (deltaT / 2) * (qBarMatrix(0, 0) * alphaXX + qBarMatrix(0, 1) * alphaYY + qBarMatrix(0, 2) * alphaXY) * (HK0 ^ 2 - HK1 ^ 2)
        thermalResultants(4) = (deltaT / 2) * (qBarMatrix(0, 1) * alphaXX + qBarMatrix(1, 1) * alphaYY + qBarMatrix(2, 1) * alphaXY) * (HK0 ^ 2 - HK1 ^ 2)
        thermalResultants(5) = (deltaT / 2) * (qBarMatrix(0, 2) * alphaXX + qBarMatrix(2, 1) * alphaYY + qBarMatrix(2, 2) * alphaXY) * (HK0 ^ 2 - HK1 ^ 2)

        If returnMatrix = True Then Return thermalResultants
        If returnMatrix = False Then Return Nothing

    End Function

    Function calculateMoisture(deltaT As Double, material As Material, Optional returnMatrix As Boolean = False) As Double()
        betaXX = material.moisture_beta1 * Math.Cos(radAngle) ^ 2 + material.moisture_beta2 * Math.Sin(radAngle) ^ 2
        betaYY = material.moisture_beta1 * Math.Sin(radAngle) ^ 2 + material.moisture_beta2 * Math.Cos(radAngle) ^ 2
        betaXY = 2 * Math.Cos(radAngle) * Math.Sin(radAngle) * (material.moisture_beta1 - material.moisture_beta2)

        moistureResultants(0) = deltaT * (qBarMatrix(0, 0) * betaXX + qBarMatrix(0, 1) * betaYY + qBarMatrix(0, 2) * betaXY) * (HK0 - HK1)
        moistureResultants(1) = deltaT * (qBarMatrix(0, 1) * betaXX + qBarMatrix(1, 1) * betaYY + qBarMatrix(2, 1) * betaXY) * (HK0 - HK1)
        moistureResultants(2) = deltaT * (qBarMatrix(0, 2) * betaXX + qBarMatrix(2, 1) * betaYY + qBarMatrix(2, 2) * betaXY) * (HK0 - HK1)
        moistureResultants(3) = (deltaT / 2) * (qBarMatrix(0, 0) * betaXX + qBarMatrix(0, 1) * betaYY + qBarMatrix(0, 2) * betaXY) * (HK0 ^ 2 - HK1 ^ 2)
        moistureResultants(4) = (deltaT / 2) * (qBarMatrix(0, 1) * betaXX + qBarMatrix(1, 1) * betaYY + qBarMatrix(2, 1) * betaXY) * (HK0 ^ 2 - HK1 ^ 2)
        moistureResultants(5) = (deltaT / 2) * (qBarMatrix(0, 2) * betaXX + qBarMatrix(2, 1) * betaYY + qBarMatrix(2, 2) * betaXY) * (HK0 ^ 2 - HK1 ^ 2)

        If returnMatrix = True Then Return moistureResultants
        If returnMatrix = False Then Return Nothing

    End Function

    Sub calculatePlyStressStrain(inLamStrainCurveCalculated() As Double, Optional deltaT As Double = 0, Optional deltaM As Double = 0)

        Dim strainVals(2) As Double
        Dim curvatureVals(2) As Double

        strainVals(0) = inLamStrainCurveCalculated(0)
        strainVals(1) = inLamStrainCurveCalculated(1)
        strainVals(2) = inLamStrainCurveCalculated(2)
        curvatureVals(0) = inLamStrainCurveCalculated(3)
        curvatureVals(1) = inLamStrainCurveCalculated(4)
        curvatureVals(2) = inLamStrainCurveCalculated(5)

        Dim plyStrain() As Double = MatrixOps.matrixAddSingle(strainVals, MatrixOps.matrixMultByConstSingle(curvatureVals, (HK0 + HK1) / 2))

        Dim plyStrainDelta(2) As Double
        plyStrainDelta(0) = plyStrain(0) - deltaT * alphaXX - deltaM * betaXX
        plyStrainDelta(1) = plyStrain(1) - deltaT * alphaYY - deltaM * betaYY
        plyStrainDelta(2) = plyStrain(2) - deltaT * alphaXY - deltaM * betaXY

        Dim plyStress() As Double = MatrixOps.matrixMultSingle(qBarMatrixCalulated, plyStrainDelta)

        stressStrainCalculated(0) = plyStress(0)
        stressStrainCalculated(1) = plyStress(1)
        stressStrainCalculated(2) = plyStress(2)
        stressStrainCalculated(3) = plyStrain(0)
        stressStrainCalculated(4) = plyStrain(1)
        stressStrainCalculated(5) = plyStrain(2)
    End Sub

    Function qBarMatrix() As Double(,)
        Return qBarMatrixCalulated
    End Function

    Function ABDMatrix() As Double(,)
        Return ABDMatrixCalculated
    End Function

    Function StressStrainMatrix()
        Return stressStrainCalculated
    End Function



End Class
