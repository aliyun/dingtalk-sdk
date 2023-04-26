// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListProcessInstanceIdsRequest extends TeaModel {
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("processCode")
    public String processCode;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("statuses")
    public java.util.List<String> statuses;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static ListProcessInstanceIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListProcessInstanceIdsRequest self = new ListProcessInstanceIdsRequest();
        return TeaModel.build(map, self);
    }

    public ListProcessInstanceIdsRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public ListProcessInstanceIdsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListProcessInstanceIdsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListProcessInstanceIdsRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public ListProcessInstanceIdsRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public ListProcessInstanceIdsRequest setStatuses(java.util.List<String> statuses) {
        this.statuses = statuses;
        return this;
    }
    public java.util.List<String> getStatuses() {
        return this.statuses;
    }

    public ListProcessInstanceIdsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
