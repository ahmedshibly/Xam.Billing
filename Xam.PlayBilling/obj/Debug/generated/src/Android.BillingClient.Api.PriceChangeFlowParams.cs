using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/PriceChangeFlowParams", DoNotGenerateAcw=true)]
	public partial class PriceChangeFlowParams : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams.Builder']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/PriceChangeFlowParams$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/PriceChangeFlowParams$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams.Builder']/constructor[@name='PriceChangeFlowParams.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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
				global::Android.BillingClient.Api.PriceChangeFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PriceChangeFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/android/billingclient/api/PriceChangeFlowParams;", "GetBuildHandler")]
			public virtual unsafe global::Android.BillingClient.Api.PriceChangeFlowParams Build ()
			{
				const string __id = "build.()Lcom/android/billingclient/api/PriceChangeFlowParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PriceChangeFlowParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Android.BillingClient.Api.PriceChangeFlowParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PriceChangeFlowParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.BillingClient.Api.SkuDetails skuDetails = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetails> (native_skuDetails, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSkuDetails (skuDetails));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams.Builder']/method[@name='setSkuDetails' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.SkuDetails']]"
			[Register ("setSkuDetails", "(Lcom/android/billingclient/api/SkuDetails;)Lcom/android/billingclient/api/PriceChangeFlowParams$Builder;", "GetSetSkuDetails_Lcom_android_billingclient_api_SkuDetails_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.PriceChangeFlowParams.Builder SetSkuDetails (global::Android.BillingClient.Api.SkuDetails skuDetails)
			{
				const string __id = "setSkuDetails.(Lcom/android/billingclient/api/SkuDetails;)Lcom/android/billingclient/api/PriceChangeFlowParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((skuDetails == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skuDetails).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PriceChangeFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/PriceChangeFlowParams", typeof (PriceChangeFlowParams));
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

		protected PriceChangeFlowParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams']/constructor[@name='PriceChangeFlowParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PriceChangeFlowParams ()
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
			global::Android.BillingClient.Api.PriceChangeFlowParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PriceChangeFlowParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkuDetails);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.BillingClient.Api.SkuDetails SkuDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams']/method[@name='getSkuDetails' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='PriceChangeFlowParams']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/android/billingclient/api/PriceChangeFlowParams$Builder;", "")]
		public static unsafe global::Android.BillingClient.Api.PriceChangeFlowParams.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lcom/android/billingclient/api/PriceChangeFlowParams$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PriceChangeFlowParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
