// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetUserJoinedProjectRequest extends TeaModel {
    /**
     * <p>分页大小。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页标。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static GetUserJoinedProjectRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserJoinedProjectRequest self = new GetUserJoinedProjectRequest();
        return TeaModel.build(map, self);
    }

    public GetUserJoinedProjectRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetUserJoinedProjectRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
