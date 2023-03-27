// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetUserJoinedProjectResponseBody extends TeaModel {
    /**
     * <p>分页标。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>项目 ID 列表。</p>
     */
    @NameInMap("result")
    public java.util.List<String> result;

    /**
     * <p>总数。</p>
     */
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
