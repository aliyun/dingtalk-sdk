// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeSendStatisticalDataResponseBody extends TeaModel {
    // 指标数据
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    // 指标元数据
    @NameInMap("metaList")
    public java.util.List<QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList> metaList;

    public static QueryRedEnvelopeSendStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRedEnvelopeSendStatisticalDataResponseBody self = new QueryRedEnvelopeSendStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRedEnvelopeSendStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryRedEnvelopeSendStatisticalDataResponseBody setMetaList(java.util.List<QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList self = new QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
