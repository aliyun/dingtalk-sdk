// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCalendarStatisticalDataResponseBody extends TeaModel {
    // 指标数据
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    // 指标元数据
    @NameInMap("metaList")
    public java.util.List<QueryCalendarStatisticalDataResponseBodyMetaList> metaList;

    public static QueryCalendarStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCalendarStatisticalDataResponseBody self = new QueryCalendarStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCalendarStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryCalendarStatisticalDataResponseBody setMetaList(java.util.List<QueryCalendarStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryCalendarStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryCalendarStatisticalDataResponseBodyMetaList extends TeaModel {
        // 指标ID
        @NameInMap("kpiId")
        public String kpiId;

        // 指标名称
        @NameInMap("kpiName")
        public String kpiName;

        // 指标单位
        @NameInMap("unit")
        public String unit;

        // 指标口径
        @NameInMap("kpiCaliber")
        public String kpiCaliber;

        // 指标周期
        @NameInMap("period")
        public String period;

        public static QueryCalendarStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryCalendarStatisticalDataResponseBodyMetaList self = new QueryCalendarStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryCalendarStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryCalendarStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryCalendarStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QueryCalendarStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryCalendarStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

    }

}
