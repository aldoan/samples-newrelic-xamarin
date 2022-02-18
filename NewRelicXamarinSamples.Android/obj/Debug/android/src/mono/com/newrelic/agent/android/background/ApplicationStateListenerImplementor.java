package mono.com.newrelic.agent.android.background;


public class ApplicationStateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.newrelic.agent.android.background.ApplicationStateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_applicationBackgrounded:(Lcom/newrelic/agent/android/background/ApplicationStateEvent;)V:GetApplicationBackgrounded_Lcom_newrelic_agent_android_background_ApplicationStateEvent_Handler:NewRelicXamarin.Android.Background.IApplicationStateListenerInvoker, NewRelicXamarin.Android\n" +
			"n_applicationForegrounded:(Lcom/newrelic/agent/android/background/ApplicationStateEvent;)V:GetApplicationForegrounded_Lcom_newrelic_agent_android_background_ApplicationStateEvent_Handler:NewRelicXamarin.Android.Background.IApplicationStateListenerInvoker, NewRelicXamarin.Android\n" +
			"";
		mono.android.Runtime.register ("NewRelicXamarin.Android.Background.IApplicationStateListenerImplementor, NewRelicXamarin.Android", ApplicationStateListenerImplementor.class, __md_methods);
	}


	public ApplicationStateListenerImplementor ()
	{
		super ();
		if (getClass () == ApplicationStateListenerImplementor.class)
			mono.android.TypeManager.Activate ("NewRelicXamarin.Android.Background.IApplicationStateListenerImplementor, NewRelicXamarin.Android", "", this, new java.lang.Object[] {  });
	}


	public void applicationBackgrounded (com.newrelic.agent.android.background.ApplicationStateEvent p0)
	{
		n_applicationBackgrounded (p0);
	}

	private native void n_applicationBackgrounded (com.newrelic.agent.android.background.ApplicationStateEvent p0);


	public void applicationForegrounded (com.newrelic.agent.android.background.ApplicationStateEvent p0)
	{
		n_applicationForegrounded (p0);
	}

	private native void n_applicationForegrounded (com.newrelic.agent.android.background.ApplicationStateEvent p0);

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
