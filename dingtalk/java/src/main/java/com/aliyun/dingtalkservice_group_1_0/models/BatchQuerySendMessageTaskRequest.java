// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQuerySendMessageTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("getReadCount")
    public Boolean getReadCount;

    /**
     * <strong>example:</strong>
     * <p>2022-04-02 00:00:00</p>
     */
    @NameInMap("gmtCreateEnd")
    public String gmtCreateEnd;

    /**
     * <strong>example:</strong>
     * <p>2022-04-01 00:00:00</p>
     */
    @NameInMap("gmtCreateStart")
    public String gmtCreateStart;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>首页传递空</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>fwPuycdHiiI</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Jciwnfw</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>群发任务双11</p>
     */
    @NameInMap("taskName")
    public String taskName;

    public static BatchQuerySendMessageTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQuerySendMessageTaskRequest self = new BatchQuerySendMessageTaskRequest();
        return TeaModel.build(map, self);
    }

    public BatchQuerySendMessageTaskRequest setGetReadCount(Boolean getReadCount) {
        this.getReadCount = getReadCount;
        return this;
    }
    public Boolean getGetReadCount() {
        return this.getReadCount;
    }

    public BatchQuerySendMessageTaskRequest setGmtCreateEnd(String gmtCreateEnd) {
        this.gmtCreateEnd = gmtCreateEnd;
        return this;
    }
    public String getGmtCreateEnd() {
        return this.gmtCreateEnd;
    }

    public BatchQuerySendMessageTaskRequest setGmtCreateStart(String gmtCreateStart) {
        this.gmtCreateStart = gmtCreateStart;
        return this;
    }
    public String getGmtCreateStart() {
        return this.gmtCreateStart;
    }

    public BatchQuerySendMessageTaskRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public BatchQuerySendMessageTaskRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public BatchQuerySendMessageTaskRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public BatchQuerySendMessageTaskRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public BatchQuerySendMessageTaskRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

}
