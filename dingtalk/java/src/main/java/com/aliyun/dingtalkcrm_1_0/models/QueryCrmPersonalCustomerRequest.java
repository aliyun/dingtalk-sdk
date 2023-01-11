// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmPersonalCustomerRequest extends TeaModel {
    /**
     * <p>用户ID</p>
     */
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    /**
     * <p>分页条数</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页页码</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>查询条件</p>
     */
    @NameInMap("queryDsl")
    public String queryDsl;

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
