// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmPersonalCustomerRequest extends TeaModel {
    // 用户ID
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    // 分页页码
    @NameInMap("nextToken")
    public String nextToken;

    // 分页条数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 查询条件
    @NameInMap("queryDsl")
    public String queryDsl;

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

    public QueryCrmPersonalCustomerRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCrmPersonalCustomerRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryCrmPersonalCustomerRequest setQueryDsl(String queryDsl) {
        this.queryDsl = queryDsl;
        return this;
    }
    public String getQueryDsl() {
        return this.queryDsl;
    }

}
