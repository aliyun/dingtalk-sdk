// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryGroupMemberResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("memberUserIds")
    public java.util.List<String> memberUserIds;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("success")
    public Boolean success;

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

    public BatchQueryGroupMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
