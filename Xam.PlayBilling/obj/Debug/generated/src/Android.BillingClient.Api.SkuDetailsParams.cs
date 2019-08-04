using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/SkuDetailsParams", DoNotGenerateAcw=true)]
	public partial class SkuDetailsParams : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams.Builder']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/SkuDetailsParams$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/SkuDetailsParams$Builder", typeof (Builder));
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
				global::Android.BillingClient.Api.SkuDetailsParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/android/billingclient/api/SkuDetailsParams;", "GetBuildHandler")]
			public virtual unsafe global::Android.BillingClient.Api.SkuDetailsParams Build ()
			{
				const string __id = "build.()Lcom/android/billingclient/api/SkuDetailsParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSkusList_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetSkusList_Ljava_util_List_Handler ()
			{
				if (cb_setSkusList_Ljava_util_List_ == null)
					cb_setSkusList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSkusList_Ljava_util_List_);
				return cb_setSkusList_Ljava_util_List_;
			}

			static IntPtr n_SetSkusList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skusList)
			{
				global::Android.BillingClient.Api.SkuDetailsParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var skusList = global::Android.Runtime.JavaList<string>.FromJniHandle (native_skusList, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSkusList (skusList));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams.Builder']/method[@name='setSkusList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setSkusList", "(Ljava/util/List;)Lcom/android/billingclient/api/SkuDetailsParams$Builder;", "GetSetSkusList_Ljava_util_List_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.SkuDetailsParams.Builder SetSkusList (global::System.Collections.Generic.IList<string> skusList)
			{
				const string __id = "setSkusList.(Ljava/util/List;)Lcom/android/billingclient/api/SkuDetailsParams$Builder;";
				IntPtr native_skusList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (skusList);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_skusList);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_skusList);
				}
			}

			static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetType_Ljava_lang_String_Handler ()
			{
				if (cb_setType_Ljava_lang_String_ == null)
					cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
				return cb_setType_Ljava_lang_String_;
			}

			static IntPtr n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
			{
				global::Android.BillingClient.Api.SkuDetailsParams.Builder __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (type));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams.Builder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)Lcom/android/billingclient/api/SkuDetailsParams$Builder;", "GetSetType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Android.BillingClient.Api.SkuDetailsParams.Builder SetType (string type)
			{
				const string __id = "setType.(Ljava/lang/String;)Lcom/android/billingclient/api/SkuDetailsParams$Builder;";
				IntPtr native_type = JNIEnv.NewString (type);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_type);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_type);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/SkuDetailsParams", typeof (SkuDetailsParams));
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

		protected SkuDetailsParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams']/constructor[@name='SkuDetailsParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SkuDetailsParams ()
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
			global::Android.BillingClient.Api.SkuDetailsParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SkuType);
		}
#pragma warning restore 0169

		[global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", ""})]
		public virtual unsafe string SkuType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams']/method[@name='getSkuType' and count(parameter)=0]"
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

		static Delegate cb_getSkusList;
#pragma warning disable 0169
		static Delegate GetGetSkusListHandler ()
		{
			if (cb_getSkusList == null)
				cb_getSkusList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSkusList);
			return cb_getSkusList;
		}

		static IntPtr n_GetSkusList (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.SkuDetailsParams __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.SkusList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> SkusList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams']/method[@name='getSkusList' and count(parameter)=0]"
			[Register ("getSkusList", "()Ljava/util/List;", "GetGetSkusListHandler")]
			get {
				const string __id = "getSkusList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='SkuDetailsParams']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/android/billingclient/api/SkuDetailsParams$Builder;", "")]
		public static unsafe global::Android.BillingClient.Api.SkuDetailsParams.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lcom/android/billingclient/api/SkuDetailsParams$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
