// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmPersonalCustomerRequest extends TeaModel {
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("queryDsl")
    public String queryDsl;

    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("relationType")
    public String relationType;

    public static QueryCrmPersonalCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmPersonalCustomerRequest self = new QueryCrmPersonalCustomerRequest();
        return TeaModel.build(map, self);
    }

    public QueryCrmPersonalCustomerRequest setCurrentOperatorUserId(String currentOperatorUserId) {
        this.currentOperatorUserId = currentOperatorUserId;
        return this;
    }
    public String getCurrentOperatorUserId() {
        return this.currentOperatorUserId;
    }

    public QueryCrmPersonalCustomerRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryCrmPersonalCustomerRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCrmPersonalCustomerRequest setQueryDsl(String queryDsl) {
        this.queryDsl = queryDsl;
        return this;
    }
    public String getQueryDsl() {
        return this.queryDsl;
    }

    public QueryCrmPersonalCustomerRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
