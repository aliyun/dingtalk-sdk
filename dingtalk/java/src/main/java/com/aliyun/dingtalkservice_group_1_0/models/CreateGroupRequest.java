// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupRequest extends TeaModel {
    @NameInMap("groupBizId")
    public String groupBizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupName")
    public String groupName;

    @NameInMap("groupTagNames")
    public java.util.List<String> groupTagNames;

    @NameInMap("memberStaffIds")
    public java.util.List<String> memberStaffIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ownerStaffId")
    public String ownerStaffId;

    public static CreateGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupRequest self = new CreateGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupRequest setGroupBizId(String groupBizId) {
        this.groupBizId = groupBizId;
        return this;
    }
    public String getGroupBizId() {
        return this.groupBizId;
    }

    public CreateGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateGroupRequest setGroupTagNames(java.util.List<String> groupTagNames) {
        this.groupTagNames = groupTagNames;
        return this;
    }
    public java.util.List<String> getGroupTagNames() {
        return this.groupTagNames;
    }

    public CreateGroupRequest setMemberStaffIds(java.util.List<String> memberStaffIds) {
        this.memberStaffIds = memberStaffIds;
        return this;
    }
    public java.util.List<String> getMemberStaffIds() {
        return this.memberStaffIds;
    }

    public CreateGroupRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public CreateGroupRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CreateGroupRequest setOwnerStaffId(String ownerStaffId) {
        this.ownerStaffId = ownerStaffId;
        return this;
    }
    public String getOwnerStaffId() {
        return this.ownerStaffId;
    }

}
