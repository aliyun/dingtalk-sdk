// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateTheGroupRolesOfGroupMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidXXXXXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openRoleIds")
    public java.util.List<String> openRoleIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateTheGroupRolesOfGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTheGroupRolesOfGroupMemberRequest self = new UpdateTheGroupRolesOfGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setOpenRoleIds(java.util.List<String> openRoleIds) {
        this.openRoleIds = openRoleIds;
        return this;
    }
    public java.util.List<String> getOpenRoleIds() {
        return this.openRoleIds;
    }

    public UpdateTheGroupRolesOfGroupMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
