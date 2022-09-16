// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceMembersRequest extends TeaModel {
    // 返回的最大结果数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页token
    @NameInMap("nextToken")
    public String nextToken;

    public static QueryConferenceMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceMembersRequest self = new QueryConferenceMembersRequest();
        return TeaModel.build(map, self);
    }

    public QueryConferenceMembersRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryConferenceMembersRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
