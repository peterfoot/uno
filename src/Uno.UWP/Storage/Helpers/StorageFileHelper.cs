﻿#nullable enable
using System.Threading;
using System;
using System.Threading.Tasks;
using Uno;

namespace Windows.Storage.Helpers;

public partial class StorageFileHelper
{
	/// <summary>
	/// Determines if an asset or resource exists within application package
	/// </summary>
	/// <param name="fileName">relative file path</param>
	/// <returns>A task that will complete with a result of true if file exists, otherwise with a result of false.</returns>
	[NotImplemented("NET461")]
	public static async Task<bool> ExistsInPackage(string fileName) => await FileExistsInPackage(fileName);

#if NET461
	private static Task<bool> FileExistsInPackage(string fileName)
		=> throw new NotImplementedException();
#endif
}
