// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetObjectDataRequest extends TeaModel {
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("name")
    public String name;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("queryDsl")
    public String queryDsl;

    public static GetObjectDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetObjectDataRequest self = new GetObjectDataRequest();
        return TeaModel.build(map, self);
    }

    public GetObjectDataRequest setCurrentOperatorUserId(String currentOperatorUserId) {
        this.currentOperatorUserId = currentOperatorUserId;
        return this;
    }
    public String getCurrentOperatorUserId() {
        return this.currentOperatorUserId;
    }

    public GetObjectDataRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetObjectDataRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetObjectDataRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetObjectDataRequest setQueryDsl(String queryDsl) {
        this.queryDsl = queryDsl;
        return this;
    }
    public String getQueryDsl() {
        return this.queryDsl;
    }

}
