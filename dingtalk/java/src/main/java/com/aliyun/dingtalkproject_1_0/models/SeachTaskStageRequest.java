// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SeachTaskStageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>f279e812xxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>自定义列1</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx</p>
     */
    @NameInMap("taskListId")
    public String taskListId;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</p>
     */
    @NameInMap("taskStageIds")
    public String taskStageIds;

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

    public SeachTaskStageRequest setTaskListId(String taskListId) {
        this.taskListId = taskListId;
        return this;
    }
    public String getTaskListId() {
        return this.taskListId;
    }

    public SeachTaskStageRequest setTaskStageIds(String taskStageIds) {
        this.taskStageIds = taskStageIds;
        return this;
    }
    public String getTaskStageIds() {
        return this.taskStageIds;
    }

}
