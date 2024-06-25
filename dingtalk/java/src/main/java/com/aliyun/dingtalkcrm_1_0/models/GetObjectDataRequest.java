// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetObjectDataRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding_userid</p>
     */
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-EF199CCA-8AB6-482A-AE10-85EDE5E391D9</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>{&quot;queryGroupList&quot;:[{&quot;logicType&quot;:&quot;AND&quot;,&quot;queryObjectList&quot;:[{&quot;fieldId&quot;:&quot;contact_phone&quot;,&quot;value&quot;:&quot;18000000000&quot;},{&quot;fieldId&quot;:&quot;contact_related_customer&quot;,&quot;value&quot;:&quot;INST-XXX&quot;}]}]}</p>
     */
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
