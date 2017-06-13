package mono.com.microsoft.azure.mobile.utils;


public class NetworkStateHelper_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microsoft.azure.mobile.utils.NetworkStateHelper.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNetworkStateUpdated:(Z)V:GetOnNetworkStateUpdated_ZHandler:Com.Microsoft.Azure.Mobile.Utils.NetworkStateHelper/IListenerInvoker, Microsoft.Azure.Mobile.Android.Bindings\n" +
			"";
		mono.android.Runtime.register ("Com.Microsoft.Azure.Mobile.Utils.NetworkStateHelper+IListenerImplementor, Microsoft.Azure.Mobile.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", NetworkStateHelper_ListenerImplementor.class, __md_methods);
	}


	public NetworkStateHelper_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NetworkStateHelper_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Microsoft.Azure.Mobile.Utils.NetworkStateHelper+IListenerImplementor, Microsoft.Azure.Mobile.Android.Bindings, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onNetworkStateUpdated (boolean p0)
	{
		n_onNetworkStateUpdated (p0);
	}

	private native void n_onNetworkStateUpdated (boolean p0);

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
