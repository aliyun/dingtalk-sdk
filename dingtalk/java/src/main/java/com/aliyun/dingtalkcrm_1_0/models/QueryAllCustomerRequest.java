// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllCustomerRequest extends TeaModel {
    /**
     * <p>翻页size</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>分页游标，第一次调用传空或者null</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>数据类型（私海个人客户：crm_customer_personal，私海企业客户：crm_customer，公海个人客户：open_customer_personal，公海企业客户：open_customer_org）</p>
     */
    @NameInMap("objectType")
    public String objectType;

    /**
     * <p>用户ID</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static QueryAllCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllCustomerRequest self = new QueryAllCustomerRequest();
        return TeaModel.build(map, self);
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

    public QueryAllCustomerRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
