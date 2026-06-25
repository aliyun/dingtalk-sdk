// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotInstanceInGroupInfoResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    public static QueryRobotInstanceInGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotInstanceInGroupInfoResponseBody self = new QueryRobotInstanceInGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRobotInstanceInGroupInfoResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryRobotInstanceInGroupInfoResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryRobotInstanceInGroupInfoResponseBody setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

}
