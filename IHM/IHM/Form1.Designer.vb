<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ConnectionPanel = New System.Windows.Forms.Panel()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.LabelBaudRate = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ConnectionTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TempBox = New System.Windows.Forms.Label()
        Me.valueLabelCycles = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.PictureBoxConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.ChartTemperature = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ConnectionPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartTemperature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionPanel
        '
        Me.ConnectionPanel.BackColor = System.Drawing.Color.White
        Me.ConnectionPanel.Controls.Add(Me.ButtonDisconnect)
        Me.ConnectionPanel.Controls.Add(Me.ButtonConnect)
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.LabelBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxPort)
        Me.ConnectionPanel.Controls.Add(Me.ButtonScanPort)
        Me.ConnectionPanel.Controls.Add(Me.ConnectionTitle)
        Me.ConnectionPanel.Location = New System.Drawing.Point(12, 12)
        Me.ConnectionPanel.Name = "ConnectionPanel"
        Me.ConnectionPanel.Size = New System.Drawing.Size(252, 191)
        Me.ConnectionPanel.TabIndex = 0
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.BackColor = System.Drawing.Color.Red
        Me.ButtonDisconnect.Location = New System.Drawing.Point(37, 148)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(175, 23)
        Me.ButtonDisconnect.TabIndex = 7
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = False
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConnect.Location = New System.Drawing.Point(37, 148)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(175, 23)
        Me.ButtonConnect.TabIndex = 6
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(113, 103)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBaudRate.TabIndex = 5
        '
        'LabelBaudRate
        '
        Me.LabelBaudRate.AutoSize = True
        Me.LabelBaudRate.Location = New System.Drawing.Point(34, 106)
        Me.LabelBaudRate.Name = "LabelBaudRate"
        Me.LabelBaudRate.Size = New System.Drawing.Size(64, 13)
        Me.LabelBaudRate.TabIndex = 4
        Me.LabelBaudRate.Text = "Baud Rate :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(113, 60)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPort.TabIndex = 3
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Location = New System.Drawing.Point(23, 60)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonScanPort.TabIndex = 1
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'ConnectionTitle
        '
        Me.ConnectionTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectionTitle.AutoSize = True
        Me.ConnectionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ConnectionTitle.Location = New System.Drawing.Point(52, 17)
        Me.ConnectionTitle.Name = "ConnectionTitle"
        Me.ConnectionTitle.Size = New System.Drawing.Size(160, 20)
        Me.ConnectionTitle.TabIndex = 0
        Me.ConnectionTitle.Text = "Connexion Arduino"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TempBox)
        Me.Panel1.Controls.Add(Me.valueLabelCycles)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 206)
        Me.Panel1.TabIndex = 2
        '
        'TempBox
        '
        Me.TempBox.AutoSize = True
        Me.TempBox.Location = New System.Drawing.Point(173, 75)
        Me.TempBox.Name = "TempBox"
        Me.TempBox.Size = New System.Drawing.Size(13, 13)
        Me.TempBox.TabIndex = 3
        Me.TempBox.Text = "0"
        '
        'valueLabelCycles
        '
        Me.valueLabelCycles.AutoSize = True
        Me.valueLabelCycles.Location = New System.Drawing.Point(173, 28)
        Me.valueLabelCycles.Name = "valueLabelCycles"
        Me.valueLabelCycles.Size = New System.Drawing.Size(13, 13)
        Me.valueLabelCycles.TabIndex = 2
        Me.valueLabelCycles.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Température (°C) :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cycles :"
        '
        'TimerSerial
        '
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(27, 428)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(37, 13)
        Me.LabelStatus.TabIndex = 3
        Me.LabelStatus.Text = "Status"
        '
        'PictureBoxConnectionStatus
        '
        Me.PictureBoxConnectionStatus.BackColor = System.Drawing.Color.Red
        Me.PictureBoxConnectionStatus.Location = New System.Drawing.Point(12, 429)
        Me.PictureBoxConnectionStatus.Name = "PictureBoxConnectionStatus"
        Me.PictureBoxConnectionStatus.Size = New System.Drawing.Size(10, 12)
        Me.PictureBoxConnectionStatus.TabIndex = 8
        Me.PictureBoxConnectionStatus.TabStop = False
        '
        'ChartTemperature
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartTemperature.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartTemperature.Legends.Add(Legend1)
        Me.ChartTemperature.Location = New System.Drawing.Point(270, 12)
        Me.ChartTemperature.Name = "ChartTemperature"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Temperature"
        Me.ChartTemperature.Series.Add(Series1)
        Me.ChartTemperature.Size = New System.Drawing.Size(518, 403)
        Me.ChartTemperature.TabIndex = 9
        Me.ChartTemperature.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChartTemperature)
        Me.Controls.Add(Me.PictureBoxConnectionStatus)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ConnectionPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ConnectionPanel.ResumeLayout(False)
        Me.ConnectionPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTemperature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectionPanel As Panel
    Friend WithEvents ConnectionTitle As Label
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents valueLabelCycles As Label
    Friend WithEvents TempBox As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PictureBoxConnectionStatus As PictureBox
    Friend WithEvents ChartTemperature As DataVisualization.Charting.Chart
End Class
