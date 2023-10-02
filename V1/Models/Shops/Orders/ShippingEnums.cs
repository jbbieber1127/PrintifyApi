namespace PrintifyApi.V1.Models.Shops.Orders
{

    /// <summary>
    /// Outdated.
    /// <para />
    /// <see href="https://developers.printify.com/#calculate-the-shipping-cost-of-an-order" />
    /// </summary>
    [Obsolete("Not in use. See https://developers.printify.com/#calculate-the-shipping-cost-of-an-order")]
    public enum ShippingOption_Old
    {
        standard = 1,
        express = 2
    }

    /// <summary>
    /// CURRENTLY ACTIVE OPTIONS. (2023/10/01)
    /// <para />
    /// <see href="https://developers.printify.com/#calculate-the-shipping-cost-of-an-order" />
    /// </summary>
    public enum ShippingOption_Transitional
    {
        standard = 1,
        express = 2,
        priority = 2,
        printify_express = 3
    }

    /// <summary>
    /// Not currently in use.
    /// <para />
    /// <see href="https://developers.printify.com/#calculate-the-shipping-cost-of-an-order" />
    /// </summary>
    public enum ShippingOption_Final
    {
        standard = 1,
        priority = 2,
        express = 3
    }
}
