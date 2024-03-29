﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim vpb_sy, vpb_ly As Integer
    Dim SpeedL, TempL, BattL As Integer
    Dim Speed, Batt, Temp, SpeedResult, BatteryResult, TempResult As String
    Dim StrSerialIn, StrSerialInRam As String
    Dim ChartLimit As Integer = 30
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ConnectionPanel.Focus()
        ComboBoxBaudRate.SelectedIndex = 0


        '-------------------creating default graph----------------------------------'
        For i = 0 To 30 Step 1
            ChartTemperature.Series("Temperature").Points.AddY(0)
            If ChartTemperature.Series(0).Points.Count = ChartLimit Then
                ChartTemperature.Series(0).Points.RemoveAt(0)
            End If
        Next
        '-----------------------------------------------------------------------------
        '------------------Labeling values of the graph-------------------------------'
        ChartTemperature.ChartAreas(0).AxisY.Maximum = 120
        ChartTemperature.ChartAreas(0).AxisY.Minimum = 0
        ChartTemperature.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = True
        '-----------------------------------------------------------------------------
    End Sub

    '================================ Connection Panel ======================================='
    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ConnectionPanel.Focus()
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to scan the new port.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ComboBoxPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub

    Private Sub ComboBoxPort_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPort.DropDown
        ConnectionPanel.Focus()
    End Sub

    Private Sub LinkLabel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LabelStatus.Click

    End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click

    End Sub

    Private Sub ChartTemperature_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxConnectionStatus.Click

    End Sub

    Private Sub ComboBoxPort_Click(sender As Object, e As EventArgs) Handles ComboBoxPort.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Connection in progress, please Disconnect to change COM.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub

    Private Sub ComboBoxBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub



    Private Sub ComboBoxBaudRate_DropDown(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.DropDown
        ConnectionPanel.Focus()
    End Sub


    Private Sub ComboBoxBaudRate_Click(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to change Baud Rate.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        ConnectionPanel.Focus()
        Try
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            SerialPort1.Open()
            TimerSerial.Start()

            LabelStatus.Text = "Status : Connected"
            ButtonConnect.SendToBack()
            ButtonDisconnect.BringToFront()
            PictureBoxConnectionStatus.BackColor = Color.Green
        Catch ex As Exception
            MsgBox("Please check the Hardware, COM, Baud Rate and try again.", MsgBoxStyle.Critical, "Connection failed !!!")
        End Try
    End Sub
    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        ConnectionPanel.Focus()
        TimerSerial.Stop()
        SerialPort1.Close()
        ButtonDisconnect.SendToBack()
        ButtonConnect.BringToFront()
        LabelStatus.Text = "Status : Disconnect"
        PictureBoxConnectionStatus.Visible = True
        PictureBoxConnectionStatus.BackColor = Color.Red
    End Sub

    '====================================== Connection Panel End ================================================'


    '=============The function to convert values to PictureBoxPBTemp size so that it looks like a progress bar.
    Function MapBatt(ByVal X As Single, ByVal In_min As Single, ByVal In_max As Single, ByVal Out_min As Single, ByVal Out_max As Single) As Integer
        Dim A As Single
        Dim B As Single
        A = X - In_min
        B = Out_max - Out_min
        A = A * B
        B = In_max - In_min
        A = A / B
        MapBatt = A + Out_min
    End Function
    '===========================================================================================================

    '=======================================Showing values=============================================
    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting  '--> Read incoming serial data

            Dim TB As New System.Windows.Forms.TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn   '--> Enter serial data into the textbox

            If TB.Lines.Count > 0 Then
                If TB.Lines(0) = "Failed to read from Your Bot !" Then '--> Check Arduino if it fails to read from the Bot, if this happens the connection is disconnected
                    TimerSerial.Stop()
                    SerialPort1.Close()
                    LabelStatus.Text = "Status : Disconnect"
                    ButtonDisconnect.SendToBack()
                    ButtonConnect.BringToFront()
                    PictureBoxConnectionStatus.Visible = True
                    PictureBoxConnectionStatus.BackColor = Color.Red
                    MsgBox("Failed to read from Bot !!!, Please check the Hardware and Please connect again.", MsgBoxStyle.Critical, "Connection failed !!!")
                    Return
                End If

                '============================Extracting Values from incoming data ========================'
                'For more info: https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/mid-function


                StrSerialInRam = TB.Lines(0).Substring(0, 1)
                If StrSerialInRam = "T" Then
                    Temp = TB.Lines(0)
                    TempL = StrSerialInRam.Length
                Else
                    Temp = Temp
                End If

                TempResult = Mid(Temp, 2, 3)



                '===========Enter the values into the chart======================
                ChartTemperature.Series("Temperature").Points.AddY(TempResult)


                '------------value into labelBox-----
                TempBox.Text = TempResult & " *C"



                '-----------If the connection is successful and running, PictureBoxConnectionStatus will blink----
                If PictureBoxConnectionStatus.Visible = True Then
                    PictureBoxConnectionStatus.Visible = False
                ElseIf PictureBoxConnectionStatus.Visible = False Then
                    PictureBoxConnectionStatus.Visible = True
                End If
                '------------------------------------------------------------------------------------------------------


            End If
        Catch ex As Exception
            TimerSerial.Stop()
            SerialPort1.Close()
            LabelStatus.Text = "Status : Disconnect"
            ButtonDisconnect.SendToBack()
            ButtonConnect.BringToFront()
            PictureBoxConnectionStatus.BackColor = Color.Red
            MsgBox("Please check the Hardware and Please connect again." & ex.Message, MsgBoxStyle.Critical, "Connection failed !!!")
            Return
        End Try
    End Sub


End Class