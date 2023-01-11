// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTracksRequest extends TeaModel {
    /**
     * <p>分页size</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>排序</p>
     */
    @NameInMap("order")
    public String order;

    public static QueryAllTracksRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTracksRequest self = new QueryAllTracksRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllTracksRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryAllTracksRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAllTracksRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

}
