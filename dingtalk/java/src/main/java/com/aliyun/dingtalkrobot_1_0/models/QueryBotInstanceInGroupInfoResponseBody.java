// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryBotInstanceInGroupInfoResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    public static QueryBotInstanceInGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBotInstanceInGroupInfoResponseBody self = new QueryBotInstanceInGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBotInstanceInGroupInfoResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryBotInstanceInGroupInfoResponseBody setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

}
