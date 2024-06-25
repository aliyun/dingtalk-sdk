// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskListRequest extends TeaModel {
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
     * <p>自定义分组1</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</p>
     */
    @NameInMap("taskListIds")
    public String taskListIds;

    public static SearchTaskListRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskListRequest self = new SearchTaskListRequest();
        return TeaModel.build(map, self);
    }

    public SearchTaskListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchTaskListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchTaskListRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

    public SearchTaskListRequest setTaskListIds(String taskListIds) {
        this.taskListIds = taskListIds;
        return this;
    }
    public String getTaskListIds() {
        return this.taskListIds;
    }

}
