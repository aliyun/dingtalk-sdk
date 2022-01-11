// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMembersOfGroupRoleRequest extends TeaModel {
    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 开放群角色id
    @NameInMap("openRoleId")
    public String openRoleId;

    // 时间戳
    @NameInMap("timestamp")
    public Long timestamp;

    public static QueryMembersOfGroupRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMembersOfGroupRoleRequest self = new QueryMembersOfGroupRoleRequest();
        return TeaModel.build(map, self);
    }

    public QueryMembersOfGroupRoleRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryMembersOfGroupRoleRequest setOpenRoleId(String openRoleId) {
        this.openRoleId = openRoleId;
        return this;
    }
    public String getOpenRoleId() {
        return this.openRoleId;
    }

    public QueryMembersOfGroupRoleRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

}
