// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskflowStatusRequest extends TeaModel {
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
     * <p>模糊查询工作流状态名字。</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <p>工作流ID集合，多个以逗号隔开。</p>
     */
    @NameInMap("tfIds")
    public String tfIds;

    /**
     * <p>工作流状态ID集合，多个以逗号隔开。</p>
     */
    @NameInMap("tfsIds")
    public String tfsIds;

    public static SearchTaskflowStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskflowStatusRequest self = new SearchTaskflowStatusRequest();
        return TeaModel.build(map, self);
    }

    public SearchTaskflowStatusRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchTaskflowStatusRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchTaskflowStatusRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

    public SearchTaskflowStatusRequest setTfIds(String tfIds) {
        this.tfIds = tfIds;
        return this;
    }
    public String getTfIds() {
        return this.tfIds;
    }

    public SearchTaskflowStatusRequest setTfsIds(String tfsIds) {
        this.tfsIds = tfsIds;
        return this;
    }
    public String getTfsIds() {
        return this.tfsIds;
    }

}
