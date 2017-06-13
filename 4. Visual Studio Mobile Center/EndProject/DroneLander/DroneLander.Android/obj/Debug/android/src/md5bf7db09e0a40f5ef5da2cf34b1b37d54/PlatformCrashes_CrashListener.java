package md5bf7db09e0a40f5ef5da2cf34b1b37d54;


public class PlatformCrashes_CrashListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microsoft.azure.mobile.crashes.Crashes.WrapperSdkListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCrashCaptured:(Lcom/microsoft/azure/mobile/crashes/ingestion/models/ManagedErrorLog;)V:GetOnCrashCaptured_Lcom_microsoft_azure_mobile_crashes_ingestion_models_ManagedErrorLog_Handler:Com.Microsoft.Azure.Mobile.Crashes.AndroidCrashes/IWrapperSdkListenerInvoker, Microsoft.Azure.Mobile.Crashes.Android.Bindings\n" +
			"";
		mono.android.Runtime.register ("Microsoft.Azure.Mobile.Crashes.PlatformCrashes+CrashListener, Microsoft.Azure.Mobile.Crashes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", PlatformCrashes_CrashListener.class, __md_methods);
	}


	public PlatformCrashes_CrashListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PlatformCrashes_CrashListener.class)
			mono.android.TypeManager.Activate ("Microsoft.Azure.Mobile.Crashes.PlatformCrashes+CrashListener, Microsoft.Azure.Mobile.Crashes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCrashCaptured (com.microsoft.azure.mobile.crashes.ingestion.models.ManagedErrorLog p0)
	{
		n_onCrashCaptured (p0);
	}

	private native void n_onCrashCaptured (com.microsoft.azure.mobile.crashes.ingestion.models.ManagedErrorLog p0);

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
