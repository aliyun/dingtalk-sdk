// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryRecentConversationsRequest extends TeaModel {
    @NameInMap("onlyHuman")
    public Boolean onlyHuman;

    @NameInMap("onlyInnerGroup")
    public Boolean onlyInnerGroup;

    @NameInMap("userId")
    public String userId;

    public static QueryRecentConversationsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentConversationsRequest self = new QueryRecentConversationsRequest();
        return TeaModel.build(map, self);
    }

    public QueryRecentConversationsRequest setOnlyHuman(Boolean onlyHuman) {
        this.onlyHuman = onlyHuman;
        return this;
    }
    public Boolean getOnlyHuman() {
        return this.onlyHuman;
    }

    public QueryRecentConversationsRequest setOnlyInnerGroup(Boolean onlyInnerGroup) {
        this.onlyInnerGroup = onlyInnerGroup;
        return this;
    }
    public Boolean getOnlyInnerGroup() {
        return this.onlyInnerGroup;
    }

    public QueryRecentConversationsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
