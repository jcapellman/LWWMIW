namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_ESENT_DatabaseInstances {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DatabaseCacheMissAttachedAverageLatency,
		DatabaseCacheMissAttachedAverageLatency_Base,
		DatabaseCacheMissesPersec,
		DatabaseCachePercentHit,
		DatabaseCachePercentHit_Base,
		DatabaseCachePercentHitUnique,
		DatabaseCachePercentHitUnique_Base,
		DatabaseCacheRequestsPersec,
		DatabaseCacheRequestsPersecUnique,
		DatabaseCacheSizeMB,
		DatabaseMaintenanceDuration,
		DatabaseOldestTransaction,
		DefragmentationTasks,
		DefragmentationTasksPending,
		IODatabaseReadsAttachedAverageLatency,
		IODatabaseReadsAttachedAverageLatency_Base,
		IODatabaseReadsAttachedPersec,
		IODatabaseReadsAverageLatency,
		IODatabaseReadsAverageLatency_Base,
		IODatabaseReadsPersec,
		IODatabaseReadsRecoveryAverageLatency,
		IODatabaseReadsRecoveryAverageLatency_Base,
		IODatabaseReadsRecoveryPersec,
		IODatabaseWritesAttachedAverageLatency,
		IODatabaseWritesAttachedAverageLatency_Base,
		IODatabaseWritesAttachedPersec,
		IODatabaseWritesAverageLatency,
		IODatabaseWritesAverageLatency_Base,
		IODatabaseWritesPersec,
		IODatabaseWritesRecoveryAverageLatency,
		IODatabaseWritesRecoveryAverageLatency_Base,
		IODatabaseWritesRecoveryPersec,
		IOFlushMapWritesAverageLatency,
		IOFlushMapWritesAverageLatency_Base,
		IOFlushMapWritesPersec,
		IOLogReadsAverageLatency,
		IOLogReadsAverageLatency_Base,
		IOLogReadsPersec,
		IOLogWritesAverageLatency,
		IOLogWritesAverageLatency_Base,
		IOLogWritesPersec,
		LogBytesGeneratedPersec,
		LogBytesWritePersec,
		LogCheckpointDepthasaPercentofTarget,
		LogCheckpointDepthasaPercentofTarget_Base,
		LogFileCurrentGeneration,
		LogFilesGenerated,
		LogFilesGeneratedPrematurely,
		LogGenerationCheckpointDepth,
		LogGenerationCheckpointDepthMax,
		LogGenerationCheckpointDepthTarget,
		LogGenerationLossResiliencyDepth,
		LogRecordStallsPersec,
		LogThreadsWaiting,
		LogWritesPersec,
		SessionsInUse,
		SessionsPercentUsed,
		SessionsPercentUsed_Base,
		StreamingBackupPagesReadPersec,
		TableClosesPersec,
		TableOpenCacheHitsPersec,
		TableOpenCacheMissesPersec,
		TableOpenCachePercentHit,
		TableOpenCachePercentHit_Base,
		TableOpensPersec,
		TablesOpen,
		Versionbucketsallocated
	}

	public static class Win32_PerfRawData_ESENT_DatabaseInstancesExtension {
		public static string GetWMIValue(this Win32_PerfRawData_ESENT_DatabaseInstances enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_ESENT_DatabaseInstances", enumOption.ToString());
	}
}