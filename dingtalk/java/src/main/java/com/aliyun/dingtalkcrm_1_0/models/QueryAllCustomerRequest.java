// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllCustomerRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // 用户ID
    @NameInMap("operatorUserId")
    public String operatorUserId;

    // 翻页size
    @NameInMap("maxResults")
    public Long maxResults;

    // 分页游标，第一次调用传空或者null
    @NameInMap("nextToken")
    public String nextToken;

    // 数据类型
    @NameInMap("objectType")
    public String objectType;

    public static QueryAllCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllCustomerRequest self = new QueryAllCustomerRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllCustomerRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public QueryAllCustomerRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public QueryAllCustomerRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public QueryAllCustomerRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public QueryAllCustomerRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public QueryAllCustomerRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public QueryAllCustomerRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryAllCustomerRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAllCustomerRequest setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

}
