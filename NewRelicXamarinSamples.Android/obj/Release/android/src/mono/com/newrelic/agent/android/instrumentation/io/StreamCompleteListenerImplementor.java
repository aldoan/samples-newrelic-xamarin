package mono.com.newrelic.agent.android.instrumentation.io;


public class StreamCompleteListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.newrelic.agent.android.instrumentation.io.StreamCompleteListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_streamComplete:(Lcom/newrelic/agent/android/instrumentation/io/StreamCompleteEvent;)V:GetStreamComplete_Lcom_newrelic_agent_android_instrumentation_io_StreamCompleteEvent_Handler:NewRelicXamarin.Android.Instrumentations.IO.IStreamCompleteListenerInvoker, NewRelicXamarin.Android\n" +
			"n_streamError:(Lcom/newrelic/agent/android/instrumentation/io/StreamCompleteEvent;)V:GetStreamError_Lcom_newrelic_agent_android_instrumentation_io_StreamCompleteEvent_Handler:NewRelicXamarin.Android.Instrumentations.IO.IStreamCompleteListenerInvoker, NewRelicXamarin.Android\n" +
			"";
		mono.android.Runtime.register ("NewRelicXamarin.Android.Instrumentations.IO.IStreamCompleteListenerImplementor, NewRelicXamarin.Android", StreamCompleteListenerImplementor.class, __md_methods);
	}


	public StreamCompleteListenerImplementor ()
	{
		super ();
		if (getClass () == StreamCompleteListenerImplementor.class)
			mono.android.TypeManager.Activate ("NewRelicXamarin.Android.Instrumentations.IO.IStreamCompleteListenerImplementor, NewRelicXamarin.Android", "", this, new java.lang.Object[] {  });
	}


	public void streamComplete (com.newrelic.agent.android.instrumentation.io.StreamCompleteEvent p0)
	{
		n_streamComplete (p0);
	}

	private native void n_streamComplete (com.newrelic.agent.android.instrumentation.io.StreamCompleteEvent p0);


	public void streamError (com.newrelic.agent.android.instrumentation.io.StreamCompleteEvent p0)
	{
		n_streamError (p0);
	}

	private native void n_streamError (com.newrelic.agent.android.instrumentation.io.StreamCompleteEvent p0);

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
