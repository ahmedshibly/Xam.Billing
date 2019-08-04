using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='PurchaseHistoryResponseListener']"
	[Register ("com/android/billingclient/api/PurchaseHistoryResponseListener", "", "Android.BillingClient.Api.IPurchaseHistoryResponseListenerInvoker")]
	public partial interface IPurchaseHistoryResponseListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='PurchaseHistoryResponseListener']/method[@name='onPurchaseHistoryResponse' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.BillingResult'] and parameter[2][@type='java.util.List&lt;com.android.billingclient.api.PurchaseHistoryRecord&gt;']]"
		[Register ("onPurchaseHistoryResponse", "(Lcom/android/billingclient/api/BillingResult;Ljava/util/List;)V", "GetOnPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_Handler:Android.BillingClient.Api.IPurchaseHistoryResponseListenerInvoker, Xam.PlayBilling")]
		void OnPurchaseHistoryResponse (global::Android.BillingClient.Api.BillingResult p0, global::System.Collections.Generic.IList<global::Android.BillingClient.Api.PurchaseHistoryRecord> p1);

	}

	[global::Android.Runtime.Register ("com/android/billingclient/api/PurchaseHistoryResponseListener", DoNotGenerateAcw=true)]
	internal class IPurchaseHistoryResponseListenerInvoker : global::Java.Lang.Object, IPurchaseHistoryResponseListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/PurchaseHistoryResponseListener", typeof (IPurchaseHistoryResponseListenerInvoker));

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

		public static IPurchaseHistoryResponseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPurchaseHistoryResponseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.PurchaseHistoryResponseListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPurchaseHistoryResponseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_Handler ()
		{
			if (cb_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_ == null)
				cb_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_);
			return cb_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_;
		}

		static void n_OnPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.IPurchaseHistoryResponseListener __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IPurchaseHistoryResponseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.BillingResult p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Android.BillingClient.Api.PurchaseHistoryRecord>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPurchaseHistoryResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_;
		public unsafe void OnPurchaseHistoryResponse (global::Android.BillingClient.Api.BillingResult p0, global::System.Collections.Generic.IList<global::Android.BillingClient.Api.PurchaseHistoryRecord> p1)
		{
			if (id_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_ == IntPtr.Zero)
				id_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onPurchaseHistoryResponse", "(Lcom/android/billingclient/api/BillingResult;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.BillingClient.Api.PurchaseHistoryRecord>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPurchaseHistoryResponse_Lcom_android_billingclient_api_BillingResult_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.android.billingclient.api.PurchaseHistoryResponseListener.onPurchaseHistoryResponse
	public partial class PurchaseHistoryResponseEventArgs : global::System.EventArgs {

		public PurchaseHistoryResponseEventArgs (global::Android.BillingClient.Api.BillingResult p0, global::System.Collections.Generic.IList<global::Android.BillingClient.Api.PurchaseHistoryRecord> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.BillingClient.Api.BillingResult p0;
		public global::Android.BillingClient.Api.BillingResult P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IList<global::Android.BillingClient.Api.PurchaseHistoryRecord> p1;
		public global::System.Collections.Generic.IList<global::Android.BillingClient.Api.PurchaseHistoryRecord> P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/android/billingclient/api/PurchaseHistoryResponseListenerImplementor")]
	internal sealed partial class IPurchaseHistoryResponseListenerImplementor : global::Java.Lang.Object, IPurchaseHistoryResponseListener {

		object sender;

		public IPurchaseHistoryResponseListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/android/billingclient/api/PurchaseHistoryResponseListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PurchaseHistoryResponseEventArgs> Handler;
#pragma warning restore 0649

		public void OnPurchaseHistoryResponse (global::Android.BillingClient.Api.BillingResult p0, global::System.Collections.Generic.IList<global::Android.BillingClient.Api.PurchaseHistoryRecord> p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PurchaseHistoryResponseEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IPurchaseHistoryResponseListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
