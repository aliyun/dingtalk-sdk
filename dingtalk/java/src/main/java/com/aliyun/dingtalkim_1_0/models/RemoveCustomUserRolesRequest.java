// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveCustomUserRolesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openRoleIds")
    public java.util.List<String> openRoleIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetUserId")
    public String targetUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RemoveCustomUserRolesRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveCustomUserRolesRequest self = new RemoveCustomUserRolesRequest();
        return TeaModel.build(map, self);
    }

    public RemoveCustomUserRolesRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RemoveCustomUserRolesRequest setOpenRoleIds(java.util.List<String> openRoleIds) {
        this.openRoleIds = openRoleIds;
        return this;
    }
    public java.util.List<String> getOpenRoleIds() {
        return this.openRoleIds;
    }

    public RemoveCustomUserRolesRequest setTargetUserId(String targetUserId) {
        this.targetUserId = targetUserId;
        return this;
    }
    public String getTargetUserId() {
        return this.targetUserId;
    }

    public RemoveCustomUserRolesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
