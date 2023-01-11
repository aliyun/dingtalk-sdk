// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetATManageScopeRequest extends TeaModel {
    /**
     * <p>单次查询条数，最大200。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页游标。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>查询用户userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetATManageScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetATManageScopeRequest self = new GetATManageScopeRequest();
        return TeaModel.build(map, self);
    }

    public GetATManageScopeRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetATManageScopeRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetATManageScopeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
