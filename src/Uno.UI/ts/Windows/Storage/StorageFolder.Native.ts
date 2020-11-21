﻿
namespace Windows.Storage {

	export class StorageFolderNative {
		private static _folderMap: Map<string, FileSystemDirectoryHandle> = new Map<string, FileSystemDirectoryHandle>();

		public static AddHandle(guid: string, handle: FileSystemDirectoryHandle) {
			this._folderMap.set(guid, handle);
		}

		public static RemoveHandle(guid: string) {
			this._folderMap.delete(guid);
		}

		public static GetHandle(guid: string): FileSystemDirectoryHandle {
			return this._folderMap.get(guid);
		}

		/**
		 * Creates a new folder inside another folder.
		 * @param parentGuid The GUID of the folder to create in.
		 * @param folderName The name of the new folder.
		 */
		public static async CreateFolderAsync(parentGuid: string, folderName: string): Promise<string> {
			const parentHandle = this.GetHandle(parentGuid);

			const newDirectoryHandle = await parentHandle.getDirectoryHandle(folderName, {
				create: true,
			});

			var guid = Uno.Utils.Guid.NewGuid();

			this.AddHandle(guid, newDirectoryHandle);

			return guid;
		}

		/**
		 * Gets a folder in the given parent folder by name.
		 * @param parentGuid The GUID of the parent folder to get.
		 * @param folderName The name of the folder to look for.
		 * @returns A GUID of the folder if found, other "notfound" literal.
		 */
		public static async GetFolderAsync(parentGuid: string, folderName: string): Promise<string> {
			const parentHandle = this.GetHandle(parentGuid);

			let nestedDirectoryHandle: FileSystemDirectoryHandle = undefined;
			let returnedGuid = Uno.Utils.Guid.NewGuid();

			try {
				nestedDirectoryHandle = await parentHandle.getDirectoryHandle(folderName);
			} catch (ex) {
				if (ex instanceof DOMException && (ex as DOMException).message.includes("could not be found")) {
					returnedGuid = "notfound";
				}
			}

			if (nestedDirectoryHandle)
				this.AddHandle(returnedGuid, nestedDirectoryHandle);

			return returnedGuid;
		}
	}
}
