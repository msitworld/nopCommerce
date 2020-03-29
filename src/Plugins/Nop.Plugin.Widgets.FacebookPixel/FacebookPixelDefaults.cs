﻿using Nop.Core.Caching;

namespace Nop.Plugin.Widgets.FacebookPixel
{
    /// <summary>
    /// Represents plugin constants
    /// </summary>
    public class FacebookPixelDefaults
    {
        /// <summary>
        /// Gets the plugin system name
        /// </summary>
        public static string SystemName => "Widgets.FacebookPixel";

        /// <summary>
        /// Gets the nopCommerce agent ID
        /// </summary>
        public static string AgentId => "plnopcommerce";

        /// <summary>
        /// Gets the configuration route name
        /// </summary>
        public static string ConfigurationRouteName => "Plugin.Widgets.FacebookPixel.Configure";

        /// <summary>
        /// Gets the generic attribute name to hide search block on the plugin configuration page
        /// </summary>
        public static string HideSearchBlockAttribute = "FacebookPixel.HideSearchBlock";

        /// <summary>
        /// Gets the route name of checkout endpoint
        /// </summary>
        public static string CheckoutRouteName => "Checkout";

        /// <summary>
        /// Gets the route name of one page checkout endpoint
        /// </summary>
        public static string CheckoutOnePageRouteName => "CheckoutOnePage";

        /// <summary>
        /// Gets the name of the view component to place Facebook Pixel into the page
        /// </summary>
        public const string VIEW_COMPONENT = "FacebookPixel";

        #region Caching

        /// <summary>
        /// Gets the cache key for configuration
        /// </summary>
        /// <remarks>
        /// {0} : configuration identifier
        /// </remarks>
        public static CacheKey ConfigurationCacheKey => new CacheKey("Nop.Plugin.Widgets.FacebookPixel.Configuration-{0}", PrefixCacheKey);

        /// <summary>
        /// Gets the cache key for configurations
        /// </summary>
        /// <remarks>
        /// {0} : store identifier
        /// </remarks>
        public static CacheKey ConfigurationsCacheKey => new CacheKey("Nop.Plugin.Widgets.FacebookPixel.Configurations-{0}", PrefixCacheKey);

        /// <summary>
        /// Gets the cache key for custom events
        /// </summary>
        /// </summary>
        public static CacheKey CustomEventsCacheKey => new CacheKey("Nop.Plugin.Widgets.FacebookPixel.CustomEvents-{0}", PrefixCacheKey);

        /// <summary>
        /// Gets the cache key for widget zones
        /// </summary>
        public static CacheKey WidgetZonesCacheKey => new CacheKey("Nop.Plugin.Widgets.FacebookPixel.WidgetZones", PrefixCacheKey);

        /// <summary>
        /// Gets the prefix key to clear cache
        /// </summary>
        public static string PrefixCacheKey => "Nop.Plugin.Widgets.FacebookPixel";

        #endregion

        #region Tracked events

        /// <summary>
        /// Gets the name of an event when a person lands on website pages
        /// </summary>
        public const string PAGE_VIEW = "PageView";

        /// <summary>
        /// Gets the name of an event when a product is added to the shopping cart
        /// </summary>
        public const string ADD_TO_CART = "AddToCart";

        /// <summary>
        /// Gets the name of an event when a purchase is made or checkout flow is completed
        /// </summary>
        public const string PURCHASE = "Purchase";

        /// <summary>
        /// Gets the name of an event when someone visit to a product page
        /// </summary>
        public const string VIEW_CONTENT = "ViewContent";

        /// <summary>
        /// Gets the name of an event when a product is added to the wishlist
        /// </summary>
        public const string ADD_TO_WISHLIST = "AddToWishlist";

        /// <summary>
        /// Gets the name of an event when a person enters the checkout flow prior to completing the checkout flow
        /// </summary>
        public const string INITIATE_CHECKOUT = "InitiateCheckout";

        /// <summary>
        /// Gets the name of an event when a search is made
        /// </summary>
        public const string SEARCH = "Search";

        /// <summary>
        /// Gets the name of an event when a person initiates contact with merchant business via contact form
        /// </summary>
        public const string CONTACT = "Contact";

        /// <summary>
        /// Gets the name of an event when a registration form is completed
        /// </summary>
        public const string COMPLETE_REGISTRATION = "CompleteRegistration";

        /// <summary>
        /// Gets the name of a session value to store prepared scripts for tracked events
        /// </summary>
        public static string TrackedEventsSessionValue => "FacebookPixelTrackedEvents";

        #endregion
    }
}