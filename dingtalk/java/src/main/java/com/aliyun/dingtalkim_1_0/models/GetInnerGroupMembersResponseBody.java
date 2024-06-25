// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetInnerGroupMembersResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>UZr*****</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

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
