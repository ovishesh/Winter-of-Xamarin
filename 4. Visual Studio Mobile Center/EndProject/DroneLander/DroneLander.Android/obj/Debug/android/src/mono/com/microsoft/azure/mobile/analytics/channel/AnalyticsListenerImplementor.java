package mono.com.microsoft.azure.mobile.analytics.channel;


public class AnalyticsListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microsoft.azure.mobile.analytics.channel.AnalyticsListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBeforeSending:(Lcom/microsoft/azure/mobile/ingestion/models/Log;)V:GetOnBeforeSending_Lcom_microsoft_azure_mobile_ingestion_models_Log_Handler:Com.Microsoft.Azure.Mobile.Analytics.Channel.IAnalyticsListenerInvoker, Microsoft.Azure.Mobile.Analytics.Android.Bindings\n" +
			"n_onSendingFailed:(Lcom/microsoft/azure/mobile/ingestion/models/Log;Ljava/lang/Exception;)V:GetOnSendingFailed_Lcom_microsoft_azure_mobile_ingestion_models_Log_Ljava_lang_Exception_Handler:Com.Microsoft.Azure.Mobile.Analytics.Channel.IAnalyticsListenerInvoker, Microsoft.Azure.Mobile.Analytics.Android.Bindings\n" +
			"n_onSendingSucceeded:(Lcom/microsoft/azure/mobile/ingestion/models/Log;)V:GetOnSendingSucceeded_Lcom_microsoft_azure_mobile_ingestion_models_Log_Handler:Com.Microsoft.Azure.Mobile.Analytics.Channel.IAnalyticsListenerInvoker, Microsoft.Azure.Mobile.Analytics.Android.Bindings\n" +
			"";
		mono.android.Runtime.register ("Com.Microsoft.Azure.Mobile.Analytics.Channel.IAnalyticsListenerImplementor, Microsoft.Azure.Mobile.Analytics.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", AnalyticsListenerImplementor.class, __md_methods);
	}


	public AnalyticsListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AnalyticsListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microsoft.Azure.Mobile.Analytics.Channel.IAnalyticsListenerImplementor, Microsoft.Azure.Mobile.Analytics.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onBeforeSending (com.microsoft.azure.mobile.ingestion.models.Log p0)
	{
		n_onBeforeSending (p0);
	}

	private native void n_onBeforeSending (com.microsoft.azure.mobile.ingestion.models.Log p0);


	public void onSendingFailed (com.microsoft.azure.mobile.ingestion.models.Log p0, java.lang.Exception p1)
	{
		n_onSendingFailed (p0, p1);
	}

	private native void n_onSendingFailed (com.microsoft.azure.mobile.ingestion.models.Log p0, java.lang.Exception p1);


	public void onSendingSucceeded (com.microsoft.azure.mobile.ingestion.models.Log p0)
	{
		n_onSendingSucceeded (p0);
	}

	private native void n_onSendingSucceeded (com.microsoft.azure.mobile.ingestion.models.Log p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
