namespace CWMII.lib.Enums {
	public enum CIM_StorageVolume {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		Availability,
		ConfigManagerErrorCode,
		ConfigManagerUserConfig,
		CreationClassName,
		DeviceID,
		ErrorCleared,
		ErrorDescription,
		LastErrorCode,
		PNPDeviceID,
		PowerManagementCapabilities,
		PowerManagementSupported,
		StatusInfo,
		SystemCreationClassName,
		SystemName,
		Access,
		BlockSize,
		ErrorMethodology,
		NumberOfBlocks,
		Purpose,
		Automount,
		BootVolume,
		Capacity,
		Compressed,
		DirtyBitSet,
		DriveLetter,
		DriveType,
		FileSystem,
		FreeSpace,
		IndexingEnabled,
		Label,
		MaximumFileNameLength,
		PageFilePresent,
		QuotasEnabled,
		QuotasIncomplete,
		QuotasRebuilding,
		SerialNumber,
		SupportsDiskQuotas,
		SupportsFileBasedCompression,
		SystemVolume
	}

	public static class CIM_StorageVolumeExtension {
		public static string GetWMIValue(this CIM_StorageVolume enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_StorageVolume", enumOption.ToString());
	}
}