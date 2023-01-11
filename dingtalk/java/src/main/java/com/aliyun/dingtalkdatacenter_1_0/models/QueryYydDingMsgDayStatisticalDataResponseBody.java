// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydDingMsgDayStatisticalDataResponseBody extends TeaModel {
    /**
     * <p>指标数据</p>
     */
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    /**
     * <p>指标元数据</p>
     */
    @NameInMap("metaList")
    public java.util.List<QueryYydDingMsgDayStatisticalDataResponseBodyMetaList> metaList;

    public static QueryYydDingMsgDayStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryYydDingMsgDayStatisticalDataResponseBody self = new QueryYydDingMsgDayStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryYydDingMsgDayStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryYydDingMsgDayStatisticalDataResponseBody setMetaList(java.util.List<QueryYydDingMsgDayStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryYydDingMsgDayStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryYydDingMsgDayStatisticalDataResponseBodyMetaList extends TeaModel {
        /**
         * <p>指标口径</p>
         */
        @NameInMap("kpiCaliber")
        public String kpiCaliber;

        /**
         * <p>指标ID</p>
         */
        @NameInMap("kpiId")
        public String kpiId;

        /**
         * <p>指标名称</p>
         */
        @NameInMap("kpiName")
        public String kpiName;

        /**
         * <p>指标周期</p>
         */
        @NameInMap("period")
        public String period;

        /**
         * <p>指标单位</p>
         */
        @NameInMap("unit")
        public String unit;

        public static QueryYydDingMsgDayStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryYydDingMsgDayStatisticalDataResponseBodyMetaList self = new QueryYydDingMsgDayStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryYydDingMsgDayStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryYydDingMsgDayStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryYydDingMsgDayStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryYydDingMsgDayStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryYydDingMsgDayStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
