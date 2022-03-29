// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupRequest extends TeaModel {
    // 群名称
    @NameInMap("groupName")
    public String groupName;

    // 群成员id
    @NameInMap("memberUserIds")
    public String memberUserIds;

    // 群主id
    @NameInMap("ownerUserId")
    public String ownerUserId;

    // 关系类型
    @NameInMap("relationType")
    public String relationType;

    public static CreateGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupRequest self = new CreateGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateGroupRequest setMemberUserIds(String memberUserIds) {
        this.memberUserIds = memberUserIds;
        return this;
    }
    public String getMemberUserIds() {
        return this.memberUserIds;
    }

    public CreateGroupRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public CreateGroupRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
