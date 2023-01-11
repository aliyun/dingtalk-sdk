// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQuerySendMessageTaskRequest extends TeaModel {
    /**
     * <p>是否获取群发任务已读数量，默认false</p>
     */
    @NameInMap("getReadCount")
    public Boolean getReadCount;

    /**
     * <p>任务查询结束时间</p>
     */
    @NameInMap("gmtCreateEnd")
    public String gmtCreateEnd;

    /**
     * <p>任务查询开始时间</p>
     */
    @NameInMap("gmtCreateStart")
    public String gmtCreateStart;

    /**
     * <p>每页条数</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开放群组ID，在服务群-群组- ID信息中获取</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>任务名称</p>
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
