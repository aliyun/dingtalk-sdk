// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddContactMemberToGroupRequest extends TeaModel {
    @NameInMap("fissionType")
    public String fissionType;

    @NameInMap("memberUnionId")
    public String memberUnionId;

    @NameInMap("memberUserId")
    public String memberUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static AddContactMemberToGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        AddContactMemberToGroupRequest self = new AddContactMemberToGroupRequest();
        return TeaModel.build(map, self);
    }

    public AddContactMemberToGroupRequest setFissionType(String fissionType) {
        this.fissionType = fissionType;
        return this;
    }
    public String getFissionType() {
        return this.fissionType;
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
