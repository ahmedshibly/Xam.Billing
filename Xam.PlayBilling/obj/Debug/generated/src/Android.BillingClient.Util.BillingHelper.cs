using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']"
	[global::Android.Runtime.Register ("com/android/billingclient/util/BillingHelper", DoNotGenerateAcw=true)]
	public sealed partial class BillingHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='DEBUG_MESSAGE']"
		[Register ("DEBUG_MESSAGE")]
		public const string DebugMessage = (string) "DEBUG_MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='EXTRA_PARAMS_DEVELOPER_PAYLOAD']"
		[Register ("EXTRA_PARAMS_DEVELOPER_PAYLOAD")]
		public const string ExtraParamsDeveloperPayload = (string) "developerPayload";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='EXTRA_PARAMS_ENABLE_PENDING_PURCHASES']"
		[Register ("EXTRA_PARAMS_ENABLE_PENDING_PURCHASES")]
		public const string ExtraParamsEnablePendingPurchases = (string) "enablePendingPurchases";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='EXTRA_PARAM_KEY_SKU_DETAILS_TOKEN']"
		[Register ("EXTRA_PARAM_KEY_SKU_DETAILS_TOKEN")]
		public const string ExtraParamKeySkuDetailsToken = (string) "skuDetailsToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='EXTRA_PARAM_KEY_SUBS_PRICE_CHANGE']"
		[Register ("EXTRA_PARAM_KEY_SUBS_PRICE_CHANGE")]
		public const string ExtraParamKeySubsPriceChange = (string) "subs_price_change";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='INAPP_CONTINUATION_TOKEN']"
		[Register ("INAPP_CONTINUATION_TOKEN")]
		public const string InappContinuationToken = (string) "INAPP_CONTINUATION_TOKEN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='LIBRARY_VERSION_KEY']"
		[Register ("LIBRARY_VERSION_KEY")]
		public const string LibraryVersionKey = (string) "playBillingLibraryVersion";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='NUMBER_OF_CORES']"
		[Register ("NUMBER_OF_CORES")]
		public static int NumberOfCores {
			get {
				const string __id = "NUMBER_OF_CORES.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "NUMBER_OF_CORES.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='RESPONSE_BUY_INTENT_KEY']"
		[Register ("RESPONSE_BUY_INTENT_KEY")]
		public const string ResponseBuyIntentKey = (string) "BUY_INTENT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='RESPONSE_CODE']"
		[Register ("RESPONSE_CODE")]
		public const string ResponseCode = (string) "RESPONSE_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='RESPONSE_GET_SKU_DETAILS_LIST']"
		[Register ("RESPONSE_GET_SKU_DETAILS_LIST")]
		public const string ResponseGetSkuDetailsList = (string) "DETAILS_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='RESPONSE_INAPP_ITEM_LIST']"
		[Register ("RESPONSE_INAPP_ITEM_LIST")]
		public const string ResponseInappItemList = (string) "INAPP_PURCHASE_ITEM_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='RESPONSE_INAPP_PURCHASE_DATA_LIST']"
		[Register ("RESPONSE_INAPP_PURCHASE_DATA_LIST")]
		public const string ResponseInappPurchaseDataList = (string) "INAPP_PURCHASE_DATA_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='RESPONSE_INAPP_SIGNATURE_LIST']"
		[Register ("RESPONSE_INAPP_SIGNATURE_LIST")]
		public const string ResponseInappSignatureList = (string) "INAPP_DATA_SIGNATURE_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/field[@name='RESPONSE_SUBS_MANAGEMENT_INTENT_KEY']"
		[Register ("RESPONSE_SUBS_MANAGEMENT_INTENT_KEY")]
		public const string ResponseSubsManagementIntentKey = (string) "SUBS_MANAGEMENT_INTENT";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/util/BillingHelper", typeof (BillingHelper));
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

		internal BillingHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/constructor[@name='BillingHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BillingHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='constructExtraParamsForAcknowledgePurchase' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.AcknowledgePurchaseParams']]"
		[Register ("constructExtraParamsForAcknowledgePurchase", "(Lcom/android/billingclient/api/AcknowledgePurchaseParams;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ConstructExtraParamsForAcknowledgePurchase (global::Android.BillingClient.Api.AcknowledgePurchaseParams acknowledgePurchaseParams)
		{
			const string __id = "constructExtraParamsForAcknowledgePurchase.(Lcom/android/billingclient/api/AcknowledgePurchaseParams;)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((acknowledgePurchaseParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) acknowledgePurchaseParams).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='constructExtraParamsForConsume' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.ConsumeParams'] and parameter[2][@type='boolean']]"
		[Register ("constructExtraParamsForConsume", "(Lcom/android/billingclient/api/ConsumeParams;Z)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ConstructExtraParamsForConsume (global::Android.BillingClient.Api.ConsumeParams consumeParams, bool isIabV9Supported)
		{
			const string __id = "constructExtraParamsForConsume.(Lcom/android/billingclient/api/ConsumeParams;Z)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((consumeParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumeParams).Handle);
				__args [1] = new JniArgumentValue (isIabV9Supported);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='constructExtraParamsForGetSkuDetails' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("constructExtraParamsForGetSkuDetails", "(ZZ)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ConstructExtraParamsForGetSkuDetails (bool isIabV9Supported, bool enablePendingPurchases)
		{
			const string __id = "constructExtraParamsForGetSkuDetails.(ZZ)Landroid/os/Bundle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (isIabV9Supported);
				__args [1] = new JniArgumentValue (enablePendingPurchases);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='constructExtraParamsForLaunchBillingFlow' and count(parameter)=4 and parameter[1][@type='com.android.billingclient.api.BillingFlowParams'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String']]"
		[Register ("constructExtraParamsForLaunchBillingFlow", "(Lcom/android/billingclient/api/BillingFlowParams;ZZLjava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ConstructExtraParamsForLaunchBillingFlow (global::Android.BillingClient.Api.BillingFlowParams @params, bool isIabV9Supported, bool enablePendingPurchases, string libraryVersion)
		{
			const string __id = "constructExtraParamsForLaunchBillingFlow.(Lcom/android/billingclient/api/BillingFlowParams;ZZLjava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_libraryVersion = JNIEnv.NewString (libraryVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [1] = new JniArgumentValue (isIabV9Supported);
				__args [2] = new JniArgumentValue (enablePendingPurchases);
				__args [3] = new JniArgumentValue (native_libraryVersion);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_libraryVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='constructExtraParamsForQueryPurchases' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register ("constructExtraParamsForQueryPurchases", "(ZZLjava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ConstructExtraParamsForQueryPurchases (bool isIabV9Supported, bool enablePendingPurchases, string libraryVersion)
		{
			const string __id = "constructExtraParamsForQueryPurchases.(ZZLjava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_libraryVersion = JNIEnv.NewString (libraryVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (isIabV9Supported);
				__args [1] = new JniArgumentValue (enablePendingPurchases);
				__args [2] = new JniArgumentValue (native_libraryVersion);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_libraryVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='extractPurchases' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("extractPurchases", "(Landroid/os/Bundle;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.BillingClient.Api.Purchase> ExtractPurchases (global::Android.OS.Bundle bundle)
		{
			const string __id = "extractPurchases.(Landroid/os/Bundle;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.BillingClient.Api.Purchase>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='getBillingResultFromIntent' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBillingResultFromIntent", "(Landroid/content/Intent;Ljava/lang/String;)Lcom/android/billingclient/api/BillingResult;", "")]
		public static unsafe global::Android.BillingClient.Api.BillingResult GetBillingResultFromIntent (global::Android.Content.Intent intent, string tag)
		{
			const string __id = "getBillingResultFromIntent.(Landroid/content/Intent;Ljava/lang/String;)Lcom/android/billingclient/api/BillingResult;";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_tag);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='getDebugMessageFromBundle' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDebugMessageFromBundle", "(Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetDebugMessageFromBundle (global::Android.OS.Bundle bundle, string tag)
		{
			const string __id = "getDebugMessageFromBundle.(Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				__args [1] = new JniArgumentValue (native_tag);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='getResponseCodeFromBundle' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("getResponseCodeFromBundle", "(Landroid/os/Bundle;Ljava/lang/String;)I", "")]
		public static unsafe int GetResponseCodeFromBundle (global::Android.OS.Bundle bundle, string tag)
		{
			const string __id = "getResponseCodeFromBundle.(Landroid/os/Bundle;Ljava/lang/String;)I";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				__args [1] = new JniArgumentValue (native_tag);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='getResponseCodeFromIntent' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("getResponseCodeFromIntent", "(Landroid/content/Intent;Ljava/lang/String;)I", "")]
		public static unsafe int GetResponseCodeFromIntent (global::Android.Content.Intent intent, string tag)
		{
			const string __id = "getResponseCodeFromIntent.(Landroid/content/Intent;Ljava/lang/String;)I";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_tag);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='logVerbose' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("logVerbose", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void LogVerbose (string tag, string msg)
		{
			const string __id = "logVerbose.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.util']/class[@name='BillingHelper']/method[@name='logWarn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("logWarn", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void LogWarn (string tag, string msg)
		{
			const string __id = "logWarn.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
