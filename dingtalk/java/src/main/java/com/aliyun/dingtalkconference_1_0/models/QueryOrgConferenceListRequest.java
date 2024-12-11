// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgConferenceListRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static QueryOrgConferenceListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgConferenceListRequest self = new QueryOrgConferenceListRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgConferenceListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryOrgConferenceListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
