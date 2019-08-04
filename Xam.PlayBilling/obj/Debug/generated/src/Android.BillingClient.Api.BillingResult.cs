using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/BillingResult", DoNotGenerateAcw=true)]
	public sealed partial class BillingResult : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult.Builder']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/BillingResult$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/BillingResult$Builder", typeof (Builder));
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
				global::Android.BillingClient.Api.BillingResult.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/android/billingclient/api/BillingResult;", "GetBuildHandler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingResult Build ()
			{
				const string __id = "build.()Lcom/android/billingclient/api/BillingResult;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDebugMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDebugMessage_Ljava_lang_String_Handler ()
			{
				if (cb_setDebugMessage_Ljava_lang_String_ == null)
					cb_setDebugMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDebugMessage_Ljava_lang_String_);
				return cb_setDebugMessage_Ljava_lang_String_;
			}

			static IntPtr n_SetDebugMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_debugMessage)
			{
				global::Android.BillingClient.Api.BillingResult.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string debugMessage = JNIEnv.GetString (native_debugMessage, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDebugMessage (debugMessage));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult.Builder']/method[@name='setDebugMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDebugMessage", "(Ljava/lang/String;)Lcom/android/billingclient/api/BillingResult$Builder;", "GetSetDebugMessage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingResult.Builder SetDebugMessage (string debugMessage)
			{
				const string __id = "setDebugMessage.(Ljava/lang/String;)Lcom/android/billingclient/api/BillingResult$Builder;";
				IntPtr native_debugMessage = JNIEnv.NewString (debugMessage);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_debugMessage);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_debugMessage);
				}
			}

			static Delegate cb_setResponseCode_I;
#pragma warning disable 0169
			static Delegate GetSetResponseCode_IHandler ()
			{
				if (cb_setResponseCode_I == null)
					cb_setResponseCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetResponseCode_I);
				return cb_setResponseCode_I;
			}

			static IntPtr n_SetResponseCode_I (IntPtr jnienv, IntPtr native__this, int responseCode)
			{
				global::Android.BillingClient.Api.BillingResult.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetResponseCode (responseCode));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult.Builder']/method[@name='setResponseCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResponseCode", "(I)Lcom/android/billingclient/api/BillingResult$Builder;", "GetSetResponseCode_IHandler")]
			public virtual unsafe global::Android.BillingClient.Api.BillingResult.Builder SetResponseCode (int responseCode)
			{
				const string __id = "setResponseCode.(I)Lcom/android/billingclient/api/BillingResult$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (responseCode);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/BillingResult", typeof (BillingResult));
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

		internal BillingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult']/constructor[@name='BillingResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BillingResult ()
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

		public unsafe string DebugMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult']/method[@name='getDebugMessage' and count(parameter)=0]"
			[Register ("getDebugMessage", "()Ljava/lang/String;", "GetGetDebugMessageHandler")]
			get {
				const string __id = "getDebugMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.BillingClient.Api.BillingResponseCode ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get {
				const string __id = "getResponseCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return (global::Android.BillingClient.Api.BillingResponseCode) __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingResult']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/android/billingclient/api/BillingResult$Builder;", "")]
		public static unsafe global::Android.BillingClient.Api.BillingResult.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lcom/android/billingclient/api/BillingResult$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
