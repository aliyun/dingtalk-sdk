// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupAvatarRequest extends TeaModel {
    /**
     * <p>群头像地址。</p>
     */
    @NameInMap("groupAvatar")
    public String groupAvatar;

    /**
     * <p>群会话id。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static UpdateGroupAvatarRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupAvatarRequest self = new UpdateGroupAvatarRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupAvatarRequest setGroupAvatar(String groupAvatar) {
        this.groupAvatar = groupAvatar;
        return this;
    }
    public String getGroupAvatar() {
        return this.groupAvatar;
    }

    public UpdateGroupAvatarRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
