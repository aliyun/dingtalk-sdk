// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToServiceGroupRequest extends TeaModel {
    /**
     * <p>钉群ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>服务群团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>员工在钉钉组织内的工号</p>
     */
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
