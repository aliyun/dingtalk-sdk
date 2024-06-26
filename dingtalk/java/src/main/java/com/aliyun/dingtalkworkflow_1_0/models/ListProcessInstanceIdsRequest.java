// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListProcessInstanceIdsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1496678400000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-FF6Y2xxxx</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1496678400000</p>
     */
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
