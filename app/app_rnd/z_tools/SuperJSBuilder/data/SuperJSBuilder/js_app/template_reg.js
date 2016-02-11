function MODULENAME() {
    //#region interface

    this.pmsg = function(oMsg){
        CHNBModule.bus.MODULENAME.actor.pmsg(oMsg);
    };

    this.msg = function(oMsg){
        CHNBModule.bus.MODULENAME.actor.msg(oMsg);
    };

    //#endregion

    //#region Fields

    this.MODULENAME = CHNBMock.getInstance("MODULENAME");

    //#endregion
}