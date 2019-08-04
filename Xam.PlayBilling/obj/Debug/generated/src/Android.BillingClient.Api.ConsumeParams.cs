using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/ConsumeParams", DoNotGenerateAcw=true)]
	public sealed partial class ConsumeParams : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams.Builder']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/ConsumeParams$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/ConsumeParams$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/android/billingclient/api/ConsumeParams;", "")]
			public unsafe global::Android.BillingClient.Api.ConsumeParams Build ()
			{
				const string __id = "build.()Lcom/android/billingclient/api/ConsumeParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.ConsumeParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams.Builder']/method[@name='setDeveloperPayload' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeveloperPayload", "(Ljava/lang/String;)Lcom/android/billingclient/api/ConsumeParams$Builder;", "")]
			public unsafe global::Android.BillingClient.Api.ConsumeParams.Builder SetDeveloperPayload (string developerPayload)
			{
				const string __id = "setDeveloperPayload.(Ljava/lang/String;)Lcom/android/billingclient/api/ConsumeParams$Builder;";
				IntPtr native_developerPayload = JNIEnv.NewString (developerPayload);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_developerPayload);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.ConsumeParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_developerPayload);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams.Builder']/method[@name='setPurchaseToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPurchaseToken", "(Ljava/lang/String;)Lcom/android/billingclient/api/ConsumeParams$Builder;", "")]
			public unsafe global::Android.BillingClient.Api.ConsumeParams.Builder SetPurchaseToken (string purchaseToken)
			{
				const string __id = "setPurchaseToken.(Ljava/lang/String;)Lcom/android/billingclient/api/ConsumeParams$Builder;";
				IntPtr native_purchaseToken = JNIEnv.NewString (purchaseToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_purchaseToken);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.ConsumeParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_purchaseToken);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/ConsumeParams", typeof (ConsumeParams));
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

		internal ConsumeParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string DeveloperPayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams']/method[@name='getDeveloperPayload' and count(parameter)=0]"
			[Register ("getDeveloperPayload", "()Ljava/lang/String;", "GetGetDeveloperPayloadHandler")]
			get {
				const string __id = "getDeveloperPayload.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string PurchaseToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams']/method[@name='getPurchaseToken' and count(parameter)=0]"
			[Register ("getPurchaseToken", "()Ljava/lang/String;", "GetGetPurchaseTokenHandler")]
			get {
				const string __id = "getPurchaseToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='ConsumeParams']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/android/billingclient/api/ConsumeParams$Builder;", "")]
		public static unsafe global::Android.BillingClient.Api.ConsumeParams.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lcom/android/billingclient/api/ConsumeParams$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.ConsumeParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
