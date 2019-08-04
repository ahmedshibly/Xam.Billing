using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Vending.Billing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.vending.billing']/class[@name='IInAppBillingService.Stub']"
	[global::Android.Runtime.Register ("com/android/vending/billing/IInAppBillingService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class InAppBillingServiceStub : global::Android.OS.Binder, global::Android.Vending.Billing.IInAppBillingService {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/vending/billing/IInAppBillingService$Stub", typeof (InAppBillingServiceStub));
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

		protected InAppBillingServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.vending.billing']/class[@name='IInAppBillingService.Stub']/constructor[@name='IInAppBillingService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InAppBillingServiceStub ()
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/class[@name='IInAppBillingService.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/class[@name='IInAppBillingService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/android/vending/billing/IInAppBillingService;", "")]
		public static unsafe global::Android.Vending.Billing.IInAppBillingService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/android/vending/billing/IInAppBillingService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/class[@name='IInAppBillingService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_AcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_AcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcknowledgePurchaseExtraParams (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='acknowledgePurchaseExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("acknowledgePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle AcknowledgePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		static Delegate cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConsumePurchase_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_ConsumePurchase_ILjava_lang_String_Ljava_lang_String_);
			return cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_ConsumePurchase_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConsumePurchase (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='consumePurchase' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("consumePurchase", "(ILjava/lang/String;Ljava/lang/String;)I", "GetConsumePurchase_ILjava_lang_String_Ljava_lang_String_Handler")]
		public abstract int ConsumePurchase (int p0, string p1, string p2);

		static Delegate cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_ConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConsumePurchaseExtraParams (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='consumePurchaseExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("consumePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle ConsumePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		static Delegate cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBuyIntent (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getBuyIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Android.OS.Bundle GetBuyIntent (int p0, string p1, string p2, string p3, string p4);

		static Delegate cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p5 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBuyIntentExtraParams (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntentExtraParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.os.Bundle']]"
		[Register ("getBuyIntentExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetBuyIntentExtraParams (int p0, string p1, string p2, string p3, string p4, global::Android.OS.Bundle p5);

		static Delegate cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBuyIntentToReplaceSkus (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntentToReplaceSkus' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("getBuyIntentToReplaceSkus", "(ILjava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Android.OS.Bundle GetBuyIntentToReplaceSkus (int p0, string p1, global::System.Collections.Generic.IList<string> p2, string p3, string p4, string p5);

		static Delegate cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPurchaseHistory (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchaseHistory' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getPurchaseHistory", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetPurchaseHistory (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4);

		static Delegate cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPurchases (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchases' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getPurchases", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract global::Android.OS.Bundle GetPurchases (int p0, string p1, string p2, string p3);

		static Delegate cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPurchasesExtraParams (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchasesExtraParams' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getPurchasesExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetPurchasesExtraParams (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4);

		static Delegate cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSkuDetails (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSkuDetails' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("getSkuDetails", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetSkuDetails (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		static Delegate cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ == null)
				cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_);
			return cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSkuDetailsExtraParams (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSkuDetailsExtraParams' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getSkuDetailsExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetSkuDetailsExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3, global::Android.OS.Bundle p4);

		static Delegate cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSubscriptionManagementIntent (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSubscriptionManagementIntent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getSubscriptionManagementIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract global::Android.OS.Bundle GetSubscriptionManagementIntent (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4);

		static Delegate cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsBillingSupported_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_IsBillingSupported_ILjava_lang_String_Ljava_lang_String_);
			return cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_IsBillingSupported_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsBillingSupported (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='isBillingSupported' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("isBillingSupported", "(ILjava/lang/String;Ljava/lang/String;)I", "GetIsBillingSupported_ILjava_lang_String_Ljava_lang_String_Handler")]
		public abstract int IsBillingSupported (int p0, string p1, string p2);

		static Delegate cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetIsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int>) n_IsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static int n_IsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsBillingSupportedExtraParams (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='isBillingSupportedExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("isBillingSupportedExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)I", "GetIsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract int IsBillingSupportedExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		static Delegate cb_stub_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStub_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stub_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_stub_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_Stub_ILjava_lang_String_Ljava_lang_String_);
			return cb_stub_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_Stub_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Vending.Billing.InAppBillingServiceStub __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.InAppBillingServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Stub (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='stub' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stub", "(ILjava/lang/String;Ljava/lang/String;)I", "GetStub_ILjava_lang_String_Ljava_lang_String_Handler")]
		public abstract int Stub (int p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/android/vending/billing/IInAppBillingService$Stub", DoNotGenerateAcw=true)]
	internal partial class InAppBillingServiceStubInvoker : InAppBillingServiceStub {

		public InAppBillingServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/vending/billing/IInAppBillingService$Stub", typeof (InAppBillingServiceStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='acknowledgePurchaseExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("acknowledgePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle AcknowledgePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			const string __id = "acknowledgePurchaseExtraParams.(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='consumePurchase' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("consumePurchase", "(ILjava/lang/String;Ljava/lang/String;)I", "GetConsumePurchase_ILjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe int ConsumePurchase (int p0, string p1, string p2)
		{
			const string __id = "consumePurchase.(ILjava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='consumePurchaseExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("consumePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle ConsumePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			const string __id = "consumePurchaseExtraParams.(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getBuyIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Android.OS.Bundle GetBuyIntent (int p0, string p1, string p2, string p3, string p4)
		{
			const string __id = "getBuyIntent.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntentExtraParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.os.Bundle']]"
		[Register ("getBuyIntentExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetBuyIntentExtraParams (int p0, string p1, string p2, string p3, string p4, global::Android.OS.Bundle p5)
		{
			const string __id = "getBuyIntentExtraParams.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntentToReplaceSkus' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("getBuyIntentToReplaceSkus", "(ILjava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Android.OS.Bundle GetBuyIntentToReplaceSkus (int p0, string p1, global::System.Collections.Generic.IList<string> p2, string p3, string p4, string p5)
		{
			const string __id = "getBuyIntentToReplaceSkus.(ILjava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchaseHistory' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getPurchaseHistory", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetPurchaseHistory (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4)
		{
			const string __id = "getPurchaseHistory.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchases' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getPurchases", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Android.OS.Bundle GetPurchases (int p0, string p1, string p2, string p3)
		{
			const string __id = "getPurchases.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchasesExtraParams' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getPurchasesExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetPurchasesExtraParams (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4)
		{
			const string __id = "getPurchasesExtraParams.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSkuDetails' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("getSkuDetails", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetSkuDetails (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			const string __id = "getSkuDetails.(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSkuDetailsExtraParams' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getSkuDetailsExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetSkuDetailsExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3, global::Android.OS.Bundle p4)
		{
			const string __id = "getSkuDetailsExtraParams.(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSubscriptionManagementIntent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getSubscriptionManagementIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetSubscriptionManagementIntent (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4)
		{
			const string __id = "getSubscriptionManagementIntent.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='isBillingSupported' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("isBillingSupported", "(ILjava/lang/String;Ljava/lang/String;)I", "GetIsBillingSupported_ILjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe int IsBillingSupported (int p0, string p1, string p2)
		{
			const string __id = "isBillingSupported.(ILjava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='isBillingSupportedExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("isBillingSupportedExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)I", "GetIsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe int IsBillingSupportedExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			const string __id = "isBillingSupportedExtraParams.(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='stub' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stub", "(ILjava/lang/String;Ljava/lang/String;)I", "GetStub_ILjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe int Stub (int p0, string p1, string p2)
		{
			const string __id = "stub.(ILjava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']"
	[Register ("com/android/vending/billing/IInAppBillingService", "", "Android.Vending.Billing.IInAppBillingServiceInvoker")]
	public partial interface IInAppBillingService : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='acknowledgePurchaseExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("acknowledgePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle AcknowledgePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='consumePurchase' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("consumePurchase", "(ILjava/lang/String;Ljava/lang/String;)I", "GetConsumePurchase_ILjava_lang_String_Ljava_lang_String_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		int ConsumePurchase (int p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='consumePurchaseExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("consumePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle ConsumePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getBuyIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetBuyIntent (int p0, string p1, string p2, string p3, string p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntentExtraParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.os.Bundle']]"
		[Register ("getBuyIntentExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetBuyIntentExtraParams (int p0, string p1, string p2, string p3, string p4, global::Android.OS.Bundle p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getBuyIntentToReplaceSkus' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("getBuyIntentToReplaceSkus", "(ILjava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetBuyIntentToReplaceSkus (int p0, string p1, global::System.Collections.Generic.IList<string> p2, string p3, string p4, string p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchaseHistory' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getPurchaseHistory", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetPurchaseHistory (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchases' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getPurchases", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "GetGetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetPurchases (int p0, string p1, string p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getPurchasesExtraParams' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getPurchasesExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetPurchasesExtraParams (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSkuDetails' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("getSkuDetails", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetSkuDetails (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSkuDetailsExtraParams' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getSkuDetailsExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetSkuDetailsExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3, global::Android.OS.Bundle p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='getSubscriptionManagementIntent' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("getSubscriptionManagementIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		global::Android.OS.Bundle GetSubscriptionManagementIntent (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='isBillingSupported' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("isBillingSupported", "(ILjava/lang/String;Ljava/lang/String;)I", "GetIsBillingSupported_ILjava_lang_String_Ljava_lang_String_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		int IsBillingSupported (int p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='isBillingSupportedExtraParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("isBillingSupportedExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)I", "GetIsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		int IsBillingSupportedExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.vending.billing']/interface[@name='IInAppBillingService']/method[@name='stub' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("stub", "(ILjava/lang/String;Ljava/lang/String;)I", "GetStub_ILjava_lang_String_Ljava_lang_String_Handler:Android.Vending.Billing.IInAppBillingServiceInvoker, Xam.PlayBilling")]
		int Stub (int p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/android/vending/billing/IInAppBillingService", DoNotGenerateAcw=true)]
	internal class IInAppBillingServiceInvoker : global::Java.Lang.Object, IInAppBillingService {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/vending/billing/IInAppBillingService", typeof (IInAppBillingServiceInvoker));

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

		public static IInAppBillingService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppBillingService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.android.vending.billing.IInAppBillingService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppBillingServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_AcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_AcknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcknowledgePurchaseExtraParams (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle AcknowledgePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "acknowledgePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acknowledgePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConsumePurchase_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_ConsumePurchase_ILjava_lang_String_Ljava_lang_String_);
			return cb_consumePurchase_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_ConsumePurchase_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConsumePurchase (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_consumePurchase_ILjava_lang_String_Ljava_lang_String_;
		public unsafe int ConsumePurchase (int p0, string p1, string p2)
		{
			if (id_consumePurchase_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_consumePurchase_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "consumePurchase", "(ILjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_consumePurchase_ILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_ConsumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConsumePurchaseExtraParams (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle ConsumePurchaseExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "consumePurchaseExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_consumePurchaseExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBuyIntent (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Android.OS.Bundle GetBuyIntent (int p0, string p1, string p2, string p3, string p4)
		{
			if (id_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBuyIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBuyIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p5 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBuyIntentExtraParams (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetBuyIntentExtraParams (int p0, string p1, string p2, string p3, string p4, global::Android.OS.Bundle p5)
		{
			if (id_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getBuyIntentExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBuyIntentExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBuyIntentToReplaceSkus (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Android.OS.Bundle GetBuyIntentToReplaceSkus (int p0, string p1, global::System.Collections.Generic.IList<string> p2, string p3, string p4, string p5)
		{
			if (id_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBuyIntentToReplaceSkus", "(ILjava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBuyIntentToReplaceSkus_ILjava_lang_String_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			return __ret;
		}

		static Delegate cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPurchaseHistory (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetPurchaseHistory (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4)
		{
			if (id_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getPurchaseHistory", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPurchaseHistory_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPurchases (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Android.OS.Bundle GetPurchases (int p0, string p1, string p2, string p3)
		{
			if (id_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPurchases", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPurchases_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPurchasesExtraParams (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetPurchasesExtraParams (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4)
		{
			if (id_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getPurchasesExtraParams", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPurchasesExtraParams_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSkuDetails (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetSkuDetails (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getSkuDetails", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSkuDetails_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ == null)
				cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_);
			return cb_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_;
		}

		static IntPtr n_GetSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSkuDetailsExtraParams (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetSkuDetailsExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3, global::Android.OS.Bundle p4)
		{
			if (id_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getSkuDetailsExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSkuDetailsExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSubscriptionManagementIntent (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe global::Android.OS.Bundle GetSubscriptionManagementIntent (int p0, string p1, string p2, string p3, global::Android.OS.Bundle p4)
		{
			if (id_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getSubscriptionManagementIntent", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriptionManagementIntent_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsBillingSupported_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_IsBillingSupported_ILjava_lang_String_Ljava_lang_String_);
			return cb_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_IsBillingSupported_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsBillingSupported (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_;
		public unsafe int IsBillingSupported (int p0, string p1, string p2)
		{
			if (id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isBillingSupported", "(ILjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_isBillingSupported_ILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetIsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int>) n_IsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static int n_IsBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsBillingSupportedExtraParams (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe int IsBillingSupportedExtraParams (int p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "isBillingSupportedExtraParams", "(ILjava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_isBillingSupportedExtraParams_ILjava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_stub_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStub_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_stub_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_stub_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_Stub_ILjava_lang_String_Ljava_lang_String_);
			return cb_stub_ILjava_lang_String_Ljava_lang_String_;
		}

		static int n_Stub_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Stub (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_stub_ILjava_lang_String_Ljava_lang_String_;
		public unsafe int Stub (int p0, string p1, string p2)
		{
			if (id_stub_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_stub_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stub", "(ILjava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_stub_ILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Vending.Billing.IInAppBillingService __this = global::Java.Lang.Object.GetObject<global::Android.Vending.Billing.IInAppBillingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
