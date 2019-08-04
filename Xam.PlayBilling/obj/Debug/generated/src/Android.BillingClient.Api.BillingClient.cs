using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.BillingClient.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']"
	[global::Android.Runtime.Register ("com/android/billingclient/api/BillingClient", DoNotGenerateAcw=true)]
	public abstract partial class BillingClient : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.BillingResponseCode']"
		[Register ("com/android/billingclient/api/BillingClient$BillingResponseCode", "", "Android.BillingClient.Api.BillingClient/IBillingResponseCodeInvoker")]
		public partial interface IBillingResponseCode : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/android/billingclient/api/BillingClient$BillingResponseCode", DoNotGenerateAcw=true)]
		internal class IBillingResponseCodeInvoker : global::Java.Lang.Object, IBillingResponseCode {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/BillingClient$BillingResponseCode", typeof (IBillingResponseCodeInvoker));

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

			public static IBillingResponseCode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBillingResponseCode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.BillingClient.BillingResponseCode"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBillingResponseCodeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Android.BillingClient.Api.BillingClient.IBillingResponseCode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IBillingResponseCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.IBillingResponseCode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IBillingResponseCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.IBillingResponseCode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IBillingResponseCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.IBillingResponseCode __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IBillingResponseCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath class reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient.Builder']"
		[global::Android.Runtime.Register ("com/android/billingclient/api/BillingClient$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/BillingClient$Builder", typeof (Builder));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/android/billingclient/api/BillingClient;", "")]
			public unsafe global::Android.BillingClient.Api.BillingClient Build ()
			{
				const string __id = "build.()Lcom/android/billingclient/api/BillingClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient.Builder']/method[@name='enablePendingPurchases' and count(parameter)=0]"
			[Register ("enablePendingPurchases", "()Lcom/android/billingclient/api/BillingClient$Builder;", "")]
			public unsafe global::Android.BillingClient.Api.BillingClient.Builder EnablePendingPurchases ()
			{
				const string __id = "enablePendingPurchases.()Lcom/android/billingclient/api/BillingClient$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient.Builder']/method[@name='setChildDirected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setChildDirected", "(I)Lcom/android/billingclient/api/BillingClient$Builder;", "")]
			public unsafe global::Android.BillingClient.Api.BillingClient.Builder SetChildDirected ([global::Android.Runtime.GeneratedEnum] global::Android.BillingClient.Api.ChildDirectedTypes childDirected)
			{
				const string __id = "setChildDirected.(I)Lcom/android/billingclient/api/BillingClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((int) childDirected);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient.Builder']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.PurchasesUpdatedListener']]"
			[Register ("setListener", "(Lcom/android/billingclient/api/PurchasesUpdatedListener;)Lcom/android/billingclient/api/BillingClient$Builder;", "")]
			public unsafe global::Android.BillingClient.Api.BillingClient.Builder SetListener (global::Android.BillingClient.Api.IPurchasesUpdatedListener listener)
			{
				const string __id = "setListener.(Lcom/android/billingclient/api/PurchasesUpdatedListener;)Lcom/android/billingclient/api/BillingClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient.Builder']/method[@name='setUnderAgeOfConsent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnderAgeOfConsent", "(I)Lcom/android/billingclient/api/BillingClient$Builder;", "")]
			public unsafe global::Android.BillingClient.Api.BillingClient.Builder SetUnderAgeOfConsent ([global::Android.Runtime.GeneratedEnum] global::Android.BillingClient.Api.UnderAgeOfConsentTypes underAgeOfConsent)
			{
				const string __id = "setUnderAgeOfConsent.(I)Lcom/android/billingclient/api/BillingClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((int) underAgeOfConsent);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[Register ("com/android/billingclient/api/BillingClient$FeatureType", DoNotGenerateAcw=true)]
		public abstract class FeatureType : Java.Lang.Object {

			internal FeatureType ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.FeatureType']/field[@name='IN_APP_ITEMS_ON_VR']"
			[Register ("IN_APP_ITEMS_ON_VR")]
			public const string InAppItemsOnVr = (string) "inAppItemsOnVr";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.FeatureType']/field[@name='PRICE_CHANGE_CONFIRMATION']"
			[Register ("PRICE_CHANGE_CONFIRMATION")]
			public const string PriceChangeConfirmation = (string) "priceChangeConfirmation";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.FeatureType']/field[@name='SUBSCRIPTIONS']"
			[Register ("SUBSCRIPTIONS")]
			public const string Subscriptions = (string) "subscriptions";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.FeatureType']/field[@name='SUBSCRIPTIONS_ON_VR']"
			[Register ("SUBSCRIPTIONS_ON_VR")]
			public const string SubscriptionsOnVr = (string) "subscriptionsOnVr";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.FeatureType']/field[@name='SUBSCRIPTIONS_UPDATE']"
			[Register ("SUBSCRIPTIONS_UPDATE")]
			public const string SubscriptionsUpdate = (string) "subscriptionsUpdate";

			// The following are fields from: java.lang.annotation.Annotation

			// The following are fields from: Android.Runtime.IJavaObject

			// The following are fields from: System.IDisposable
		}

		[Register ("com/android/billingclient/api/BillingClient$FeatureType", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'FeatureType' type. This type will be removed in a future release.")]
		public abstract class FeatureTypeConsts : FeatureType {

			private FeatureTypeConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.FeatureType']"
		[Register ("com/android/billingclient/api/BillingClient$FeatureType", "", "Android.BillingClient.Api.BillingClient/IFeatureTypeInvoker")]
		public partial interface IFeatureType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/android/billingclient/api/BillingClient$FeatureType", DoNotGenerateAcw=true)]
		internal class IFeatureTypeInvoker : global::Java.Lang.Object, IFeatureType {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/BillingClient$FeatureType", typeof (IFeatureTypeInvoker));

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

			public static IFeatureType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFeatureType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.BillingClient.FeatureType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFeatureTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Android.BillingClient.Api.BillingClient.IFeatureType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IFeatureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.IFeatureType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IFeatureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.IFeatureType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IFeatureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.IFeatureType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.IFeatureType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		[Register ("com/android/billingclient/api/BillingClient$SkuType", DoNotGenerateAcw=true)]
		public abstract class SkuType : Java.Lang.Object {

			internal SkuType ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.SkuType']/field[@name='INAPP']"
			[Register ("INAPP")]
			public const string Inapp = (string) "inapp";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.SkuType']/field[@name='SUBS']"
			[Register ("SUBS")]
			public const string Subs = (string) "subs";

			// The following are fields from: java.lang.annotation.Annotation

			// The following are fields from: Android.Runtime.IJavaObject

			// The following are fields from: System.IDisposable
		}

		[Register ("com/android/billingclient/api/BillingClient$SkuType", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'SkuType' type. This type will be removed in a future release.")]
		public abstract class SkuTypeConsts : SkuType {

			private SkuTypeConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.android.billingclient.api']/interface[@name='BillingClient.SkuType']"
		[Register ("com/android/billingclient/api/BillingClient$SkuType", "", "Android.BillingClient.Api.BillingClient/ISkuTypeInvoker")]
		public partial interface ISkuType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/android/billingclient/api/BillingClient$SkuType", DoNotGenerateAcw=true)]
		internal class ISkuTypeInvoker : global::Java.Lang.Object, ISkuType {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/BillingClient$SkuType", typeof (ISkuTypeInvoker));

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

			public static ISkuType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISkuType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.android.billingclient.api.BillingClient.SkuType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISkuTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Android.BillingClient.Api.BillingClient.ISkuType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.ISkuType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.ISkuType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.ISkuType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.ISkuType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.ISkuType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.BillingClient.Api.BillingClient.ISkuType __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.ISkuType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/android/billingclient/api/BillingClient", typeof (BillingClient));
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

		protected BillingClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/constructor[@name='BillingClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BillingClient ()
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

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		public abstract bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")] get;
		}

		static Delegate cb_acknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_;
#pragma warning disable 0169
		static Delegate GetAcknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_Handler ()
		{
			if (cb_acknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_ == null)
				cb_acknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AcknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_);
			return cb_acknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_;
		}

		static void n_AcknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.AcknowledgePurchaseParams p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.AcknowledgePurchaseParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.IAcknowledgePurchaseResponseListener p1 = (global::Android.BillingClient.Api.IAcknowledgePurchaseResponseListener)global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IAcknowledgePurchaseResponseListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AcknowledgePurchase (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='acknowledgePurchase' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.AcknowledgePurchaseParams'] and parameter[2][@type='com.android.billingclient.api.AcknowledgePurchaseResponseListener']]"
		[Register ("acknowledgePurchase", "(Lcom/android/billingclient/api/AcknowledgePurchaseParams;Lcom/android/billingclient/api/AcknowledgePurchaseResponseListener;)V", "GetAcknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_Handler")]
		public abstract void AcknowledgePurchase (global::Android.BillingClient.Api.AcknowledgePurchaseParams p0, global::Android.BillingClient.Api.IAcknowledgePurchaseResponseListener p1);

		static Delegate cb_consumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_;
#pragma warning disable 0169
		static Delegate GetConsumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_Handler ()
		{
			if (cb_consumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_ == null)
				cb_consumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConsumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_);
			return cb_consumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_;
		}

		static void n_ConsumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.ConsumeParams p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.ConsumeParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.IConsumeResponseListener p1 = (global::Android.BillingClient.Api.IConsumeResponseListener)global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IConsumeResponseListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeAsync (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='consumeAsync' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.ConsumeParams'] and parameter[2][@type='com.android.billingclient.api.ConsumeResponseListener']]"
		[Register ("consumeAsync", "(Lcom/android/billingclient/api/ConsumeParams;Lcom/android/billingclient/api/ConsumeResponseListener;)V", "GetConsumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_Handler")]
		public abstract void ConsumeAsync (global::Android.BillingClient.Api.ConsumeParams p0, global::Android.BillingClient.Api.IConsumeResponseListener p1);

		static Delegate cb_endConnection;
#pragma warning disable 0169
		static Delegate GetEndConnectionHandler ()
		{
			if (cb_endConnection == null)
				cb_endConnection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndConnection);
			return cb_endConnection;
		}

		static void n_EndConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndConnection ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='endConnection' and count(parameter)=0]"
		[Register ("endConnection", "()V", "GetEndConnectionHandler")]
		public abstract void EndConnection ();

		static Delegate cb_isFeatureSupported_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsFeatureSupported_Ljava_lang_String_Handler ()
		{
			if (cb_isFeatureSupported_Ljava_lang_String_ == null)
				cb_isFeatureSupported_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_IsFeatureSupported_Ljava_lang_String_);
			return cb_isFeatureSupported_Ljava_lang_String_;
		}

		static IntPtr n_IsFeatureSupported_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IsFeatureSupported (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='isFeatureSupported' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFeatureSupported", "(Ljava/lang/String;)Lcom/android/billingclient/api/BillingResult;", "GetIsFeatureSupported_Ljava_lang_String_Handler")]
		public abstract global::Android.BillingClient.Api.BillingResult IsFeatureSupported ([global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", "", "", "", ""})]string p0);

		static Delegate cb_launchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_;
#pragma warning disable 0169
		static Delegate GetLaunchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_Handler ()
		{
			if (cb_launchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_ == null)
				cb_launchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LaunchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_);
			return cb_launchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_;
		}

		static IntPtr n_LaunchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.BillingFlowParams p1 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingFlowParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LaunchBillingFlow (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='launchBillingFlow' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.android.billingclient.api.BillingFlowParams']]"
		[Register ("launchBillingFlow", "(Landroid/app/Activity;Lcom/android/billingclient/api/BillingFlowParams;)Lcom/android/billingclient/api/BillingResult;", "GetLaunchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_Handler")]
		public abstract global::Android.BillingClient.Api.BillingResult LaunchBillingFlow (global::Android.App.Activity p0, global::Android.BillingClient.Api.BillingFlowParams p1);

		static Delegate cb_launchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_;
#pragma warning disable 0169
		static Delegate GetLaunchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_Handler ()
		{
			if (cb_launchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_ == null)
				cb_launchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LaunchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_);
			return cb_launchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_;
		}

		static void n_LaunchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.PriceChangeFlowParams p1 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.PriceChangeFlowParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.IPriceChangeConfirmationListener p2 = (global::Android.BillingClient.Api.IPriceChangeConfirmationListener)global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IPriceChangeConfirmationListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LaunchPriceChangeConfirmationFlow (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='launchPriceChangeConfirmationFlow' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.android.billingclient.api.PriceChangeFlowParams'] and parameter[3][@type='com.android.billingclient.api.PriceChangeConfirmationListener']]"
		[Register ("launchPriceChangeConfirmationFlow", "(Landroid/app/Activity;Lcom/android/billingclient/api/PriceChangeFlowParams;Lcom/android/billingclient/api/PriceChangeConfirmationListener;)V", "GetLaunchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_Handler")]
		public abstract void LaunchPriceChangeConfirmationFlow (global::Android.App.Activity p0, global::Android.BillingClient.Api.PriceChangeFlowParams p1, global::Android.BillingClient.Api.IPriceChangeConfirmationListener p2);

		static Delegate cb_loadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_;
#pragma warning disable 0169
		static Delegate GetLoadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_Handler ()
		{
			if (cb_loadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_ == null)
				cb_loadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_);
			return cb_loadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_;
		}

		static void n_LoadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.RewardLoadParams p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.RewardLoadParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.IRewardResponseListener p1 = (global::Android.BillingClient.Api.IRewardResponseListener)global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IRewardResponseListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadRewardedSku (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='loadRewardedSku' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.RewardLoadParams'] and parameter[2][@type='com.android.billingclient.api.RewardResponseListener']]"
		[Register ("loadRewardedSku", "(Lcom/android/billingclient/api/RewardLoadParams;Lcom/android/billingclient/api/RewardResponseListener;)V", "GetLoadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_Handler")]
		public abstract void LoadRewardedSku (global::Android.BillingClient.Api.RewardLoadParams p0, global::Android.BillingClient.Api.IRewardResponseListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='newBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newBuilder", "(Landroid/content/Context;)Lcom/android/billingclient/api/BillingClient$Builder;", "")]
		public static unsafe global::Android.BillingClient.Api.BillingClient.Builder NewBuilder (global::Android.Content.Context context)
		{
			const string __id = "newBuilder.(Landroid/content/Context;)Lcom/android/billingclient/api/BillingClient$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_;
#pragma warning disable 0169
		static Delegate GetQueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_Handler ()
		{
			if (cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_ == null)
				cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_);
			return cb_queryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_;
		}

		static void n_QueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.IPurchaseHistoryResponseListener p1 = (global::Android.BillingClient.Api.IPurchaseHistoryResponseListener)global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IPurchaseHistoryResponseListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.QueryPurchaseHistoryAsync (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='queryPurchaseHistoryAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.android.billingclient.api.PurchaseHistoryResponseListener']]"
		[Register ("queryPurchaseHistoryAsync", "(Ljava/lang/String;Lcom/android/billingclient/api/PurchaseHistoryResponseListener;)V", "GetQueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_Handler")]
		public abstract void QueryPurchaseHistoryAsync ([global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", ""})]string p0, global::Android.BillingClient.Api.IPurchaseHistoryResponseListener p1);

		static Delegate cb_queryPurchases_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryPurchases_Ljava_lang_String_Handler ()
		{
			if (cb_queryPurchases_Ljava_lang_String_ == null)
				cb_queryPurchases_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryPurchases_Ljava_lang_String_);
			return cb_queryPurchases_Ljava_lang_String_;
		}

		static IntPtr n_QueryPurchases_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.QueryPurchases (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='queryPurchases' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryPurchases", "(Ljava/lang/String;)Lcom/android/billingclient/api/Purchase$PurchasesResult;", "GetQueryPurchases_Ljava_lang_String_Handler")]
		public abstract global::Android.BillingClient.Api.Purchase.PurchasesResult QueryPurchases ([global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", ""})]string p0);

		static Delegate cb_querySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_;
#pragma warning disable 0169
		static Delegate GetQuerySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_Handler ()
		{
			if (cb_querySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_ == null)
				cb_querySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_QuerySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_);
			return cb_querySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_;
		}

		static void n_QuerySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.SkuDetailsParams p0 = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.SkuDetailsParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.ISkuDetailsResponseListener p1 = (global::Android.BillingClient.Api.ISkuDetailsResponseListener)global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.ISkuDetailsResponseListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.QuerySkuDetailsAsync (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='querySkuDetailsAsync' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.SkuDetailsParams'] and parameter[2][@type='com.android.billingclient.api.SkuDetailsResponseListener']]"
		[Register ("querySkuDetailsAsync", "(Lcom/android/billingclient/api/SkuDetailsParams;Lcom/android/billingclient/api/SkuDetailsResponseListener;)V", "GetQuerySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_Handler")]
		public abstract void QuerySkuDetailsAsync (global::Android.BillingClient.Api.SkuDetailsParams p0, global::Android.BillingClient.Api.ISkuDetailsResponseListener p1);

		static Delegate cb_startConnection_Lcom_android_billingclient_api_BillingClientStateListener_;
#pragma warning disable 0169
		static Delegate GetStartConnection_Lcom_android_billingclient_api_BillingClientStateListener_Handler ()
		{
			if (cb_startConnection_Lcom_android_billingclient_api_BillingClientStateListener_ == null)
				cb_startConnection_Lcom_android_billingclient_api_BillingClientStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartConnection_Lcom_android_billingclient_api_BillingClientStateListener_);
			return cb_startConnection_Lcom_android_billingclient_api_BillingClientStateListener_;
		}

		static void n_StartConnection_Lcom_android_billingclient_api_BillingClientStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.BillingClient.Api.BillingClient __this = global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.BillingClient.Api.IBillingClientStateListener p0 = (global::Android.BillingClient.Api.IBillingClientStateListener)global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.IBillingClientStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartConnection (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='startConnection' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.BillingClientStateListener']]"
		[Register ("startConnection", "(Lcom/android/billingclient/api/BillingClientStateListener;)V", "GetStartConnection_Lcom_android_billingclient_api_BillingClientStateListener_Handler")]
		public abstract void StartConnection (global::Android.BillingClient.Api.IBillingClientStateListener p0);

	}

	[global::Android.Runtime.Register ("com/android/billingclient/api/BillingClient", DoNotGenerateAcw=true)]
	internal partial class BillingClientInvoker : BillingClient {

		public BillingClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/android/billingclient/api/BillingClient", typeof (BillingClientInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				const string __id = "isReady.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='acknowledgePurchase' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.AcknowledgePurchaseParams'] and parameter[2][@type='com.android.billingclient.api.AcknowledgePurchaseResponseListener']]"
		[Register ("acknowledgePurchase", "(Lcom/android/billingclient/api/AcknowledgePurchaseParams;Lcom/android/billingclient/api/AcknowledgePurchaseResponseListener;)V", "GetAcknowledgePurchase_Lcom_android_billingclient_api_AcknowledgePurchaseParams_Lcom_android_billingclient_api_AcknowledgePurchaseResponseListener_Handler")]
		public override unsafe void AcknowledgePurchase (global::Android.BillingClient.Api.AcknowledgePurchaseParams p0, global::Android.BillingClient.Api.IAcknowledgePurchaseResponseListener p1)
		{
			const string __id = "acknowledgePurchase.(Lcom/android/billingclient/api/AcknowledgePurchaseParams;Lcom/android/billingclient/api/AcknowledgePurchaseResponseListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='consumeAsync' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.ConsumeParams'] and parameter[2][@type='com.android.billingclient.api.ConsumeResponseListener']]"
		[Register ("consumeAsync", "(Lcom/android/billingclient/api/ConsumeParams;Lcom/android/billingclient/api/ConsumeResponseListener;)V", "GetConsumeAsync_Lcom_android_billingclient_api_ConsumeParams_Lcom_android_billingclient_api_ConsumeResponseListener_Handler")]
		public override unsafe void ConsumeAsync (global::Android.BillingClient.Api.ConsumeParams p0, global::Android.BillingClient.Api.IConsumeResponseListener p1)
		{
			const string __id = "consumeAsync.(Lcom/android/billingclient/api/ConsumeParams;Lcom/android/billingclient/api/ConsumeResponseListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='endConnection' and count(parameter)=0]"
		[Register ("endConnection", "()V", "GetEndConnectionHandler")]
		public override unsafe void EndConnection ()
		{
			const string __id = "endConnection.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='isFeatureSupported' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFeatureSupported", "(Ljava/lang/String;)Lcom/android/billingclient/api/BillingResult;", "GetIsFeatureSupported_Ljava_lang_String_Handler")]
		public override unsafe global::Android.BillingClient.Api.BillingResult IsFeatureSupported ([global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", "", "", "", ""})]string p0)
		{
			const string __id = "isFeatureSupported.(Ljava/lang/String;)Lcom/android/billingclient/api/BillingResult;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='launchBillingFlow' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.android.billingclient.api.BillingFlowParams']]"
		[Register ("launchBillingFlow", "(Landroid/app/Activity;Lcom/android/billingclient/api/BillingFlowParams;)Lcom/android/billingclient/api/BillingResult;", "GetLaunchBillingFlow_Landroid_app_Activity_Lcom_android_billingclient_api_BillingFlowParams_Handler")]
		public override unsafe global::Android.BillingClient.Api.BillingResult LaunchBillingFlow (global::Android.App.Activity p0, global::Android.BillingClient.Api.BillingFlowParams p1)
		{
			const string __id = "launchBillingFlow.(Landroid/app/Activity;Lcom/android/billingclient/api/BillingFlowParams;)Lcom/android/billingclient/api/BillingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.BillingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='launchPriceChangeConfirmationFlow' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.android.billingclient.api.PriceChangeFlowParams'] and parameter[3][@type='com.android.billingclient.api.PriceChangeConfirmationListener']]"
		[Register ("launchPriceChangeConfirmationFlow", "(Landroid/app/Activity;Lcom/android/billingclient/api/PriceChangeFlowParams;Lcom/android/billingclient/api/PriceChangeConfirmationListener;)V", "GetLaunchPriceChangeConfirmationFlow_Landroid_app_Activity_Lcom_android_billingclient_api_PriceChangeFlowParams_Lcom_android_billingclient_api_PriceChangeConfirmationListener_Handler")]
		public override unsafe void LaunchPriceChangeConfirmationFlow (global::Android.App.Activity p0, global::Android.BillingClient.Api.PriceChangeFlowParams p1, global::Android.BillingClient.Api.IPriceChangeConfirmationListener p2)
		{
			const string __id = "launchPriceChangeConfirmationFlow.(Landroid/app/Activity;Lcom/android/billingclient/api/PriceChangeFlowParams;Lcom/android/billingclient/api/PriceChangeConfirmationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='loadRewardedSku' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.RewardLoadParams'] and parameter[2][@type='com.android.billingclient.api.RewardResponseListener']]"
		[Register ("loadRewardedSku", "(Lcom/android/billingclient/api/RewardLoadParams;Lcom/android/billingclient/api/RewardResponseListener;)V", "GetLoadRewardedSku_Lcom_android_billingclient_api_RewardLoadParams_Lcom_android_billingclient_api_RewardResponseListener_Handler")]
		public override unsafe void LoadRewardedSku (global::Android.BillingClient.Api.RewardLoadParams p0, global::Android.BillingClient.Api.IRewardResponseListener p1)
		{
			const string __id = "loadRewardedSku.(Lcom/android/billingclient/api/RewardLoadParams;Lcom/android/billingclient/api/RewardResponseListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='queryPurchaseHistoryAsync' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.android.billingclient.api.PurchaseHistoryResponseListener']]"
		[Register ("queryPurchaseHistoryAsync", "(Ljava/lang/String;Lcom/android/billingclient/api/PurchaseHistoryResponseListener;)V", "GetQueryPurchaseHistoryAsync_Ljava_lang_String_Lcom_android_billingclient_api_PurchaseHistoryResponseListener_Handler")]
		public override unsafe void QueryPurchaseHistoryAsync ([global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", ""})]string p0, global::Android.BillingClient.Api.IPurchaseHistoryResponseListener p1)
		{
			const string __id = "queryPurchaseHistoryAsync.(Ljava/lang/String;Lcom/android/billingclient/api/PurchaseHistoryResponseListener;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='queryPurchases' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryPurchases", "(Ljava/lang/String;)Lcom/android/billingclient/api/Purchase$PurchasesResult;", "GetQueryPurchases_Ljava_lang_String_Handler")]
		public override unsafe global::Android.BillingClient.Api.Purchase.PurchasesResult QueryPurchases ([global::Android.Runtime.StringDef (Type = "", Fields = new string [] {"", ""})]string p0)
		{
			const string __id = "queryPurchases.(Ljava/lang/String;)Lcom/android/billingclient/api/Purchase$PurchasesResult;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.BillingClient.Api.Purchase.PurchasesResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='querySkuDetailsAsync' and count(parameter)=2 and parameter[1][@type='com.android.billingclient.api.SkuDetailsParams'] and parameter[2][@type='com.android.billingclient.api.SkuDetailsResponseListener']]"
		[Register ("querySkuDetailsAsync", "(Lcom/android/billingclient/api/SkuDetailsParams;Lcom/android/billingclient/api/SkuDetailsResponseListener;)V", "GetQuerySkuDetailsAsync_Lcom_android_billingclient_api_SkuDetailsParams_Lcom_android_billingclient_api_SkuDetailsResponseListener_Handler")]
		public override unsafe void QuerySkuDetailsAsync (global::Android.BillingClient.Api.SkuDetailsParams p0, global::Android.BillingClient.Api.ISkuDetailsResponseListener p1)
		{
			const string __id = "querySkuDetailsAsync.(Lcom/android/billingclient/api/SkuDetailsParams;Lcom/android/billingclient/api/SkuDetailsResponseListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.android.billingclient.api']/class[@name='BillingClient']/method[@name='startConnection' and count(parameter)=1 and parameter[1][@type='com.android.billingclient.api.BillingClientStateListener']]"
		[Register ("startConnection", "(Lcom/android/billingclient/api/BillingClientStateListener;)V", "GetStartConnection_Lcom_android_billingclient_api_BillingClientStateListener_Handler")]
		public override unsafe void StartConnection (global::Android.BillingClient.Api.IBillingClientStateListener p0)
		{
			const string __id = "startConnection.(Lcom/android/billingclient/api/BillingClientStateListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
