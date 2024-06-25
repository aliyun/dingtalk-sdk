// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChatSubAdminUpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidVwhmrlxsR3sL3+JdH1LjUA==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("role")
    public Integer role;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static ChatSubAdminUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatSubAdminUpdateRequest self = new ChatSubAdminUpdateRequest();
        return TeaModel.build(map, self);
    }

    public ChatSubAdminUpdateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public ChatSubAdminUpdateRequest setRole(Integer role) {
        this.role = role;
        return this;
    }
    public Integer getRole() {
        return this.role;
    }

    public ChatSubAdminUpdateRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
