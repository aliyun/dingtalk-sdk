// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomGroupRolesByUserRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("viewedUserId")
    public String viewedUserId;

    public static QueryCustomGroupRolesByUserRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomGroupRolesByUserRequest self = new QueryCustomGroupRolesByUserRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomGroupRolesByUserRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryCustomGroupRolesByUserRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public QueryCustomGroupRolesByUserRequest setViewedUserId(String viewedUserId) {
        this.viewedUserId = viewedUserId;
        return this;
    }
    public String getViewedUserId() {
        return this.viewedUserId;
    }

}
