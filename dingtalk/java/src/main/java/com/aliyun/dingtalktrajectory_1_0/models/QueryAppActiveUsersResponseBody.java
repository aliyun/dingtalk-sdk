// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryAppActiveUsersResponseBody extends TeaModel {
    // 是否存在更多数据需要获取
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 数据集合
    @NameInMap("list")
    public java.util.List<QueryAppActiveUsersResponseBodyList> list;

    // 下一次获取开始位置
    @NameInMap("nextToken")
    public Long nextToken;

    // 总数
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryAppActiveUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAppActiveUsersResponseBody self = new QueryAppActiveUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAppActiveUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryAppActiveUsersResponseBody setList(java.util.List<QueryAppActiveUsersResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryAppActiveUsersResponseBodyList> getList() {
        return this.list;
    }

    public QueryAppActiveUsersResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryAppActiveUsersResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryAppActiveUsersResponseBodyList extends TeaModel {
        // 应用轨迹ID
        @NameInMap("appTraceId")
        public String appTraceId;

        // 纬度
        @NameInMap("latitude")
        public Float latitude;

        // 经度
        @NameInMap("longitude")
        public Float longitude;

        // 该位置采集时间
        @NameInMap("reportTime")
        public Long reportTime;

        // 轨迹采集开启时间
        @NameInMap("startTime")
        public Long startTime;

        // 员工Id
        @NameInMap("userId")
        public String userId;

        public static QueryAppActiveUsersResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryAppActiveUsersResponseBodyList self = new QueryAppActiveUsersResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryAppActiveUsersResponseBodyList setAppTraceId(String appTraceId) {
            this.appTraceId = appTraceId;
            return this;
        }
        public String getAppTraceId() {
            return this.appTraceId;
        }

        public QueryAppActiveUsersResponseBodyList setLatitude(Float latitude) {
            this.latitude = latitude;
            return this;
        }
        public Float getLatitude() {
            return this.latitude;
        }

        public QueryAppActiveUsersResponseBodyList setLongitude(Float longitude) {
            this.longitude = longitude;
            return this;
        }
        public Float getLongitude() {
            return this.longitude;
        }

        public QueryAppActiveUsersResponseBodyList setReportTime(Long reportTime) {
            this.reportTime = reportTime;
            return this;
        }
        public Long getReportTime() {
            return this.reportTime;
        }

        public QueryAppActiveUsersResponseBodyList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryAppActiveUsersResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
