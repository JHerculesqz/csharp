(function ($) {
    $.SMK = function () {
        var self = this;
        this.MODULE_NAME = "SMK";

        //#region Fields

        var plugin = new $.SMKPlugin();

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

        this.bindEvent = function (oCallbackSMKClick) {
            plugin.bindEvent(oCallbackSMKClick);
        };

        //#endregion
    };
})(jQuery);