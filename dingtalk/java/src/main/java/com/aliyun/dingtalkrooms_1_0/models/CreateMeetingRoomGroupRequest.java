// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomGroupRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>测试分组</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>172</p>
     */
    @NameInMap("parentGroupId")
    public Long parentGroupId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
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
