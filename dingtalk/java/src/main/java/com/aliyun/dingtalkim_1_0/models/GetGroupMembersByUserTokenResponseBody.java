// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetGroupMembersByUserTokenResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("memberUnionIds")
    public java.util.List<String> memberUnionIds;

    @NameInMap("memberUserIds")
    public java.util.List<String> memberUserIds;

    /**
     * <strong>example:</strong>
     * <p>92233720368</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("staffIdNickMap")
    public java.util.Map<String, String> staffIdNickMap;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("unionIdNickMap")
    public java.util.Map<String, String> unionIdNickMap;

    public static GetGroupMembersByUserTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetGroupMembersByUserTokenResponseBody self = new GetGroupMembersByUserTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetGroupMembersByUserTokenResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetGroupMembersByUserTokenResponseBody setMemberUnionIds(java.util.List<String> memberUnionIds) {
        this.memberUnionIds = memberUnionIds;
        return this;
    }
    public java.util.List<String> getMemberUnionIds() {
        return this.memberUnionIds;
    }

    public GetGroupMembersByUserTokenResponseBody setMemberUserIds(java.util.List<String> memberUserIds) {
        this.memberUserIds = memberUserIds;
        return this;
    }
    public java.util.List<String> getMemberUserIds() {
        return this.memberUserIds;
    }

    public GetGroupMembersByUserTokenResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetGroupMembersByUserTokenResponseBody setStaffIdNickMap(java.util.Map<String, String> staffIdNickMap) {
        this.staffIdNickMap = staffIdNickMap;
        return this;
    }
    public java.util.Map<String, String> getStaffIdNickMap() {
        return this.staffIdNickMap;
    }

    public GetGroupMembersByUserTokenResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public GetGroupMembersByUserTokenResponseBody setUnionIdNickMap(java.util.Map<String, String> unionIdNickMap) {
        this.unionIdNickMap = unionIdNickMap;
        return this;
    }
    public java.util.Map<String, String> getUnionIdNickMap() {
        return this.unionIdNickMap;
    }

}
