// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetContactsRequest extends TeaModel {
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("objectType")
    public String objectType;

    @NameInMap("providerCorpId")
    public String providerCorpId;

    @NameInMap("queryDsl")
    public String queryDsl;

    public static GetContactsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContactsRequest self = new GetContactsRequest();
        return TeaModel.build(map, self);
    }

    public GetContactsRequest setCurrentOperatorUserId(String currentOperatorUserId) {
        this.currentOperatorUserId = currentOperatorUserId;
        return this;
    }
    public String getCurrentOperatorUserId() {
        return this.currentOperatorUserId;
    }

    public GetContactsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetContactsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetContactsRequest setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public GetContactsRequest setProviderCorpId(String providerCorpId) {
        this.providerCorpId = providerCorpId;
        return this;
    }
    public String getProviderCorpId() {
        return this.providerCorpId;
    }

    public GetContactsRequest setQueryDsl(String queryDsl) {
        this.queryDsl = queryDsl;
        return this;
    }
    public String getQueryDsl() {
        return this.queryDsl;
    }

}
