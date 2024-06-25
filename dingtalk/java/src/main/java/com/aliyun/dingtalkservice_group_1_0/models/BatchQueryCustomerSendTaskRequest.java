// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryCustomerSendTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2023-06-02 00:00:00</p>
     */
    @NameInMap("gmtCreateEnd")
    public String gmtCreateEnd;

    /**
     * <strong>example:</strong>
     * <p>2023-06-01 00:00:00</p>
     */
    @NameInMap("gmtCreateStart")
    public String gmtCreateStart;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("needRichStatistics")
    public Boolean needRichStatistics;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("openBatchTaskIds")
    public java.util.List<String> openBatchTaskIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>哈哈哈</p>
     */
    @NameInMap("taskName")
    public String taskName;

    public static BatchQueryCustomerSendTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryCustomerSendTaskRequest self = new BatchQueryCustomerSendTaskRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryCustomerSendTaskRequest setGmtCreateEnd(String gmtCreateEnd) {
        this.gmtCreateEnd = gmtCreateEnd;
        return this;
    }
    public String getGmtCreateEnd() {
        return this.gmtCreateEnd;
    }

    public BatchQueryCustomerSendTaskRequest setGmtCreateStart(String gmtCreateStart) {
        this.gmtCreateStart = gmtCreateStart;
        return this;
    }
    public String getGmtCreateStart() {
        return this.gmtCreateStart;
    }

    public BatchQueryCustomerSendTaskRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public BatchQueryCustomerSendTaskRequest setNeedRichStatistics(Boolean needRichStatistics) {
        this.needRichStatistics = needRichStatistics;
        return this;
    }
    public Boolean getNeedRichStatistics() {
        return this.needRichStatistics;
    }

    public BatchQueryCustomerSendTaskRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public BatchQueryCustomerSendTaskRequest setOpenBatchTaskIds(java.util.List<String> openBatchTaskIds) {
        this.openBatchTaskIds = openBatchTaskIds;
        return this;
    }
    public java.util.List<String> getOpenBatchTaskIds() {
        return this.openBatchTaskIds;
    }

    public BatchQueryCustomerSendTaskRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public BatchQueryCustomerSendTaskRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

}
