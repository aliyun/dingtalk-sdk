// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetMachineUserRequest extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("maxResults")
    public Integer maxResults;

    public static GetMachineUserRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMachineUserRequest self = new GetMachineUserRequest();
        return TeaModel.build(map, self);
    }

    public GetMachineUserRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetMachineUserRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
