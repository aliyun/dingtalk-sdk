// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTodoStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryTodoStatisticalDataResponseBodyMetaList> metaList;

    public static QueryTodoStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTodoStatisticalDataResponseBody self = new QueryTodoStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTodoStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryTodoStatisticalDataResponseBody setMetaList(java.util.List<QueryTodoStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryTodoStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryTodoStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryTodoStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryTodoStatisticalDataResponseBodyMetaList self = new QueryTodoStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryTodoStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryTodoStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryTodoStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryTodoStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryTodoStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
