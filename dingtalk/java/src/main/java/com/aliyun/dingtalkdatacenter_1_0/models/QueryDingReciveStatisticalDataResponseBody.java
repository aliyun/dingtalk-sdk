// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDingReciveStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryDingReciveStatisticalDataResponseBodyMetaList> metaList;

    public static QueryDingReciveStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDingReciveStatisticalDataResponseBody self = new QueryDingReciveStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDingReciveStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryDingReciveStatisticalDataResponseBody setMetaList(java.util.List<QueryDingReciveStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryDingReciveStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryDingReciveStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryDingReciveStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryDingReciveStatisticalDataResponseBodyMetaList self = new QueryDingReciveStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryDingReciveStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryDingReciveStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryDingReciveStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryDingReciveStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryDingReciveStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
