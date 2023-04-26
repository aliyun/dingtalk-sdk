// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskListRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("query")
    public String query;

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
