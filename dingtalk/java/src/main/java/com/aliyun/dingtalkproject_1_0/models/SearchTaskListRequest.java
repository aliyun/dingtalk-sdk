// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskListRequest extends TeaModel {
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
     * <p>模糊任务分组名字。</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <p>任务分组ID集合，逗号组合。</p>
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
