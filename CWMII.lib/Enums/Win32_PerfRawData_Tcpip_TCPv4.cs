namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Tcpip_TCPv4 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ConnectionFailures,
		ConnectionsActive,
		ConnectionsEstablished,
		ConnectionsPassive,
		ConnectionsReset,
		SegmentsPersec,
		SegmentsReceivedPersec,
		SegmentsRetransmittedPersec,
		SegmentsSentPersec
	}

	public static class Win32_PerfRawData_Tcpip_TCPv4Extension {
		public static string GetWMIValue(this Win32_PerfRawData_Tcpip_TCPv4 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Tcpip_TCPv4", enumOption.ToString());
	}
}