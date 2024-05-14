// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarDayStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryYydCalendarDayStatisticalDataResponseBodyMetaList> metaList;

    public static QueryYydCalendarDayStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryYydCalendarDayStatisticalDataResponseBody self = new QueryYydCalendarDayStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryYydCalendarDayStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryYydCalendarDayStatisticalDataResponseBody setMetaList(java.util.List<QueryYydCalendarDayStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryYydCalendarDayStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryYydCalendarDayStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryYydCalendarDayStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryYydCalendarDayStatisticalDataResponseBodyMetaList self = new QueryYydCalendarDayStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryYydCalendarDayStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryYydCalendarDayStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryYydCalendarDayStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryYydCalendarDayStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryYydCalendarDayStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
