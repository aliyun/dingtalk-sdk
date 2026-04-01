// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryGroupMemberResponseBody extends TeaModel {
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
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("staffIdNickMap")
    public java.util.Map<String, String> staffIdNickMap;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("unionIdList")
    public java.util.List<String> unionIdList;

    @NameInMap("unionIdNickMap")
    public java.util.Map<String, String> unionIdNickMap;

    public static BatchQueryGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryGroupMemberResponseBody self = new BatchQueryGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryGroupMemberResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public BatchQueryGroupMemberResponseBody setMemberUserIds(java.util.List<String> memberUserIds) {
        this.memberUserIds = memberUserIds;
        return this;
    }
    public java.util.List<String> getMemberUserIds() {
        return this.memberUserIds;
    }

    public BatchQueryGroupMemberResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public BatchQueryGroupMemberResponseBody setStaffIdNickMap(java.util.Map<String, String> staffIdNickMap) {
        this.staffIdNickMap = staffIdNickMap;
        return this;
    }
    public java.util.Map<String, String> getStaffIdNickMap() {
        return this.staffIdNickMap;
    }

    public BatchQueryGroupMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public BatchQueryGroupMemberResponseBody setUnionIdList(java.util.List<String> unionIdList) {
        this.unionIdList = unionIdList;
        return this;
    }
    public java.util.List<String> getUnionIdList() {
        return this.unionIdList;
    }

    public BatchQueryGroupMemberResponseBody setUnionIdNickMap(java.util.Map<String, String> unionIdNickMap) {
        this.unionIdNickMap = unionIdNickMap;
        return this;
    }
    public java.util.Map<String, String> getUnionIdNickMap() {
        return this.unionIdNickMap;
    }

}
