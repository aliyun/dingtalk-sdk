// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSubAdminRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidXXXXXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("role")
    public Long role;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static UpdateGroupSubAdminRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSubAdminRequest self = new UpdateGroupSubAdminRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSubAdminRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateGroupSubAdminRequest setRole(Long role) {
        this.role = role;
        return this;
    }
    public Long getRole() {
        return this.role;
    }

    public UpdateGroupSubAdminRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
