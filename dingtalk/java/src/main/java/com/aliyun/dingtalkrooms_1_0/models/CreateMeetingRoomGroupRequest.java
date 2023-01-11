// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomGroupRequest extends TeaModel {
    /**
     * <p>分组名称</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>父分组id</p>
     */
    @NameInMap("parentGroupId")
    public Long parentGroupId;

    /**
     * <p>操作人unionId</p>
     */
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
