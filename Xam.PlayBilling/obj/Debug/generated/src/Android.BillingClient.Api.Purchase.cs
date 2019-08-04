using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/Purchase", DoNotGenerateAcw=true)]
	public partial class Purchase : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase.PurchasesResult']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/Purchase$PurchasesResult", DoNotGenerateAcw=true)]
		public partial class PurchasesResult : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/Purchase$PurchasesResult", typeof (PurchasesResult));
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

			protected PurchasesResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase.PurchasesResult']/constructor[@name='Purchase.PurchasesResult' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.BillingResult'] and parameter[2][@type='java.util.List&lt;com.android.billingclient.api.Purchase&gt;']]"
			[Register (".ctor", "(Lcom/android/billingclient/api/BillingResult;Ljava/util/List;)V", "")]
			public unsafe PurchasesResult (global::Android.BillingClient.Api.BillingResult mBillingResult, global::System.Collections.Generic.IList<global::Android.BillingClient.Api.Purchase> purchasesList)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/android/billingclient/api/BillingResult;Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_purchasesList = global::Android.Runtime.JavaList<global::Android.BillingClient.Api.Purchase>.ToLocalJniHandle (purchasesList);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((mBillingResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mBillingResult).Handle);
					__args [1] = new JniArgumentValue (native_purchasesList);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_purchasesList);
				}
			}

			static Delegate cb_getBillingResult;
#pragma warning disable 0169
			static Delegate GetGetBillingResultHandler ()
			{
				if (cb_getBillingResult == null)
					cb_getBillingResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBillingResult);
				return cb_getBillingResult;
			}

			static IntPtr n_GetBillingResult (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.Purchase.PurchasesResult __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase.PurchasesResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BillingResult);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.BillingClient.Api.BillingResult BillingResult {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase.PurchasesResult']/method[@name='getBillingResult' and count(parameter)=0]"
				[Register ("getBillingResult", "()Lcom/android/billingclient/api/BillingResult;", "GetGetBillingResultHandler")]
				get {
					const string __id = "getBillingResult.()Lcom/android/billingclient/api/BillingResult;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPurchasesList;
#pragma warning disable 0169
			static Delegate GetGetPurchasesListHandler ()
			{
				if (cb_getPurchasesList == null)
					cb_getPurchasesList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPurchasesList);
				return cb_getPurchasesList;
			}

			static IntPtr n_GetPurchasesList (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.Purchase.PurchasesResult __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase.PurchasesResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Android.BillingClient.Api.Purchase>.ToLocalJniHandle (__this.PurchasesList);
			}
#pragma warning restore 0169

			public virtual unsafe global::System.Collections.Generic.IList<global::Android.BillingClient.Api.Purchase> PurchasesList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase.PurchasesResult']/method[@name='getPurchasesList' and count(parameter)=0]"
				[Register ("getPurchasesList", "()Ljava/util/List;", "GetGetPurchasesListHandler")]
				get {
					const string __id = "getPurchasesList.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Android.BillingClient.Api.Purchase>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getResponseCode;
#pragma warning disable 0169
			static Delegate GetGetResponseCodeHandler ()
			{
				if (cb_getResponseCode == null)
					cb_getResponseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResponseCode);
				return cb_getResponseCode;
			}

			static int n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.Purchase.PurchasesResult __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase.PurchasesResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ResponseCode;
			}
#pragma warning restore 0169

			public virtual unsafe int ResponseCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase.PurchasesResult']/method[@name='getResponseCode' and count(parameter)=0]"
				[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
				get {
					const string __id = "getResponseCode.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/Purchase", typeof (Purchase));
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

		protected Purchase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/constructor[@name='Purchase' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Purchase (string jsonPurchaseInfo, string signature)
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
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeveloperPayload);
		}
#pragma warning restore 0169

		public virtual unsafe string DeveloperPayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getDeveloperPayload' and count(parameter)=0]"
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

		static Delegate cb_isAcknowledged;
#pragma warning disable 0169
		static Delegate GetIsAcknowledgedHandler ()
		{
			if (cb_isAcknowledged == null)
				cb_isAcknowledged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAcknowledged);
			return cb_isAcknowledged;
		}

		static bool n_IsAcknowledged (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAcknowledged;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAcknowledged {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='isAcknowledged' and count(parameter)=0]"
			[Register ("isAcknowledged", "()Z", "GetIsAcknowledgedHandler")]
			get {
				const string __id = "isAcknowledged.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAutoRenewing;
#pragma warning disable 0169
		static Delegate GetIsAutoRenewingHandler ()
		{
			if (cb_isAutoRenewing == null)
				cb_isAutoRenewing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoRenewing);
			return cb_isAutoRenewing;
		}

		static bool n_IsAutoRenewing (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoRenewing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAutoRenewing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='isAutoRenewing' and count(parameter)=0]"
			[Register ("isAutoRenewing", "()Z", "GetIsAutoRenewingHandler")]
			get {
				const string __id = "isAutoRenewing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOrderId;
#pragma warning disable 0169
		static Delegate GetGetOrderIdHandler ()
		{
			if (cb_getOrderId == null)
				cb_getOrderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrderId);
			return cb_getOrderId;
		}

		static IntPtr n_GetOrderId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrderId);
		}
#pragma warning restore 0169

		public virtual unsafe string OrderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getOrderId' and count(parameter)=0]"
			[Register ("getOrderId", "()Ljava/lang/String;", "GetGetOrderIdHandler")]
			get {
				const string __id = "getOrderId.()Ljava/lang/String;";
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
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginalJson);
		}
#pragma warning restore 0169

		public virtual unsafe string OriginalJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getOriginalJson' and count(parameter)=0]"
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

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPurchaseState;
#pragma warning disable 0169
		static Delegate GetGetPurchaseStateHandler ()
		{
			if (cb_getPurchaseState == null)
				cb_getPurchaseState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPurchaseState);
			return cb_getPurchaseState;
		}

		static int n_GetPurchaseState (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return (int) __this.PurchaseState;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.BillingClient.Api.PurchaseState PurchaseState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getPurchaseState' and count(parameter)=0]"
			[Register ("getPurchaseState", "()I", "GetGetPurchaseStateHandler")]
			get {
				const string __id = "getPurchaseState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return (global::Android.BillingClient.Api.PurchaseState) __rm;
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
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PurchaseTime;
		}
#pragma warning restore 0169

		public virtual unsafe long PurchaseTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getPurchaseTime' and count(parameter)=0]"
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
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PurchaseToken);
		}
#pragma warning restore 0169

		public virtual unsafe string PurchaseToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getPurchaseToken' and count(parameter)=0]"
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
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Signature);
		}
#pragma warning restore 0169

		public virtual unsafe string Signature {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getSignature' and count(parameter)=0]"
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
			global::Android.BillingClient.Api.Purchase __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sku);
		}
#pragma warning restore 0169

		public virtual unsafe string Sku {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='Purchase']/method[@name='getSku' and count(parameter)=0]"
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
