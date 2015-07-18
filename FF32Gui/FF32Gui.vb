Option Explicit On
'' Option Strict On
Imports System.Drawing.Text
Imports System.Text
Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports System.Timers
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Globalization
Imports System.ComponentModel



Public Class FF32Gui



    Private clsFF3x_API As New FF3x_API.FF3x_API
    Public bytResponse() As Byte = Nothing
    Public volt As Double
    Dim S1, S2, S3, S4, S5, S6, S7, S8, S9 As Double
    Dim buffa(60), buffb(60), buffc(60), buffd(60) As Byte
    Dim adddress As Integer = -1
    Dim Count As Integer = -1
    Dim bla, blb, blc, bld As Integer
    Dim setsnum As String = "S1"
    Public waitin As Integer = 0

    Private Sub frmFF3x_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intNumOfDevices As Integer

        bla = 0
        blb = 0
        blc = 0
        bld = 0

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")

        intNumOfDevices = clsFF3x_API.GetNumOfDevices

        Control.CheckForIllegalCrossThreadCalls = False

        If intNumOfDevices = 0 Then
            Me.ErrOut.Text = "No FF3x device found"
        End If
        Me.txtAboutNumOfDevices.Text = intNumOfDevices.ToString

        ' get 1st device path
        If clsFF3x_API.GetPath(1) = False Then
            Me.ErrOut.Text = "Unable to locate FF3x device"
        End If

        ' connect to the device
        If clsFF3x_API.OpenComm = False Then
            Me.ErrOut.Text = "Unable to open FF3x device"
        End If

        ' get chip type and silicon version
        If clsFF3x_API.GetChipInfo(bytResponse) = False Then
            PrintMessage("Error", "GetChipInfo - " & clsFF3x_API.LastError)
        Else
            If (bytResponse(2) = &HB) Then
                Select Case bytResponse(1)
                    Case &HF
                        Me.txtAbout1stDevice.Text = "FF32"
                        Me.txtAboutVersion.Text = CInt(bytResponse(3)) & "." & CInt(bytResponse(4))
                    Case &H10
                        Me.txtAbout1stDevice.Text = "FF34"
                        Me.txtAboutVersion.Text = CInt(bytResponse(3)) & "." & CInt(bytResponse(4))
                    Case Else
                        Me.txtAbout1stDevice.Text = "???"
                        Me.txtAboutVersion.Text = "???"
                End Select
            Else
                Me.txtAbout1stDevice.Text = "???"
                Me.txtAboutVersion.Text = "???"
            End If
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)


        If clsFF3x_API.GetAnalogInput(ConvertPinName2PinBlock("B12"), ConvertPinName2PinNumber("B12"), bytResponse) Then
            If bytResponse(1) = CByte(&H33) Then
                volt = 3.3
            Else
                volt = 5
            End If
        End If

        cmbDigiOutPin.Text = "A1"
        cmbDigiOutPinValue.Text = "0"
        cmbDigiOutPinsBlock.Text = "A"
        cmbDigiInPin.Text = "B1"
        cmbDigiInPinsBlock.Text = "B"
        cmbPWMPin.Text = "A1"
        cmbPWMPin1.Text = "A2"
        cmbPWMPin2.Text = "A3"
        cmbPWMPin3.Text = "A4"
        cmbAnalogInPin.Text = "B1"
        cmbSPICSPin.Text = "A1"
        cmbSPISCKPin.Text = "A2"
        cmbSPIMOSIPin.Text = "A3"
        cmbSPIMISOPin.Text = "A4"
        cmbI2CSCLPin.Text = "A5"
        cmbI2CSDAPin.Text = "A6"
        cmb1WireDQPin.Text = "B1"

    End Sub

    Private Sub frmFF3x_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Document.Modified = True Then
            Dim result As Integer = MessageBox.Show("Save File ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Try
                    clsFF3x_API.CloseComm()
                Catch ex As Exception
                End Try
            Else
                Save()
                Try
                    clsFF3x_API.CloseComm()
                Catch ex As Exception
                End Try
            End If
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PrintMessage(ByVal strCategory As String, ByVal strContent As String)
        If rtbStatus.TextLength > 0 Then
            rtbStatus.AppendText(vbCrLf)
        End If
        rtbStatus.SelectionStart = rtbStatus.Text.Length
        Select Case strCategory
            Case "Error"
                rtbStatus.SelectionColor = Color.Red
            Case "Sent"
                rtbStatus.SelectionColor = Color.Blue
            Case "Received"
                rtbStatus.SelectionColor = Color.DarkGreen
            Case "Error at Line "
                rtbStatus.SelectionColor = Color.DarkRed
            Case "> "
                rtbStatus.SelectionColor = Color.LightGreen
            Case Else
                rtbStatus.SelectionColor = Color.Black
        End Select
        rtbStatus.AppendText(strCategory & ": ")
        rtbStatus.SelectionColor = Color.Black
        rtbStatus.AppendText(strContent)
    End Sub

    Private Sub cmdStatusClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStatusClear.Click
        rtbStatus.Clear()
    End Sub

    Private Function ConvertPinName2PinBlock(ByVal strPin As String) As Byte
        Dim bytPin() As Byte = System.Text.Encoding.UTF8.GetBytes(strPin)
        Return CByte(bytPin(0) - &H37)
    End Function
    Private Function ConvertPinName2PinNumber(ByVal strPin As String) As Byte
        Dim bytPin() As Byte = System.Text.Encoding.UTF8.GetBytes(strPin)
        If bytPin.Length = 3 Then   ' two-digits pin number
            Return CByte((bytPin(1) - 39) + (bytPin(2) - 48))
        End If
        Return CByte(bytPin(1) - 48)
    End Function

    Private Function HexToByte(ByVal strIn As String) As Byte
        Return CByte(CInt("&H" & strIn.Substring(2, 2)))
    End Function


#Region " About "

    Private Sub cmdAboutAddressGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutAddressGet.Click
        If clsFF3x_API.GetAddress(bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Me.txtAboutAddress.Text = CInt(bytResponse(1)).ToString
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmdAboutAddressSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutAddressSet.Click
        If Not IsNumeric(txtAboutAddress.Text) Then
            PrintMessage("Error", "Numeric value is required")
            Return
        End If
        If (CInt(txtAboutAddress.Text) < 0) Or (CInt(txtAboutAddress.Text) > 127) Then
            PrintMessage("Error", "Numeric value must be between 0 and 127")
            Return
        End If
        If clsFF3x_API.SetAddress(CByte(txtAboutAddress.Text), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmdAboutVendorGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutVendorGet.Click
        If clsFF3x_API.GetVendor(bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Me.txtAboutVendor.Text = System.Text.Encoding.UTF8.GetString(bytResponse, 1, bytResponse.Length - 2)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmdAboutVendorSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutVendorSet.Click
        Dim bytVendor() As Byte = System.Text.Encoding.UTF8.GetBytes(txtAboutVendor.Text)
        If clsFF3x_API.SetVendor(bytVendor, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmdAboutProductGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutProductGet.Click
        If clsFF3x_API.GetProduct(bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Me.txtAboutProduct.Text = System.Text.Encoding.UTF8.GetString(bytResponse, 1, bytResponse.Length - 2)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmdAboutProductSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutProductSet.Click
        Dim bytProduct() As Byte = System.Text.Encoding.UTF8.GetBytes(txtAboutProduct.Text)
        If clsFF3x_API.SetProduct(bytProduct, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmdAboutSerialGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutSerialGet.Click
        If clsFF3x_API.GetSerialNumber(bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Me.txtAboutSerial.Text = System.Text.Encoding.UTF8.GetString(bytResponse, 1, bytResponse.Length - 2)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmdAboutSerialSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAboutSerialSet.Click
        Dim bytSerial() As Byte = System.Text.Encoding.UTF8.GetBytes(txtAboutSerial.Text)
        If clsFF3x_API.SetSerialNumber(bytSerial, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

#End Region


#Region " Digital out "

    Private Sub cmdDigiOutPinSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDigiOutPinSet.Click
        If clsFF3x_API.SetDigitalOutput(ConvertPinName2PinBlock(cmbDigiOutPin.Text), ConvertPinName2PinNumber(cmbDigiOutPin.Text), CByte(cmbDigiOutPinValue.Text), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmbDigiOutPinsBlock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDigiOutPinsBlock.SelectedIndexChanged
        Dim i As Integer
        dgwDigiOutPinsBlockSettings.Rows.Clear()
        If cmbDigiOutPinsBlock.SelectedIndex = 0 Then
            For i = 1 To 6
                dgwDigiOutPinsBlockSettings.Rows.Add()
                Dim cbcCell As DataGridViewCell = dgwDigiOutPinsBlockSettings.Rows(i - 1).Cells(0)
                cbcCell.Value = "A" & i
            Next
        Else
            For i = 1 To 12
                dgwDigiOutPinsBlockSettings.Rows.Add()
                Dim cbcCell As DataGridViewCell = dgwDigiOutPinsBlockSettings.Rows(i - 1).Cells(0)
                cbcCell.Value = "B" & i
            Next
        End If
    End Sub

    Private Sub dgwDigiOutPinsBlockSettings_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDigiOutPinsBlockSettings.CellClick
        Select Case dgwDigiOutPinsBlockSettings.Columns(e.ColumnIndex).Index
            Case 1
                Dim cbcCell As DataGridViewCell = dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(1)
                If CBool(cbcCell.Value) = True Then
                    cbcCell.Value = False
                    dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(2) = New DataGridViewTextBoxCell
                    dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.FromKnownColor(KnownColor.Control)
                Else
                    cbcCell.Value = True
                    dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(2) = New DataGridViewComboBoxCell
                    Dim cbcValue As DataGridViewComboBoxCell = CType(dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(2), DataGridViewComboBoxCell)
                    cbcValue.Items.Add("0")
                    cbcValue.Items.Add("1")
                    cbcValue.Value = "0"
                    dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.FromKnownColor(KnownColor.Window)
                End If
            Case 2
                If CBool(dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(1).Value) = True Then
                    Dim cbcValue As DataGridViewComboBoxCell = CType(dgwDigiOutPinsBlockSettings.Rows(e.RowIndex).Cells(2), DataGridViewComboBoxCell)
                    If cbcValue.Value.ToString = "0" Then
                        cbcValue.Value = "1"
                    Else
                        cbcValue.Value = "0"
                    End If
                End If
        End Select
    End Sub

    Private Sub cmdDigiOutPinsBlockSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDigiOutPinsBlockSet.Click
        Dim bytBlock As Byte
        Dim bytMask(1) As Byte
        Dim bytState(1) As Byte
        Dim intMask As Integer = 0
        Dim intState As Integer = 0

        If cmbDigiOutPinsBlock.SelectedIndex = 0 Then    ' block A
            bytBlock = CByte(&HA)
            bytMask(0) = 0
            bytState(0) = 0
            For i = 5 To 0 Step -1
                intMask *= 2
                intState *= 2
                Dim cbcCell As DataGridViewCell = dgwDigiOutPinsBlockSettings.Rows(i).Cells(1)
                Dim cbcValue As DataGridViewCell = dgwDigiOutPinsBlockSettings.Rows(i).Cells(2)
                If CBool(cbcCell.Value) = True Then
                    intMask += 1
                    intState += CInt(cbcValue.Value)
                End If
            Next
            bytMask(1) = CByte(intMask)
            bytState(1) = CByte(intState)
        Else    ' block B
            bytBlock = CByte(&HB)
            For i = 11 To 0 Step -1
                intMask *= 2
                intState *= 2
                Dim cbcCell As DataGridViewCell = dgwDigiOutPinsBlockSettings.Rows(i).Cells(1)
                Dim cbcValue As DataGridViewCell = dgwDigiOutPinsBlockSettings.Rows(i).Cells(2)
                If CBool(cbcCell.Value) = True Then
                    intMask += 1
                    intState += CInt(cbcValue.Value)
                End If
                If i = 8 Then
                    bytMask(0) = CByte(intMask)
                    bytState(0) = CByte(intState)
                    intMask = 0
                    intState = 0
                End If
                bytMask(1) = CByte(intMask)
                bytState(1) = CByte(intState)
            Next
        End If

        If clsFF3x_API.SetBlockDigitalOutputs(bytBlock, bytMask, bytState, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

#End Region


#Region " Digital in "

    Private Sub cmdDigiInPinSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDigiInPinSet.Click
        If clsFF3x_API.GetDigitalInput(ConvertPinName2PinBlock(cmbDigiInPin.Text), ConvertPinName2PinNumber(cmbDigiInPin.Text), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            txtDigiInPinValue.Text = (bytResponse(1)).ToString
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmbDigiInPinsBlock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDigiInPinsBlock.SelectedIndexChanged
        Dim i As Integer
        dgwDigiInPinsBlockSettings.Rows.Clear()
        If cmbDigiInPinsBlock.SelectedIndex = 0 Then
            For i = 1 To 6
                dgwDigiInPinsBlockSettings.Rows.Add()
                Dim cbcCell As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i - 1).Cells(0)
                cbcCell.Value = "A" & i
            Next
        Else
            For i = 1 To 12
                dgwDigiInPinsBlockSettings.Rows.Add()
                Dim cbcCell As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i - 1).Cells(0)
                cbcCell.Value = "B" & i
            Next
        End If
    End Sub

    Private Sub dgwDigiInPinsBlockSettings_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwDigiInPinsBlockSettings.CellClick
        If dgwDigiInPinsBlockSettings.Columns(e.ColumnIndex).Index = 1 Then
            Dim cbcCell As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(e.RowIndex).Cells(1)
            If CBool(cbcCell.Value) = True Then
                cbcCell.Value = False
            Else
                cbcCell.Value = True
            End If
        End If
    End Sub

    Private Sub cmbDigiInPinsBlockGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDigiInPinsBlockGet.Click
        Dim bytBlock As Byte
        Dim bytMask(1) As Byte
        Dim intMask As Integer = 0

        If cmbDigiInPinsBlock.SelectedIndex = 0 Then    ' block A
            bytBlock = CByte(&HA)
            bytMask(0) = 0
            For i = 5 To 0 Step -1
                intMask *= 2
                Dim cbcCell As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i).Cells(1)
                If CBool(cbcCell.Value) = True Then
                    intMask += 1
                End If
            Next
            bytMask(1) = CByte(intMask)
        Else    ' block B
            bytBlock = CByte(&HB)
            For i = 11 To 0 Step -1
                intMask *= 2
                Dim cbcCell As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i).Cells(1)
                If CBool(cbcCell.Value) = True Then
                    intMask += 1
                End If
                If i = 8 Then
                    bytMask(0) = CByte(intMask)
                    intMask = 0
                End If
            Next
            bytMask(1) = CByte(intMask)
        End If

        If clsFF3x_API.GetBlockDigitalInputs(bytBlock, bytMask, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            intMask = 1
            If cmbDigiInPinsBlock.SelectedIndex = 0 Then    ' block A
                For i = 0 To 5
                    Dim cbcMask As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i).Cells(1)
                    Dim cbcValue As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i).Cells(2)
                    If CBool(cbcMask.Value) = True Then
                        If (bytResponse(2) And intMask) = 0 Then
                            cbcValue.Value = 0
                        Else
                            cbcValue.Value = 1
                        End If
                    Else
                        cbcValue.Value = ""
                    End If
                    intMask *= 2
                Next
            Else        ' block B
                For i = 0 To 11
                    Dim cbcMask As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i).Cells(1)
                    Dim cbcValue As DataGridViewCell = dgwDigiInPinsBlockSettings.Rows(i).Cells(2)
                    If CBool(cbcMask.Value) = True Then
                        If (bytResponse(2 - (i \ 8)) And intMask) = 0 Then
                            cbcValue.Value = 0
                        Else
                            cbcValue.Value = 1
                        End If
                    Else
                        cbcValue.Value = ""
                    End If
                    intMask *= 2
                    If i = 7 Then
                        intMask = 1
                    End If
                Next
            End If
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

#End Region


#Region " PWM "

    Private Sub cmdPWMPinSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPWMPinSet.Click
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin.Text), ConvertPinName2PinNumber(cmbPWMPin.Text), _
                    CByte(trbPWMPinValue.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub trbPWMPinValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbPWMPinValue.ValueChanged
        txtPWMPinValue.Text = trbPWMPinValue.Value & "%"
    End Sub

    Private Sub trbPWMPinValue1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbPWMPinValue1.ValueChanged
        txtPWMPinValue1.Text = trbPWMPinValue1.Value & "%"
    End Sub

    Private Sub trbPWMPinValue2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbPWMPinValue2.ValueChanged
        txtPWMPinValue2.Text = trbPWMPinValue2.Value & "%"
    End Sub

    Private Sub trbPWMPinValue3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbPWMPinValue3.ValueChanged
        txtPWMPinValue3.Text = trbPWMPinValue3.Value & "%"
    End Sub

#End Region


#Region " Analog in "

    Private Sub cmdAnalogInPinGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnalogInPinGet.Click
        If clsFF3x_API.GetAnalogInput(ConvertPinName2PinBlock(cmbAnalogInPin.Text), ConvertPinName2PinNumber(cmbAnalogInPin.Text), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Dim dblValue As Double = (((bytResponse(2) * 256) + bytResponse(3)) / 1023)
            If bytResponse(1) = CByte(&H33) Then
                dblValue *= 3.3
            Else
                dblValue *= 5
            End If
            txtAnalogInPinValue.Text = dblValue.ToString("F3") & "V"
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

#End Region


#Region " SPI "

    Private Sub cmbSPIPinsSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSPIPinsSet.Click
        If clsFF3x_API.SetSPIPins(ConvertPinName2PinBlock(cmbSPICSPin.Text), ConvertPinName2PinNumber(cmbSPICSPin.Text), _
                ConvertPinName2PinBlock(cmbSPISCKPin.Text), ConvertPinName2PinNumber(cmbSPISCKPin.Text), _
                ConvertPinName2PinBlock(cmbSPIMOSIPin.Text), ConvertPinName2PinNumber(cmbSPIMOSIPin.Text), _
                ConvertPinName2PinBlock(cmbSPIMISOPin.Text), ConvertPinName2PinNumber(cmbSPIMISOPin.Text), _
                bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub


    Private Sub cmdSPIExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSPIExecute.Click


        If Not IsNumeric(txtSPIDataLen.Text) Then
            PrintMessage("Error", "Numeric value is required for Data Length ")
            Return
        End If
        If (CInt(txtSPIDataLen.Text) < 0) Or (CInt(txtSPIDataLen.Text) > 60) Then
            PrintMessage("Error", "Data Length value must be between 0 and 60")
            Return
        End If

        If RadioHex.Checked Then txtSPIData.Text = ToAs(txtSPIData.Text)

        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(txtSPIData.Text)
        Dim bytData(bytContent.Length) As Byte

        For i = 0 To bytContent.Length - 1     ' fill data payload
            bytData(i) = bytContent(i)
        Next
        If clsFF3x_API.ReadSPI(CByte(bytData.Length - 1), CByte(txtSPIDataLen.Text), bytData, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Me.txtResultSPI.Text = ""
            For i = 2 To bytResponse.Length - 2
                txtResultSPI.Text &= (Convert.ToString(bytResponse(i), 16).PadLeft(2, "0"c)).ToUpper
            Next
        End If

        If RadioHex.Checked Then txtSPIData.Text = ToHex(txtSPIData.Text)

        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)



    End Sub

#End Region


#Region " I2C "

    Private Sub cmdI2CPinsSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdI2CPinsSet.Click
        If clsFF3x_API.SetI2CPins(ConvertPinName2PinBlock(cmbI2CSCLPin.Text), ConvertPinName2PinNumber(cmbI2CSCLPin.Text), _
                ConvertPinName2PinBlock(cmbI2CSDAPin.Text), ConvertPinName2PinNumber(cmbI2CSDAPin.Text), _
                bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub


    Private Sub cmdI2CExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdI2CExecute.Click

        If Not IsNumeric(txtI2CDataLen.Text) Then
            PrintMessage("Error", "Numeric value is required for Data Length ")
            Return
        End If
        If (CInt(txtI2CDataLen.Text) < 0) Or (CInt(txtI2CDataLen.Text) > 60) Then
            PrintMessage("Error", "Data Length value must be between 0 and 60")
            Return
        End If

        If RadioIHex.Checked Then txtI2CData.Text = ToAs(txtI2CData.Text)

        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(txtI2CData.Text)
        Dim bytData(bytContent.Length) As Byte

        For i = 0 To bytContent.Length - 1     ' fill data payload
            bytData(i) = bytContent(i)
        Next

        If clsFF3x_API.ReadI2C(CByte(bytData.Length - 1), CByte(txtI2CDataLen.Text), bytData, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Me.I2CResult.Text = ""
            For i = 2 To bytResponse.Length - 2
                I2CResult.Text &= (Convert.ToString(bytResponse(i), 16).PadLeft(2, "0"c)).ToUpper
            Next
        End If
        If RadioIHex.Checked Then txtI2CData.Text = ToHex(txtI2CData.Text)
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)

    End Sub

#End Region


#Region " 1-Wire "

    Private Sub cmd1WireDQPinSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1WireDQPinSet.Click
        If clsFF3x_API.Set1WirePin(ConvertPinName2PinBlock(cmb1WireDQPin.Text), ConvertPinName2PinNumber(cmb1WireDQPin.Text), _
                bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub


    Private Sub cmd1WireReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1WireReset.Click
        If clsFF3x_API.Reset1Wire(bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmd1WireWriteBit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1WireWriteBit1.Click
        If clsFF3x_API.WriteBit1Wire(1, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmd1WireWriteBit0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1WireWriteBit0.Click
        If clsFF3x_API.WriteBit1Wire(0, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub cmd1WireReadBit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1WireReadBit.Click
        If clsFF3x_API.ReadBit1Wire(bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

#End Region



#Region "Main Menu Bar"
    Private Sub mMNew_Click(sender As System.Object, e As System.EventArgs) Handles mMNew.Click
        NewDocument()
    End Sub

    Private Sub mMOpen_Click(sender As System.Object, e As System.EventArgs) Handles mMOpen.Click
        Open()
    End Sub

    Private Sub mMSave_Click(sender As System.Object, e As System.EventArgs) Handles mMSave.Click
        Save()
    End Sub

    Private Sub mMExit_Click(sender As System.Object, e As System.EventArgs) Handles mMExit.Click
        ExitApplication()
    End Sub


    Private Sub mMUndo_Click(sender As System.Object, e As System.EventArgs) Handles mMUndo.Click
        Undo()
    End Sub

    Private Sub mMRedo_Click(sender As System.Object, e As System.EventArgs) Handles mMRedo.Click
        Redo()
    End Sub

    Private Sub mMCut_Click(sender As System.Object, e As System.EventArgs) Handles mMCut.Click
        Cut()
    End Sub

    Private Sub mMCopy_Click(sender As System.Object, e As System.EventArgs) Handles mMCopy.Click
        Copy()
    End Sub

    Private Sub mMPaste_Click(sender As System.Object, e As System.EventArgs) Handles mMPaste.Click
        Paste()
    End Sub

    Private Sub mMSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles mMSelectAll.Click
        SelectAll()
    End Sub


#End Region


#Region "Toolbar"


    Private Sub tbNew_Click(sender As System.Object, e As System.EventArgs) Handles tbNew.Click
        NewDocument()
    End Sub

    Private Sub tbOpen_Click(sender As System.Object, e As System.EventArgs) Handles tbOpen.Click
        Open()
        Document.Modified = False
    End Sub

    Private Sub tbSave_Click(sender As System.Object, e As System.EventArgs) Handles tbSave.Click
        Save()
        Document.Modified = False
    End Sub

    Private Sub tbCut_Click(sender As System.Object, e As System.EventArgs) Handles tbCut.Click
        Cut()
    End Sub

    Private Sub tbCopy_Click(sender As System.Object, e As System.EventArgs) Handles tbCopy.Click
        Copy()
    End Sub

    Private Sub tbPaste_Click(sender As System.Object, e As System.EventArgs) Handles tbPaste.Click
        Paste()
    End Sub

    Private Sub tbZoom_Click(sender As System.Object, e As System.EventArgs) Handles tbZoom.Click
        If Document.ZoomFactor = 63 Then

            Exit Sub
        Else

            Document.ZoomFactor = Document.ZoomFactor + 1
        End If


    End Sub

    Private Sub tbZoomOut_Click(sender As System.Object, e As System.EventArgs) Handles tbZoomOut.Click
        If Document.ZoomFactor = 1 Then
            Exit Sub

        Else

            Document.ZoomFactor = Document.ZoomFactor - 1
        End If



    End Sub

#End Region


#Region "Methods"

#Region "File"

    Private Sub NewDocument()
        If Document.Modified = True Then
            Dim result As Integer = MessageBox.Show("Save File ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then
                Return
            ElseIf result = DialogResult.Yes Then
                Save()
            End If
        End If
        Document.Clear()
    End Sub

    Private Sub Open()
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then

            Document.LoadFile(openWork.FileName, _
                              RichTextBoxStreamType.PlainText)

        End If
    End Sub

    Private Sub Save()
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Document.SaveFile(saveWork.FileName, _
                                  RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ExitApplication()
        Me.Close()
    End Sub



#End Region

#Region "Edit"

    Private Sub Undo()
        Document.Undo()
    End Sub

    Private Sub Redo()
        Document.Redo()
    End Sub

    Private Sub Cut()
        Document.Cut()
    End Sub

    Private Sub Copy()
        Document.Copy()
    End Sub

    Private Sub Paste()
        Document.Paste()
    End Sub

    Private Sub SelectAll()
        Document.SelectAll()
    End Sub


#End Region


#End Region


#Region "RightClickMenu"

    Private Sub UndoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Paste()
    End Sub
#End Region

    Private Sub tbRun_Click(sender As Object, e As EventArgs) Handles tbRun.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        ToolStripButton1.Enabled = False
        RunToolStripMenuItem.Enabled = False
        StopToolStripMenuItem.Enabled = True
        tbRun.Enabled = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Function ToAs(st As String) As String
        Dim com As New System.Text.StringBuilder(st.Length \ 2)
        Dim xx As Integer = st.Length
        If (xx Mod 2) <> 0 Then xx -= 1
        For x = 0 To xx - 1 Step 2
            If IsNumeric("&H" & st.Substring(x, 2)) Then
                com.Append(Chr(Convert.ToByte(st.Substring(x, 2), 16)))
            End If
        Next
        Return com.ToString
    End Function

    Private Function ToHex(st As String) As String
        Dim com As New System.Text.StringBuilder(st.Length * 2)
        For i As Integer = 0 To st.Length - 1
            com.Append(Asc(st.Substring(i, 1)).ToString("x").ToUpper)
        Next
        Return com.ToString
    End Function

    Private Sub RadioAscii_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAscii.CheckedChanged
        If RadioHex.Checked Then Return
        txtSPIData.Text = ToAs(txtSPIData.Text)
        txtSPIData.MaxLength = 60
    End Sub

    Private Sub RadioHex_CheckedChanged(sender As Object, e As EventArgs) Handles RadioHex.CheckedChanged
        If RadioAscii.Checked Then Return
        txtSPIData.MaxLength = 120
        txtSPIData.Text = ToHex(txtSPIData.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioHex.Checked Then txtSPIData.Text = ToAs(txtSPIData.Text)

        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(txtSPIData.Text)
        Dim bytData(bytContent.Length) As Byte
        Dim i As Integer

        For i = 0 To bytContent.Length - 1     ' fill data payload
            bytData(i) = bytContent(i)
        Next

        If clsFF3x_API.WriteSPI(CByte(bytData.Length - 1), bytData, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        If RadioHex.Checked Then txtSPIData.Text = ToHex(txtSPIData.Text)
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oReader As StreamReader
        Dim cin(60) As Char
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtSPIData.Text = ""
            oReader = New StreamReader(openWork.FileName, True)
            oReader.Read(cin, 0, 60)
            oReader.Close()
            txtSPIData.Text = cin
            If RadioHex.Checked Then txtSPIData.Text = ToHex(txtSPIData.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            If RadioHex.Checked Then txtSPIData.Text = ToAs(txtSPIData.Text)
            IO.File.WriteAllText(saveWork.FileName, txtSPIData.Text)
            If RadioHex.Checked Then txtSPIData.Text = ToHex(txtSPIData.Text)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RadioIHex.Checked Then txtSPIData.Text = ToAs(txtSPIData.Text)

        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(txtI2CData.Text)
        Dim bytData(bytContent.Length) As Byte
        Dim i As Integer

        For i = 0 To bytContent.Length - 1     ' fill data payload
            bytData(i) = bytContent(i)
        Next

        If clsFF3x_API.WriteI2C(CByte(bytData.Length - 1), bytData, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        If RadioIHex.Checked Then txtSPIData.Text = ToHex(txtSPIData.Text)

        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)

    End Sub

    Private Sub RadioIAsc_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIAsc.CheckedChanged
        If RadioIHex.Checked Then Return
        txtI2CData.Text = ToAs(txtI2CData.Text)
        txtI2CData.MaxLength = 60
    End Sub

    Private Sub RadioIHex_CheckedChanged(sender As Object, e As EventArgs) Handles RadioIHex.CheckedChanged
        If RadioIAsc.Checked Then Return
        txtI2CData.MaxLength = 120
        txtI2CData.Text = ToHex(txtI2CData.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim oReader As StreamReader
        Dim cin(60) As Char
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtI2CData.Text = ""
            oReader = New StreamReader(openWork.FileName, True)
            oReader.Read(cin, 0, 60)
            oReader.Close()
            txtI2CData.Text = cin
            If RadioIHex.Checked Then txtI2CData.Text = ToHex(txtI2CData.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            If RadioIHex.Checked Then txtI2CData.Text = ToAs(txtI2CData.Text)
            IO.File.WriteAllText(saveWork.FileName, txtI2CData.Text)
            If RadioIHex.Checked Then txtI2CData.Text = ToHex(txtI2CData.Text)
        End If
    End Sub

    Private Sub Radio1asc_CheckedChanged(sender As Object, e As EventArgs) Handles Radio1asc.CheckedChanged
        If Radio1Hex.Checked Then Return
        txt1WireData.Text = ToAs(txt1WireData.Text)
        txt1WireData.MaxLength = 60
    End Sub

    Private Sub Radio1Hex_CheckedChanged(sender As Object, e As EventArgs) Handles Radio1Hex.CheckedChanged
        If Radio1asc.Checked Then Return
        txt1WireData.MaxLength = 120
        txt1WireData.Text = ToHex(txt1WireData.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Not IsNumeric(txt1WireLen.Text) Then
            PrintMessage("Error", "Numeric value is required for Data Length ")
            Return
        End If
        If (CInt(txtI2CDataLen.Text) < 0) Or (CInt(txtI2CDataLen.Text) > 60) Then
            PrintMessage("Error", "Data Length value must be between 0 and 60")
            Return
        End If

        If Radio1Hex.Checked Then txt1WireData.Text = ToAs(txt1WireData.Text)

        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(txt1WireData.Text)
        Dim bytData(bytContent.Length) As Byte

        For i = 0 To bytContent.Length - 1     ' fill data payload
            bytData(i) = bytContent(i)
        Next

        If clsFF3x_API.Read1Wire(CByte(bytData.Length - 1), CByte(txt1WireLen.Text), bytData, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        Else
            Me.txt1WireResponse.Text = ""
            For i = 2 To bytResponse.Length - 2
                txt1WireResponse.Text &= (Convert.ToString(bytResponse(i), 16).PadLeft(2, "0"c)).ToUpper
            Next
        End If
        If Radio1Hex.Checked Then txt1WireData.Text = ToHex(txt1WireData.Text)
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Radio1Hex.Checked Then txt1WireData.Text = ToAs(txt1WireData.Text)

        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(txt1WireData.Text)
        Dim bytData(bytContent.Length) As Byte
        Dim i As Integer

        For i = 0 To bytContent.Length - 1     ' fill data payload
            bytData(i) = bytContent(i)
        Next

        If clsFF3x_API.Write1Wire(CByte(bytData.Length - 1), bytData, bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        If Radio1Hex.Checked Then txt1WireData.Text = ToHex(txt1WireData.Text)

        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim oReader As StreamReader
        Dim cin(60) As Char
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt1WireData.Text = ""
            oReader = New StreamReader(openWork.FileName, True)
            oReader.Read(cin, 0, 60)
            oReader.Close()
            txt1WireData.Text = cin
            If Radio1Hex.Checked Then txt1WireData.Text = ToHex(txt1WireData.Text)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Radio1Hex.Checked Then txt1WireData.Text = ToAs(txt1WireData.Text)
            IO.File.WriteAllText(saveWork.FileName, txt1WireData.Text)
            If Radio1Hex.Checked Then txt1WireData.Text = ToHex(txt1WireData.Text)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        clsFF3x_API.GetAnalogInput(ConvertPinName2PinBlock(cmbAnalogInPin.Text), ConvertPinName2PinNumber(cmbAnalogInPin.Text), bytResponse)

        If bytResponse(1) = CByte(&H33) Then
            Chart1.ChartAreas(0).AxisY.Maximum = 3.3
        Else
            Chart1.ChartAreas(0).AxisY.Maximum = 5
        End If

        Timer1.Start()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Timer1.Stop()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin1.Text), ConvertPinName2PinNumber(cmbPWMPin1.Text), _
            CByte(trbPWMPinValue1.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin2.Text), ConvertPinName2PinNumber(cmbPWMPin2.Text), _
            CByte(trbPWMPinValue2.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin3.Text), ConvertPinName2PinNumber(cmbPWMPin3.Text), _
            CByte(trbPWMPinValue3.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin.Text), ConvertPinName2PinNumber(cmbPWMPin.Text), _
    CByte(trbPWMPinValue.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin1.Text), ConvertPinName2PinNumber(cmbPWMPin1.Text), _
    CByte(trbPWMPinValue1.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin2.Text), ConvertPinName2PinNumber(cmbPWMPin2.Text), _
    CByte(trbPWMPinValue2.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin3.Text), ConvertPinName2PinNumber(cmbPWMPin3.Text), _
    CByte(trbPWMPinValue3.Value), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin.Text), ConvertPinName2PinNumber(cmbPWMPin.Text), _
    CByte(0), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin1.Text), ConvertPinName2PinNumber(cmbPWMPin1.Text), _
    CByte(0), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin2.Text), ConvertPinName2PinNumber(cmbPWMPin2.Text), _
    CByte(0), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(cmbPWMPin3.Text), ConvertPinName2PinNumber(cmbPWMPin3.Text), _
    CByte(0), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        PrintMessage("Sent", clsFF3x_API.LastDataSent)
        PrintMessage("Received", clsFF3x_API.LastDataReceived)
    End Sub



    Function ChopItUp(ByVal inputFile As String, ByVal chunkSize As Integer) As Integer

        Dim reader As New FileStream(inputFile, FileMode.Open)
        Dim fileIndex As Integer = 1
        Dim buffer(chunkSize) As Byte
        Dim writer As FileStream
        Dim bytesRead As Integer
        Dim pos As Integer = inputFile.LastIndexOf(".")
        Dim inFile As String = inputFile
        Do
            bytesRead = reader.Read(buffer, 0, chunkSize)
            If bytesRead > 0 Then
                inFile = inputFile.Insert(pos, CStr(fileIndex))
                writer = New FileStream(inFile, FileMode.Create)
                writer.Write(buffer, 0, bytesRead)
                writer.Close()
                fileIndex = fileIndex + 1
            End If
        Loop While bytesRead > 0

        reader.Close()

        ChopItUp = fileIndex - 1

    End Function

    Sub Main(ByVal args() As String)


        If args(0) = "split" And args.Length = 2 Then
            Dim pieces As Integer = ChopItUp(args(1), 524288)
            System.Console.WriteLine("Created {0} pieces", pieces)
            Exit Sub
        End If

    End Sub


    Private Sub SplitAFileIn60BytesFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitAFileIn60BytesFilesToolStripMenuItem.Click
        Panel10.Visible = True
    End Sub


    Private Const semicolon As Byte = &H3A
    Private mBuffer As Byte() = Nothing
    Private test As String = ""

    Public Function StringToByteArray(hex As String) As Byte()
        Return Enumerable.Range(0, Hex.Length).Where(Function(x) x Mod 2 = 0).[Select](Function(x) Convert.ToByte(Hex.Substring(x, 2), 16)).ToArray()
    End Function

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    Private Sub IntelHEXToBINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntelHEXToBINToolStripMenuItem.Click

        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = mydocpath
        openFileDialog1.Filter = "hex files|*.hex|All files|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.Multiselect = True
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim tempFolder As String = System.IO.Path.GetTempPath()
                For Each fileName As String In openFileDialog1.FileNames
                    Using sr As New StreamReader(fileName)
                        Dim sbWrite As New StringBuilder()
                        Dim binaryval As [String] = "", hexvalue As [String] = ""

                        Dim line As [String]

                        'Get rid of first line
                        'sr.ReadLine()

                        While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
                            binaryval = ""
                            line = line.Substring(9)
                            Dim charArray As Char() = line.ToCharArray()

                            If charArray.Length > 32 Then
                                binaryval = New String(charArray, 0, 32)
                                sbWrite.Append(binaryval)
                            End If
                        End While

                        Dim buffer As Byte() = StringToByteArray(sbWrite.ToString())

                        'MessageBox.Show(fileName)
                        Dim fs As New FileStream(fileName & ".bin", FileMode.Create, FileAccess.ReadWrite)
                        Dim bw As New BinaryWriter(fs)
                        bw.Write(buffer)
                        bw.Close()
                        fs.Close()
                    End Using
                Next

                MessageBox.Show("Conversion complete.")
            Catch ex As IOException
            End Try
        End If
    End Sub

    Private Sub HexToBinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HexToBinToolStripMenuItem.Click
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = mydocpath
        openFileDialog1.Filter = "Text files|*.txt|All files|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.Multiselect = True
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim tempFolder As String = System.IO.Path.GetTempPath()
                For Each fileName As String In openFileDialog1.FileNames
                    Using sr As New StreamReader(fileName)
                        Dim sbWrite As New StringBuilder()
                        Dim binaryval As [String] = "", hexvalue As [String] = ""

                        Dim line As [String] = ""

                        While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
                            If (line.Length Mod 2) <> 0 Then line = "0" & line
                            Dim myRegex As New Regex("^[a-fA-F0-9]+$")
                            If myRegex.IsMatch(line) Then
                                binaryval = ""
                                Dim charArray As Char() = line.ToCharArray()

                                binaryval = New String(charArray, 0, charArray.Length)
                                sbWrite.Append(binaryval)
                            End If
                        End While

                        Dim buffer As Byte() = StringToByteArray(sbWrite.ToString())

                        'MessageBox.Show(fileName)
                        Dim fs As New FileStream(fileName & ".bin", FileMode.Create, FileAccess.ReadWrite)
                        Dim bw As New BinaryWriter(fs)
                        bw.Write(buffer)
                        bw.Close()
                        fs.Close()
                    End Using
                Next

                MessageBox.Show("Conversion complete.")
            Catch ex As IOException
            End Try
        End If

    End Sub


    Private Function EvalFF3(lineorg As String, i As Integer) As Integer
        i = i + 1
        EvalFF3 = i
        Dim line As String = Trim(lineorg.ToUpper)
        If line.Length < 2 Then Return i
        If GetChar(line, 1) = "'" Then Return i
        Dim token As String = ""
        Dim betw As String
        Dim chrn As Char
        token = GetChar(line, 1)
        If token = "A" Then
            chrn = GetChar(line, 2)
            If chrn = "B" Then
                betw = Trim(line.Substring(2))
                chrn = GetChar(betw, 1)
                If chrn = "=" Then
                    If Setportblk(token, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                    Return i
                End If
            ElseIf chrn > "0" And chrn < "7" Then
                token &= chrn
                betw = Trim(line.Substring(2))
                chrn = GetChar(betw, 1)
                If chrn = "=" Then
                    If Setport(token, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                    Return i
                End If
            End If
        End If
        If token = "B" Then
            chrn = GetChar(line, 2)
            If chrn = "B" Then
                betw = Trim(line.Substring(2))
                chrn = GetChar(betw, 1)
                If chrn = "=" Then
                    If Setportblk(token, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                    Return i
                End If
            ElseIf chrn > "0" And chrn <= "9" Then
                token &= chrn
                betw = Trim(line.Substring(2))
                chrn = GetChar(betw, 1)
                If chrn >= "0" And chrn < "3" And token = "B1" Then
                    betw = Trim(line.Substring(3))
                    token &= chrn
                    chrn = GetChar(betw, 1)
                End If
                If chrn = "=" Then
                    If Setport(token, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                    Return i
                End If
            End If
        End If
            If token = "S" Then
                chrn = GetChar(line, 2)
                If chrn > "0" And chrn <= "9" Then
                    token &= chrn
                    betw = Trim(line.Substring(2))
                    chrn = GetChar(betw, 1)
                    If chrn = "=" Then
                        If SetS(token, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                        Return i
                    End If
                End If
            End If
            If line.Length > 4 Then token = Trim(line.Substring(0, 4))
            If token = "BUFF" Then
                betw = Trim(line.Substring(4))
                chrn = GetChar(betw, 1)
                betw = Trim(line.Substring(5))
            If chrn >= "A" And chrn < "E" Then
                token = chrn
                chrn = GetChar(betw, 1)
                If chrn = "=" Then
                    betw = Trim(lineorg.Substring(6))
                    If GetChar(lineorg, 6) = " " Then betw = Trim(lineorg.Substring(7))
                    If SetBuff(token, betw) = False Then PrintMessage("Error at Line ", lineorg)
                    Return i
                ElseIf chrn = "(" Then
                    betw = Trim(betw.Substring(1))
                    Dim pos As Integer = betw.IndexOf(")")
                    If pos > 0 Then
                        Dim numb As String = Trim(betw.Substring(0, pos))
                        betw = Trim(betw.Substring(pos + 1))
                        chrn = GetChar(betw, 1)
                        If chrn = "=" Then
                            If SetBuffIDX(token, numb, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                            Return i
                        End If
                    End If
                End If
            End If
            End If
            Dim post As Integer = line.IndexOf(" ")
            Dim po As Integer = line.IndexOf("(")
            If po < post And po > 0 Then post = po
            po = line.IndexOf("""")
            If po < post And po > 0 Then post = po
            If post < 1 Then
                token = line
                post = 0
            Else
                token = line.Substring(0, post)
            End If
            Select Case token
                Case "WRITE"
                    If post = 0 Then
                        PrintMessage("Error at Line ", lineorg)
                    Else
                        betw = Trim(lineorg.Substring(post + 1))
                        chrn = GetChar(betw, 1)
                        If chrn = "(" Then
                            betw = Trim(betw.Substring(1))
                            Dim pos As Integer = betw.IndexOf(")")
                            If pos > 0 Then
                                Dim filenm As String = Trim(betw.Substring(0, pos))
                                betw = Trim(betw.Substring(pos + 1)).ToUpper
                                If betw.Length > 4 Then
                                    token = Trim(betw.Substring(0, 4))
                                    If token = "BUFF" Then
                                        chrn = GetChar(betw, 5)
                                        If chrn >= "A" And chrn < "E" Then
                                            token = chrn
                                            WriteFile(filenm, token)
                                        Else : PrintMessage("Error at Line ", lineorg)
                                        End If
                                    Else : PrintMessage("Error at Line ", lineorg)
                                    End If
                                Else : PrintMessage("Error at Line ", lineorg)
                                End If
                            Else : PrintMessage("Error at Line ", lineorg)
                            End If
                        Else : PrintMessage("Error at Line ", lineorg)
                        End If
                    End If
                Case "READ"
                    If post = 0 Then
                        PrintMessage("Error at Line ", lineorg)
                    Else
                        betw = Trim(lineorg.Substring(post + 1))
                        chrn = GetChar(betw, 1)
                        If chrn = "(" Then
                            betw = Trim(betw.Substring(1))
                            Dim pos As Integer = betw.IndexOf(")")
                            If pos > 0 Then
                                Dim filenm As String = Trim(betw.Substring(0, pos))
                                betw = Trim(betw.Substring(pos + 1)).ToUpper
                                If betw.Length > 4 Then
                                    token = Trim(betw.Substring(0, 4))
                                    If token = "BUFF" Then
                                        chrn = GetChar(betw, 5)
                                        If chrn >= "A" And chrn < "E" Then
                                            token = chrn
                                            ReadFile(filenm, token)
                                        Else : PrintMessage("Error at Line ", lineorg)
                                        End If
                                    Else : PrintMessage("Error at Line ", lineorg)
                                    End If
                                Else : PrintMessage("Error at Line ", lineorg)
                                End If
                            Else : PrintMessage("Error at Line ", lineorg)
                            End If
                        Else : PrintMessage("Error at Line ", lineorg)
                        End If
                    End If
                Case "PRINT"
                    If post = 0 Then
                        PrintMessage("Error at Line ", lineorg)
                    Else
                        betw = Trim(lineorg.Substring(post + 1))
                        Dim type As String = "D"
                        post = betw.IndexOf("""")
                    If post >= 0 Then type = "S"
                    post = betw.ToUpper.IndexOf(",BUFF")
                    If post >= 0 Then type = "S"
                    post = betw.ToUpper.IndexOf("BUFF")
                    If post = 0 Then
                        If betw.Length < 6 Then
                            type = "S"
                        Else
                            If GetChar(betw, 6) <> "(" And GetChar(betw, 7) <> "(" Then
                                type = "S"
                            End If
                        End If
                    End If
                    If betw.Length > 1 Then chrn = GetChar(betw, 2)
                    If chrn = " " And GetChar(betw, 1) > "@" Then
                        type = GetChar(betw, 1)
                        betw = betw.Substring(2)
                    End If
                    DoPrint(type.ToUpper, Trim(betw), 0)
                End If
            Case "SLEEP"
                If post = 0 Then
                    betw = "1000"
                Else
                    betw = Trim(line.Substring(post + 1))
                End If
                Dim tst As Char = "T"c
                Dim valu As Integer = Math.Abs(GetExpression(betw, tst))
                If tst = "E" Then PrintMessage("Error at Line ", lineorg)
                DoSleep(valu)
            Case "WAIT"
                If post = 0 Then
                    PrintMessage("Error at Line ", lineorg)
                Else
                    betw = Trim(line.Substring(post + 1))
                    token = GetChar(betw, 1)
                    If token = "A" Then
                        chrn = GetChar(betw, 2)
                        If chrn > "0" And chrn < "7" Then
                            token &= chrn
                            betw = Trim(betw.Substring(2))
                            chrn = GetChar(betw, 1)
                            If chrn = "=" Then
                                If DoWait(token, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                            End If
                        Else
                        End If
                    End If
                    If token = "B" Then
                        chrn = GetChar(betw, 2)
                        If chrn > "0" And chrn <= "9" Then
                            token &= chrn
                            betw = Trim(betw.Substring(2))
                            chrn = GetChar(betw, 1)
                            If chrn >= "0" And chrn < "3" And token = "B1" Then
                                betw = Trim(betw.Substring(3))
                                token &= chrn
                                chrn = GetChar(betw, 1)
                            End If
                            If chrn = "=" Then
                                If DoWait(token, Trim(betw.Substring(1))) = False Then PrintMessage("Error at Line ", lineorg)
                            End If
                        End If
                    End If
                End If
            Case "PWM"
                If post = 0 Then
                    PrintMessage("Error at Line ", lineorg)
                Else
                    Dim Pin As String = ""
                    betw = Trim(line.Substring(post + 1))
                    chrn = GetChar(betw, 1)
                    If chrn = "A" Then
                        chrn = GetChar(betw, 2)
                        If chrn > "0" And chrn < "7" Then
                            Pin = "A" & chrn
                        Else : PrintMessage("Error at Line ", lineorg)
                        End If
                    Else : PrintMessage("Error at Line ", lineorg)
                    End If
                    If Pin.Length < 2 Then
                        PrintMessage("Error at Line ", lineorg)
                    Else
                        betw = Trim(betw.Substring(Pin.Length))
                        If betw.Length < 1 Then betw = "50"
                        If SetPWM(Pin, betw) = False Then PrintMessage("Error at Line ", lineorg)
                    End If
                End If
            Case "SPI"
                If post = 0 Then
                    PrintMessage("Error at Line ", lineorg)
                Else
                    betw = Trim(lineorg.Substring(post + 1))
                    post = betw.IndexOf(" ")
                    If post < 1 Then
                        PrintMessage("Error at Line ", lineorg)
                    Else
                        token = betw.Substring(0, post).ToUpper
                    End If
                    Select Case token
                        Case "SET"
                            Dim pin(4) As String
                            For x As Integer = 0 To 3
                                betw = Trim(betw.Substring(post + 1)).ToUpper
                                post = betw.IndexOf(" ")
                                If post > 1 Then
                                    token = betw.Substring(0, post)
                                ElseIf x = 3 Then
                                    token = betw
                                Else
                                    PrintMessage("Error at Line ", lineorg)
                                    Return i
                                End If
                                If token.Length < 2 Then
                                    PrintMessage("Error at Line ", lineorg)
                                    Return i
                                Else
                                    chrn = GetChar(token, 1)
                                    If chrn = "A" Then
                                        If token.Length > 2 Then
                                            PrintMessage("Error at Line ", lineorg)
                                            Return i
                                        Else
                                            chrn = GetChar(token, 2)
                                            If chrn > "0" And chrn < "7" Then
                                                pin(x) = "A" & chrn
                                            Else
                                                PrintMessage("Error at Line ", lineorg)
                                                Return i
                                            End If
                                        End If
                                    ElseIf chrn = "B" Then
                                        If token.Length > 3 Then
                                            PrintMessage("Error at Line ", lineorg)
                                            Return i
                                        Else
                                            chrn = GetChar(token, 2)
                                            If chrn > "0" And chrn <= "9" Then
                                                pin(x) = "B" & chrn
                                                If token.Length > 2 Then
                                                    chrn = GetChar(betw, 3)
                                                    If chrn >= "0" And chrn < "3" And pin(x) = "B1" Then
                                                        pin(x) &= chrn
                                                    Else
                                                        PrintMessage("Error at Line ", lineorg)
                                                        Return i
                                                    End If
                                                End If
                                            Else
                                                PrintMessage("Error at Line ", lineorg)
                                                Return i
                                            End If
                                        End If
                                    Else
                                        PrintMessage("Error at Line ", lineorg)
                                        Return i
                                    End If
                                End If
                            Next
                            If clsFF3x_API.SetSPIPins(ConvertPinName2PinBlock(pin(0)), ConvertPinName2PinNumber(pin(0)), _
                                ConvertPinName2PinBlock(pin(1)), ConvertPinName2PinNumber(pin(1)), _
                                ConvertPinName2PinBlock(pin(2)), ConvertPinName2PinNumber(pin(2)), _
                                ConvertPinName2PinBlock(pin(3)), ConvertPinName2PinNumber(pin(3)), _
                                bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            End If
                        Case "WRITE"
                            If post = 0 Then
                                PrintMessage("Error at Line ", lineorg)
                            Else
                                betw = Trim(betw.Substring(post + 1))
                                Dim type As String = "D"
                                post = betw.IndexOf("""")
                                If post >= 0 Then type = "S"
                                If betw.Length > 1 Then chrn = GetChar(betw, 2)
                                If chrn = " " And GetChar(betw, 1) > "@" Then
                                    type = GetChar(betw, 1)
                                    betw = betw.Substring(2)
                                End If
                                DoPrint(type.ToUpper, Trim(betw), 1)
                            End If
                        Case "READ"
                            Dim bfr As String
                            betw = Trim(betw.Substring(post + 1))
                            post = betw.IndexOf(" ")
                            If post < 1 Then
                                PrintMessage("Error at Line ", lineorg)
                                Return i
                            End If
                            Dim len As String = Trim(betw.Substring(0, post))
                            betw = Trim(betw.Substring(post + 1))
                            post = betw.IndexOf(" ")
                            If post < 1 Then
                                bfr = betw
                                betw = ""
                            Else
                                bfr = Trim(betw.Substring(0, post))
                                betw = Trim(betw.Substring(post + 1))
                            End If
                            If readbfr(len, bfr, betw, 1) = False Then PrintMessage("Error at Line ", lineorg)
                        Case Else
                            PrintMessage("Error at Line ", lineorg)
                    End Select
                End If
            Case "I2C"
                If post = 0 Then
                    PrintMessage("Error at Line ", lineorg)
                Else
                    betw = Trim(lineorg.Substring(post + 1))
                    post = betw.IndexOf(" ")
                    If post < 1 Then
                        PrintMessage("Error at Line ", lineorg)
                    Else
                        token = betw.Substring(0, post).ToUpper
                    End If
                    Select Case token
                        Case "SET"
                            Dim pin(2) As String
                            For x As Integer = 0 To 1
                                betw = Trim(betw.Substring(post + 1)).ToUpper
                                post = betw.IndexOf(" ")
                                If post > 1 Then
                                    token = betw.Substring(0, post)
                                ElseIf x = 1 Then
                                    token = betw
                                Else
                                    PrintMessage("Error at Line ", lineorg)
                                    Return i
                                End If
                                If token.Length < 2 Then
                                    PrintMessage("Error at Line ", lineorg)
                                    Return i
                                Else
                                    chrn = GetChar(token, 1)
                                    If chrn = "A" Then
                                        If token.Length > 2 Then
                                            PrintMessage("Error at Line ", lineorg)
                                            Return i
                                        Else
                                            chrn = GetChar(token, 2)
                                            If chrn > "0" And chrn < "7" Then
                                                pin(x) = "A" & chrn
                                            Else
                                                PrintMessage("Error at Line ", lineorg)
                                                Return i
                                            End If
                                        End If
                                    ElseIf chrn = "B" Then
                                        If token.Length > 3 Then
                                            PrintMessage("Error at Line ", lineorg)
                                            Return i
                                        Else
                                            chrn = GetChar(token, 2)
                                            If chrn > "0" And chrn <= "9" Then
                                                pin(x) = "B" & chrn
                                                If token.Length > 2 Then
                                                    chrn = GetChar(betw, 3)
                                                    If chrn >= "0" And chrn < "3" And pin(x) = "B1" Then
                                                        pin(x) &= chrn
                                                    Else
                                                        PrintMessage("Error at Line ", lineorg)
                                                        Return i
                                                    End If
                                                End If
                                            Else
                                                PrintMessage("Error at Line ", lineorg)
                                                Return i
                                            End If
                                        End If
                                    Else
                                        PrintMessage("Error at Line ", lineorg)
                                        Return i
                                    End If
                                End If
                            Next
                            If clsFF3x_API.SetI2CPins(ConvertPinName2PinBlock(pin(0)), ConvertPinName2PinNumber(pin(0)), _
                                ConvertPinName2PinBlock(pin(1)), ConvertPinName2PinNumber(pin(1)), _
                                bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            End If
                        Case "WRITE"
                            If post = 0 Then
                                PrintMessage("Error at Line ", lineorg)
                            Else
                                betw = Trim(betw.Substring(post + 1))
                                Dim type As String = "D"
                                post = betw.IndexOf("""")
                                If post >= 0 Then type = "S"
                                If betw.Length > 1 Then chrn = GetChar(betw, 2)
                                If chrn = " " And GetChar(betw, 1) > "@" Then
                                    type = GetChar(betw, 1)
                                    betw = betw.Substring(2)
                                End If
                                DoPrint(type.ToUpper, Trim(betw), 2)
                            End If
                        Case "READ"
                            Dim bfr As String
                            betw = Trim(betw.Substring(post + 1))
                            post = betw.IndexOf(" ")
                            If post < 1 Then
                                PrintMessage("Error at Line ", lineorg)
                                Return i
                            End If
                            Dim len As String = Trim(betw.Substring(0, post))
                            betw = Trim(betw.Substring(post + 1))
                            post = betw.IndexOf(" ")
                            If post < 1 Then
                                bfr = betw
                                betw = ""
                            Else
                                bfr = Trim(betw.Substring(0, post))
                                betw = Trim(betw.Substring(post + 1))
                            End If
                            If readbfr(len, bfr, betw, 2) = False Then PrintMessage("Error at Line ", lineorg)
                        Case Else
                            PrintMessage("Error at Line ", lineorg)
                    End Select
                End If
            Case "1WIRE"
                If post = 0 Then
                    PrintMessage("Error at Line ", lineorg)
                Else
                    betw = Trim(lineorg.Substring(post + 1))
                    post = betw.IndexOf(" ")
                    If betw.ToUpper = "RESET" Then post = 5
                    If post < 1 Then
                        PrintMessage("Error at Line ", lineorg)
                    Else
                        token = betw.Substring(0, post).ToUpper
                    End If
                    Select Case token
                        Case "SET"
                            Dim pin As String
                            token = Trim(betw.Substring(post + 1)).ToUpper
                            If token.Length < 2 Then
                                PrintMessage("Error at Line ", lineorg)
                                Return i
                            Else
                                chrn = GetChar(token, 1)
                                If chrn = "A" Then
                                    If token.Length > 2 Then
                                        PrintMessage("Error at Line ", lineorg)
                                        Return i
                                    Else
                                        chrn = GetChar(token, 2)
                                        If chrn > "0" And chrn < "7" Then
                                            pin = "A" & chrn
                                        Else
                                            PrintMessage("Error at Line ", lineorg)
                                            Return i
                                        End If
                                    End If
                                ElseIf chrn = "B" Then
                                    If token.Length > 3 Then
                                        PrintMessage("Error at Line ", lineorg)
                                        Return i
                                    Else
                                        chrn = GetChar(token, 2)
                                        If chrn > "0" And chrn <= "9" Then
                                            pin = "B" & chrn
                                            If token.Length > 2 Then
                                                chrn = GetChar(token, 3)
                                                If chrn >= "0" And chrn < "3" And pin = "B1" Then
                                                    pin &= chrn
                                                Else
                                                    PrintMessage("Error at Line ", lineorg)
                                                    Return i
                                                End If
                                            End If
                                        Else
                                            PrintMessage("Error at Line ", lineorg)
                                            Return i
                                        End If
                                    End If
                                Else
                                    PrintMessage("Error at Line ", lineorg)
                                    Return i
                                End If
                            End If
                            If clsFF3x_API.Set1WirePin(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), _
                                bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            End If
                        Case "WRITE"
                            If post = 0 Then
                                PrintMessage("Error at Line ", lineorg)
                            Else
                                betw = Trim(betw.Substring(post + 1))
                                Dim type As String = "D"
                                post = betw.IndexOf("""")
                                If post >= 0 Then type = "S"
                                If betw.Length > 1 Then chrn = GetChar(betw, 2)
                                If chrn = " " And GetChar(betw, 1) > "@" Then
                                    type = GetChar(betw, 1)
                                    betw = betw.Substring(2)
                                End If
                                DoPrint(type.ToUpper, Trim(betw), 3)
                            End If
                        Case "WRITEB"
                            betw = Trim(betw.Substring(post + 1)).ToUpper
                            chrn = "T"
                            Dim pin As Integer = Math.Abs(GetExpression(betw, chrn))
                            If chrn = "E" Then PrintMessage("Error at Line ", lineorg)
                            If pin <> 0 And pin <> 1 Then
                                If pin < (volt / 2) Then
                                    pin = 0
                                Else
                                    pin = 1
                                End If
                            End If
                            If clsFF3x_API.WriteBit1Wire(CByte(pin), bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            End If
                        Case "READ"
                            Dim bfr As String
                            betw = Trim(betw.Substring(post + 1))
                            post = betw.IndexOf(" ")
                            If post < 1 Then
                                PrintMessage("Error at Line ", lineorg)
                                Return i
                            End If
                            Dim len As String = Trim(betw.Substring(0, post))
                            betw = Trim(betw.Substring(post + 1))
                            post = betw.IndexOf(" ")
                            If post < 1 Then
                                bfr = betw
                                betw = ""
                            Else
                                bfr = Trim(betw.Substring(0, post))
                                betw = Trim(betw.Substring(post + 1))
                            End If
                            If readbfr(len, bfr, betw, 3) = False Then PrintMessage("Error at Line ", lineorg)
                        Case "READB"
                            If clsFF3x_API.ReadBit1Wire(bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            Else
                                betw = Trim(betw.Substring(post + 1)).ToUpper
                                If line.Length < 2 Then
                                    PrintMessage("Error at Line ", lineorg)
                                Else
                                    chrn = GetChar(betw, 1)
                                    If chrn = "S" Then
                                        token = "S"
                                    Else
                                        PrintMessage("Error at Line ", lineorg)
                                        Return 1
                                    End If
                                    chrn = GetChar(betw, 2)
                                    If chrn < "1" And chrn > "9" Then
                                        PrintMessage("Error at Line ", lineorg)
                                        Return 1
                                    Else
                                        token &= chrn
                                        betw = (bytResponse(1)).ToString
                                        SetS(token, betw)
                                    End If
                                End If
                            End If
                        Case "RESET"
                            If clsFF3x_API.Reset1Wire(bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            Else
                                betw = Trim(betw.Substring(post + 1)).ToUpper
                                If line.Length < 2 Then
                                    PrintMessage("Error at Line ", lineorg)
                                Else
                                    chrn = GetChar(betw, 1)
                                    If chrn = "S" Then
                                        token = "S"
                                    Else
                                        PrintMessage("Error at Line ", lineorg)
                                        Return 1
                                    End If
                                    chrn = GetChar(betw, 2)
                                    If chrn < "1" And chrn > "9" Then
                                        PrintMessage("Error at Line ", lineorg)
                                        Return 1
                                    Else
                                        token &= chrn
                                        betw = (bytResponse(1)).ToString
                                        SetS(token, betw)
                                    End If
                                End If
                            End If
            Case Else
                PrintMessage("Error at Line ", lineorg)
        End Select
                End If
            Case "IF"
                If post = 0 Then
                    PrintMessage("Error at Line ", lineorg)
                Else
                    betw = Trim(lineorg.Substring(post + 1))
                    chrn = GetChar(betw, 1)
                    If chrn = "{" Then
                        betw = Trim(betw.Substring(1))
                        Dim pos As Integer = betw.IndexOf("}")
                        If pos > 0 Then
                            Dim cond As String = Trim(betw.Substring(0, pos))
                            betw = Trim(betw.Substring(pos + 1))
                            If betw.Length < 1 Then
                                PrintMessage("Error at Line ", lineorg)
                            Else
                                chrn = "T"
                                DoIf(cond.ToUpper, betw, chrn, i)
                                If chrn = "E" Then PrintMessage("Error at Line ", lineorg)
                            End If
                        Else : PrintMessage("Error at Line ", lineorg)
                        End If
                    Else : PrintMessage("Error at Line ", lineorg)
                    End If
                End If
            Case "DO"
                If adddress = -1 Then
                    adddress = i
                Else
                    PrintMessage("Error at Line ", lineorg)
                End If
            Case "LOOP"
                If adddress = -1 Then
                    PrintMessage("Error at Line ", lineorg)
                End If
                If post = 0 Then
                    i = adddress
                Else
                    betw = Trim(line.Substring(post + 1))
                    post = betw.IndexOf(" ")
                    If post < 1 Then
                        token = ""
                        post = 0
                    Else
                        token = betw.Substring(0, post)
                    End If
                    If token = "UNTIL" Then
                        betw = Trim(betw.Substring(post + 1))
                        chrn = GetChar(betw, 1)
                        If chrn = "{" Then
                            betw = Trim(betw.Substring(1))
                            Dim pos As Integer = betw.IndexOf("}")
                            If pos > 0 Then
                                Dim cond As String = Trim(betw.Substring(0, pos))
                                betw = Trim(betw.Substring(pos + 1))
                                Dim co As Boolean = GetCondition(cond, chrn)
                                If chrn = "E" Then PrintMessage("Error at Line ", lineorg)
                                If co Then
                                    adddress = -1
                                Else
                                    i = adddress
                                End If
                            Else : PrintMessage("Error at Line ", lineorg)
                            End If
                        Else : PrintMessage("Error at Line ", lineorg)
                        End If
                    Else
                        If Count < 0 Then
                            Dim tst As Char = "T"c
                            Count = Math.Abs(CInt(GetExpression(betw, tst)))
                            If tst = "E" Then PrintMessage("Error at Line ", lineorg)
                            If Count > 0 Then i = adddress
                            Count = Count - 1
                        Else
                            Count = Count - 1
                            If Count >= 0 Then
                                i = adddress
                            Else : adddress = -1
                            End If
                        End If
                    End If
                End If
            Case "END"
                If adddress = -1 Then
                    i = Document.Lines.Length + 1
                Else
                    Dim Sloop As String
                    adddress = -1
                    Count = -1
                    For x As Integer = i To Document.Lines.Length
                        Sloop = Trim(Document.Lines(x)).ToUpper
                        If Sloop.Length > 3 Then Sloop = Sloop.Substring(0, 4)
                        If Sloop = "LOOP" Then
                            i = x + 1
                            Exit For
                        End If
                    Next
                End If
            Case Else
                PrintMessage("Error at Line ", lineorg)
        End Select
            Return i

    End Function

    Private Function readbfr(len As String, bfr As String, rest As String, sel As Integer) As Boolean
        readbfr = False
        Dim value As String = ""
        Dim tok As Char = "T"c
        Dim tot As Integer = GetExpression(len, tok)
        If tok = "E" Then Return False
        If tot > 60 Then tot = 60
        Dim ishex As Integer = rest.IndexOf("[")
        Dim lst As Integer = rest.IndexOf("]")
        If ishex >= 0 And lst >= 0 Then rest = Trim(rest.Substring(ishex + 1, lst - 1)).ToUpper
        lst = rest.Length
        If ishex >= 0 Then lst = lst \ 2
        Dim i As Integer
        If rest <> "" And ishex < 0 Then value = GetString(rest, tok)
        If tok = "E" Then Return False
        If value.Length > 60 Then value = value.Substring(0, 60)
        Dim encText As New System.Text.UTF8Encoding()
        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(value)
        Dim bytData(lst) As Byte
        If ishex < 0 Then
            For i = 0 To bytContent.Length - 1     ' fill data payload
                bytData(i) = bytContent(i)
            Next
        Else
            If rest.Length Mod 2 = 0 Then
                lst -= 1
            Else
                rest = "0" & rest
            End If
            For i = 0 To lst    ' fill data payload
                bytData(i) = Convert.ToByte(rest.Substring(i * 2, 2), 16)
            Next
        End If
        Select Case sel
            Case 1
                If clsFF3x_API.ReadSPI(CByte(bytData.Length - 1), CByte(tot), bytData, bytResponse) = False Then
                    PrintMessage("Error", clsFF3x_API.LastError)
                End If
            Case 2
                If clsFF3x_API.ReadI2C(CByte(bytData.Length - 1), CByte(tot), bytData, bytResponse) = False Then
                    PrintMessage("Error", clsFF3x_API.LastError)
                End If
            Case 3
                If clsFF3x_API.Read1Wire(CByte(bytData.Length - 1), CByte(tot), bytData, bytResponse) = False Then
                    PrintMessage("Error", clsFF3x_API.LastError)
                End If
        End Select
        tot -= 1
        Select Case bfr.ToUpper
            Case "BUFFA"
                For i = 2 To bytResponse.Length - 2
                    bytResponse(i - 2) = bytResponse(i)
                Next
                buffa = bytResponse
                bla = tot
            Case "BUFFB"
                For i = 2 To bytResponse.Length - 2
                    bytResponse(i - 2) = bytResponse(i)
                Next
                buffb = bytResponse
                blb = tot
            Case "BUFFC"
                For i = 2 To bytResponse.Length - 2
                    bytResponse(i - 2) = bytResponse(i)
                Next
                buffc = bytResponse
                blc = tot
            Case "BUFFD"
                For i = 2 To bytResponse.Length - 2
                    bytResponse(i - 2) = bytResponse(i)
                Next
                buffd = bytResponse
                bld = tot
        End Select
        For i = 2 To bytResponse.Length - 2
            txtResultSPI.Text &= (Convert.ToString(bytResponse(i), 16).PadLeft(2, "0"c)).ToUpper
        Next
        Return True
    End Function

    Private Function Setport(token As String, line As String) As Boolean
        Dim tst As Char = "T"c
        Dim pin As Integer = Math.Abs(GetExpression(line, tst))
        If tst = "E" Then
            Return False
        Else
            If pin <> 0 And pin <> 1 Then
                If pin < (volt / 2) Then
                    pin = 0
                Else
                    pin = 1
                End If
            End If
        End If
        If clsFF3x_API.SetDigitalOutput(ConvertPinName2PinBlock(token), ConvertPinName2PinNumber(token), CByte(pin), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        Return True
    End Function

    Private Function Setportblk(token As String, line As String) As Boolean
        Dim pos As Integer = line.IndexOf(" ")
        If pos < 1 Then
            Return False
        Else
            Dim pin As Byte = 10
            If token = "B" Then pin = 11
            Dim smask As String = line.Substring(0, pos)
            Dim sstate As String = line.Substring(pos + 1)
            Dim tst As Char = "T"c
            Dim mask As Integer = Math.Abs(CInt(GetExpression(smask, tst)))
            If tst = "E" Then Return False
            tst = "T"c
            Dim state As Integer = Math.Abs(CInt(GetExpression(sstate, tst)))
            If tst = "E" Then Return False
            Dim amask(2), astate(2) As Byte
            amask(1) = CByte(mask And 255)
            amask(0) = CByte(mask >> 8)
            astate(1) = CByte(state And 255)
            astate(0) = CByte(state >> 8)
            If clsFF3x_API.SetBlockDigitalOutputs(pin, amask, astate, bytResponse) = False Then
                PrintMessage("Error", clsFF3x_API.LastError)
            End If
            Return True
        End If
    End Function

    Private Function SetS(token As String, line As String) As Boolean
        Dim tst As Char = "T"c
        Dim val As Double = GetExpression(line, tst)
        Select Case token
            Case "S1"
                S1 = val
                Return True
            Case "S2"
                S2 = val
                Return True
            Case "S3"
                S3 = val
                Return True
            Case "S4"
                S4 = val
                Return True
            Case "S5"
                S5 = val
                Return True
            Case "S6"
                S6 = val
                Return True
            Case "S7"
                S7 = val
                Return True
            Case "S8"
                S8 = val
                Return True
            Case "S9"
                S9 = val
                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Sub DoSleep(msec As Integer)
        Do
            If msec <= 1000 Then
                If msec = 0 Then Return
                Thread.Sleep(msec)
                Return
            Else
                Thread.Sleep(1000)
                msec = msec - 1000
                If BackgroundWorker1.CancellationPending Then
                    Exit Do
                End If
            End If
        Loop
    End Sub

    Private Function SetBuff(token As String, line As String) As Boolean
        Dim tok As Char = "T"c
        Dim value As String = ""
        Dim ishex As Integer = line.IndexOf("[")
        Dim lst As Integer = line.IndexOf("]")
        If ishex >= 0 And lst >= 0 Then line = Trim(line.Substring(ishex + 1, lst - 1)).ToUpper
        lst = line.Length
        If ishex >= 0 Then lst = lst \ 2
        Dim i As Integer
        If ishex < 0 Then value = GetString(line, tok)
        If tok = "E" Then Return False
        If value.Length > 60 Then value = value.Substring(0, 60)
        Dim encText As New System.Text.UTF8Encoding()
        Select Case token
            Case "A"
                If ishex < 0 Then
                    buffa = encText.GetBytes(value)
                    bla = value.Length - 1
                Else
                    If line.Length Mod 2 = 0 Then
                        lst -= 1
                    Else
                        line = "0" & line
                    End If
                    For i = 0 To lst
                        buffa(i) = Convert.ToByte(line.Substring(i * 2, 2), 16)
                    Next
                    bla = lst
                End If
            Case "B"
                If ishex < 0 Then
                    buffb = encText.GetBytes(value)
                    blb = value.Length - 1
                Else
                    If line.Length Mod 2 = 0 Then
                        lst -= 1
                    Else
                        line = "0" & line
                    End If
                    For i = 0 To lst
                        buffb(i) = Convert.ToByte(line.Substring(i * 2, 2), 16)
                    Next
                    blb = lst
                End If
            Case "C"
                If ishex < 0 Then
                    buffc = encText.GetBytes(value)
                    blc = value.Length - 1
                Else
                    If line.Length Mod 2 = 0 Then
                        lst -= 1
                    Else
                        line = "0" & line
                    End If
                    For i = 0 To lst
                        buffc(i) = Convert.ToByte(line.Substring(i * 2, 2), 16)
                    Next
                    blc = lst
                End If
            Case "D"
                If ishex < 0 Then
                    buffd = encText.GetBytes(value)
                    bld = value.Length - 1
                Else
                    If line.Length Mod 2 = 0 Then
                        lst -= 1
                    Else
                        line = "0" & line
                    End If
                    For i = 0 To lst
                        buffd(i) = Convert.ToByte(line.Substring(i * 2, 2), 16)
                    Next
                    bld = lst
                End If
            Case Else
                Return False
        End Select
        Return True
    End Function

    Private Function SetBuffIDX(token As String, numb As String, line As String) As Boolean
        Dim tst As Char = "T"c
        Dim val As Byte = Math.Abs(CByte(GetExpression(line, tst)))
        If numb > 60 Then Return False
        If tst = "E" Then Return False
        Select Case token
            Case "A"
                '                If bla < numb Then buffa.Length = numb
                buffa(numb) = val
                If bla < numb Then bla = numb
            Case "B"
                buffb(numb) = val
                If blb < numb Then blb = numb
            Case "C"
                buffc(numb) = val
                If blc < numb Then blc = numb
            Case "D"
                buffd(numb) = val
                If bld < numb Then bld = numb
            Case Else
                Return False
        End Select
        Return True
    End Function

    Private Sub WriteFile(fname As String, buff As String)
        Dim tok As Char = "T"c
        If fname.IndexOf("""") >= 0 Then fname = GetString(fname, tok)
        If tok = "E" Then Return
        Dim fs As New FileStream(fname, FileMode.Create, FileAccess.ReadWrite)
        Dim bw As New BinaryWriter(fs)
        Dim i As Integer
        Select Case buff
            Case "A"
                For i = 0 To bla - 1
                    bw.Write(buffa(i))
                Next
            Case "B"
                For i = 0 To blb - 1
                    bw.Write(buffb(i))
                Next
            Case "C"
                For i = 0 To blc - 1
                    bw.Write(buffc(i))
                Next
            Case "D"
                For i = 0 To bld - 1
                    bw.Write(buffd(i))
                Next
        End Select
        bw.Flush()
        bw.Close()
        fs.Close()
    End Sub

    Private Sub ReadFile(fname As String, buff As String)
        Dim tok As Char = "T"c
        If fname.IndexOf("""") >= 0 Then fname = GetString(fname, tok)
        If tok = "E" Then Return
        If File.Exists(fname) = False Then Return
        Dim fs As New FileStream(fname, FileMode.Open, FileAccess.Read)
        If fs.Length > 60 Then Return
        Dim bw As New BinaryReader(fs)
        Dim le As Integer = fs.Length
        Select Case buff
            Case "A"
                buffa = bw.ReadBytes(60)
                bla = le
            Case "B"
                buffb = bw.ReadBytes(60)
                bld = le
            Case "C"
                buffc = bw.ReadBytes(60)
                blc = le
            Case "D"
                buffd = bw.ReadBytes(60)
                bld = le
        End Select
        bw.Close()
        fs.Close()
    End Sub

    Private Sub DoPrint(type As String, line As String, sel As Integer)
        Dim token As String = ""
        Dim chrn As Char
        Dim ishex As Integer = line.IndexOf("[")
        Dim lst As Integer = line.IndexOf("]")
        If ishex >= 0 And lst >= 0 Then
            line = Trim(line.Substring(ishex + 1, lst - 1)).ToUpper
            type = "S"
        End If
        chrn = "T"c
        Select Case type
            Case "D"
                token = GetExpression(line.ToUpper, chrn).ToString
                If chrn = "E" Then
                    PrintMessage("Error", line)
                    Return
                End If
            Case "X"
                Dim val As Double = Math.Abs(CInt(GetExpression(line.ToUpper, chrn)))
                If chrn = "E" Then
                    PrintMessage("Error", line)
                    Return
                Else
                    token = Hex(val)
                End If
            Case "N"
                Dim val As Integer = Math.Abs(CInt(GetExpression(line.ToUpper, chrn)))
                If chrn = "E" Then
                    PrintMessage("Error", line)
                    Return
                Else
                    token = Convert.ToString(val, 2)
                End If
            Case "S"
                If ishex < 0 Then
                    token = GetString(line, chrn)
                    If chrn = "E" Then
                        PrintMessage("Error", line)
                        Return
                    End If
                Else
                    token = line
                End If
            Case Else
                token = GetString(line, chrn)
                If chrn = "E" Then
                    PrintMessage("Error", line)
                    Return
                End If
        End Select
        Dim bytContent() As Byte = System.Text.Encoding.UTF8.GetBytes(token)
        lst = bytContent.Length
        If ishex >= 0 Then lst = token.Length \ 2
        Dim bytData(lst) As Byte
        Dim i As Integer
        If ishex < 0 Then
            For i = 0 To bytContent.Length - 1     ' fill data payload
                bytData(i) = bytContent(i)
            Next
        Else
            If token.Length Mod 2 = 0 Then
                lst -= 1
            Else
                token = "0" & token
            End If
            For i = 0 To lst    ' fill data payload
                bytData(i) = Convert.ToByte(token.Substring(i * 2, 2), 16)
            Next
        End If
        Select Case sel
            Case 0
                PrintMessage("> ", token)
            Case 1
                If clsFF3x_API.WriteSPI(CByte(bytData.Length - 1), bytData, bytResponse) = False Then
                    PrintMessage("Error", clsFF3x_API.LastError)
                End If
            Case 2
                If clsFF3x_API.WriteI2C(CByte(bytData.Length - 1), bytData, bytResponse) = False Then
                    PrintMessage("Error", clsFF3x_API.LastError)
                End If
            Case 3
                If clsFF3x_API.Write1Wire(CByte(bytData.Length - 1), bytData, bytResponse) = False Then
                    PrintMessage("Error", clsFF3x_API.LastError)
                End If
        End Select
    End Sub

    Private Function DoWait(pin As String, line As String) As Boolean

        Dim comper As String
        Dim chrn As Char
        Dim timeout As Integer = 60000
        If line.Length < 1 Then Return False
        chrn = GetChar(line, 1)
        If chrn <> "0" And chrn <> "1" Then Return False
        comper = chrn
        line = line.Substring(1)
        If line.Length > 1 Then
            chrn = "T"c
            timeout = GetExpression(line, chrn)
            If chrn = "E" Then Return False
        End If
        Do
            If clsFF3x_API.GetDigitalInput(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), bytResponse) = False Then
                PrintMessage("Error", clsFF3x_API.LastError)
            Else
                If comper = (bytResponse(1)).ToString Then Return True
            End If
            If BackgroundWorker1.CancellationPending Then Return False

            Thread.Sleep(1)

            timeout -= 1

            If timeout < 1 Then Return True

        Loop

        Return True
    End Function

    Private Function SetPWM(pin As String, line As String) As Boolean
        Dim tst As Char = "T"c
        Dim procent As Integer = Math.Abs(GetExpression(line, tst))
        If tst = "E" Then Return False
        If procent > 100 Then procent = 100
        If clsFF3x_API.SetPWMOutput(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), CByte(procent), bytResponse) = False Then
            PrintMessage("Error", clsFF3x_API.LastError)
        End If
        Return True
    End Function

    Private Function GetCondition(cond As String, ByRef tok As Char) As Boolean
        Dim pos As Integer = cond.IndexOf("=")
        If pos < 1 Then pos = cond.IndexOf("<")
        If pos < 1 Then pos = cond.IndexOf(">")
        tok = "E"
        If pos < 1 Then Return False
        Dim chrn = GetChar(cond, pos + 1)
        Dim expr1 As String = Trim(cond.Substring(0, pos))
        Dim expr2 As String = Trim(cond.Substring(pos + 1))
        tok = "T"
        Dim res1 As Double = GetExpression(expr1, tok)
        If tok = "E" Then Return False
        Dim res2 As Double = GetExpression(expr2, tok)
        If tok = "E" Then Return False
        Select Case chrn
            Case "="c
                Return res1 = res2
            Case "<"c
                Return res1 < res2
            Case ">"c
                Return res1 > res2
            Case Else
                tok = "E"
                Return False
        End Select
    End Function

    Private Sub DoIf(cond As String, line As String, ByRef tok As Char, ByRef i As Integer)
        Dim doit As Boolean = GetCondition(cond, tok)
        If tok = "E" Then Return
        If doit Then
            i = EvalFF3(line, i - 1)
        End If
    End Sub

    Private Function GetNumber(ByRef line As String, ByRef tkne As Char) As Double
        GetNumber = 0
        Dim token As String = ""
        Dim dblValue As Double = 0
        Dim pos As Integer = 2000
        Dim ps As Integer = 0
        Dim chrnst As Char
        Dim tokens() As Char = {"*"c, "/"c, "+"c, "-"c, "%"c, "^"c, "&"c, "|"c}
        Dim Numb As String = ""
        line = line.Replace(" ", "")
        For x As Integer = 0 To 7
            ps = line.IndexOf(tokens(x))
            If ps < pos And ps >= 0 Then
                pos = ps
                tkne = tokens(x)
            End If
        Next
        If pos = 2000 Then
            Numb = line
            line = ""
        Else
            Numb = Trim(line.Substring(0, pos))
            line = Trim(line.Substring(pos + 1))
        End If
        If Numb.Length > 4 Then token = Trim(Numb.Substring(0, 4))
        If token = "BUFF" Then
            token = Trim(Numb.Substring(4))
            chrnst = GetChar(token, 1)
            token = Trim(Numb.Substring(5))
            If chrnst >= "A" And chrnst < "E" Then
                Numb = chrnst
                chrnst = GetChar(token, 1)
                If chrnst = "(" Then
                    token = Trim(token.Substring(1))
                    pos = token.IndexOf(")")
                    If pos > 0 Then
                        Dim idx As Integer = Trim(token.Substring(0, pos))
                        Select Case Numb
                            Case "A"
                                Return buffa(idx)
                            Case "B"
                                Return buffb(idx)
                            Case "C"
                                Return buffc(idx)
                            Case "D"
                                Return buffd(idx)
                        End Select
                    End If
                End If
            End If
        End If
        chrnst = GetChar(Numb, 1)
        Select Case chrnst
            Case "S"c
                If Numb.Length = 2 Then
                    chrnst = GetChar(Numb, 2)
                    Select Case chrnst
                        Case "1"c
                            Return (S1)
                        Case "2"c
                            Return (S2)
                        Case "3"c
                            Return (S3)
                        Case "4"c
                            Return (S4)
                        Case "5"c
                            Return (S5)
                        Case "6"c
                            Return (S6)
                        Case "7"c
                            Return (S7)
                        Case "8"c
                            Return (S8)
                        Case "9"c
                            Return (S9)
                        Case Else
                            tkne = "E"c
                            Return 0
                    End Select
                End If
            Case "X"c
                Numb = Numb.Substring(1)
                Dim myRegex As New Regex("^[a-fA-F0-9]+$")
                If myRegex.IsMatch(Numb) Then
                    Return (Int32.Parse(Numb, System.Globalization.NumberStyles.HexNumber))
                End If
            Case "N"c
                Numb = Numb.Substring(1)
                Dim myRegex As New Regex("^[0-1]+$")
                If myRegex.IsMatch(Numb) Then
                    Dim dig As String, p As Integer
                    Dim dec, B, d As Double
                    p = 0
                    For x As Integer = Numb.Length - 1 To 0 Step -1
                        dig = Numb.Substring(x, 1)
                        Double.TryParse(dig, B)
                        d = B * (2 ^ p)
                        dec = dec + d
                        p = p + 1
                    Next x
                    Return dec
                End If
            Case "V"c
                Return volt
            Case "B"c
                Dim pin As String
                If Numb.Length > 1 Then
                    chrnst = GetChar(Numb, 2)
                    If chrnst = "A" Then
                        If Numb.Length > 2 Then chrnst = GetChar(Numb, 3)
                        If chrnst > "0" And chrnst <= "9" Then
                            pin = "B" & chrnst
                            If Numb.Length > 3 Then
                                chrnst = GetChar(Numb, 4)
                                If chrnst >= "0" And chrnst < "3" And pin = "B1" Then
                                    pin &= chrnst
                                    clsFF3x_API.GetAnalogInput(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), bytResponse)

                                    dblValue = (((bytResponse(2) * 256) + bytResponse(3)) / 1023)

                                    If bytResponse(1) = CByte(&H33) Then
                                        dblValue *= 3.3
                                    Else
                                        dblValue *= 5
                                    End If
                                    Numb = dblValue.ToString("F3")
                                    Return Convert.ToDouble(Numb)
                                End If
                            End If
                            clsFF3x_API.GetAnalogInput(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), bytResponse)

                            dblValue = (((bytResponse(2) * 256) + bytResponse(3)) / 1023)

                            If bytResponse(1) = CByte(&H33) Then
                                dblValue *= 3.3
                            Else
                                dblValue *= 5
                            End If
                            Numb = dblValue.ToString("F3")
                            Return Convert.ToDouble(Numb)
                        End If
                    ElseIf chrnst = "B" Then
                        Dim bytBlock = CByte(&HB)
                        Numb = Numb.Substring(2)
                        Dim bytMask(1) As Byte
                        Dim intMask As Integer = GetNumber(Numb, tkne)
                        bytMask(0) = CByte(CInt(intMask \ 256))
                        bytMask(1) = CByte(intMask And 255)
                        If clsFF3x_API.GetBlockDigitalInputs(bytBlock, bytMask, bytResponse) = False Then
                            PrintMessage("Error", clsFF3x_API.LastError)
                        Else
                            Return bytResponse(1) * 256 + bytResponse(2)
                        End If
                    ElseIf chrnst > "0" And chrnst <= "9" Then
                        pin = "B" & chrnst
                        If Numb.Length > 2 Then
                            chrnst = GetChar(Numb, 3)
                            If chrnst >= "0" And chrnst < "3" And pin = "B1" Then
                                pin &= chrnst
                            End If
                            If clsFF3x_API.GetDigitalInput(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            Else
                                Return Convert.ToDouble(bytResponse(1).ToString)
                            End If
                        Else
                            If clsFF3x_API.GetDigitalInput(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), bytResponse) = False Then
                                PrintMessage("Error", clsFF3x_API.LastError)
                            Else
                                Return Convert.ToDouble(bytResponse(1).ToString)
                            End If
                        End If
                    End If
                End If
            Case "A"c
                Dim pin As String
                If Numb.Length > 1 Then
                    chrnst = GetChar(Numb, 2)
                    If chrnst > "0" And chrnst <= "6" Then
                        pin = "A" & chrnst
                        If clsFF3x_API.GetDigitalInput(ConvertPinName2PinBlock(pin), ConvertPinName2PinNumber(pin), bytResponse) = False Then
                            PrintMessage("Error", clsFF3x_API.LastError)
                        Else
                            Return Convert.ToDouble(bytResponse(1).ToString)
                        End If
                    ElseIf chrnst = "B" Then
                        Dim bytBlock = CByte(&HA)
                        Numb = Numb.Substring(2)
                        Dim bytMask(1) As Byte
                        Dim intMask As Integer = GetNumber(Numb, tkne)
                        bytMask(0) = CByte(CInt(intMask \ 256))
                        bytMask(1) = CByte(intMask And 255)
                        If clsFF3x_API.GetBlockDigitalInputs(bytBlock, bytMask, bytResponse) = False Then
                            PrintMessage("Error", clsFF3x_API.LastError)
                        Else
                            Return bytResponse(1) * 256 + bytResponse(2)
                        End If
                    End If
                End If
            Case Else
                If IsNumeric(Numb) Then
                    Return Convert.ToDouble(Numb)
                End If
        End Select
        tkne = "E"c
        Return 0
    End Function

    Private Function GetString(line As String, ByRef tok As Char) As String
        GetString = ""
        Dim result As New StringBuilder
        Dim chrnst As Char
        Dim pos As Integer
        Dim value As Double
        Dim line2 As String = ""
        Do
            If line.Length > 4 Then line2 = Trim(line.Substring(0, 4)).ToUpper
            If line2 = "BUFF" Then
                chrnst = GetChar(line.ToUpper, 5)
                If chrnst >= "A" And chrnst < "E" Then
                    Select Case chrnst
                        Case "A"
                            result.Append(System.Text.UTF8Encoding.UTF8.GetString(buffa, 0, bla + 1))
                        Case "B"
                            result.Append(System.Text.UTF8Encoding.UTF8.GetString(buffb, 0, blb + 1))
                        Case "C"
                            result.Append(System.Text.UTF8Encoding.UTF8.GetString(buffc, 0, blc + 1))
                        Case "D"
                            result.Append(System.Text.UTF8Encoding.UTF8.GetString(buffd, 0, bld + 1))
                        Case Else
                            tok = "E"
                            Return ""
                    End Select
                    pos = line.IndexOf(",")
                    If pos < 1 Then
                        Return result.ToString
                    Else
                        line2 = line.Substring(0, pos).ToUpper
                        line = Trim(line.Substring(pos + 1))
                        If line.Length < 1 Then Return result.ToString
                        chrnst = GetChar(line, 1)
                        If chrnst = "," Then
                            line = Trim(line.Substring(1))
                        End If
                    End If
                Else
                    tok = "E"
                    Return ""
                End If
            Else
                tok = "T"c
                chrnst = GetChar(line, 1)
                If chrnst = """" Then
                    line = line.Substring(1)
                    pos = line.IndexOf("""")
                    If pos < 1 Then
                        tok = "E"c
                        Return ""
                    End If
                    result.Append(line.Substring(0, pos))
                    line = Trim(line.Substring(pos + 1))
                    If line.Length < 1 Then Return result.ToString
                    chrnst = GetChar(line, 1)
                    If chrnst = "," Then
                        line = Trim(line.Substring(1))
                    End If
                Else
                    pos = line.IndexOf(",")
                    If pos < 1 Then
                        value = GetExpression(line.ToUpper, tok)
                        If tok = "E" Then Return ""
                        result.Append(value.ToString)
                        Return result.ToString
                    Else
                        line2 = line.Substring(0, pos).ToUpper
                        value = GetExpression(line2, tok)
                        If tok = "E" Then Return ""
                        result.Append(value.ToString)
                        line = Trim(line.Substring(pos + 1))
                        If line.Length < 1 Then Return result.ToString
                        chrnst = GetChar(line, 1)
                        If chrnst = "," Then
                            line = Trim(line.Substring(1))
                        End If
                    End If
                End If
            End If
        Loop
    End Function

    Private Function GetExpression(line As String, ByRef tok As Char) As Double
        GetExpression = 0
        Dim Expr As String = ""
        Dim oper As String = tok
        Do
            tok = "T"c
            Expr &= GetNumber(line, tok).ToString
            If tok = "T" Then Exit Do
            If tok = "E" Then Return 0
            oper = tok
            If tok = "&" Then oper = "and"
            If tok = "|" Then oper = "or"
            If tok = "%" Then oper = "mod"
            Expr &= " " & oper & " "
        Loop
        Dim ScriptEngine As New MSScriptControl.ScriptControl
        ScriptEngine.Language = "VBScript"
        GetExpression = ScriptEngine.Eval(Expr)
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ToolStripButton1.Enabled = False
        RunToolStripMenuItem.Enabled = False
        StopToolStripMenuItem.Enabled = True
        tbRun.Enabled = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If Me.Document.Text = "" Then Return
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        Me.rtbStatus.Clear()
        Me.Count = -1
        Me.adddress = -1
        If Document.Text = "" Then Return
        Dim line As String
        Dim tot As Integer = Me.Document.Lines.Length
        Dim i As Integer = 0
        bla = 0
        blb = 0
        blc = 0
        bld = 0
        Me.Document.Enabled = False
        Do
            line = Trim(Me.Document.Lines(i))
            Try
                i = Me.EvalFF3(line, i)
            Catch ex As Exception
                PrintMessage("Error at Line ", Me.Document.Lines(i))
                i = i + 1
            End Try
            If BackgroundWorker1.CancellationPending Then
                e.Cancel = True
                Exit Do
            End If
        Loop Until i >= tot
        Me.Document.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ToolStripButton1.Enabled = True
        RunToolStripMenuItem.Enabled = True
        StopToolStripMenuItem.Enabled = False
        tbRun.Enabled = False
        Document.Enabled = True
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        clsFF3x_API.GetAnalogInput(ConvertPinName2PinBlock(cmbAnalogInPin.Text), ConvertPinName2PinNumber(cmbAnalogInPin.Text), bytResponse)

        Dim dblValue As Double = (((bytResponse(2) * 256) + bytResponse(3)) / 1023)
        If bytResponse(1) = CByte(&H33) Then
            dblValue *= 3.3
        Else
            dblValue *= 5
        End If
        txtAnalogInPinValue.Text = dblValue.ToString("F3") & "V"

        Chart1.Series("Series1").Points.AddY(dblValue)

        If Chart1.Series(0).Points.Count = 50 Then
            Chart1.Series(0).Points.RemoveAt(0)
        End If

        Timer1.Start()
    End Sub

    Private Sub SetFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetFontToolStripMenuItem.Click

        Try
            If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Document.ForeColor = FontDialog1.Color

                Document.Font = FontDialog1.Font
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try


    End Sub

    Private Sub CreateHEXFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateHEXFileToolStripMenuItem.Click
        EnterHex.Show()
    End Sub

    Private Sub mainMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mainMenu.ItemClicked

    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.ShowHelp(Me, Application.StartupPath & "\FF3xGui.chm")
    End Sub

    Private Sub HelpIndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpIndexToolStripMenuItem.Click
        Help.ShowHelpIndex(Me, Application.StartupPath & "\FF3xGui.chm")
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim tot As Integer = TotBytes.Text
        Panel10.Visible = False
        If openWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim pieces As Integer = ChopItUp(openWork.FileName, tot)
            MessageBox.Show("Done " & CStr(pieces) & " Files Created")
        End If
    End Sub

End Class


