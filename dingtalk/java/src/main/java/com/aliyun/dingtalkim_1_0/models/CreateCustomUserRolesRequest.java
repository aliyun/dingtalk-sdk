// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomUserRolesRequest extends TeaModel {
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

    public static CreateCustomUserRolesRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomUserRolesRequest self = new CreateCustomUserRolesRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomUserRolesRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CreateCustomUserRolesRequest setOpenRoleIds(java.util.List<String> openRoleIds) {
        this.openRoleIds = openRoleIds;
        return this;
    }
    public java.util.List<String> getOpenRoleIds() {
        return this.openRoleIds;
    }

    public CreateCustomUserRolesRequest setTargetUserId(String targetUserId) {
        this.targetUserId = targetUserId;
        return this;
    }
    public String getTargetUserId() {
        return this.targetUserId;
    }

    public CreateCustomUserRolesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
