// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryFeedWhiteListRequest extends TeaModel {
    /**
     * <p>用户组织内id（查询该用户是否在白名单列表中）</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryFeedWhiteListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryFeedWhiteListRequest self = new QueryFeedWhiteListRequest();
        return TeaModel.build(map, self);
    }

    public QueryFeedWhiteListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
