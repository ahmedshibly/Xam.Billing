using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/SkuDetails", DoNotGenerateAcw=true)]
	public partial class SkuDetails : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails.SkuDetailsResult']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/SkuDetails$SkuDetailsResult", DoNotGenerateAcw=true)]
		public partial class SkuDetailsResult : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/SkuDetails$SkuDetailsResult", typeof (SkuDetailsResult));
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

			protected SkuDetailsResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails.SkuDetailsResult']/constructor[@name='SkuDetails.SkuDetailsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.android.billingclient.api.SkuDetails&gt;']]"
			[Register (".ctor", "(ILjava/lang/String;Ljava/util/List;)V", "")]
			public unsafe SkuDetailsResult (int responseCode, string debugMessage, global::System.Collections.Generic.IList<global::Android.BillingClient.Api.SkuDetails> skuDetailsList)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ILjava/lang/String;Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_debugMessage = JNIEnv.NewString (debugMessage);
				IntPtr native_skuDetailsList = global::Android.Runtime.JavaList<global::Android.BillingClient.Api.SkuDetails>.ToLocalJniHandle (skuDetailsList);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (responseCode);
					__args [1] = new JniArgumentValue (native_debugMessage);
					__args [2] = new JniArgumentValue (native_skuDetailsList);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_debugMessage);
					JNIEnv.DeleteLocalRef (native_skuDetailsList);
				}
			}

			static Delegate cb_getDebugMessage;
#pragma warning disable 0169
			static Delegate GetGetDebugMessageHandler ()
			{
				if (cb_getDebugMessage == null)
					cb_getDebugMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDebugMessage);
				return cb_getDebugMessage;
			}

			static IntPtr n_GetDebugMessage (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.SkuDetails.SkuDetailsResult __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails.SkuDetailsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DebugMessage);
			}
#pragma warning restore 0169

			public virtual unsafe string DebugMessage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails.SkuDetailsResult']/method[@name='getDebugMessage' and count(parameter)=0]"
				[Register ("getDebugMessage", "()Ljava/lang/String;", "GetGetDebugMessageHandler")]
				get {
					const string __id = "getDebugMessage.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Android.BillingClient.Api.SkuDetails.SkuDetailsResult __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails.SkuDetailsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ResponseCode;
			}
#pragma warning restore 0169

			public virtual unsafe int ResponseCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails.SkuDetailsResult']/method[@name='getResponseCode' and count(parameter)=0]"
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

			static Delegate cb_getSkuDetailsList;
#pragma warning disable 0169
			static Delegate GetGetSkuDetailsListHandler ()
			{
				if (cb_getSkuDetailsList == null)
					cb_getSkuDetailsList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSkuDetailsList);
				return cb_getSkuDetailsList;
			}

			static IntPtr n_GetSkuDetailsList (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.BillingClient.Api.SkuDetails.SkuDetailsResult __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails.SkuDetailsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Android.BillingClient.Api.SkuDetails>.ToLocalJniHandle (__this.SkuDetailsList);
			}
#pragma warning restore 0169

			public virtual unsafe global::System.Collections.Generic.IList<global::Android.BillingClient.Api.SkuDetails> SkuDetailsList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails.SkuDetailsResult']/method[@name='getSkuDetailsList' and count(parameter)=0]"
				[Register ("getSkuDetailsList", "()Ljava/util/List;", "GetGetSkuDetailsListHandler")]
				get {
					const string __id = "getSkuDetailsList.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Android.BillingClient.Api.SkuDetails>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/SkuDetails", typeof (SkuDetails));
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

		protected SkuDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/constructor[@name='SkuDetails' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SkuDetails (string jsonSkuDetails)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_jsonSkuDetails = JNIEnv.NewString (jsonSkuDetails);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonSkuDetails);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonSkuDetails);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFreeTrialPeriod;
#pragma warning disable 0169
		static Delegate GetGetFreeTrialPeriodHandler ()
		{
			if (cb_getFreeTrialPeriod == null)
				cb_getFreeTrialPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFreeTrialPeriod);
			return cb_getFreeTrialPeriod;
		}

		static IntPtr n_GetFreeTrialPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FreeTrialPeriod);
		}
