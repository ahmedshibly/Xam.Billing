using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClientStateListener']"
	[Register ("com/android/billingclient/api/BillingClientStateListener", "", "Android.BillingClient.Api.IBillingClientStateListenerInvoker")]
	public partial interface IBillingClientStateListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClientStateListener']/method[@name='onBillingServiceDisconnected' and count(parameter)=0]"
		[Register ("onBillingServiceDisconnected", "()V", "GetOnBillingServiceDisconnectedHandler:Android.BillingClient.Api.IBillingClientStateListenerInvoker, Xam.PlayBilling")]
		void OnBillingServiceDisconnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClientStateListener']/method[@name='onBillingSetupFinished' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.BillingResult']]"
		[Register ("onBillingSetupFinished", "(Lcom/android/billingclient/api/BillingResult;)V", "GetOnBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_Handler:Android.BillingClient.Api.IBillingClientStateListenerInvoker, Xam.PlayBilling")]
		void OnBillingSetupFinished (global::Android.BillingClient.Api.BillingResult p0);

	}

	[global::Android.Runtime.Register ("com/android/billingclient/api/BillingClientStateListener", DoNotGenerateAcw=true)]
	internal class IBillingClientStateListenerInvoker : global::Java.Lang.Object, IBillingClientStateListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/BillingClientStateListener", typeof (IBillingClientStateListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBillingClientStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBillingClientStateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.BillingClientStateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBillingClientStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBillingServiceDisconnected;
#pragma warning disable 0169
		static Delegate GetOnBillingServiceDisconnectedHandler ()
		{
			if (cb_onBillingServiceDisconnected == null)
				cb_onBillingServiceDisconnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBillingServiceDisconnected);
			return cb_onBillingServiceDisconnected;
		}

		static void n_OnBillingServiceDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.IBillingClientStateListener __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IBillingClientStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBillingServiceDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_onBillingServiceDisconnected;
		public unsafe void OnBillingServiceDisconnected ()
		{
			if (id_onBillingServiceDisconnected == IntPtr.Zero)
				id_onBillingServiceDisconnected = JNIEnv.GetMethodID (class_ref, "onBillingServiceDisconnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBillingServiceDisconnected);
		}

		static Delegate cb_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_;
#pragma warning disable 0169
		static Delegate GetOnBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_Handler ()
		{
			if (cb_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_ == null)
				cb_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_);
			return cb_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_;
		}

		static void n_OnBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.BillingClient.Api.IBillingClientStateListener __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IBillingClientStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.BillingResult p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBillingSetupFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_;
		public unsafe void OnBillingSetupFinished (global::Android.BillingClient.Api.BillingResult p0)
		{
			if (id_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_ == IntPtr.Zero)
				id_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_ = JNIEnv.GetMethodID (class_ref, "onBillingSetupFinished", "(Lcom/android/billingclient/api/BillingResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBillingSetupFinished_Lcom_android_billingclient_api_BillingResult_, __args);
		}

	}

	// event args for com.android.billingclient.api.BillingClientStateListener.onBillingSetupFinished
	public partial class BillingSetupFinishedEventArgs : global::System.EventArgs {

		public BillingSetupFinishedEventArgs (global::Android.BillingClient.Api.BillingResult p0)
		{
			this.p0 = p0;
		}

		global::Android.BillingClient.Api.BillingResult p0;
		public global::Android.BillingClient.Api.BillingResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/android/billingclient/api/BillingClientStateListenerImplementor")]
	internal sealed partial class IBillingClientStateListenerImplementor : global::Java.Lang.Object, IBillingClientStateListener {

		object sender;

		public IBillingClientStateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/android/billingclient/api/BillingClientStateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnBillingServiceDisconnectedHandler;
#pragma warning restore 0649

		public void OnBillingServiceDisconnected ()
		{
			var __h = OnBillingServiceDisconnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<BillingSetupFinishedEventArgs> OnBillingSetupFinishedHandler;
#pragma warning restore 0649

		public void OnBillingSetupFinished (global::Android.BillingClient.Api.BillingResult p0)
		{
			var __h = OnBillingSetupFinishedHandler;
			if (__h != null)
				__h (sender, new BillingSetupFinishedEventArgs (p0));
		}

		internal static bool __IsEmpty (IBillingClientStateListenerImplementor value)
		{
			return value.OnBillingServiceDisconnectedHandler == null && value.OnBillingSetupFinishedHandler == null;
		}
	}

}
