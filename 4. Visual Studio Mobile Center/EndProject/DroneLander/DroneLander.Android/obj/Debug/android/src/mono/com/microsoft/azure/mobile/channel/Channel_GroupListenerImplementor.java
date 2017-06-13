package mono.com.microsoft.azure.mobile.channel;


public class Channel_GroupListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microsoft.azure.mobile.channel.Channel.GroupListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBeforeSending:(Lcom/microsoft/azure/mobile/ingestion/models/Log;)V:GetOnBeforeSending_Lcom_microsoft_azure_mobile_ingestion_models_Log_Handler:Com.Microsoft.Azure.Mobile.Channel.IChannelGroupListenerInvoker, Microsoft.Azure.Mobile.Android.Bindings\n" +
			"n_onFailure:(Lcom/microsoft/azure/mobile/ingestion/models/Log;Ljava/lang/Exception;)V:GetOnFailure_Lcom_microsoft_azure_mobile_ingestion_models_Log_Ljava_lang_Exception_Handler:Com.Microsoft.Azure.Mobile.Channel.IChannelGroupListenerInvoker, Microsoft.Azure.Mobile.Android.Bindings\n" +
			"n_onSuccess:(Lcom/microsoft/azure/mobile/ingestion/models/Log;)V:GetOnSuccess_Lcom_microsoft_azure_mobile_ingestion_models_Log_Handler:Com.Microsoft.Azure.Mobile.Channel.IChannelGroupListenerInvoker, Microsoft.Azure.Mobile.Android.Bindings\n" +
			"";
		mono.android.Runtime.register ("Com.Microsoft.Azure.Mobile.Channel.IChannelGroupListenerImplementor, Microsoft.Azure.Mobile.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", Channel_GroupListenerImplementor.class, __md_methods);
	}


	public Channel_GroupListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Channel_GroupListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microsoft.Azure.Mobile.Channel.IChannelGroupListenerImplementor, Microsoft.Azure.Mobile.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onBeforeSending (com.microsoft.azure.mobile.ingestion.models.Log p0)
	{
		n_onBeforeSending (p0);
	}

	private native void n_onBeforeSending (com.microsoft.azure.mobile.ingestion.models.Log p0);


	public void onFailure (com.microsoft.azure.mobile.ingestion.models.Log p0, java.lang.Exception p1)
	{
		n_onFailure (p0, p1);
	}

	private native void n_onFailure (com.microsoft.azure.mobile.ingestion.models.Log p0, java.lang.Exception p1);


	public void onSuccess (com.microsoft.azure.mobile.ingestion.models.Log p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (com.microsoft.azure.mobile.ingestion.models.Log p0);

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
