// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgMonthStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList> metaList;

    public static QueryYydSingleMsgMonthStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryYydSingleMsgMonthStatisticalDataResponseBody self = new QueryYydSingleMsgMonthStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryYydSingleMsgMonthStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryYydSingleMsgMonthStatisticalDataResponseBody setMetaList(java.util.List<QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList extends TeaModel {
        @NameInMap("kpiCaliber")
        public String kpiCaliber;

        @NameInMap("kpiId")
        public String kpiId;

        @NameInMap("kpiName")
        public String kpiName;

        @NameInMap("period")
        public String period;

        @NameInMap("unit")
        public String unit;

        public static QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList self = new QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
