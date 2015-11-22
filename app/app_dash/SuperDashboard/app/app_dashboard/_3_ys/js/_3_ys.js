(function ($) {
    $.YS = function () {
        var self = this;
        this.MODULE_NAME = "YS";

        //#region Fields

        var plugin = new $.YSPlugin();

        //#endregion

        //#region init

        this.init = function (oCallback, iLastMon) {
            plugin.getXByPost(function (arrX) {
                plugin.init(arrX, iLastMon);

                oCallback();
            });
        };

        //#endregion

        //#region getData

        this.getData = function () {
            plugin.getDataByPost(function (oLineDatas) {
                plugin.addLines(oLineDatas);
            });
        };

        //#endregion

        //#region reDraw

        this.reDraw = function () {
            plugin.reDraw();
        };

        //#endregion

        //#region bindEvent

        this.bindEvent = function (oCallbackYSClick) {
            plugin.bindEvent(oCallbackYSClick);
        };

        //#endregion
    };
})(jQuery);