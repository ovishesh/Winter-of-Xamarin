package md5bf7db09e0a40f5ef5da2cf34b1b37d54;


public class PlatformCrashes_GetLastSessionCrashReportCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microsoft.azure.mobile.ResultCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onResult:(Ljava/lang/Object;)V:GetOnResult_Ljava_lang_Object_Handler:Com.Microsoft.Azure.Mobile.IResultCallbackInvoker, Microsoft.Azure.Mobile.Android.Bindings\n" +
			"";
		mono.android.Runtime.register ("Microsoft.Azure.Mobile.Crashes.PlatformCrashes+GetLastSessionCrashReportCallback, Microsoft.Azure.Mobile.Crashes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", PlatformCrashes_GetLastSessionCrashReportCallback.class, __md_methods);
	}


	public PlatformCrashes_GetLastSessionCrashReportCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PlatformCrashes_GetLastSessionCrashReportCallback.class)
			mono.android.TypeManager.Activate ("Microsoft.Azure.Mobile.Crashes.PlatformCrashes+GetLastSessionCrashReportCallback, Microsoft.Azure.Mobile.Crashes, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onResult (java.lang.Object p0)
	{
		n_onResult (p0);
	}

	private native void n_onResult (java.lang.Object p0);

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
