/**
 * Created by JHercules on 2015/7/30.
 */
(function ($) {
    $.MODULENAMEMock = function (actor) {
        var self = this;
        this.MODULE_NAME = "MODULENAMEMock";

        actor.impl2({
            imsg: {
                //#region demo
                //IMSGKEY_11:function(oMsg, oAfterOK, oAfterPOK){
                //    console.log("MODULENAMEMock.IMSGKEY_11");
                //    oAfterOK({});
                //},
                //IMSGKEY_12:function(oMsg){
                //    console.log("MODULENAMEMock.IMSGKEY_12");
                //    return 1;
                //}
                //#endregion
            },
            postInvoke: {
                //#region demo
                //POSTKEY_11:function(oMsg, oAfterOK, oAfterPOK){
                //    console.log("MODULENAMEMock.POSTKEY_11");
                //    oAfterOK({});
                //}
                //#endregion
            }
        });
    };
})(jQuery);