using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='PriceChangeConfirmationListener']"
	[Register ("com/android/billingclient/api/PriceChangeConfirmationListener", "", "Android.BillingClient.Api.IPriceChangeConfirmationListenerInvoker")]
	public partial interface IPriceChangeConfirmationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='PriceChangeConfirmationListener']/method[@name='onPriceChangeConfirmationResult' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.BillingResult']]"
		[Register ("onPriceChangeConfirmationResult", "(Lcom/android/billingclient/api/BillingResult;)V", "GetOnPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_Handler:Android.BillingClient.Api.IPriceChangeConfirmationListenerInvoker, Xam.PlayBilling")]
		void OnPriceChangeConfirmationResult (global::Android.BillingClient.Api.BillingResult p0);

	}

	[global::Android.Runtime.Register ("com/android/billingclient/api/PriceChangeConfirmationListener", DoNotGenerateAcw=true)]
	internal class IPriceChangeConfirmationListenerInvoker : global::Java.Lang.Object, IPriceChangeConfirmationListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/PriceChangeConfirmationListener", typeof (IPriceChangeConfirmationListenerInvoker));

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

		public static IPriceChangeConfirmationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPriceChangeConfirmationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.PriceChangeConfirmationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPriceChangeConfirmationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_;
#pragma warning disable 0169
		static Delegate GetOnPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_Handler ()
		{
			if (cb_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_ == null)
				cb_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_);
			return cb_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_;
		}

		static void n_OnPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.BillingClient.Api.IPriceChangeConfirmationListener __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IPriceChangeConfirmationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.BillingResult p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPriceChangeConfirmationResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_;
		public unsafe void OnPriceChangeConfirmationResult (global::Android.BillingClient.Api.BillingResult p0)
		{
			if (id_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_ == IntPtr.Zero)
				id_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_ = JNIEnv.GetMethodID (class_ref, "onPriceChangeConfirmationResult", "(Lcom/android/billingclient/api/BillingResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPriceChangeConfirmationResult_Lcom_android_billingclient_api_BillingResult_, __args);
		}

	}

	// event args for com.android.billingclient.api.PriceChangeConfirmationListener.onPriceChangeConfirmationResult
	public partial class PriceChangeConfirmationEventArgs : global::System.EventArgs {

		public PriceChangeConfirmationEventArgs (global::Android.BillingClient.Api.BillingResult p0)
		{
			this.p0 = p0;
		}

		global::Android.BillingClient.Api.BillingResult p0;
		public global::Android.BillingClient.Api.BillingResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/android/billingclient/api/PriceChangeConfirmationListenerImplementor")]
	internal sealed partial class IPriceChangeConfirmationListenerImplementor : global::Java.Lang.Object, IPriceChangeConfirmationListener {

		object sender;

		public IPriceChangeConfirmationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/android/billingclient/api/PriceChangeConfirmationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PriceChangeConfirmationEventArgs> Handler;
#pragma warning restore 0649

		public void OnPriceChangeConfirmationResult (global::Android.BillingClient.Api.BillingResult p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PriceChangeConfirmationEventArgs (p0));
		}

		internal static bool __IsEmpty (IPriceChangeConfirmationListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
