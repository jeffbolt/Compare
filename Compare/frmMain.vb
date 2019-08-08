Imports System.IO
Imports System.Linq

Public Class frmMain
	Dim w1, w2, w, r1, r2 As Double

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cmbFolder1.Items.Add("C:\Users\jbolt\Documents\GitHub\Compare\Folder1")
		cmbFolder1.SelectedIndex = 0
		cmbFolder2.Items.Add("C:\Users\jbolt\Documents\GitHub\Compare\Folder2")
		cmbFolder2.SelectedIndex = 0
	End Sub

	Private Sub frmMain_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
		w = CDbl(lvwResults.Width) - 10
		w1 = CDbl(lvwResults.Columns(0).Width)
		'w2 = CDbl(lvwResults.Columns(1).Width)
		w2 = w - w1
		r1 = w1 / w
		r2 = w2 / w
	End Sub

	Private Sub frmMain_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
		lvwResults.Columns(0).Width = lvwResults.Width * r1
		lvwResults.Columns(1).Width = lvwResults.Width * r2
	End Sub

	Private Sub btnBrowseFolder1_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder1.Click
		With FolderBrowserDialog1
			.ShowDialog()
			cmbFolder1.Text = .SelectedPath
		End With
	End Sub
	Private Sub btnBrowseFolder2_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder2.Click
		With FolderBrowserDialog1
			.ShowDialog()
			cmbFolder2.Text = .SelectedPath
		End With
	End Sub

	Private Sub cmbFolder_DragEnter(sender As Object, e As DragEventArgs) Handles cmbFolder1.DragEnter, cmbFolder2.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub cmbFolder1_DragDrop(sender As Object, e As DragEventArgs) Handles cmbFolder1.DragDrop, cmbFolder2.DragDrop
		Dim strPath As String = e.Data.GetData(DataFormats.FileDrop)(0)
		If Directory.Exists(strPath) Then
			Select Case sender.Name
				Case "cmbFolder1"
					cmbFolder1.Text = strPath
				Case "cmbFolder2"
					cmbFolder2.Text = strPath
			End Select
		End If
	End Sub

	Private Sub btnCompareFolders_Click(sender As Object, e As EventArgs) Handles btnCompareFolders.Click
		'Search(cmbFolder1.Text, cmbFolder2.Text)
		Dim FileList1 As New List(Of String)
		BuildFilelist(cmbFolder1.Text, FileList1)
		Dim FileList2 As New List(Of String)
		BuildFilelist(cmbFolder2.Text, FileList2)
		FileList1.Sort()
		FileList2.Sort()

		If Not FileList1.Equals(FileList2) Then
			Dim DiffQuery1 As IEnumerable(Of String) = FileList1.Except(FileList2)
			'Execute the query
			Console.WriteLine("The following files are in FileList1 but not FileList2")
			For Each s As String In DiffQuery1
				Console.WriteLine(s)
				AddToList(s)
			Next
		End If

		If Not FileList2.Equals(FileList1) Then
			Dim DiffQuery2 As IEnumerable(Of String) = FileList2.Except(FileList1)
			'Execute the query
			Console.WriteLine("The following files are in FileList2 but not FileList1")
			For Each s As String In DiffQuery2
				Console.WriteLine(s)
				AddToList(s)
			Next
		End If

		'Dim Files1() As String = Directory.GetFileSystemEntries(cmbFolder1.Text)
		'Dim Files2() As String = Directory.GetFileSystemEntries(cmbFolder2.Text)
		'Dim lst1 As New List(Of String)(Files1)
		'Dim lst2 As New List(Of String)(Files2)

		'lst1 = RemovePath(lst1)
		'lst2 = RemovePath(lst2)
		'lst1.Sort(StringComparer.OrdinalIgnoreCase)
		'lst2.Sort(StringComparer.OrdinalIgnoreCase)

		'If Not lst1.Equals(lst2) Then
		'	Dim DiffQuery1 As IEnumerable(Of String) = lst1.Except(lst2)
		'	'Execute the query
		'	Console.WriteLine("The following files are in lst1 but not lst2")
		'	For Each s As String In DiffQuery1
		'		Console.WriteLine(s)
		'	Next
		'End If

		'If Not lst2.Equals(lst1) Then
		'	Dim DiffQuery2 As IEnumerable(Of String) = lst2.Except(lst1)
		'	'Execute the query
		'	Console.WriteLine("The following files are in lst2 but not lst1")
		'	For Each s As String In DiffQuery2
		'		Console.WriteLine(s)
		'	Next
		'End If
	End Sub

	Private Function RemovePath(ByRef lst As List(Of String)) As List(Of String)
		Dim lst2 As New List(Of String)
		For Each f In lst
			lst2.Add(New FileInfo(f).Name)
		Next
		Return lst2
	End Function

	Private Sub BuildFilelist(ByVal Folder As String, ByRef Files As List(Of String)) 'As List(Of String)
		If Files.Count = 0 Then Files = New List(Of String)
		Dim lst() As String = Directory.GetFileSystemEntries(Folder)

		For Each f In lst
			If Directory.Exists(f) Then
				BuildFilelist(f, Files)
			Else
				'Files.Add(f)
				Files.Add(New FileInfo(f).Name)
			End If
		Next
	End Sub

	Private Sub AddToList(ByVal FilePath As String)
		Dim fi As New FileInfo(FilePath)
		Dim li As New ListViewItem With {.Text = fi.Name}
		li.SubItems.Add(New ListViewItem.ListViewSubItem With {.Text = fi.DirectoryName})
		lvwResults.Items.Add(li)
	End Sub

	Private Function Search(ByVal Folder1 As String, ByVal Folder2 As String) As Boolean
		Dim blnFound As Boolean

		lvwResults.Items.Clear()

		If Directory.Exists(Folder1) AndAlso Directory.Exists(Folder2) Then
			Console.WriteLine("Folder1: " + Folder1)
			'Console.WriteLine(Directory.GetFileSystemEntries(strFolder1))
			'Console.WriteLine(Path.GetTempFileName)

			For Each File1 As String In Directory.GetFiles(Folder1)
				blnFound = False
				Dim FileName1 As String = New FileInfo(File1).Name
				Console.WriteLine("File1: " + Path.Combine(Folder1, File1))
				For Each File2 As String In Directory.GetFiles(Folder2)
					Dim FileName2 As String = New FileInfo(File2).Name
					Console.WriteLine("  File2: " + Path.Combine(Folder1, File2))
					If StrComp(FileName1, FileName2, CompareMethod.Text) = 0 Then
						Console.WriteLine("FOUND!")
						blnFound = True
						Exit For
					End If
				Next

				If Not blnFound Then
					'Recursively seach any subfolders of Folder2
					For Each SubFolder1 In Directory.GetDirectories(Folder1)
						If Search(SubFolder1, Folder2) Then
							blnFound = True
							Exit For
						End If
					Next

					If Not blnFound Then
						Dim fi As New FileInfo(File1)
						Dim li As New ListViewItem With {.Text = fi.Name}
						li.SubItems.Add(New ListViewItem.ListViewSubItem With {.Text = fi.DirectoryName})
						lvwResults.Items.Add(li)
					End If
				End If
			Next

			'Recursively seach any subfolders of Folder1
			For Each SubFolder2 In Directory.GetDirectories(Folder2)
				Return Search(Folder1, SubFolder2)
			Next
		End If

		Return blnFound
	End Function

End Class
