// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetAllCustomerRecyclesRequest extends TeaModel {
    // 每页返回的结果集个数，默认10。
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static GetAllCustomerRecyclesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAllCustomerRecyclesRequest self = new GetAllCustomerRecyclesRequest();
        return TeaModel.build(map, self);
    }

    public GetAllCustomerRecyclesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetAllCustomerRecyclesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
