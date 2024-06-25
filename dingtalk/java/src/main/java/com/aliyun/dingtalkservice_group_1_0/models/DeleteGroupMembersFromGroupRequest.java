// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupMembersFromGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>GROUP：从群中删除；GROUP_SET：从群组中删除</p>
     */
    @NameInMap("deleteGroupType")
    public String deleteGroupType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8888</p>
     */
    @NameInMap("memberUnionId")
    public String memberUnionId;

    /**
     * <strong>example:</strong>
     * <p>cid**</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>8888</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8888</p>
     */
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
