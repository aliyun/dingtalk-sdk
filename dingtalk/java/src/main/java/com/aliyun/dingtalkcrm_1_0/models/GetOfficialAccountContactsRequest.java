// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123567</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static GetOfficialAccountContactsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactsRequest self = new GetOfficialAccountContactsRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetOfficialAccountContactsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
