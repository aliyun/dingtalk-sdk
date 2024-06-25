// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetContactsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>user01</p>
     */
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>crm_contact</p>
     */
    @NameInMap("objectType")
    public String objectType;

    /**
     * <strong>example:</strong>
     * <p>dingxxx</p>
     */
    @NameInMap("providerCorpId")
    public String providerCorpId;

    /**
     * <strong>example:</strong>
     * <p>{&quot;queryGroupList&quot;:[{&quot;logicType&quot;:&quot;AND&quot;,&quot;queryObjectList&quot;:[{&quot;fieldId&quot;:&quot;contact_phone&quot;,&quot;value&quot;:&quot;18000000000&quot;},{&quot;fieldId&quot;:&quot;contact_related_customer&quot;,&quot;value&quot;:&quot;INST-XXX&quot;}]}]}</p>
     */
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
