/**
 * Created by JHercules on 2015/7/30.
 */
(function ($) {
    $.MODULENAME = function () {
        var self = this;
        this.MODULE_NAME = "MODULENAME";

        //#region Fields

        this.actor = new $.CHNBActor({
            status: {
                isActive: function (oMsg) {
                    console.log("MODULENAME.isActive");
                },
                active: function (oMsg) {
                    console.log("MODULENAME.active");
                },
                isClear: function (oMsg) {
                    console.log("MODULENAME.isClear");
                },
                clear: function (oMsg) {
                    console.log("MODULENAME.clear");
                },
                bindCloseEvent: function (oMsg) {
                    console.log("MODULENAME.bindCloseEvent");
                },
                isInit: function (oMsg) {
                    console.log("MODULENAME.isInit");
                },
                init: function (oMsg) {
                    console.log("MODULENAME.init");
                },
                isSlide: function (oMsg) {
                    console.log("MODULENAME.isSlide");
                },
                slide: function (oMsg) {
                    console.log("MODULENAME.slide");
                },
                onClose: function (oMsg) {
                    console.log("MODULENAME.onClose");
                },
                disClose: function (oMsg) {
                    console.log("MODULENAME.disClose");
                }
            },
            pmsg: {
                PMSGKEY_LOAD: function (oMsg) {
                    console.log("MODULENAME.PMSGKEY_LOAD");
                },
                PMSGKEY_CLEAR: function (oMsg) {
                    console.log("MODULENAME.PMSGKEY_CLEAR");
                }
            },
            msg: {
                //#region demo
                //MSGKEY_11: function (oMsg) {
                //    console.log("MODULENAME.MSGKEY_11");
                //}
                //#endregion
            },
            msgCheck: {
                //#region demo
                //MSGKEY_11: function (oInput, oOutput) {
                //    if (!oInput.value) {
                //        return false;
                //    }
                //    return true;
                //}
                //#endregion
            },
            imsg: {
                IMSGKEY_SHOW: function (oMsg) {
                    console.log("MODULENAME.IMSGKEY_SHOW");
                },
                IMSGKEY_ONCLOSE: function (oMsg) {
                    console.log("MODULENAME.IMSGKEY_ONCLOSE");
                },
                IMSGKEY_DISCLOSE: function (oMsg) {
                    console.log("MODULENAME.IMSGKEY_DISCLOSE");
                },
                //#region demo
                //IMSGKEY_11: function (oMsg, oAfterOK, oAfterPOK) {
                //    console.log("MODULENAME.IMSGKEY_11");
                //    oAfterOK({});
                //},
                //IMSGKEY_12: function (oMsg) {
                //    console.log("MODULENAME.IMSGKEY_12");
                //    return 1;
                //}
                //#endregion
            },
            imsgCheck: {
                //#region demo
                //IMSGKEY_11: function (oInput, oOutput) {
                //    if (!oInput.key) {
                //        return false;
                //    }
                //    if (!oOutput.value) {
                //        return false;
                //    }
                //    return true;
                //},
                //IMSGKEY_12: function (oInput, oOutput) {
                //    if (oOutput != 1) {
                //        return false;
                //    }
                //    return true;
                //}
                //#endregion
            },
            imsgInvoke: {
                //#region demo
                //IMSGKEY_21: function (oMsg) {
                //    CHNBModule.bus.Module2.actor.imsg(oMsg);
                //},
                //IMSGKEY_22: function (oMsg) {
                //    return CHNBModule.bus.Module2.actor.imsg(oMsg);
                //}
                //#endregion
            },
            imsgInvokeCheck: {

            },
            postInvoke: {
                //#region demo
                //POSTKEY_11: function (oMsg, oAfterOK, oAfterPOK) {
                //    console.log("MODULENAME.POSTKEY_11");
                //    oAfterOK(oMsg);
                //}
                //#endregion
            },
            postInvokeCheck: {
                //#region demo
                //POSTKEY_11: function (oInput, oOutput) {
                //    if (!oInput.key) {
                //        return false;
                //    }
                //    return true;
                //}
                //#endregion
            },
            tmsg: {
                //#region demo
                //TMSGKEY_11 :function(oMsg){
                //    console.log("MODULENAME.TMSGKEY_11");
                //}
                //#endregion
            }
        }, self.MODULE_NAME);
        this.MODULENAMEMain = new $.MODULENAMEMain(self.actor);
        this.MODULENAMEMock = new $.MODULENAMEMock(self.actor);

        //#endregion
    };
})(jQuery);