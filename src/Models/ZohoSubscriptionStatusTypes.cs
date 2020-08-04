using System;

namespace ZohoSubscriptions.Net.Models {
    public enum ZohoSubscriptionStatusTypes {
        Unknown = 0,
        Active,
        Live,
        Future,
        Trial,
        NonRenewing
    }
}
