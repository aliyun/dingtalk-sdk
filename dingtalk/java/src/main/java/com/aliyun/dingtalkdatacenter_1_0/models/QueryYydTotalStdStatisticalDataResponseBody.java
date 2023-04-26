// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalStdStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryYydTotalStdStatisticalDataResponseBodyMetaList> metaList;

    public static QueryYydTotalStdStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalStdStatisticalDataResponseBody self = new QueryYydTotalStdStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalStdStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryYydTotalStdStatisticalDataResponseBody setMetaList(java.util.List<QueryYydTotalStdStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryYydTotalStdStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryYydTotalStdStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryYydTotalStdStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryYydTotalStdStatisticalDataResponseBodyMetaList self = new QueryYydTotalStdStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryYydTotalStdStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryYydTotalStdStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryYydTotalStdStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryYydTotalStdStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryYydTotalStdStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