#pragma warning restore 0169

		public virtual unsafe string FreeTrialPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getFreeTrialPeriod' and count(parameter)=0]"
			[Register ("getFreeTrialPeriod", "()Ljava/lang/String;", "GetGetFreeTrialPeriodHandler")]
			get {
				const string __id = "getFreeTrialPeriod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconUrl;
#pragma warning disable 0169
		static Delegate GetGetIconUrlHandler ()
		{
			if (cb_getIconUrl == null)
				cb_getIconUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconUrl);
			return cb_getIconUrl;
		}

		static IntPtr n_GetIconUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IconUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string IconUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getIconUrl' and count(parameter)=0]"
			[Register ("getIconUrl", "()Ljava/lang/String;", "GetGetIconUrlHandler")]
			get {
				const string __id = "getIconUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIntroductoryPrice;
#pragma warning disable 0169
		static Delegate GetGetIntroductoryPriceHandler ()
		{
			if (cb_getIntroductoryPrice == null)
				cb_getIntroductoryPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntroductoryPrice);
			return cb_getIntroductoryPrice;
		}

		static IntPtr n_GetIntroductoryPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IntroductoryPrice);
		}
#pragma warning restore 0169

		public virtual unsafe string IntroductoryPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getIntroductoryPrice' and count(parameter)=0]"
			[Register ("getIntroductoryPrice", "()Ljava/lang/String;", "GetGetIntroductoryPriceHandler")]
			get {
				const string __id = "getIntroductoryPrice.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIntroductoryPriceAmountMicros;
#pragma warning disable 0169
		static Delegate GetGetIntroductoryPriceAmountMicrosHandler ()
		{
			if (cb_getIntroductoryPriceAmountMicros == null)
				cb_getIntroductoryPriceAmountMicros = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIntroductoryPriceAmountMicros);
			return cb_getIntroductoryPriceAmountMicros;
		}

		static long n_GetIntroductoryPriceAmountMicros (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IntroductoryPriceAmountMicros;
		}
#pragma warning restore 0169

		public virtual unsafe long IntroductoryPriceAmountMicros {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getIntroductoryPriceAmountMicros' and count(parameter)=0]"
			[Register ("getIntroductoryPriceAmountMicros", "()J", "GetGetIntroductoryPriceAmountMicrosHandler")]
			get {
				const string __id = "getIntroductoryPriceAmountMicros.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIntroductoryPriceCycles;
#pragma warning disable 0169
		static Delegate GetGetIntroductoryPriceCyclesHandler ()
		{
			if (cb_getIntroductoryPriceCycles == null)
				cb_getIntroductoryPriceCycles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntroductoryPriceCycles);
			return cb_getIntroductoryPriceCycles;
		}

		static IntPtr n_GetIntroductoryPriceCycles (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IntroductoryPriceCycles);
		}
#pragma warning restore 0169

		public virtual unsafe string IntroductoryPriceCycles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getIntroductoryPriceCycles' and count(parameter)=0]"
			[Register ("getIntroductoryPriceCycles", "()Ljava/lang/String;", "GetGetIntroductoryPriceCyclesHandler")]
			get {
				const string __id = "getIntroductoryPriceCycles.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIntroductoryPricePeriod;
#pragma warning disable 0169
		static Delegate GetGetIntroductoryPricePeriodHandler ()
		{
			if (cb_getIntroductoryPricePeriod == null)
				cb_getIntroductoryPricePeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntroductoryPricePeriod);
			return cb_getIntroductoryPricePeriod;
		}

		static IntPtr n_GetIntroductoryPricePeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IntroductoryPricePeriod);
		}
#pragma warning restore 0169

		public virtual unsafe string IntroductoryPricePeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getIntroductoryPricePeriod' and count(parameter)=0]"
			[Register ("getIntroductoryPricePeriod", "()Ljava/lang/String;", "GetGetIntroductoryPricePeriodHandler")]
			get {
				const string __id = "getIntroductoryPricePeriod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRewarded;
#pragma warning disable 0169
		static Delegate GetIsRewardedHandler ()
		{
			if (cb_isRewarded == null)
				cb_isRewarded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRewarded);
			return cb_isRewarded;
		}

		static bool n_IsRewarded (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRewarded;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRewarded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='isRewarded' and count(parameter)=0]"
			[Register ("isRewarded", "()Z", "GetIsRewardedHandler")]
			get {
				const string __id = "isRewarded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginalJson);
		}
