// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryCollectingTraceTaskResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("list")
    public java.util.List<QueryCollectingTraceTaskResponseBodyList> list;

    public static QueryCollectingTraceTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectingTraceTaskResponseBody self = new QueryCollectingTraceTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCollectingTraceTaskResponseBody setList(java.util.List<QueryCollectingTraceTaskResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCollectingTraceTaskResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryCollectingTraceTaskResponseBodyList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ffsfsdf</p>
         */
        @NameInMap("appTraceId")
        public String appTraceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("geoCollectPeriod")
        public Long geoCollectPeriod;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("geoReportPeriod")
        public Long geoReportPeriod;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("geoReportStatus")
        public Long geoReportStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("reportEndTime")
        public Long reportEndTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("reportStartTime")
        public Long reportStartTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>I01231231ads1</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryCollectingTraceTaskResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCollectingTraceTaskResponseBodyList self = new QueryCollectingTraceTaskResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryCollectingTraceTaskResponseBodyList setAppTraceId(String appTraceId) {
            this.appTraceId = appTraceId;
            return this;
        }
        public String getAppTraceId() {
            return this.appTraceId;
        }

        public QueryCollectingTraceTaskResponseBodyList setGeoCollectPeriod(Long geoCollectPeriod) {
            this.geoCollectPeriod = geoCollectPeriod;
            return this;
        }
        public Long getGeoCollectPeriod() {
            return this.geoCollectPeriod;
        }

        public QueryCollectingTraceTaskResponseBodyList setGeoReportPeriod(Long geoReportPeriod) {
            this.geoReportPeriod = geoReportPeriod;
            return this;
        }
        public Long getGeoReportPeriod() {
            return this.geoReportPeriod;
        }

        public QueryCollectingTraceTaskResponseBodyList setGeoReportStatus(Long geoReportStatus) {
            this.geoReportStatus = geoReportStatus;
            return this;
        }
        public Long getGeoReportStatus() {
            return this.geoReportStatus;
        }

        public QueryCollectingTraceTaskResponseBodyList setReportEndTime(Long reportEndTime) {
            this.reportEndTime = reportEndTime;
            return this;
        }
        public Long getReportEndTime() {
            return this.reportEndTime;
        }

        public QueryCollectingTraceTaskResponseBodyList setReportStartTime(Long reportStartTime) {
            this.reportStartTime = reportStartTime;
            return this;
        }
        public Long getReportStartTime() {
            return this.reportStartTime;
        }

        public QueryCollectingTraceTaskResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
