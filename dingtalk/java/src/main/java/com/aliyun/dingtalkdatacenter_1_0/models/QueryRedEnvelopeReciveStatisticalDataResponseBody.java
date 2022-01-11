// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeReciveStatisticalDataResponseBody extends TeaModel {
    // 指标数据
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    // 指标元数据
    @NameInMap("metaList")
    public java.util.List<QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList> metaList;

    public static QueryRedEnvelopeReciveStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRedEnvelopeReciveStatisticalDataResponseBody self = new QueryRedEnvelopeReciveStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRedEnvelopeReciveStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryRedEnvelopeReciveStatisticalDataResponseBody setMetaList(java.util.List<QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList self = new QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
