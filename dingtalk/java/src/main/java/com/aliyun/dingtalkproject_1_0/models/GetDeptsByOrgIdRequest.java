// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetDeptsByOrgIdRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    public static GetDeptsByOrgIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDeptsByOrgIdRequest self = new GetDeptsByOrgIdRequest();
        return TeaModel.build(map, self);
    }

    public GetDeptsByOrgIdRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetDeptsByOrgIdRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
