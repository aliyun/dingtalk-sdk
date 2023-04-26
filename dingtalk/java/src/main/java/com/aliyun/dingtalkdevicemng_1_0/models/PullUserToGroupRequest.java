// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class PullUserToGroupRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static PullUserToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        PullUserToGroupRequest self = new PullUserToGroupRequest();
        return TeaModel.build(map, self);
    }

    public PullUserToGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public PullUserToGroupRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
