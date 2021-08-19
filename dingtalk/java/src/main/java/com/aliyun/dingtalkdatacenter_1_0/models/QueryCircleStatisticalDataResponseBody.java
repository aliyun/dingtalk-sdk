// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCircleStatisticalDataResponseBody extends TeaModel {
    // 指标数据
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    // 指标元数据
    @NameInMap("metaList")
    public java.util.List<QueryCircleStatisticalDataResponseBodyMetaList> metaList;

    public static QueryCircleStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCircleStatisticalDataResponseBody self = new QueryCircleStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCircleStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryCircleStatisticalDataResponseBody setMetaList(java.util.List<QueryCircleStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryCircleStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryCircleStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryCircleStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryCircleStatisticalDataResponseBodyMetaList self = new QueryCircleStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryCircleStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryCircleStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryCircleStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QueryCircleStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryCircleStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

    }

}
