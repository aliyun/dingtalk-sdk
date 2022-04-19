// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchQuerySendMessageTaskRequest extends TeaModel {
    // 是否获取群发任务已读数量，默认false
    @NameInMap("getReadCount")
    public Boolean getReadCount;

    // 任务查询结束时间
    @NameInMap("gmtCreateEnd")
    public String gmtCreateEnd;

    // 任务查询开始时间
    @NameInMap("gmtCreateStart")
    public String gmtCreateStart;

    // 每页条数
    @NameInMap("maxResults")
    public Long maxResults;

    // 游标
    @NameInMap("nextToken")
    public String nextToken;

    // 开放群组ID，在服务群-群组- ID信息中获取
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 任务名称
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
