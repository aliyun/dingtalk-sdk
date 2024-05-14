// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeReciveStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kpiCaliber")
        public String kpiCaliber;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kpiId")
        public String kpiId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kpiName")
        public String kpiName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("period")
        public String period;

        /**
         * <p>This parameter is required.</p>
         */
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
