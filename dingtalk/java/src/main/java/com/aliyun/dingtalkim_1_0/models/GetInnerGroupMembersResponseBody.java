// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetInnerGroupMembersResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据。</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下一次请求的游标，若没有更多数据，则此参数为空。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>群成员userId列表。</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetInnerGroupMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInnerGroupMembersResponseBody self = new GetInnerGroupMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInnerGroupMembersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetInnerGroupMembersResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetInnerGroupMembersResponseBody setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
