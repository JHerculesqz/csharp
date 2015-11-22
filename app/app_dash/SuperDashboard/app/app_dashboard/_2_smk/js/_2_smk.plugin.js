(function ($) {
    $.SMKPlugin = function () {
        var self = this;
        this.MODULE_NAME = "SMKPlugin";

        //#region Const

        var COUNT_X = 365;

        //#endregion

        //#region Fields

        this.m_oCHNBEChartLine = new $.CHNBEChartLine();

        //#endregion

        //#region getXByPost

        this.getXByPost = function (oCallback) {
            var arrX = [];
            for (var i = 0; i < COUNT_X; i++) {
                arrX.push(i);
            }
            oCallback(arrX);
        };

        //#endregion

        //#region init

        this.init = function (arrX, iLastMon) {
            var oOptions = {
                title: "SMK测试",
                subTitle: $("#m_comboBoxBranch").val() + " - " + $("#m_comboBoxAutoType").val(),
                arrLegend: _getLegend(),
                arrX: arrX,
                strYPrefix: "%",
                startPercent: _calcStartPercent(iLastMon)
            };
            self.m_oCHNBEChartLine.init("m_panel", oOptions);
        };
        var _calcStartPercent = function (iLastMon) {
            if (0 == iLastMon) {
                return 0;
            }
            else if (3 == iLastMon) {
                return (365 - 90) / 365 * 100;
            }
            else if (2 == iLastMon) {
                return (365 - 60) / 365 * 100;
            }
            else if (1 == iLastMon) {
                return (365 - 30) / 365 * 100;
            }
        };
        var _getLegend = function () {
            if ($("#m_comboBoxAutoType").val() == "UI自动化") {
                return [
                "局点1",
                "局点2",
                "局点3",
                "局点4",
                "局点5"
                ];
            }
            else {
                return [
                "ACL",
                "BGP",
                "ISIS",
                "OSPF",
                "MPLS LDP",
                "MPLS TE",
                "VRRP",
                "DIRECT",
                "STATIC",
                "CLOCK",
                "FOEWARDING",
                "LOAD TO FLOW",
                "L3VPN"
                ];
            }
        };

        //#endregion

        //#region getDataByPost

        this.getDataByPost = function (oCallback) {
            if ($("#m_comboBoxAutoType").val() == "UI自动化") {
                var oLineDatas = {
                    "局点1": _getData(),
                    "局点2": _getData(),
                    "局点3": _getData(),
                    "局点4": _getData(),
                    "局点5": _getData()
                };
                oCallback(oLineDatas);
            }
            else {
                var oLineDatas = {
                    "ACL": _getData(),
                    "BGP": _getData(),
                    "ISIS": _getData(),
                    "OSPF": _getData(),
                    "MPLS LDP": _getData(),
                    "MPLS TE": _getData(),
                    "VRRP": _getData(),
                    "DIRECT": _getData(),
                    "STATIC": _getData(),
                    "CLOCK": _getData(),
                    "FOEWARDING": _getData(),
                    "LOAD TO FLOW": _getData(),
                    "L3VPN": _getData()
                };
                oCallback(oLineDatas);
            }
        };
        var i = 1;
        var _getData = function () {
            var arrData = [];
            for (var j = 1; j <= COUNT_X; j++) {
                arrData.push(40 + i + Math.random() * 5);
            }

            i >= 30 ? i = 1 : i += 10;
            return arrData;
        };

        //#endregion

        //#region addLines

        this.addLines = function (oLineDatas) {
            self.m_oCHNBEChartLine.addLines(oLineDatas);
        };

        //#endregion

        //#region reDraw

        this.reDraw = function () {
            self.m_oCHNBEChartLine.reDraw();
        };

        //#endregion

        //#region bindEvent

        this.bindEvent = function (oCallbackSMKClick) {
            $("#m_btnAllMon").click(function () {
                oCallbackSMKClick(0);
            });

            $("#m_btnLast3Mon").click(function () {
                oCallbackSMKClick(3);
            });

            $("#m_btnLast2Mon").click(function () {
                oCallbackSMKClick(2);
            });

            $("#m_btnLast1Mon").click(function () {
                oCallbackSMKClick(1);
            });
        };

        //#endregion
    };
})(jQuery);