#pragma warning restore 0169

		public virtual unsafe string OriginalJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getOriginalJson' and count(parameter)=0]"
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

		static Delegate cb_getOriginalPrice;
#pragma warning disable 0169
		static Delegate GetGetOriginalPriceHandler ()
		{
			if (cb_getOriginalPrice == null)
				cb_getOriginalPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginalPrice);
			return cb_getOriginalPrice;
		}

		static IntPtr n_GetOriginalPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginalPrice);
		}
#pragma warning restore 0169

		public virtual unsafe string OriginalPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getOriginalPrice' and count(parameter)=0]"
			[Register ("getOriginalPrice", "()Ljava/lang/String;", "GetGetOriginalPriceHandler")]
			get {
				const string __id = "getOriginalPrice.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOriginalPriceAmountMicros;
#pragma warning disable 0169
		static Delegate GetGetOriginalPriceAmountMicrosHandler ()
		{
			if (cb_getOriginalPriceAmountMicros == null)
				cb_getOriginalPriceAmountMicros = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOriginalPriceAmountMicros);
			return cb_getOriginalPriceAmountMicros;
		}

		static long n_GetOriginalPriceAmountMicros (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OriginalPriceAmountMicros;
		}
#pragma warning restore 0169

		public virtual unsafe long OriginalPriceAmountMicros {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getOriginalPriceAmountMicros' and count(parameter)=0]"
			[Register ("getOriginalPriceAmountMicros", "()J", "GetGetOriginalPriceAmountMicrosHandler")]
			get {
				const string __id = "getOriginalPriceAmountMicros.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPrice;
#pragma warning disable 0169
		static Delegate GetGetPriceHandler ()
		{
			if (cb_getPrice == null)
				cb_getPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrice);
			return cb_getPrice;
		}

		static IntPtr n_GetPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Price);
		}
#pragma warning restore 0169

		public virtual unsafe string Price {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getPrice' and count(parameter)=0]"
			[Register ("getPrice", "()Ljava/lang/String;", "GetGetPriceHandler")]
			get {
				const string __id = "getPrice.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPriceAmountMicros;
#pragma warning disable 0169
		static Delegate GetGetPriceAmountMicrosHandler ()
		{
			if (cb_getPriceAmountMicros == null)
				cb_getPriceAmountMicros = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPriceAmountMicros);
			return cb_getPriceAmountMicros;
		}

		static long n_GetPriceAmountMicros (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PriceAmountMicros;
		}
#pragma warning restore 0169

		public virtual unsafe long PriceAmountMicros {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getPriceAmountMicros' and count(parameter)=0]"
			[Register ("getPriceAmountMicros", "()J", "GetGetPriceAmountMicrosHandler")]
			get {
				const string __id = "getPriceAmountMicros.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPriceCurrencyCode;
#pragma warning disable 0169
		static Delegate GetGetPriceCurrencyCodeHandler ()
		{
			if (cb_getPriceCurrencyCode == null)
				cb_getPriceCurrencyCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPriceCurrencyCode);
			return cb_getPriceCurrencyCode;
		}

		static IntPtr n_GetPriceCurrencyCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PriceCurrencyCode);
		}
#pragma warning restore 0169

		public virtual unsafe string PriceCurrencyCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getPriceCurrencyCode' and count(parameter)=0]"
			[Register ("getPriceCurrencyCode", "()Ljava/lang/String;", "GetGetPriceCurrencyCodeHandler")]
			get {
				const string __id = "getPriceCurrencyCode.()Ljava/lang/String;";
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
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sku);
		}
#pragma warning restore 0169

		public virtual unsafe string Sku {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getSku' and count(parameter)=0]"
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

		static Delegate cb_getSubscriptionPeriod;
#pragma warning disable 0169
		static Delegate GetGetSubscriptionPeriodHandler ()
		{
			if (cb_getSubscriptionPeriod == null)
				cb_getSubscriptionPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubscriptionPeriod);
			return cb_getSubscriptionPeriod;
		}

		static IntPtr n_GetSubscriptionPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubscriptionPeriod);
		}
#pragma warning restore 0169

		public virtual unsafe string SubscriptionPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getSubscriptionPeriod' and count(parameter)=0]"
			[Register ("getSubscriptionPeriod", "()Ljava/lang/String;", "GetGetSubscriptionPeriodHandler")]
			get {
				const string __id = "getSubscriptionPeriod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetails __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		[global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", ""})]
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetails']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
