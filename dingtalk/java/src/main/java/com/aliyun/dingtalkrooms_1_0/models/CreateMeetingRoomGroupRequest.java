// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomGroupRequest extends TeaModel {
    // 分组名称
    @NameInMap("groupName")
    public String groupName;

    // 父分组id
    @NameInMap("parentGroupId")
    public Long parentGroupId;

    // 操作人unionId
    @NameInMap("unionId")
    public String unionId;

    public static CreateMeetingRoomGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomGroupRequest self = new CreateMeetingRoomGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateMeetingRoomGroupRequest setParentGroupId(Long parentGroupId) {
        this.parentGroupId = parentGroupId;
        return this;
    }
    public Long getParentGroupId() {
        return this.parentGroupId;
    }

    public CreateMeetingRoomGroupRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
