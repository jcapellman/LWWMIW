namespace CWMII.lib.Enums {
	public enum Win32_NetworkAdapterConfiguration {
		Caption,
		Description,
		SettingID,
		ArpAlwaysSourceRoute,
		ArpUseEtherSNAP,
		DatabasePath,
		DeadGWDetectEnabled,
		DefaultIPGateway,
		DefaultTOS,
		DefaultTTL,
		DHCPEnabled,
		DHCPLeaseExpires,
		DHCPLeaseObtained,
		DHCPServer,
		DNSDomain,
		DNSDomainSuffixSearchOrder,
		DNSEnabledForWINSResolution,
		DNSHostName,
		DNSServerSearchOrder,
		DomainDNSRegistrationEnabled,
		ForwardBufferMemory,
		FullDNSRegistrationEnabled,
		GatewayCostMetric,
		IGMPLevel,
		Index,
		InterfaceIndex,
		IPAddress,
		IPConnectionMetric,
		IPEnabled,
		IPFilterSecurityEnabled,
		IPPortSecurityEnabled,
		IPSecPermitIPProtocols,
		IPSecPermitTCPPorts,
		IPSecPermitUDPPorts,
		IPSubnet,
		IPUseZeroBroadcast,
		IPXAddress,
		IPXEnabled,
		IPXFrameType,
		IPXMediaType,
		IPXNetworkNumber,
		IPXVirtualNetNumber,
		KeepAliveInterval,
		KeepAliveTime,
		MACAddress,
		MTU,
		NumForwardPackets,
		PMTUBHDetectEnabled,
		PMTUDiscoveryEnabled,
		ServiceName,
		TcpipNetbiosOptions,
		TcpMaxConnectRetransmissions,
		TcpMaxDataRetransmissions,
		TcpNumConnections,
		TcpUseRFC1122UrgentPointer,
		TcpWindowSize,
		WINSEnableLMHostsLookup,
		WINSHostLookupFile,
		WINSPrimaryServer,
		WINSScopeID,
		WINSSecondaryServer
	}

	public static class Win32_NetworkAdapterConfigurationExtension {
		public static string GetWMIValue(this Win32_NetworkAdapterConfiguration enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NetworkAdapterConfiguration", enumOption.ToString());
	}
}