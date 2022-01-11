// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTelMeetingStatisticalDataResponseBody extends TeaModel {
    // 指标数据
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    // 指标元数据
    @NameInMap("metaList")
    public java.util.List<QueryTelMeetingStatisticalDataResponseBodyMetaList> metaList;

    public static QueryTelMeetingStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTelMeetingStatisticalDataResponseBody self = new QueryTelMeetingStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTelMeetingStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryTelMeetingStatisticalDataResponseBody setMetaList(java.util.List<QueryTelMeetingStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryTelMeetingStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryTelMeetingStatisticalDataResponseBodyMetaList extends TeaModel {
        // 指标口径
        @NameInMap("kpiCaliber")
        public String kpiCaliber;

        // 指标ID
        @NameInMap("kpiId")
        public String kpiId;

        // 指标名称
        @NameInMap("kpiName")
        public String kpiName;

        // 指标周期
        @NameInMap("period")
        public String period;

        // 指标单位
        @NameInMap("unit")
        public String unit;

        public static QueryTelMeetingStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryTelMeetingStatisticalDataResponseBodyMetaList self = new QueryTelMeetingStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryTelMeetingStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryTelMeetingStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryTelMeetingStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryTelMeetingStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryTelMeetingStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
