// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupMembersResponseBody extends TeaModel {
    // 是否还有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 群成员员工号
    @NameInMap("memberUserIds")
    public java.util.List<String> memberUserIds;

    // 下一次请求的游标
    @NameInMap("nextCursor")
    public String nextCursor;

    // result
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
