namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_PerfOS_Cache {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AsyncCopyReadsPersec,
		AsyncDataMapsPersec,
		AsyncFastReadsPersec,
		AsyncMDLReadsPersec,
		AsyncPinReadsPersec,
		CopyReadHitsPercent,
		CopyReadHitsPercent_Base,
		CopyReadsPersec,
		DataFlushesPersec,
		DataFlushPagesPersec,
		DataMapHitsPercent,
		DataMapHitsPercent_Base,
		DataMapPinsPersec,
		DataMapPinsPersec_Base,
		DataMapsPersec,
		DirtyPages,
		DirtyPageThreshold,
		FastReadNotPossiblesPersec,
		FastReadResourceMissesPersec,
		FastReadsPersec,
		LazyWriteFlushesPersec,
		LazyWritePagesPersec,
		MDLReadHitsPercent,
		MDLReadHitsPercent_Base,
		MDLReadsPersec,
		PinReadHitsPercent,
		PinReadHitsPercent_Base,
		PinReadsPersec,
		ReadAheadsPersec,
		SyncCopyReadsPersec,
		SyncDataMapsPersec,
		SyncFastReadsPersec,
		SyncMDLReadsPersec,
		SyncPinReadsPersec
	}

	public static class Win32_PerfRawData_PerfOS_CacheExtension {
		public static string GetWMIValue(this Win32_PerfRawData_PerfOS_Cache enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_PerfOS_Cache", enumOption.ToString());
	}
}