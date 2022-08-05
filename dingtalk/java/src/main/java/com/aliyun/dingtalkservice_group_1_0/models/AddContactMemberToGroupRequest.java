// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddContactMemberToGroupRequest extends TeaModel {
    // 员工unionId
    @NameInMap("memberUnionId")
    public String memberUnionId;

    // 员工成员ID
    @NameInMap("memberUserId")
    public String memberUserId;

    // 群会话ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static AddContactMemberToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddContactMemberToGroupRequest self = new AddContactMemberToGroupRequest();
        return TeaModel.build(map, self);
    }

    public AddContactMemberToGroupRequest setMemberUnionId(String memberUnionId) {
        this.memberUnionId = memberUnionId;
        return this;
    }
    public String getMemberUnionId() {
        return this.memberUnionId;
    }

    public AddContactMemberToGroupRequest setMemberUserId(String memberUserId) {
        this.memberUserId = memberUserId;
        return this;
    }
    public String getMemberUserId() {
        return this.memberUserId;
    }

    public AddContactMemberToGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public AddContactMemberToGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
