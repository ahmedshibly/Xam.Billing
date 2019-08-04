using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/BillingFlowParams", DoNotGenerateAcw=true)]
	public partial class BillingFlowParams : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_CHILD_DIRECTED']"
		[Register ("EXTRA_PARAM_CHILD_DIRECTED")]
		public const string ExtraParamChildDirected = (string) "childDirected";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_KEY_ACCOUNT_ID']"
		[Register ("EXTRA_PARAM_KEY_ACCOUNT_ID")]
		public const string ExtraParamKeyAccountId = (string) "accountId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_KEY_DEVELOPER_ID']"
		[Register ("EXTRA_PARAM_KEY_DEVELOPER_ID")]
		public const string ExtraParamKeyDeveloperId = (string) "developerId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_KEY_OLD_SKUS']"
		[Register ("EXTRA_PARAM_KEY_OLD_SKUS")]
		public const string ExtraParamKeyOldSkus = (string) "skusToReplace";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_KEY_REPLACE_SKUS_PRORATION_MODE']"
		[Register ("EXTRA_PARAM_KEY_REPLACE_SKUS_PRORATION_MODE")]
		public const string ExtraParamKeyReplaceSkusProrationMode = (string) "prorationMode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_KEY_RSKU']"
		[Register ("EXTRA_PARAM_KEY_RSKU")]
		public const string ExtraParamKeyRsku = (string) "rewardToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_KEY_VR']"
		[Register ("EXTRA_PARAM_KEY_VR")]
		public const string ExtraParamKeyVr = (string) "vr";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/field[@name='EXTRA_PARAM_UNDER_AGE_OF_CONSENT']"
		[Register ("EXTRA_PARAM_UNDER_AGE_OF_CONSENT")]
		public const string ExtraParamUnderAgeOfConsent = (string) "underAgeOfConsent";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/BillingFlowParams$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/BillingFlowParams$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_addOldSku_Ljava_lang_String_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetAddOldSku_Ljava_lang_String_Handler ()
			{
				if (cb_addOldSku_Ljava_lang_String_ == null)
					cb_addOldSku_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOldSku_Ljava_lang_String_);
				return cb_addOldSku_Ljava_lang_String_;
			}

			[Obsolete]
			static IntPtr n_AddOldSku_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldSku)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string oldSku = JNIEnv.GetString (native_oldSku, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOldSku (oldSku));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='addOldSku' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("addOldSku", "(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetAddOldSku_Ljava_lang_String_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder AddOldSku (string oldSku)
			{
				const string __id = "addOldSku.(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				IntPtr native_oldSku = JNIEnv.NewString (oldSku);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_oldSku);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_oldSku);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/android/billingclient/api/BillingFlowParams;", "GetBuildHandler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams Build ()
			{
				const string __id = "build.()Lcom/android/billingclient/api/BillingFlowParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAccountId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAccountId_Ljava_lang_String_Handler ()
			{
				if (cb_setAccountId_Ljava_lang_String_ == null)
					cb_setAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccountId_Ljava_lang_String_);
				return cb_setAccountId_Ljava_lang_String_;
			}

			static IntPtr n_SetAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accountId)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string accountId = JNIEnv.GetString (native_accountId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccountId (accountId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='setAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountId", "(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetSetAccountId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder SetAccountId (string accountId)
			{
				const string __id = "setAccountId.(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				IntPtr native_accountId = JNIEnv.NewString (accountId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_accountId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_accountId);
				}
			}

			static Delegate cb_setDeveloperId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDeveloperId_Ljava_lang_String_Handler ()
			{
				if (cb_setDeveloperId_Ljava_lang_String_ == null)
					cb_setDeveloperId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDeveloperId_Ljava_lang_String_);
				return cb_setDeveloperId_Ljava_lang_String_;
			}

			static IntPtr n_SetDeveloperId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_developerId)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string developerId = JNIEnv.GetString (native_developerId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDeveloperId (developerId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='setDeveloperId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeveloperId", "(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetSetDeveloperId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder SetDeveloperId (string developerId)
			{
				const string __id = "setDeveloperId.(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				IntPtr native_developerId = JNIEnv.NewString (developerId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_developerId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_developerId);
				}
			}

			static Delegate cb_setOldSku_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetOldSku_Ljava_lang_String_Handler ()
			{
				if (cb_setOldSku_Ljava_lang_String_ == null)
					cb_setOldSku_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOldSku_Ljava_lang_String_);
				return cb_setOldSku_Ljava_lang_String_;
			}

			static IntPtr n_SetOldSku_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldSku)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string oldSku = JNIEnv.GetString (native_oldSku, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOldSku (oldSku));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='setOldSku' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOldSku", "(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetSetOldSku_Ljava_lang_String_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder SetOldSku (string oldSku)
			{
				const string __id = "setOldSku.(Ljava/lang/String;)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				IntPtr native_oldSku = JNIEnv.NewString (oldSku);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_oldSku);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_oldSku);
				}
			}

			static Delegate cb_setOldSkus_Ljava_util_ArrayList_;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetSetOldSkus_Ljava_util_ArrayList_Handler ()
			{
				if (cb_setOldSkus_Ljava_util_ArrayList_ == null)
					cb_setOldSkus_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOldSkus_Ljava_util_ArrayList_);
				return cb_setOldSkus_Ljava_util_ArrayList_;
			}

			[Obsolete]
			static IntPtr n_SetOldSkus_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldSkus)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var oldSkus = global::Android.Runtime.JavaList<string>.FromJniHandle (native_oldSkus, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOldSkus (oldSkus));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='setOldSkus' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
			[Obsolete (@"deprecated")]
			[Register ("setOldSkus", "(Ljava/util/ArrayList;)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetSetOldSkus_Ljava_util_ArrayList_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder SetOldSkus (global::System.Collections.Generic.IList<string> oldSkus)
			{
				const string __id = "setOldSkus.(Ljava/util/ArrayList;)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				IntPtr native_oldSkus = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (oldSkus);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_oldSkus);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_oldSkus);
				}
			}

			static Delegate cb_setReplaceSkusProrationMode_I;
#pragma warning disable 0169
			static Delegate GetSetReplaceSkusProrationMode_IHandler ()
			{
				if (cb_setReplaceSkusProrationMode_I == null)
					cb_setReplaceSkusProrationMode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReplaceSkusProrationMode_I);
				return cb_setReplaceSkusProrationMode_I;
			}

			static IntPtr n_SetReplaceSkusProrationMode_I (IntPtr jnienv, IntPtr native__this, int replaceSkusProrationMode)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetReplaceSkusProrationMode (replaceSkusProrationMode));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='setReplaceSkusProrationMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReplaceSkusProrationMode", "(I)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetSetReplaceSkusProrationMode_IHandler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder SetReplaceSkusProrationMode (int replaceSkusProrationMode)
			{
				const string __id = "setReplaceSkusProrationMode.(I)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (replaceSkusProrationMode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSkuDetails_Lcom_android_billingclient_api_SkuDetails_;
#pragma warning disable 0169
			static Delegate GetSetSkuDetails_Lcom_android_billingclient_api_SkuDetails_Handler ()
			{
				if (cb_setSkuDetails_Lcom_android_billingclient_api_SkuDetails_ == null)
					cb_setSkuDetails_Lcom_android_billingclient_api_SkuDetails_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSkuDetails_Lcom_android_billingclient_api_SkuDetails_);
				return cb_setSkuDetails_Lcom_android_billingclient_api_SkuDetails_;
			}

			static IntPtr n_SetSkuDetails_Lcom_android_billingclient_api_SkuDetails_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skuDetails)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.BillingClient.Api.SkuDetails skuDetails = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (native_skuDetails, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSkuDetails (skuDetails));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='setSkuDetails' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.SkuDetails']]"
			[Register ("setSkuDetails", "(Lcom/android/billingclient/api/SkuDetails;)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetSetSkuDetails_Lcom_android_billingclient_api_SkuDetails_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder SetSkuDetails (global::Android.BillingClient.Api.SkuDetails skuDetails)
			{
				const string __id = "setSkuDetails.(Lcom/android/billingclient/api/SkuDetails;)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((skuDetails == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skuDetails).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setVrPurchaseFlow_Z;
#pragma warning disable 0169
			static Delegate GetSetVrPurchaseFlow_ZHandler ()
			{
				if (cb_setVrPurchaseFlow_Z == null)
					cb_setVrPurchaseFlow_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetVrPurchaseFlow_Z);
				return cb_setVrPurchaseFlow_Z;
			}

			static IntPtr n_SetVrPurchaseFlow_Z (IntPtr jnienv, IntPtr native__this, bool isVrPurchaseFlow)
			{
				global::Android.BillingClient.Api.BillingFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetVrPurchaseFlow (isVrPurchaseFlow));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams.Builder']/method[@name='setVrPurchaseFlow' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVrPurchaseFlow", "(Z)Lcom/android/billingclient/api/BillingFlowParams$Builder;", "GetSetVrPurchaseFlow_ZHandler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder SetVrPurchaseFlow (bool isVrPurchaseFlow)
			{
				const string __id = "setVrPurchaseFlow.(Z)Lcom/android/billingclient/api/BillingFlowParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isVrPurchaseFlow);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[Register ("com/android/billingclient/api/BillingFlowParams$ProrationMode", DoNotGenerateAcw=true)]
		public abstract class ProrationMode : Java.Lang.Object {

			internal ProrationMode ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingFlowParams.ProrationMode']/field[@name='DEFERRED']"
			[Register ("DEFERRED")]
			public const int Deferred = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingFlowParams.ProrationMode']/field[@name='IMMEDIATE_AND_CHARGE_PRORATED_PRICE']"
			[Register ("IMMEDIATE_AND_CHARGE_PRORATED_PRICE")]
			public const int ImmediateAndChargeProratedPrice = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingFlowParams.ProrationMode']/field[@name='IMMEDIATE_WITHOUT_PRORATION']"
			[Register ("IMMEDIATE_WITHOUT_PRORATION")]
			public const int ImmediateWithoutProration = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingFlowParams.ProrationMode']/field[@name='IMMEDIATE_WITH_TIME_PRORATION']"
			[Register ("IMMEDIATE_WITH_TIME_PRORATION")]
			public const int ImmediateWithTimeProration = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingFlowParams.ProrationMode']/field[@name='UNKNOWN_SUBSCRIPTION_UPGRADE_DOWNGRADE_POLICY']"
			[Register ("UNKNOWN_SUBSCRIPTION_UPGRADE_DOWNGRADE_POLICY")]
			public const int UnknownSubscriptionUpgradeDowngradePolicy = (int) 0;

			// The following are fields from: java.lang.annotation.Annotation

			// The following are fields from: Android.Runtime.IJavaObject

			// The following are fields from: System.IDisposable
		}

		[Register ("com/android/billingclient/api/BillingFlowParams$ProrationMode", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'ProrationMode' type. This type will be removed in a future release.")]
		public abstract class ProrationModeConsts : ProrationMode {

			private ProrationModeConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingFlowParams.ProrationMode']"
		[Register ("com/android/billingclient/api/BillingFlowParams$ProrationMode", "", "Android.BillingClient.Api.BillingFlowParams/IProrationModeInvoker")]
		public partial interface IProrationMode : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/android/billingclient/api/BillingFlowParams$ProrationMode", DoNotGenerateAcw=true)]
		internal class IProrationModeInvoker : global::Java.Lang.Object, IProrationMode {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/BillingFlowParams$ProrationMode", typeof (IProrationModeInvoker));

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

			public static IProrationMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProrationMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.BillingFlowParams.ProrationMode"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProrationModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.BillingFlowParams.IProrationMode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.IProrationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Android.BillingClient.Api.BillingFlowParams.IProrationMode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.IProrationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.BillingFlowParams.IProrationMode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.IProrationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.BillingFlowParams.IProrationMode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.IProrationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/BillingFlowParams", typeof (BillingFlowParams));
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

		protected BillingFlowParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/constructor[@name='BillingFlowParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BillingFlowParams ()
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

		static Delegate cb_getAccountId;
#pragma warning disable 0169
		static Delegate GetGetAccountIdHandler ()
		{
			if (cb_getAccountId == null)
				cb_getAccountId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountId);
			return cb_getAccountId;
		}

		static IntPtr n_GetAccountId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountId);
		}
#pragma warning restore 0169

		public virtual unsafe string AccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getAccountId' and count(parameter)=0]"
			[Register ("getAccountId", "()Ljava/lang/String;", "GetGetAccountIdHandler")]
			get {
				const string __id = "getAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeveloperId;
#pragma warning disable 0169
		static Delegate GetGetDeveloperIdHandler ()
		{
			if (cb_getDeveloperId == null)
				cb_getDeveloperId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeveloperId);
			return cb_getDeveloperId;
		}

		static IntPtr n_GetDeveloperId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeveloperId);
		}
#pragma warning restore 0169

		public virtual unsafe string DeveloperId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getDeveloperId' and count(parameter)=0]"
			[Register ("getDeveloperId", "()Ljava/lang/String;", "GetGetDeveloperIdHandler")]
			get {
				const string __id = "getDeveloperId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldSku;
#pragma warning disable 0169
		static Delegate GetGetOldSkuHandler ()
		{
			if (cb_getOldSku == null)
				cb_getOldSku = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOldSku);
			return cb_getOldSku;
		}

		static IntPtr n_GetOldSku (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OldSku);
		}
#pragma warning restore 0169

		public virtual unsafe string OldSku {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getOldSku' and count(parameter)=0]"
			[Register ("getOldSku", "()Ljava/lang/String;", "GetGetOldSkuHandler")]
			get {
				const string __id = "getOldSku.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldSkus;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetOldSkusHandler ()
		{
			if (cb_getOldSkus == null)
				cb_getOldSkus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOldSkus);
			return cb_getOldSkus;
		}

		[Obsolete]
		static IntPtr n_GetOldSkus (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.OldSkus);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::System.Collections.Generic.IList<string> OldSkus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getOldSkus' and count(parameter)=0]"
			[Register ("getOldSkus", "()Ljava/util/ArrayList;", "GetGetOldSkusHandler")]
			get {
				const string __id = "getOldSkus.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReplaceSkusProrationMode;
#pragma warning disable 0169
		static Delegate GetGetReplaceSkusProrationModeHandler ()
		{
			if (cb_getReplaceSkusProrationMode == null)
				cb_getReplaceSkusProrationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReplaceSkusProrationMode);
			return cb_getReplaceSkusProrationMode;
		}

		static int n_GetReplaceSkusProrationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReplaceSkusProrationMode;
		}
#pragma warning restore 0169

		public virtual unsafe int ReplaceSkusProrationMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getReplaceSkusProrationMode' and count(parameter)=0]"
			[Register ("getReplaceSkusProrationMode", "()I", "GetGetReplaceSkusProrationModeHandler")]
			get {
				const string __id = "getReplaceSkusProrationMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sku);
		}
#pragma warning restore 0169

		public virtual unsafe string Sku {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getSku' and count(parameter)=0]"
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

		static Delegate cb_getSkuDetails;
#pragma warning disable 0169
		static Delegate GetGetSkuDetailsHandler ()
		{
			if (cb_getSkuDetails == null)
				cb_getSkuDetails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSkuDetails);
			return cb_getSkuDetails;
		}

		static IntPtr n_GetSkuDetails (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkuDetails);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.BillingClient.Api.SkuDetails SkuDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getSkuDetails' and count(parameter)=0]"
			[Register ("getSkuDetails", "()Lcom/android/billingclient/api/SkuDetails;", "GetGetSkuDetailsHandler")]
			get {
				const string __id = "getSkuDetails.()Lcom/android/billingclient/api/SkuDetails;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSkuType;
#pragma warning disable 0169
		static Delegate GetGetSkuTypeHandler ()
		{
			if (cb_getSkuType == null)
				cb_getSkuType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSkuType);
			return cb_getSkuType;
		}

		static IntPtr n_GetSkuType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SkuType);
		}
#pragma warning restore 0169

		[global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", ""})]
		public virtual unsafe string SkuType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getSkuType' and count(parameter)=0]"
			[Register ("getSkuType", "()Ljava/lang/String;", "GetGetSkuTypeHandler")]
			get {
				const string __id = "getSkuType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVrPurchaseFlow;
#pragma warning disable 0169
		static Delegate GetGetVrPurchaseFlowHandler ()
		{
			if (cb_getVrPurchaseFlow == null)
				cb_getVrPurchaseFlow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetVrPurchaseFlow);
			return cb_getVrPurchaseFlow;
		}

		static bool n_GetVrPurchaseFlow (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VrPurchaseFlow;
		}
#pragma warning restore 0169

		public virtual unsafe bool VrPurchaseFlow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='getVrPurchaseFlow' and count(parameter)=0]"
			[Register ("getVrPurchaseFlow", "()Z", "GetGetVrPurchaseFlowHandler")]
			get {
				const string __id = "getVrPurchaseFlow.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingFlowParams']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/android/billingclient/api/BillingFlowParams$Builder;", "")]
		public static unsafe global::Android.BillingClient.Api.BillingFlowParams.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lcom/android/billingclient/api/BillingFlowParams$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
