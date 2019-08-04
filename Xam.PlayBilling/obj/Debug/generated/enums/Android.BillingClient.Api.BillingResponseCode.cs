namespace Android.BillingClient.Api {
  public enum BillingResponseCode {
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.BILLING_UNAVAILABLE")]
    BillingUnavailable = 3,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.DEVELOPER_ERROR")]
    DeveloperError = 5,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.ERROR")]
    Error = 6,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.FEATURE_NOT_SUPPORTED")]
    FeatureNotSupported = -2,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.ITEM_ALREADY_OWNED")]
    ItemAlreadyOwned = 7,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.ITEM_NOT_OWNED")]
    ItemNotOwned = 8,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.ITEM_UNAVAILABLE")]
    ItemUnavailable = 4,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.OK")]
    Ok = 0,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.SERVICE_DISCONNECTED")]
    ServiceDisconnected = -1,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.SERVICE_TIMEOUT")]
    ServiceTimeout = -3,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.SERVICE_UNAVAILABLE")]
    ServiceUnavailable = 2,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/BillingClient$BillingResponseCode.USER_CANCELED")]
    UserCancelled = 1,
  }
}
