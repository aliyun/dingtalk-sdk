// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateMeetingRoomGroupRequest extends TeaModel {
    /**
     * <p>分组id</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <p>分组名称</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateMeetingRoomGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMeetingRoomGroupRequest self = new UpdateMeetingRoomGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMeetingRoomGroupRequest setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

    public UpdateMeetingRoomGroupRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public UpdateMeetingRoomGroupRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
