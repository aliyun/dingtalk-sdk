// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchAllTasksByTqlRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("tql")
    public String tql;

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

}
