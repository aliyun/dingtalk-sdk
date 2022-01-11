// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryCollectingTraceTaskResponseBody extends TeaModel {
    // result
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
        // 应用轨迹ID
        @NameInMap("appTraceId")
        public String appTraceId;

        @NameInMap("geoCollectPeriod")
        public Long geoCollectPeriod;

        @NameInMap("geoReportPeriod")
        public Long geoReportPeriod;

        @NameInMap("geoReportStatus")
        public Long geoReportStatus;

        @NameInMap("reportEndTime")
        public Long reportEndTime;

        @NameInMap("reportStartTime")
        public Long reportStartTime;

        // 组织下员工Id
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
