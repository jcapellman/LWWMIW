namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_SynchronizationNuma {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ExecResourceAcquiresAcqExclLitePersec,
		ExecResourceAcquiresAcqShrdLitePersec,
		ExecResourceAcquiresAcqShrdStarveExclPersec,
		ExecResourceAcquiresAcqShrdWaitForExclPersec,
		ExecResourceAttemptsAcqExclLitePersec,
		ExecResourceAttemptsAcqShrdLitePersec,
		ExecResourceAttemptsAcqShrdStarveExclPersec,
		ExecResourceAttemptsAcqShrdWaitForExclPersec,
		ExecResourceBoostExclOwnerPersec,
		ExecResourceBoostSharedOwnersPersec,
		ExecResourceContentionAcqExclLitePersec,
		ExecResourceContentionAcqShrdLitePersec,
		ExecResourceContentionAcqShrdStarveExclPersec,
		ExecResourceContentionAcqShrdWaitForExclPersec,
		ExecResourcenoWaitsAcqExclLitePersec,
		ExecResourcenoWaitsAcqShrdLitePersec,
		ExecResourcenoWaitsAcqShrdStarveExclPersec,
		ExecResourcenoWaitsAcqShrdWaitForExclPersec,
		ExecResourceRecursiveExclAcquiresAcqExclLitePersec,
		ExecResourceRecursiveExclAcquiresAcqShrdLitePersec,
		ExecResourceRecursiveExclAcquiresAcqShrdStarveExclPersec,
		ExecResourceRecursiveExclAcquiresAcqShrdWaitForExclPersec,
		ExecResourceRecursiveShAcquiresAcqShrdLitePersec,
		ExecResourceRecursiveShAcquiresAcqShrdStarveExclPersec,
		ExecResourceRecursiveShAcquiresAcqShrdWaitForExclPersec,
		ExecResourceSetOwnerPointerExclusivePersec,
		ExecResourceSetOwnerPointerSharedExistingOwnerPersec,
		ExecResourceSetOwnerPointerSharedNewOwnerPersec,
		ExecResourceTotalAcquiresPersec,
		ExecResourceTotalContentionsPersec,
		ExecResourceTotalConvExclusiveToSharedPersec,
		ExecResourceTotalDeletePersec,
		ExecResourceTotalExclusiveReleasesPersec,
		ExecResourceTotalInitializePersec,
		ExecResourceTotalReInitializePersec,
		ExecResourceTotalSharedReleasesPersec,
		IPISendBroadcastRequestsPersec,
		IPISendRoutineRequestsPersec,
		IPISendSoftwareInterruptsPersec,
		SpinlockAcquiresPersec,
		SpinlockContentionsPersec,
		SpinlockSpinsPersec
	}

	public static class Win32_PerfRawData_Counters_SynchronizationNumaExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_SynchronizationNuma enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_SynchronizationNuma", enumOption.ToString());
	}
}