using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='RewardResponseListener']"
	[Register ("com/android/billingclient/api/RewardResponseListener", "", "Android.BillingClient.Api.IRewardResponseListenerInvoker")]
	public partial interface IRewardResponseListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='RewardResponseListener']/method[@name='onRewardResponse' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.BillingResult']]"
		[Register ("onRewardResponse", "(Lcom/android/billingclient/api/BillingResult;)V", "GetOnRewardResponse_Lcom_android_billingclient_api_BillingResult_Handler:Android.BillingClient.Api.IRewardResponseListenerInvoker, Xam.PlayBilling")]
		void OnRewardResponse (global::Android.BillingClient.Api.BillingResult p0);

	}

	[global::Android.Runtime.Register ("com/android/billingclient/api/RewardResponseListener", DoNotGenerateAcw=true)]
	internal class IRewardResponseListenerInvoker : global::Java.Lang.Object, IRewardResponseListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/RewardResponseListener", typeof (IRewardResponseListenerInvoker));

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

		public static IRewardResponseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRewardResponseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.RewardResponseListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRewardResponseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRewardResponse_Lcom_android_billingclient_api_BillingResult_;
#pragma warning disable 0169
		static Delegate GetOnRewardResponse_Lcom_android_billingclient_api_BillingResult_Handler ()
		{
			if (cb_onRewardResponse_Lcom_android_billingclient_api_BillingResult_ == null)
				cb_onRewardResponse_Lcom_android_billingclient_api_BillingResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRewardResponse_Lcom_android_billingclient_api_BillingResult_);
			return cb_onRewardResponse_Lcom_android_billingclient_api_BillingResult_;
		}

		static void n_OnRewardResponse_Lcom_android_billingclient_api_BillingResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.BillingClient.Api.IRewardResponseListener __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IRewardResponseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.BillingResult p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardResponse_Lcom_android_billingclient_api_BillingResult_;
		public unsafe void OnRewardResponse (global::Android.BillingClient.Api.BillingResult p0)
		{
			if (id_onRewardResponse_Lcom_android_billingclient_api_BillingResult_ == IntPtr.Zero)
				id_onRewardResponse_Lcom_android_billingclient_api_BillingResult_ = JNIEnv.GetMethodID (class_ref, "onRewardResponse", "(Lcom/android/billingclient/api/BillingResult;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardResponse_Lcom_android_billingclient_api_BillingResult_, __args);
		}

	}

	// event args for com.android.billingclient.api.RewardResponseListener.onRewardResponse
	public partial class RewardResponseEventArgs : global::System.EventArgs {

		public RewardResponseEventArgs (global::Android.BillingClient.Api.BillingResult p0)
		{
			this.p0 = p0;
		}

		global::Android.BillingClient.Api.BillingResult p0;
		public global::Android.BillingClient.Api.BillingResult P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/android/billingclient/api/RewardResponseListenerImplementor")]
	internal sealed partial class IRewardResponseListenerImplementor : global::Java.Lang.Object, IRewardResponseListener {

		object sender;

		public IRewardResponseListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/android/billingclient/api/RewardResponseListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RewardResponseEventArgs> Handler;
#pragma warning restore 0649

		public void OnRewardResponse (global::Android.BillingClient.Api.BillingResult p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new RewardResponseEventArgs (p0));
		}

		internal static bool __IsEmpty (IRewardResponseListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
