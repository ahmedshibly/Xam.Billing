using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='ConsumeResponseListener']"
	[Register ("com/android/billingclient/api/ConsumeResponseListener", "", "Android.BillingClient.Api.IConsumeResponseListenerInvoker")]
	public partial interface IConsumeResponseListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='ConsumeResponseListener']/method[@name='onConsumeResponse' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.BillingResult'] and parameter[2][@type='java.lang.String']]"
		[Register ("onConsumeResponse", "(Lcom/android/billingclient/api/BillingResult;Ljava/lang/String;)V", "GetOnConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_Handler:Android.BillingClient.Api.IConsumeResponseListenerInvoker, Xam.PlayBilling")]
		void OnConsumeResponse (global::Android.BillingClient.Api.BillingResult p0, string p1);

	}

	[global::Android.Runtime.Register ("com/android/billingclient/api/ConsumeResponseListener", DoNotGenerateAcw=true)]
	internal class IConsumeResponseListenerInvoker : global::Java.Lang.Object, IConsumeResponseListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/ConsumeResponseListener", typeof (IConsumeResponseListenerInvoker));

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

		public static IConsumeResponseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConsumeResponseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.ConsumeResponseListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConsumeResponseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_Handler ()
		{
			if (cb_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_ == null)
				cb_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_);
			return cb_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_;
		}

		static void n_OnConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.IConsumeResponseListener __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IConsumeResponseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.BillingResult p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnConsumeResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_;
		public unsafe void OnConsumeResponse (global::Android.BillingClient.Api.BillingResult p0, string p1)
		{
			if (id_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_ == IntPtr.Zero)
				id_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConsumeResponse", "(Lcom/android/billingclient/api/BillingResult;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConsumeResponse_Lcom_android_billingclient_api_BillingResult_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.android.billingclient.api.ConsumeResponseListener.onConsumeResponse
	public partial class ConsumeResponseEventArgs : global::System.EventArgs {

		public ConsumeResponseEventArgs (global::Android.BillingClient.Api.BillingResult p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.BillingClient.Api.BillingResult p0;
		public global::Android.BillingClient.Api.BillingResult P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/android/billingclient/api/ConsumeResponseListenerImplementor")]
	internal sealed partial class IConsumeResponseListenerImplementor : global::Java.Lang.Object, IConsumeResponseListener {

		object sender;

		public IConsumeResponseListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/android/billingclient/api/ConsumeResponseListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConsumeResponseEventArgs> Handler;
#pragma warning restore 0649

		public void OnConsumeResponse (global::Android.BillingClient.Api.BillingResult p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ConsumeResponseEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IConsumeResponseListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
