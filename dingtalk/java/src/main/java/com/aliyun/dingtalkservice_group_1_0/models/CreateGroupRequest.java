// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupRequest extends TeaModel {
    // 业务关联id
    @NameInMap("groupBizId")
    public String groupBizId;

    // 群名称
    @NameInMap("groupName")
    public String groupName;

    // 群标签
    @NameInMap("groupTagNames")
    public java.util.List<String> groupTagNames;

    // 群成员员工ID列表
    @NameInMap("memberStaffIds")
    public java.util.List<String> memberStaffIds;

    // 开放群组ID
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 群主员工ID
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
