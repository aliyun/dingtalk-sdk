// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryPageTraceDataRequest extends TeaModel {
    // traceId
    @NameInMap("traceId")
    public String traceId;

    // 起始位置
    @NameInMap("nextToken")
    public Long nextToken;

    // 查询数量
    @NameInMap("maxResults")
    public Long maxResults;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 终止时间
    @NameInMap("endTime")
    public Long endTime;

    // 员工ID
    @NameInMap("staffId")
    public String staffId;

    public static QueryPageTraceDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPageTraceDataRequest self = new QueryPageTraceDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryPageTraceDataRequest setTraceId(String traceId) {
        this.traceId = traceId;
        return this;
    }
    public String getTraceId() {
        return this.traceId;
    }

    public QueryPageTraceDataRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryPageTraceDataRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryPageTraceDataRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryPageTraceDataRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryPageTraceDataRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

}
