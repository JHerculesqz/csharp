(function ($) {
    $.MODULENAMEMain = function (actor) {
        var self = this;
        this.MODULE_NAME = "MODULENAMEMain";

        //#region Fields

        actor.impl({
            status: {
                isActive: function (oMsg) {
                    console.log("MODULENAMEMain.isActive");
                },
                active: function (oMsg) {
                    console.log("MODULENAMEMain.active");
                },
                isClear: function (oMsg) {
                    console.log("MODULENAMEMain.isClear");
                },
                clear: function (oMsg) {
                    console.log("MODULENAMEMain.clear");
                },
                bindCloseEvent: function (oMsg) {
                    console.log("MODULENAMEMain.bindCloseEvent");
                },
                isInit: function (oMsg) {
                    console.log("MODULENAMEMain.isInit");
                },
                init: function (oMsg) {
                    console.log("MODULENAMEMain.init");
                },
                isSlide: function (oMsg) {
                    console.log("MODULENAMEMain.isSlide");
                },
                slide: function (oMsg) {
                    console.log("MODULENAMEMain.slide");
                },
                onClose: function (oMsg) {
                    console.log("MODULENAMEMain.onClose");
                },
                disClose: function (oMsg) {
                    console.log("MODULENAMEMain.disClose");
                }
            },
            pmsg: {
                PMSGKEY_LOAD: function (oMsg) {
                    console.log("MODULENAMEMain.PMSGKEY_LOAD");
                },
                PMSGKEY_CLEAR: function (oMsg) {
                    console.log("MODULENAMEMain.PMSGKEY_CLEAR");
                }
            },
            msg: {
                //#region demo
                //MSGKEY_11: function (oMsg) {
                //    console.log("MODULENAMEMain.MSGKEY_11");
                //}
                //#endregion
            },
            imsg: {
                //#region demo
                //IMSGKEY_11: function (oMsg, oAfterOK, oAfterPOK) {
                //    console.log("MODULENAMEMain.IMSGKEY_11");
                //    oAfterOK({});
                //},
                //IMSGKEY_12: function (oMsg) {
                //    console.log("MODULENAMEMain.IMSGKEY_12");
                //    return 1;
                //}
                //#endregion
            },
            postInvoke: {
                //#region demo
                //POSTKEY_11: function (oMsg, oAfterOK, oAfterPOK) {
                //    console.log("MODULENAMEMain.POSTKEY_11");
                //    oAfterOK({});
                //}
                //#endregion
            },
            tmsg: {
                //#region demo
                //TMSGKEY_11 :function(oMsg){
                //    console.log("MODULENAMEMain.TMSGKEY_11");
                //}
                //#endregion
            }
        });

        //#endregion
    };
})(jQuery);