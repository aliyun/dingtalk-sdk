// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserGroupRolesRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("userId")
    public String userId;

    @NameInMap("viewedUserId")
    public String viewedUserId;

    public static QueryUserGroupRolesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserGroupRolesRequest self = new QueryUserGroupRolesRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserGroupRolesRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryUserGroupRolesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public QueryUserGroupRolesRequest setViewedUserId(String viewedUserId) {
        this.viewedUserId = viewedUserId;
        return this;
    }
    public String getViewedUserId() {
        return this.viewedUserId;
    }

}
