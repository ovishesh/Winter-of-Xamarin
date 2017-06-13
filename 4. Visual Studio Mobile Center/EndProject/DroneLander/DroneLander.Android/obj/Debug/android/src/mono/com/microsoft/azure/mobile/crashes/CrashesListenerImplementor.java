package mono.com.microsoft.azure.mobile.crashes;


public class CrashesListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microsoft.azure.mobile.crashes.CrashesListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getErrorAttachments:(Lcom/microsoft/azure/mobile/crashes/model/ErrorReport;)Ljava/lang/Iterable;:GetGetErrorAttachments_Lcom_microsoft_azure_mobile_crashes_model_ErrorReport_Handler:Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerInvoker, Microsoft.Azure.Mobile.Crashes.Android.Bindings\n" +
			"n_onBeforeSending:(Lcom/microsoft/azure/mobile/crashes/model/ErrorReport;)V:GetOnBeforeSending_Lcom_microsoft_azure_mobile_crashes_model_ErrorReport_Handler:Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerInvoker, Microsoft.Azure.Mobile.Crashes.Android.Bindings\n" +
			"n_onSendingFailed:(Lcom/microsoft/azure/mobile/crashes/model/ErrorReport;Ljava/lang/Exception;)V:GetOnSendingFailed_Lcom_microsoft_azure_mobile_crashes_model_ErrorReport_Ljava_lang_Exception_Handler:Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerInvoker, Microsoft.Azure.Mobile.Crashes.Android.Bindings\n" +
			"n_onSendingSucceeded:(Lcom/microsoft/azure/mobile/crashes/model/ErrorReport;)V:GetOnSendingSucceeded_Lcom_microsoft_azure_mobile_crashes_model_ErrorReport_Handler:Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerInvoker, Microsoft.Azure.Mobile.Crashes.Android.Bindings\n" +
			"n_shouldAwaitUserConfirmation:()Z:GetShouldAwaitUserConfirmationHandler:Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerInvoker, Microsoft.Azure.Mobile.Crashes.Android.Bindings\n" +
			"n_shouldProcess:(Lcom/microsoft/azure/mobile/crashes/model/ErrorReport;)Z:GetShouldProcess_Lcom_microsoft_azure_mobile_crashes_model_ErrorReport_Handler:Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerInvoker, Microsoft.Azure.Mobile.Crashes.Android.Bindings\n" +
			"";
		mono.android.Runtime.register ("Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerImplementor, Microsoft.Azure.Mobile.Crashes.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", CrashesListenerImplementor.class, __md_methods);
	}


	public CrashesListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CrashesListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microsoft.Azure.Mobile.Crashes.ICrashesListenerImplementor, Microsoft.Azure.Mobile.Crashes.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public java.lang.Iterable getErrorAttachments (com.microsoft.azure.mobile.crashes.model.ErrorReport p0)
	{
		return n_getErrorAttachments (p0);
	}

	private native java.lang.Iterable n_getErrorAttachments (com.microsoft.azure.mobile.crashes.model.ErrorReport p0);


	public void onBeforeSending (com.microsoft.azure.mobile.crashes.model.ErrorReport p0)
	{
		n_onBeforeSending (p0);
	}

	private native void n_onBeforeSending (com.microsoft.azure.mobile.crashes.model.ErrorReport p0);


	public void onSendingFailed (com.microsoft.azure.mobile.crashes.model.ErrorReport p0, java.lang.Exception p1)
	{
		n_onSendingFailed (p0, p1);
	}

	private native void n_onSendingFailed (com.microsoft.azure.mobile.crashes.model.ErrorReport p0, java.lang.Exception p1);


	public void onSendingSucceeded (com.microsoft.azure.mobile.crashes.model.ErrorReport p0)
	{
		n_onSendingSucceeded (p0);
	}

	private native void n_onSendingSucceeded (com.microsoft.azure.mobile.crashes.model.ErrorReport p0);


	public boolean shouldAwaitUserConfirmation ()
	{
		return n_shouldAwaitUserConfirmation ();
	}

	private native boolean n_shouldAwaitUserConfirmation ();


	public boolean shouldProcess (com.microsoft.azure.mobile.crashes.model.ErrorReport p0)
	{
		return n_shouldProcess (p0);
	}

	private native boolean n_shouldProcess (com.microsoft.azure.mobile.crashes.model.ErrorReport p0);

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
