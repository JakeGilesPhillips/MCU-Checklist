﻿using System.Web;
using System.Web.Optimization;

namespace MCUChecklist
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Libraries/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Libraries/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Libraries/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/Site/Cookies.js",
                        "~/Scripts/Site/Header.js",
                        "~/Scripts/Site/Homepage.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/Shared/site.css",
                      "~/Content/Styles/Shared/flex.css",
                      "~/Content/Styles/Shared/responsivecss.css",
                      "~/Content/Styles/Header/header.css",
                      "~/Content/Styles/Home/index.css",
                      "~/Content/Styles/Home/Tile/tile.css",
                      "~/Content/Styles/Account/login.css"));
        }
    }
}
