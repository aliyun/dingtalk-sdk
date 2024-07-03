// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleUpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openRoleId")
    public String openRoleId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roleName")
    public String roleName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static OpenGroupRoleUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleUpdateRequest self = new OpenGroupRoleUpdateRequest();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleUpdateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public OpenGroupRoleUpdateRequest setOpenRoleId(String openRoleId) {
        this.openRoleId = openRoleId;
        return this;
    }
    public String getOpenRoleId() {
        return this.openRoleId;
    }

    public OpenGroupRoleUpdateRequest setRoleName(String roleName) {
        this.roleName = roleName;
        return this;
    }
    public String getRoleName() {
        return this.roleName;
    }

    public OpenGroupRoleUpdateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
