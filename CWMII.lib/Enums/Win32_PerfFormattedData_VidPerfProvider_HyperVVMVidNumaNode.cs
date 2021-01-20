namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNode {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		PageCount,
		ProcessorCount
	}

	public static class Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNodeExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNode enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidNumaNode", enumOption.ToString());
	}
}