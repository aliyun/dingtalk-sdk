// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetUserJoinedProjectResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812xxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<String> result;

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

}
