namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_ASPNET_ASPNETApplications {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AnonymousRequests,
		AnonymousRequestsPerSec,
		ApplicationLifetimeEvents,
		ApplicationLifetimeEventsPerSec,
		AuditFailureEventsRaised,
		AuditSuccessEventsRaised,
		CacheAPIEntries,
		CacheAPIHitRatio,
		CacheAPIHitRatio_Base,
		CacheAPIHits,
		CacheAPIMisses,
		CacheAPITrims,
		CacheAPITurnoverRate,
		CachePercentMachineMemoryLimitUsed,
		CachePercentMachineMemoryLimitUsed_Base,
		CachePercentProcessMemoryLimitUsed,
		CachePercentProcessMemoryLimitUsed_Base,
		CacheTotalEntries,
		CacheTotalHitRatio,
		CacheTotalHitRatio_Base,
		CacheTotalHits,
		CacheTotalMisses,
		CacheTotalTrims,
		CacheTotalTurnoverRate,
		CompilationsTotal,
		DebuggingRequests,
		ErrorEventsRaised,
		ErrorEventsRaisedPerSec,
		ErrorsDuringCompilation,
		ErrorsDuringExecution,
		ErrorsDuringPreprocessing,
		ErrorsTotal,
		ErrorsTotalPerSec,
		ErrorsUnhandledDuringExecution,
		ErrorsUnhandledDuringExecutionPerSec,
		EventsRaised,
		EventsRaisedPerSec,
		FormsAuthenticationFailure,
		FormsAuthenticationSuccess,
		InfrastructureErrorEventsRaised,
		InfrastructureErrorEventsRaisedPerSec,
		ManagedMemoryUsedestimated,
		MembershipAuthenticationFailure,
		MembershipAuthenticationSuccess,
		OutputCacheEntries,
		OutputCacheHitRatio,
		OutputCacheHitRatio_Base,
		OutputCacheHits,
		OutputCacheMisses,
		OutputCacheTrims,
		OutputCacheTurnoverRate,
		PercentManagedProcessorTimeestimated,
		PercentManagedProcessorTimeestimated_Base,
		PipelineInstanceCount,
		RequestBytesInTotal,
		RequestBytesInTotalWebSockets,
		RequestBytesOutTotal,
		RequestBytesOutTotalWebSockets,
		RequestErrorEventsRaised,
		RequestErrorEventsRaisedPerSec,
		RequestEventsRaised,
		RequestEventsRaisedPerSec,
		RequestExecutionTime,
		RequestsDisconnected,
		RequestsExecuting,
		RequestsExecutingWebSockets,
		RequestsFailed,
		RequestsFailedWebSockets,
		RequestsInApplicationQueue,
		RequestsNotAuthorized,
		RequestsNotFound,
		RequestsPerSec,
		RequestsRejected,
		RequestsSucceeded,
		RequestsSucceededWebSockets,
		RequestsTimedOut,
		RequestsTotal,
		RequestsTotalWebSockets,
		RequestWaitTime,
		SessionsAbandoned,
		SessionsActive,
		SessionSQLServerconnectionstotal,
		SessionStateServerconnectionstotal,
		SessionsTimedOut,
		SessionsTotal,
		TransactionsAborted,
		TransactionsCommitted,
		TransactionsPending,
		TransactionsPerSec,
		TransactionsTotal,
		ViewstateMACValidationFailure
	}

	public static class Win32_PerfRawData_ASPNET_ASPNETApplicationsExtension {
		public static string GetWMIValue(this Win32_PerfRawData_ASPNET_ASPNETApplications enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_ASPNET_ASPNETApplications", enumOption.ToString());
	}
}