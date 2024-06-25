// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchAllTasksByTqlRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>DXF1ZXJ5QW5kRmV0Y2gBAAAAAAKC9p4WVjNKbUstaldRX3lOOHNBbElzcjA5Zw==</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>isDone = false</p>
     */
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
