namespace CWMII.lib.Enums {
	public enum CIM_VideoController {
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
		MaxNumberControlled,
		ProtocolSupported,
		TimeOfLastReset,
		AcceleratorCapabilities,
		CapabilityDescriptions,
		CurrentBitsPerPixel,
		CurrentHorizontalResolution,
		CurrentNumberOfColors,
		CurrentNumberOfColumns,
		CurrentNumberOfRows,
		CurrentRefreshRate,
		CurrentScanMode,
		CurrentVerticalResolution,
		MaxMemorySupported,
		MaxRefreshRate,
		MinRefreshRate,
		NumberOfVideoPages,
		VideoMemoryType,
		VideoProcessor,
		NumberOfColorPlanes,
		VideoArchitecture,
		VideoMode,
		AdapterCompatibility,
		AdapterDACType,
		AdapterRAM,
		ColorTableEntries,
		DeviceSpecificPens,
		DitherType,
		DriverDate,
		DriverVersion,
		ICMIntent,
		ICMMethod,
		InfFilename,
		InfSection,
		InstalledDisplayDrivers,
		Monochrome,
		ReservedSystemPaletteEntries,
		SpecificationVersion,
		SystemPaletteEntries,
		VideoModeDescription
	}

	public static class CIM_VideoControllerExtension {
		public static string GetWMIValue(this CIM_VideoController enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_VideoController", enumOption.ToString());
	}
}