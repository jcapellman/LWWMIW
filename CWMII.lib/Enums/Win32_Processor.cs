namespace CWMII.lib.Enums {
	public enum Win32_Processor {
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
		AddressWidth,
		CurrentClockSpeed,
		DataWidth,
		Family,
		LoadPercentage,
		MaxClockSpeed,
		OtherFamilyDescription,
		Role,
		Stepping,
		UniqueId,
		UpgradeMethod,
		Architecture,
		AssetTag,
		Characteristics,
		CpuStatus,
		CurrentVoltage,
		ExtClock,
		L2CacheSize,
		L2CacheSpeed,
		L3CacheSize,
		L3CacheSpeed,
		Level,
		Manufacturer,
		NumberOfCores,
		NumberOfEnabledCore,
		NumberOfLogicalProcessors,
		PartNumber,
		ProcessorId,
		ProcessorType,
		Revision,
		SecondLevelAddressTranslationExtensions,
		SerialNumber,
		SocketDesignation,
		ThreadCount,
		Version,
		VirtualizationFirmwareEnabled,
		VMMonitorModeExtensions,
		VoltageCaps
	}

	public static class Win32_ProcessorExtension {
		public static string GetWMIValue(this Win32_Processor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Processor", enumOption.ToString());
	}
}