// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppStdStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryYydAppStdStatisticalDataResponseBodyMetaList> metaList;

    public static QueryYydAppStdStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppStdStatisticalDataResponseBody self = new QueryYydAppStdStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryYydAppStdStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryYydAppStdStatisticalDataResponseBody setMetaList(java.util.List<QueryYydAppStdStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryYydAppStdStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryYydAppStdStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryYydAppStdStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryYydAppStdStatisticalDataResponseBodyMetaList self = new QueryYydAppStdStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryYydAppStdStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryYydAppStdStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryYydAppStdStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryYydAppStdStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryYydAppStdStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
