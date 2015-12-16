
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
Friend WithEvents Button1 As System.Windows.Forms.Button
Friend WithEvents Timer1 As System.Windows.Forms.Timer
Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container
Me.Button1 = New System.Windows.Forms.Button
Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
Me.Button2 = New System.Windows.Forms.Button
Me.SuspendLayout()
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(17, 27)
Me.Button1.Name = "Button1"
Me.Button1.TabIndex = 0
Me.Button1.Text = "Start"
'
'Timer1
'
Me.Timer1.Interval = 1000
'
'Button2
'
Me.Button2.Location = New System.Drawing.Point(109, 27)
Me.Button2.Name = "Button2"
Me.Button2.TabIndex = 1
Me.Button2.Text = "Stop"
'
'Form1
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.ClientSize = New System.Drawing.Size(207, 75)
Me.Controls.Add(Me.Button2)
Me.Controls.Add(Me.Button1)
Me.Name = "Form1"
Me.Text = "Form1"
Me.ResumeLayout(False)

    End Sub

#End Region

Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

  Dim c As Process = Process.GetCurrentProcess()
  Dim objProcessed() As Process
  Dim blnOK As Boolean


  objProcessed = Process.GetProcessesByName("mangosd")

  If objProcessed.Length < 1 Then
    'Wait for 5 sec
    System.Threading.Thread.Sleep(5000)
    Process.Start(Application.StartupPath & "\" & "mangosd.exe")
  End If

End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
  Timer1.Enabled = True
End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
  Timer1.Enabled = False
End Sub
End Class
