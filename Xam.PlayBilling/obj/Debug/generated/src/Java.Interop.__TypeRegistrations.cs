using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/android/billingclient",
						"com/android/billingclient/api",
						"com/android/billingclient/util",
						"com/android/vending/billing",
					},
					new Converter<string, Type>[]{
						lookup_com_android_billingclient_package,
						lookup_com_android_billingclient_api_package,
						lookup_com_android_billingclient_util_package,
						lookup_com_android_vending_billing_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_android_billingclient_mappings;
		static Type lookup_com_android_billingclient_package (string klass)
		{
			if (package_com_android_billingclient_mappings == null) {
				package_com_android_billingclient_mappings = new string[]{
					"com/android/billingclient/BuildConfig:Android.BillingClient.BuildConfig",
				};
			}

			return Lookup (package_com_android_billingclient_mappings, klass);
		}

		static string[] package_com_android_billingclient_api_mappings;
		static Type lookup_com_android_billingclient_api_package (string klass)
		{
			if (package_com_android_billingclient_api_mappings == null) {
				package_com_android_billingclient_api_mappings = new string[]{
					"com/android/billingclient/api/AcknowledgePurchaseParams:Android.BillingClient.Api.AcknowledgePurchaseParams",
					"com/android/billingclient/api/AcknowledgePurchaseParams$Builder:Android.BillingClient.Api.AcknowledgePurchaseParams/Builder",
					"com/android/billingclient/api/BillingClient:Android.BillingClient.Api.BillingClient",
					"com/android/billingclient/api/BillingClient$Builder:Android.BillingClient.Api.BillingClient/Builder",
					"com/android/billingclient/api/BillingFlowParams:Android.BillingClient.Api.BillingFlowParams",
					"com/android/billingclient/api/BillingFlowParams$Builder:Android.BillingClient.Api.BillingFlowParams/Builder",
					"com/android/billingclient/api/BillingResult:Android.BillingClient.Api.BillingResult",
					"com/android/billingclient/api/BillingResult$Builder:Android.BillingClient.Api.BillingResult/Builder",
					"com/android/billingclient/api/ConsumeParams:Android.BillingClient.Api.ConsumeParams",
					"com/android/billingclient/api/ConsumeParams$Builder:Android.BillingClient.Api.ConsumeParams/Builder",
					"com/android/billingclient/api/PriceChangeFlowParams:Android.BillingClient.Api.PriceChangeFlowParams",
					"com/android/billingclient/api/PriceChangeFlowParams$Builder:Android.BillingClient.Api.PriceChangeFlowParams/Builder",
					"com/android/billingclient/api/ProxyBillingActivity:Android.BillingClient.Api.ProxyBillingActivity",
					"com/android/billingclient/api/Purchase:Android.BillingClient.Api.Purchase",
					"com/android/billingclient/api/Purchase$PurchasesResult:Android.BillingClient.Api.Purchase/PurchasesResult",
					"com/android/billingclient/api/PurchaseHistoryRecord:Android.BillingClient.Api.PurchaseHistoryRecord",
					"com/android/billingclient/api/RewardLoadParams:Android.BillingClient.Api.RewardLoadParams",
					"com/android/billingclient/api/RewardLoadParams$Builder:Android.BillingClient.Api.RewardLoadParams/Builder",
					"com/android/billingclient/api/SkuDetails:Android.BillingClient.Api.SkuDetails",
					"com/android/billingclient/api/SkuDetails$SkuDetailsResult:Android.BillingClient.Api.SkuDetails/SkuDetailsResult",
					"com/android/billingclient/api/SkuDetailsParams:Android.BillingClient.Api.SkuDetailsParams",
					"com/android/billingclient/api/SkuDetailsParams$Builder:Android.BillingClient.Api.SkuDetailsParams/Builder",
				};
			}

			return Lookup (package_com_android_billingclient_api_mappings, klass);
		}

		static string[] package_com_android_billingclient_util_mappings;
		static Type lookup_com_android_billingclient_util_package (string klass)
		{
			if (package_com_android_billingclient_util_mappings == null) {
				package_com_android_billingclient_util_mappings = new string[]{
					"com/android/billingclient/util/BillingHelper:Android.BillingClient.Util.BillingHelper",
				};
			}

			return Lookup (package_com_android_billingclient_util_mappings, klass);
		}

		static string[] package_com_android_vending_billing_mappings;
		static Type lookup_com_android_vending_billing_package (string klass)
		{
			if (package_com_android_vending_billing_mappings == null) {
				package_com_android_vending_billing_mappings = new string[]{
					"com/android/vending/billing/IInAppBillingService$Stub:Android.Vending.Billing.InAppBillingServiceStub",
				};
			}

			return Lookup (package_com_android_vending_billing_mappings, klass);
		}
	}
}
