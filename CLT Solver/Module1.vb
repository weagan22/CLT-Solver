Module Module1

    Dim materialList() As Material
    Dim plyList() As Ply

    Dim totalThickness As Double = 0

    Dim LamABDMatrix(5, 5) As Double
    Dim LamABDMatrixInverted(5, 5) As Double
    Dim loadingMatrix() As Double

    Dim runThermal As Boolean = False
    Dim deltaT As Double = 0
    Dim thermalResultants(5) As Double

    Dim runMoisture As Boolean = False
    Dim deltaM As Double = 0
    Dim moistureResultants(5) As Double

    Dim totalLoadingMatrix() As Double

    Dim lamStrainCurveCalculated() As Double


    Sub Main()

        'Create materials list update
        ReDim materialList(1)
        materialList(0) = New Material("test0", 0.12, 141, 10, 0.25, 0.114)
        materialList(1) = New Material("AS4/3502 Carbon/Epoxy (MIL-HDBK-17)", 0.12, 19300000.0, 1350000.0, 0.34, 543000.0, -0.0000005, 0.000015, 0, 0.4)

        Dim materialXML As New System.Xml.Serialization.XmlSerializer(GetType(Material()))
        Dim writeFile As New System.IO.StreamWriter("Materials.xml") '"C:\Users\Will Eagan\Desktop\New Text Document.xml")
        materialXML.Serialize(writeFile, materialList)
        writeFile.Close()

        Dim readfile As New System.IO.StreamReader("Materials.xml") '"C:\Users\Will Eagan\Desktop\New Text Document.xml")
        materialList = CType(materialXML.Deserialize(readfile), Material())

        For i = 0 To UBound(materialList)
            materialList(i).calculateQmatrix()
        Next


        'Create ply stackup
        ReDim plyList(5)
        For i = 0 To 5
            plyList(i) = New Ply(45, 1, True)
        Next




        'Calculate ABD for each ply
        For i = 0 To 5
            plyList(i).qBarCalculate(materialList(plyList(i).materialID))
        Next

        Call plyMidplaneOffset(plyList, materialList)

        For i = 0 To UBound(plyList)
            plyList(i).ABDCalculate()
        Next


        'Calculate laminate ABD matrix
        For i = 0 To UBound(plyList)
            LamABDMatrix = MatrixOps.matrixAdd(plyList(i).ABDMatrix, LamABDMatrix)
        Next

        LamABDMatrixInverted = MatrixOps.matrix_Inverse(LamABDMatrix)



        'Create loading matrix
        ReDim loadingMatrix(5)
        loadingMatrix(4) = 565


        ReDim totalLoadingMatrix(5)
        totalLoadingMatrix = loadingMatrix


        'Calculate thermal loading
        If runThermal = True Then
            For i = 0 To UBound(plyList)
                thermalResultants = MatrixOps.matrixAddSingle(plyList(i).calculateThermal(deltaT, materialList(plyList(i).materialID), True), thermalResultants)
            Next
            totalLoadingMatrix = MatrixOps.matrixAddSingle(thermalResultants, totalLoadingMatrix)
        End If


        'Calculate moisture loading
        If runMoisture = True Then
            For i = 0 To UBound(plyList)
                moistureResultants = MatrixOps.matrixAddSingle(plyList(i).calculateMoisture(deltaT, materialList(plyList(i).materialID), True), moistureResultants)
            Next
            totalLoadingMatrix = MatrixOps.matrixAddSingle(moistureResultants, totalLoadingMatrix)
        End If

        'Calculate Strain and curvature for the whole laminate
        lamStrainCurveCalculated = MatrixOps.matrixMultSingle(LamABDMatrixInverted, totalLoadingMatrix)

        'Calculate loading and stress/strain for each ply
        Dim z As Double = 0
        For i = 0 To UBound(plyList)
            z = z + (materialList(plyList(i).materialID).Thickness / 2)
            Call plyList(i).calculatePlyStressStrain(lamStrainCurveCalculated, z)
            z = z + materialList(plyList(i).materialID).Thickness / 2
        Next

        Call outputResults()

    End Sub

    Sub outputResults()
        Dim objWriter As New System.IO.StreamWriter("C:\Users\Will Eagan\Desktop\test.txt")

        For i = 0 To UBound(materialList)
            objWriter.Write("Material " & i & " Q Matrix" & vbNewLine)
            objWriter.Write(MatrixOps.printMatrix(materialList(i).qMatrix) & "_________________________________________________________" & vbNewLine & vbNewLine)
        Next

        objWriter.Write("Laminate Loading" & vbNewLine)
        objWriter.Write(MatrixOps.printSingleMatrix(loadingMatrix) & "_________________________________________________________" & vbNewLine & vbNewLine)

        objWriter.Write("Laminate Thermal Loading" & vbNewLine)
        objWriter.Write(MatrixOps.printSingleMatrix(thermalResultants) & "_________________________________________________________" & vbNewLine & vbNewLine)

        objWriter.Write("Laminate Moisture Loading" & vbNewLine)
        objWriter.Write(MatrixOps.printSingleMatrix(moistureResultants) & "_________________________________________________________" & vbNewLine & vbNewLine)

        objWriter.Write("Laminate Total Loading" & vbNewLine)
        objWriter.Write(MatrixOps.printSingleMatrix(totalLoadingMatrix) & "_________________________________________________________" & vbNewLine & vbNewLine)

        objWriter.Write("Laminate ABD" & vbNewLine)
        objWriter.Write(MatrixOps.printMatrix(LamABDMatrix) & "_________________________________________________________" & vbNewLine & vbNewLine)

        objWriter.Write("Laminate ABDInv" & vbNewLine)
        objWriter.Write(MatrixOps.printMatrix(LamABDMatrixInverted,, True, 8) & "_________________________________________________________" & vbNewLine & vbNewLine)

        objWriter.Write("Laminate Strain-Curvature" & vbNewLine)
        objWriter.Write(MatrixOps.printSingleMatrix(lamStrainCurveCalculated) & "_________________________________________________________" & vbNewLine & vbNewLine)

        For i = 0 To UBound(plyList)
            objWriter.Write("Ply: " & i + 1 & " - QBAR" & vbNewLine)
            objWriter.Write(MatrixOps.printMatrix(plyList(i).qBarMatrix))
            objWriter.Write("Ply: " & i + 1 & " - ABD" & vbNewLine)
            objWriter.Write(MatrixOps.printMatrix(plyList(i).ABDMatrix))
            objWriter.Write("Ply: " & i + 1 & " - StressStrain" & vbNewLine)
            objWriter.Write(MatrixOps.printSingleMatrix(plyList(i).StressStrainMatrix) & "_________________________________________________________" & vbNewLine & vbNewLine)
        Next

        objWriter.Close()
    End Sub

    Sub plyMidplaneOffset(ByVal plyList() As Ply, ByRef materialList() As Material)

        For i = 0 To UBound(plyList)
            totalThickness = totalThickness + materialList(plyList(i).materialID).Thickness
        Next

        For i = 0 To UBound(plyList)
            If i = 0 Then
                plyList(i).HK0 = totalThickness / 2
            Else
                plyList(i).HK0 = plyList(i - 1).HK1
            End If
            plyList(i).HK1 = plyList(i).HK0 - materialList(plyList(i).materialID).Thickness
        Next
    End Sub

    Sub excelMatrixTest()
        'Dim excel = CreateObject("Excel.application")
        'Dim xlBook = excel.workbooks.add
        'excel.visible = True

        'Dim test = excel.cells(1, 1).value

        'Dim testMatrix(5, 5) As Double
        'For r = 0 To 5
        '    For c = 0 To 5
        '        testMatrix(r, c) = excel.cells(r + 1, c + 1).value
        '    Next
        'Next

        'Dim objWritertest As New System.IO.StreamWriter("C:\Users\Will Eagan\Desktop\test.txt")
        'objWritertest.WriteLine(MathOperations.printMatrix(MathOperations.matrix_Inverse(testMatrix)))

        'objWritertest.Close()

        'Exit Sub
    End Sub

End Module
