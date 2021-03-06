namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ConnectionsAcceptedovernetpipe,
		ConnectionsAcceptedovernettcp,
		ConnectionsDispatchedovernetpipe,
		ConnectionsDispatchedovernettcp,
		DispatchFailuresovernetpipe,
		DispatchFailuresovernettcp,
		ProtocolFailuresovernetpipe,
		ProtocolFailuresovernettcp,
		RegistrationsActivefornetpipe,
		RegistrationsActivefornettcp,
		UrisRegisteredfornetpipe,
		UrisRegisteredfornettcp,
		UrisUnregisteredfornetpipe,
		UrisUnregisteredfornettcp
	}

	public static class Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000Extension {
		public static string GetWMIValue(this Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_SMSvcHost4000_SMSvcHost4000", enumOption.ToString());
	}
}