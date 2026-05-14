// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddSceneGroupMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxxxx==</p>
     */
    @NameInMap("open_conversation_id")
    public String openConversationId;

    @NameInMap("union_ids")
    public java.util.List<String> unionIds;

    @NameInMap("user_ids")
    public java.util.List<String> userIds;

    public static AddSceneGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddSceneGroupMemberRequest self = new AddSceneGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public AddSceneGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public AddSceneGroupMemberRequest setUnionIds(java.util.List<String> unionIds) {
        this.unionIds = unionIds;
        return this;
    }
    public java.util.List<String> getUnionIds() {
        return this.unionIds;
    }

    public AddSceneGroupMemberRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
