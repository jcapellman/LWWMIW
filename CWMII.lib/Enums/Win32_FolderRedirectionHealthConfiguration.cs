namespace CWMII.lib.Enums {
	public enum Win32_FolderRedirectionHealthConfiguration {
		LastSyncDurationCautionInHours,
		LastSyncDurationUnhealthyInHours
	}

	public static class Win32_FolderRedirectionHealthConfigurationExtension {
		public static string GetWMIValue(this Win32_FolderRedirectionHealthConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_FolderRedirectionHealthConfiguration", enumOption.ToString());
	}
}