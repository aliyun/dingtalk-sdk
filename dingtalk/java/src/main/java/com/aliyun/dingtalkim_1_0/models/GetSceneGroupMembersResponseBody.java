// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupMembersResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>cidXXXXXXXXX==</p>
     */
    @NameInMap("memberUserIds")
    public java.util.List<String> memberUserIds;

    /**
     * <strong>example:</strong>
     * <p>92233720368</p>
     */
    @NameInMap("nextCursor")
    public String nextCursor;

    @NameInMap("success")
    public Boolean success;

    public static GetSceneGroupMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupMembersResponseBody self = new GetSceneGroupMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupMembersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetSceneGroupMembersResponseBody setMemberUserIds(java.util.List<String> memberUserIds) {
        this.memberUserIds = memberUserIds;
        return this;
    }
    public java.util.List<String> getMemberUserIds() {
        return this.memberUserIds;
    }

    public GetSceneGroupMembersResponseBody setNextCursor(String nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public String getNextCursor() {
        return this.nextCursor;
    }

    public GetSceneGroupMembersResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
