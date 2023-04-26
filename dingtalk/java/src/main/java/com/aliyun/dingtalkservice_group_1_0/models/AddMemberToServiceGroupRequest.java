// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToServiceGroupRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static AddMemberToServiceGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddMemberToServiceGroupRequest self = new AddMemberToServiceGroupRequest();
        return TeaModel.build(map, self);
    }

    public AddMemberToServiceGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public AddMemberToServiceGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddMemberToServiceGroupRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
