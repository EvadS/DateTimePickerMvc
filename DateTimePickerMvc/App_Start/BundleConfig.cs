using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DateTimePickerMvc.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));


            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                "~/Content/themes/smoothness/jquery-ui.smoothness.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            "~/Content/themes/base/jquery.ui.core.css",
            "~/Content/themes/base/jquery.ui.autocomplete.css",
            "~/Content/themes/base/jquery.ui.datepicker.css",
            "~/Content/themes/base/jquery.ui.theme.css"));

            // Add your jQueryUI styles
            bundles.Add(new StyleBundle("~/Content/themes/smoothness/css").Include(
                            "~/Content/themes/smoothness/jquery-ui.smoothness.css"));


            bundles.Add(new ScriptBundle("~/jquery.validate").Include(
                 "~/Scripts/jquery.validate.js",
                 "~/Scripts/jquery.validate.unobtrusive.js"));
        }
    }
}