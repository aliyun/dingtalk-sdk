// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskFlowRequest extends TeaModel {
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
     * <p>工作流1</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</p>
     */
    @NameInMap("taskflowIds")
    public String taskflowIds;

    public static SearchTaskFlowRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskFlowRequest self = new SearchTaskFlowRequest();
        return TeaModel.build(map, self);
    }

    public SearchTaskFlowRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchTaskFlowRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchTaskFlowRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

    public SearchTaskFlowRequest setTaskflowIds(String taskflowIds) {
        this.taskflowIds = taskflowIds;
        return this;
    }
    public String getTaskflowIds() {
        return this.taskflowIds;
    }

}
