// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchAllTasksByTqlRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("tql")
    public String tql;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0517xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SearchAllTasksByTqlRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchAllTasksByTqlRequest self = new SearchAllTasksByTqlRequest();
        return TeaModel.build(map, self);
    }

    public SearchAllTasksByTqlRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchAllTasksByTqlRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchAllTasksByTqlRequest setTql(String tql) {
        this.tql = tql;
        return this;
    }
    public String getTql() {
        return this.tql;
    }

    public SearchAllTasksByTqlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
