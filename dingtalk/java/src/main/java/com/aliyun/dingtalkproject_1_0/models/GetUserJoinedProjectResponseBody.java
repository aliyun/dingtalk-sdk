// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetUserJoinedProjectResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<String> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static GetUserJoinedProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserJoinedProjectResponseBody self = new GetUserJoinedProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserJoinedProjectResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetUserJoinedProjectResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

    public GetUserJoinedProjectResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

}
