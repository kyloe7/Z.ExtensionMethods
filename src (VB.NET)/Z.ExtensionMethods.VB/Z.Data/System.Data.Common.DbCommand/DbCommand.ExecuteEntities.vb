
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common

Public Module Extensions_647

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbCommand) As IEnumerable(Of T)
		Using reader As IDataReader = this.ExecuteReader()
			Return reader.ToEntities(Of T)()
		End Using
	End Function
End Module


