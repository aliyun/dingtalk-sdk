// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SeachTaskStageRequest extends TeaModel {
    /**
     * <p>每页返回最大数量。默认10，最大300。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页标，从上一次请求结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>任务列表名字。</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <p>任务列表 ID 集合，逗号组合。</p>
     */
    @NameInMap("stageIds")
    public String stageIds;

    /**
     * <p>项目分组ID。</p>
     */
    @NameInMap("taskListId")
    public String taskListId;

    public static SeachTaskStageRequest build(java.util.Map<String, ?> map) throws Exception {
        SeachTaskStageRequest self = new SeachTaskStageRequest();
        return TeaModel.build(map, self);
    }

    public SeachTaskStageRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SeachTaskStageRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SeachTaskStageRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

    public SeachTaskStageRequest setStageIds(String stageIds) {
        this.stageIds = stageIds;
        return this;
    }
    public String getStageIds() {
        return this.stageIds;
    }

    public SeachTaskStageRequest setTaskListId(String taskListId) {
        this.taskListId = taskListId;
        return this;
    }
    public String getTaskListId() {
        return this.taskListId;
    }

}
