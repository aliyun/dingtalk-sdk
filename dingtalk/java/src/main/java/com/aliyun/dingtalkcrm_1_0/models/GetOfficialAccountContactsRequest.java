// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactsRequest extends TeaModel {
    // 取数游标，第一次传0
    @NameInMap("nextToken")
    public String nextToken;

    // 分页大小，最大不超过10
    @NameInMap("maxResults")
    public Long maxResults;

    public static GetOfficialAccountContactsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactsRequest self = new GetOfficialAccountContactsRequest();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetOfficialAccountContactsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

}
