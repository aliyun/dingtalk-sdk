// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDriveStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryDriveStatisticalDataResponseBodyMetaList> metaList;

    public static QueryDriveStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDriveStatisticalDataResponseBody self = new QueryDriveStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDriveStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryDriveStatisticalDataResponseBody setMetaList(java.util.List<QueryDriveStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryDriveStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryDriveStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryDriveStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryDriveStatisticalDataResponseBodyMetaList self = new QueryDriveStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryDriveStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryDriveStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryDriveStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryDriveStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryDriveStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
