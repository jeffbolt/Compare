<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblFolder1 = New System.Windows.Forms.Label()
		Me.cmbFolder1 = New System.Windows.Forms.ComboBox()
		Me.lblFolder2 = New System.Windows.Forms.Label()
		Me.cmbFolder2 = New System.Windows.Forms.ComboBox()
		Me.btnCompareFolders = New System.Windows.Forms.Button()
		Me.lvwResults = New System.Windows.Forms.ListView()
		Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chFolder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnBrowseFolder1 = New System.Windows.Forms.Button()
		Me.btnBrowseFolder2 = New System.Windows.Forms.Button()
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(11, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(92, 28)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Compare"
		'
		'lblFolder1
		'
		Me.lblFolder1.AutoSize = True
		Me.lblFolder1.Location = New System.Drawing.Point(13, 55)
		Me.lblFolder1.Name = "lblFolder1"
		Me.lblFolder1.Size = New System.Drawing.Size(66, 20)
		Me.lblFolder1.TabIndex = 1
		Me.lblFolder1.Text = "Folder 1:"
		'
		'cmbFolder1
		'
		Me.cmbFolder1.AllowDrop = True
		Me.cmbFolder1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbFolder1.FormattingEnabled = True
		Me.cmbFolder1.Location = New System.Drawing.Point(17, 81)
		Me.cmbFolder1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.cmbFolder1.Name = "cmbFolder1"
		Me.cmbFolder1.Size = New System.Drawing.Size(547, 28)
		Me.cmbFolder1.TabIndex = 1
		'
		'lblFolder2
		'
		Me.lblFolder2.AutoSize = True
		Me.lblFolder2.Location = New System.Drawing.Point(13, 114)
		Me.lblFolder2.Name = "lblFolder2"
		Me.lblFolder2.Size = New System.Drawing.Size(66, 20)
		Me.lblFolder2.TabIndex = 3
		Me.lblFolder2.Text = "Folder 2:"
		'
		'cmbFolder2
		'
		Me.cmbFolder2.AllowDrop = True
		Me.cmbFolder2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbFolder2.FormattingEnabled = True
		Me.cmbFolder2.Location = New System.Drawing.Point(17, 140)
		Me.cmbFolder2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.cmbFolder2.Name = "cmbFolder2"
		Me.cmbFolder2.Size = New System.Drawing.Size(547, 28)
		Me.cmbFolder2.TabIndex = 3
		'
		'btnCompareFolders
		'
		Me.btnCompareFolders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCompareFolders.Location = New System.Drawing.Point(603, 140)
		Me.btnCompareFolders.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnCompareFolders.Name = "btnCompareFolders"
		Me.btnCompareFolders.Size = New System.Drawing.Size(94, 29)
		Me.btnCompareFolders.TabIndex = 5
		Me.btnCompareFolders.Text = "Compare"
		Me.btnCompareFolders.UseVisualStyleBackColor = True
		'
		'lvwResults
		'
		Me.lvwResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvwResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chFolder})
		Me.lvwResults.GridLines = True
		Me.lvwResults.Location = New System.Drawing.Point(14, 201)
		Me.lvwResults.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.lvwResults.Name = "lvwResults"
		Me.lvwResults.ShowGroups = False
		Me.lvwResults.Size = New System.Drawing.Size(683, 279)
		Me.lvwResults.TabIndex = 6
		Me.lvwResults.UseCompatibleStateImageBehavior = False
		Me.lvwResults.View = System.Windows.Forms.View.Details
		'
		'chName
		'
		Me.chName.Text = "Name"
		Me.chName.Width = 221
		'
		'chFolder
		'
		Me.chFolder.Text = "Folder"
		Me.chFolder.Width = 451
		'
		'btnBrowseFolder1
		'
		Me.btnBrowseFolder1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnBrowseFolder1.Location = New System.Drawing.Point(571, 80)
		Me.btnBrowseFolder1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnBrowseFolder1.Name = "btnBrowseFolder1"
		Me.btnBrowseFolder1.Size = New System.Drawing.Size(29, 29)
		Me.btnBrowseFolder1.TabIndex = 2
		Me.btnBrowseFolder1.Text = "..."
		Me.btnBrowseFolder1.UseVisualStyleBackColor = True
		'
		'btnBrowseFolder2
		'
		Me.btnBrowseFolder2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnBrowseFolder2.Location = New System.Drawing.Point(571, 140)
		Me.btnBrowseFolder2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnBrowseFolder2.Name = "btnBrowseFolder2"
		Me.btnBrowseFolder2.Size = New System.Drawing.Size(29, 29)
		Me.btnBrowseFolder2.TabIndex = 4
		Me.btnBrowseFolder2.Text = "..."
		Me.btnBrowseFolder2.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(714, 493)
		Me.Controls.Add(Me.btnBrowseFolder2)
		Me.Controls.Add(Me.btnBrowseFolder1)
		Me.Controls.Add(Me.lvwResults)
		Me.Controls.Add(Me.btnCompareFolders)
		Me.Controls.Add(Me.cmbFolder2)
		Me.Controls.Add(Me.lblFolder2)
		Me.Controls.Add(Me.cmbFolder1)
		Me.Controls.Add(Me.lblFolder1)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Compare"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents lblFolder1 As Label
	Friend WithEvents cmbFolder1 As ComboBox
	Friend WithEvents lblFolder2 As Label
	Friend WithEvents cmbFolder2 As ComboBox
	Friend WithEvents btnCompareFolders As Button
	Friend WithEvents lvwResults As ListView
	Friend WithEvents btnBrowseFolder1 As Button
	Friend WithEvents btnBrowseFolder2 As Button
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents chName As ColumnHeader
	Friend WithEvents chFolder As ColumnHeader
End Class
