package md55c6f8e28dadd97f54a94144cb123839e;


public class WeatherDetails
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("WeatherBirdie.WeatherDetails, WeatherBirdie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WeatherDetails.class, __md_methods);
	}


	public WeatherDetails () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WeatherDetails.class)
			mono.android.TypeManager.Activate ("WeatherBirdie.WeatherDetails, WeatherBirdie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
