namespace CWMII.lib.Enums {
	public enum CIM_DiskDrive {
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
		Capabilities,
		CapabilityDescriptions,
		CompressionMethod,
		DefaultBlockSize,
		ErrorMethodology,
		MaxBlockSize,
		MaxMediaSize,
		MinBlockSize,
		NeedsCleaning,
		NumberOfMediaSupported,
		BytesPerSector,
		FirmwareRevision,
		Index,
		InterfaceType,
		Manufacturer,
		MediaLoaded,
		MediaType,
		Model,
		Partitions,
		SCSIBus,
		SCSILogicalUnit,
		SCSIPort,
		SCSITargetId,
		SectorsPerTrack,
		SerialNumber,
		Signature,
		Size,
		TotalCylinders,
		TotalHeads,
		TotalSectors,
		TotalTracks,
		TracksPerCylinder
	}

	public static class CIM_DiskDriveExtension {
		public static string GetWMIValue(this CIM_DiskDrive enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_DiskDrive", enumOption.ToString());
	}
}