using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/PurchaseHistoryRecord", DoNotGenerateAcw=true)]
	public partial class PurchaseHistoryRecord : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/PurchaseHistoryRecord", typeof (PurchaseHistoryRecord));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected PurchaseHistoryRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']/constructor[@name='PurchaseHistoryRecord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PurchaseHistoryRecord (string jsonPurchaseInfo, string signature)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_jsonPurchaseInfo = JNIEnv.NewString (jsonPurchaseInfo);
			IntPtr native_signature = JNIEnv.NewString (signature);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_jsonPurchaseInfo);
				__args [1] = new JniArgumentValue (native_signature);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonPurchaseInfo);
				JNIEnv.DeleteLocalRef (native_signature);
			}
		}

		static Delegate cb_getDeveloperPayload;
#pragma warning disable 0169
		static Delegate GetGetDeveloperPayloadHandler ()
		{
			if (cb_getDeveloperPayload == null)
				cb_getDeveloperPayload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeveloperPayload);
			return cb_getDeveloperPayload;
		}

		static IntPtr n_GetDeveloperPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.PurchaseHistoryRecord __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PurchaseHistoryRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeveloperPayload);
		}
#pragma warning restore 0169

		public virtual unsafe string DeveloperPayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']/method[@name='getDeveloperPayload' and count(parameter)=0]"
			[Register ("getDeveloperPayload", "()Ljava/lang/String;", "GetGetDeveloperPayloadHandler")]
			get {
				const string __id = "getDeveloperPayload.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOriginalJson;
#pragma warning disable 0169
		static Delegate GetGetOriginalJsonHandler ()
		{
			if (cb_getOriginalJson == null)
				cb_getOriginalJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginalJson);
			return cb_getOriginalJson;
		}

		static IntPtr n_GetOriginalJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.PurchaseHistoryRecord __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PurchaseHistoryRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginalJson);
		}
#pragma warning restore 0169

		public virtual unsafe string OriginalJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']/method[@name='getOriginalJson' and count(parameter)=0]"
			[Register ("getOriginalJson", "()Ljava/lang/String;", "GetGetOriginalJsonHandler")]
			get {
				const string __id = "getOriginalJson.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPurchaseTime;
#pragma warning disable 0169
		static Delegate GetGetPurchaseTimeHandler ()
		{
			if (cb_getPurchaseTime == null)
				cb_getPurchaseTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPurchaseTime);
			return cb_getPurchaseTime;
		}

		static long n_GetPurchaseTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.PurchaseHistoryRecord __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PurchaseHistoryRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PurchaseTime;
		}
#pragma warning restore 0169

		public virtual unsafe long PurchaseTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']/method[@name='getPurchaseTime' and count(parameter)=0]"
			[Register ("getPurchaseTime", "()J", "GetGetPurchaseTimeHandler")]
			get {
				const string __id = "getPurchaseTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPurchaseToken;
#pragma warning disable 0169
		static Delegate GetGetPurchaseTokenHandler ()
		{
			if (cb_getPurchaseToken == null)
				cb_getPurchaseToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPurchaseToken);
			return cb_getPurchaseToken;
		}

		static IntPtr n_GetPurchaseToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.PurchaseHistoryRecord __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PurchaseHistoryRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PurchaseToken);
		}
#pragma warning restore 0169

		public virtual unsafe string PurchaseToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']/method[@name='getPurchaseToken' and count(parameter)=0]"
			[Register ("getPurchaseToken", "()Ljava/lang/String;", "GetGetPurchaseTokenHandler")]
			get {
				const string __id = "getPurchaseToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSignature;
#pragma warning disable 0169
		static Delegate GetGetSignatureHandler ()
		{
			if (cb_getSignature == null)
				cb_getSignature = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignature);
			return cb_getSignature;
		}

		static IntPtr n_GetSignature (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.PurchaseHistoryRecord __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PurchaseHistoryRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Signature);
		}
#pragma warning restore 0169

		public virtual unsafe string Signature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']/method[@name='getSignature' and count(parameter)=0]"
			[Register ("getSignature", "()Ljava/lang/String;", "GetGetSignatureHandler")]
			get {
				const string __id = "getSignature.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSku;
#pragma warning disable 0169
		static Delegate GetGetSkuHandler ()
		{
			if (cb_getSku == null)
				cb_getSku = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSku);
			return cb_getSku;
		}

		static IntPtr n_GetSku (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.PurchaseHistoryRecord __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PurchaseHistoryRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sku);
		}
#pragma warning restore 0169

		public virtual unsafe string Sku {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PurchaseHistoryRecord']/method[@name='getSku' and count(parameter)=0]"
			[Register ("getSku", "()Ljava/lang/String;", "GetGetSkuHandler")]
			get {
				const string __id = "getSku.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
