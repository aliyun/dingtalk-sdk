// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskflowStatusRequest extends TeaModel {
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
     * <p>未开始</p>
     */
    @NameInMap("query")
    public String query;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</p>
     */
    @NameInMap("tfIds")
    public String tfIds;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</p>
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
