// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryPageTraceDataRequest extends TeaModel {
    /**
     * <p>终止时间</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>查询数量</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>起始位置</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>员工ID</p>
     */
    @NameInMap("staffId")
    public String staffId;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>traceId</p>
     */
    @NameInMap("traceId")
    public String traceId;

    public static QueryPageTraceDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPageTraceDataRequest self = new QueryPageTraceDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryPageTraceDataRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryPageTraceDataRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryPageTraceDataRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryPageTraceDataRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public QueryPageTraceDataRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryPageTraceDataRequest setTraceId(String traceId) {
        this.traceId = traceId;
        return this;
    }
    public String getTraceId() {
        return this.traceId;
    }

}
