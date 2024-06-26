// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberGroupNickRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupNick")
    public String groupNick;

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
    @NameInMap("userId")
    public String userId;

    public static UpdateMemberGroupNickRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberGroupNickRequest self = new UpdateMemberGroupNickRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMemberGroupNickRequest setGroupNick(String groupNick) {
        this.groupNick = groupNick;
        return this;
    }
    public String getGroupNick() {
        return this.groupNick;
    }

    public UpdateMemberGroupNickRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateMemberGroupNickRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
