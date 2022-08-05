// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupMembersFromGroupRequest extends TeaModel {
    // 删除类型
    @NameInMap("deleteGroupType")
    public String deleteGroupType;

    // 群成员unionId
    @NameInMap("memberUnionId")
    public String memberUnionId;

    // 会话ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 开放群组ID
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static DeleteGroupMembersFromGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupMembersFromGroupRequest self = new DeleteGroupMembersFromGroupRequest();
        return TeaModel.build(map, self);
    }

    public DeleteGroupMembersFromGroupRequest setDeleteGroupType(String deleteGroupType) {
        this.deleteGroupType = deleteGroupType;
        return this;
    }
    public String getDeleteGroupType() {
        return this.deleteGroupType;
    }

    public DeleteGroupMembersFromGroupRequest setMemberUnionId(String memberUnionId) {
        this.memberUnionId = memberUnionId;
        return this;
    }
    public String getMemberUnionId() {
        return this.memberUnionId;
    }

    public DeleteGroupMembersFromGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public DeleteGroupMembersFromGroupRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public DeleteGroupMembersFromGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
