// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMembersOfGroupRoleResponseBody extends TeaModel {
    /**
     * <p>userIds</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static QueryMembersOfGroupRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMembersOfGroupRoleResponseBody self = new QueryMembersOfGroupRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMembersOfGroupRoleResponseBody setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
