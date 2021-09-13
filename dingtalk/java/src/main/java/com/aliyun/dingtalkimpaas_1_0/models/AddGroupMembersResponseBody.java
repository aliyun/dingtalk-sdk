// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class AddGroupMembersResponseBody extends TeaModel {
    @NameInMap("memberUids")
    public java.util.List<String> memberUids;

    public static AddGroupMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddGroupMembersResponseBody self = new AddGroupMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public AddGroupMembersResponseBody setMemberUids(java.util.List<String> memberUids) {
        this.memberUids = memberUids;
        return this;
    }
    public java.util.List<String> getMemberUids() {
        return this.memberUids;
    }

}
