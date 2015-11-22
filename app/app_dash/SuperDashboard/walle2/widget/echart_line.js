(function ($) {
    /**
     * 详见test.html<br>
     * @constructor
     */
    $.CHNBEChartLine = function () {
        var self = this;
        this.WIDGET_NAME = "CHNBEChartLine";
        this.m_oOptions;
        var m_oChart;
        var m_oOptionsLine;

        //#region init

        this.init = function (strParentId, oOptions) {
            self.m_oOptions = oOptions;

            m_oChart = echarts.init(document.getElementById(strParentId));
            m_oOptionsLine = _initOptionLine(oOptions.title,
                oOptions.subTitle,
                oOptions.arrLegend,
                oOptions.arrX,
                oOptions.strYPrefix,
                oOptions.startPercent);
        };
        var _initOptionLine = function (strTitle, strSubTitle, arrLegend, arrX, strYPrefix, iStartPercent) {
            var option = {
                title: {
                    text: strTitle,
                    subtext: strSubTitle
                },
                tooltip: {
                    trigger: 'axis'//item
                },
                legend: {
                    data: arrLegend,
                    orient: 'vertical',
                    x: 'right',
                    y: 'center'
                },
                toolbox: {
                    show: true,
                    feature: {
                        mark: { show: true },
                        dataView: { show: true, readOnly: false },
                        magicType: { show: true, type: ['line', 'bar'] },
                        restore: { show: true },
                        saveAsImage: { show: true }
                    }
                },
                dataZoom: {
                    show: true,
                    realtime: true,
                    start: iStartPercent,
                    end: 100
                },
                calculable: true,
                xAxis: [{
                    type: 'category',
                    boundaryGap: false,
                    data: arrX
                }],
                yAxis: [
                    {
                        type: 'value',
                        axisLabel: {
                            formatter: '{value}' + strYPrefix
                        }
                    }
                ],
                series: []
            };

            return option;
        };

        //#endregion

        //#region addLine

        this.addLines = function (oLineDatas) {
            m_oOptionsLine.series = [];
            $.each(oLineDatas, function (strLineName, arrData) {
                var oOptionY = {
                    name: strLineName,
                    type: 'line',
                    data: arrData
                    //markLine: {
                    //    data: [
                    //        { type: 'average', name: '平均值' }
                    //    ]
                    //}
                };
                m_oOptionsLine.series.push(oOptionY);
            });
        };

        //#endregion

        //#region reDraw

        this.reDraw = function () {
            m_oChart.setOption(m_oOptionsLine);
        };

        //#endregion
    };
})(jQuery);