// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupNameRequest extends TeaModel {
    // 群名称
    @NameInMap("groupName")
    public String groupName;

    // 群会话id
    @NameInMap("openConversationId")
    public String openConversationId;

    public static UpdateGroupNameRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupNameRequest self = new UpdateGroupNameRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupNameRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public UpdateGroupNameRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
