// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTracksRequest extends TeaModel {
    // 分页游标
    @NameInMap("nextToken")
    public String nextToken;

    // 分页size
    @NameInMap("maxResults")
    public Integer maxResults;

    // 排序
    @NameInMap("order")
    public String order;

    public static QueryAllTracksRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTracksRequest self = new QueryAllTracksRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllTracksRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAllTracksRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryAllTracksRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

}
