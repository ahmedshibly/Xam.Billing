namespace Android.BillingClient.Api {
  public enum PurchaseState {
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/Purchase$PurchaseState.PENDING")]
    Pending = 2,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/Purchase$PurchaseState.PURCHASED")]
    Purchased = 1,
    [global::Android.Runtime.IntDefinition (null, JniField = "com/android/billingclient/api/Purchase$PurchaseState.UNSPECIFIED_STATE")]
    Unspecified = 0,
  }
}
