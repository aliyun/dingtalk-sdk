// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpLeaveRecordsRequest extends TeaModel {
    /**
     * <p>结束时间，YYYY-MM-DDTHH:mm:ssZ (ISO 8601/RFC 3339)</p>
     */
    @NameInMap("endTime")
    public String endTime;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开始时间，YYYY-MM-DDTHH:mm:ssZ (ISO 8601/RFC 3339)</p>
     */
    @NameInMap("startTime")
    public String startTime;

    public static ListEmpLeaveRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListEmpLeaveRecordsRequest self = new ListEmpLeaveRecordsRequest();
        return TeaModel.build(map, self);
    }

    public ListEmpLeaveRecordsRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public ListEmpLeaveRecordsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListEmpLeaveRecordsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListEmpLeaveRecordsRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

}
