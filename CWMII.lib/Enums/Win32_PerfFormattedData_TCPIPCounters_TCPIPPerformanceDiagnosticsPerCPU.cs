namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		TCPcurrentconnections
	}

	public static class Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPUExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnosticsPerCPU", enumOption.ToString());
	}
}