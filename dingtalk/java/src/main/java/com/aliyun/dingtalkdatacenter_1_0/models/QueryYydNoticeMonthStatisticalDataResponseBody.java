// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydNoticeMonthStatisticalDataResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<QueryYydNoticeMonthStatisticalDataResponseBodyMetaList> metaList;

    public static QueryYydNoticeMonthStatisticalDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryYydNoticeMonthStatisticalDataResponseBody self = new QueryYydNoticeMonthStatisticalDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryYydNoticeMonthStatisticalDataResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public QueryYydNoticeMonthStatisticalDataResponseBody setMetaList(java.util.List<QueryYydNoticeMonthStatisticalDataResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<QueryYydNoticeMonthStatisticalDataResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class QueryYydNoticeMonthStatisticalDataResponseBodyMetaList extends TeaModel {
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

        public static QueryYydNoticeMonthStatisticalDataResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            QueryYydNoticeMonthStatisticalDataResponseBodyMetaList self = new QueryYydNoticeMonthStatisticalDataResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public QueryYydNoticeMonthStatisticalDataResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public QueryYydNoticeMonthStatisticalDataResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public QueryYydNoticeMonthStatisticalDataResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public QueryYydNoticeMonthStatisticalDataResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public QueryYydNoticeMonthStatisticalDataResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
